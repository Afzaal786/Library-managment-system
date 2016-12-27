using System;
using LMSDataAccessLayer;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Library_Managment_System
{
    /// <summary>
    /// Interaction logic for frmUser.xaml
    /// </summary>
    public partial class frmUser : Window
    {
        USER tobjUser = new USER();
        userFactory objUserFactory = new userFactory();

        public frmUser()
        {
            InitializeComponent();
        }

        private void btnSaveBook_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtUserName.Text) || string.IsNullOrEmpty(txtUserPassword.Password) || string.IsNullOrEmpty(txtConfirmPassword.Password) || string.IsNullOrWhiteSpace(txtUserName.Text))
                {
                    MessageBox.Show("Valid user name, password and confirm password fields are Required.", "Error");
                }
                else
                {
                    int resultName;
                    if (!int.TryParse(txtUserName.Text, out resultName))
                    {
                        tobjUser.userName = txtUserName.Text;
                        if (string.Equals(txtUserPassword.Password, txtConfirmPassword.Password))
                        {
                            tobjUser.userPassword = txtUserPassword.Password;
                            if (objUserFactory.insert(tobjUser))
                            {
                                MessageBox.Show("Record Saved Successfully!", "Success");
                                txtUserName.Clear();
                                txtUserPassword.Clear();
                                txtConfirmPassword.Clear();
                            }
                            else
                                MessageBox.Show("Record cant saved", "Error");
                        }
                        else
                        {
                            MessageBox.Show("Passwords dont match, please type again", "Error");
                            txtUserPassword.Clear();
                            txtConfirmPassword.Clear();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Name cant be a number.", "Error");
                        txtUserName.Clear();
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnViewAllUsers_Click(object sender, RoutedEventArgs e)
        {

            try { 
            List<USER> userList = objUserFactory.getAllUsers();
            dgUser.ItemsSource = userList;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void btnUserSearch_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int resultId;
                if (!string.IsNullOrEmpty(txtSearchUser.Text))
                {
                    bool successfullyParsed = int.TryParse(txtSearchUser.Text, out resultId);
                    if (successfullyParsed)
                    {
                        var result = objUserFactory.getAllUsersById(resultId);
                        if (result.Count() != 0)
                        {
                            dgUser.ItemsSource = result;
                            txtSearchUser.Clear();
                        }
                        else
                        {
                            MessageBox.Show("No record found with given Id", "Error");
                            txtSearchUser.Clear();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Id must be a number.", "Error");
                        txtSearchUser.Clear();
                    }
                }
                else
                    MessageBox.Show("Please enter the Id first.", "Error");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUserDelete_Click(object sender, RoutedEventArgs e)
        {
            try { 
            int resultId;
            if (!string.IsNullOrEmpty(txtGiveId.Text))
            {
                bool successfullyParsed = int.TryParse(txtGiveId.Text, out resultId);
                if (successfullyParsed)
                {
                    if (objUserFactory.delete(resultId))
                    {
                        MessageBox.Show("Record Deleted Successfully.", "Success");
                        txtGiveId.Clear();
                    }
                    else
                    {
                        MessageBox.Show("No record exist with given Id", "Error");
                        txtGiveId.Clear();
                    }
                }
                else
                {
                    MessageBox.Show("Id must be a number.", "Error");
                    txtGiveId.Clear();
                }
            }
            else
                MessageBox.Show("Please enter the Id first.", "Error");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void btnUserUpdate_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtGiveId.Text) || string.IsNullOrEmpty(txtGiveName.Text) || string.IsNullOrEmpty(txtGivePassword.Password) || string.IsNullOrEmpty(txtGiveConfirmPassword.Password))
                {
                    MessageBox.Show("User Id, name, password and confirm password fields are Required for Updation.", "Error");
                }
                else
                {
                    int resultId,resultName;
                    if(int.TryParse(txtGiveId.Text,out resultId)) 
                    {
                        if (!int.TryParse(txtUserName.Text, out resultName))
                        {
                            if (string.Equals(txtGivePassword.Password, txtGiveConfirmPassword.Password))
                            {
                                if (objUserFactory.update(resultId,txtGiveName.Text,txtGivePassword.Password))
                                {
                                    MessageBox.Show("Record Updated Successfully!", "Success");
                                    txtGiveName.Clear();
                                    txtGivePassword.Clear();
                                    txtGiveConfirmPassword.Clear();
                                    txtGiveId.Clear();
                                }
                                else
                                    MessageBox.Show("No record found against given Id.", "Error");
                            }
                            else
                            {
                                MessageBox.Show("Passwords dont match, please type again", "Error");
                                txtUserPassword.Clear();
                                txtConfirmPassword.Clear();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Name cant be a number.", "Error");
                            txtUserName.Clear();
                        }
                    }
                    else
                        MessageBox.Show("Id must be a number.","Error");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"Error");
            }
            


        }
    }
}

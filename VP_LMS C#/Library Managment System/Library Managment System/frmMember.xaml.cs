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
    /// Interaction logic for frmMember.xaml
    /// </summary>
    public partial class frmMember : Window
    {
        MEMBER tobjMember = new MEMBER();
        memberFactory objMemberFactory = new memberFactory();
        public frmMember()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnMemberSave_Click(object sender, RoutedEventArgs e)
        {

            try
            {
                int result;
                if (string.IsNullOrEmpty(txtMemName.Text) || string.IsNullOrWhiteSpace(txtMemName.Text))
                {
                    MessageBox.Show("Please Enter valid member name.", "Error");
                }
                else
                {
                    if (int.TryParse(txtMemName.Text, out result))
                        MessageBox.Show("Name cant be a number.", "Error");
                    else
                    {
                        tobjMember.memberName = txtMemName.Text;
                        if (!string.IsNullOrEmpty(txtMemCon.Text))
                            tobjMember.memberContact = txtMemCon.Text;
                        if (objMemberFactory.insert(tobjMember))
                        {
                            MessageBox.Show("Record saved successfully!", "Success");
                            txtMemName.Clear();
                            txtMemCon.Clear();
                        }
                        else
                            MessageBox.Show("Record Cant be saved.", "Error");
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                txtMemName.Clear();
                txtMemCon.Clear();
            }

        }

        private void btnViewAllMembers_Click(object sender, RoutedEventArgs e)
        {
            try { 
            List<MEMBER> memberList = objMemberFactory.getAllMembers();
            dgMember.ItemsSource = memberList;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void btnMemberSearch_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int resultId;
                if (!string.IsNullOrEmpty(txtSearchMember.Text))
                {
                    bool successfullyParsed = int.TryParse(txtSearchMember.Text, out resultId);
                    if (successfullyParsed)
                    {
                        var result = objMemberFactory.getAllMembersById(resultId);
                        if (result.Count() != 0)
                        {
                            dgMember.ItemsSource = result;
                            txtSearchMember.Clear();
                        }
                        else
                        {
                            MessageBox.Show("No record found with given Id", "Error");
                            txtSearchMember.Clear();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Id must be a number.", "Error");
                        txtSearchMember.Clear();
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

        private void btnMemberDelete_Click(object sender, RoutedEventArgs e)
        {
            try { 
            int resultId;
            if (!string.IsNullOrEmpty(txtGiveMemId.Text))
            {
                bool successfullyParsed = int.TryParse(txtGiveMemId.Text, out resultId);
                if (successfullyParsed)
                {
                    if (objMemberFactory.delete(resultId))
                    {
                        MessageBox.Show("Record Deleted Successfully.", "Success");
                        txtGiveMemId.Clear();
                    }
                    else
                    {
                        MessageBox.Show("No record exist with given Id", "Error");
                        txtGiveMemId.Clear();
                    }
                }
                else
                {
                    MessageBox.Show("Id must be a number.", "Error");
                    txtGiveMemId.Clear();
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

        private void btnMemberUpdate_Click(object sender, RoutedEventArgs e)
        {
            try { 
            int resultId,resultName;
            if (!string.IsNullOrEmpty(txtGiveMemId.Text))
            {
                bool successfullyParsed = int.TryParse(txtGiveMemId.Text, out resultId);
                if (successfullyParsed)
                {
                    if (!string.IsNullOrEmpty(txtGiveMemName.Text))
                    {
                        if (!int.TryParse(txtGiveMemName.Text, out resultName))
                        {
                            if (objMemberFactory.update(resultId, txtGiveMemName.Text, txtGiveMemContact.Text))
                            {
                                MessageBox.Show("Updated Successfully", "Success");
                                
                            }
                            else
                            {
                                MessageBox.Show("No record exist with given Id.", "Error");
                                txtGiveMemId.Clear();
                            }
                        }
                        else
                            MessageBox.Show("Name cant be a number.", "Error");

                    }
                    else
                    {
                        MessageBox.Show("Please enter the name.", "Error");
                        txtGiveMemName.Clear();
                    }
                }
                else
                {
                    MessageBox.Show("Id must be a number.", "Error");
                    txtSearchMember.Clear();
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
    }
}

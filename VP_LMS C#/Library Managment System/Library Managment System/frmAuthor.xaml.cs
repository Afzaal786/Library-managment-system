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
    /// Interaction logic for frmAuthor.xaml
    /// </summary>
    public partial class frmAuthor : Window
    {
        AUTHOR tobjAuthor = new AUTHOR();
        authorFactory objAuthorFactory = new authorFactory();

        public frmAuthor()
        {
            InitializeComponent();
        }

        private void btnAutClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnAutSave_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int result;
                if (string.IsNullOrEmpty(txtAutName.Text) || string.IsNullOrWhiteSpace(txtAutName.Text))
                {
                    MessageBox.Show("Please enter a valid author name.", "Error");
                }
                else
                {
                    if (int.TryParse(txtAutName.Text, out result))
                        MessageBox.Show("Name cant be a number.", "Error");
                    else
                    {
                        tobjAuthor.authorName = txtAutName.Text;
                        if (!string.IsNullOrEmpty(txtAutContact.Text))
                            tobjAuthor.authorContact = txtAutContact.Text;
                        if (objAuthorFactory.insert(tobjAuthor))
                        {
                            MessageBox.Show("Record saved successfully!", "Success");
                            txtAutName.Clear();
                            txtAutContact.Clear();
                        }
                        else
                            MessageBox.Show("Record Cant be saved.", "Error");
                    }
                }
               
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                txtAutName.Clear();
                txtAutContact.Clear();
            }
            
        }

        private void btnViewAllAuthors_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                List<AUTHOR> authorList = objAuthorFactory.getAllAuthors();
                dgAuthor.ItemsSource = authorList;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Error");
            }
        }

        private void btnAuthorSearch_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int resultId;
                if (!string.IsNullOrEmpty(txtSearchAuthor.Text))
                {
                    bool successfullyParsed = int.TryParse(txtSearchAuthor.Text, out resultId);
                    if (successfullyParsed)
                    {
                        var result = objAuthorFactory.getAllAuthorsById(resultId);
                        if (result.Count() != 0)
                        {
                            dgAuthor.ItemsSource = result;
                            txtSearchAuthor.Clear();
                        }
                        else
                        {
                            MessageBox.Show("No record found with given Id", "Error");
                            txtSearchAuthor.Clear();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Id must be a number.", "Error");
                        txtSearchAuthor.Clear();
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

        private void btnAuthorDelete_Click(object sender, RoutedEventArgs e)
        {
            try { 
            int resultId;
            if (!string.IsNullOrEmpty(txtGiveId.Text))
            {
                bool successfullyParsed = int.TryParse(txtGiveId.Text, out resultId);
                if (successfullyParsed)
                {
                    if (objAuthorFactory.delete(resultId))
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
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAuthorUpdate_Click(object sender, RoutedEventArgs e)
        {
            try { 
            int resultId,resultName;
            if (!string.IsNullOrEmpty(txtGiveId.Text))
            {
                bool successfullyParsed = int.TryParse(txtGiveId.Text, out resultId);
                if (successfullyParsed)
                {
                    if (!string.IsNullOrEmpty(txtGiveName.Text))
                    {
                        if (!int.TryParse(txtGiveName.Text, out resultName))
                        {
                            if (objAuthorFactory.update(resultId, txtGiveName.Text, txtGiveContact.Text))
                            {
                                MessageBox.Show("Updated Successfully", "Success");
                            }
                            else
                            {
                                MessageBox.Show("No record exist with given Id.", "Error");
                                txtGiveId.Clear();
                            }
                        }
                        else
                            MessageBox.Show("Name cant be number.","Error");
                    }
                    else
                        MessageBox.Show("Please enter the name.","Error");
                }
                else
                {
                    MessageBox.Show("Id must be a number.", "Error");
                    txtSearchAuthor.Clear();
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

        private void btnClearAuthorGrid_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}

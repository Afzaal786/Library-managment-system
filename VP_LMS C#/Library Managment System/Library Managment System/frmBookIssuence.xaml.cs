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
    /// Interaction logic for frmBookIssuence.xaml
    /// </summary>
    public partial class frmBookIssuence : Window
    {
        BOOK_ISSUENCE tobjBookIssuence = new BOOK_ISSUENCE();
        bookIssuenceFactory objBookIssuenceFactory = new bookIssuenceFactory();
        cmbBookFactory objCmbBookFactory = new cmbBookFactory();
        cmbMemberFactory objCmbMemberFactory = new cmbMemberFactory();
        cmbEmployeeFactory objCmbEmployeeFactory = new cmbEmployeeFactory();




        public frmBookIssuence()
        {
            InitializeComponent();
        }

        private void btnBISave_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(dpIssuedOn.Text) || string.IsNullOrEmpty(DpReturnOn.Text) || cmbBookId.SelectedValue == null || cmbMemberId.SelectedValue == null || cmbEmployeeId.SelectedValue == null)
                    MessageBox.Show("All fields are required.", "Error");
                else
                {
                    tobjBookIssuence.bookId = int.Parse(cmbBookId.SelectedValue.ToString());
                    tobjBookIssuence.memberId = int.Parse(cmbMemberId.SelectedValue.ToString());
                    tobjBookIssuence.employeeId = int.Parse(cmbEmployeeId.SelectedValue.ToString());
                    tobjBookIssuence.issuedOn = DateTime.Parse(dpIssuedOn.Text);
                    tobjBookIssuence.returnDate = DateTime.Parse(DpReturnOn.Text);

                    if (objBookIssuenceFactory.insert(tobjBookIssuence))
                        MessageBox.Show("Record Saved Successfully!","Success!");
                    else
                        MessageBox.Show("Unable to save the record.","Error");
                }
                       
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBISearch_Click(object sender, RoutedEventArgs e)
        {
            try { 
            int resultId;
            if (!string.IsNullOrEmpty(txtSearchIssuedBook.Text))
            {
                bool successfullyParsed = int.TryParse(txtSearchIssuedBook.Text, out resultId);
                if (successfullyParsed)
                {
                    var result = objBookIssuenceFactory.getAllIssuedBooksById(resultId);
                    if (result.Count() != 0)
                    {
                        dgIssuedBooks.ItemsSource = result;
                        txtSearchIssuedBook.Clear();
                    }
                    else
                    {
                        MessageBox.Show("No record found with given Id", "Error");
                        txtSearchIssuedBook.Clear();
                    }
                }
                else
                {
                    MessageBox.Show("Id must be a number.", "Error");
                    txtSearchIssuedBook.Clear();
                }
            }
            else
                MessageBox.Show("Please enter the Id first.", "Error");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Error");
            }
        }

        private void btnBookDelete_Click(object sender, RoutedEventArgs e)
        {
            try { 
            int resultId;
            if (!string.IsNullOrEmpty(txtGiveId.Text))
            {
                bool successfullyParsed = int.TryParse(txtGiveId.Text, out resultId);
                if (successfullyParsed)
                {
                    if (objBookIssuenceFactory.delete(resultId))
                    {
                        MessageBox.Show("Deleted Successfully", "Success");
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

        private void btnRecordUpdate_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int resultId;
                if (!string.IsNullOrEmpty(txtGiveId.Text))
                {
                    bool successfullyParsed = int.TryParse(txtGiveId.Text, out resultId);
                    if (successfullyParsed)
                    {
                        if (string.IsNullOrEmpty(dpGiveIssuedOn.Text) && string.IsNullOrEmpty(DpGiveReturnOn.Text))
                            MessageBox.Show("Issued and return date cant be empty.", "Error");
                        else
                        {
                            if (objBookIssuenceFactory.update(resultId, DateTime.Parse(dpGiveIssuedOn.Text), DateTime.Parse(DpGiveReturnOn.Text)))
                            {
                                MessageBox.Show("Updated Successfully", "Success");
                                txtGiveId.Clear();
                            }
                            else
                            {
                                MessageBox.Show("No record found with given Id.", "Error");
                                txtGiveId.Clear();
                            }
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
                MessageBox.Show(ex.Message,"Error");
            }
        }

        private void btnRecordDelete_Click(object sender, RoutedEventArgs e)
        {
            try { 
            int resultId;
            if (!string.IsNullOrEmpty(txtGiveId.Text))
            {
                bool successfullyParsed = int.TryParse(txtGiveId.Text, out resultId);
                if (successfullyParsed)
                {
                    if (objBookIssuenceFactory.delete(resultId))
                    {
                        MessageBox.Show("Deleted Successfully", "Success");
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

        private void btnViewAllBI_Click(object sender, RoutedEventArgs e)
        {
            try { 
            List<BOOK_ISSUENCE> bookList = objBookIssuenceFactory.getAllIssuedBooks();
            dgIssuedBooks.ItemsSource = bookList;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void btnBIClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            List<BOOK> booklist = objCmbBookFactory.getAllEntries();
            List<EMPLOYEE> employeelist = objCmbEmployeeFactory.getAllEntries();
            List<MEMBER> memberlist = objCmbMemberFactory.getAllEntries();

            cmbBookId.ItemsSource = booklist;
            cmbBookId.DisplayMemberPath = "bookName";
            cmbBookId.SelectedValuePath = "bookId";

            cmbEmployeeId.ItemsSource = employeelist;
            cmbEmployeeId.DisplayMemberPath = "employeeName";
            cmbEmployeeId.SelectedValuePath = "employeeId";

            cmbMemberId.ItemsSource = memberlist;
            cmbMemberId.DisplayMemberPath = "memberName";
            cmbMemberId.SelectedValuePath = "memberId";
        }
    }
}

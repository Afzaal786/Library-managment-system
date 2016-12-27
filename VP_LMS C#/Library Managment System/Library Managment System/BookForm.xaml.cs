using System;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using LMSDataAccessLayer;
namespace Library_Managment_System
{
    /// <summary>
    /// Interaction logic for BookForm.xaml
    /// </summary>
    public partial class BookForm : UserControl
    {
        BOOK tobjBook = new BOOK();
        bookFactory objBookFactory = new bookFactory();
        cmbPublisherFactory objCmbPublisherFactory = new cmbPublisherFactory();
        cmbRackFactory objCmbRackFactory = new cmbRackFactory();
        cmbSectionFactory objCmbSectionFactory = new cmbSectionFactory();
        cmbCatagoryFactory objCmbCatagoryFactory = new cmbCatagoryFactory();
        
        public BookForm()
        {
            InitializeComponent();
        }

        private void btnSaveBook_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtBookName.Text))
                {
                    MessageBox.Show("Please Enter Book Name.", "Error");
                }
                else
                {
                    int resultBname;

                    if(!int.TryParse(txtBookName.Text,out resultBname))
                    {
                        tobjBook.bookName = txtBookName.Text;
                    }
                    else
                        MessageBox.Show("Book name cant be a number.", "Error");
                }

                if (string.IsNullOrEmpty(txtPurPrice.Text))
                {
                    MessageBox.Show("Please Enter Book Purchase Price.", "Error");
                }
                else
                {
                    int resultPrice;
                    bool successfullyParsed = int.TryParse(txtPurPrice.Text, out resultPrice);
                    if (successfullyParsed && resultPrice > 0)
                    {
                        tobjBook.purchasePrice = resultPrice;
                        if (cmbPublisherId.SelectedItem!=null)
                            tobjBook.publisherId = int.Parse(cmbPublisherId.SelectedValue.ToString());                            
                        if (cmbSectionId.SelectedItem!=null)
                            tobjBook.sectionId = int.Parse(cmbSectionId.SelectedValue.ToString());
                        if (cmbCatagoryId.SelectedItem!=null)
                            tobjBook.catagoryId = int.Parse(cmbCatagoryId.SelectedValue.ToString());
                        if (cmbRackId.SelectedItem!=null)
                            tobjBook.rackId = int.Parse(cmbRackId.SelectedValue.ToString());
                        if (objBookFactory.insert(tobjBook))
                        {
                            MessageBox.Show("Record saved successfully!", "Success");
                            txtBookName.Clear();
                            txtPurPrice.Clear();                            
                        }
                        else
                            MessageBox.Show("Unable to save the record.","Error");
                    }
                    else
                    {
                        MessageBox.Show("Price must be a number and greater then zero.", "Error");
                        txtPurPrice.Clear();
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void btnViewAllBooks_Click(object sender, RoutedEventArgs e)
        {
            try { 
            List<BOOK> bookList = objBookFactory.getAllBooks();
            dgBook.ItemsSource = bookList;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        
        private void btnBookSearch_Click(object sender, RoutedEventArgs e)
        {
            try { 
            int resultId;
            if (!string.IsNullOrEmpty(txtSearchBook.Text))
            {
                bool successfullyParsed = int.TryParse(txtSearchBook.Text, out resultId);
                if (successfullyParsed)
                {
                    var result = objBookFactory.getAllBooksById(resultId);
                    if (result.Count() != 0)
                    {
                        dgBook.ItemsSource = result;
                        txtSearchBook.Clear();
                    }
                    else
                    {
                        MessageBox.Show("No record found with given Id", "Error");
                        txtSearchBook.Clear();
                    }
                }
                else
                {
                    MessageBox.Show("Id must be a number.", "Error");
                    txtSearchBook.Clear();
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

        private void btnBookDelete_Click(object sender, RoutedEventArgs e)
        {
            try { 

            int resultId;
            if (!string.IsNullOrEmpty(txtGiveId.Text))
            {
                bool successfullyParsed = int.TryParse(txtGiveId.Text, out resultId);
                if (successfullyParsed)
                {
                    if (objBookFactory.delete(resultId))
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
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBookUpdate_Click(object sender, RoutedEventArgs e)
        {
            try { 
            int resultId, resultPrice;
            if (!string.IsNullOrEmpty(txtGiveId.Text))
            {
                bool successfullyParsed = int.TryParse(txtGiveId.Text, out resultId);
                if (successfullyParsed)
                {
                    if (string.IsNullOrEmpty(txtGiveName.Text) && string.IsNullOrEmpty(txtGivePrice.Text))
                        MessageBox.Show("Name and price cant be empty.", "Error");
                    else
                    {
                        bool successfullyParsed2 = int.TryParse(txtGivePrice.Text, out resultPrice);
                        if (successfullyParsed2 && resultPrice > 0)
                        {
                            if (objBookFactory.update(resultId, txtGiveName.Text, resultPrice))
                            {
                                MessageBox.Show("Updated Successfully", "Success");
                                txtGiveId.Clear();
                                txtGivePrice.Clear();
                                txtGiveName.Clear();
                            }
                            else
                            {
                                MessageBox.Show("No record found with given Id.", "Error");
                                txtGiveId.Clear();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Price must be a number and greated then zero.", "Error");
                            txtGivePrice.Clear();
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
                MessageBox.Show(ex.Message);
            }

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            List<SECTION> sectionlist = objCmbSectionFactory.getAllEntries();
            List<PUBLISHER> publisherlist = objCmbPublisherFactory.getAllEntries();
            List<CATAGORY> catagorylist = objCmbCatagoryFactory.getAllEntries();
            List<RACK> racklist = objCmbRackFactory.getAllEntries();
            
            cmbSectionId.ItemsSource = sectionlist;
            cmbSectionId.DisplayMemberPath = "sectionName";
            cmbSectionId.SelectedValuePath = "sectionId";

            cmbPublisherId.ItemsSource = publisherlist;
            cmbPublisherId.DisplayMemberPath = "publisherName";
            cmbPublisherId.SelectedValuePath = "publisherId";

            cmbCatagoryId.ItemsSource = catagorylist;
            cmbCatagoryId.DisplayMemberPath = "catagoryName";
            cmbCatagoryId.SelectedValuePath = "catagoryId";

            cmbRackId.ItemsSource = racklist;
            cmbRackId.DisplayMemberPath = "rackId";
            cmbRackId.SelectedValuePath = "rackId";
        }
    }
}

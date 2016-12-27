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
    /// Interaction logic for frmCatagory.xaml
    /// </summary>
    public partial class frmCatagory : Window
    {
        CATAGORY tobjCatagory = new CATAGORY();
        catagoryFactory objCatagoryFactory = new catagoryFactory();
        public frmCatagory()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnViewAllCatagories_Click(object sender, RoutedEventArgs e)
        {
            try { 
            List<CATAGORY> catagoryList = objCatagoryFactory.getAllCatagorys();
            dgCatagory.ItemsSource = catagoryList;
            txtSearchCatagory.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void btnSaveCatagory_Click(object sender, RoutedEventArgs e)
        {
            try { 
            if (string.IsNullOrEmpty(txtCatName.Text) || string.IsNullOrWhiteSpace(txtCatName.Text))
            {
                MessageBox.Show("Please Enter a valid Catagory Name.", "Error");
            }
            else
            {
                int result;
                if (!int.TryParse(txtCatName.Text, out result))
                {
                    tobjCatagory.catagoryName = txtCatName.Text;
                    objCatagoryFactory.insert(tobjCatagory);
                    MessageBox.Show("Record saved successfully!", "Success");
                    txtCatName.Clear();
                }
                else
                {
                    MessageBox.Show("Category name cant be a number.", "Error");
                    txtCatName.Clear();
                }
            }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void btnCatagorySearch_Click(object sender, RoutedEventArgs e)
        {
            try { 
            if (!string.IsNullOrEmpty(txtSearchCatagory.Text))
            {
                int resultId;
                if (int.TryParse(txtSearchCatagory.Text, out resultId))
                {
                    var result = objCatagoryFactory.getAllCatagorysById(resultId);
                    if (result.Count() != 0)
                    {
                        dgCatagory.ItemsSource = result;
                        txtSearchCatagory.Clear();
                    }
                    else
                    { 
                        MessageBox.Show("No record found with the given Id.", "Error"); 
                        txtSearchCatagory.Clear(); 
                    }
                }
                else 
                {
                    MessageBox.Show("Id must be a number.","Error");
                    txtSearchCatagory.Clear();
                }
            }
            else
                MessageBox.Show("Please enter the Id first.","Error");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void btnCatagoryDelete_Click(object sender, RoutedEventArgs e)
        {
            try { 
            if (!string.IsNullOrEmpty(txtGiveCatId.Text))
            {
                int resultId;
                if (int.TryParse(txtGiveCatId.Text, out resultId))
                {

                    if (objCatagoryFactory.delete(resultId))
                    {
                        MessageBox.Show("Deleted Successfully");
                        txtGiveCatId.Clear();
                    }
                    else
                    {
                        MessageBox.Show("No record found against the given Id.", "Error");
                        txtGiveCatId.Clear();
                    }
                }
                else
                {
                    MessageBox.Show("Id must be a number", "Error");
                    txtGiveCatId.Clear();
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

        private void btnCatagoryUpdate_Click(object sender, RoutedEventArgs e)
        {

            try { 
            if (string.IsNullOrEmpty(txtGiveCatId.Text) || string.IsNullOrEmpty(txtGiveCatName.Text))
            {
                MessageBox.Show("Both Id and Name are required.", "Error");
            }
            else
            {
                int resultId, resultName;
                if (int.TryParse(txtGiveCatId.Text, out resultId))
                {
                    if (!int.TryParse(txtGiveCatName.Text, out resultName))
                    {
                        if (objCatagoryFactory.update(resultId, txtGiveCatName.Text))
                        {
                            MessageBox.Show("Updated Successfully!","Error");
                           
                        }
                        else
                        {
                            MessageBox.Show("No record found against the given Id.", "Error");
                            txtGiveCatId.Clear();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Name cant be a number.", "Error");
                        txtCatName.Clear();
                    }
                }
                else
                {
                    MessageBox.Show("Id must be a number", "Error");
                    txtGiveCatId.Clear();
                }
            }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }    
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}

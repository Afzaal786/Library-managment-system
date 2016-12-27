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
    /// Interaction logic for frmSection.xaml
    /// </summary>
    public partial class frmSection : Window
    {
        SECTION tobjSection = new SECTION();
        sectionFactory objSectionFactory = new sectionFactory();
        public frmSection()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnViewAllSection_Click(object sender, RoutedEventArgs e)
        {
            try { 
            List<SECTION> catagoryList = objSectionFactory.getAllSections();
            dgSection.ItemsSource = catagoryList;
            txtSearchSection.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void btnSaveSection_Click(object sender, RoutedEventArgs e)
        {
            try {
                if (string.IsNullOrEmpty(txtSecName.Text) || string.IsNullOrWhiteSpace(txtSecName.Text))
            {
                MessageBox.Show("Please Enter Section Name.", "Error");
            }
            else
            {
                int result;
                if (!int.TryParse(txtSecName.Text, out result))
                {
                    tobjSection.sectionName = txtSecName.Text;
                    objSectionFactory.insert(tobjSection);
                    MessageBox.Show("Record saved successfully!", "Success");
                    txtSecName.Clear();
                }
                else
                {
                    MessageBox.Show("Section name cant be a number.", "Error");
                    txtSecName.Clear();
                }
            }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }

        }

        private void btnSectionSearch_Click(object sender, RoutedEventArgs e)
        {
            try { 
            if (!string.IsNullOrEmpty(txtSearchSection.Text))
            {
                int resultId;
                if (int.TryParse(txtSearchSection.Text, out resultId))
                {
                    var result = objSectionFactory.getAllSectionsById(resultId);
                    if (result.Count() != 0)
                    {
                        dgSection.ItemsSource = result;
                        txtSearchSection.Clear();
                    }
                    else
                    { 
                        MessageBox.Show("No record found with the given Id.", "Error"); 
                        txtSearchSection.Clear(); 
                    }
                }
                else 
                {
                    MessageBox.Show("Id must be a number.","Error");
                    txtSearchSection.Clear();
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

        private void btnSectionDelete_Click(object sender, RoutedEventArgs e)
        {
            try { 
            if (!string.IsNullOrEmpty(txtGiveSecId.Text))
            {
                int resultId;
                if (int.TryParse(txtGiveSecId.Text, out resultId))
                {

                    if (objSectionFactory.delete(resultId))
                    {
                        MessageBox.Show("Deleted Successfully");
                        txtGiveSecId.Clear();
                    }
                    else
                    {
                        MessageBox.Show("No record found against the given Id.", "Error");
                        txtGiveSecId.Clear();
                    }
                }
                else
                {
                    MessageBox.Show("Id must be a number", "Error");
                    txtGiveSecId.Clear();
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

        private void btnSectionUpdate_Click(object sender, RoutedEventArgs e)
        {

            try { 
            if (string.IsNullOrEmpty(txtGiveSecId.Text) || string.IsNullOrEmpty(txtGiveSecName.Text))
            {
                MessageBox.Show("Both Id and Name are required.", "Error");
            }
            else
            {
                int resultId, resultName;
                if (int.TryParse(txtGiveSecId.Text, out resultId))
                {
                    if (!int.TryParse(txtGiveSecName.Text, out resultName))
                    {
                        if (objSectionFactory.update(resultId, txtGiveSecName.Text))
                        {
                            MessageBox.Show("Updated Successfully!","Error");
                            txtGiveSecId.Clear();
                        }
                        else
                        {
                            MessageBox.Show("No record found against the given Id.", "Error");
                            txtGiveSecId.Clear();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Name cant be a number.", "Error");
                        txtSecName.Clear();
                    }
                }
                else
                {
                    MessageBox.Show("Id must be a number", "Error");
                    txtGiveSecId.Clear();
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

using System;
using LMSDataAccessLayer;
using System.Collections.Generic;
using System.Linq;
using System.Windows;

namespace Library_Managment_System
{
    /// <summary>
    /// Interaction logic for frmRack.xaml
    /// </summary>
    public partial class frmRack : Window
    {
        RACK tobjRack = new RACK();
        cmbSectionFactory objCmbSectionFactory = new cmbSectionFactory();
        rackFactory objRackFactory = new rackFactory();

        public frmRack()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            List<SECTION> list = objCmbSectionFactory.getAllEntries();

            cmbSectionId.ItemsSource = list;
            cmbSectionId.DisplayMemberPath = "sectionName";
            cmbSectionId.SelectedValuePath = "sectionId";
        }
        private void btnSaveRack_Click(object sender, RoutedEventArgs e)
        {
            try { 
            if (cmbSectionId.SelectedValue != null)
                tobjRack.sectionId = int.Parse(cmbSectionId.SelectedValue.ToString());
            else
            {
                if (objRackFactory.insert(tobjRack))
                {
                    MessageBox.Show("Record saved successfully!", "Success!");

                }
                else
                    MessageBox.Show("Unable to save the record!", "Error");
            }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }  

        }

        

        private void btnViewAllRacks_Click(object sender, RoutedEventArgs e)
        {
            try { 
            List<RACK> rackList = objRackFactory.getAllRacks();
            dgRack.ItemsSource = rackList;
            txtSearchRack.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void btnRackSearch_Click(object sender, RoutedEventArgs e)
        {
            try { 
            if (!string.IsNullOrEmpty(txtSearchRack.Text))
            {
                int resultId;
                if (int.TryParse(txtSearchRack.Text, out resultId))
                {
                    var result = objRackFactory.getAllRacksById(resultId);
                    if (result.Count() != 0)
                    {
                        dgRack.ItemsSource = result;
                        txtSearchRack.Clear();
                    }
                    else
                    {
                        MessageBox.Show("No record found with the given Id.", "Error");
                        txtSearchRack.Clear();
                    }
                }
                else
                {
                    MessageBox.Show("Id must be a number.", "Error");
                    txtSearchRack.Clear();
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

        private void btnRackDelete_Click(object sender, RoutedEventArgs e)
        {
            try { 
            if (!string.IsNullOrEmpty(txtGiveRackId.Text))
            {
                int resultId;
                if (int.TryParse(txtGiveRackId.Text, out resultId))
                {

                    if (objRackFactory.delete(resultId))
                    {
                        MessageBox.Show("Deleted Successfully");
                        txtGiveRackId.Clear();
                    }
                    else
                    {
                        MessageBox.Show("No record found against the given Id.", "Error");
                        txtGiveRackId.Clear();
                    }
                }
                else
                {
                    MessageBox.Show("Id must be a number", "Error");
                    txtGiveRackId.Clear();
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

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

       
    }
}

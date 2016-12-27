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
    /// Interaction logic for frmFine.xaml
    /// </summary>
    public partial class frmFine : Window
    {
        FINE tobjFine = new FINE();
        fineFactory objFineFactory = new fineFactory();
        cmbMemberFactory objCmbMemberFactory = new cmbMemberFactory();
        public frmFine()
        {
            InitializeComponent();
        }

        private void btnFineClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnFineSave_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int resultAmount;
                if (string.IsNullOrEmpty(txtFinAmount.Text) || cmbMemberId.SelectedValue==null || string.IsNullOrEmpty(dpFine.Text))
                {
                    MessageBox.Show("Fine amount, member Id and paid on date is required.", "Error");
                }
                else
                {
                    if (!int.TryParse(txtFinAmount.Text, out resultAmount))
                        MessageBox.Show("Amount must be a number.", "Error");
                    else
                    {
                        if (resultAmount > 0)
                        {
                            tobjFine.fineAmount = resultAmount;
                            
                            tobjFine.memberId = int.Parse(cmbMemberId.SelectedValue.ToString());
                            tobjFine.paidOn = dpFine.DisplayDate.Date;
                            if (objFineFactory.insert(tobjFine))
                            {
                                MessageBox.Show("Record saved successfully!", "Success");
                                txtFinAmount.Clear();
                            }
                            else
                                MessageBox.Show("Record Cant be saved.", "Error");
                        }
                        else
                        {
                            MessageBox.Show("Amount must be greater than zero.", "Error");
                            txtFinAmount.Clear();
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnViewAllFines_Click(object sender, RoutedEventArgs e)
        {
            try { 
            List<FINE> fineList = objFineFactory.getAllFines();
            dgFIne.ItemsSource = fineList;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
            
        }

        private void btnFineSearch_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int resultId;
                if (!string.IsNullOrEmpty(txtSearchFIne.Text))
                {
                    bool successfullyParsed = int.TryParse(txtSearchFIne.Text, out resultId);
                    if (successfullyParsed)
                    {
                        var result = objFineFactory.getAllFInesById(resultId);
                        if (result.Count() != 0)
                        {
                            dgFIne.ItemsSource = result;
                            txtSearchFIne.Clear();
                        }
                        else
                        {
                            MessageBox.Show("No record found with given Id", "Error");
                            txtSearchFIne.Clear();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Id must be a number.", "Error");
                        txtSearchFIne.Clear();
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

        private void btnFineDelete_Click(object sender, RoutedEventArgs e)
        {
            try { 
            int resultId;
            if (!string.IsNullOrEmpty(txtGiveId.Text))
            {
                bool successfullyParsed = int.TryParse(txtGiveId.Text, out resultId);
                if (successfullyParsed)
                {
                    if (objFineFactory.delete(resultId))
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

        private void btnFineUpdate_Click(object sender, RoutedEventArgs e)
        {
            try { 
            int resultId, resultAmount, resultMemId;
            if (!string.IsNullOrEmpty(txtGiveId.Text) && !string.IsNullOrEmpty(txtGiveAmount.Text) && !string.IsNullOrEmpty(txtGiveMemId.Text) && !string.IsNullOrEmpty(dpGivePaidDate.Text))
            {               
                if(int.TryParse(txtGiveId.Text,out resultId) && int.TryParse(txtGiveAmount.Text, out resultAmount) && int.TryParse(txtGiveMemId.Text, out resultMemId))
                {
                    if (objFineFactory.update(resultId, resultAmount, resultMemId, dpGivePaidDate.DisplayDate.Date))
                    {
                        MessageBox.Show("Record Updated Successfully.", "Success!");
                        txtGiveId.Clear();
                        txtGiveAmount.Clear();
                        txtGiveMemId.Clear();
                    }
                    else
                    {
                        MessageBox.Show("No record found against given Id.","Error");
                        txtGiveId.Clear();
                        txtGiveAmount.Clear();
                        txtGiveMemId.Clear();
                    }
                }
                else
                {
                    MessageBox.Show("Id, amount and meber Id must be numbers.", "Error");
                    txtSearchFIne.Clear();
                }
            }
            else
                MessageBox.Show("All four fields are required.", "Error");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            List<MEMBER> memberlist = objCmbMemberFactory.getAllEntries();
            cmbMemberId.ItemsSource = memberlist;
            cmbMemberId.DisplayMemberPath = "memberName";
            cmbMemberId.SelectedValuePath = "memberId";
        }
    }
}

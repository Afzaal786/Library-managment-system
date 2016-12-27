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
    /// Interaction logic for frmEmployee.xaml
    /// </summary>
    public partial class frmEmployee : Window
    {
        EMPLOYEE tobjEmployee = new EMPLOYEE();
        employeeFactory objEmployeeFactory = new employeeFactory();
        public frmEmployee()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnEmployeeSave_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtEmpName.Text) || string.IsNullOrEmpty(txtEmpDesignation.Text) || string.IsNullOrWhiteSpace(txtEmpName.Text) || string.IsNullOrWhiteSpace(txtEmpDesignation.Text))
                {
                    MessageBox.Show("Please enter valid employee name and designation.", "Error");
                }
                else
                {
                    int resultName, resultDesig;
                    if (int.TryParse(txtEmpName.Text, out resultName) || int.TryParse(txtEmpDesignation.Text, out resultDesig))
                        MessageBox.Show("Name and designation cant be a number.", "Error");
                    else
                    {
                        tobjEmployee.employeeName = txtEmpName.Text;
                        tobjEmployee.Designation = txtEmpDesignation.Text;
                        if (!string.IsNullOrEmpty(txtEmpCon.Text))
                        {
                            tobjEmployee.employeeContact = txtEmpDesignation.Text;
                        }
                        if (objEmployeeFactory.insert(tobjEmployee))
                            MessageBox.Show("Record Saved Successfully.", "Success!");
                        else
                            MessageBox.Show("Unable to save the record.", "Error");
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnViewAllEmployee_Click(object sender, RoutedEventArgs e)
        {
            try { 
            List<EMPLOYEE> employeeList = objEmployeeFactory.getAllEmployees();
            dgEmployee.ItemsSource = employeeList;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void btnEmployeeSearch_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int resultId;
                if (!string.IsNullOrEmpty(txtSearchEmployee.Text))
                {
                    bool successfullyParsed = int.TryParse(txtSearchEmployee.Text, out resultId);
                    if (successfullyParsed)
                    {
                        var result = objEmployeeFactory.getAllEmployeesById(resultId);
                        if (result.Count() != 0)
                        {
                            dgEmployee.ItemsSource = result;
                            txtSearchEmployee.Clear();
                        }
                        else
                        {
                            MessageBox.Show("No record found with given Id", "Error");
                            txtSearchEmployee.Clear();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Id must be a number.", "Error");
                        txtSearchEmployee.Clear();
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

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void btnEmployeeUpdate_Click(object sender, RoutedEventArgs e)
        {
            try { 
            int resultId, resultName, resultDesig;
            if (!string.IsNullOrEmpty(txtGiveEmployeeId.Text))
            {
                bool successfullyParsed = int.TryParse(txtGiveEmployeeId.Text, out resultId);
                if (successfullyParsed)
                {
                    if (!string.IsNullOrEmpty(txtGiveEmployeeName.Text) && !string.IsNullOrEmpty(txtGiveEmployeeDesignation.Text))
                    {
                        if (int.TryParse(txtGiveEmployeeName.Text, out resultName) || int.TryParse(txtGiveEmployeeDesignation.Text, out resultDesig))
                        {
                            MessageBox.Show("Name and designation cant be number.", "Error");
                            
                        }
                        else
                        {
                            if (objEmployeeFactory.update(resultId, txtGiveEmployeeName.Text, txtGiveEmployeeDesignation.Text,txtGiveEmployeeContact.Text))
                            {
                                MessageBox.Show("Updated Successfully", "Success");
                                txtGiveEmployeeId.Clear();
                                txtGiveEmployeeContact.Clear();
                                txtGiveEmployeeName.Clear();
                            }
                            else
                            {
                                MessageBox.Show("No record exist with given Id.", "Error");
                                txtGiveEmployeeId.Clear();
                            }
                        }
                           
                    }
                    else
                        MessageBox.Show("Name and Designation both are required.", "Error");
                }
                else
                {
                    MessageBox.Show("Id must be a number.", "Error");
                    txtSearchEmployee.Clear();
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

        private void btnEmployeeDelete_Click(object sender, RoutedEventArgs e)
        {
            try{
            
            int resultId;
            if (!string.IsNullOrEmpty(txtGiveEmployeeId.Text))
            {
                bool successfullyParsed = int.TryParse(txtGiveEmployeeId.Text, out resultId);
                if (successfullyParsed)
                {
                    if (objEmployeeFactory.delete(resultId))
                    {
                        MessageBox.Show("Record Deleted Successfully.", "Success");
                        txtGiveEmployeeId.Clear();
                    }
                    else
                    {
                        MessageBox.Show("No record exist with given Id", "Error");
                        txtGiveEmployeeId.Clear();
                    }
                }
                else
                {
                    MessageBox.Show("Id must be a number.", "Error");
                    txtGiveEmployeeId.Clear();
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
           
    }

}

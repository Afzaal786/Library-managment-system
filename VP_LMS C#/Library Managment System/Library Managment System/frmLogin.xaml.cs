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
    /// Interaction logic for frmLogin.xaml
    /// </summary>
    public partial class frmLogin : Window
    {
        USER tobjUser = new USER();
        userFactory objUserFactory = new userFactory();
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int resultName;
                if (string.IsNullOrEmpty(txtUserName.Text) || string.IsNullOrEmpty(txtPassword.Password))
                    MessageBox.Show("User name and password are required.", "Error");
                else
                    if (int.TryParse(txtUserName.Text, out resultName))
                        MessageBox.Show("Name cant be number.", "Error");
                    else
                    {
                        var result = objUserFactory.userLogin(txtUserName.Text,txtPassword.Password);
                        if (result.Count() != 0)
                        {
                            this.Hide();
                            MainWindow mw = new MainWindow();
                            mw.Show();
                        }
                        else
                            MessageBox.Show("Invalid User Name or Password, or\n This user dont exist.","Login failed.");
                    }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"Error");
            }
        }
    }
}

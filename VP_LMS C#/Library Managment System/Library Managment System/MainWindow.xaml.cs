using System.Windows;

namespace Library_Managment_System
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void  btnBookClick(object sender, RoutedEventArgs e)
        {
           frmBook objFrmBook = new frmBook();
           objFrmBook.ShowDialog();
        }

        private void btnBookIssueClick(object sender, RoutedEventArgs e)
        {
            frmBookIssuence objFrmBookIssuence = new frmBookIssuence();
            objFrmBookIssuence.ShowDialog();
        }

        private void btnAuthorClick(object sender, RoutedEventArgs e)
        {
            frmAuthor objFrmAuthor = new frmAuthor();
            objFrmAuthor.ShowDialog();
        }

        private void btnCatagoryClick(object sender, RoutedEventArgs e)
        {
            frmCatagory objFrmCatagory = new frmCatagory();
            objFrmCatagory.ShowDialog();
        }

        private void btnEmployeeClick(object sender, RoutedEventArgs e)
        {
            frmEmployee objFrmEmployee = new frmEmployee();
            objFrmEmployee.ShowDialog();
        }

        private void btnMemberClick(object sender, RoutedEventArgs e)
        {
            frmMember objFrmMember = new frmMember();
            objFrmMember.ShowDialog();
        }

        private void btnPublisherClick(object sender, RoutedEventArgs e)
        {
            frmPublisher objFrmPublisher = new frmPublisher();
            objFrmPublisher.ShowDialog();
        }

        private void btnUserClick(object sender, RoutedEventArgs e)
        {
            frmUser objFrmUser = new frmUser();
            objFrmUser.ShowDialog();
        }

        private void btnFineClick(object sender, RoutedEventArgs e)
        {
            frmFine objFrmFine = new frmFine();
            objFrmFine.ShowDialog();
        }

        private void btnRackClick(object sender, RoutedEventArgs e)
        {
            frmRack objFrmRack = new frmRack();
            objFrmRack.ShowDialog();
        }

        private void btnExitClick(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();

        }
    }
}

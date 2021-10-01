using ErpSystem.HelperClass;
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

namespace ErpSystem
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ErpSystemContext _context = new ErpSystemContext();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void signUpbtn_Click(object sender, RoutedEventArgs e)
        {
            signUP signUPWindow = new signUP();
            //this.Close();
            signUPWindow.ShowDialog();
        }

        private void signInbtn_Click(object sender, RoutedEventArgs e)
        {
            var email = emailtxt.Text;
            var password = passwordtxt.Password;
            if (email == null || password == null)
                MessageBox.Show("Email and password is requires...!");
            else { 
                var emp = UserHelper.GetEmployeeEmail(email);


                if (emp==null)
                    MessageBox.Show("These account dosen't exist..!");
                else
                {
                    var passwordDP = UserHelper.GetEmployeePassword(emp.employee_id);
                    if (String.IsNullOrEmpty(passwordDP))
                        MessageBox.Show("This Account Dosn't Exist..!");
                    else
                    {
                        if (passwordDP == password)
                        {
                            StartWindow startWindow = new StartWindow(emp);
                            this.Close();
                            startWindow.Show();
                        }
                        else
                        {
                            MessageBox.Show("Password Is Wrong");
                        }
                        
                    }
                }
            }

        }
    }
}

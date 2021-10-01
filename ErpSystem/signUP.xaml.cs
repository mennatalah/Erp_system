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
using System.Windows.Shapes;
using System.Data.Entity;
using ErpSystem.HelperClass;

namespace ErpSystem
{
    /// <summary>
    /// Interaction logic for signUP.xaml
    /// </summary>
    public partial class signUP : Window
    {
        public signUP()
        {
            InitializeComponent();
            
        }

        private void savebtn_Click(object sender, RoutedEventArgs e)
        {
            var email = signUpEmailtxt.Text;
            var password = passwordtxt.Password;
            if (email == null||password==null)
                MessageBox.Show("Email and password is requires...!");
            else
            {
                   
                    var employeeBussinessEmail = UserHelper.GetEmployeeEmail(email);
                    if (employeeBussinessEmail == null)
                        MessageBox.Show("This email does't exist..!");
                    else
                    {
                        var employeePassword = UserHelper.GetEmployeePassword(employeeBussinessEmail.employee_id);
                        if(employeePassword!=null)
                            MessageBox.Show("This This Account Orady exist!");
                        else
                        {
                            var newPassword = new employees_passwords()
                            {
                                id = employeeBussinessEmail.employee_id,
                                password = password,
                                date_added = DateTime.Now
                            };
                        UserHelper.SignUp(newPassword);


                        }
                        
                    }

                
               
            }

            this.Close();

        }


    }
}

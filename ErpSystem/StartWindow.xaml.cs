using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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
using ErpSystem.HelperClass;
using System.Data.Entity;
using System.Collections;
using System.Data;

namespace ErpSystem
{
    /// <summary>
    /// Interaction logic for StartWindow.xaml
    /// </summary>
    public partial class StartWindow : Window
    {
        private employees_info _user;
        private List<contact_person_info> contacts;
        public StartWindow(employees_info user)
        {
            InitializeComponent();
            _user = user;
            contactbtn.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));
        }

        private void companiestn_Click(object sender, RoutedEventArgs e)
        {
           
            IEnumerable companes = AccessAllData.CanAccessAllData(_user)? 
                                                 CompanyHelper.GetAllCompanies():
                                                 CompanyHelper.GetAllCompanies(_user.employee_id);
            
            myGrid.ItemsSource = companes;
        }

        private void contactbtn_Click(object sender, RoutedEventArgs e)
        {
           
            contacts = AccessAllData.CanAccessAllData(_user) ?
                                                ContactHelper.GetAllContacts() :
                                                ContactHelper.GetAllContacts(_user.employee_id);

            var List = contacts.Select(c => new { Name = c.name, Email = c.email, Gender = c.gender });
            myGrid.ItemsSource = List;

            
        }
        private void companiesTelephonbtn_Click(object sender, RoutedEventArgs e)
        {
            
            IEnumerable companeTelphone = AccessAllData.CanAccessAllData(_user) ?
                                                 CompanyHelper.GetAllTelphones() :
                                                 CompanyHelper.GetAllTelphones(_user.employee_id);
            myGrid.ItemsSource = companeTelphone;

        }

        private void companiesAdressbtn_Click(object sender, RoutedEventArgs e)
        {
            
            IEnumerable companeAdresses = AccessAllData.CanAccessAllData(_user) ?
                                                 CompanyHelper.GetAllAddresses() :
                                                 CompanyHelper.GetAllAddresses(_user.employee_id);
            myGrid.ItemsSource = companeAdresses;
        }
        private void signOutbtn_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            this.Close();
            mainWindow.Show();
        }
        
        private void myGrid_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var grid = sender as DataGrid;
            var cell = grid.SelectedItem;
            var ContactGender = cell.GetType().GetProperty("Gender");
            if(ContactGender != null)
            {
                int idex = grid.SelectedIndex;
                ContantDetails contantDetails = new ContantDetails(contacts.ElementAt(idex));
                contantDetails.ShowDialog();
            }
                
        }
      
        
    }
}

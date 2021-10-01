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
using System.Windows.Shapes;

namespace ErpSystem
{
    /// <summary>
    /// Interaction logic for ContantDetails.xaml
    /// </summary>
    public partial class ContantDetails : Window
    {
        public ContantDetails(contact_person_info contactPersonInfo)
        {
            InitializeComponent();
            nametxt.Text = contactPersonInfo.name;
            emailtxt.Text = contactPersonInfo.email;
            gendertxt.Text = contactPersonInfo.gender;
            departmenttxt.Text = contactPersonInfo.departments_type.department;
            myGrid.ItemsSource = ContactHelper.GetContactMobils(contactPersonInfo);

        }
    }
}

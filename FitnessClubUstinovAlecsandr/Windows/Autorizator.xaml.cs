using FitnessClubUstinovAlecsandr.ClassHelper;
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

namespace FitnessClubUstinovAlecsandr.Windows
{
    /// <summary>
    /// Логика взаимодействия для Autorizator.xaml
    /// </summary>
    public partial class Autorizator : Window
    {
        public Autorizator()
        {
            InitializeComponent();
        }

        private void BtnRegistration_Click(object sender, RoutedEventArgs e)
        {
            RegistrationWindows registrationWindows = new RegistrationWindows();
            registrationWindows.Show();
            Close();
        }

        private void BtnSignIn_Click(object sender, RoutedEventArgs e)
        {
            var authUser = ClassHelper.EFClass.content.User.ToList()
                .Where(i =>i.Login == TbLogin.Text && i.Password == TbPassword.Text)
                .FirstOrDefault();

            if (authUser != null)
            {
                MainWindow mainWindow = new MainWindow(); 
                mainWindow.Show();  
            }
            else
            {
                MessageBox.Show("Такого пользователя нету");
            }
        }
    }
}

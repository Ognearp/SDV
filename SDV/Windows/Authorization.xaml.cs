using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
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
using MaterialDesignExtensions.Controls;
using Notification.Wpf;
using SDV.Model;
using SDV.Services;

namespace SDV.Windows
{
    /// <summary>
    /// Логика взаимодействия для Authorization.xaml
    /// </summary>
    public partial class Authorization : MaterialWindow, INotifyPropertyChanged
    {


        #region Property
        private string login;
        private string passwords;
     
        #endregion

        #region
        public string Login
        {
            get => login;
            set
            {
                login = value;
                OnPropertyChanged();
            }
        }
        public string Passwords
        {
            get => passwords;
            set
            {
                passwords = value;
                OnPropertyChanged();
            }
        }

        
        #endregion
        public Authorization()
        {
            InitializeComponent();
            DataContext = this;
           
        }
        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
           
        }
        #region Medots

        public void Avtorization()
        {
            using(var bd = new Model1())
            {

                if (bd.BaseEmployes.Any(p => p.login == Login && p.password == Passwords) == true)
                {
                    User_services.Instance.CurentEmployees = bd.BaseEmployes.FirstOrDefault(p => p.login == Login && p.password == Passwords);
                    if (User_services.Instance.CurentEmployees.id_role == 1)
                    {
                        Shops_products shop = new Shops_products();
                        shop.Show();
                        this.Close();
                    }
                    if (User_services.Instance.CurentEmployees.id_role == 2)
                    {
                        Warehouse_product warehouse = new Warehouse_product();
                        warehouse.Show();
                        this.Close();
                    }
                }
                else
                {
                    NotificationManager alo = new NotificationManager();
                    alo.Show(new NotificationContent {Title="Ошибка",Message= "Неверный логин или пароль", Type=NotificationType.Error },areaName:"Notify");
                }
            }
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Avtorization();
        }
        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
           
            this.DragMove();
        }
        #endregion


        #region Property
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string property = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }


        #endregion

        private void Label_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }
    }


}

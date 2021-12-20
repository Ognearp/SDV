using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using Notification.Wpf;
using SDV.Model;
using SDV.OtherClass;
using SDV.Services;

namespace SDV.Windows
{
    /// <summary>
    /// Логика взаимодействия для Create_delivery.xaml
    /// </summary>
    public partial class Create_delivery : Window , INotifyPropertyChanged
    {


        #region Fields
        private int amount_delivery;
        private ObservableCollection<AmountProduct> amountproducts;
        private AmountProduct currentproduct;
        private Products_to_delivery currentindelivry;
        private ObservableCollection<Products_to_delivery> products_to_delivery;
        private DateTime dateTime;
        private int numberDelivry;
       
        Random rnd = new Random();
      

        #endregion

        #region Property



        public int Amount_delivery { get => amount_delivery; set { amount_delivery = value; OnPropertyChanged();  } }

        public ObservableCollection<AmountProduct> Amountproducts { get => amountproducts; set { amountproducts = value; OnPropertyChanged(); } }

        public AmountProduct Currentproduct { get => currentproduct; set { currentproduct = value; OnPropertyChanged(); } }

        public ObservableCollection<Products_to_delivery> Products_To_Delivery { get => products_to_delivery; set { products_to_delivery = value; OnPropertyChanged(); } }

        public Products_to_delivery Currentindelivry { get => currentindelivry; set { currentindelivry = value; OnPropertyChanged(); } }

        public DateTime DateTime { get => dateTime; set => dateTime = value; }
        public int NumberDelivry { get => numberDelivry; set { numberDelivry = value; OnPropertyChanged(); } }

        public Delivery Delivery { get; set; }
       


        #endregion
        public Create_delivery()
        {
            InitializeFields();
            LoadProducts();
            InitializeComponent();
            DataContext = this;
        }


        #region Metods

        public void InitializeFields()
        {
            Delivery = new Delivery();
            Products_To_Delivery = new ObservableCollection<Products_to_delivery>();
            amount_delivery = 0;
            numberDelivry = rnd.Next(800, 80000);
            dateTime = DateTime.Now;
        }
        public void LoadProducts()
        {
            Amountproducts = new ObservableCollection<AmountProduct>();
            using (var bd = new Model1())
            {
                var list  = bd.Products.ToList();
                foreach(var item in list)
                {
                    Amountproducts.Add(new AmountProduct { AmountProducts = 1, Products = item});
                }
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string property = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }

        #endregion

        private void AddDelivery(object sender, RoutedEventArgs e)
        {
            
            using(var bd = new Model1())
            {
                if(Products_To_Delivery.All(p=>p.Id_product != Currentproduct.Products.Id_product))
                {
                    Products_To_Delivery.Add(new Products_to_delivery { Id_product = Currentproduct.Products.Id_product, amount = Currentproduct.AmountProducts, Products = Currentproduct.Products });
                }
                else
                {
                    MessageBox.Show("Этот продукт уже добавлен");
                }
                
                
            }
        }

        private void DeleteProduct(object sender, RoutedEventArgs e)
        {
            using (var bd = new Model1())
            {
                var product = Products_To_Delivery.FirstOrDefault(p => p.Id_product == Currentindelivry.Id_product);
                Products_To_Delivery.Remove(product);
            }
        }

        private void Create_delivry(object sender, RoutedEventArgs e)
        {
            Delivery.Number_delivry = NumberDelivry;
            Delivery.date_delivery = DateTime.Date;
            Delivery.EmployeesId = User_services.Instance.CurentEmployees.EmployeesId;
            foreach(var item in Products_To_Delivery)
            {
                Delivery.Products_to_delivery.Add(new Products_to_delivery { amount = item.amount, Id_product = item.Id_product });
            }
            using(var bd = new Model1())
            {
                bd.Delivery.Add(Delivery);
                bd.SaveChanges();
                NotificationManager alo = new NotificationManager();
                alo.Show(new NotificationContent { Title = "Заявка создана!", Message = "Заявка успешно создана", Type = NotificationType.Success }, areaName: "Notify");
                
            }
            
        }
    }
}

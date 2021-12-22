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
using MaterialDesignExtensions.Controls;
using SDV.Model;
using SDV.Services;

namespace SDV.Windows
{
    /// <summary>
    /// Логика взаимодействия для Saw_Delivry.xaml
    /// </summary>
    public partial class Saw_Delivry : MaterialWindow, INotifyPropertyChanged
    {
        #region Fields
        private ObservableCollection<Delivery> deliveries;
        private Delivery currentDelivery;

        #endregion


        #region Property
        public ObservableCollection<Delivery> Deliveries { get => deliveries; set { deliveries = value; OnPropertyChanged(); } }

        public Delivery CurrentDelivery { get => currentDelivery; set { currentDelivery = value; OnPropertyChanged(); } }
        #endregion
        public Saw_Delivry()
        {
            LoadDelivry();
            InitializeComponent();
            DataContext = this;
        }
        #region Metods



        public void LoadDelivry()
        {
            using(var bd = new Model1())
            {
                Deliveries = new ObservableCollection<Delivery>(bd.Delivery.Include("Products_to_delivery"));
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string property = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }
        #endregion

        private void Complete_delivery(object sender, RoutedEventArgs e)
        {
            using(var bd  = new Model1())
            {
                var user = bd.Employees.FirstOrDefault(p => p.EmployeesId == CurrentDelivery.EmployeesId) as employees;
                var warehouse = bd.warehouse.Include("Product_in_warehouse").FirstOrDefault();
                var shop = bd.Shop.FirstOrDefault(p => p.Id_shop == user.id_shop);

                foreach(var item in CurrentDelivery.Products_to_delivery)
                {

                    var productinwarehouse = warehouse.Product_in_warehouse.FirstOrDefault(p => p.Id_product == item.Id_product);
                    if (productinwarehouse.amount_on_warehouse - item.amount>=0)
                    {
                        productinwarehouse.amount_on_warehouse -= item.amount;
                    }
                    else
                    {

                    }

                    var shopinproduct = shop.Prodoct_in_shop.FirstOrDefault(p => p.Id_product == item.Id_product);
                    if (shopinproduct == null)
                    {
                        shop.Prodoct_in_shop.Add(new Prodoct_in_shop { Id_product = item.Id_product, Id_shop = shop.Id_shop, Kol_vo_v_shop = item.amount });
                    }
                    else
                    {
                        shopinproduct.Kol_vo_v_shop += item.amount;
                    }
                    
                   
                }
                bd.Delivery.Remove(bd.Delivery.FirstOrDefault(p=>p.Id_delivery == CurrentDelivery.Id_delivery));
                bd.SaveChanges();
                LoadDelivry();
            }
            
        }

        private void Delete_delivery(object sender, RoutedEventArgs e)
        {
            using(var bd = new Model1())
            {
                bd.Delivery.Remove(bd.Delivery.FirstOrDefault(p => p.Id_delivery == CurrentDelivery.Id_delivery));
                bd.SaveChanges();
            }
            LoadDelivry();
            
        }
    }
}

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
using SDV.Filters;
using SDV.Model;
using SDV.Services;

namespace SDV.Windows
{
    /// <summary>
    /// Логика взаимодействия для Warehouse_product.xaml
    /// </summary>
    public partial class Warehouse_product : MaterialWindow, INotifyPropertyChanged
    {


        #region Fields
        private ObservableCollection<Products> productlist;
        private string search;
        private ObservableCollection<Products> filterlist;
        private int currentPage;
        private int itemonpage;
        private bool orderbyDesign;
        private FilterItem sortitem;
        private Products selectProduct;
        private string ordreby;
        private int maxPages;
        private int mincost;
        private int maxcost;
        #endregion
        public Warehouse_product()
        {
            LoadProduct();
            InitializeComponent();
            InitializeFieldsAsync();
            DataContext = this;
        }


        #region Property
        public ObservableCollection<Products> Productlist { get => productlist; set { productlist = value; OnPropertyChanged(); } }

 

        public ObservableCollection<Products> Filterlist { get => filterlist; set { filterlist = value; OnPropertyChanged(); } }

     
        public bool OrderbyDesign { get => orderbyDesign; set { orderbyDesign = value; OnPropertyChanged();  } }
     
        public Products SelectProduct { get => selectProduct; set { selectProduct = value; OnPropertyChanged(); } }
      
        public ObservableCollection<Typeproducta> FilterType { get; set; }
   

        #endregion

        #region Metods


        public async Task InitializeFieldsAsync()
        {

           

        }

        public void LoadProduct()
        {
            Productlist = new ObservableCollection<Products>();
            using (var bd = new Model1())
            {
                var otdel = (User_services.Instance.CurentEmployees as Warehouse_employess).warehouse.Id_warehouse;
                var data = new ObservableCollection<Product_in_warehouse>(bd.Product_in_warehouse.Where(p => p.Id_warehouse == otdel));
                foreach (var item in data)
                {
                    bd.Entry(item.Products).Collection("Product_in_warehouse").Load();
                    Productlist.Add(item.Products);
                }
                Filterlist = Productlist;
            }
        }

     
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string property = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }
        #endregion

        private void See_delivery(object sender, RoutedEventArgs e)
        {
            Saw_Delivry saw = new Saw_Delivry();
            saw.Show();
        }

        private void Go_Back(object sender, RoutedEventArgs e)
        {
            Authorization authorization = new Authorization();
            authorization.Show();
            this.Close();
        }
    }
}

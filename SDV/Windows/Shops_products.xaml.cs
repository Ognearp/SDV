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
using SDV.Model;
using SDV.Services;

namespace SDV.Windows
{
    /// <summary>
    /// Логика взаимодействия для Shops_products.xaml
    /// </summary>
    public partial class Shops_products : Window , INotifyPropertyChanged
    {

        #region Fields


        private ObservableCollection<Products> productlist;

        #endregion


        #region Property
        public ObservableCollection<Products> Productlist { get => productlist; set { productlist = value; OnPropertyChanged(); } }

        #endregion
        public Shops_products()
        {
            LoadProduct();
            InitializeFields();
            InitializeComponent();  
            DataContext = this;

          
        }

        #region Medots
        public void InitializeFields()
        {
        
         
        }
        public void LoadProduct()
        {
            Productlist = new ObservableCollection<Products>();
            using(var bd = new Model1())
            {
                var data = new ObservableCollection<Prodoct_in_shop>(bd.Prodoct_in_shop.Where(p=>p.Id_shop==User_services.Instance.CurentEmployees.id_shop));
                foreach(var item in data)
                {
                    Productlist.Add(item.Products);
                }
            }
        }



        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string property = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }
        #endregion



    }
}

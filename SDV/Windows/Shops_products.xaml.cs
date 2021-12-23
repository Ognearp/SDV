using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
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
    /// Логика взаимодействия для Shops_products.xaml
    /// </summary>
    public partial class Shops_products : MaterialWindow, INotifyPropertyChanged
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


        #region Property
        public ObservableCollection<Products> Productlist { get => productlist; set { productlist = value; OnPropertyChanged(); } }

        public string Search { get => search; set { search = value; OnPropertyChanged(); FilerMetod(); } }

        public ObservableCollection<Products> Filterlist { get => filterlist; set { filterlist = value; OnPropertyChanged(); } }

        public int CurrentPage { get => currentPage; set { currentPage=value; OnPropertyChanged(); FilerMetod(); } }
        public bool OrderbyDesign { get => orderbyDesign; set { orderbyDesign = value; OnPropertyChanged(); FilerMetod(); } }
        public FilterItem Sortitem { get => sortitem; set { sortitem = value; OnPropertyChanged(); FilerMetod(); } }
        public Products SelectProduct { get => selectProduct; set { selectProduct = value; OnPropertyChanged(); } }
        public string PageDisplay { get => $"{currentPage + 1}/{MaxPages}"; }
        public ObservableCollection<Typeproducta> FilterType { get; set; }
        public List<FilterItem> SortParams { get; set; }
        public string Ordreby { get => ordreby; set { ordreby = value; OnPropertyChanged(); } }

        public int MaxPages { get => maxPages; set { maxPages=value > 0 ? maxPages = value : 1; OnPropertyChanged(); } }

        public int Mincost { get => mincost; set { mincost = value; OnPropertyChanged(); FilerMetod(); } }
        public int Maxcost { get => maxcost; set { maxcost = value; OnPropertyChanged(); FilerMetod(); } }




        #endregion
        public Shops_products()
        {
            
            LoadProduct();
            LoadSort();
            LoadFilter();
            InitializeComponent();
            InitializeFieldsAsync();
            DataContext = this;


        }



        #region Medots
        public async Task InitializeFieldsAsync()
        {

            search = string.Empty;
            itemonpage = 5;
            sortitem = SortParams[0];
            OrderbyDesign = true;
            currentPage = 0;
            mincost = 0;
            maxcost = 0;
            try
            {
                await Task.Run(() =>
                {
                    FilerMetod();
                    MaxPage();
                   
                });
            }
            catch (Exception ex)
            {

            }
            
        }
        public void LoadProduct()
        {
            Productlist = new ObservableCollection<Products>();

            using (var bd = new Model1())
            {
                var alo = (User_services.Instance.CurentEmployees as employees).id_shop;
                var data = new ObservableCollection<Prodoct_in_shop>(bd.Prodoct_in_shop.Where(p => p.Id_shop == alo));
                foreach (var item in data )
                {
                    bd.Entry(item.Products).Collection("Prodoct_in_shop").Load();
                    Productlist.Add(item.Products);
                    
                }
                Filterlist = Productlist;
            }
        }
        public void LoadSort()
        {
            SortParams = new List<FilterItem>
            {
                new FilterItem("name_product","Название продукта"),
                new FilterItem("cost","Цена"),
            };
        }
        public void LoadFilter()
        {
            FilterType = new ObservableCollection<Typeproducta>()
            {
                new Typeproducta("Вафли",false),
                new Typeproducta("Крекер",false),
                new Typeproducta("Печенье",false),
                new Typeproducta("Пряники",false),
                new Typeproducta("Шоколад",false),
                new Typeproducta("Батончик",false),
                new Typeproducta("Бисквит",false),
                new Typeproducta("Рулет",false),
                new Typeproducta("Конфеты",false),
            };
        }
        public IEnumerable<Products> SortMetod(string orderby = "name_product")
        {
            if (OrderbyDesign)
            {
                return Productlist.OrderByDescending(p => p.GetProperty(orderby).GetType() == typeof(string) ? p.GetProperty(orderby).ToString().Replace("«", "").Replace("»", "") : p.GetProperty(orderby));
            }
            else
            {
                return Productlist.OrderBy(p => p.GetProperty(orderby).GetType() == typeof(string) ? p.GetProperty(orderby).ToString().Replace("«", "").Replace("»", "") : p.GetProperty(orderby));
            }

        }
        public void FilerMetod()
        {
            var list = SortMetod(Sortitem.Property).ToList();
            
            list = list.Where(p => p.name_product.ToLower().Contains(Search.ToLower())).ToList();

            var selectedType = FilterType.Where(p => p.IsSelected);

            if (selectedType.Count() > 0)
            {
                foreach (var item in list.ToArray())
                {
                    if (selectedType.FirstOrDefault(p => p.Name.Equals(item.type_product)) == null)
                    {
                        list.Remove(item);
                    }
                    else
                    {
                        continue;
                    }
                }

            }
            if (Maxcost > 0)
            {
                list = list.Where(p => p.cost >= Mincost && p.cost <= Maxcost).ToList();
            }
            list = list.Skip(currentPage * itemonpage).Take(itemonpage).ToList();
            MaxPage();
            OnPropertyChanged(nameof(PageDisplay)); 
            Filterlist = new ObservableCollection<Products>(list);
            if (CurrentPage >= MaxPages)
            {
                
                CurrentPage = MaxPages-1;
            }
        }
        public int MaxPage()
        {
            var list = SortMetod(Sortitem.Property).ToList();

            list = list.Where(p => p.name_product.ToLower().Contains(Search.ToLower())).ToList();

            var selectedType = FilterType.Where(p => p.IsSelected);

            if (selectedType.Count() > 0)
            {
                foreach (var item in list.ToArray())
                {
                    if (selectedType.FirstOrDefault(p => p.Name.Equals(item.type_product)) == null)
                    {
                        list.Remove(item);
                    }
                    else
                    {
                        continue;
                    }
                }
                
            }
            if (Maxcost > 0)
            {
                list = list.Where(p => p.cost >= Mincost && p.cost <= Maxcost).ToList();
            }

            return MaxPages = (int)Math.Ceiling((float)list.Count / (float)itemonpage);

        }


        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string property = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }


        #endregion

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            FilerMetod();
        }

        private void Previous_click(object sender, RoutedEventArgs e)
        {
            if (CurrentPage > 0)
            {
                CurrentPage--;
            }
        }

        private void Next_Click(object sender, RoutedEventArgs e)
        {
            if (CurrentPage+1 < MaxPages)
            { 

                CurrentPage++;
            }
        }

        private void ToggleButton_Checked(object sender, RoutedEventArgs e)
        {
            if (Togle.IsChecked == true)
            {
               
                OrderbyDesign = false;
            }
            if(Togle.IsChecked == false)
            {
                OrderbyDesign = true;
            }
        }

        private void CreateDelivery_Click(object sender, RoutedEventArgs e)
        {
            Create_delivery delivery = new Create_delivery();
            delivery.Show();
        }

        private void Go_Back(object sender, RoutedEventArgs e)
        {
            Authorization authorization = new Authorization();
            authorization.Show();
            this.Close();
        }
    }
}

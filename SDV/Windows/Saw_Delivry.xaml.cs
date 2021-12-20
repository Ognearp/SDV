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

namespace SDV.Windows
{
    /// <summary>
    /// Логика взаимодействия для Saw_Delivry.xaml
    /// </summary>
    public partial class Saw_Delivry : Window, INotifyPropertyChanged
    {
        #region Fields
        private ObservableCollection<Delivery> deliveries;

        #endregion


        #region Property
        public ObservableCollection<Delivery> Deliveries { get => deliveries; set { deliveries = value; OnPropertyChanged(); } }
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
                Deliveries = new ObservableCollection<Delivery>(bd.Delivery);
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

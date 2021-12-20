using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using SDV.Model;

namespace SDV.OtherClass
{
   public class AmountProduct : INotifyPropertyChanged
   {

        private int amountproducts;
        public Products Products { get; set; }

        public int AmountProducts { get => amountproducts; 
            set { amountproducts = value; OnPropertyChanged(); } }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string property = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }
    }
}

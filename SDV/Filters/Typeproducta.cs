using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDV.Filters
{
    public class Typeproducta
    {
        public Typeproducta(string name, bool isSelected)
        {
            Name = name;
            IsSelected = isSelected;
        }

        public string Name { get; set; }


        public bool IsSelected { get; set; }


    }
}

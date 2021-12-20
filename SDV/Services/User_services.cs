using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SDV.Model;

namespace SDV.Services
{
    public class User_services
    {
        private static User_services instance;
        private User_services()
        {

        }
        public static User_services Instance => instance == null ? instance = new User_services() : instance;
        public BaseEmployes CurentEmployees { get; set; }
        
    }


}

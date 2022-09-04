using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Butcher_Shop
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }

    [Serializable]
    public abstract class Product
    {
        string _product_Code;
        string _name;
        float _price;
        public string product_code
        {
            get
            {
                return _product_Code;
            }
            set
            {
                _product_Code = value;
            }
        }
        public string name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }
        public float price
        {
            get
            {
                return _price;
            }
            set
            {
                _price = value;
            }
        }
    }
    [Serializable]
    public class Alchohol:Product
    {
        float _alchohol_Precentage;
        string _country_Source;
        public float alchohol_precentage
        {
            get
            {
                return _alchohol_Precentage;
            }
            set
            {
                _alchohol_Precentage = value;
            }
        }
    }
    [Serializable]
    public class Wine:Alchohol
    {
        string _kind_Of_Grape;
        float _age;
        bool _is_Red;
        bool _is_Dry;
        bool _is_Bubblling;

        public string kind_of_grape
        {
            get
            {
                return _kind_Of_Grape;
            }
            set
            {
                _kind_Of_Grape = value;
            }
        }
        public float age
        {
            get
            {
                return _age;
            }
            set
            {
                _age = value;
            }
        }
        public bool is_red
        {
            get
            {
                return _is_Red;
            }
            set
            {
                _is_Red = value;
            }
        }
        public bool is_dry
        {
            get
            {
                return _is_Dry;
            }
            set
            {
                _is_Dry = value;
            }
        }
        public bool is_bubblling
        {
            get
            {
                return _is_Bubblling;
            }
            set
            {
                _is_Bubblling = value;
            }
        }


    }
    [Serializable]
    public class Beer:Alchohol
    {
        bool _is_Dark;
        bool _is_Filltered;

        public bool is_Dark
        {
            get
            {
                return _is_Dark;
            }
            set
            {
                _is_Dark = value;
            }
        }
        public bool is_Filltered
        {
            get
            {
                return _is_Filltered;
            }
            set
            {
                _is_Filltered = value;
            }
        }
    }
    [Serializable]
    public class other_Alchoholic:Alchohol
    {

    }
    [Serializable]
    public class Meat:Product
    {
        float _fat_Precentage;
        string _origin;

        public float fat_precentage
        {
            get
            {
                return _fat_Precentage;
            }
            set
            {
                _fat_Precentage = value;
            }
        }
        public string origin
        {
            get
            {
                return _origin;
            }
            set
            {
                _origin = value;
            }
        }
    }
    [Serializable]
    public class Fish:Meat
    {
        bool _is_Fillet;
        bool _is_From_Pool;

        public bool is_fillet
        {
            get
            {
                return _is_Fillet;
            }
            set
            {
                _is_Fillet = value;
            }
        }
        public bool is_from_pool
        {
            get
            {
                return _is_From_Pool;
            }
            set
            {
                _is_From_Pool = value;
            }
        }
    }
    [Serializable]
    public class Cuttel:Meat
    {
        int _part_Number;
        bool _is_Grass_Fed;

        public int part_number
        {
            get
            {
                return _part_Number;
            }
            set
            {
                _part_Number = value;
            }
        }
        public bool is_grass_fed
        {
            get
            {
                return _is_Grass_Fed;
            }
            set
            {
                _is_Grass_Fed = value;
            }
        }
    }
    [Serializable]
    public class Chicken:Meat
    {
        string _body_Part;
        bool _is_Free_Growth;

        public string body_part
        {
            get
            {
                return _body_Part;
            }
            set
            {
                _body_Part = value;
            }
        }
        public bool is_free_growth
        {
            get
            {
                return _is_Free_Growth;
            }
            set
            {
                _is_Free_Growth = value;
            }
        }
    }
}

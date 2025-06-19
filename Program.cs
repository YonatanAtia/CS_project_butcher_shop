using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Butcher_Shop
{
    [Serializable]
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
    //************************************************//
    [Serializable]
    public class Product
    {
        protected string _product_Code;
        protected string _product_name;
        protected double _product_price;
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
        public string product_name
        {
            get
            {
                return _product_name;
            }
            set
            {
                _product_name = value;
            }
        }
        public double product_price
        {
            get
            {
                return _product_price;
            }
            set
            {
                _product_price = value;
            }
        }
        public Product() { }
        ~Product() { }
    }
    [Serializable]
    public class Alchohol_Drink:Product
    {
        protected double _Alchohol_Precentage;
        protected string _country_Source;
        public double Alchohol_precentage
        {
            get{return _Alchohol_Precentage;}
            set{_Alchohol_Precentage = value;}
        }
        public string country_source
        {
            get
            {
                return _country_Source;
            }
            set
            {
                _country_Source = value;
            }
        }
        public Alchohol_Drink() { }
        ~Alchohol_Drink() { }
    }
    [Serializable]
    public class Meat : Product
    {
        protected double _fat_Precentage;
        protected string _origin;
        public double fat_precentage
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
        public Meat() { }
        ~Meat() { }
    }
    [Serializable]
    public class Wine:Alchohol_Drink
    {
        string _kind_Of_Grape;
        double _age;
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
        public double age
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
        public Wine(string kind,double age,bool isRed,bool isDry,bool isBubblling,
            double alc_Prec, string source, string code, string name, double price) 
        {
            _kind_Of_Grape = kind;
            _age = age;
            _is_Red = isRed;
            _is_Dry = isDry;
            _is_Bubblling = isBubblling;
            _Alchohol_Precentage = alc_Prec;
            _country_Source = source;
            _product_Code = code;
            _product_name = name;
            _product_price = price;
    }
        ~Wine() { }
    }
    [Serializable]
    public class Beer:Alchohol_Drink
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
        public Beer(bool isDark, bool isFFiltered,
            double alc_Prec, string source, string code, string name, double price) 
        {
            _is_Dark = isDark;
            _is_Filltered = isFFiltered;
            _Alchohol_Precentage = alc_Prec;
            _country_Source = source;
            _product_Code = code;
            _product_name = name;
            _product_price = price;
        }
        ~Beer() { }
    }
    [Serializable]
    public class other_Alchohol_Drink:Alchohol_Drink
    {
        public other_Alchohol_Drink(double alc_Prec, string source, string code, string name, double price) 
        {
            _Alchohol_Precentage = alc_Prec;
            _country_Source = source;
            _product_Code = code;
            _product_name = name;
            _product_price = price;
        }
        ~other_Alchohol_Drink() { }
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
        public Fish(bool isFillet, bool isFromPool, double fatPrecentage, string origin, string productCode, string productName, double price) 
        {
            _is_Fillet = isFillet;
            _is_From_Pool = isFromPool;
            _fat_Precentage = fatPrecentage;
            _origin = origin;
            _product_Code = productCode;
            _product_name = productName;
            _product_price = price;
    }
        ~Fish() { }
    }
    [Serializable]
    public class cattle : Meat
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
        public cattle(int partNum, bool isGrassFed, double fatPrecentage, string origin, string productCode, string productName, double price) 
        {
            _part_Number = partNum;
            _is_Grass_Fed = isGrassFed;
            _fat_Precentage = fatPrecentage;
            _origin = origin;
            _product_Code = productCode;
            _product_name = productName;
            _product_price = price;
        }
        ~cattle() { }
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
        public Chicken(string bodyPart, bool isFreeGrowth, double fatPrecentage, string origin, string productCode, string productName, double price) 
        {
            _body_Part = bodyPart;
            _is_Free_Growth = isFreeGrowth;
            _fat_Precentage = fatPrecentage;
            _origin = origin;
            _product_Code = productCode;
            _product_name = productName;
            _product_price = price;
        }
        ~Chicken() { }
    }
    [Serializable]
    public class CartList // here polymorphism
    {
        protected List<Product> Cart_List;

        static public double totalAmount = 0;
        double totalMoney = 0;
        [Serializable]
        public struct prdDtl
        {
            public string name;
            public int amount;
            public double price;
            public string serialNum;
        }
        
        static public prdDtl[] _prdDtlArr = new prdDtl[18];
        public prdDtl[] _prdDtlArr2 = new prdDtl[18];//Array holds  details of products;
        public CartList()
        {
            Cart_List = new List<Product>();
        }
        static public void zeroPrice()
        {
            _prdDtlArr[0].name = "Hot Dog       ";
            _prdDtlArr[0].serialNum = "425372";

            _prdDtlArr[1].name = "Sinta            ";
            _prdDtlArr[1].serialNum = "397271";

            _prdDtlArr[2].name = "Steak           ";
            _prdDtlArr[2].serialNum = "666666";

            _prdDtlArr[3].name = "Chicken Wings";
            _prdDtlArr[3].serialNum = "665588";

            _prdDtlArr[4].name = "Whole Chicken";
            _prdDtlArr[4].serialNum = "796366";

            _prdDtlArr[5].name = "Chicken legs ";
            _prdDtlArr[5].serialNum = "549131";

            _prdDtlArr[6].name = "Tuna             ";
            _prdDtlArr[6].serialNum = "357148";

            _prdDtlArr[7].name = "Amnon          ";
            _prdDtlArr[7].serialNum = "235777";

            _prdDtlArr[8].name = "Salmon         ";
            _prdDtlArr[8].serialNum = "996378";
            //***********DRINKS**************//
            _prdDtlArr[9].name = "Taquila       ";
            _prdDtlArr[9].serialNum = "548941";

            _prdDtlArr[10].name = "Jin               ";
            _prdDtlArr[10].serialNum = "116633";

            _prdDtlArr[11].name = "Vodka           ";
            _prdDtlArr[11].serialNum = "479966";

            _prdDtlArr[12].name = "Rioja            ";
            _prdDtlArr[12].serialNum = "568648";

            _prdDtlArr[13].name = "Bazelet        ";
            _prdDtlArr[13].serialNum = "684662";

            _prdDtlArr[14].name = "Champagne   ";
            _prdDtlArr[14].serialNum = "467855";

            _prdDtlArr[15].name = "Corona         ";
            _prdDtlArr[15].serialNum = "857433";

            _prdDtlArr[16].name = "Paulaner       ";
            _prdDtlArr[16].serialNum = "152485";

            _prdDtlArr[17].name = "heineken      ";
            _prdDtlArr[17].serialNum = "534813";
            //*********RESSET PRICES & AMOUNTS********//
            for (int i = 0; i < 18; i++)
            {
                _prdDtlArr[i].price = 0;
                _prdDtlArr[i].amount = 0;
            }
        }//SETTING THE PRODUCTS DETAILS;
        public void Add(Product item)
        {
            Cart_List.Add(item);
        }
        public void remove(Product item)
        {
            Cart_List.Remove(item);
        }
        public void copyStruct()
        {
            totalMoney = totalAmount;
            for (int i = 0; i < 18; i++)
            {
                _prdDtlArr2[i] = _prdDtlArr[i];
            }
        }
        public void reversCopyStruct()
        {
            totalAmount = totalMoney;
            for (int i = 0; i < 18; i++)
            {
                _prdDtlArr[i] = _prdDtlArr2[i];
            }
        }
        public void clearList()
        {
            Cart_List.Clear();
        }
        static public void add(int _index, double price)// Adding one product
        {
            _prdDtlArr[_index].amount++;
            _prdDtlArr[_index].price += price;
        }
        static public void sub(int _index, double price) // subbing one product
        {
            if (_prdDtlArr[_index].amount > 0)
                _prdDtlArr[_index].amount--;
            _prdDtlArr[_index].price -= price;
        }
        static public void clear()//CLEARRING THE RECEIPT;
        {
            for (int i = 0; i < 18; i++)
            {
                _prdDtlArr[i].amount = 0;
                _prdDtlArr[i].price = 0;
            }

        }

    }
}

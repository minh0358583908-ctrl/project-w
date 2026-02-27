using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace baitap2702
{
    internal class baitait4
    {
        class Product
        {
            public int Id;
            public string Name;
            public double Price;
            public Product()
            {
            }
            public Product(int id, string name, double price)
            {
                Id = id;
                Name = name;
                Price = price;
            }
            public void ApplyDiscount(double percent)
            {
                Price = Price - (Price * percent / 100);
            }
            public void ApplyDiscount(int amount)
            {
                Price = Price - amount;
            }
            public virtual void DisplayInfo()
            {
                Console.WriteLine("ID: " + Id);
                Console.WriteLine("Name: " + Name);
                Console.WriteLine("Price: " + Price);
            }
        }
        class Monitor : Product
        {
            public string PanelType;
            public string Size;
            public Monitor(int id, string name, double price, string panelType, string size)
                : base(id, name, price)
            {
                PanelType = panelType;
                Size = size;
            }
            public override void DisplayInfo()
            {
                base.DisplayInfo();
                Console.WriteLine("Panel Type: " + PanelType);
                Console.WriteLine("Size: " + Size);
                Console.WriteLine("---------");
            }
        }
        class AudioDevice : Product
        {
            public int OutputPower;
            public bool HasBluetooth;
            public AudioDevice(int id, string name, double price, int outputPower, bool hasBluetooth)
                : base(id, name, price)
            {
                OutputPower = outputPower;
                HasBluetooth = hasBluetooth;
            }
            public override void DisplayInfo()
            {
                base.DisplayInfo();
                Console.WriteLine("Output Power: " + OutputPower + "W");
                Console.WriteLine("Bluetooth: " + HasBluetooth);
                Console.WriteLine("-----------");
            }
        }
        class StoreManager
        {
            List<Product> products = new List<Product>();
            public void AddProduct(Product p)
            {
                products.Add(p);
            }
            public void ShowAllProduct()
            {
                if (products.Count == 0)
                {
                    Console.WriteLine("Kho chua co san pham");
                    return;
                }
                foreach (Product p in products)
                {
                    p.DisplayInfo();
                }
            }
            public Product SearchProduct(int id)
            {
                foreach (Product p in products)
                {
                    if (p.Id == id)
                        return p;
                }
                return null;
            }
            public List<Product> SearchProduct(string name)
            {
                List<Product> result = new List<Product>();

                foreach (Product p in products)
                {
                    if (p.Name.ToLower().Contains(name.ToLower()))
                    {
                        result.Add(p);
                    }
                }
                return result;
            }
        }
        class Program
        {
            static void Main()
            {
                StoreManager store = new StoreManager();
                int choice;
                do
                {
                    Console.WriteLine("\n     MENU      ");
                    Console.WriteLine("1. Them Monitor");
                    Console.WriteLine("2. Them Audio Device");
                    Console.WriteLine("3. Hien thi tat ca san pham");
                    Console.WriteLine("4. Tim san pham theo ten");
                    Console.WriteLine("5. Ap dung giam gia");
                    Console.WriteLine("0. Thoat");
                    Console.Write("Chon: ");
                    choice = int.Parse(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            Console.Write("Id: ");
                            int id = int.Parse(Console.ReadLine());
                            Console.Write("Name: ");
                            string name = Console.ReadLine();
                            Console.Write("Price: ");
                            double price = double.Parse(Console.ReadLine());
                            Console.Write("Panel Type: ");
                            string panel = Console.ReadLine();
                            Console.Write("Size: ");
                            string size = Console.ReadLine();
                            Monitor monitor = new Monitor(id, name, price, panel, size);
                            store.AddProduct(monitor);
                            break;
                        case 2:
                            Console.Write("Id: ");
                            id = int.Parse(Console.ReadLine());
                            Console.Write("Name: ");
                            name = Console.ReadLine();
                            Console.Write("Price: ");
                            price = double.Parse(Console.ReadLine());
                            Console.Write("Output Power: ");
                            int power = int.Parse(Console.ReadLine());
                            Console.Write("Bluetooth (true/false): ");
                            bool bluetooth = bool.Parse(Console.ReadLine());
                            AudioDevice audio = new AudioDevice(id, name, price, power, bluetooth);
                            store.AddProduct(audio);
                            break;
                        case 3:
                            store.ShowAllProduct();
                            break;
                        case 4:
                            Console.Write("Nhap ten can tim: ");
                            string search = Console.ReadLine();
                            List<Product> list = store.SearchProduct(search);
                            foreach (Product p in list)
                            {
                                p.DisplayInfo();
                            }
                            break;
                        case 5:
                            Console.Write("Nhap ID san pham: ");
                            id = int.Parse(Console.ReadLine());
                            Product product = store.SearchProduct(id);
                            if (product != null)
                            {
                                Console.WriteLine("1. Giam theo %");
                                Console.WriteLine("2. Giam theo so tien");
                                int c = int.Parse(Console.ReadLine());
                                if (c == 1)
                                {
                                    Console.Write("Nhap % giam: ");
                                    double percent = double.Parse(Console.ReadLine());
                                    product.ApplyDiscount(percent);
                                }
                                else
                                {
                                    Console.Write("Nhap so tien giam: ");
                                    int money = int.Parse(Console.ReadLine());
                                    product.ApplyDiscount(money);
                                }
                            }
                            else
                            {
                                Console.WriteLine("Khong tim thay san pham");
                            }
                            break;
                    }
                } 
                while (choice != 0);
            }
        }
    }
}


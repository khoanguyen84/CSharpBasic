using System;

namespace ProductManagement {
    class Program {
        public static Shop shop = new Shop ();
        const int addProduct = 1;
        const int removeProduct = 2;
        const int printProduct = 3;
        const int searchProduct = 4;
        const int sortProduct = 5;
        const int exist = 6;
        static void Main (string[] args) {
            int selector = 0;
            do {
                Console.WriteLine ("================Menu================");
                Console.WriteLine ("1. Add new product");
                Console.WriteLine ("2. Remove product");
                Console.WriteLine ("3. Iterate product list");
                Console.WriteLine ("4. Search product");
                Console.WriteLine ("5. Sort product list");
                Console.WriteLine ("6. Exit");
                Console.Write ("Please choice feature: ");
                int.TryParse (Console.ReadLine (), out selector);

                Process (selector);

            }
            while (selector != exist);
        }

        static void Process (int selector) {
            Console.Clear ();
            switch (selector) {
                case addProduct:
                    {
                        CreateProduct ();
                        break;
                    }
                case removeProduct:
                    {
                        DeleteProduct ();
                        break;
                    }
                case printProduct:
                    {
                        shop.IteratorProductList ();
                        break;
                    }
                case searchProduct:
                    {
                        FilterProduct ();
                        break;
                    }
                case sortProduct:
                    {
                        shop.SortProductByPrice ();
                        break;
                    }
                case exist:
                    {
                        Environment.Exit (0);
                        break;
                    }
                default:
                    {
                        Console.WriteLine ("The feature not found!\nPlease choice number 1 -> 5.");
                        break;
                    }
            }
        }

        static void CreateProduct () {
            Console.Write ("Enter Product Name: ");
            string productName = Console.ReadLine ();
            Console.Write ("Enter Description: ");
            string desciption = Console.ReadLine ();
            Console.Write ("Enter Price: ");
            double price = double.Parse (Console.ReadLine ());
            Product product = new Product (productName, desciption, price);
            shop.AddProduct (product);
        }

        static void DeleteProduct () {
            Console.Write ("Enter Product Name: ");
            string productName = Console.ReadLine ();
            shop.RemoveProduct (productName);
        }

        static void FilterProduct () {
            Console.Write ("Enter Price Start: ");
            double priceStart = double.Parse (Console.ReadLine ());
            Console.Write ("Enter Price End: ");
            double priceEnd = double.Parse (Console.ReadLine ());
            shop.SearchProduct (priceStart, priceEnd);
        }
    }
}
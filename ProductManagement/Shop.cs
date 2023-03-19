using System;
namespace ProductManagement
{
    class Shop
    {
        Product[] ProductList = new Product[0];

        public void AddProduct(Product newProduct){
            int length = ProductList.Length ;
            Array.Resize(ref ProductList, length + 1);
            ProductList[length] = newProduct;
        }

        public void IteratorProductList(){
            for (int i = 0; i < ProductList.Length; i++)
            {
                ProductList[i].ViewInfo();
            }
        }

        public void RemoveProduct(string name){
            int position = FindProductByName(name);
            if(position != -1){
                for(int i=position; i < ProductList.Length - 1; i++){
                    ProductList[i] = ProductList[i + 1];
                }
            }
            Array.Resize(ref ProductList, ProductList.Length - 1);
        }

        public void SearchProduct(double priceStart, double priceEnd){
            for(int i= 0 ; i< ProductList.Length; i++){
                if(ProductList[i].Price >= priceStart && ProductList[i].Price <= priceEnd){
                    ProductList[i].ViewInfo();
                }
            }
        }

        public void SortProductByPrice(){
            Product tempProduct = ProductList[0];
            for(int i = 0; i < ProductList.Length - 1; i++){
                for(int j = i + 1; j < ProductList.Length; j++){
                    if(ProductList[i].Price > ProductList[j].Price){
                        tempProduct = ProductList[i];
                        ProductList[i] = ProductList[j];
                        ProductList[j] = tempProduct;
                    }
                }
            }
            IteratorProductList();
        }

        private int FindProductByName(string name){
            for(int i= 0 ; i< ProductList.Length; i++){
                if(ProductList[i].Name == name){
                    return i;
                }
            }
            return -1;
        }
    }
}
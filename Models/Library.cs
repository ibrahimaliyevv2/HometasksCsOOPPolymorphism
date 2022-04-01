using System;
namespace Models
{
    public class Library
    {
        Product[] Products = new Product[0];
        Product[] FilteredProducts = new Product[0];

        public void AddProduct(Product Product)
        {
            Array.Resize(ref Products, Products.Length+1);
            Products[Products.Length - 1] = Product;
        }

        public Product[] GetProductsByPrice(double minPrice, double maxPrice)
        {
            int j = 0;

            foreach (var item in Products)
            {
                if(item.Price>=minPrice && item.Price <= maxPrice)
                {
                    Array.Resize(ref FilteredProducts, FilteredProducts.Length + 1);
                    FilteredProducts[FilteredProducts.Length - 1] = item;
                    j++;
                }
            }
            return FilteredProducts;
        }

        public Product[] GetProductsByName(string name)
        {
            int j = 0;

            foreach (var item in Products)
            {
                if (item.Name == name)
                {
                    Array.Resize(ref FilteredProducts, FilteredProducts.Length + 1);
                    FilteredProducts[FilteredProducts.Length - 1] = item;
                    j++;
                }
            }
            return FilteredProducts;
        }
    }
}

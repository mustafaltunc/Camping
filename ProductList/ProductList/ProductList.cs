using System;

namespace ProductList
{
    class ProductList
    {
        static void Main(string[] args)
        {
            PhoneProduct ProductOne = new PhoneProduct();
            ProductOne.DiscountRatio = 5;
            ProductOne.ProductName = "iPhone 12 Pro Max";
            ProductOne.ProductBrand = "Apple";
            ProductOne.ProductPrice = 12.500;
            ProductOne.Discount = (ProductOne.ProductPrice - (ProductOne.ProductPrice * ( (ProductOne.DiscountRatio) / 100) ));

            PhoneProduct ProductTwo = new PhoneProduct();
            ProductTwo.DiscountRatio = 3;
            ProductTwo.ProductName = "iPhone SE";
            ProductTwo.ProductBrand = "Apple";
            ProductTwo.ProductPrice = 5200;
            ProductTwo.Discount = (ProductTwo.ProductPrice - (ProductTwo.ProductPrice * ((ProductTwo.DiscountRatio) / 100)));

            PhoneProduct ProductThree = new PhoneProduct();
            ProductThree.DiscountRatio = 24;
            ProductThree.ProductName = "Samsung Galaxy S20 Ultra SM-G988B";
            ProductThree.ProductBrand = "Samsung";
            ProductThree.ProductPrice = 12.499;
            ProductThree.Discount = (ProductThree.ProductPrice - (ProductThree.ProductPrice * ((ProductThree.DiscountRatio) / 100)));





            PhoneProduct[] phones = new PhoneProduct[] { ProductOne, ProductTwo, ProductThree };

            Console.WriteLine("-----------for-----------");
            //for
            for (int i = 0; i < phones.Length; i++)
            {
                Console.WriteLine(phones[i].ProductName + " " + phones[i].ProductBrand + " : " + phones[i].Discount);

            }

            Console.WriteLine("-----------foreach-----------");
            //foreach
            foreach (var product in phones)
            {
                Console.WriteLine(product.ProductName + " " + product.ProductBrand + " : " + product.Discount);
                
            }
                


        }
    }

    class PhoneProduct
    {
        public string ProductName { get; set; }
        public string ProductBrand { get; set; }

        public double ProductPrice { get; set; }

        public double Discount { get; set; }
        public double DiscountRatio { get; set; }
    }
}

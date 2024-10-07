namespace GeoLabExercise._1
{

    internal class Program
    {
        static void Main(string[] args)
        {

           
            Person person = new Person();

            person.Name = "Giorgi";
            person.Age = 25;

            person.GetInfo();

            Car car = new Car();

            car.Brand = "Mustang";
            car.Year = 2026;
            car.GetCarInfo();

            Product product = new Product();
            

            product.Name = "Cheese";
            product.Price = -100;
            product.MoneyType = Currency.USD;

            product.GetProductInfo();

        }

        class Person
        {
            public string Name { get; set; }

            public byte Age { get; set; }



            public void GetInfo()
            {
                if (Age < 0)
                {
                    Age = 0;
                }
                else if (Age > 120)
                {
                    Age = 120;
                }

                Console.WriteLine($"Person name is {Name} and age is {Age}");
            }

        }

        class Car
        {
            public string Brand { get; set; }

            public int Year { get; set; }

            public void GetCarInfo()
            {
                DateTime dateTime = DateTime.Now;

                if (Year < 1886)
                {
                    Year = 1886;
                }
                else if (Year > dateTime.Year)
                {
                    Year = dateTime.Year;
                }

                Console.WriteLine($"Brand {Brand} Year {Year}");

            }



        }

        class Product
        {
            public string Name { get; set; }

            public decimal Price { get; set; }

            public Currency MoneyType { get; set; }

            public void GetProductInfo()
            {
                if(Price < 0)
                {
                    Price = 0;
                }

                Console.WriteLine($"Product Name - {Name} Product Price - {Price} Product Currency - {MoneyType}");
            }
        }

        enum Currency
        {
            GEl,
            USD,
            EUR
        }
    }
}

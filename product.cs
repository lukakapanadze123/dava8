namespace lessione8
{
    internal class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public bool Nuts { get; set; }
        public string Image { get; set; }
        public bool Vegeterian { get; set; }
        public int Spiciness { get; set; }
        public string Category { get; set; }

        public Product(int id, string name, decimal price, bool nuts, string image, bool vegeterian, int spiciness, string category)
        {
            Id = id;
            Name = name;
            Price = price;
            Nuts = nuts;
            Image = image;
            Vegeterian = vegeterian;
            Spiciness = spiciness;
            Category = category;
        }



     
        public void ShowInfo()
        {
            Console.WriteLine($"Id: {Id}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Price: {Price}");
            Console.WriteLine($"Nuts: {Nuts}");
            Console.WriteLine($"Image: {Image}");
            Console.WriteLine($"Vegeterian: {Vegeterian}");
            Console.WriteLine($"Spiciness: {Spiciness}");
            Console.WriteLine($"Category: {Category}");
        }

        public bool IsSpicy()
        {
            return Spiciness > 0;
        }

        public bool ApplyDiscount(decimal percent)
        {
            if (percent < 0 || percent > 100)
            {
                return false;
            }

            Price = Price - Price * percent / 100;
            return true;
        }

   
        public bool UpdateName(string newName)
        {
            if (newName == "")
            {
                return false;
            }

            Name = newName;
            return true;
        }


        public bool UpdatePrice(decimal newPrice)
        {
            if (newPrice < 0)
            {
                return false;
            }

            Price = newPrice;
            return true;
        }


        public bool UpdateSpiciness(int newSpiciness)
        {
            if (newSpiciness < 0)
            {
                return false;
            }

            Spiciness = newSpiciness;
            return true;
        }

        public bool UpdateCategory(string newCategory)
        {
            if (newCategory == "")
            {
                return false;
            }

            Category = newCategory;
            return true;
        }




        public bool IsSuitableFor(bool onlyVegetarian, bool noNuts)
        {
            if (onlyVegetarian && !Vegeterian)
            {
                return false;
            }

            if (noNuts && Nuts)
            {
                return false;
            }

            return true;
        }
    }
}
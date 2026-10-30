namespace dava8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product pizza = new Product(1, "Margherita", 12.5m, false, "margherita.jpg", true, 0, "Pizza");
            Product curry = new Product(2, "Chicken Curry", 18m, true, "curry.jpg", false, 3, "Main");

            pizza.ShowInfo();

            if (pizza.IsSpicy())
            {
                Console.WriteLine("This product is spicy");
            }
            else
            {
                Console.WriteLine("This product is not spicy");
            }

            if (pizza.IsSuitableFor(true, true))
            {
                Console.WriteLine("Suitable for vegetarians without nuts");
            }
            else
            {
                Console.WriteLine("Not suitable for vegetarians without nuts");
            }

            bool isDiscounted = pizza.ApplyDiscount(20);

            if (isDiscounted)
            {
                Console.WriteLine($"Price after 20% discount: {pizza.Price}");
            }
            else
            {
                Console.WriteLine("Invalid discount");
            }



            Console.WriteLine();
            curry.ShowInfo();

            if (curry.IsSpicy())
            {
                Console.WriteLine("This product is spicy");
            }
            else
            {
                Console.WriteLine("This product is not spicy");
            }

            if (curry.IsSuitableFor(true, true))
            {
                Console.WriteLine("Suitable for vegetarians without nuts");
            }
            else
            {
                Console.WriteLine("Not suitable for vegetarians without nuts");
            }
        }
    }
}
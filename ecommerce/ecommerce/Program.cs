namespace ecommerce
{
    internal class Program
    {
        static void Main(string[] args)
        {
          
            createUser createUser = new createUser();
            while (true)
            {
                Console.WriteLine("Press 1 to create user 0 for exit ");
              var  choice = Console.ReadLine();
                if (choice == "0")
                {
                    break;
                }
                else if (choice == "1")
                {
                    Console.WriteLine("Enter the name of the user : ");
                    createUser.createuser(Console.ReadLine());
                    break;
                }
                else
                {
                    Console.WriteLine("Provide valid input ! ");
                }
            }
            Console.WriteLine("/----------------------/\n");
            Console.WriteLine("Your Deatils :-\n");
            createUser.display();
            Console.WriteLine("/----------------------/\n");
            Console.WriteLine("Product Details :- \n");
            all_items allitem=new all_items();
           addToCart add = new addToCart();
            allitem.display();
            Console.WriteLine("Your Cart : ");
            allitem.cartItems();
        }
    }
}

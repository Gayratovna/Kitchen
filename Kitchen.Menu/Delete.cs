using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Kitchen.Menu
{
    public class Delete
    {
        Menu menu = new Menu();
        public string[] listKitchen = new string[10];



        public void NationalFoods()
        {

            Console.WriteLine();
            Console.WriteLine("Current foods:");
            Console.WriteLine("-------------------------");

            for (int i = 0; i < menu.listKitchen.Length; i++)
            {
                if (!string.IsNullOrEmpty(listKitchen[i]))
                    Console.WriteLine($"Food {i + 1}: {listKitchen[i]}");
            }

            Console.WriteLine("-------------------------");
        }


        Menu menu1 = new Menu();
        public string[] fFoods = new string[10];



        public void FastFoods()
        {

            Console.WriteLine();
            Console.Write("Enter the food description: ");
            string foods = Console.ReadLine();

            for (int i = 0; i < menu1.fastFoods.Length; i++)
            {
                if (string.IsNullOrEmpty(listKitchen[i]))
                {
                    fFoods[i] = foods;
                    Console.WriteLine("food added successfully.");
                    return;
                }
            }

            Console.WriteLine("Food limit exceeded. Unable to add food.");
        }
        Menu menu2 = new Menu();
        public string[] listDrinks = new string[10];

        public void Drinks()
        {
            Console.WriteLine();
            Console.Write("Enter the food number to update: ");
            int foodNumber = Convert.ToInt32(Console.ReadLine());

            if (foodNumber < 1 || foodNumber > menu.listDrinks.Length)
            {
                Console.WriteLine("Invalid food number.");
                return;
            }

            Console.Write("Enter the new food description: ");
            string foods = Console.ReadLine();
            listKitchen[foodNumber - 1] = foods;

            Console.WriteLine("Food updated successfully.");
        }

        public void DeleteFood(string Name)
        {
            Console.WriteLine();
            Console.Write("Enter the food number to delete: ");
            int foodNumber = Convert.ToInt32(Console.ReadLine());

            

            if (foodNumber < 1 || foodNumber > menu.listKitchen.Length)
            {
                Console.WriteLine("Invalipublic number.");
                return;
            }

            listKitchen[foodNumber - 1] = null;
            Console.WriteLine("Food deleted successfully.");
        }

        public void DeleteFastFood()
        {
            Console.WriteLine();
            Console.Write("Enter the food number to delete: ");
            int foodNumber = Convert.ToInt32(Console.ReadLine());

            if (foodNumber < 1 || foodNumber > menu.fastFoods.Length)
            {
                Console.WriteLine("Invalipublic number.");
                return;
            }

            listKitchen[foodNumber - 1] = null;
            Console.WriteLine("Food deleted successfully.");
        }
        
    }
}


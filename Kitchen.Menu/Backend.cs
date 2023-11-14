using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kitchen.Menu
{
    public class Backend
    {
        
            public void GetInfo()
            {
                Menu menu = new Menu();
            for (int i = 0; i < menu.res.Length / 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write(menu.res[i, j] + "\t");
                }
                Console.WriteLine();
            }

           


        }
            public void SearchFood(string foodName)
            {
                Menu menu = new Menu();
                bool IsThisFood = false;
                int i_value = 0, j_value = 0;
                for (int i = 0; i < menu.listKitchen.Length / 2; i++)
                {
                    for (int j = 0; j < 2; j++)
                    {
                        if (menu.listKitchen[i, j].ToLower() == foodName.ToLower())
                        {
                            i_value = i;
                            j_value = j;
                            IsThisFood = true;
                        }
                    }
                    Console.WriteLine();

                }
                if (IsThisFood == true)
                {
                    Console.WriteLine("Foods: " + menu.listKitchen[i_value, j_value]);
                    Console.WriteLine("Price: " + menu.listKitchen[i_value, j_value + 1]);
                  
                   
                }
                else
                {
                    Console.WriteLine("This is not food");
                }
            }
        public void SearchFastFood(string fFoodName)
        {
            Menu menu = new Menu();
            bool IsThisfFood = false;
            int i_value = 0, j_value = 0;
            for (int i = 0; i < menu.fastFoods.Length / 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    if (menu.fastFoods[i, j].ToLower() == fFoodName.ToLower())
                    {
                        i_value = i;
                        j_value = j;
                        IsThisfFood = true;
                    }
                }
                Console.WriteLine();

            }
            if (IsThisfFood == true)
            {
                Console.WriteLine("Foods: " + menu.fastFoods[i_value, j_value]);
                Console.WriteLine("Price: " + menu.fastFoods[i_value, j_value + 1]);


            }
            else
            {
                Console.WriteLine("This is not fFood");
            }
        }
        public void SearchDrinks(string drinkName)
        {
            Menu menu1 = new Menu();
            bool IsThisDrinks = false; ;
            int i_value = 0, j_value = 0;
            for (int i = 0; i < menu1.listDrinks.Length / 3; i += 2)
            {
                for (int j = 0; j < 3; j += 2)
                {
                    if (menu1.listDrinks[i, j].ToLower() == drinkName.ToLower())
                    {
                        i_value = i;
                        j_value = j;
                        IsThisDrinks = false;
                    }
                }
                Console.WriteLine();

            }
            if (IsThisDrinks == false)
            {
                Console.WriteLine("Drink: " + menu1.listDrinks[i_value, j_value]);
                Console.WriteLine("Price: " + menu1.listDrinks[i_value, j_value + 1]);
                Console.WriteLine("Price: " + menu1.listDrinks[i_value, j_value + 2]);


            }
            else
            {
                Console.WriteLine("This is not drinks");
            }
        }
    }
    }



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
                    Console.Write("Foods: " + menu.listKitchen[i_value, j_value]);
                    Console.Write("Price: " + menu.listKitchen[i_value, j_value + 1]);
                  
                   
                }
                else
                {
                    Console.WriteLine("This is not food");
                }
            }
       
    }
}



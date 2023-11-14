using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kitchen.Menu
{
    public class Menu
    {
        public bool isAdded = false;
        public string[,] res =
        {
            {"Kabob", "18000"},
            {"Somsa",    "8000"},
            {"Norin",    "15000"},
            {"Soup",     "12000"},
            {"Pizza",  "75000"},
            {"Haggi",  "25000"},
            {"Clap",   "28000"},
            {"Lavash", "10000"},
            {"Juice", "1l = 8000 1.5l = 12000"},
            {"Fanta", "1l = 10000 1.5l = 12000"},
            {"Pepsi", "1l = 9000 1.5l = 12000"},
            {"Cola", "1l = 11000 1.5l = 12000"},
        };

        public string[,] kitchenList = new string[12, 2];
        public string[,] listKitchen =
        {
            {"Shashlik", "18000"},
            {"Somsa",    "8000"},
            {"Norin",    "15000"},
            {"Soup",     "12000"},
        };
        public string[,] fastFoods =
        {
            {"Pizza",  "75000"},
            {"Haggi",  "25000"},
            {"Clap",   "28000"},
            {"Lavash", "10000"},

        };
        public string[,] listDrinks =
        {
            {"Juice", "1l = 8000", "1.5l = 12000"},
            {"Fanta", "1l = 10000", "1.5l = 14000"},
            {"Pepsi", "1l = 9000", "1.5l = 13000"},
            {"Cola", "1l = 11000", "1.5l = 15000"},

        };
        public void IsDeleteInfo(string food_name)
        {
            bool IsFound = false;
            for (int i = 0; i < listKitchen.Length / 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    if (listKitchen[i, j] == food_name)
                    {
                        IsFound = true;
                        listKitchen[i, j] = null;
                        listKitchen[i, (j + 1)] = null;


                    }

                }

            }
            for (int i = 0; i < res.Length / 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    if (res[i, j] == food_name)
                    {
                        IsFound = true;
                        res[i, j] = null;
                        res[i, (j + 1)] = null;


                    }

                }

            }
            if (IsFound == false)
            {
                Console.WriteLine("Not Found");
            }
        }
        public void IsDeleteFastFood(string fastFood_name)
        {
            bool IsFound = false;
            for (int i = 0; i < fastFoods.Length / 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    if (fastFoods[i, j] == fastFood_name)
                    {
                        IsFound = true;
                        fastFoods[i, j] = null;
                        fastFoods[i, (j + 1)] = null;

                    }

                }

            }
            if (IsFound == false)
            {
                Console.WriteLine("Not Found");
            }
        }
        public void IsDeleteDrinks(string drink_name)
        {
            bool IsFound = false;
            for (int i = 0; i < listDrinks.Length / 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (listDrinks[i, j] == drink_name)
                    {
                        IsFound = true;
                        listDrinks[i, j] = null;
                        listDrinks[i, (j + 1)] = null;
                        listDrinks[i, (j + 2)] = null;
                    }

                }

            }
            if (IsFound == false)
            {
                Console.WriteLine("Not Found");
            }
        }
        public void GetAllInfo()
        {
            if (isAdded == false)
            {
                for (int i = 0; i < res.Length / 2; i++)
                {
                    int count = 0;
                    for (int j = 0; j < 2; j++)
                    {
                        if (res[i, j] != null)
                        {
                            Console.Write(res[i, j] + " ");
                        }
                        else
                        {
                            count++;
                        }

                    }
                    if (count != 2)
                    {
                        Console.WriteLine();
                    }

                }
            }
            else
            {
                for (int i = 0; i < kitchenList.Length / 2; i++)
                {
                    int count = 0;
                    for (int j = 0; j < 2; j++)
                    {
                        if (res[i, j] != null)
                        {
                            Console.Write(kitchenList[i, j] + " ");
                        }
                        else
                        {
                            count++;
                        }

                    }
                    if (count != 2)
                    {
                        Console.WriteLine();
                    }
                }

            }

             void ClearAllInfo()
            {
                if (res != null)
                {
                    for (int i = 0; i < res.Length / 2; i++)
                    {
                        for (int j = 0; j < 2; j++)
                        {
                            res[i, j] = null;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Baza Mavjud emas");
                }
            }
              void AddOneFood
                (
                string food_name,
                string food_price
                )
            {
                bool isfound = false;
                for (int i = 0; i < res.Length / 2; i++)
                {
                    for (int j = 0; j < 2; j++)
                    {
                        if (res[i, j].ToString().ToLower() == food_name.ToString().ToLower()) ;
                        {
                            isfound = true;
                            Console.WriteLine("Bu taom menyuda bor");
                        }

                    }
                }
                if (isfound == false)
                {
                    for (int i = 0; i < listKitchen.Length / 2; i++)
                    {
                        for (int j = 0; j < 4; j++)
                        {
                            kitchenList[i, j] = res[i, j];
                        }
                    }
                    kitchenList[2, 0] = food_name;
                    kitchenList[2, 1] = food_price;
                }
            }
        }
    }
}

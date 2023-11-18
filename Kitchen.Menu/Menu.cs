using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kitchen.Menu
{
    public class Menu
    {
        private decimal priceSum;
        private int count = 0;

        public bool isAdded = false;

        public string[,] listKitchen =
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
        public string[,] res = new string[13, 2];


        public void AllSellFood()
        {
            Console.WriteLine($"Money: {this.priceSum}");
        }

        public void IsDeleteInfo(string food_name)
        {
            bool isfound = false;
            for (int i = 0; i < listKitchen.Length / 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    if (listKitchen[i, j] == food_name)
                    {
                        isfound = true;
                        //code delete
                        listKitchen[i, j] = null;
                        listKitchen[i, (j + 1)] = null;


                    }

                }

            }
            if (isfound == false)
            {
                Console.WriteLine("Not Found");

            }

        }
        public void GetAllInfo()
        {
            if (isAdded == false)
            {
                for (int i = 0; i < listKitchen.Length / 2; i++)
                {
                    int count = 0;
                    for (int j = 0; j < 2; j++)
                    {
                        if (listKitchen[i, j] != null)
                        {
                            Console.WriteLine(listKitchen[i, j]);

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

                for (int i = 0; i < res.Length / 2; i++)
                {
                    int count = 0;
                    for (int j = 0; j < 2; j++)
                    {
                        if (res[i, j] != null)
                        {
                            Console.WriteLine(res[i, j]);

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


        }

        public void ClearAllInfo()
        {
            if (listKitchen != null)
            {
                for (int i = 0; i < listKitchen.Length / 2; i++)
                {
                    for (int j = 0; j < 2; j++)
                    {
                        listKitchen[i, j] = null;


                    }

                }

            }
            else
            {
                Console.WriteLine("Not on the menu");
            }


        }

        public void AddOneFood(string food_name, string food_price)
        {
            bool isfound = false;

            for (int i = 0; i < listKitchen.Length / 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    
                    if (listKitchen[i, j] == food_name)
                    {
                        isfound = true;
                        Console.WriteLine("I'ts on the menyu ");

                    }

                }


            }
            if (isfound == false && res[0, 0] == null)
            {
                isAdded = true;
                for (int i = 0; i < listKitchen.Length / 2; i++)
                {
                    for (int j = 0; j < 2; j++)
                    {
                        res[i, j] = listKitchen[i, j];

                    }

                }


                res[listKitchen.Length / 2, 0] = food_name;
                res[listKitchen.Length / 2, 1] = food_price;

                Console.WriteLine("A new dish has been added to the menu1");

            }
            if (isfound == false && count == 1)
            {
                int row = 0;
                for (int i = 0; i < res.Length / 2; i++)
                {
                    for (int j = 0; j < 2; j++)
                    {
                        if (res[i, j] == null)
                        {
                            row = i;
                        }
                        break;

                    }

                }

                res[row, 0] = food_name;
                res[row, 1] = food_price;
                

                Console.WriteLine("A new dish has been added to the menu");

            }
            count = 1;

        }
        //Topshiriq
        public void OneUpdateFood(string food_name, decimal price)
        {
            bool res = false;
            for (int i = 0; i < listKitchen.Length / 2; i++)
            {
                for (int j = 0; j < 2; j ++)
                {
                    if (listKitchen[i, j].ToLower() ==food_name.ToLower())
                    {
                        res = true;

                        listKitchen[i, j] = food_name;
                        listKitchen[i, j + 1] = price.ToString();
                       

                        Console.WriteLine($"This is {food_name} food information update");




                    }
                }

            }

            if (res == false)
            {
                Console.WriteLine("Not Found");

            }



        }




        public void SellFoods(string food_name)
        {
            bool res = false;
            for (int i = 0; i < listKitchen.Length / 2; i++)
            {
                for (int j = 0; j < 2; j ++)
                {
                    if (listKitchen[i, j].ToLower() == food_name.ToLower())
                    {
                        res = true;
                        priceSum += Convert.ToDecimal(listKitchen[i, j + 1]);


                    }

                }

            }

            if (res == false)
            {
                Console.WriteLine("Not Found");

            }


        }






    }
}




    

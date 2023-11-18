using Kitchen.Menu;

Menu menu = new Menu();


Console.WriteLine("======= Welcome our to the Kitchen =======");
Console.WriteLine("1.View all foods");
Console.WriteLine("2.Add single food information");
Console.WriteLine("3.Sell one food");
Console.WriteLine("4.List of sold books");
Console.WriteLine("5.Delete one food information");
Console.WriteLine("6.Update single food data");



belgi:
Console.Write("Enter command: ");
int command = int.Parse(Console.ReadLine());

if (command == 1)
{
    menu.GetAllInfo();

}
if (command == 2)
{
    Console.Write("Enter foods/drinks name: ");
    string foodName = Console.ReadLine();
    Console.Write("Enter food price: ");
    string foodPrice = Console.ReadLine();
    

    menu.AddOneFood(foodName, foodPrice);
}
if (command == 3)
{
    Console.Write("Enter foods/drinks name: ");
    string name = Console.ReadLine();
    menu.SellFoods(name);

}

if (command == 4)
{
    menu.AllSellFood();

}

if  (command == 5)
{
    Console.Write("Enter foodds/drinks name: ");
    string foodName = Console.ReadLine();
    

    menu.IsDeleteInfo(foodName);

}
if (command == 6)
{
    Console.Write("Enter foods/drinks name: ");
    string foodName = Console.ReadLine();
    Console.Write("Enter food price: ");
    decimal foodPrice = decimal.Parse(Console.ReadLine());
    
    menu.OneUpdateFood(foodName, foodPrice);

}
Console.WriteLine("============================");
goto belgi;

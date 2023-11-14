
using Kitchen.Menu;

Menu menu = new Menu();
menu.IsDeleteDrinks("Pepsi");


public void AddOneBook(string book_name, int book_price, string book_writer)
{
    bool isfound = false;
    for (int i = 0; i < @book.Length / 3; i++)
    {
        for (int j = 0; j < 3; j += 3)
        {
            if (book_name == @book[i, j])
            {
                isfound = true;
                Console.WriteLine(" Bumaqa kitob mavjud");
            }

        }

    }

    if (isfound == true)
    {
        isfound = false;

        for (int i = 0; i < @book.Length / 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                @book1[i, j] = @book[i, j];

            }

        }
        @book[6, 0] = book_name;
        @book[6, 1] = book_price.ToString();
        @book[6, 2] = book_writer;
    }
}
/// <summary>
/// Bitta malumotni yangilash
/// </summary>
/// <param name="book_name"></param>
public void UpdateOneInfo(string book_name)
{

}
/// <summary>
/// Hamma malumotni uchirish
/// </summary>
public void DeleteAllData()
{

}

/// <summary>
/// qushimcha funksiya
/// </summary>
/// <param name="book_name"></param>
/// <returns></returns>
public bool IsThere(string book_name)
{
    bool IsThere = false;
    for (int i = 0; i < book_name.Length / 3; i++)
    {
        for (int j = 0; j < 3; j++)
        {
            if (book_name == @book[i, j])
            {
                IsThere = true;
            }
        }

    }
    return IsThere;
}
/// <summary>
/// 
/// </summary>
/// <param name="book_name"></param>
public void SellBook(string book_name)
{
    for (int i = 0; i < book_name.Length / 3; i++)
    {
        for (int j = 0; j < 3; j += 3)
        {
            if (@book[i, j] == book_name)
            {
                sotilgankitoblarRuyhati += Convert.ToDouble(@book[i, j + 1]);
            }
        }
    }

}

    }


}


/*bool exit = false;

while (!exit)
{

    Console.WriteLine("-----------MENU--------------");
    Console.WriteLine("1. Umumiy taomlar");
    Console.WriteLine("2. Fast Foods");
    Console.WriteLine("3. Bizda mavjudDrinks");
    Console.WriteLine("4. Taomni ruyhatdan olish ");
    Console.WriteLine("5. Tizimdan chiqish");
    Console.WriteLine("-------------------------");

    Console.Write("Enter your choice (1-5): ");
    int choice = Convert.ToInt32(Console.ReadLine());

    switch (choice)
    {
        case 1:
            del.NationalFoods();
            break;
        case 2:
            del.FastFoods();
            break;
        case 3:
            del.Drinks();
            break;
        case 4:
            del.DeleteFood("Norin");
            break;
        case 5:
            exit = true;
            break;
        default:
            Console.WriteLine("Invalid choice. Please enter a number between 1 and 5.");
            break;
    }

    Console.WriteLine();
}

*/



Console.WriteLine ("Введите имя пользователя");
string username = Console.ReadLine();

if (username.ToLower == "Маша")
    {
        Console.WriteLine("Привет, Маша!");
    }
    else 
    {
        Console.Write ("Привет ");
        Console.WriteLine (username);
    }
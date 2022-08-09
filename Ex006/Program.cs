Console.Write("Введите имя пользователя:");
string username = Console.ReadLine();
    if (username.ToLower() == "аня")
    {
         Console.WriteLine("Ура! Это же Аня");
    }
    else
    {
        Console.Write("Привет");
        Console.Write(username);
    }
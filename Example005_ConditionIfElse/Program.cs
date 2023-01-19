Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "руслан")
{
    Console.WriteLine("Ура, это же Руслан!");
}

else 
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}

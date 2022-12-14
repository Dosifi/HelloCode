Console.Write("Введите имя пользователя");
string username = Console.ReadLine();

if(username.ToLower() == "mary")
{
Console.WriteLine("Ура, это же Mary!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}
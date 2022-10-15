Console.WriteLine("Введите имя пользователя:");
string username = Console.ReadLine();
if(username.ToLower() == "женя")
{
    Console.WriteLine("Привет, капитан!");
}
else
{
    Console.Write("Привет, ");
    Console.Write(username);
}
  
 Console.Write("Введите имя пользователя: ");
 string username = Console.ReadLine();

if(username.ToLower() == "диана")
{
    Console.WriteLine("Ура, это же ДИАНА!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}
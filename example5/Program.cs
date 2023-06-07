Console.Write("Введите Ваше имя ");
string username = Console.ReadLine();
if (username.ToLower() == "джана")
{
    Console.Write("Ура, это же Джана!");
}
else
{
    Console.Write("Привет, ");
    Console.Write(username);
}
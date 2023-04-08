Console.WriteLine("Write UserName: ");
string username = Console.ReadLine();

if (username.ToLower() == "Olha") //ToLower() - переводит все символы строки в нижний регистр (это для того чтобы проверить совпадение только по буквам без учёта их регистра)
{
    Console.WriteLine("You wery COOL, " + username + " !");
}
else
{
    Console.WriteLine("Hello, " + username + " ! ");
}

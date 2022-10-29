Console.Write("Как тебя зовут? ");
string username = Console.ReadLine();

if (username.ToLower() == "маша")
{
    Console.WriteLine("Ойёй, тебе особый привет :)");
}
else
{
    Console.Write("Ну привет, ");
    Console.WriteLine(username);
}
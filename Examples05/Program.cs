// Individual greeting

Console.Write("Enter your uzername: ");

string username = Console.ReadLine();

if(username.ToLower() == "маша")
{
    Console.WriteLine("Ура, это же МАРИЯ!");
}

else{

    Console.Write("Hello, ");
    Console.WriteLine(username);
}
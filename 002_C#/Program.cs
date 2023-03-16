// Console.WriteLine("Введите Има");
// string username = Console.ReadLine();
// Console.WriteLine("Привет, ");
// Console.WriteLine(username);

// int numberA = 3;
// int namberb = 5;
// int result = numberA + namberb;
// Console.WriteLine(result);



// double numberA = new Random().Next(1, 10);
// Console.WriteLine(numberA);
// double namberb = new Random().Next(1, 10);
// Console.WriteLine(namberb);
// double result = numberA + namberb;
// Console.WriteLine(result);



Console.Write("Введите имя:  ");
string username = Console.ReadLine();

if(username.ToLower() == "маша")
{
    Console.WriteLine("Ура маша");
}
else
{
    Console.WriteLine("Привет -  " + username);
}
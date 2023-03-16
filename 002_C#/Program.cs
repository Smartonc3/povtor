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



// Console.Write("Введите имя:  ");
// string username = Console.ReadLine();

// if(username.ToLower() == "маша")
// {
//     Console.WriteLine("Ура маша");
// }
// else
// {
//     Console.WriteLine("Привет -  " + username);
// }


// int a = 1;
// int b = 2;
// int c = 6;
// int d = 8;
// int e = 4;

// int max = a;

// if (a > max ) max = a;
// if (b > max ) max = b;
// if (c > max ) max = c;
// if (d > max ) max = d;
// if (e > max ) max = e;


// Console.Write("max = ");
// Console.WriteLine(max);




//  Задачв на трёхугодтник


Console.Clear();
// Console.SetCursorPosition(10, 4);
// Console.WriteLine("+");


int xa = 40;
int ya = 1;

int xb = 1;
int yb = 40;

int xc = 100;
int yc = 40;

Console.SetCursorPosition(xa, ya);
Console.WriteLine("+");

Console.SetCursorPosition(xb, yb);
Console.WriteLine("+");

Console.SetCursorPosition(xc, yc);
Console.WriteLine("+");


int x = xa, y = xb;
int count = 0;

while(count < 10000)
{
    int what = new Random().Next(0, 3);
    if (what == 0)
    {
        x = (x+xa)/2;
        y = (y + ya)/2;       
    }

  if (what == 1)
    {
        x = (x+xb)/2;
        y = (y + yb)/2;       
    }

  if (what == 2)
    {
        x = (x+xc)/2;
        y = (y + yc)/2;       
    }


Console.SetCursorPosition(x, y);
Console.WriteLine("+");
count++;

}



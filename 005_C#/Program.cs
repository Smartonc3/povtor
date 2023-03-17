// string[,] table = new string[2,5];
// //

// table [1,2] = "Слово";

// for (int rows = 0; rows < 2; rows++)
// {
//     for (int columns = 0; columns < 5; columns++)
//     {
//         Console.WriteLine($"-{table[rows, columns]}-");
//     }
// }

// //--------------------------------------------------------------------------------------------


// void PrintArray(int[,] mart)
// {
//     for (int rows = 0; rows < mart.GetLength(0); rows++)
//     {
//         for (int columns = 0; columns < mart.GetLength(1); columns++)
//         {
//             Console.Write($"{mart[rows, columns]} ");
//         }
//         Console.WriteLine();
//     }

// }

// void FillArray(int[,] matr)
// {

// for (int rows = 0; rows < matr.GetLength(0); rows++)
//     {
//         for (int columns = 0; columns < matr.GetLength(1); columns++)
//         {
//             matr[rows,columns] = new Random().Next(1,10);
//         }
//     }

// }

//  ------------------------------------------------------------------------------------

// int[,] matrix = new int[3,4];
// PrintArray(matrix);
// FillArray(matrix);
// Console.WriteLine();
// PrintArray(matrix);


// double Factorial (int n)
// {
//     if(n == 1) return 1;
//     else return n * Factorial( n - 1);
// }
// for (int i = 1; i < 40; i++)
// {
//     Console.WriteLine($"{i}! = {Factorial(i)}");
// }


// //-------------------------------------------------------------------
// // f(1) = 1
// // F(2) = 1
// // f(n) = f(n-1) + f(n-2)

// double Fibomacci(int n)
// {
//     if(n == 1 || n == 2) return 1;
//     else return Fibomacci(n - 1) + Fibomacci( n- 2);
// }

// for (int i = 1; i < 40; i++)
// {
//     Console.WriteLine(Fibomacci(i));
// }

// //------------------------------------------------------------------------

// int Fibomacci(int n)
// {
//     if(n == 1 || n == 2) return 1;
//     else return Fibomacci(n - 1) + Fibomacci( n- 2);
// }

// for (int i = 1; i < 40; i++)
// {
//     Console.WriteLine(Fibomacci(i));
// }



﻿// // Интерактивное решения. Собрать строку с числами от a до b, a ≤ b

// string NumbersFor(int a, int b)
// {
//     string result = String.Empty;
//     for (int i = a; i <= b; i++)
//     {
//         result += $"{i} ";
//     }
//     return result;
// }


// // Рекурсия. Собрать строку с числами от a до b, a ≤ b


// string NumbersRec(int a, int b)
// {
//     if (a <= b) return $"{a} " + NumbersRec(a + 1, b);
//     else return String.Empty;
// }
// Console.WriteLine(NumbersFor(1, 10)); // 1 2 3 4 5 6 7 8 9 10
// Console.WriteLine(NumbersRec(1, 10)); // 1 2 3 4 5 6 7 8 9 10




// // ---------------------------------------------------------------


// // Интерактивное решения. Собрать строку с числами от a до b, a ≥ b


// string NumbersFor(int a, int b)
// {
//     string result = String.Empty;
//     for (int i = a; i >= b; i--)
//     {
//         result += $"{i} ";
//     }
//     return result;
// }



// // Рекурсия. Собрать строку с числами от a до b, a ≥ b


// string NumbersRec(int a, int b)
// {
//     if (a <= b) return NumbersRec(a + 1, b) + $"{a} ";
//     else return String.Empty;
// }
// Console.WriteLine(NumbersFor(1, 10)); // 10 9 8 7 6 5 4 3 2 1
// Console.WriteLine(NumbersRec(1, 10)); // 10 9 8 7 6 5 4 3 2 1


// // ---------------------------------------------------------------------------------


// // Сумма чисел от 1 до n


// int SumFor(int n)
// {
//     int result = 0;
//     for (int i = 1; i <= n; i++) result += i;
//     return result;
// }


// // Рекурсия. Сумма чисел от 1 до n

// int SumRec(int n)
// {
//     if (n == 0) return 0;
//     else return n + SumRec(n - 1);
// }
// Console.WriteLine(SumFor(10)); // 55
// Console.WriteLine(SumRec(10)); // 55

// //---------------------------------------------------------

// // Факториал числа

// int FactorialFor(int n)
// {
//     int result = 1;
//     for (int i = 1; i <= n; i++) result *= i;
//     return result;
// }


// // Рэкурсия. Факториал числа

// int FactorialRec(int n)
// {
//     if (n == 1) return 1;
//     else return n * FactorialRec(n - 1);
// }
// Console.WriteLine(FactorialFor(10)); // 3628800
// Console.WriteLine(FactorialRec(10)); // 3628800

// // ------------------------------------------------------------

// // Вычислить а до n

// int PowerFor(int a, int n)
// {
//     int result = 1;
//     for (int i = 1; i <= n; i++) result *= a;
//     return result;
// }

// // Рэкурсия. Вычислить а до n


// int PowerRec(int a, int n)
// { //return n == 0 ? 1 : PowerRec(a, n - 1) * a;
//     if (n == 0) return 1;
//     else return PowerRec(a, n - 1) * a;
// }


// // 3 способ. 

// int PowerRecMath(int a, int n)
// {
//     if (n == 0) return 1;
//     else if (n % 2 == 0) return PowerRecMath(a * a, n / 2);
//     else return PowerRecMath(a, n - 1) * a;
// }


// Console.WriteLine(PowerFor(2, 10)); // 1024
// Console.WriteLine(PowerRec(2, 10)); // 1024
// Console.WriteLine(PowerRecMath(2, 10)); // 1024
// //------------------------------------------------------------


// // Перебор слов

// char[] s = { 'а', 'и', 'с', 'в' };
// int count = s.Length;
// int n = 1;
// for (int i = 0; i < count; i++)
// {
//     for (int j = 0; j < count; j++)
//     {
//         for (int k = 0; k < count; k++)
//         {
//             for (int l = 0; l < count; l++)
//             {
//                 for (int m = 0; m < count; m++)
//                 {
//                     Console.WriteLine($"{n++,-5}{s[i]}{s[j]}{s[k]}{s[l]}{s[m]}");
//                 }
//             }
//         }
//     }
// }


// // Рекурсия. Перебор слов
// int n = 1;
// void FindWords(string alphabet, char[] word, int length = 0)
// {
//     if (length == word.Length)
//     {
//         Console.WriteLine($"{n++} {new String(word)}"); return;
//     }
//     for (int i = 0; i < alphabet.Length; i++)
//     {
//         word[length] = alphabet[i];
//         FindWords(alphabet, word, length + 1);
//     }
// }
// FindWords("аисв", new char[2]);


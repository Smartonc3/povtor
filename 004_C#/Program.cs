

// // 2 - Чтото принимает но не возврашает. 

// void Merhod21(string msg, int count)
// {
//     int i = 0;
//     while (i < count)
//     {
//         Console.WriteLine(msg);
//         i++;        
//     }
// }

// Merhod21(msg: "Текст", count: 4);
// Merhod21("Текст", 4);



// // 3 - Чтото возврашает но не принимает. 

// int Method3()
// {
//     return DateTime.Now.Year;
// }

// int  year = Method3();
// Console.WriteLine(year);


// // 4 - Чтото принимают и чтото возврашают. 
// string method4(int count, string text)
// {
//     int i =0; 
//     string result = String.Empty;

//     while (i < count)
//     {
//         result = result + text;
//         i++;
//     }
//     return result;
// }

// string res = method4(10, "Ок");
// Console.WriteLine(res);


// --------------------------------------------------------------------------------------------------------

// // Цикл For

// string method4(int count, string text)
// {
     
//     string result = String.Empty;
//     for (int i = 0; i < count; i++)
//     {
//         result = result + text;
//     }
    
//     return result;

// }

// string res = method4(10, "Ок");
// Console.WriteLine(res);

//  ----------------------------------------------------------------------------------------------------------

// // // Цыкаль в цикле.  Таблица умнажения. 

// for (int i = 2; i <= 10; i++)
// {
    
//     for (int j = 2; j <= 10; j++)
//     {
//         Console.WriteLine($"{i} x {j} = {i * j}");
//     }
//     Console.WriteLine();
// }

// ----------------------------------------------------------------------------------------------------------

//=====Работа с текстом
// Дан текст. В тексте нужно все пробелы заменить чёрточками,
// маленькие буквы “к” заменить большими “К”,
// а большие “С” маленькими “с”.
// Ясна ли задача?

// string text = "— Я думаю, — сказал князь, улыбаясь, — что, "
//             + "ежели бы вас послали вместо нашего милого Винценгероде,"
//             + "вы бы взяли приступом согласие прусского короля."
//             + "Вы так красноречивы. Вы дадите мне чаю?";


// string Replace(string text, char oldValur, char newValue)
// {
//     string result = String.Empty;
//     int length = text.Length;
//     for (int i = 0; i < length; i++)
//     {
//         if(text[i] == oldValur) result = result + $"{newValue}";
//         else result = result + $"{text[i]}";
//     }
//     return result;
// }

// string newText = Replace(text, ' ', '|');
// Console.WriteLine(newText);
// Console.WriteLine();
// newText = Replace(newText, 'к', 'К');
// Console.WriteLine(newText);




// //--------------------------------------------------

// //  Упорядочивания Массива ом минимального к максимальному


// int[] arr = {1, 5, 6, 5, 1, 9, 50, 4, 8, 7};

// void PrintArray(int[] array)
// {
//     int count = array.Length;
//     for (int i = 0; i < count; i++)
//     {
//         Console.Write($"{array[i]} ");
//     }
//     Console.WriteLine();
// }

// void SelectionSort(int[] array)
// {
//     for (int i = 0; i < array.Length -1 ; i++)
//     {
//         int minPosition = i;

//         for (int j = i + 1; j < array.Length; j++) 
//         {
//             if(array[j] < array[minPosition]) minPosition = j;
//         }

//         int temporary = array[i];
//         array[i] = array[minPosition];
//         array[minPosition] = temporary;
//     }
// }

// PrintArray(arr);
// SelectionSort(arr);

// PrintArray(arr);


// //--------------------------------------------------

// //  Упорядочивания Массива ом максимального к минимальному 




int[] arr = {1, 5, 6, 5, 1, 9, 50, 4, 8, 7};

void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length -1 ; i++)
    {
        int maxPosition = i;

        for (int j = i + 1; j < array.Length; j++) 
        {
            if(array[j] > array[maxPosition]) maxPosition = j;
        }

        int temporary = array[i];
        array[i] = array[maxPosition];
        array[maxPosition] = temporary;
    }
}

PrintArray(arr);
SelectionSort(arr);

PrintArray(arr);
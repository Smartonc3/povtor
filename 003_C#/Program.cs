// int max(int arg1, int arg2, int arg3 )
// {
//     int result = arg1;
//     if(arg2 > result) result = arg2;
//     if(arg3 > result) result = arg3;
//     return result;
// }


// int a1 = 15;
// int b1 = 21;
// int c1 = 39;
// int a2 = 12;
// int b2 = 23;
// int c2 = 33;
// int a3 = 131;
// int b3 = 23;
// int c3 = 33;

// // int max1 = max(a1, b1, c1);
// // int max2 = max(a2, b2, c2);
// // int max3 = max(a3, b3, c3);
// // int maxi = max(max1, max2, max3);


// int maxi = max(
//     max(a1, b1, c1),
//     max(a2, b2, c2),
//     max(a3, b3, c3)
//     );

// Console.WriteLine(maxi);


// --------------------------------------------------------------------------------------------


// int Max(int arg1, int arg2, int arg3 )
// {
//     int result = arg1;
//     if(arg2 > result) result = arg2;
//     if(arg3 > result) result = arg3;
//     return result;
// }


// int[] array = {11, 21, 31, 41, 15, 61, 17, 18, 19};

// int max = Max(
//     Max(array[0], array[1], array[2]),
//     Max(array[3], array[4], array[5]),
//     Max(array[6], array[7], array[8])
//     );


// Console.WriteLine(max);


// ----------------------------------------------------------------------------------------------

// int[] array = {1, 12, 4, 31, 5, 85, 25, 4, 56, 751};

// int n = array.Length;
// int find = 4;

// int index = 0;

// while (index < n)
// {
//     if(array[index] == find)
//         {
//             Console.WriteLine(index);
//             break;
//         }


//     index++;
// }



// -------------------------------------------------------------------------------------------------------------

void FillArray(int[] collection)       //  Массив для заполнения.
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

void PrintArray(int[] coll)            //  Массив для Печать   
{
    int count = coll.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(coll[position]);
        position++;
    }
}


int[] array = new int[10];            //   Создали массив.

FillArray(array);                     //   Заполнили его.
PrintArray(array);                    //   Напечатали его.


int IndexOf(int[] collection1, int find)         //   Ишем в каком месте стоит то или иное 1 найденое чтсло.  
{
    int count = collection1.Length;
    int index = 0;
    int position = -1;
    while (index < count)
    {
        if(collection1[index]  == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}

Console.WriteLine();


int pos = IndexOf(array, 4);       // Задаём Длину массива и число в функчию. 
Console.WriteLine(pos);



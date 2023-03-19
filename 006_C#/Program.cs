﻿using System.Linq;

string text = "(1,2) (2,3) (4,5) (9,7)"     // Возмите текст 
                .Replace("(", "")           // Замените скобочки на пустату   
                .Replace(")", "")
                ;


Console.WriteLine(text);                    // Разпечатаем полученный результат.

var data = text.Split(" ")                        // Возми текст и (Split) Разбей на пробели.

                .Select(item => item.Split(","))  // Сделай выборку "item" элиментов, Для который нужно будет превратить в новое разбеения, тоесть взять отдельную подстроку у 
                                                  // разбит его на несколко элиментов с учётом символа разделения запятая.
                .Select(e => (x: int.Parse(e[0]), y: int.Parse(e[1])))   // Сделайте выбарку из текушего массива(е) такого что 1 кардинат будет взята как 1 элимент
                                                                         // массива и конвертировано в число, и тоже самое со второй.
                .Where(e => e.x % 2 == 0)        //  Делаем проверку услоуия Дайте нам такие пары где 1 кардинаты чётные.
                .Select(point => (point.x * 10, point.y))   //  ДАй тк нам тот набор каторый мы получили на претыдушем этаве и для него мы хотим
                                                            //  сделать увеличения 1 кординаты. или 1 кардинаты. 
                .ToArray();                //преврошаем в явный мвссив

for (int i = 0; i < data.Length; i++)
{
    // Console.WriteLine(data[i].x * 10);    Увеличиваеи х на 10. (х это 1 позиция.)
    Console.WriteLine(data[i]);
}



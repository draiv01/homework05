// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2


// int [] Nazvanie(int size, int minValue, int maxValue)
// {
//     int [] array = new int[size];
//     for(int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(minValue, maxValue+1);
//     }
//     return array;
// }

// void Showarray(int [] array)
// {
//     for(int i = 0; i < array.Length; i++)
//     {
//         Console.Write($"{array[i]} ");
//     }
//     Console.WriteLine();
// }

// int NazvaniePlus(int [] array)
// {
//     int num = 0;
//     for(int i = 0; i < array.Length; i++)
//     {
//         if(array[i] % 2 == 0)
//             num++;
//     }
//     return num;
// }


// int size = 4;
// int min = 99;
// int max = 1000;
// int [] array = Nazvanie(size, min, max);
// Showarray(array);
// Console.WriteLine($"Количество четных чисел в массиве {NazvaniePlus(array)}");




// Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5


// int [] Nazvanie(int size, int minValue, int maxValue)
// {
//     int [] array = new int[size];
//     for(int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(minValue, maxValue+1);
//     }
//     return array;
// }

// void Showarray(int [] array)
// {
//     for(int i = 0; i < array.Length; i++)
//     {
//         Console.Write($"{array[i]} ");   
//     }
//     Console.WriteLine();   
// }




// int NazvaniePlus(int [] array)
// {
//     int raz = 0;
//     for(int i = 0; i < array.Length; i++)
//     {
//         if(array[i] > 9 && array[i] < 100)
//        raz ++;
//     }
//     return raz;
// }



// int size = 123;
// int min = 1;
// int max = 1000;
// int [] array = Nazvanie(size, min, max);
// Showarray(array);
// Console.WriteLine($"Количество эелементов массива в отрезке [10, 99] {NazvaniePlus(array)}");







// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

// int [] Nazvanie(int size, int minValue, int maxValue)
// {
//     int [] array = new int[size];
//     for(int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(minValue+1, maxValue+1);
//     }
//     return array;
// }

// void Showarray(int [] array)
// {
//     for(int i = 0; i < array.Length; i++)
//     {
//         Console.Write($"{array[i]} ");
//     }
//     Console.WriteLine();
// }



// int NazvaniePlus(int [] array)
// {
//     int summ = 0;
//     for(int i = 0; i < array.Length; i++)
//     {
//         if(array[i] % 2 - 1 == 0)
//             summ += array[i];
//     }
//     return summ;
// }


// int size = 4;
// int min = 1;
// int max = 9;
// int [] array = Nazvanie(size, min, max);
// Showarray(array);
// Console.WriteLine($"Сумма на нечетных позициях {NazvaniePlus(array)}");


// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76



// double [] Nazvanie(int size, int minValue, int maxValue)
// {
//     double [] array = new double[size];
//     for(int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(minValue, maxValue+1);
//     }
//     return array;
// }

// void Showarray(double [] array)
// {
//     for(int i = 0; i < array.Length; i++)
//     {
//         Console.Write($"{array[i]} ");
//     }
//     Console.WriteLine();
// }



// double NazvanieMax(double [] array)
// {
//     double max = 0;
//     for(int i = 0; i < array.Length; i++)
//     {
//         if(array[i] > max)
//             max= array[i];
//     }
//     return max;
// }

// double NazvanieMin(double [] array)
// {
//     double min = 0;
//     for(int i = 0; i < array.Length; i++)
//     {
//         if(array[i] < min)
//             min= array[i];
//     }
//     return min;
// }

// int size = 4;
// int min = 1;
// int max = 9;
// double [] array = Nazvanie(size, min, max);
// Showarray(array);
// Console.WriteLine($"Разница между максимальным и минимальным элементов массива = {NazvanieMax(array) - NazvanieMin(array)}");






// Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21



// int [] Nazvanie(int size, int minValue, int maxValue)
// {
//     int [] array = new int[size];
//     for(int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(minValue, maxValue+1);
//     }
//     return array;
// }

// void Showarray(int [] array)
// {
//     for(int i = 0; i < array.Length; i++)
//     {
//         Console.Write($"{array[i]} ");
//     }
//     Console.WriteLine();
// }



// int NazvanieOne(int [] array)
// {
//     int one = 0;
  
//     for(int i = 0; i < array.Length; i++)
//     {
//         if(array [i] > 0)
//             one = array[0];
        
//     }
//     return one;
// }

// int NazvanieTwo(int [] array)
// {
//     int two = array [^1];
//     for(int i = array.Length; i < array.Length; i++)
//     {
//         if(array [i] > 0)
//             two = array[i];
      
//     }
//     return two;
// }

// int size = 4;
// int min = -9;
// int max = 9;
// int [] array = Nazvanie(size, min, max);
// Showarray(array);
// Console.WriteLine($"{NazvanieOne(array) * NazvanieTwo(array)} ");
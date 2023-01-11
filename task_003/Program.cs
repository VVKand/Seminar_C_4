// Задача 29: Напишите программу, которая задаёт массив из 8 целых чисел с клавиатуры 
// и далее выводит массив на экран в одну строку.

Console.WriteLine("Ввведите элементы массива с клавиатуры");

void Input(int[] col)
{
    int i = 0;
       while (i < 8)
        {
           Console.WriteLine($"Введите элемент массива {i+1}: ");
           col[i] = Convert.ToInt32(Console.ReadLine());
           Console.WriteLine();
           i++;
        }
 }

void Print(int[] col2)
{
    foreach (int item in col2)
        Console.Write(item + " ");
}

int [] Data = new int[8];
Input(Data);
Print(Data);
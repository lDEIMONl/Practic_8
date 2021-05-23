using System;

namespace Practic_8
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array = new int[10, 10];
            Random random = new Random();
            //Заполнение массива случаными числами
            Console.WriteLine("Изначальный массив\n");
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = random.Next(10);
                    Console.Write(array[i,j] + " ");
                }
                Console.WriteLine();
            }

            //Нахождение на главной диагонали максимального элемента
            int[] coordinatesMainDiagonal = new int[2];
            int maxMainDiagonal = array[0, 0];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (i == j)
                    {
                        if (maxMainDiagonal < array[i,j])
                        {
                            maxMainDiagonal = array[i, j];
                            coordinatesMainDiagonal[0] = i;
                            coordinatesMainDiagonal[1] = j;
                        }
                        break;
                    }
                }
            }

            //Нахождение на побочной диагонали максимального элемента
            int[] coordinatesSecondaryDiagonal = new int[2];
            int maxSecondaryDiagonal = array[0, 9];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (j == array.GetLength(1) - (i + 1))
                    {
                        if (maxSecondaryDiagonal < array[i, j])
                        {
                            maxSecondaryDiagonal = array[i, j];
                            coordinatesSecondaryDiagonal[0] = i;
                            coordinatesSecondaryDiagonal[1] = j;
                        }
                        break;
                    }
                }
            }


            //Нахождение суммы каждого столбца в массиве "array"
            int[] sumColumn = new int[10];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    sumColumn[i] += array[j, i];
                }
            }

            Console.WriteLine("\nСумма столбцов в массиве");
            //Вывод сумм каждого столбца в массиве "array"
            for (int i = 0; i < sumColumn.Length; i++)
            {
                Console.Write($"Сумма столбца {i + 1}: " + sumColumn[i] + "\n");
            }

            Console.WriteLine("\nМаксимальный элемент на побочной диагонали: " 
                + maxSecondaryDiagonal + $" |Столбец: {coordinatesSecondaryDiagonal[0] + 1} Ряд: {coordinatesSecondaryDiagonal[1] + 1}");
            
            Console.WriteLine("Максимальный элемент на главное диагонали: " 
                + maxMainDiagonal + $"  |Столбец: {coordinatesMainDiagonal[0] + 1} Ряд: {coordinatesMainDiagonal[1] + 1}");
        }
    }
}

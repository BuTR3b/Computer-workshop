using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    class Program
    {

        static int[] write_array(int size)
        {
            int[] array = new int[size];
            Random num = new Random();
            for (int i = 0; i < size; i++)
            {
                array[i] = num.Next(0, 100);
            }
            return array;
        }

        static int[,] write_matrix(int rows, int columns)
        {
            int[,] matrix = new int[rows, columns];
            Random num = new Random();
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    matrix[i,j] = num.Next(0, 100);
                }
            }
            return matrix;
        }

        static void print_array(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
        }

        static void print_matrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        static int func(double x) // функция для бисекции 
        {
            return (int)(Math.Sin(x) * Math.Log(x));
        }

        static void Swap_1() // Алгоритм обмена значениями двух переменных. (через сумму)
        {
            int num_1;
            int num_2;
            Console.Write("Первое число >> ");
            num_1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Второе число >> ");
            num_2 = Convert.ToInt32(Console.ReadLine());
            num_1 += num_2;
            num_2 = num_1 - num_2;
            num_1 -= num_2;
            Console.WriteLine("Первое число = " + num_1 + " Второе число = " + num_2);
        }

        static void Swap_2() // Алгоритм обмена значениями двух переменных. (через временную)
        {
            string str_1;
            string str_2;
            string tmp;
            Console.Write("Первая переменная >> ");
            str_1 = Console.ReadLine();
            Console.Write("Вторая переменная >> ");
            str_2 = Console.ReadLine();
            tmp = str_1;
            str_1 = str_2;
            str_2 = tmp;
            Console.WriteLine("Первая переменная = " + str_1 + " Вторая переменная = " + str_2);
        }

        static void Series_part()
        {
            int start;
            int stop;
            int sum = 0;
            Console.Write("Начальный элемент >> ");
            start = Convert.ToInt32(Console.ReadLine());
            Console.Write("Количество элементов >> ");
            stop = Convert.ToInt32(Console.ReadLine());
            for (int i = start; i <= stop; i++)
            {
                sum += (int)Math.Pow(i, 2); // ряд - n ^ 2
            }
            Console.WriteLine("Сумма ряда = " + sum);
        }

        static void Series_accur() // Вычисление суммы ряда с заданной точностью
        {
            double sum = 0;
            float EPSILON = 0.01F;
            Console.Write("Число >> "); 
            double x = Convert.ToDouble(Console.ReadLine());
            int n = 0; 
            double a = x; 
            while (Math.Abs(a) >= EPSILON) 
            { 
                sum += a; 
                n++; 
                int i = n + 1; 
                a = -a * x * x / ((2 * i - 2) * (2 * i - 1)); 
            }
            Console.WriteLine("Сумма = " + sum);
        }

        static void Series_rec() //  Вычисление суммы ряда, заданного рекуррентным соотношением
        {
            int sum;
            int n;
            int F0;
            int F1;
            int Fn;
            Console.Write("Количество элементов >> "); 
            n = Convert.ToInt32(Console.ReadLine());
            F0 = 0;
            F1 = 1;
            sum = F1 + F0;
            for (int i = 1; i < n; i++) 
            {
                Fn = F1 + F0; 
                sum += Fn;
                F0 = F1;
                F1 = Fn;
            }
            Console.WriteLine("Сумма ряда = " + sum);
        }

        static void Array_sum() //Алгоритм суммы элементов одномерного массива. Суммирование элементов массива, удовлетворяющих некоторому заданному условию
        {
            int sum = 0;
            int[] array;
            int size;
            Console.Write("Размер массива >> ");
            size = Convert.ToInt32(Console.ReadLine());
            array = new int[size];
            for (int i = 0; i < size; i++)
            {
                array[i] = i + 1;
                if (array[i] % 2 == 0) // условие - сумма четных 
                {
                    sum += array[i];
                }
                Console.Write(array[i] + " ");
            }
            Console.WriteLine("\nСумма элементов = " + sum);
        }

        static void Array_mean() //  Алгоритм нахождения среднего значения элементов массива, удовлетворяющих некоторому заданному условию
        {
            int sum = 0;
            int count = 0;
            double mean;
            int[] array;
            int size;
            Console.Write("Размер массива >> ");
            size = Convert.ToInt32(Console.ReadLine());
            array = new int[size];
            for (int i = 0; i < size; i++)
            {
                array[i] = i + 1;
                if (array[i] % 2 != 0) // условие - сумма нечетных 
                {
                    sum += array[i];
                    count++;
                }
                Console.Write(array[i] + " ");
            }
            mean = sum / count;
            Console.WriteLine("\nСреднее значение = " + mean);
        }

        static void bubble_sort() // Сортировка пузырьком
        {
            int n;
            int[] array;
            Console.Write("Размер массива >> ");
            n = Convert.ToInt32(Console.ReadLine());
            array = write_array(n);
            Console.WriteLine("До сортировки: ");
            print_array(array);
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = 0; j < array.Length - i - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        array[j] += array[j + 1];
                        array[j + 1] = array[j] - array[j + 1];
                        array[j] -= array[j + 1];
                    }
                }
            } 
            Console.WriteLine("\nПосле сортировки: ");
            print_array(array);
        }

        static void super_bubble_sort() // Сортировка пузырьком улучшенный
        {
            int n;
            int[] array;
            bool swaped = false;
            Console.Write("Размер массива >> ");
            n = Convert.ToInt32(Console.ReadLine());
            array = write_array(n);
            Console.WriteLine("До сортировки: ");
            print_array(array);
            for (int i = 0; i < array.Length - 1; i++)
            {
                swaped = false;
                for (int j = 0; j < array.Length - i - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        array[j] += array[j + 1];
                        array[j + 1] = array[j] - array[j + 1];
                        array[j] -= array[j + 1];
                        swaped = true;
                    }
                }
                if (! swaped)
                {
                    break;
                }
            }
            Console.WriteLine("\nПосле сортировки: ");
            print_array(array);
        }

        static void insertion_sort() // Сортировка вставкой
        {
            int n;
            int[] array;
            int tmp;
            int key;
            Console.Write("Размер массива >> ");
            n = Convert.ToInt32(Console.ReadLine());
            array = write_array(n);
            Console.WriteLine("До сортировки: ");
            print_array(array);
            for (int i = 1; i < array.Length; i++)
            {
                tmp = array[i];
                key = i;
                while (key > 0 && array[key - 1] > tmp)
                {
                    key -= 1;
                    array[key] += array[key + 1];
                    array[key + 1] = array[key] - array[key + 1];
                    array[key] -= array[key + 1];
                }
                array[key] = tmp;
            }
            Console.WriteLine("\nПосле сортировки: ");
            print_array(array);
        }

        static void selection_sort() // Алгоритм сортировки массива методом выбора
        {
            int n;
            int[] array;
            int tmp;
            Console.Write("Размер массива >> ");
            n = Convert.ToInt32(Console.ReadLine());
            array = write_array(n);
            Console.WriteLine("До сортировки: ");
            print_array(array);
            for (int i = 0; i < array.Length - 1; i++)
            {
                int min = i;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] < array[min])
                    {
                        min = j;
                    }
                }
                tmp = array[i];
                array[i] = array[min];
                array[min] = tmp;
            }
            Console.WriteLine("\nПосле сортировки: ");
            print_array(array);
        }

        static void shaker_sort() // Алгоритм сортировки массива методом «шейкер»
        {
            int n;
            int[] array;
            int tmp;
            int j;
            Console.Write("Размер массива >> ");
            n = Convert.ToInt32(Console.ReadLine());
            array = write_array(n);
            Console.WriteLine("До сортировки: ");
            print_array(array);
            for (int i = 0; i < array.Length / 2; i++)
            {
                j = 0;
                while (j < array.Length - 1)
                {
                    if (array[j] > array[j + 1])
                    {
                        tmp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = tmp;
                    }
                    j++;
                }
                j = array.Length - 2;
                while (j > 0)
                {
                    if (array[j] > array[j + 1])
                    {
                        tmp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = tmp;
                    }
                    j--;
                }
            }
            Console.WriteLine("\nПосле сортировки: ");
            print_array(array);
        }

        static void find_max_min() // Алгоритм поиска наибольшего и наименьшего элемента в одномерном массиве
        {
            int n;
            int[] array;
            int max;
            int min;
            Console.Write("Размер массива >> ");
            n = Convert.ToInt32(Console.ReadLine());
            array = write_array(n);
            Console.WriteLine("Массив: ");
            print_array(array);
            max = array[0];
            min = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (min > array[i]) 
                { 
                    min = array[i];
                }
                else
                if (max < array[i]) 
                { 
                    max = array[i];
                }
            }
            Console.WriteLine("\nМаксимальное = " + max + "\nМинимальное = " + min);
        }

        static void find_min_max_index() // Алгоритм поиска индекса наибольшего или наименьшего элемента в одномерном массиве
        {
            int n;
            int[] array;
            int max_ind;
            int min_ind;
            Console.Write("Размер массива >> ");
            n = Convert.ToInt32(Console.ReadLine());
            array = write_array(n);
            Console.WriteLine("Массив: ");
            print_array(array);
            max_ind = 0;
            min_ind = 0;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[min_ind] > array[i])
                {
                    min_ind = i;
                }
                else
                if (array[max_ind] < array[i])
                {
                    max_ind = i;
                }
            }
            Console.WriteLine("\nИндекс мксимального = " + max_ind + "\nИндекс минимального = " + min_ind);
        }

        static void consistent_search() // Алгоритм поиска заданного значения в одномерном массиве. Последовательный поиск
        {
            int n;
            int find_elem;
            int ind = -1;
            int[] array;
            Console.Write("Размер массива >> ");
            n = Convert.ToInt32(Console.ReadLine());
            array = write_array(n);
            Console.Write("Найти >> ");
            find_elem = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Массив: ");
            print_array(array);
            for (int i = 0; i < array.Length; i++)
            {
                if (find_elem == array[i])
                {
                    ind = i;
                    break;
                }
            }
            if (ind != -1)
            {
                Console.WriteLine("\nЭлемент " + find_elem + " с индексом " + ind);
            }
            else
            {
                Console.WriteLine("\nЭлемент не найдет");
            }
        }

        static void binary_search() // Алгоритм поиска заданного значения в одномерном массиве. Бинарный поиск
        {
            int n;
            int find_elem;
            int mid;
            int left;
            int right;
            int ind = -1;
            int[] array;
            Console.Write("Размер массива >> ");
            n = Convert.ToInt32(Console.ReadLine());
            array = write_array(n);
            Console.Write("Найти >> ");
            find_elem = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Массив: ");
            left = 0;
            right = array.Length - 1;
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = 0; j < array.Length - i - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        array[j] += array[j + 1];
                        array[j + 1] = array[j] - array[j + 1];
                        array[j] -= array[j + 1];
                    }
                }
            }
            print_array(array);
            while (left <= right)
            {
                mid = (int)((left + right) / 2);
                if (find_elem == array[mid])
                {
                    ind = mid;
                    break;
                }
                else if (find_elem < array[mid])
                {
                    right = mid - 1;
                }
                else
                {
                    left = mid + 1;
                }
            }
            if (ind != -1)
            {
                Console.WriteLine("\nЭлемент " + find_elem + " с индексом " + ind);
            }
            else
            {
                Console.WriteLine("\nЭлемент не найдет");
            }
        }

        static void shuffle() // Алгоритм случайного перемешивания одномерного массива
        {
            Random dice = new Random();
            int[] array;
            int n;
            int tmp;
            int k;
            Console.Write("Размер массива >> ");
            n = Convert.ToInt32(Console.ReadLine());
            array = write_array(n);
            Console.WriteLine("Массив до перемешивания: ");
            print_array(array);
            for (int i = 0; i < array.Length; i++)
            {
                k = dice.Next(0, array.Length);
                tmp = array[i];
                array[i] = array[k];
                array[k] = tmp;
            }
            Console.WriteLine("\nМассив после перемешивания: ");
            print_array(array);
        }

        static void transpose() // Алгоритм транспонирования матрицы
        {
            int[,] matrix;
            int[,] result;
            int m;
            int n;
            Console.Write("Строки >> ");
            m = Convert.ToInt32(Console.ReadLine());
            Console.Write("Столбцы >> ");
            n = Convert.ToInt32(Console.ReadLine());
            matrix = write_matrix(m, n);
            result = new int[n, m];
            Console.WriteLine("Исходная матрица: ");
            print_matrix(matrix);
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    result[j, i] = matrix[i, j];
                }
            }
            Console.WriteLine("Транспонированная матрица: ");
            print_matrix(result);
        }

        static void matrix_multip() // Алгоритм умножения матрицы на вектор, на другую матрицу
        {
            int[,] matrix_A;
            int[,] matrix_B;
            int A_rows;
            int A_columns;
            int B_rows;
            int B_columns;
            Console.Write("Строки 1й >> ");
            A_rows = Convert.ToInt32(Console.ReadLine());
            Console.Write("Столбцы 1й >> ");
            A_columns = Convert.ToInt32(Console.ReadLine());
            matrix_A = write_matrix(A_rows, A_columns);
            Console.Write("Строки 2й >> ");
            B_rows = Convert.ToInt32(Console.ReadLine());
            Console.Write("Столбцы 2й >> ");
            B_columns = Convert.ToInt32(Console.ReadLine());
            matrix_B = write_matrix(B_rows, B_columns);
            Console.WriteLine("Матрица A: ");
            print_matrix(matrix_A);
            Console.WriteLine("Матрица B: ");
            print_matrix(matrix_B);
            if (A_columns != B_rows)
            {
                Console.WriteLine("Умножение не возможно. Количество столбцов первой матрицы не равно количеству строк второй матрицы");
            }
            else
            {
                int[,] result = new int[A_rows, B_columns];
                for (int i = 0; i < A_rows; i++)
                {
                    for (int j = 0; j < B_columns; j++)
                    {
                        for (int k = 0; k < A_columns; k++)
                        {
                            result[i, j] = matrix_A[i, k] * matrix_B[k, j];
                        }
                    }
                }
                Console.WriteLine("Результат: ");
                print_matrix(result);
            }
        }

        static void sieve_Eratosthen() // Алгоритм поиска простых чисел («решето Эратосфена»)
        {
            int[] array;
            int n;
            int k = 0;
            int m = 2;
            Console.Write("Элементов >> ");
            n = Convert.ToInt32(Console.ReadLine()) + 1;
            array = new int[n];
            for (int i = 0; i < n; i++)
            {
                array[i] = i;
            }
            array[1] = 0;
            while (m < n)
            {
                if (array[m] != 0)
                {
                    k = m * 2;
                }
                while (k < n)
                {
                    array[k] = 0;
                    k += m;
                }
                m += 1;
            }
            for (int i = 0; i < n; i++)
            {
                if (array[i] != 0)
                {
                    Console.Write(array[i] + " ");
                }
            }
        }

        static void bisection() // Алгоритм поиска приближенного решения обыкновенного уравнения методом деления отрезка пополам
        {
            float EPSILON = 0.01F;
            double left;
            double right;
            double x;
            Console.Write("Начало отрезка >> ");
            left = Convert.ToInt32(Console.ReadLine());
            Console.Write("Конец отрезка >> ");
            right = Convert.ToInt32(Console.ReadLine());
            x = (int)(left + right) / 2;
            while (Math.Abs(func(x)) >= EPSILON)
            {
                x = (left + right) / 2;
                if (func(left) * func(x) < 0)
                {
                    right = left;
                    left = x;
                }
                else
                {
                    left = right;
                    right = x;
                }
            }
            Console.WriteLine((left + right) / 2);
        }

        static void count_letter() // Алгоритм подсчета числа повторений заданной буквы в заданной строке
        {
            char letter;
            string str;
            int count = 0;
            Console.Write("Строка >> ");
            str = Console.ReadLine();
            Console.Write("Буква >> ");
            letter = Convert.ToChar(Console.ReadLine());
            for (int i = 0; i < str.Length; i++)
            {
                if (letter == str[i])
                {
                    count++;
                }
            }
            Console.WriteLine("Буква " + letter + " повторялась " + count + " раз(а)");
        }

        static void find_substr() // Алгоритм поиска подстроки в строке
        {
            string str;
            string substr;
            List<string> words = new List<string>();
            string word = "";
            Console.Write("Строка >> ");
            str = Console.ReadLine() + " ";
            Console.Write("Подстрока >> ");
            substr = Console.ReadLine();
            for (int i = 1; i < str.Length; i++)
            {
                if (str[i] != ' ')
                {
                    word += str[i];
                }
                else if (word != "" && str[i] == ' ')
                {
                    words.Add(word);
                    word = "";
                }
            }
            foreach (string q in words)
            {
                if (q == substr)
                {
                    Console.WriteLine("Подстрока - " + substr + " - в строке - " + str);
                    break;
                }
            }
        }

        static void count_words() // Алгоритм подсчета количества слов в строке
        {
            string str;
            List<string> words = new List<string>();
            string word = "";
            Console.Write("Строка >> ");
            str = Console.ReadLine() + " ";
            for (int i = 1; i < str.Length; i++)
            {
                if (str[i] != ' ')
                {
                    word += str[i];
                }
                else if (word != "" && str[i] == ' ')
                {
                    words.Add(word);
                    word = "";
                }
            }
            Console.WriteLine("Слов в строке - " + words.Count);
        }

        static void to_ten() // Алгоритм получения целого числа из его строкового представления в заданной системе счисления
        {
            int new_num = 0;
            string num;
            int syst;
            int q;
            Console.Write("Исходное число >> ");
            num = Console.ReadLine();
            Console.Write("Основание (от 2 до 9) >> ");
            syst = Convert.ToInt32(Console.ReadLine());
            if (syst > 9)
            {
                Console.WriteLine("Основание больше допустимого");
            }
            else
            {
                for (int i = 0; i < num.Length; i++)
                {
                    q = syst;
                    new_num += Convert.ToInt32(Convert.ToInt32(Convert.ToString(num[i])) * Math.Pow(q, num.Length - i - 1));
                }
                Console.WriteLine("Число в 10ой системе - " + new_num);
            }
        }

        static void from_ten() // Алгоритм перевода целого числа в строковое представление в заданной системе счисления
        {
            string[] digits = new string[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "A", "B", "C", "D", "E", "F" };
            string new_num = "";
            int num;
            int syst;
            int k;
            Console.Write("Число для перевода >> ");
            num = Convert.ToInt32(Console.ReadLine());
            Console.Write("Основание (от 2 до 16) >> ");
            syst = Convert.ToInt32(Console.ReadLine());
            if (syst > 16)
            {
                Console.WriteLine("Основание больше допустимого");
            }
            else
            {
                while (num > 0)
                {
                    k = num % syst;
                    new_num += digits[k];
                    num = Convert.ToInt32(num / syst);
                }
                Console.Write("Полученное число - ");
                for (int i = new_num.Length - 1; i >= 0; i--)
                {
                    Console.Write(new_num[i]);
                }
            }
        }

        static void count_condition() // Алгоритм подсчета числа элементов массива (списка) удовлетворяющего заданному условию
        {
            int[] array;
            int count = 0;
            int n;
            Console.Write("Размер массива >> ");
            n = Convert.ToInt32(Console.ReadLine());
            array = write_array(n);
            print_array(array);
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 3 == 0)
                {
                    count++;
                }
            }
            Console.WriteLine("\nУдовлетворяют условию - " + count);
        }

        static void check_prime() // Алгоритм проверки является ли заданное целое число простым, т.е. не имеет делителей кроме единицы и его самого
        {
            int num;
            int lim;
            bool prime = true;
            Console.Write("Число >> ");
            num = Convert.ToInt32(Console.ReadLine());
            if (num < 2)
            {
                Console.WriteLine("Число составное");
            }
            else
            {
                lim = Convert.ToInt32(Math.Sqrt(num));
                for (int i = 2; i <= lim; i++)
                {
                    if (num % i == 0)
                    {
                        Console.WriteLine("Число составное");
                        prime = false;
                        break;
                    }
                }
                if (prime)
                {
                    Console.WriteLine("Число простое");
                }
            }
        }

        static void Main(string[] args)
        {
            //Swap_1();
            //Swap_2();
            //Series_part();
            Series_accur();
            //Series_rec();
            //Array_sum();
            //Array_mean();
            //bubble_sort();
            //super_bubble_sort();
            //insertion_sort();
            //selection_sort();
            //shaker_sort();
            //find_max_min();
            //find_min_max_index();
            //consistent_search();
            //binary_search();
            //shuffle();
            //transpose();
            //matrix_multip();
            //sieve_Eratosthen();
            //bisection();
            //count_letter();
            //find_substr();
            //count_words();
            //to_ten();
            //from_ten();
            //count_condition();
            //check_prime();
            Console.ReadKey();
        }
    }
}

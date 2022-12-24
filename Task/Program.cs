/*
// Task 19 Новое решение для любых чисел

Console.Clear();

Console.Write("Введите число: ");
string? number = Console.ReadLine();
int count = number.Length - 1;
double newNumber = 0;
for (int i = count; i >= 0; i--)
{
    newNumber = newNumber + int.Parse(number[i].ToString()) * Math.Pow(10, i);
}

Console.WriteLine(number == newNumber.ToString());


/* Task dop. 
Второй максимум
(Время: 1 сек. Память: 16 Мб Сложность: 16%)
Задана последовательность натуральных чисел, завершающаяся числом 0. Требуется определить значение второго 
по величине элемента в этой последовательности, то есть элемента, который будет наибольшим, 
если из последовательности удалить наибольший элемент.

Входные данные
Входной файл INPUT.TXT содержит последовательность неотрицательных целых чисел, не превышающих значения 100. 
Гарантируется, что во входных данных не более 100 чисел и среди них есть хотя бы одно число 0, 
перед которым идет как минимум 2 элемента.

Выходные данные
В выходной файл OUTPUT.TXT выведите целое число – значение второго максимума.
*/

/*
Console.Clear();
int n = int.Parse(Console.ReadLine());
int maxFirst = n, maxSecond = -1;
while (n != 0)
{
    n = int.Parse(Console.ReadLine());
    if (maxFirst < n)
    {
        maxSecond = maxFirst;
        maxFirst = n;
    }
    else if (maxSecond < n)
        maxSecond = n;
}
Console.WriteLine(maxSecond);

// Вывод чисел в одну строку
Console.Clear();
string[] array = Console.ReadLine().Split(" ");
int n = int.Parse(array[0]);
int m = int.Parse(array[1]);
Console.WriteLine(n + m);

/* Tsk dop 2 
В фермерском хозяйстве в Карелии выращивают чернику. Она растет на круглой грядке, 
причем кусты высажены только по окружности. Таким образом, у каждого куста есть ровно 
два соседних. Всего на грядке растет N кустов.

Эти кусты обладают разной урожайностью, поэтому ко времени сбора на них выросло различное 
число ягод – на i-ом кусте выросло ai ягод.

В этом фермерском хозяйстве внедрена система автоматического сбора черники. Эта система 
состоит из управляющего модуля и нескольких собирающих модулей. Собирающий модуль за один заход, 
находясь непосредственно перед некоторым кустом, собирает ягоды с этого куста и с двух соседних с ним.

Напишите программу для нахождения максимального числа ягод, которое может собрать за один заход 
собирающий модуль, находясь перед некоторым кустом заданной во входном файле грядки.

Входные данные
Первая строка входного файла INPUT.TXT содержит целое число N (3 ≤ N ≤ 1000) – количество кустов черники. 
Вторая строка содержит N целых положительных чисел a1, a2, ..., aN – число ягод черники, 
растущее на соответствующем кусте. Все ai не превосходят 1000.

Выходные данные
В выходной файл OUTPUT.TXT выведите ответ на задачу.
*/

/*
Console.Clear();
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
string[] input = Console.ReadLine().Split(" ");
for (int i = 0; i < input.Length; i++)
    array[i] = int.Parse(input[i].ToString());

int maxSumma = 0;
for (int i = 1; i < array.Length - 1; i++)
{
    int sum = array[i - 1] + array[i] + array[i + 1];
    if (sum > maxSumma)
        maxSumma = sum;
}
if (array[0] + array[1] + array[array.Length - 1] > maxSumma)
    maxSumma = array[0] + array[1] + array[array.Length - 1];

if (array[array.Length - 1] + array[array.Length - 2] + array[0] > maxSumma)
    maxSumma = array[array.Length - 1] + array[array.Length - 2] + array[0];

Console.WriteLine(maxSumma);

// Array

Console.Clear();
Console.Write("Введите кол-во элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
for (int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(1, 11); // [1, 10]

Console.WriteLine($"[{string.Join(", ", array)}]");


// Function. Void

int f(int a, int b)
{
    if (a > b)
        return a;
    return b;
}

// return возвращает значение либо в консоль, либо в переменную
// return завершает работу функции
// Сколько аргументов мы передаем, столько и принимаем. НО!!!
Console.Clear();
Console.Write("Введите 1-ое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 2-ое число: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(f(a, b));

// Void - процедура
// Void

void f(ref int a)
{
    a += 5;
}


Console.Clear();
Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
f(ref a);
Console.WriteLine(a);


// task 24

Console.Clear();
Console.Write("Введите число: ");
double n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine((1 + n) / 2 * n);
*/

/*Задача 26: 
Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
456 -> 3
78 -> 2
89126 -> 5
*/

/*Console.Clear();
Console.Write("Введите исло: ");
int n = Convert.ToInt32(Console.ReadLine()), count = 0;
while ( n > 0)
{
    n /= 10;
    count ++;
}
Console.WriteLine(count);
*/

/*
// Задача 28:
Напишите программу, которая на вход принимает число N и 
выдает произведение чисел от 1 до N

4 -> 24
5 -> 120


Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine()), res = 1;
for (int i = 2; i <= n; i++ )
    res *= i;

Console.WriteLine(res);
*/

/*// Задача 30

Console.Clear();
int n = 8;
int[] array = new int[n];
for (int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(0, 2); // [1, 10]

Console.WriteLine($"[{string.Join(", ", array)}]");



// task 32 
Напишите программу замена элементов массива: положительные элементы замените 
на соответствующие отрицательные, и наоборот.

[-4, -8, 8, 2] -> [4, 8, -8, -2] 

void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(-9, 10); // [-9, 9]
}


void ReleaseArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] *= (-1);
}


Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n]; // {0, 0,....}
InputArray(array);
Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
ReleaseArray(array);
Console.WriteLine($"Конечный массив: [{string.Join(", ", array)}]");


// task 33
Задайте массив. Напишите программу, которая определяет, присутствует ли 
заданное число в массиве.

4; массив [6, 7, 19, 345, 3] -> нет
3; массив [6, 7, 19, 345, 3] -> да


void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(-9, 10); // [-9, 9]
}


string ReleaseArray(int[] array, int number)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (number == array[i])
            return "yes";
    }
    return "no";
}


Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n]; // {0, 0,....}
InputArray(array);
Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
Console.Write("Введите число: ");
int k = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(ReleaseArray(array, k));

*/

/*Задача 35: 
Задайте одномерный массив из 123 случайных чисел. Найдите количество 
элементов массива, значения которых лежат в отрезке [10,99]. 
Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
[5, 18, 123, 6, 2] -> 1
[1, 2, 3, 6, 2] -> 0
[10, 11, 12, 13, 14] -> 5
*/

/*void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(-100, 101); // [-100, 100]
}


int ReleaseArray(int[] array)
{   
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] >= 10 && array[i] <= 99)
            count++; // count = count + 1;
    }       
    return count;
}


Console.Clear();
// Console.Write("Введите число: ");
// int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[123]; // {0, 0,....}
InputArray(array);
Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
Console.WriteLine(ReleaseArray(array));
*/


/*Задача 37: 
Найдите произведение пар чисел в одномерном массиве. 
Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
[1 2 3 4 5] -> 5 8 9
[6 7 3 6] -> 36 21
*/
/*
void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(1, 11); // [1, 10]
}


void ReleaseArray(int[] array)
{   
    for (int i = 0; i < array.Length / 2 + array.Length % 2; i++)
        Console.Write($"{array[i] * array[array.Length - 1 - i]} ");
}


Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n]; // {0, 0,....}
InputArray(array);
Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
ReleaseArray(array);
*/




/*
// Семинар 6
int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
foreach (int element in size)
    Console.WriteLine(element * 2); //вывод чисел в массив и умножение на 2


    // Задача Суперсдвиг

int n = Convert.ToInt32(Console.ReadLine());

int[] numbers = Console.ReadLine().
Split(" ").Select(x => int.Parse(x)).ToArray();

int k = Convert.ToInt32(Console.ReadLine());
k %= n; // k = k % n
int[] result = new int[n];
if (k > 0)
{
    for (int i = 0; i < k; i++)
        result[i] = numbers[n - k + i];
    for (int i = 0; i < n - k; i++)
        result[k + i] = numbers[i];
}
else
{
    k = (-1) * k;
    for (int i = 0; i < k; i++)
        result[n - k + i] = numbers[i];
    for (int i = 0; i < n - k; i++)
        result[i] = numbers[k + i];
}
Console.WriteLine(string.Join(" ", result));
*/

/*
// double a = new Random().NextDouble() * (end - begin) + begin;
Console.Write(new Random().NextDouble() * 
(50 - 10) + 10); // Генерация дробных чисел*/


/*
// Задача 39 Переворот массива.

void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(1, 11); // [1, 10]
}


void ReleaseArray(int[] array)
{
    for (int i = 0; i < array.Length / 2; i++)
    {
        int temp = array[i];
        array[i] = array[array.Length - 1 - i];
        array[array.Length - 1 - i] = temp;
    }
}


Console.Clear();
Console.Write("Введите кол-во элементов: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
InputArray(array);
Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
ReleaseArray(array);
Console.WriteLine($"Конечный массив: [{string.Join(", ", array)}]");
*/

/* Задача 40.
Напишите программу, которая принимает на вход три числа
и проверяет, может ли существовать треугольник с сторонами такой длины?
Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы 
двух других сторон.*/

/*
Console.Write("Введите стороны треугольника: ");
int[] array = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();

if (array[0] < array[1] + array[2]
    && array[1] < array[0] + array[2]
    && array[2] < array[0] + array[1])
    Console.Write("Да");
else
    Console.Write("Нет");
*/

/* Задача 42. Напишите программу, которая будет преобразовывать десятичное 
число в двоичное.
45 -> 101101
3 -> 11
2 -> 10
*/

/*
Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
string result = String.Empty;
while (n > 0)
{
    result = Convert.ToString(n % 2) + result;
    n /= 2; // n = n / 2;
}
Console.WriteLine(result);
*/

/* Задача 44. Не используя рекурсию, введите первые N чисел
Фибоначчи. Первые два числа Фибоначчи 0 и 1.


Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine()), a0 = 0,
a1 = 1, x;
for (int i = 0; i < n; i++)
{
    Console.Write($"{a0} ");
    x = a0 + a1;
    a0 = a1;
    a1 = x;
}
*/

/* Задача 45
Напишите программу, которая будет создавать копию массива
с помощью поэлементного копирования.

Console.Clear();
int[] a = {1, 2, 3, 4, 5};
int[] b = new int[a.Length];

for (int i = 0; i < a.Length; i++)
    b[i] = a[i];

b[0] = -5;
Console.WriteLine(string.Join(" ", a));
Console.WriteLine(string.Join(" ", b)); // Поэлементное копирование массива
*/







// Семинар 7

//Task Статистика

/*
int n = Convert.ToInt32(Console.ReadLine());
int[] numbers = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
 
int countEven = 0, countOdd = 0;
foreach (int element in numbers)
{
    if (element % 2 == 1)
    {
        Console.Write($"{element} ");
        countEven++;
    }
}
Console.WriteLine();
foreach (int element in numbers)
{
    if (element % 2 == 0)
    {
        Console.Write($"{element} ");
        countOdd++;
    }
}
Console.WriteLine();

if (countOdd >= countEven)
    Console.WriteLine("YES");
else
    Console.WriteLine("NO");
    */




//Task Гипотеза Гольдбаха

/*
int n = Convert.ToInt32(Console.ReadLine());
int countDel = 0, i, j, k, m;
for (i = 2; i <= n / 2; i++)
{
    countDel = 0;
    for (j = 2; j <= i / 2; j++)
    {
        if (i % j == 0)
            countDel++;
    }
    if (countDel == 0)
    {
        countDel = 0;
        m = n - i;
        for (k = 2; k <= (m + 1) / 2; k++)
        {
            if (m % k == 0)
                countDel++;
        }
        if (countDel == 0)
        {
            Console.WriteLine($"{i} {m}");
            return;
        }
    }
}
*/



// Task 36
/* Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.*/

/*
void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(-10, 11); // [-10, 10]
}

int SummaOdd(int[] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i+=2)
        sum += array[i];
    return sum;
}

Console.Clear();
Console.Write("Введите кол-во чисел: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
InputArray(array);
Console.WriteLine(string.Join(" ", array));
Console.WriteLine(SummaOdd(array));
*/



// Task 38
/* Задайте массив вещественных чисел. Найдите разницу 
между максимальным и минимальным элементов массива.
*/

/*
void InputArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = Math.Round(new Random().NextDouble() * (10 + 10) - 10, 2); // [-10, 10]
}

double MinArray(double[] array)
{
    double min = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < min)
            min = array[i];
    }
    return min;
}

double MaxArray(double[] array)
{
    double max = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > max)
            max = array[i];
    }
    return max;
}

Console.Clear();
Console.Write("Введите кол-во чисел: ");
int n = Convert.ToInt32(Console.ReadLine());
double[] array = new double[n];
InputArray(array);
Console.WriteLine($"[{string.Join(", ", array)}]");
Console.WriteLine(MaxArray(array) - MinArray(array));
*/

/*
double m = 1.934546653;
Console.Write(Math.Truncate(m)); обрезает после запятой
*/

// Task 46

/*
void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(-10, 11); // [-10, 10]
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }
}

Console.Clear();
Console.Write("Введите размеры матрицы: ");
int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];
InputMatrix(matrix);
*/


// Task 48
/*
Задайте двумерный массив размера m на n, каждый элемент в массиве
находится по формуле: Amn = m + n Выведете полученный массив на экран.
*/

/*
void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = i + j;
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }
}

Console.Clear();
Console.Write("Введите размеры матрицы: ");
int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];
InputMatrix(matrix);
*/

/* Задача 49
Задайте двумерный массив. Найдите элементы, у которых оба индекса не чётные
и замените эти элементы на их квадраты
*/
/*
void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(-10, 11); // [-10, 10]
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }
}

void ReleaseMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i % 2 == 1 && j % 2 == 1)
                matrix[i, j] *= matrix[i, j];

            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }
}

Console.Clear();
Console.Write("Введите размеры матрицы: ");
int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];
Console.WriteLine("Начальная матрица: ");
InputMatrix(matrix);
Console.WriteLine("Конечная матрица: ");
ReleaseMatrix(matrix);
*/


/* Задача 51
Задайте двумерный массив. Найдите сумму элементов, находящихся на 
главной диагонали (с индексами (0,0); (1,1); и т.д.)
*/
/*
void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(-10, 11); // [-10, 10]
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }
}

int ReleaseMatrix(int[,] matrix)
{
    int sum = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i == j)
                sum += matrix[i, j];
        }
    }
    return sum;
}

Console.Clear();
Console.Write("Введите размеры матрицы: ");
int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];
Console.WriteLine("Начальная матрица: ");
InputMatrix(matrix);
Console.Write("Результат: ");
Console.WriteLine(ReleaseMatrix(matrix));
*/

// Какой длины массив?
Console.WriteLine("Введите длину массива");
int numArrayLength = int.Parse(Console.ReadLine());

// Что ищем?
Console.WriteLine("Введите искомое число (положительное)");
int numArrayFind = int.Parse(Console.ReadLine());

// Создание функции по генерации структуры массива
void arrayStructure (int[] arrayStruc) {
    int arrayLength = arrayStruc.Length;    // Генерация длины массива
    int index = 0;                         // Индекс начинается с 0

    // Пока индкс меньше длины массива, выполняется слдующее условие
    while(index<arrayLength) {
        arrayStruc[index] = new Random().Next(1, numArrayFind);    // Присваиваем рандом каждому индексу от 1 до 9
        index++;                                        // Переходим к следующему элементу массива
    }
}

// Вывод структуры массива
void printArrayStructure (int[] arrStr) {
    int arrayCount = arrStr.Length; // Генерация длины массива
    int position = 0;               // Позиция начинается с 0

    // Пока позиция массива меньше его длины
    while(position<arrayCount) {
        Console.WriteLine($"{position}-й элемент массива - {arrStr[position]}");   // Выводим элемент массива
        position++;                             // Переходим к следующему элементу массива   
    }
}

// Задаем условие поиска
int searching (int[] arrayStruc, int find) {
    int count = arrayStruc.Length;  // Кладем в счетчик длину массива
    int index = 0;                  // Присваиваем первому элементу массива 0й индекс
    int position = -1;              // Магия

    while(index<count) {
        // Если какой-либо элемент массива равен искомому, то все ок
        if(arrayStruc[index]==find) {
            position = index;   // Присваиваем позиции номер индекса
            break;
        }
        index++;
    }
    return position;
}

int [] array = new int[numArrayLength];                     // Генерируем массив нужной длины
arrayStructure(array);                                      // Генерируем структуру массива рандомами
array[new Random().Next(1, numArrayLength)] = numArrayFind; // Читерство
printArrayStructure(array);                                 // Выводим структура массива

int pos = searching (array, numArrayFind);
switch (pos) {
    case -1:
        Console.WriteLine("Sorry!");
        break;
    default:
        Console.WriteLine(pos);
        break;
}
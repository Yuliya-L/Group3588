// Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
// Например: 7 -> 28
// 4 -> 10
// 8 -> 36

//Запрос данных у пользователя
int ReadData (string line)
{
    //выводим сообщение
    Console.WriteLine(line);
    //считываем число
    int numberP = int.Parse(Console.ReadLine() ?? "0");
    return numberP; //возвращаем значение
}

//Метод вывода результата
void PrintResult(string line)
{
    Console.WriteLine(line);
}

int VariantSumSimple(int numA)
{
    int sumOfNumber =0;
    sumOfNumber = ((1+ numA) * numA) / 2;
    return sumOfNumber;
}

int numberA = ReadData("Введите число A: ");

DateTime d1 = DateTime.Now;
int res1 = VariantSumSimple(numberA);
Console.WriteLine(DateTime.Now - d1);

DateTime d2 = DateTime.Now;
int res2 = VariantSumSimple(numberA);
Console.WriteLine(DateTime.Now - d2);

PrintResult("сумма чисел от 1 до А равна (простой метод):" + res1);
PrintResult("сумма чисел от 1 до А равна (метод Гаусса):" + res2);


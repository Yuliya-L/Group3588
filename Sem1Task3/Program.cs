 // Считываем данные с консоли
string? inputLine = Console.ReadLine ();

// Проверяем чтобы данные были не пустыми
if (inputLine!=null)
{
    // создаем массив с днями недели
    string [] dayOfWeek = new string [7];
    dayOfWeek [0] = "понедельник";
    dayOfWeek [1] = "вторник";
    dayOfWeek [2] = "среда";
    dayOfWeek [3] = "четверг";
    dayOfWeek [4] = "пятница";
    dayOfWeek [5] = "суббота";
    dayOfWeek [6] = "воскресенье";

    //Парсим введенное число
    int inputNumber = int.Parse (inputLine);

// Находим название дня недели по введенному номеру
    string outDayOfWeek = dayOfWeek [inputNumber - 1];

    //выводим данные в консоль
    Console.WriteLine (outDayOfWeek);

}

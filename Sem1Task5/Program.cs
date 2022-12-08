// Считываем данные с консоли
 string? inputLine = Console.ReadLine ();

 //Проверяем чтобы данные были не пустими
 if (inputLine!=null)
 {
    // Парсим введеное число
    int inputNumber = int.Parse (inputLine);

    int startNumber = inputNumber*(-1);

    //Выходное зачение
    string outLine = string.Empty;

    while (startNumber<inputNumber)
    {
        outLine = outLine + startNumber + ",";
        startNumber ++;
        //startNumber=StartNumber+1;
    }
    outLine = outLine + inputNumber;

    //выводим данные в консоль

    Console.WriteLine (outLine);
 }

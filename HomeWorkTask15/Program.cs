Console.WriteLine ("Введите день недели...");
      {int dayofweek = int.Parse (Console.ReadLine());
      if (dayofweek == 6 || dayofweek == 7) Console.WriteLine ("Выходной день");
      else if (dayofweek <= 5) Console.WriteLine ("Рабочий день");
      else if (dayofweek > 7) Console.WriteLine ("Не день недели");
		}
	
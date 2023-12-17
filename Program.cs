 // Инициализация первоначального массива из 5 строк
        string[] initialArray = new string[5] {"ice", "banana", "orange", "kiwi", "pear"};

        // Формирование нового массива из строк, длина которых меньше или равна 3 символам
        string[] newArray = new string[initialArray.Length]; 
        int count = 0;
        for (int i = 0; i < initialArray.Length; i++)
        {
            if (initialArray[i].Length <= 3)
            {
                newArray[count] = initialArray[i];
                count++;
            }
        }

        // Удаление пустых элементов в новом массиве
        Array.Resize(ref newArray, count);

        // Вывод нового массива
        foreach (string s in newArray)
        {
            Console.WriteLine(s);
        }

Console.Clear();

int[] fifteenki1 = {1,2,3,4};
int[] fifteenki2 = {5,6,7,8};
int[] fifteenki3 = {9,10,11,12};
int[] fifteenki4 = {13,14,15,0};

bool CheckArraysEquality(int[] arr1, int[] arr2)
{
    if (arr1.Length != arr2.Length)
    {
        return false;
    }
    else
    {
        for (int i = 0; i < arr1.Length; i++)
        {
            if (arr1[i] == arr2[i])
            {
                continue;
            }
            else
            {
                return false;
            }
       }
       return true;
    }
}

void playgroundFill()
{
    Console.Clear();
    Console.SetCursorPosition(2,2);
    Console.WriteLine(" ___________________ ");

    Console.SetCursorPosition(2,3);
    Console.WriteLine("|    |    |    |    |");

    Console.SetCursorPosition(2,4);
    Console.WriteLine("|");

    Console.SetCursorPosition(4,4);
    Console.WriteLine(fifteenki1[0]);
    
    Console.SetCursorPosition(7,4);
    Console.WriteLine("|");

    Console.SetCursorPosition(9,4);
    Console.WriteLine(fifteenki1[1]);

    Console.SetCursorPosition(12,4);
    Console.WriteLine("|");

    Console.SetCursorPosition(14,4);
    Console.WriteLine(fifteenki1[2]);

    Console.SetCursorPosition(17,4);
    Console.WriteLine("|");

    Console.SetCursorPosition(19,4);
    Console.WriteLine(fifteenki1[3]);

    Console.SetCursorPosition(22,4);
    Console.WriteLine("|");

    Console.SetCursorPosition(2,5);
    Console.WriteLine("|____|____|____|____|");

    Console.SetCursorPosition(2,6);
    Console.WriteLine("|    |    |    |    |");

    Console.SetCursorPosition(2,7);
    Console.WriteLine("|");

    Console.SetCursorPosition(4,7);
    Console.WriteLine(fifteenki2[0]);

    Console.SetCursorPosition(7,7);
    Console.WriteLine("|");
    
    Console.SetCursorPosition(9,7);
    Console.WriteLine(fifteenki2[1]);

    Console.SetCursorPosition(12,7);
    Console.WriteLine("|");

    Console.SetCursorPosition(14,7);
    Console.WriteLine(fifteenki2[2]);

    Console.SetCursorPosition(17,7);
    Console.WriteLine("|");

    Console.SetCursorPosition(19,7);
    Console.WriteLine(fifteenki2[3]);

    Console.SetCursorPosition(22,7);
    Console.WriteLine("|");

    Console.SetCursorPosition(2,8);
    Console.WriteLine("|____|____|____|____|");

    Console.SetCursorPosition(2,9);
    Console.WriteLine("|    |    |    |    |");

    Console.SetCursorPosition(2,10);
    Console.WriteLine("|");

    Console.SetCursorPosition(4,10);
    Console.WriteLine(fifteenki3[0]);

    Console.SetCursorPosition(7,10);
    Console.WriteLine("|");
    
    Console.SetCursorPosition(9,10);
    Console.WriteLine(fifteenki3[1]);

    Console.SetCursorPosition(12,10);
    Console.WriteLine("|");

    Console.SetCursorPosition(14,10);
    Console.WriteLine(fifteenki3[2]);

    Console.SetCursorPosition(17,10);
    Console.WriteLine("|");

    Console.SetCursorPosition(19,10);
    Console.WriteLine(fifteenki3[3]);

    Console.SetCursorPosition(22,10);
    Console.WriteLine("|");

    Console.SetCursorPosition(2,11);
    Console.WriteLine("|____|____|____|____|");

    Console.SetCursorPosition(2,12);
    Console.WriteLine("|    |    |    |    |");

    Console.SetCursorPosition(2,13);
    Console.WriteLine("|");

    Console.SetCursorPosition(4,13);
    Console.WriteLine(fifteenki4[0]);

    Console.SetCursorPosition(7,13);
    Console.WriteLine("|");
    
    Console.SetCursorPosition(9,13);
    Console.WriteLine(fifteenki4[1]);

    Console.SetCursorPosition(12,13);
    Console.WriteLine("|");

    Console.SetCursorPosition(14,13);
    Console.WriteLine(fifteenki4[2]);

    Console.SetCursorPosition(17,13);
    Console.WriteLine("|");

    Console.SetCursorPosition(19,13);
    Console.WriteLine(fifteenki4[3]);

    Console.SetCursorPosition(22,13);
    Console.WriteLine("|");

    Console.SetCursorPosition(2,14);
    Console.WriteLine("|____|____|____|____|");

    Console.SetCursorPosition(0,1);
}

void mixArray(int[] array11, int[] array22, int[] array33, int[] array44)
{
    int repeat = new Random().Next(2,3);
    int count = 0;
    if (array11.Length == array22.Length && array33.Length == array44.Length && array22.Length == array33.Length)
    {
    while (count < repeat)
        {
            int size = array11.Length;
            int i = 0;
            int temp = 0;
            int j = i + 1;
            while (i < size)
            {
                temp = array11[i];
                array11[i] = array11[j];
                array11[j] = temp;

                temp = array11[i];
                array11[i] = array22[i];
                array22[i] = temp;

                temp = array22[i];
                array22[i] = array33[i];
                array33[i] = temp;

                temp = array33[i];
                array33[i] = array44[i];
                array44[i] = temp;

                i++;
            }
            count++;
        }
    }
}

int findPosition(int[] array, int find)
{
    int position = -1;
    int index = 0;
    int size = array.Length;
    while (index < size)
    {
        if (array[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}

void gamePlay(int[] array1, int[] array2, int[] array3, int[] array4)
{
    int[] GG1 = {1,2,3,4};
    int[] GG2 = {5,6,7,8};
    int[] GG3 = {9,10,11,12};
    int[] GG4 = {13,14,15,0};

    while(CheckArraysEquality(fifteenki1, GG1) == false || CheckArraysEquality(fifteenki2, GG2) == false || CheckArraysEquality(fifteenki3, GG3) == false || CheckArraysEquality(fifteenki4, GG4) == false)
    {
        Console.WriteLine("Выбор поля 1: ");
        Console.SetCursorPosition(15,1);
        Int32.TryParse(Console.ReadLine(), out int playerChoise1);
        Console.SetCursorPosition(0,1);
        Console.WriteLine("                                                  ");
        Console.SetCursorPosition(0,1);
        Console.WriteLine("Выбор поля 2: ");
        Console.SetCursorPosition(15,1);
        Int32.TryParse(Console.ReadLine(), out int playerChoise2);
        Console.SetCursorPosition(0,1);
        Console.WriteLine("                                                  ");
        Console.SetCursorPosition(0,1);
        if ((playerChoise1 >= 1 && playerChoise1 <=15 && playerChoise2 == 0) || (playerChoise2 >= 1 && playerChoise2 <=15 && playerChoise1 == 0))
        {
            if (findPosition(fifteenki1, playerChoise1) != -1 && findPosition(fifteenki1, playerChoise2) != -1)
            {
                int position1 = findPosition(fifteenki1, playerChoise1);
                int position2 = findPosition(fifteenki1, playerChoise2);
                if (Math.Abs(position1 - position2) == 1)
                {
                    int temp = fifteenki1[position1];
                    fifteenki1[position1] = fifteenki1[position2];
                    fifteenki1[position2] = temp;
                    playgroundFill();
                    continue;
                }
            }
            if (findPosition(fifteenki2, playerChoise1) != -1 && findPosition(fifteenki2, playerChoise2) != -1)
            {
                int position1 = findPosition(fifteenki2, playerChoise1);
                int position2 = findPosition(fifteenki2, playerChoise2);
                if (Math.Abs(position1 - position2) == 1)
                {
                    int temp = fifteenki2[position1];
                    fifteenki2[position1] = fifteenki2[position2];
                    fifteenki2[position2] = temp;
                    playgroundFill();
                    continue;
                }
            }
            if (findPosition(fifteenki3, playerChoise1) != -1 && findPosition(fifteenki3, playerChoise2) != -1)
            {
                int position1 = findPosition(fifteenki3, playerChoise1);
                int position2 = findPosition(fifteenki3, playerChoise2);
                if (Math.Abs(position1 - position2) == 1)
                {
                    int temp = fifteenki3[position1];
                    fifteenki3[position1] = fifteenki3[position2];
                    fifteenki3[position2] = temp;
                    playgroundFill();
                    continue;
                }
            }
            if (findPosition(fifteenki4, playerChoise1) != -1 && findPosition(fifteenki4, playerChoise2) != -1)
            {
                int position1 = findPosition(fifteenki4, playerChoise1);
                int position2 = findPosition(fifteenki4, playerChoise2);
                if (Math.Abs(position1 - position2) == 1)
                {
                    int temp = fifteenki4[position1];
                    fifteenki4[position1] = fifteenki4[position2];
                    fifteenki4[position2] = temp;
                    playgroundFill();
                    continue;
                }
            }
            if (findPosition(fifteenki1, playerChoise1) != -1 && findPosition(fifteenki2, playerChoise2) != -1)
            {
                int position1 = findPosition(fifteenki1, playerChoise1);
                int position2 = findPosition(fifteenki2, playerChoise2);
                if (Math.Abs(position1 - position2) == 0)
                {
                    int temp = fifteenki1[position1];
                    fifteenki1[position1] = fifteenki2[position2];
                    fifteenki2[position2] = temp;
                    playgroundFill();
                    continue;
                }
            }
            if (findPosition(fifteenki2, playerChoise1) != -1 && findPosition(fifteenki1, playerChoise2) != -1)
            {
                int position1 = findPosition(fifteenki2, playerChoise1);
                int position2 = findPosition(fifteenki1, playerChoise2);
                if (Math.Abs(position1 - position2) == 0)
                {
                    int temp = fifteenki2[position1];
                    fifteenki2[position1] = fifteenki1[position2];
                    fifteenki1[position2] = temp;
                    playgroundFill();
                    continue;
                }
            }
            if (findPosition(fifteenki2, playerChoise1) != -1 && findPosition(fifteenki3, playerChoise2) != -1)
            {
                int position1 = findPosition(fifteenki2, playerChoise1);
                int position2 = findPosition(fifteenki3, playerChoise2);
                if (Math.Abs(position1 - position2) == 0)
                {
                    int temp = fifteenki2[position1];
                    fifteenki2[position1] = fifteenki3[position2];
                    fifteenki3[position2] = temp;
                    playgroundFill();
                    continue;
                }
            }
            if (findPosition(fifteenki3, playerChoise1) != -1 && findPosition(fifteenki2, playerChoise2) != -1)
            {
                int position1 = findPosition(fifteenki3, playerChoise1);
                int position2 = findPosition(fifteenki2, playerChoise2);
                if (Math.Abs(position1 - position2) == 0)
                {
                    int temp = fifteenki3[position1];
                    fifteenki3[position1] = fifteenki2[position2];
                    fifteenki2[position2] = temp;
                    playgroundFill();
                    continue;
                }
            }
            if (findPosition(fifteenki3, playerChoise1) != -1 && findPosition(fifteenki4, playerChoise2) != -1)
            {
                int position1 = findPosition(fifteenki3, playerChoise1);
                int position2 = findPosition(fifteenki4, playerChoise2);
                if (Math.Abs(position1 - position2) == 0)
                {
                    int temp = fifteenki3[position1];
                    fifteenki3[position1] = fifteenki4[position2];
                    fifteenki4[position2] = temp;
                    playgroundFill();
                    continue;
                }
            }
            if (findPosition(fifteenki4, playerChoise1) != -1 && findPosition(fifteenki3, playerChoise2) != -1)
            {
                int position1 = findPosition(fifteenki4, playerChoise1);
                int position2 = findPosition(fifteenki3, playerChoise2);
                if (Math.Abs(position1 - position2) == 0)
                {
                    int temp = fifteenki4[position1];
                    fifteenki4[position1] = fifteenki3[position2];
                    fifteenki3[position2] = temp;
                    playgroundFill();
                    continue;
                }
            }
            else
            {
                continue;
            }
        }
        else
        {
            continue;
        }
    }
    if (CheckArraysEquality(fifteenki1, GG1) == true && CheckArraysEquality(fifteenki2, GG2) == true && CheckArraysEquality(fifteenki3, GG3) == true && CheckArraysEquality(fifteenki4, GG4) == true)
        {
            Console.WriteLine("Вы выиграли! Нажмите Enter чтобы выйти: ");
            while (Console.ReadKey(true).Key != ConsoleKey.Enter) {Console.Write("");}
        }
}

mixArray(fifteenki1, fifteenki2, fifteenki3, fifteenki4);

Console.WriteLine("Пятнашки. Введите поочередно номера двух полей, которые хотите поменять местами.");
Console.WriteLine("Одним из полей всегда должен быть 0 - пустое поле. Нажмите Enter, чтобы начать игру: ");
while (Console.ReadKey(true).Key != ConsoleKey.Enter) {Console.Write("");}

playgroundFill();

gamePlay(fifteenki1, fifteenki2, fifteenki3, fifteenki4);

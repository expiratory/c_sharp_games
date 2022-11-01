Console.Clear();

int[] fifteenki1 = {10,11,12,13};
int[] fifteenki2 = {14,15,16,17};
int[] fifteenki3 = {18,19,20,21};
int[] fifteenki4 = {22,23,24,99};

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
    Console.WriteLine($"| {fifteenki1[0]} | {fifteenki1[1]} | {fifteenki1[2]} | {fifteenki1[3]} |");

    Console.SetCursorPosition(2,5);
    Console.WriteLine("|____|____|____|____|");

    Console.SetCursorPosition(2,6);
    Console.WriteLine("|    |    |    |    |");

    Console.SetCursorPosition(2,7);
    Console.WriteLine($"| {fifteenki2[0]} | {fifteenki2[1]} | {fifteenki2[2]} | {fifteenki2[3]} |");

    Console.SetCursorPosition(2,8);
    Console.WriteLine("|____|____|____|____|");

    Console.SetCursorPosition(2,9);
    Console.WriteLine("|    |    |    |    |");

    Console.SetCursorPosition(2,10);
    Console.WriteLine($"| {fifteenki3[0]} | {fifteenki3[1]} | {fifteenki3[2]} | {fifteenki3[3]} |");

    Console.SetCursorPosition(2,11);
    Console.WriteLine("|____|____|____|____|");

    Console.SetCursorPosition(2,12);
    Console.WriteLine("|    |    |    |    |");

    Console.SetCursorPosition(2,13);
    Console.WriteLine($"| {fifteenki4[0]} | {fifteenki4[1]} | {fifteenki4[2]} | {fifteenki4[3]} |");

    Console.SetCursorPosition(2,14);
    Console.WriteLine("|____|____|____|____|");

    Console.SetCursorPosition(0,1);
}

void mixArray(int[] array)
{
    int repeat = new Random().Next(5,10);
    int count = 0;
    while (count < repeat)
    {
        int size = array.Length;
        int i = 0;
        int temp = 0;
        int j = i + 1;
        while (i < size)
        {
            temp = array[i];
            array[i] = array[j];
            array[j] = temp;
            i++;
        }
        count++;
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
    int[] GG1 = {10,11,12,13};
    int[] GG2 = {14,15,16,17};
    int[] GG3 = {18,19,20,21};
    int[] GG4 = {22,23,24,99};

    while(CheckArraysEquality(fifteenki1, GG1) == false || CheckArraysEquality(fifteenki2, GG2) == false || CheckArraysEquality(fifteenki3, GG3) == false || CheckArraysEquality(fifteenki4, GG4) == false)
    {
        Console.WriteLine("Выбор 1: ");
        Console.SetCursorPosition(10,1);
        Int32.TryParse(Console.ReadLine(), out int playerChoise1);
        Console.SetCursorPosition(0,1);
        Console.WriteLine("                                                  ");
        Console.SetCursorPosition(0,1);
        Console.WriteLine("Выбор 2: ");
        Console.SetCursorPosition(10,1);
        Int32.TryParse(Console.ReadLine(), out int playerChoise2);
        Console.SetCursorPosition(0,1);
        Console.WriteLine("                                                  ");
        Console.SetCursorPosition(0,1);
        if ((playerChoise1 >= 10 && playerChoise1 <=24 && playerChoise2 == 99) || (playerChoise2 >= 10 && playerChoise2 <=24 && playerChoise1 == 99))
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

mixArray(fifteenki1);
mixArray(fifteenki2);
mixArray(fifteenki3);
mixArray(fifteenki4);

Console.WriteLine("Пятнашки. Нажмите Enter, чтобы начать игру: ");
while (Console.ReadKey(true).Key != ConsoleKey.Enter) {Console.Write("");}

playgroundFill();

gamePlay(fifteenki1, fifteenki2, fifteenki3, fifteenki4);

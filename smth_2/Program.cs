Console.Clear();

void playgroundFill()
{
    Console.SetCursorPosition(2,2);
    Console.WriteLine("_____________");

    Console.SetCursorPosition(2,3);
    Console.WriteLine("|");
    Console.SetCursorPosition(2,4);
    Console.WriteLine("|");
    Console.SetCursorPosition(6,3);
    Console.WriteLine("|");
    Console.SetCursorPosition(6,4);
    Console.WriteLine("|");
    Console.SetCursorPosition(10,3);
    Console.WriteLine("|");
    Console.SetCursorPosition(10,4);
    Console.WriteLine("|");
    Console.SetCursorPosition(14,3);
    Console.WriteLine("|");
    Console.SetCursorPosition(14,4);
    Console.WriteLine("|");
    Console.SetCursorPosition(2,5);
    Console.WriteLine("|___|___|___|");

    Console.SetCursorPosition(2,6);
    Console.WriteLine("|");
    Console.SetCursorPosition(2,7);
    Console.WriteLine("|");
    Console.SetCursorPosition(6,6);
    Console.WriteLine("|");
    Console.SetCursorPosition(6,7);
    Console.WriteLine("|");
    Console.SetCursorPosition(10,6);
    Console.WriteLine("|");
    Console.SetCursorPosition(10,7);
    Console.WriteLine("|");
    Console.SetCursorPosition(14,6);
    Console.WriteLine("|");
    Console.SetCursorPosition(14,7);
    Console.WriteLine("|");
    Console.SetCursorPosition(2,8);
    Console.WriteLine("|___|___|___|");

    Console.SetCursorPosition(2,9);
    Console.WriteLine("|");
    Console.SetCursorPosition(2,10);
    Console.WriteLine("|");
    Console.SetCursorPosition(6,9);
    Console.WriteLine("|");
    Console.SetCursorPosition(6,10);
    Console.WriteLine("|");
    Console.SetCursorPosition(10,9);
    Console.WriteLine("|");
    Console.SetCursorPosition(10,10);
    Console.WriteLine("|");
    Console.SetCursorPosition(14,9);
    Console.WriteLine("|");
    Console.SetCursorPosition(14,10);
    Console.WriteLine("|");
    Console.SetCursorPosition(2,11);
    Console.WriteLine("|___|___|___|");

    Console.SetCursorPosition(4,4);
    Console.WriteLine("7");
    Console.SetCursorPosition(8,4);
    Console.WriteLine("8");
    Console.SetCursorPosition(12,4);
    Console.WriteLine("9");
    Console.SetCursorPosition(4,7);
    Console.WriteLine("4");
    Console.SetCursorPosition(8,7);
    Console.WriteLine("5");
    Console.SetCursorPosition(12,7);
    Console.WriteLine("6");
    Console.SetCursorPosition(4,10);
    Console.WriteLine("1");
    Console.SetCursorPosition(8,10);
    Console.WriteLine("2");
    Console.SetCursorPosition(12,10);
    Console.WriteLine("3");

    Console.SetCursorPosition(0,1);
}

void choiseX(int playerChoise)
{   
    if (playerChoise == 1)
    {
        Console.SetCursorPosition(4,10);
        Console.WriteLine("X");
        Console.SetCursorPosition(0,1);
    }
    else if (playerChoise == 2)
    {
        Console.SetCursorPosition(8,10);
        Console.WriteLine("X");
        Console.SetCursorPosition(0,1);
    }
    else if (playerChoise == 3)
    {
        Console.SetCursorPosition(12,10);
        Console.WriteLine("X");
        Console.SetCursorPosition(0,1);
    }
    else if (playerChoise == 4)
    {
        Console.SetCursorPosition(4,7);
        Console.WriteLine("X");
        Console.SetCursorPosition(0,1);
    }
    else if (playerChoise == 5)
    {
        Console.SetCursorPosition(8,7);
        Console.WriteLine("X");
        Console.SetCursorPosition(0,1);
    }
    else if (playerChoise == 6)
    {
        Console.SetCursorPosition(12,7);
        Console.WriteLine("X");
        Console.SetCursorPosition(0,1);
    }
    else if (playerChoise == 7)
    {
        Console.SetCursorPosition(4,4);
        Console.WriteLine("X");
        Console.SetCursorPosition(0,1);
    }
    else if (playerChoise == 8)
    {
        Console.SetCursorPosition(8,4);
        Console.WriteLine("X");
        Console.SetCursorPosition(0,1);
    }
    else if (playerChoise == 9)
    {
        Console.SetCursorPosition(12,4);
        Console.WriteLine("X");
        Console.SetCursorPosition(0,1);
    }
}

void choiseO(int playerChoise)
{   
    if (playerChoise == 1)
    {
        Console.SetCursorPosition(4,10);
        Console.WriteLine("O");
        Console.SetCursorPosition(0,1);
    }
    else if (playerChoise == 2)
    {
        Console.SetCursorPosition(8,10);
        Console.WriteLine("O");
        Console.SetCursorPosition(0,1);
    }
    else if (playerChoise == 3)
    {
        Console.SetCursorPosition(12,10);
        Console.WriteLine("O");
        Console.SetCursorPosition(0,1);
    }
    else if (playerChoise == 4)
    {
        Console.SetCursorPosition(4,7);
        Console.WriteLine("O");
        Console.SetCursorPosition(0,1);
    }
    else if (playerChoise == 5)
    {
        Console.SetCursorPosition(8,7);
        Console.WriteLine("O");
        Console.SetCursorPosition(0,1);
    }
    else if (playerChoise == 6)
    {
        Console.SetCursorPosition(12,7);
        Console.WriteLine("O");
        Console.SetCursorPosition(0,1);
    }
    else if (playerChoise == 7)
    {
        Console.SetCursorPosition(4,4);
        Console.WriteLine("O");
        Console.SetCursorPosition(0,1);
    }
    else if (playerChoise == 8)
    {
        Console.SetCursorPosition(8,4);
        Console.WriteLine("O");
        Console.SetCursorPosition(0,1);
    }
    else if (playerChoise == 9)
    {
        Console.SetCursorPosition(12,4);
        Console.WriteLine("O");
        Console.SetCursorPosition(0,1);
    }
}

int findAlreadyChosen(int[] array, int find)
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

void playGame()
{
    int[] alreadyChosen = new int [10000];
    int pos = -1;
    int i = 0;
    while (i < 9)
    {
        int choise = Convert.ToInt32(Console.ReadLine());
        if (choise >= 1 && choise <= 9)
        {
            pos = findAlreadyChosen(alreadyChosen, choise);
            alreadyChosen[i] = choise;
            if (i%2 == 0 && pos == -1)
            {
                choiseX(choise);
                i++;
            }
            else if (i%2 == 1 && pos == -1)
            {
                choiseO(choise);
                i++;
            }
        }
        else
        {
            continue;
        }
    }
}

Console.WriteLine("Сначала ходят крестики, затем нолики и так далее до конца игры. Выберите клетку: ");

playgroundFill();

playGame();

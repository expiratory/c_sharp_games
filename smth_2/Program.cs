Console.Clear();

void playgroundFill()
{
    Console.Clear();
    Console.SetCursorPosition(2,2);
    Console.WriteLine(" ___________ ");

    Console.SetCursorPosition(2,3);
    Console.WriteLine("|   |   |   |");

    Console.SetCursorPosition(2,4);
    Console.WriteLine("| 7 | 8 | 9 |");

    Console.SetCursorPosition(2,5);
    Console.WriteLine("|___|___|___|");

    Console.SetCursorPosition(2,6);
    Console.WriteLine("|   |   |   |");

    Console.SetCursorPosition(2,7);
    Console.WriteLine("| 4 | 5 | 6 |");

    Console.SetCursorPosition(2,8);
    Console.WriteLine("|___|___|___|");

    Console.SetCursorPosition(2,9);
    Console.WriteLine("|   |   |   |");

    Console.SetCursorPosition(2,10);
    Console.WriteLine("| 1 | 2 | 3 |");

    Console.SetCursorPosition(2,11);
    Console.WriteLine("|___|___|___|");

    Console.SetCursorPosition(0,1);
}

void choiseX(int playerChoise)
{   
    switch(playerChoise)
    {
        case 1:
            Console.SetCursorPosition(4,10);
            Console.WriteLine("X");
            Console.SetCursorPosition(0,1);
            break;
        case 2:
            Console.SetCursorPosition(8,10);
            Console.WriteLine("X");
            Console.SetCursorPosition(0,1);
            break;
        case 3:
            Console.SetCursorPosition(12,10);
            Console.WriteLine("X");
            Console.SetCursorPosition(0,1);
            break;
        case 4:
            Console.SetCursorPosition(4,7);
            Console.WriteLine("X");
            Console.SetCursorPosition(0,1);
            break;
        case 5:
            Console.SetCursorPosition(8,7);
            Console.WriteLine("X");
            Console.SetCursorPosition(0,1);
            break;
        case 6:
            Console.SetCursorPosition(12,7);
            Console.WriteLine("X");
            Console.SetCursorPosition(0,1);
            break;
        case 7:
            Console.SetCursorPosition(4,4);
            Console.WriteLine("X");
            Console.SetCursorPosition(0,1);
            break;
        case 8:
            Console.SetCursorPosition(8,4);
            Console.WriteLine("X");
            Console.SetCursorPosition(0,1);
            break;
        case 9:
            Console.SetCursorPosition(12,4);
            Console.WriteLine("X");
            Console.SetCursorPosition(0,1);
            break;
    }
}

void choiseO(int playerChoise)
{   
    switch(playerChoise)
    {
        case 1:
            Console.SetCursorPosition(4,10);
            Console.WriteLine("O");
            Console.SetCursorPosition(0,1);
            break;
        case 2:
            Console.SetCursorPosition(8,10);
            Console.WriteLine("O");
            Console.SetCursorPosition(0,1);
            break;
        case 3:
            Console.SetCursorPosition(12,10);
            Console.WriteLine("O");
            Console.SetCursorPosition(0,1);
            break;
        case 4:
            Console.SetCursorPosition(4,7);
            Console.WriteLine("O");
            Console.SetCursorPosition(0,1);
            break;
        case 5:
            Console.SetCursorPosition(8,7);
            Console.WriteLine("O");
            Console.SetCursorPosition(0,1);
            break;
        case 6:
            Console.SetCursorPosition(12,7);
            Console.WriteLine("O");
            Console.SetCursorPosition(0,1);
            break;
        case 7:
            Console.SetCursorPosition(4,4);
            Console.WriteLine("O");
            Console.SetCursorPosition(0,1);
            break;
        case 8:
            Console.SetCursorPosition(8,4);
            Console.WriteLine("O");
            Console.SetCursorPosition(0,1);
            break;
        case 9:
            Console.SetCursorPosition(12,4);
            Console.WriteLine("O");
            Console.SetCursorPosition(0,1);
            break;
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
    int[] choisesOfX = new int [100];
    int[] choisesOfO = new int [100];
    int pos = -1;
    int i = 0;
    int iX = 0;
    int iO = 0;
    while (i < 9)
    {
        Console.SetCursorPosition(0,1);
        Int32.TryParse(Console.ReadLine(), out int choise);
        Console.SetCursorPosition(0,1);
        Console.WriteLine("                                                  ");
        if (choise >= 1 && choise <= 9)
        {
            pos = findAlreadyChosen(alreadyChosen, choise);
            alreadyChosen[i] = choise;
            if (i%2 == 0 && pos == -1)
            {
                choiseX(choise);
                choisesOfX[iX] = choise;
                if (findAlreadyChosen(choisesOfX, 1) != -1 && findAlreadyChosen(choisesOfX, 4) != -1 && findAlreadyChosen(choisesOfX, 7) != -1)
                {
                    Console.WriteLine("Крестики выиграли! Нажмите Enter чтобы выйти: ");
                    while (Console.ReadKey(true).Key != ConsoleKey.Enter) {Console.Write("");}
                    break;
                }
                if (findAlreadyChosen(choisesOfX, 2) != -1 && findAlreadyChosen(choisesOfX, 5) != -1 && findAlreadyChosen(choisesOfX, 8) != -1)
                {
                    Console.WriteLine("Крестики выиграли! Нажмите Enter чтобы выйти: ");
                    while (Console.ReadKey(true).Key != ConsoleKey.Enter) {Console.Write("");}
                    break;
                }
                if (findAlreadyChosen(choisesOfX, 3) != -1 && findAlreadyChosen(choisesOfX, 6) != -1 && findAlreadyChosen(choisesOfX, 9) != -1)
                {
                    Console.WriteLine("Крестики выиграли! Нажмите Enter чтобы выйти: ");
                    while (Console.ReadKey(true).Key != ConsoleKey.Enter) {Console.Write("");}
                    break;
                }
                if (findAlreadyChosen(choisesOfX, 1) != -1 && findAlreadyChosen(choisesOfX, 2) != -1 && findAlreadyChosen(choisesOfX, 3) != -1)
                {
                    Console.WriteLine("Крестики выиграли! Нажмите Enter чтобы выйти: ");
                    while (Console.ReadKey(true).Key != ConsoleKey.Enter) {Console.Write("");}
                    break;
                }
                if (findAlreadyChosen(choisesOfX, 4) != -1 && findAlreadyChosen(choisesOfX, 5) != -1 && findAlreadyChosen(choisesOfX, 6) != -1)
                {
                    Console.WriteLine("Крестики выиграли! Нажмите Enter чтобы выйти: ");
                    while (Console.ReadKey(true).Key != ConsoleKey.Enter) {Console.Write("");}
                    break;
                }
                if (findAlreadyChosen(choisesOfX, 7) != -1 && findAlreadyChosen(choisesOfX, 8) != -1 && findAlreadyChosen(choisesOfX, 9) != -1)
                {
                    Console.WriteLine("Крестики выиграли! Нажмите Enter чтобы выйти: ");
                    while (Console.ReadKey(true).Key != ConsoleKey.Enter) {Console.Write("");}
                    break;
                }
                if (findAlreadyChosen(choisesOfX, 1) != -1 && findAlreadyChosen(choisesOfX, 5) != -1 && findAlreadyChosen(choisesOfX, 9) != -1)
                {
                    Console.WriteLine("Крестики выиграли! Нажмите Enter чтобы выйти: ");
                    while (Console.ReadKey(true).Key != ConsoleKey.Enter) {Console.Write("");}
                    break;
                }
                if (findAlreadyChosen(choisesOfX, 7) != -1 && findAlreadyChosen(choisesOfX, 5) != -1 && findAlreadyChosen(choisesOfX, 3) != -1)
                {
                    Console.WriteLine("Крестики выиграли! Нажмите Enter чтобы выйти: ");
                    while (Console.ReadKey(true).Key != ConsoleKey.Enter) {Console.Write("");}
                    break;
                }
                iX++;
                i++;
            }
            else if (i%2 == 1 && pos == -1)
            {
                choiseO(choise);
                choisesOfO[iO] = choise;
                if (findAlreadyChosen(choisesOfO, 1) != -1 && findAlreadyChosen(choisesOfO, 4) != -1 && findAlreadyChosen(choisesOfO, 7) != -1)
                {
                    Console.WriteLine("Нолики выиграли! Нажмите Enter чтобы выйти: ");
                    while (Console.ReadKey(true).Key != ConsoleKey.Enter) {Console.Write("");}
                    break;
                }
                if (findAlreadyChosen(choisesOfO, 2) != -1 && findAlreadyChosen(choisesOfO, 5) != -1 && findAlreadyChosen(choisesOfO, 8) != -1)
                {
                    Console.WriteLine("Нолики выиграли! Нажмите Enter чтобы выйти: ");
                    while (Console.ReadKey(true).Key != ConsoleKey.Enter) {Console.Write("");}
                    break;
                }
                if (findAlreadyChosen(choisesOfO, 3) != -1 && findAlreadyChosen(choisesOfO, 6) != -1 && findAlreadyChosen(choisesOfO, 9) != -1)
                {
                    Console.WriteLine("Нолики выиграли! Нажмите Enter чтобы выйти: ");
                    while (Console.ReadKey(true).Key != ConsoleKey.Enter) {Console.Write("");}
                    break;
                }
                if (findAlreadyChosen(choisesOfO, 1) != -1 && findAlreadyChosen(choisesOfO, 2) != -1 && findAlreadyChosen(choisesOfO, 3) != -1)
                {
                    Console.WriteLine("Нолики выиграли! Нажмите Enter чтобы выйти: ");
                    while (Console.ReadKey(true).Key != ConsoleKey.Enter) {Console.Write("");}
                    break;
                }
                if (findAlreadyChosen(choisesOfO, 4) != -1 && findAlreadyChosen(choisesOfO, 5) != -1 && findAlreadyChosen(choisesOfO, 6) != -1)
                {
                    Console.WriteLine("Нолики выиграли! Нажмите Enter чтобы выйти: ");
                    while (Console.ReadKey(true).Key != ConsoleKey.Enter) {Console.Write("");}
                    break;
                }
                if (findAlreadyChosen(choisesOfO, 7) != -1 && findAlreadyChosen(choisesOfO, 8) != -1 && findAlreadyChosen(choisesOfO, 9) != -1)
                {
                    Console.WriteLine("Нолики выиграли! Нажмите Enter чтобы выйти: ");
                    while (Console.ReadKey(true).Key != ConsoleKey.Enter) {Console.Write("");}
                    break;
                }
                if (findAlreadyChosen(choisesOfO, 1) != -1 && findAlreadyChosen(choisesOfO, 5) != -1 && findAlreadyChosen(choisesOfO, 9) != -1)
                {
                    Console.WriteLine("Нолики выиграли! Нажмите Enter чтобы выйти: ");
                    while (Console.ReadKey(true).Key != ConsoleKey.Enter) {Console.Write("");}
                    break;
                }
                if (findAlreadyChosen(choisesOfO, 7) != -1 && findAlreadyChosen(choisesOfO, 5) != -1 && findAlreadyChosen(choisesOfO, 3) != -1)
                {
                    Console.WriteLine("Нолики выиграли! Нажмите Enter чтобы выйти: ");
                    while (Console.ReadKey(true).Key != ConsoleKey.Enter) {Console.Write("");}
                    break;
                }
                iO++;
                i++;
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
    if (i == 9)
    {
        Console.WriteLine("Ничья! Нажмите Enter чтобы выйти: ");
        Console.ReadLine();
    }
}

Console.WriteLine("Сначала ходят крестики, затем нолики. Нажмите Enter, чтобы начать игру: ");
while (Console.ReadKey(true).Key != ConsoleKey.Enter) {Console.Write("");}

playgroundFill();

playGame();

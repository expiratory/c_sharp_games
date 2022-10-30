Console.Clear();

Console.SetCursorPosition(2,2);
string number2 = " ___________ ";
Console.WriteLine(number2);

Console.SetCursorPosition(2,3);
string number3 = "|   |   |   |";
Console.WriteLine(number3);

Console.SetCursorPosition(2,4);
string number4 = "| 7 | 8 | 9 |";
Console.WriteLine(number4);

Console.SetCursorPosition(2,5);
string number5 = "|___|___|___|";
Console.WriteLine(number5);

Console.SetCursorPosition(2,6);
string number6 = "|   |   |   |";
Console.WriteLine(number6);

Console.SetCursorPosition(2,7);
string number7 = "| 4 | 5 | 6 |";
Console.WriteLine(number7);

Console.SetCursorPosition(2,8);
string number8 = "|___|___|___|";
Console.WriteLine(number8);

Console.SetCursorPosition(2,9);
string number9 = "|   |   |   |";
Console.WriteLine(number9);

Console.SetCursorPosition(2,10);
string number10 = "| 1 | 2 | 3 |";
Console.WriteLine(number10);

Console.SetCursorPosition(2,11);
string number11 = "|___|___|___|";
Console.WriteLine(number11);

Console.SetCursorPosition(0,1);

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
        Console.SetCursorPosition(81,1);
        int choise = Convert.ToInt32(Console.ReadLine());
        if (choise >= 1 && choise <= 9)
        {
            pos = findAlreadyChosen(alreadyChosen, choise);
            alreadyChosen[i] = choise;
            if (i%2 == 0 && pos == -1)
            {
                choiseX(choise);
                checkForWinO(number4, number7, number10);
                checkForWinX(number4, number7, number10);
                i++;
            }
            else if (i%2 == 1 && pos == -1)
            {
                choiseO(choise);
                checkForWinO(number4, number7, number10);
                checkForWinX(number4, number7, number10);
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
}

void checkForWinX(string num1, string num2, string num3)
{
    if (num1[2] == 'X' && num2[2] == 'X' && num3[2] == 'X')
    {
        Console.WriteLine("Крестики победили!");
    }
    else if (num1[6] == 'X' && num2[6] == 'X' && num3[6] == 'X')
    {
        Console.WriteLine("Крестики победили!");
    }
    else if (num1[10] == 'X' && num2[10] == 'X' && num3[10] == 'X')
    {
        Console.WriteLine("Крестики победили!");
    }
    else if (num1[2] == 'X' && num1[6] == 'X' && num1[10] == 'X')
    {
        Console.WriteLine("Крестики победили!");
    }
    else if (num2[2] == 'X' && num2[6] == 'X' && num2[6] == 'X')
    {
        Console.WriteLine("Крестики победили!");
    }
    else if (num3[2] == 'X' && num3[6] == 'X' && num3[10] == 'X')
    {
        Console.WriteLine("Крестики победили!");
    }
    else if (num1[2] == 'X' && num2[6] == 'X' && num3[10] == 'X')
    {
        Console.WriteLine("Крестики победили!");
    }
    else if (num1[10] == 'X' && num2[6] == 'X' && num3[2] == 'X')
    {
        Console.WriteLine("Крестики победили!");
    }
}

void checkForWinO(string num1, string num2, string num3)
{
    if (num1[2] == 'O' && num2[2] == 'O' && num3[2] == 'O')
    {
        Console.WriteLine("Нолики победили!");
    }
    else if (num1[6] == 'O' && num2[6] == 'O' && num3[6] == 'O')
    {
        Console.WriteLine("Нолики победили!");
    }
    else if (num1[10] == 'O' && num2[10] == 'O' && num3[10] == 'O')
    {
        Console.WriteLine("Нолики победили!");
    }
    else if (num1[2] == 'O' && num1[6] == 'O' && num1[10] == 'O')
    {
        Console.WriteLine("Нолики победили!");
    }
    else if (num2[2] == 'O' && num2[6] == 'O' && num2[6] == 'O')
    {
        Console.WriteLine("Нолики победили!");
    }
    else if (num3[2] == 'O' && num3[6] == 'O' && num3[10] == 'O')
    {
        Console.WriteLine("Нолики победили!");
    }
    else if (num1[2] == 'O' && num2[6] == 'O' && num3[10] == 'O')
    {
        Console.WriteLine("Нолики победили!");
    }
    else if (num1[10] == 'O' && num2[6] == 'O' && num3[2] == 'O')
    {
        Console.WriteLine("Нолики победили!");
    }
}

Console.WriteLine("Сначала ходят крестики, затем нолики и так далее до конца игры. Выберите клетку: ");

playGame();

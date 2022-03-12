int PlayerScore = 0;
int ComputerScore = 0;
string Rock = @"   
    _______
---'   ____)
      (_____)
      (_____)
      (____)
---.__(___)";


string Paper = @"   
    ________
---'    ____)____
           ______)
          _______)
         _______)
---.__________)";


string Scissors = @"   
    _______
---'   ____)____
          ______)
       __________)
      (____)
---.__(___)";


void Game()
{   
    while (PlayerScore < 3 && ComputerScore < 3)
    {
        Match();
    }
}

Game();

void Match ()
{
    Menu();

    string input = Console.ReadLine();
    int PlayerAnswer = int.Parse(input);

    Random choice = new Random ();
    int ComputerAnswer = choice.Next(1,4);

    Selection(PlayerAnswer);
    Console.WriteLine();
    Console.WriteLine("vs");
    Console.WriteLine();
    Selection(ComputerAnswer);
    Console.WriteLine();
        
    if (PlayerAnswer == 1 && ComputerAnswer == 2)
    {
        ComputerScore++;
        Console.WriteLine("Point for the Computer!");
    }
    else if (PlayerAnswer == 1 && ComputerAnswer == 3)
    {
        PlayerScore++;
        Console.WriteLine("Point for the Player!");
    }
    else if (PlayerAnswer == 2 && ComputerAnswer == 1)
    {
        PlayerScore++;
        Console.WriteLine("Point for the Player!");
    }
    else if (PlayerAnswer == 2 && ComputerAnswer == 3)
    {
        ComputerScore++;
        Console.WriteLine("Point for the Computer!");
    }
    else if (PlayerAnswer == 3 && ComputerAnswer == 1)
    {
        ComputerScore++;
        Console.WriteLine("Point for the Computer!");
    }
    else if (PlayerAnswer == 3 && ComputerAnswer == 2)
    {
        PlayerScore++;
        Console.WriteLine("Point for the Player!");
    }
    else if (PlayerAnswer == ComputerAnswer)
    {
        Console.WriteLine("No score, throw again!");
    }

    if (PlayerScore == 3)
    {
        Console.WriteLine("YOU WIN");
        Console.WriteLine($"Final Score: Player: {PlayerScore} | Computer: {ComputerScore}");
    }
    else if (ComputerScore == 3)
    {
        Console.WriteLine("YOU LOSE");
        Console.WriteLine($"Final Score:   Player: {PlayerScore} | Computer: {ComputerScore}");
    }
}

void Menu ()
{
    Console.WriteLine ("-----------------------------");
    Console.WriteLine ($"| Player: {PlayerScore}  | Computer: {ComputerScore}  |");
    Console.WriteLine ("-----------------------------");
    Console.WriteLine ("What would you like to throw?");
    Console.WriteLine ("1) Rock");
    Console.WriteLine ("2) Paper");
    Console.WriteLine ("3) Scissors");
}


void Selection (int input)
{
    if (input == 1)
    {
        Console.WriteLine ($"{Rock}");
    }
    else if (input == 2)
    {
        Console.WriteLine ($"{Paper}");
    }
    else if (input == 3)
    {
        Console.WriteLine ($"{Scissors}");
    }
}

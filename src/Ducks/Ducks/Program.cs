using ConsoleApp1;
using System.ComponentModel.Design;
using System.Diagnostics;

Duck duck = null;
DuckService duckService = new DuckService();
Play();

void Play()
{
    int playerChoice = 0;
    bool continiue = true;
    
    while (continiue)
    {
        Console.WriteLine("Choose action: 1 - Create Duck 2 - Show Duck 3 - Eat Duck 4 - Sleep Duck 5 - Competition Duck 6 - Swimming Duck 7 - exit");
        playerChoice = Convert.ToInt32(Console.ReadLine());
        switch (playerChoice)
        {
            case 1:
                CreateDuck();
                break;

            case 2:
                ShowDuck();
                break;

            case 3:
                EatDuck();
                break;

            case 4:
                SleepDuck();
                break;

            case 5:
                CompetitionDuck();
                break;
            
            case 6:
                SwimmingDuck();
                break;
            
            case 7:
                continiue = false;
                break;



        }
        
    }
}


void CreateDuck()
{
    Console.WriteLine("Choose name for new duck");
    string name = Console.ReadLine();

    duckService.CreateNewDuck(name);
}

Duck GetDuck()
{
    foreach (var duck in duckService.Ducks)
    {
        duck.ShowDuck();
    }

    Console.WriteLine("Enter duck's id: ");
    int id = Convert.ToInt32(Console.ReadLine());
    return duckService.GetDuckById(id);
}

void ShowDuck ()
{
    bool countDuck = OneOrAllDuck();
    if (countDuck = true)
    {
        duck.ShowDuck();
    }
    else
    {
        foreach (var duck in duckService.Ducks)
        {
            duck.ShowDuck();
        }
    }
    

}

bool OneOrAllDuck ()
{
    Console.WriteLine("Do you want choose one (1) or all ducks (2)?");
    int playerChoice = 0;
    int playerChoose = Convert.ToInt32(Console.ReadLine());
    if (playerChoice == 1)
    {
        return true;
    }
    else
    {
        return false;
    }
}

void EatDuck()
{
    bool countDuck = OneOrAllDuck();
    if (countDuck = true)
    {
        duck.Eat();
    }
    else
    {
        foreach (var duck in duckService.Ducks)
        {
            duck.Eat();
        }
    }


}

void SleepDuck()
{
    bool countDuck = OneOrAllDuck();
    if (countDuck = true)
    {
        duck.Sleep();
    }
    else
    {
        foreach (var duck in duckService.Ducks)
        {
            duck.Sleep();
        }
    }


}

void SwimmingDuck()
{
    bool countDuck = OneOrAllDuck();
    if (countDuck = true)
    {
        duck.Swimming();
    }
    else
    {
        foreach (var duck in duckService.Ducks)
        {
            duck.Swimming();
        }
    }


}

void CompetitionDuck()
{
    if (duckService.Ducks.Count > 1)
    {
        Console.WriteLine ("Winner Duck: " + duckService.GetCompetition()); 
    }
    else
    {
        Console.WriteLine("Sorry, not enough ducks");
    }
}
int choice;
Menu();

choice = Convert.ToInt32(Console.ReadLine());
ClearScreen();
while (choice != 9)
{
    if (choice == 1)
    {
        Console.WriteLine("This will display your member ID card");
        Menu();
        choice = Convert.ToInt32(Console.ReadLine());
        ClearScreen();
    }
    else if (choice == 2)
    {
        Console.WriteLine("This will display any upcoming appoin and prescription pickups");
        Menu();
        choice = Convert.ToInt32(Console.ReadLine());
        ClearScreen();
    }
    else if (choice == 3)
    {
        Console.WriteLine("This will prompt the user with a search bar");

        Menu();
        choice = Convert.ToInt32(Console.ReadLine());
        ClearScreen();
    }
    else if (choice == 4)
    {
        Console.WriteLine("This will display the users current coverage plan and other plans they could be eligible for");
        Menu();
        choice = Convert.ToInt32(Console.ReadLine());
        ClearScreen();
    }
    else if (choice == 5)
    {
        Console.WriteLine("Through Hello Blue you can do all of the features of the app, but through voice activated software");
        Menu();
        choice = Convert.ToInt32(Console.ReadLine());
        ClearScreen();
    }
    else if (choice == 6)
    {
        Console.WriteLine("This will prompt the user with a chatbox and some pre-generated generic questions.");
        Menu();
        choice = Convert.ToInt32(Console.ReadLine());
        ClearScreen();
    }
    else if (choice == 7)
    {
        Console.WriteLine("The user will be put on a call with an available medical professional");
        Menu();
        choice = Convert.ToInt32(Console.ReadLine());
        ClearScreen();
    }
    else if (choice == 8)
    {
        Console.WriteLine("Enter your zipcode");
        Console.ReadLine();
        Console.WriteLine("Clinc 1");
        Console.WriteLine("Would you like to schedule an appointment?");
        string choice2 = Console.ReadLine();
        ClearScreen();
        if(choice2 == "yes" || choice2 == "Yes" )
        {
            Console.WriteLine("Appointment scheduled");
        }
        else
        {
            Menu();
            choice = Convert.ToInt32(Console.ReadLine());
            ClearScreen();
        }
        Menu();
        choice = Convert.ToInt32(Console.ReadLine());
        ClearScreen();
    }
}

static void Menu()
{
    Console.WriteLine("1. Member ID");
    Console.WriteLine("2. Reminders/Alerts");
    Console.WriteLine("3. Search");
    Console.WriteLine("4. View coverage plan");
    Console.WriteLine("5. Hello Blue");
    Console.WriteLine("6. Ask a professional (SMS)");
    Console.WriteLine("7. Ask a professional (Phone call)");
    Console.WriteLine("8. Find a clinic and schedule an appointment");
}

static void ClearScreen()
{
    Console.Clear();
}
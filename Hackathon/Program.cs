int choice;
Menu();

choice = Convert.ToInt32(Console.ReadLine());
ClearScreen();
while (choice != 5)
{
    if (choice == 1)
    {
        Console.WriteLine("Welcome to the BlueCross blog");
        Console.WriteLine("----------------------------------------");
        Console.WriteLine("This section will include a live feed of the BlueCross blog so our consumers and employees can have easy access to \nBlueCross news.\n");

        Menu();
        choice = Convert.ToInt32(Console.ReadLine());
        ClearScreen();
    }
    else if (choice == 2)
    {
        Console.WriteLine("What kind of question would you like to ask?");
        Console.WriteLine("1. Generic question");
        Console.WriteLine("2. Generic question");
        Console.WriteLine("3. Contact a professional directly via sms");

        int choice2 = Convert.ToInt32(Console.ReadLine());
        ClearScreen();

        if (choice2 == 1 || choice2 == 2)
        {
            Console.WriteLine("Generic answer");
            Console.WriteLine("Is there anything else you'd like to ask?\n");

            Menu();
            choice = Convert.ToInt32(Console.ReadLine());
            ClearScreen();
        }
        else if (choice2 == 3)
        {
            Console.WriteLine("Opens a chatbox with a medical professional\n");

            Menu();
            choice = Convert.ToInt32(Console.ReadLine());
            ClearScreen();
        }

    }
    else if (choice == 3)
    {
        Console.WriteLine("Please enter your zipcode");
        string zipcode = Console.ReadLine();

        Console.WriteLine("Here are some clinics near you:");
        Console.WriteLine("Clinic 1");
        Console.WriteLine("Clinic 2\n");

        Menu();
        choice = Convert.ToInt32(Console.ReadLine());
        ClearScreen();
    }
    else if (choice == 4)
    {
        Console.WriteLine("Here is your current health coverage: coverage example");
        Console.WriteLine("Here are other insurance plans we have available: list of insurance plans\n");

        Menu();
        choice = Convert.ToInt32(Console.ReadLine());
        ClearScreen();
    }
}

static void Menu()
{
    Console.WriteLine("1. Access the BlueCross blog");
    Console.WriteLine("2. Ask a professional");
    Console.WriteLine("3. Find a clinic near you");
    Console.WriteLine("4. Check your coverage");
}

static void ClearScreen()
{
    Console.Clear();
}

            // Skapa ett slumpmässigt tal mellan 1 och 100 som användaren ska gissa
            Random random = new Random();
            int numberToGuess = random.Next(1, 101); // Slumpar ett tal mellan 1 och 100
            int userGuess = 0;

            Console.WriteLine("Välkommen till 'Gissa siffran'-spelet!");
            Console.WriteLine("Jag har valt ett tal mellan 1 och 100. Försök att gissa vilket det är.");

            // Loop som fortsätter tills användaren gissar rätt
            while (userGuess != numberToGuess)
            {
                Console.Write("Gissa ett tal: ");
                string input = Console.ReadLine();

                // Kontrollera att användaren skriver in ett giltigt tal
                if (int.TryParse(input, out userGuess))
                {
                    if (userGuess < numberToGuess)
                    {
                        Console.WriteLine("För lågt! Försök igen.");
                    }
                    else if (userGuess > numberToGuess)
                    {
                        Console.WriteLine("För högt! Försök igen.");
                    }
                    else
                    {
                        Console.WriteLine("Grattis! Du gissade rätt.");
                    }
                }
                else
                {
                    Console.WriteLine("Ogiltig inmatning. Vänligen skriv in ett heltal.");
                }
            }
            Console.ReadLine();
     
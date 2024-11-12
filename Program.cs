
            // 1. If-sats som skriver ut "Hello, World!" om 6 >= 3
            if (6 >= 3)
            {
                Console.WriteLine("Hello, World!");
            }

            // 2. Hämtar in ett användarnamn och skriver ut "Welcome!" om användarnamnet är "kalleanka"
            Console.Write("Enter username: ");
            string username = Console.ReadLine();
            if (username == "kalleanka")
            {
                Console.WriteLine("Welcome!");
            }

            // 3. Efterfrågar både användarnamn och lösenord
            Console.Write("Enter username: ");
            username = Console.ReadLine();
            Console.Write("Enter password: ");
            string password = Console.ReadLine();

            if (username == "kalleanka" && password == "12345")
            {
                Console.WriteLine("Welcome");
            }
            else
            {
                Console.WriteLine("Wrong username or password");
            }

            // 4. Loop som skriver ut "Hello, World" 32 gånger
            for (int i = 0; i < 32; i++)
            {
                Console.WriteLine("Hello, World");
            }

            // 5. While-loop som fortsätter tills användaren skriver in rätt lösenord
            string correctPassword = "12345";
            string input;
            do
            {
                Console.Write("Enter password: ");
                input = Console.ReadLine();
            } while (input != correctPassword);

            Console.WriteLine("Correct password entered!");

            // 6. Loop som körs 5 gånger och ber användaren skriva in ett tal
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Enter a number: ");
                int number = int.Parse(Console.ReadLine());
                if (number > 5)
                {
                    Console.WriteLine("högre än 5!");
                }
            }

            // 7. Loop som fortsätter så länge användaren skriver in en string som inte kan konverteras till en int
            string inputString;
            while (true)
            {
                Console.Write("Enter a number (or type something non-numeric to stop): ");
                inputString = Console.ReadLine();
                if (int.TryParse(inputString, out int result))
                {
                    Console.WriteLine($"You entered the number {result}");
                }
                else
                {
                    Console.WriteLine("Not a valid number. Exiting loop.");
                    break;
                }
            }
        
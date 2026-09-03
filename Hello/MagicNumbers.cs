namespace Hello
{
    internal class MagicNumbers
    {
        public static void Run()
        {
            int number = 42; // This is a magic number
            Console.WriteLine($"The answer to life, the universe, and everything is: {number}");

            // Bad practice: using numbers without explanation
            int age = 20; // This is another magic number
            if (age >= 18)
            {
                Console.WriteLine("Adult");
            }

            //Good practice: using named constants instead of magic numbers
            const int ADULT_AGE = 18;

            if (age >= ADULT_AGE)
            {
                Console.WriteLine("Adult");
            }

            //Another examples of magic numbers
            //Peple data
            const int VOTING_AGE = 18;
            const int RETIREMENT_AGE = 65;

            if (age >= VOTING_AGE)
            {
                Console.WriteLine("Can vote");
            }

            if (age >= RETIREMENT_AGE) { 
                Console.WriteLine("Can retire");
            }

            //Character stats
            const int MAX_HEALTH = 100;
            const int STARTING_GOLD = 50;

            int health = MAX_HEALTH;
            int gold = STARTING_GOLD;

            const int MIN_PASSWORD_LENGTH = 8;
            const string password = "secret";

            if (password.Length < MIN_PASSWORD_LENGTH)
            {
                Console.WriteLine("Password too short");
            }

            //Physics
            const double GRAVITY = 9.81;
            const double PI = 3.14159265359;
            const double mass = 20;

            double force = mass * GRAVITY;

            //Bad
            Thread.Sleep(5000);

            //Good
            const int SLEEP_DURATION_MS = 5000;
            Thread.Sleep(SLEEP_DURATION_MS);

            //Array size
            const int MAX_PLAYERS = 4;

            string[] players = new string[MAX_PLAYERS];

            //HTTP Status
            const int NOT_FOUND_STATUS = 404;
            int statusCode = NOT_FOUND_STATUS;
            if (statusCode == NOT_FOUND_STATUS)
            {
                Console.WriteLine("Not Found");
            }

            //Sometimes is not need it
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }
            int sum = 2 + 1;

            //"If another developer sees this number in six months, will they know why it's this value?"
            //If the answer is no, create a constant:
            const int MAX_USERS = 100;
            const int DEFAULT_PORT = 8080;
            const double TAX_RATE = 0.07;
        }
    }
}

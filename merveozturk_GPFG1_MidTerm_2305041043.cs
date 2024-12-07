using System;

class DGD203MidtermGame
{
    static void Main()
    {
        // Set the terminal background color to black and text color to white
        Console.BackgroundColor = ConsoleColor.Black;  // Background color
        Console.ForegroundColor = ConsoleColor.White;   // Text color
        Console.Clear();  // Apply the background color

        // Welcome message and ask for name
        Console.WriteLine("Welcome to the Adventure Game!");
        Console.Write("What's your name? ");
        string playerName = Console.ReadLine();
        Console.WriteLine("\nHello, " + playerName + "! Your adventure starts now!");

        // First question
        Console.WriteLine("Where would you like to start your journey?");
        Console.WriteLine("a) A mysterious forest");
        Console.WriteLine("b) A peaceful river");
        Console.Write("Choose a or b: ");
        string choice1 = Console.ReadLine();

        // Second question: Encountering a creature
        Console.WriteLine("You see a glowing creature in front of you. What will you do?");
        Console.WriteLine("a) Try to befriend it");
        Console.WriteLine("b) Stay away and watch from a distance");
        Console.Write("Choose a or b: ");
        string choice2 = Console.ReadLine();

        // Different outcomes based on the second choice
        if (choice2 == "a")
        {
            Console.WriteLine("The creature approaches cautiously, its shimmering aura casting a soft glow. It offers you a token—a small, glowing orb—and vanishes, leaving behind a sense of mystery and purpose.");
        }
        else
        {
            Console.WriteLine("The creature stares at you with glowing eyes, as if measuring your intentions. Without a sound, it fades into the shadows, leaving a faint shimmer in its wake.");
        }

        // Third question based on first choice
        if (choice1 == "a")
        {
            Console.WriteLine("In the forest, you see an ancient tree with strange symbols. Do you:");
            Console.WriteLine("a) Try to read the symbols");
            Console.WriteLine("b) Ignore it and follow the light trail");
            Console.Write("Choose a or b: ");
        }
        else
        {
            Console.WriteLine("By the river, you find a hidden cave behind a waterfall. Do you:");
            Console.WriteLine("a) Go into the cave");
            Console.WriteLine("b) Stay by the river and follow the footprints");
            Console.Write("Choose a or b: ");
        }
        string choice3 = Console.ReadLine();

        // Fourth question based on second choice
        Console.WriteLine("You come to a fork in the path. What do you do?");
        Console.WriteLine("a) Take the left path where you hear a soft sound");
        Console.WriteLine("b) Take the right path, which feels colder");
        Console.Write("Choose a or b: ");
        string choice4 = Console.ReadLine();

        // Fifth question based on third choice
        Console.WriteLine("You discover an abandoned house with a strange glow inside. Do you:");
        Console.WriteLine("a) Enter the house to investigate");
        Console.WriteLine("b) Avoid the house and continue your journey");
        Console.Write("Choose a or b: ");
        string choice5 = Console.ReadLine();

        // Sixth question based on fifth choice
        Console.WriteLine("Inside, you find a large, glowing crystal. What do you do?");
        Console.WriteLine("a) Touch the crystal");
        Console.WriteLine("b) Leave it alone and walk away");
        Console.Write("Choose a or b: ");
        string choice6 = Console.ReadLine();

        // Seventh question based on sixth choice
        Console.WriteLine("The crystal begins to glow brighter. What do you do?");
        Console.WriteLine("a) Stand still and observe");
        Console.WriteLine("b) Run away in fear");
        Console.Write("Choose a or b: ");
        string choice7 = Console.ReadLine();

        // Eighth question based on sixth choice
        Console.WriteLine("The glow fades, and you find a hidden passage. Do you:");
        Console.WriteLine("a) Enter the passage");
        Console.WriteLine("b) Exit the house and leave the crystal behind");
        Console.Write("Choose a or b: ");
        string choice8 = Console.ReadLine();

        // Ninth question based on eighth choice
        Console.WriteLine("You enter a new realm. What do you do?");
        Console.WriteLine("a) Explore the realm");
        Console.WriteLine("b) Try to find a way back home");
        Console.Write("Choose a or b: ");
        string choice9 = Console.ReadLine();

        // Tenth question based on ninth choice
        Console.WriteLine("You see a magnificent castle in the distance. Do you:");
        Console.WriteLine("a) Go towards the castle");
        Console.WriteLine("b) Avoid the castle and continue exploring the realm");
        Console.Write("Choose a or b: ");
        string choice10 = Console.ReadLine();

        // Ending summary based on the choices
        Console.WriteLine("\nYour adventure ends...");
        if (choice1 == "a" && choice4 == "a" && choice5 == "a" && choice6 == "a" && choice7 == "a" && choice8 == "a")
        {
            Console.WriteLine(playerName + ", as the crystal illuminated the hidden passage, it transported you to a magnificent parallel dimension filled with breathtaking landscapes and otherworldly creatures. With bravery and determination, you uncovered the ancient secrets of this realm, earning the respect of its inhabitants. Eventually, you were crowned as the guardian of the realm, your name etched into the annals of history as a beacon of courage and discovery.");
        }
        else if (choice1 == "b" && choice2 == "b" && choice3 == "b" && choice5 == "a" && choice6 == "b")
        {
            Console.WriteLine(playerName + ", your careful decisions and unwavering curiosity guided you through a world brimming with hidden mysteries. By staying observant and avoiding unnecessary risks, you amassed knowledge that transformed you into the land's most renowned scholar. People from all corners sought your wisdom, and your legacy was immortalized as the wisest mind of your generation.");
        }
        else if (choice3 == "a" && choice5 == "b" && choice6 == "a" && choice9 == "a")
        {
            Console.WriteLine(playerName + ", the moment you touched the crystal, a surge of power coursed through you. Emboldened by the newfound energy, you ventured into uncharted realms, overcoming trials that tested your limits. Ultimately, you claimed the magnificent castle and united the realm under your leadership. Your tale became a legend, inspiring countless adventurers to follow in your footsteps.");
        }
        else
        {
            Console.WriteLine(playerName + ", your journey was a tapestry of unexpected twists and turns. Though not all your choices led to glory, they created a unique adventure that shaped the world in ways you could never imagine. The echoes of your journey continue to inspire tales of wonder and courage, forever engrained in the hearts of those who hear them.");
        }

        // End with credits
        Console.WriteLine("\nGame created by: MERVE ÖZTÜRK");
        Console.WriteLine("\nThanks for playing! Come back soon.");

        // Reset console colors
        Console.ResetColor();
    }
}

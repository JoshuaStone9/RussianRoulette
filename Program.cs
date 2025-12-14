string[] russianroulette = {"1","2","3","4","5","6"};

Console.WriteLine("Welcome To Russian Roulette!");

foreach (string chamber in russianroulette){
    Console.WriteLine($"Chambers Active: {chamber}\n");
}

Console.WriteLine("Enter Your Number And Let Fate Decide If You LIVE or DIE!");

string number = Console.ReadLine() ?? "";

Console.WriteLine($"You Have Chosen {number}");

if (number == "1") {
    Console.WriteLine("You Have Been Shot!\n R.I.P\n");
}
else {
    Console.WriteLine("\nYou Live Another Day!");
}

        string[] result = RandomizeArray(new string[] { "1", "2", "3", "4", "5", "6" });
    

    static string[] RandomizeArray(string[] array)
    {
        int count = array.Length;
        Random rng = new Random();

        while (count > 1)
        {
            count--;
            int i = rng.Next(count + 1);
            (array[i], array[count]) = (array[count], array[i]);
        }

        return array;
         
    }

if (number == "2") {
    Console.WriteLine("\nBut Do Not Think You Are Getting Away Just Yet!, Press ENTER If You Dare!");
    Console.ReadLine();
     if ( result[0] == "2") {
        Console.WriteLine("You Have Died!");
     }
     else {
        Console.WriteLine("You Live!");
     }
}
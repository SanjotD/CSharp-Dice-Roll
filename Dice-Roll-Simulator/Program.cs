// Dice Roll Simulator
Console.Clear();
#nullable disable

Console.WriteLine("Dice Roll Simulator Menu");


//Roll Dice Function
 Random rnd = new Random();
    

bool loop = true;

while (loop) {

//Menu Options
    Console.WriteLine("\n1. Roll Dice Once");
    Console.WriteLine("2. Roll Dice 5 Times");
    Console.WriteLine("3. Roll Dice 'n' Times");
    Console.WriteLine("4. Roll Dice Until Snake Eyes");
    Console.WriteLine("5. Exit");
    Console.Write("Select an option (1-5): ");

//User Input Variable
string userInput = Console.ReadLine();

//Menu Functions

if (userInput == "1") {
    //Roll Die Once
    Console.Clear();

    //Roll Dice
    int randNum1 = rnd.Next(1, 6);
    int randNum2 = rnd.Next(1, 6);
    int sum = randNum1 + randNum2;
    Console.Write($"\n{randNum1}, {randNum2} (sum : {sum})\n");
} else if (userInput == "2") {
    //Roll Die 5 Times
    Console.Clear();

    //Roll Dice
    for (int n = 1; n <= 5; n++) {
        int randNum1 = rnd.Next(1, 6);
        int randNum2 = rnd.Next(1, 6);
        int sum = randNum1 + randNum2;
        Console.Write($"\n{randNum1}, {randNum2} (sum : {sum})\n");
}
}
  else if (userInput == "3") {
    //Roll Die 'n' Times
    Console.Clear();

    Console.Write("\nHow many rolls would you like? ");
    //User Input 'n' rolls
    int nRolls = Convert.ToInt32(Console.ReadLine());

    //Roll Dice
    for (int n = 1; n <= nRolls; n++) {
        int randNum1 = rnd.Next(1, 6);
        int randNum2 = rnd.Next(1, 6);
        int sum = randNum1 + randNum2;
        Console.Write($"\n{randNum1}, {randNum2} (sum : {sum})\n");
}
} else if (userInput == "4") {
    //Roll Dice until Snake Eyes
    Console.Clear();

    // Loop til Snake Eyes
    bool snakeLoop = true;
    
    int rollCount = 0;
    while(snakeLoop) {
        //Roll Dice
        int randNum1 = rnd.Next(1, 6);
        int randNum2 = rnd.Next(1, 6);
        int sum = randNum1 + randNum2;
        Console.Write($"\n{randNum1}, {randNum2} (sum : {sum})\n");
        //Count Rolls
        rollCount++;
        if (randNum1 == 1 && randNum2 == 1) { 
             Console.WriteLine($"\n Snake eyes!!! It took {rollCount} to get to snake eyes");
            break;
        }
    }
} else {
   break;
}
}

Random rnd = new Random();
int cpuRandom;
bool loopActive = true;// bool - true/false

while (loopActive)
{ 
    cpuRandom = rnd.Next(1,4);
    // Console.WriteLine($"cpu has generated {cpuRandom}");
    Console.WriteLine("Make a guess:   Enter a number 1-3");

    int usernumber = Int32.Parse(Console.ReadLine());
    if(usernumber == cpuRandom)
    {
        Console.WriteLine(" Congatualations, you won!");
        // loopActive = false;
        break;
            }
    else { Console.WriteLine("Oops Try again");
    }
}
Console.WriteLine("Have a nice day!");



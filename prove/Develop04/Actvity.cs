class Activity
{
 private int time= 0;
public void DisplayWelcomeMessage (string typeOfActvity)
{
    Console.WriteLine ($"Welcome to the {typeOfActvity} Actvity!");
} 

public void HowLongToRunProgram()
{
    Console.WriteLine ("How long in seconds, would you like for your session to take?");
    time  = int.Parse(Console.ReadLine());
}















}
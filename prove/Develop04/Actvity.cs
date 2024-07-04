class Activity
{
 private int _time= 0;
 private string typeOfActvity = "";
 private string _description ="";
 private DateTime _endTime;
 
public void DisplayWelcomeMessage (string typeOfActvity)
{
    Console.WriteLine ($"Welcome to the {typeOfActvity} Actvity!");
} 

public void GetDuration()
{
    Console.WriteLine ("How long in seconds, would you like for your session to take?");
    _time  = int.Parse(Console.ReadLine());
}















}
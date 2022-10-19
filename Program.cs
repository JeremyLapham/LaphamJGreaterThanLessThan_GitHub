//Jeremy Lapham
//10-17-22
//Greater Than Less Than
//This program will ask the user for two numbers and it will compare them
//Peer Review:


bool validNum;
int num = 0;
bool validNum2;
int num2 = 0;


bool playAgain = true;
while(playAgain)
{
Console.WriteLine("I can compare any number you want, now give me any number ");
string numOneA = Console.ReadLine();
validNum = Int32.TryParse(numOneA, out num);

Console.WriteLine("Now give me another number");
string numTwoA = Console.ReadLine();
validNum2 = Int32.TryParse(numTwoA, out num2);

if(validNum != true || validNum2 != true)
{
    Console.WriteLine("You didn't enter two vaild numbers try again");
}
else if(validNum == true && validNum2 == true)
{
    if( num == num2)
    {
        Console.WriteLine($"{num} is equal to {num2}");
    }
    else if( num > num2)
    {
        Console.WriteLine($"{num} is Greater Than {num2}");
    }
    else if(num < num2)
    {
        Console.WriteLine($"{num} is Less Than {num2}");
    }
}
Console.WriteLine("Do you want to play again? Type Yes to continue type end to stop playing.");
string playAgain2 = Console.ReadLine().ToLower();
if(playAgain2 == "end")
{
    playAgain = false;
}
}
Console.WriteLine("Thank you for playing!");
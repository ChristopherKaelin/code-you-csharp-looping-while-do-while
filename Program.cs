Console.WriteLine("\n====================");
Console.WriteLine("==   Project 1  ==");

string? readResult;
int numericValue = 0;
bool validNumber = false;

while (!validNumber) {
    Console.WriteLine("Enter a number:");
    readResult = Console.ReadLine();

    validNumber = int.TryParse(readResult, out numericValue);
    if (!validNumber) {
        Console.WriteLine($"{readResult} is NOT a valid number.  Try Again");
    } else if (numericValue <5 || numericValue >10)
        {Console.WriteLine($"{numericValue} is a valid number, but not between 5 and 10.  Try Again.");
        validNumber = false;
    }
}
Console.WriteLine($"Your input value ({numericValue}) has been accepted.");


Console.WriteLine("\n====================");
Console.WriteLine("==   Project 2  ==");

string readRole = "";
string compareRole = "";
bool validRole = false;

while (!validRole) {
    Console.WriteLine("Enter your role name (Administrator, Manager, or User");
    readRole = Console.ReadLine();
    compareRole = readRole.Trim().ToLower();
    if (compareRole == "administrator" || compareRole ==  "manager" || compareRole == "user") {
        validRole =  true;
    } else {
        Console.WriteLine($"The role name that you entered, '{readRole}' is not valid. ");
    }
}
Console.WriteLine($"Your input value ({readRole}) has been accepted.");


Console.WriteLine("\n====================");
Console.WriteLine("==   Project 3  ==");
string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };
string sentence = "";
int periodLocation = 0;

foreach(string stringText in myStrings){
    sentence = stringText;
    periodLocation = sentence.IndexOf(".");
    while (periodLocation > 0){
        Console.WriteLine($"{sentence.Substring(0,periodLocation)}");
        sentence = sentence.Remove(0,periodLocation+1).TrimStart();
        periodLocation = sentence.IndexOf(".");
    }
    Console.WriteLine($"{sentence}");
}
Console.WriteLine("\n====================\n");

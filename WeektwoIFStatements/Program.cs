Console.WriteLine("Enter your last name:");
string lastName = Console.ReadLine();

Console.WriteLine("Enter your gender (M/F/N):");
char userGender = Char.Parse(Console.ReadLine());
string greeting;
if (userGender == 'F')
    greeting = "Mrs.";
else if (userGender == 'M')
    greeting = "Mr.";
else if (userGender == 'm')
    greeting = "Mr.";
else if (userGender == 'f')
    greeting = "Mrs.";
else if (userGender == 'n')
    greeting = "";
else
    greeting = "";

Console.WriteLine("Enter your year of birth:");
int userYOB = Int32.Parse(Console.ReadLine());
int CurrentYear = DateTime.Now.Year;
//Console.WriteLine($"Current year: {CurrentYear}");
int userAge = CurrentYear - userYOB;

//int userAge = Int32.Parse(Console.ReadLine());
if (userAge >= 13)
    Console.WriteLine("'Gates open'");
else
    Console.WriteLine("Sorry, but You are too young to be allowed on this webpage :(");

if (userAge >= 13)
    Console.WriteLine($"Hello, {greeting} {lastName}! You are {userAge} years old and We're pleased to have You!");
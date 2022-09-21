Console.WriteLine("Enter Your number: ");           // Input user name
string userName = Console.ReadLine();               // Initial user name

if(userName.ToLower()=="Michael") {                 // Condition user name = Michael
    Console.WriteLine("Hello, Bro!");               // Print Bro
} else {                                            // Condition user name != Michael
    Console.WriteLine($"Hello, {userName}!");       // Brint default template
}
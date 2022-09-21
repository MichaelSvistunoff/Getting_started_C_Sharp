Console.WriteLine("Input first number: ");      // Input number one
int numOne = int.Parse(Console.ReadLine());     // Initial number two

Console.WriteLine("Input second number: ");     // Input number two
int numTwo = int.Parse(Console.ReadLine());     // Initial number two

if(numOne>numTwo) {                             // Condition if first > second
    int result = numOne/numTwo;
    Console.WriteLine($"The result of division is {result}");
} else {                                        // Condition if first < second
    Console.WriteLine("You have inputed incorrect firs number: it needs to be more than second number!");
}
int numOne = new Random().Next(1, 10);                  // Initial first random number
int numTwo = new Random().Next(1, 10);                  // Initial second random number

int summary = numOne*numTwo;                            // Math operation

Console.WriteLine($"{numOne} * {numTwo} = {summary}");  // Print summary
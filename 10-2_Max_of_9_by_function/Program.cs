int Max(int arg1, int arg2, int arg3) {
    int result = arg1;
    if (arg2> result) result = arg2;
    if (arg3> result) result = arg3;
    return result;
}

int numOne = 15;
int numTwo = 21;
int numThree = 39;

int numFour = 12;
int numFive = 189;
int numSix = 33;

int numSeven = 13;
int numEight = 23;
int numNine = 33;
// Classical method
// int max1 = Max(numOne, numTwo, numThree);
// int max2 = Max(numFour, numFive, numSix);
// int max3 = Max(numSeven, numEight, numNine);
// int maximun = Max(max1, max2, max3);
// Analogy
int maximun = Max(
                    Max(numOne, numTwo, numThree),
                    Max(numFour, numFive, numSix),
                    Max(numSeven, numEight, numNine)
                );

Console.WriteLine($"Maximun number is {maximun}");
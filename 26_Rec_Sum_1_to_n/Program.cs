/*
ВЫвести сумму чисел от 1 до N
*/
Console.Write("Enter N: ");
int N = int.Parse(Console.ReadLine()!);

Console.WriteLine(GetSumStd(N));
Console.WriteLine(GetSumRec(N));

int GetSumStd(int number) {
    int result = 0;

    for (int i=0; i<=number; i++) {
        result += i;
    }
    return result;
}

int GetSumRec (int number) {
    if (number == 0) {
        return 0;
    }
    return number + GetSumRec(number-1);
}
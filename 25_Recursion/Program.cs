/*
Собрать строку с числами от A до B, где a<=b
*/

Console.Write("Enter method: ");
int isChoosen = int.Parse(Console.ReadLine()!);

// Обычный метод через цикл For
if (isChoosen == 1) {
    Console.Write("Enter A: ");
    int A = int.Parse(Console.ReadLine()!);
    Console.Write("Enter B: ");
    int B = int.Parse(Console.ReadLine()!);

    Console.WriteLine(ShowAToB(A, B));

    string ShowAToB(int a, int b) {
        string result = string.Empty;

        for (int i=a; i<=b; i++) {
            result += $"{i} ";
        }
        return result;
    }
}

else {
    Console.Write("Enter A: ");
    int A = int.Parse(Console.ReadLine()!);
    Console.Write("Enter B: ");
    int B = int.Parse(Console.ReadLine()!);

    Console.WriteLine(ShowAToB(A, B));

    string ShowAToB(int a, int b) {
        if (a <= b) {
            return (a + " " + ShowAToB(a+1, b));
        } else {
            return string.Empty;
        }
    }
}
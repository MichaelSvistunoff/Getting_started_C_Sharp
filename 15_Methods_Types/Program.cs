﻿// Функции в программировании, тип 1
void Method1() {
    Console.WriteLine("Author: Michael Svistunov");
}

Method1();

//Функции в программировании, тип 2
void Method2(string msg) {
    Console.WriteLine(msg);
}
Method2(msg: "Some interesting message for You in the first function!");

void Method21(string msg, int count) {
    int i = 0;
    while (i<count) {
        Console.WriteLine(msg);
        i++;
    }
}
Method21(msg: "Some interesting message for You in the second function!", count: 4);

// Функции в программировании, тип 3
int Method3() {
    return DateTime.Now.Year;
}
int year = Method3();
Console.WriteLine(year);

// Функции в программировании, тип 4
string Method4(int count, string text) {
    int i = 0;
    string result = String.Empty;

    while (i<count) {
        result = result + text;
        i++;
    }
    return result;
}
string res = Method4(10, "qwer ");
Console.WriteLine(res);
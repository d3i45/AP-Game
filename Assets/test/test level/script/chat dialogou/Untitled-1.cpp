#include <iostream>
using namespace std;

int main() {
    double num1, num2, result;
    char operation;

    cout << "Simple Calculator in C++" << endl;
    cout << "------------------------" << endl;

    cout << "Enter the first number: ";
    cin >> num1;

    cout << "Enter the operation (+, -, *, /): ";
    cin >> operation;

    cout << "Enter the second number: ";
    cin >> num2;

    switch (operation) {
        case '+':
            result = num1 + num2;
            cout << "Result: " << num1 << " + " << num2 << " = " << result << endl;
            break;
        case '-':
            result = num1 - num2;
            cout << "Result: " << num1 << " - " << num2 << " = " << result << endl;
            break;
        case '*':
            result = num1 * num2;
            cout << "Result: " << num1 << " * " << num2 << " = " << result << endl;
            break;
        case '/':
            if (num2 != 0) {
                result = num1 / num2;
                cout << "Result: " << num1 << " / " << num2 << " = " << result << endl;
            } else {
                cout << "Cannot divide by zero!" << endl;
            }
            break;
        default:
            cout << "Invalid operation." << endl;
            break;
    }

    return 0;
}
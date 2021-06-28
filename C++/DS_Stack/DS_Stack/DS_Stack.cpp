// DS_Stack.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>
using namespace std;

#define MAX_STACK_SIZE 5

class Stack
{
private:
    int stack[MAX_STACK_SIZE];
    int top;

public:
    Stack()
    {
        top = -1;
        for (int i = 0; i < MAX_STACK_SIZE; i++)
        {
            stack[i] = 0;
        }        
    }

    bool push(int value)
    {
        if (top == MAX_STACK_SIZE-1)
        {
            cout << "Stack Overflow!" << endl;
            return false;
        }

        cout << "Push: " << value << endl;
        stack[++top] = value;
    }

    int pop()
    {
        if (top == -1)
        {
            cout << "Stack Empty!" << endl;
            return -1;
        }

        cout << "Pop:" << stack[top] << endl;
        return stack[top--];
    }
};

int main()
{
    std::cout << "Hello World!\n";

    Stack s1;
    s1.push(10);
    s1.push(20);
    s1.push(30);
    s1.push(40);
    s1.push(50);
    s1.push(100);

    s1.pop();
    s1.pop();
    s1.pop();
    s1.pop();
    s1.pop();
    s1.pop();

    return 1;
}
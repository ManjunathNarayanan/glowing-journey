// DS_Queue.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>

#define MAX_QUEUE_SIZE 2

using namespace std;

class queue
{
private:
    int q[MAX_QUEUE_SIZE];
    int front;
    int rear;

public:
    queue()
    {
        front = 0;
        rear = 0;

        for (int i = 0; i < MAX_QUEUE_SIZE; i++)
        {
            q[i] = 0;
        }
    }

    bool enqueue(int value)
    {
        if (rear >= MAX_QUEUE_SIZE)
        {
            cout << "Queue is full!" << endl;
            return false;
        }

        cout << "Enqueue: " << value << endl;
        q[rear++] = value;
        return true;
    }

    bool dequeue()
    {
        if (front == rear)
        {
            cout << "Queue is empty!" << endl;
            return false;
        }
        else
        {
            cout << "Dequeue: " << q[front] << endl;
            for (int i = 0; i < rear - 1; i++)
            {
                q[i] = q[i + 1];
            }
            rear--;
        }        
        return true;
    }

    void queuedisplay()
    {
        int i;
        if (front == rear)
        {
            cout << "queue is empty" << endl;
            return;
        }

        cout << "queue contents are:" << endl;
        for (i = front; i < rear; i++)
        {
            cout << q[i] << " ";
        }
        cout << endl;
        return;
    }
};

int main()
{
    queue q1;
    q1.enqueue(10);
    q1.enqueue(20);
    q1.enqueue(30);
    q1.enqueue(40);
    q1.enqueue(50);

    q1.queuedisplay();

    q1.dequeue();
    q1.dequeue();
    q1.dequeue();
    q1.dequeue();
    q1.dequeue();
    q1.dequeue();
    q1.dequeue();

}

// Run program: Ctrl + F5 or Debug > Start Without Debugging menu
// Debug program: F5 or Debug > Start Debugging menu

// Tips for Getting Started: 
//   1. Use the Solution Explorer window to add/manage files
//   2. Use the Team Explorer window to connect to source control
//   3. Use the Output window to see build output and other messages
//   4. Use the Error List window to view errors
//   5. Go to Project > Add New Item to create new code files, or Project > Add Existing Item to add existing code files to the project
//   6. In the future, to open this project again, go to File > Open > Project and select the .sln file

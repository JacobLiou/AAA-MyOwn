#include <iostream>
#include <cstdlib>
#define default_value 10
using namespace std;

template <class T>
class Stack
{

public:
    Stack(int x = default_value)
    {
        size = x;
        values = new T[size];
        index = -1;
    };

    ~Stack()
    {
        delete[] values;
    };

    bool Push(T x);
    T Pop();
    bool IsEmpty();
    bool IsFull();

private:
    int size;
    T *values;
    int index;
};

template <class T>
bool Stack<T>::IsFull()
{
    if ((index + 1) == size)
        return 1;
    else
        return 0;
}

template <class T>
bool Stack<T>::Push(T x)
{
    bool b = 0;
    if (!Stack<T>::IsFull())
    {
        index += 1;
        values[index] = x;
        b = 1;
    }
    return b;
}

template <class T>
bool Stack<T>::IsEmpty()
{
    if (index == -1) //is empty
        return 1;
    else
        return 0; //is not empty
}

template <class T>
T Stack<T>::Pop()
{
    T val = -1;
    if (!Stack<T>::IsEmpty())
    {
        val = values[index];
        index -= 1;
    }
    else
    {
        cerr << "Stack is Empty : ";
    }
    return val;
}

int main()
{
    Stack<double> stack1;
    Stack<int> stack2(5);
    int y = 1;
    double x = 1.1;
    int i, j;
    cout << "\n pushed values into stack1: ";

    for (i = 1; i <= 11; i++) //start enter 11 elements into stack
    {
        if (stack1.Push(i * x))
            cout << endl
                 << i * x;
        else
            cout << "\n Stack1 is full: ";
    }

    cout << "\n\n popd values from stack1 : \n";
    for (j = 1; j <= 11; j++)
        cout << stack1.Pop() << endl;

    cout << "\n pushd values into stack2: ";

    for (i = 1; i <= 6; i++) //start enter 6 elements into stack
    {
        if (stack2.Push(i * y))
            cout << endl
                 << i * y;
        else
            cout << "\n Stack2 is full: ";
    }

    cout << "\n\n popd values from stack2: \n";
    for (j = 1; j <= 6; j++)
        cout << stack2.Pop() << endl;
    cout << endl
         << endl;
    return 0;
}

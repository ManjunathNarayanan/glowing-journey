// DS_Trees.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>
using namespace std;

class bsTree
{
    bsTree* left;
    bsTree* right;
    int data;

public:
    bsTree(int data)
    {
        this->data = data;
        this->left = NULL;
        this->right = NULL;
    }

    void insert(int value)
    {
        if (value <= data)
        {
            if (left == NULL)
                left = new bsTree(value);
            else
                left->insert(value);
        }
        else
        {
            if (right == NULL)
                right = new bsTree(value);
            else
                right->insert(value);
        }
    }

    bool containsValue(int value)
    {
        if (value == data)
            return true;
        else if (value < data)
        {
            if (left == NULL)
                return false;
            else
                return left->containsValue(value);
        }
        else
        {
            if (right == NULL)
                return false;
            else
                return right->containsValue(value);
        }
    }

    void printInOrder()
    {
        if (left != NULL)
            left->printInOrder();
        cout << data << endl;
        if (right != NULL)
            right->printInOrder();
    }

    void printPreOrder()
    {
        cout << data << endl;
        if(left != NULL)
            left->printPreOrder();
        if(right != NULL)
            right->printPreOrder();
    }

    void printPostOrder()
    {
        if (left != NULL)
            left->printPostOrder();
        if (right != NULL)
            right->printPostOrder();
        cout << data << endl;
    }
};

int main()
{
    std::cout << "TREES!!!\n";

    bsTree tree1(10);
    tree1.insert(20);
    tree1.insert(5);
    tree1.insert(8);
    tree1.insert(40);
    tree1.insert(1);

    int valueToFind = 8;
    if(tree1.containsValue(valueToFind))
        cout << "Tree contains value " << valueToFind << endl;
    else
        cout << "Tree does not contain the value " << valueToFind << endl;
    
    cout << "InOrder:" << endl;
    tree1.printInOrder();

    cout << "PreOrder:" << endl;
    tree1.printPreOrder();

    cout << "PostOder:" << endl;
    tree1.printPostOrder();
}
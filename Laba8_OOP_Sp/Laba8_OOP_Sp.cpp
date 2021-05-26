#include <iostream>
#include "Header.h"
using namespace std;
int main()
{
    cout << "Vozniak Sofiia is-01" <<endl;
    LinkedList1 linkedList;
    linkedList.Add(0.232f);
    linkedList.Add(4.1234f);
    linkedList.Add(23.0f);
    linkedList.Add(12.211221f);
    cout << "Current list" << endl;
    linkedList.PrintList();
    cout << "Count of nums, that are more than 10,5 : " << linkedList.FindNumOfElsThatMore(10.5f) << endl;
    cout << "~ Extracting all nums, that are less than 2,6 ~" << endl;
    cout << "Current list" << endl;
    linkedList.Remove(2.6f);
    linkedList.PrintList();
}


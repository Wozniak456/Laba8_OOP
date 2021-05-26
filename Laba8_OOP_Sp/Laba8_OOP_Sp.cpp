#include <iostream>
#include "Header.h"
using namespace std;
int main()
{
    cout << "Vozniak Sofiia is-01";
    LinkedList1 linkedList;
    linkedList.Add(0.232F);
    linkedList.Add(234.1234F);
    linkedList.Add(23.0F);
    linkedList.Add(12.211221F);
    linkedList.PrintList();
    cout << "Count of nums, that are more than 10.5:" << linkedList.FindNumOfElsThatMore(10.5F) << endl;
    cout << "Nums that are less than 2.6: " << endl;
    linkedList.Remove(2.6F);
    linkedList.PrintList();
}


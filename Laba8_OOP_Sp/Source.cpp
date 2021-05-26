#include "Header.h"
#include <stdlib.h>  
#include <iostream>
using namespace std;
Element::Element(float data)
{
	Data = data;
}
LinkedList1::LinkedList1() 
{
	head = NULL;
}
void LinkedList1::Add(float data)
{
	Element* el = new Element(data);
	if (head == NULL)
		head = el;
	else
		tail->next = el;
	tail = el;
	count++;
}
void LinkedList1::Remove(float data)
{
	Element *curr = head;
	Element* previous = NULL;
	while (curr != NULL)
	{
		if (curr->Data == FindElsThatLess(data))
		{
			if (previous != NULL)
			{
				previous->next = curr->next;
				if (curr->next == NULL)
					tail = previous;
			}
			else
			{
				head = head->next;
				if (head == NULL)
					tail = NULL;
			}
			count--;
		}
		previous = curr;
		curr = curr->next;
	}
}
float LinkedList1::FindElsThatLess(float data)
{
	Element* curr = head;
	while (curr != NULL)
	{
		if (curr->Data < data)
			return curr->Data;
		curr = curr->next;
	}
	return 0;
}
int LinkedList1::FindNumOfElsThatMore(float data)
{
	int count = 0;
	Element* curr = head;
	while (curr != NULL)
	{
		if (curr->Data > data)
			count++;
		curr = curr->next;
	}
	return count;
}
void LinkedList1::PrintList()
{
	Element* el = head;
	while (el != NULL)
	{
		cout << el-> Data << endl;
		el = el->next;
	}
	cout << endl;
}
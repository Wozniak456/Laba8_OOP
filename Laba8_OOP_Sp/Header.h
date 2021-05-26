#pragma once
class Element
{
public:
	float Data;
	Element *next;
	Element(float data);
};
class LinkedList1
{
public:
	Element* head;
	Element* tail;
	int count;
	void Add(float data);
	void Remove(float data);
	int FindNumOfElsThatMore(float data);
	float FindElsThatLess(float data);
	void PrintList();
};
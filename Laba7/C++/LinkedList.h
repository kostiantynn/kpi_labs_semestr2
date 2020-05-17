#pragma once
#include "Node.h"
#include <iostream>
using namespace std;
class LinkedList
{
public:
	Node* head;
	int FindNumberOfElementsGreaterThanMedian();
	void DeleteEvenElements();
	void PrintList();
private:
	double MedianValue();
};


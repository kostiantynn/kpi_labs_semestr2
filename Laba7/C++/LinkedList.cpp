#include "LinkedList.h"

double LinkedList::MedianValue() {
	double sum = 0.0;
	int count = 0;
	Node* temp = head;
	while (temp != NULL) {
		sum += temp->Data;
		count++;
		temp = temp->Link;
	}
	return sum / count;
}
void LinkedList::DeleteEvenElements() {
	Node* next = head->Link;
	Node* after = head->Link->Link;
	head = next;
	while (next != NULL && after != NULL) {
		next->Link = after->Link;
		after = NULL;
		next = next->Link;
		if (next != NULL) {
			after = next->Link;
		}
	}
}
void LinkedList::PrintList() {
	Node* temp = head;
	while (temp != NULL) {
		cout << temp->Data << "->";
		temp = temp->Link;
	}
	cout << "null" << endl;
}

int LinkedList::FindNumberOfElementsGreaterThanMedian() {
	int count = 0;
	double median = MedianValue();
	Node* temp = head;
	while (temp != NULL) {
		if (temp->Data > median) {
			count++;
		}
		temp = temp->Link;
	}
	return count;
}

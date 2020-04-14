#include "BaseString.h"
#include <iostream>


BaseString::BaseString(string str[]) {
	this->StrValue = str;
}


int BaseString::GetLength(int index) {
	if (index >= StrValue->length()) {
		throw out_of_range("Index out of range.");
	}
	else {
		return this->StrValue[index].length();
	}
	
}
#include "MyString.h"
#include <iostream>

using namespace std;

vector<char> strToCharArr(string str) {
	vector<char> result;
	for (int i = 0; i < str.length(); i++) {
		result.push_back(str[i]);
	}
	return result;
}


MyString::MyString(string value) {
	this->Value = strToCharArr(value);
}

vector<char> MyString::getValue() {
	return this->Value;
}

int MyString::getLength() {
	return this->Value.size();
}

void MyString::displayValue() {
	for (int i = 0; i < this->getLength(); i++) {
		std::cout << this->getValue()[i];
	}
}
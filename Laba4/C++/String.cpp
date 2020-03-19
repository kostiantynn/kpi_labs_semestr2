#include "String.h"
#include <iostream>

int String::GetStringLength() {
	return strlen(this->StrValue);
}

void String::DisplayValue() {
	/*for (int i = 0; i < this->GetStringLength(); i++)
	{
		if (isdigit((int)this->StrValue[i])) {
			cout << this->StrValue[i];
		}
	}cout << endl;*/
	cout << this->StrValue << endl;
}

String::String() {
	this->StrValue = new char[0];
}

String::String(char* InputArr) {
	this->StrValue = InputArr;
}

String::String(const String &str) {
	this->StrValue = str.StrValue;
}

String String::operator+(String& str) {
	String retString;
	int counter = 0;
	int retStringSize = this->GetStringLength() + str.GetStringLength();
	retString.StrValue = new char[retStringSize];
	for (int i = 0; i < this->GetStringLength(); i++)
	{
		retString.StrValue[counter] = this->StrValue[i];
		counter++;
	}
	for (int i = 0; i < str.GetStringLength(); i++)
	{
		retString.StrValue[counter] = str.StrValue[i];
		counter++;
	}
	return retString;
}

String String::operator-(char chr) {
	String retStr;
	int retStringSize = this->GetStringLength() - 1;
	retStr.StrValue = new char[retStringSize];
	int counter = 0;
	for (int i = 0; i < this->GetStringLength(); i++)
	{
		if (this->StrValue[i] == chr) { continue; }
		retStr.StrValue[counter] = this->StrValue[i];
		counter++;
	}
	return retStr;
}
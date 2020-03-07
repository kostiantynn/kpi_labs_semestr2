#include <vector>
#include "MyString.h"
#include "Text.h"
#include <iostream>

using namespace std;

vector<MyString> Text::getText() {
	return this->text;
}

Text::Text(vector<MyString> text) {
	this->text = text;
}

void Text::displayText() {
	for (int i = 0; i < this->text.size(); i++) {
		for (int j = 0; j < this->text[i].getLength(); j++) {
			cout << this->text[i].getValue()[j];
		}
		cout << endl;
	}
}

void Text::addStringToText(MyString str) {
	this->text.push_back(str);
}

void Text::deleteStringByIndex(int index) {
	vector<MyString> newText;
	for (int i = 0; i < this->text.size(); i++) {
		if (i == index) { continue; }
		newText.push_back(this->text[i]);
	}this->text = newText;
}

MyString Text::getLongestString() {
	MyString maxValue = MyString("");
	for (int i = 0; i < this->text.size(); i++) {
		if (this->text[i].getLength() > maxValue.getValue().size()) {
			maxValue = this->text[i];
		}
	}
	return maxValue;
}

int Text::getTextLength() {
	int length = 0;
	for (int i = 0; i < this->text.size(); i++) {
		length += this->text[i].getLength();
	}
	return length;
}

float Text::getPercentOfDigits() {
	float counter = 0;
	for (int i = 0; i < this->text.size(); i++) {
		for (int j = 0; j < this->text[i].getLength(); j++) {
			if (isdigit(this->text[i].getValue()[j])) { counter++; }
		}
	}
	return counter / this->getTextLength() * 100;
	
}

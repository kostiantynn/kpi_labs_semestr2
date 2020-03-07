#ifndef C___TEXT_H
#define C___TEXT_H

#include <vector>
#include "MyString.h"

class Text {
private:
	std::vector<MyString> text;
public:
	explicit Text(std::vector<MyString>);
	std::vector<MyString> getText();
	void displayText();
	void addStringToText(MyString str);
	void deleteStringByIndex(int index);
	MyString getLongestString();
	int getTextLength();
	float getPercentOfDigits();
};

#endif
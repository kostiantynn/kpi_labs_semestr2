#include <iostream>
#include "MyString.h"
#include "Text.h"
#include <vector>
#include <string>

using namespace std;

vector<char> strToCharArr(string str);

int main() {

	MyString test1 = MyString("73798 18237 981 1987");
	MyString test2 = MyString("My name is Kostya and ...");
	MyString test3 = MyString("I am the freshman student from KPI uni.");
	MyString test4 = MyString("Just for testing this thing out.");

	Text myText = Text({ test1, test2, test3 });
	//Add string to text
	//myText.addStringToText(test4);

	//Delete String by index
	//myText.deleteStringByIndex(0);

	//Getting longest string
	//auto longestString = myText.getLongestString();
	//longestString.displayValue();

	//Getting text length
	//cout << myText.getTextLength() << endl;

	//Getting percentage of digits in text
	//cout << myText.getPercentOfDigits() << "%" << endl;

	myText.displayText();
}

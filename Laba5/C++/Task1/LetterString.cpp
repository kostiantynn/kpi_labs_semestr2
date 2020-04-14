#include "LetterString.h"


LetterString::LetterString(string str[]): BaseString(str) {
	this->StrValue = str;
}


string LetterString::GetValue(int index) {
	try {
		return StrValue[index];
	}
	catch (const out_of_range& oor) {
		cerr << "Index out of range" << oor.what() << '\n';
	}
}


void LetterString::Sort() {
	for (int i = 0; i < this->StrValue->length() - 1; i++) {
		if (StrValue[i].length() > StrValue[i + 1].length()) {
			string temp = StrValue[i + 1];
			StrValue[i + 1] = StrValue[i];
			StrValue[i] = temp;
		}
	}
}
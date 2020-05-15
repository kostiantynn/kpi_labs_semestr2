#include <iostream>

using namespace std;

int GetNumberOfDigitsInString(string str);

int main() {
	int (*GetNumberOfDigitsInStringPointer)(string);
	GetNumberOfDigitsInStringPointer = GetNumberOfDigitsInString;
	cout << GetNumberOfDigitsInStringPointer("XAE-12") << endl;
	return 0;
}

int GetNumberOfDigitsInString(string str) {
	int k = 0;
	for (int i = 0; i < str.length(); i++) {
		if (isdigit(str[i])) {
			k++;
		}
	}
	return k;
}
#include <iostream>
#include "LetterString.h"
#include "BaseString.h"


int main() {
	auto str = LetterString(new string[3]{ "Hello", "My", "friend" });
	
	str.Sort();
	for (int i = 0; i < 3; i++) {
		cout << str.GetValue(i) << endl;
	}
	return 0;
}
#include <iostream>
using namespace std;

bool EqualityFunction(int number1, int number2);
string ConvertToBinary(int number);
void Increment(int &number);

int main()
{
	int a;
	int b;
	int c;
	cout << "Enter numbers to compare" << endl;
	cout << "Enter a: ";
	cin >> a;
	cout << "Enter b: ";
	cin >> b;
	bool res = EqualityFunction(a, b);
	res ? printf("Numbers are equal.") : printf("Numbers are not equal.");
	cout << endl << "Enter number to increment it: ";
	cin >> c;
	Increment(c);
	cout << endl << "Incremented number: " << c;
}

bool EqualityFunction(int number1, int number2) {
	if (!(number1 ^ number2)) {
		return true;
	}
	else {
		return false;
	}
}

void Increment(int &number) {
	string binary = ConvertToBinary(number);
	int index = binary.rfind('0');
	int for_index = binary.length();
	for (int i = 0; i < for_index - index; i = -~i) {
		number ^= (1 << i);
	}
}


string ConvertToBinary(int number) {
	if (number < 0) {
		number += 256;
	}
	string result = "";
	while (number > 0){
		result = string(1, (char)(number % 2 + 48)) + result;
		number /= 2;
	}
	return result;
}

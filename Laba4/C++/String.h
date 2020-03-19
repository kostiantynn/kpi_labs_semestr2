#pragma once

#include <string>
using namespace std;

class String
{
private:
	char* StrValue;
public:
	int GetStringLength();
	void DisplayValue();
	String();
	String(char*);
	String(const String&);
	String operator +(String&);
	String operator -(char);

};


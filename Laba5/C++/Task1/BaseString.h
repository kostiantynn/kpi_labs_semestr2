#pragma once

#include <string>

using namespace std;

class BaseString {
protected:
	string* StrValue;
public:
	BaseString(string[]);
	int GetLength(int);
};
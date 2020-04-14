#pragma once
#include "BaseString.h"
#include <iostream>
class LetterString :
	public BaseString
{
public:
	LetterString(string[]);
	string GetValue(int);
	void Sort();
};


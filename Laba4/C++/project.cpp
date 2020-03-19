#include "String.h"
#include <iostream>

int main()
{
	
	char* data = (char*)"12345";
	auto c1 = String();
	auto c2 = String(data);
	c2.DisplayValue();
	auto c3 = String(c2);
	c3.DisplayValue();
	c2 = c2 - '5';
	c2.DisplayValue();
	c1 = c3 + c2;
	c1.DisplayValue();
}

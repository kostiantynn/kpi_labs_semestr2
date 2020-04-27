#pragma once
#include <string>
#include <iostream>

using namespace std;

class arithmeticExpression
{
private:
	double a, c, d;
public:
	arithmeticExpression(double, double, double);
	double calculateExpression();
};


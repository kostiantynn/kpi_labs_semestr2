#pragma once
using namespace std;
class Figure
{
protected:
	int* data;
public:
	Figure(int*);
	virtual double CalculateLength() { return 0; };
	virtual double CalculateArea() { return 0; };
};


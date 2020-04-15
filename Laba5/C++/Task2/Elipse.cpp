#include "Elipse.h"


Elipse::Elipse(int a, int b) : Figure(new int[2] {a,b}) {
	this->data = new int[2] {a, b};
}


double Elipse::CalculateLength() {
	return (data[0] + data[1]) * M_PI;
}

double Elipse::CalculateArea() {
	return (double)(data[0] * data[1] * M_PI);
}
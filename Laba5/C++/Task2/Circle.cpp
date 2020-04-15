#include "Circle.h"


Circle::Circle(int r) : Figure(&r) {
	this->data = &r;
}


double Circle::CalculateLength() {
	return 2 * M_PI * data[0];
}


double Circle::CalculateArea() {
	return M_PI * pow(data[0], 2);
}
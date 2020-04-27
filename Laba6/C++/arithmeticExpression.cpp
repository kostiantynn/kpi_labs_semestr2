#include "arithmeticExpression.h"


arithmeticExpression::arithmeticExpression(double a, double c, double d) {
	this->a = a;
	this->c = c;
	this->d = d;
}

double arithmeticExpression::calculateExpression() {
	
	if (d == 0) {
		throw "Divide by zero exception. d = 0;";
	}if (c + a == 1) {
		throw "Divide by zero exception. Denominator = 0;";
	}if (d < 0) {
		throw "You cannot take sqrt from negative value; d < 0;";
	}

	double solution = (2 * c - d * sqrt(42 / d)) / (c + a - 1);
	return solution;
}
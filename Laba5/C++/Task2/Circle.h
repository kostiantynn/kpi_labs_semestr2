#pragma once
#include "Figure.h"
#define _USE_MATH_DEFINES
#include <math.h>
class Circle :
	protected Figure
{
public:
	Circle(int r);
	double CalculateLength();
	double CalculateArea();
};


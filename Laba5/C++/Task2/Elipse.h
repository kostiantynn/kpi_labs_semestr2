#pragma once
#include "Figure.h"
#define _USE_MATH_DEFINES
#include <math.h>
class Elipse :
	protected Figure
{
public:
	Elipse(int a, int b);
	double CalculateLength();
	double CalculateArea();
};


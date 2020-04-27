#pragma once
#include <string>
#include <fstream>

using namespace std;

class Log
{
private:
	char* exception;
public:
	void LogAnException(const char*, string);
};


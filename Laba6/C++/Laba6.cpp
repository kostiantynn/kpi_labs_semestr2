#include "arithmeticExpression.h"
#include "Log.h"
#include <Windows.h>


int main(int argc, char* argv[]) {


	string cur_dir(argv[0]);
	int pos = cur_dir.find_last_of("C++");
	string filePath = cur_dir.substr(0, pos + 1) + "\\log.txt";
	auto log = Log();

	auto expression = arithmeticExpression(0.5, 1.5, -1);
	try {
		cout << expression.calculateExpression();
	}
	catch (const char* e) {
		log.LogAnException(e, filePath);
	}
	return 0;
	
}
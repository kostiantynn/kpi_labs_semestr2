#include "Log.h"

void Log::LogAnException(const char* exception, string filePath) {
    ofstream file;
    file.open(filePath, ios_base::app);
    file << exception;
}
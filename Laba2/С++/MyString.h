#ifndef LINE_H
#define LINE_H

#include <vector>
#include <string>

class MyString {
private:
    std::vector<char> Value;
public:
    explicit MyString(std::string);
    int getLength();
    std::vector<char> getValue();
    void displayValue();
};

#endif 
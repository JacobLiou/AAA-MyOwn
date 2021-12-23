// ConsoleApplication1.cpp : 此文件包含 "main" 函数。程序执行将在此处开始并结束。
//

#include <string>
#include <iostream>

void truth_table_entry(bool const x, bool const y)
{
    const std::string s[] = { "false", "true", "and", " " };
    const std::string x_and_y = s[x] + s[2] + s[y];
    const std::string r = s[x and y] + s[3];

    if (x + y == 0)
        std::cout << "┌──────────────────┬─────────┐\n";
    if (x + y <= 2)
        std::cout << "│ " << x_and_y << " │ " << r << " │\n";
    if (x + y == 2)
        std::cout << "└──────────────────┴─────────┘\n";
}

int main()
{
    truth_table_entry(false, false);
    truth_table_entry(false, true);
    truth_table_entry(true, false);
    truth_table_entry(true, true);
}
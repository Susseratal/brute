#include <iostream>
#include <fstream>
#include <chrono>
#include <thread>

void brute()
{
    std::cout << "hello world\n";
}

int main(int argc, char *argv[]) // fool, these are memory address pointers
{
    if (argc != 3)
    {
        std::cout << "Usage: " << argv[0] << " <-m/-f> <message/file>\n";
        return 0;
    }

    else
    {
        std::string flag = (argv[1]);
        if (flag == "-m")
        {
            std::cout << "message\n";
        }
        else if (flag == "-f")
        {
            std::cout << "file\n";
        }
        else
        {
            std::cout << "The flag was not recognised, much like the confederate flag\n";
        }
        return 0;
    }
}

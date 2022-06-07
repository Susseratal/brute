#include <stdio.h>
#include <stdlib.h>
#include <cstring>
#include <iostream>
#include <fstream>
#include <chrono>
#include <thread>

void brute(std::string message)
{
    srand (time(NULL));
    int targetLen = message.length();
    char targetArray[targetLen + 1]; // hah a ha allocate memory 
    strcpy(targetArray, message.c_str());
    std::string stringArray[targetLen];
    int i = 0;
    while (i < targetLen)
    {
        int currentGuess = rand() % 95 + 32; // range + minimum (because obviously that's what I'd do)
        char currentChar = static_cast<char>(currentGuess);
        std::cout << currentChar << std::flush;
        if (currentChar == targetArray[i])
        {
            std::cout << " ";
            i++;
        }
        std::cout << "\b";
        std::this_thread::sleep_for(std::chrono::milliseconds(5)); // sleep for 5 ms
    }
    std::cout << "\n";
}

int main(int argc, char *argv[]) 
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
            std::string text = (argv[2]);
            brute(text);
        }
        else if (flag == "-f")
        {
            std::string fileName = (argv[2]);
            std::string fileString;

            std::ifstream f(fileName);
            getline(f, fileString);
            f.close();

            brute(fileString);
        }
        else
        {
            std::cout << "The flag was not recognised, much like the confederate flag\n";
        }
        return 0;
    }
}

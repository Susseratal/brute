# What?
This is a silly bit of fun to practice programming in different languages, and it's more interesting than writing normal hello world programs  
All compiled languages are decompiled - in order to run C# version you have to compile it using  
        
        dotnet build

and then execute the build that's spat out into the build folder. (I used dotnet 6, if you don't have that available, change the .csproj file and see what happens because I don't know)

For the C++ version, just run 

        make

and it should compile.

Usage on compiled binaries:  

        ./brute <-m/-f> <"message"/file.txt>

or
        
        python brute.py <-m/-f> <"message"/file.txt>

This was inspired by [someone who wrote this in ruby](https://github.com/kickinespresso/brute_hello)  
Languages I have done myself:  

        - [x] Python
        - [x] C#
        - [x] C++
        - [ ] Java - what a dumb language

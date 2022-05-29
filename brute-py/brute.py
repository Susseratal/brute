import random
import time
import sys

def brute(message):
    targetArray = list(message) # listify the string "hello world"
    stringArray = [""] * len(targetArray) # construct an array of empty strings the length of the target string
    i = 0 # empty variable
    while i < len(targetArray): # while i is less than the length of the target string
        stringArray[i] = chr(random.randint(32, 126)) # Choose a random number and select the unicode character for it 
        if stringArray[i] == targetArray[i]: # If it's equal to the corresponding character in the target string
            i += 1 # increment i
        print("".join(stringArray), end="", flush=True) # not 100% on what this line does
        print(200*chr(8), end="")
        time.sleep(0.05) # have a quick breather
    print("\n")


def main():
    flag = str(sys.argv[1])
    if flag == "-m":
        text = str(sys.argv[2])
        brute(text)
    elif flag == "-f":
        f = open(str(sys.argv[2]), "r")
        fileText = f.read()
        fileText = fileText.strip()
        brute(fileText)
    else:
        print("Error: unrecognised flag: " + str(sys.argv[1]))

main()

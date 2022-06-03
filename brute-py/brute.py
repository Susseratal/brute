import random
import time
import sys

def brute(message):
    targetArray = list(message) 
    stringArray = [""] * len(targetArray) 
    i = 0 
    while i < len(targetArray): 
        stringArray[i] = chr(random.randint(32, 126)) 
        if stringArray[i] == targetArray[i]: 
            i += 1 
        print("".join(stringArray), end="", flush=True) 
        print(200*chr(8), end="")
        time.sleep(0.05) 
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
        fileText = fileText.replace("\n", "")
        brute(fileText)
    else:
        print("Error: unrecognised flag: " + str(sys.argv[1]))

main()

import random
import time
import sys

# it would be cool to make it read command line args - sys.argv just printed the directory, which was perplexing
targetArray = list("Hello, I'm Iain and I'm very clever") # listify the string "hello world"
stringArray = [""] * len(targetArray) # construct an array of empty strings the length of the target string
i = 0 # empty variable
while i < len(targetArray): # while i is less than the length of the target string
    stringArray[i] = chr(random.randint(32, 126)) # Choose a random number and select the unicode character for it 
    if stringArray[i] == targetArray[i]: # If it's equal to the corresponding character in the target string
        i += 1 # increment i
    print("".join(stringArray)) # not 100% on what this line does
    time.sleep(0.05) # have a quick breather

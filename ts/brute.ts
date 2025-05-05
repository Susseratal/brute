const fs = require('fs');

async function sleep(ms: number): Promise<void>{
    return new Promise((resolve) => setTimeout(resolve, ms));
}

function help() {
    console.log("Two arguments required, -m or -f followed by a message or file name")
}

function consoleWrite(character: string) {
    process.stdout.write(character)
}

async function brute(message: string) {
    let targetArray: String[] = Array.from(message);

    let stringArray: String[] = [];
    let i = 0;

    while(i < targetArray.length) {
        let currentChar = String.fromCharCode(Math.floor(Math.random() * (126 - 32) + 32));
        consoleWrite(currentChar); 
        if (currentChar == targetArray[i]) {
            consoleWrite(" ");
            ++i;
        }
        consoleWrite("\b");
        await sleep(5);
    }
    consoleWrite("\n");
}

if (process.argv.length < 3) {
    help();
} else {
    let arg = process.argv[2];
    let msg = process.argv[3];

    if (arg == "-m") {
        brute(msg);
    } else if (arg == "-f") {
        fs.readFile(msg, 'utf8', (err: string, data: string) => {
            if(err) {
                console.error('Error reading file: ' + err);
                return;
            }
            let trimmedData = data.trimEnd();
            brute(trimmedData);
        })
    } else {
        help();
    }
}

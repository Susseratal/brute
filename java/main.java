import java.io.File; 
import java.io.FileNotFoundException;
import java.util.Scanner;

class main {
    static void brute(String message) {
        char[] targetArray = message.toCharArray();
        String newStr = "";
        int i = 0;
        while(i < targetArray.length) {
            var currentChar = (char)((int)Math.floor(Math.random()*(126-32+1)+32)); // guess this is random number gen
            System.out.print(currentChar);
            if(currentChar == targetArray[i]) {
                System.out.print(" ");
                i++;
            }
            newStr += currentChar;
            System.out.print("\b");
            try {
                Thread.sleep(5);}
            catch(InterruptedException e) {
            }
        }

        System.out.print("\n");
    }
    
    public static void main(String[] args) {
        if(args.length != 2) {
            System.out.println("Usage: <-m/-f> <message/file>");
        }
        else {
            String flag = args[0];
            if(flag.equals("-m")) { // apparently one can't use == because that checks for reference equality rather than value equality - wtf??
                String text = args[1];
                brute(text);
            }

            else if(flag.equals("-f")) {
                String data = "";
                try {
                    String fn = args[1];
                    File f = new File(fn);
                    Scanner reader = new Scanner(f);
                    while (reader.hasNextLine()) {
                        data += reader.nextLine();
                    }
                    reader.close();
                } catch (FileNotFoundException e ) {
                    System.out.println("Read error occurred");
                    e.printStackTrace();
                }
                brute(data);
            }

            else {
                System.out.println("The flag was not recognised, much like the confederate flag");
            }
        }
    }
}

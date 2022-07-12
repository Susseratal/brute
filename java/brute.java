class Brute
{
    public static void brute(String message)
    {
        char[] targetArray = message.toCharArray();
        String[] stringArray = new String[targetArray.length];
        int i = 0;
        while(i < targetArray.length)
        {
            var currentChar = (char)((int)Math.floor(Math.random()*(126-32+1)+32));
            System.out.print(currentChar);
            if(currentChar == targetArray[i])
            {
                System.out.print(" ");
                i++;
            }
            System.out.print(String.join("", stringArray)); // something here is what's causing the "null" bug  
            System.out.print("\b");
            try {
                Thread.sleep(5);}
            catch(InterruptedException e) {
            }
        }
        System.out.print("\n");
    }
    
    public static void main(String[] args)
    {
        if(args.length != 2)
        {
            System.out.println("Usage: <-m/-f> <message/file>");
        }
        else
        {
            String flag = args[0];
            if(flag.equals("-m")) // apparently one can't use == because that checks for reference equality rather than value equality - wtf??
            {
                String text = args[1];
                brute(text);
            }

            else if(flag.equals("-f"))
            {
                String file = args[1];
                System.out.println("File = " + file);
            }

            else
            {
                System.out.println("The flag was not recognised, much like the confederate flag");
            }
        }
    }
}

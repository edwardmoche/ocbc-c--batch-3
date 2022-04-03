using System;

class luas{
    public static void Main(String[] args){
        string getStatus;
        bool y, status;
        do
        {
            Console.Write("status nikah (y/n): ");
            getStatus = Console.ReadLine();
            y = getStatus == "y" || getStatus == "n";
        } while (!y);
        
        bool status = false;

            if (getStatus == "y")
            {
                status = true;
            }

        Console.WriteLine($"Status nikah: {getStatus}");
    }
}
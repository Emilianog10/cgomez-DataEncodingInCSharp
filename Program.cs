using System;

namespace cgomez_DataEncodingInCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = args[0];
            Console.WriteLine($"Loading '{filePath}'.");
            
            string message;
            message = System.IO.File.ReadAllText(filePath);
            Console.WriteLine($"The encrypted message is: {message}");

            Cipher cipher;
            cipher = new Cipher(3);

            
            string decrypted;
            decrypted = cipher.Decrypt(message);
            Console.WriteLine($"The decrypted message is: '{decrypted}'");



            
            
        }
    }
}

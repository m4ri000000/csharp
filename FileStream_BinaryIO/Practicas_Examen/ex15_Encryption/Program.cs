//file encryption/decryption
using System;
using System.IO;

class Program
{
    static void Main()
    {
        string inputFile = "sample.txt";
        string encryptedFile = "encrypted.txt";
        string decryptedFile = "decrypted.txt";
        int shift = 3; 

        try
        {
            //encryption
            using (StreamReader reader = new StreamReader(inputFile))
            using (StreamWriter writer = new StreamWriter(encryptedFile))
            {
                string content = reader.ReadToEnd();
                string encryptedContent = Encrypt(content, shift);
                writer.Write(encryptedContent);
            }

            //decryption
            using (StreamReader reader = new StreamReader(encryptedFile))
            using (StreamWriter writer = new StreamWriter(decryptedFile))
            {
                string encryptedContent = reader.ReadToEnd();
                string decryptedContent = Decrypt(encryptedContent, shift);
                writer.Write(decryptedContent);
            }

            Console.WriteLine("File encrypted and decrypted successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }
    }

    static string Encrypt(string content, int shift)
    {
        char[] buffer = content.ToCharArray();
        for (int i = 0; i < buffer.Length; i++)
        {
            char letter = buffer[i];
            if (char.IsLetter(letter))
            {
                char d = char.IsUpper(letter) ? 'A' : 'a';
                buffer[i] = (char)((((letter + shift) - d) % 26) + d);
            }
        }
        return new string(buffer);
    }

    static string Decrypt(string content, int shift)
    {
        return Encrypt(content, 26 - shift); 
    }
}
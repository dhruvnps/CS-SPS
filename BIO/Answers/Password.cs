using System;

class Password
{
    public static void CheckPassword()
    {
        Console.Write("Password: ");
        string password = Console.ReadLine().ToUpper();
        Console.WriteLine(Password.IsValid(password) ? "Accepted" : "Rejected");
    }

    private static bool IsValid(string password)
    {
        for (int len = 1; len <= password.Length - 1; len++)
        {
            for (int pos = 0; pos < password.Length - (len * 2 - 1); pos++)
            {
                if (password.Substring(pos, len) == password.Substring(pos + len, len))
                {
                    return false;
                }
            }
        }
        return true;
    }
}
public class ConvertToBinaryDemo
{
    static void Main()
    {
        ConvertToBinary();
    }

    static void ConvertToBinary()
    {
        Console.WriteLine("Enter the number in decimal: ");
        int decimalInput = Convert.ToInt32(Console.ReadLine());

        List<int> remainders = new List<int>();

        while (decimalInput != 0)
        {
            remainders.Add(decimalInput % 2);
            decimalInput /= 2;
        }

        Console.WriteLine("Your decimal number in binary is: ");
        for (int i = remainders.Count - 1; i >= 0; i--)
        {
            Console.Write(remainders[i]);
        }
    }
}
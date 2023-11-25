using System;
using System.IO;

class SpiroGraph
{
    static void Main(string[] args)
    {
        decimal R = 36;
        decimal r = 9;
        decimal a = 30;
        decimal x = 0;
        decimal y = 0;
        string path = @"D:\Database Systems\HW3\count.txt";
        StreamWriter f = new StreamWriter(path);
        decimal t = 0.0m;
        while (t < 12 * (decimal)Math.PI)
        {
            x = 34.02049440553145m + ((R + r) * (decimal)Math.Cos((double)(r / R) * (double)t) - a * (decimal)Math.Cos((double)(1 + r / R) * (double)t)) / 16000;
            y = -118.28562511467511m + ((R + r) * (decimal)Math.Sin((double)(r / R) * (double)t) - a * (decimal)Math.Sin((double)(1 + r / R) * (double)t)) / 16000;
            f.WriteLine(y + "," + x + ",200");
            t += 0.01m;
        }
        f.Close();
    }
}

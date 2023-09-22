using System.ComponentModel.DataAnnotations;
using System.Net;

namespace BT01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap so luong phan tu: ");
            int n = Convert.ToInt16(Console.ReadLine());
            int[] A = new int[n];
            int Max = 0;
            int dem = 0;
            for (int i = 0; i < n; i++)
            {
                Console.Write("Nhap phan tu thu: "+(i+1), ": ");
                A[i] = Convert.ToInt16(Console.ReadLine());
                if (A[i] > Max)
                {
                    Max = A[i];
                    dem = i + 1;
                }
            }
            Console.WriteLine("Cac phan tu trong mang: ");
            for (int i = 0;i < n; i++)
            {
                Console.WriteLine("phan tu "+(i+1) + "la: " + A[i]);
            }
            Console.WriteLine("So lon nhat: "+ Max);
            Console.WriteLine("Vi tri: " + dem);
            Console.ReadKey();
        }
    }
}
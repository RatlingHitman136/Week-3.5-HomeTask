using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace Proc
{
    class Program
    {
        static void Main(string[] args)
        {

        }


        //All functions from tasks 16 to 36
        int Sign(int X)
        {
            if (X == 0) return 0;
            if (X < 0) return -1;
            return 1;
        }
        int RootsCount(int a, int b, int c)
        {
            int d = b * b - 4 * a * c;
            return (Sign(d) + 1);
        }
        double CircleS(double r)
        {
            return Math.PI * r * r;
        }
        double RingS(double r_1, double r_2)
        {
            return Math.Abs(CircleS(r_1) - CircleS(r_2));
        }
        double TriangleP(double a, double h)
        {
            double b = Math.Sqrt((a / 2) * (a / 2) + h * h);
            return 2 * a + b;
        }
        int SumRange(int a, int b)
        {
            return ((b + a) * (b - a + 1)) / 2;
        }
        double Calc(double a, double b, int Op)
        {
            switch (Op)
            {
                case 1:
                    return a - b;
                case 2:
                    return a * b;
                case 3:
                    return a / b;
                default:
                    return a + b;
            }
        }
        int Quarter(double x, double y)
        {
            if (x > 0 && y > 0)
                return 1;
            else if (x < 0 && y > 0)
                return 2;
            else if (x < 0 && y < 0)
                return 3;
            else
                return 4;
        }
        bool Even(int K)
        {
            return K % 2 == 0;
        }
        bool IsSquare(int K)
        {
            int SqrtK = (int)Math.Sqrt(K);
            return SqrtK * SqrtK == K;
        }
        bool isPowerN(int K, int N)
        {
            int K_1 = (int)Math.Pow(Math.E, (Math.Log(K) / N));
            return K == Math.Pow(K_1, N);
        }
        bool isPrime(int N)
        {
            for (int i = 1; i <= Math.Sqrt(N); i++)
            {
                if (N % i == 0) return false;
            }
            return true;
        }
        int DigitCount(int K)
        {
            int count = 0;
            while (K > 0)
            {
                count++;
                K /= 10;
            }
            return count;
        }
        bool IsPalindrom(int K)
        {
            string num = K.ToString();
            for (int i = 0; i < (num.Length / 2); i++)
                if (num[i] != num[num.Length - i - 1])
                    return false;

            return true;
        }
        double DegToRad(double D)
        {
            return (D / 360.0) * 2 * Math.PI;
        }
        double RadToDeg(double R)
        {
            return (R / (2 * Math.PI)) * 360.0;
        }
        int Fact(int N)
        {
            if (N == 1) return N;
            return N * Fact(N - 1);
        }
        int Fact2(int N)
        {
            if (N == 1 || N == 2) return N;
            return N * Fact2(N - 2);
        }
        int Fib(int N)
        {
            double mid = (1.0 + Math.Sqrt(5)) / 2.0;
            double Fib_N = (Math.Pow(mid, N) - Math.Pow(-mid, -N)) / (2 * mid - 1);
            return (int)Fib_N;
        }

        //tasks from 36
        double Power1(double A, double B)
        {
            return Math.Exp(B * Math.Log(A));
        }
        double Power2(double A, int N)
        {
            if (N == 1) return A;
            else if (N == -1) return 1 / A;
            else if (N > 1) return A * Power2(A, N - 1);
            else if (N < -1) return (1 / A) * Power2(A, N + 1);
            else return 1;
        }
        double Power3(double A, double B)
        {
            if ((double)((int)B) == B)
                return Power2(A, (int)Math.Round(B));
            else
                return Power1(A, B);
        }
        double Exp1(double x, double eps)
        {
            double exp_val = 0;
            double val = 1;
            int num = 0;
            do
            {
                exp_val += val;
                val *= x;
                val /= ++num;
            }
            while (Math.Abs(val) >= eps);
            return exp_val;
        }
        double Sin1(double x, double eps)
        {
            double sin_val = 0;
            double val = x;
            int num = 1;
            do
            {
                sin_val += val;
                val *= -(x * x);
                val /= (++num * ++num);
            }
            while (Math.Abs(val) >= eps);
            return sin_val;
        }
        double Cos1(double x, double eps)
        {
            double cos_val = 0;
            double val = 1;
            int num = 0;
            do
            {
                cos_val += val;
                val *= -(x * x);
                val /= (++num * ++num);
            }
            while (Math.Abs(val) >= eps);
            return cos_val;
        }
        double Ln1(double x, double eps)
        {
            double ln_val = 0;
            double val = x;
            int num = 1;
            do
            {
                ln_val += val;
                val *= -x;
                val *= num;
                val /= ++num;
            }
            while (Math.Abs(val) >= eps);
            return ln_val;
        }
        double Arctg1(double x, double eps)
        {
            double arctg_val = 0;
            double val = x;
            int num = 1;
            do
            {
                arctg_val += val;
                val *= -(x * x);
                val *= num;
                num += 2;
                val /= num;
            }
            while (Math.Abs(val) >= eps);
            return arctg_val;
        }
        double Power4(double x, double a, double eps)
        {
            double power4_val = 0;
            double val = 1;
            int num = 0;
            do
            {
                power4_val += val;
                val *= x;
                val *= (a - num);
                val /= ++num;
            }
            while (Math.Abs(val) >= eps);
            return power4_val;
        }
        int NOD2(int A, int B)
        {
            if (A == 1 || B == 1) return 1;
            if (A == 0 || B == 0) return B + A;
            return NOD2(Math.Min(A, B), Math.Max(A, B) - Math.Min(A, B));
        }
        void Frac1(int a, int b, out int p, out int q)
        {
            int nod = NOD2(a, b);
            p = a / nod;
            q = b / nod;
        }
        int NOK2(int A, int B)
        {
            return (A * B) / NOD2(A, B);
        }
        int NOD3(int A, int B, int C)
        {
            return NOD2(NOD2(A, B), C);
        }
        void TimeToHMS(int T, out int H, out int M, out int S)
        {
            H = T / 3600;
            T %= 3600;

            M = T / 60;
            T %= 60;

            S = T;
        }
        void IncTime(ref int H, ref int M, ref int S, int T)
        {
            int ToAddH, ToAddM, ToAddS;
            TimeToHMS(T, out ToAddH, out ToAddM, out ToAddS);
            S += ToAddS;
            ToAddM += S / 60;
            S %= 60;

            M += ToAddM;
            ToAddH += M / 60;
            M %= 60;

            H += ToAddH;
        }
        bool IsLeapYear(int Y)
        {
            bool isLeap = Y % 4 == 0;
            if (Y % 100 == 0)
                isLeap = false;
            if (Y % 400 == 0)
                isLeap = true;
            return isLeap;
        }
        int MonthDays(int M, int Y)
        {
            if (M == 1 || M == 4 || M == 6 || M == 9 || M == 11)
                return 30;
            if (M == 2)
                return IsLeapYear(Y) ? 29 : 28;
            return 31;
        }
        void PrevDate(ref int D, ref int M, ref int Y)
        {
            if (D == 1)
            {
                if (M == 1)
                {
                    Y -= 1;
                    M = 12;
                }
                else
                    M--;
                D = MonthDays(M, Y);
            }
            else
                D -= 1;
        }
        void NextDate(ref int D, ref int M, ref int Y)
        {
            if (D == MonthDays(M, Y))
            {
                if (M == 12)
                {
                    Y += 1;
                    M = 1;
                }
                else
                    M++;
                D = 1;
            }
            else
            {
                D += 1;
            }
        }
        
        double Leng(double X_a,double Y_a, double X_b, double Y_b)
        {
            return Math.Sqrt((X_a - X_b) * (X_a - X_b) + (Y_a - Y_b) * (Y_a - Y_b));
        }
        double Perim(double X_a, double Y_a, double X_b, double Y_b, double X_c, double Y_c)
        {
            double AB, BC, AC;
            TriangleCalc(X_a, Y_a, X_b, Y_b, X_c, Y_c, out AB, out AC, out BC);
            return (AB + BC + AC);
        }
        void TriangleCalc(double X_a, double Y_a, double X_b, double Y_b, double X_c, double Y_c, out double AB, out double AC, out double BC)
        {
            AB = Leng(X_a, Y_a, X_b, Y_b);
            AC = Leng(X_a, Y_a, X_c, Y_c);
            BC = Leng(X_b, Y_b, X_c, Y_c);
        }//доп функция
        double Area(double X_a, double Y_a, double X_b, double Y_b, double X_c, double Y_c)
        {
            double AB, BC, AC, p;
            TriangleCalc(X_a, Y_a, X_b, Y_b, X_c, Y_c, out AB, out AC, out BC);
            p = Perim(X_a, Y_a, X_b, Y_b, X_c, Y_c) / 2.0;
            return Math.Sqrt(p * (p - BC) * (p - AC) * (p - AB));
        }
        double Dist(double X_p, double Y_p, double X_a, double Y_a, double X_b, double Y_b)
        {
            return (2 * Area(X_p, Y_p, X_a, Y_a, X_b, Y_b)) / Leng(X_a, Y_a, X_b, Y_b);
        }
        void Heights(double X_a, double Y_a, double X_b, double Y_b, double X_c, double Y_c, out double h_a, out double h_b, out double h_c)
        {
            h_a = Dist(X_a, Y_a, X_b, Y_b, X_c, Y_c);
            h_b = Dist(X_b, Y_b, X_a, Y_a, X_c, Y_c);
            h_c = Dist(X_c, Y_c, X_b, Y_b, X_a, Y_a);
        }
        //это впринципе все
    }
}

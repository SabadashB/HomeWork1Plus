using System;

namespace Homwork1Lib
{
    public class Homework1
    {
    public static double Task1(int A, int B)
    {
        if((B - A)==0)
        {
            throw new ArgumentException("(B - A) cannot be zero!");
        }

        return (5 * A + B * B) / (B - A);
    }

    public static void Task2(ref string A, ref string B)
    {
        string temp = A;
        A = B;
        B = temp;
    }

    public static (int division, int remainder) Task3(int A, int B)
    {
        if(B == 0)
        {
            throw new ArgumentException("Сannot using zero vlues!");
        }

        return (A / B, A % B);
    }

    public static double Task4(double A, double B, double C)
    {
        if (A == 0)
        {
            throw new ArgumentException("A cannot be zero!");
        }

        return (C - B) / A;
    }

    public static (double A, double B) Task5(double X1, double Y1, double X2, double Y2)
    {
        if(X1 - X2 == 0)
        {
            throw new ArgumentException("X1 and X2 cannot be zero!");
        }

        double A = (Y1 - Y2) / (X1 - X2);
        double B = Y2 - A * X2;

        return (A, B);
    }
         public static int Task6(int A, int B)
        {
            int result = 0;
            if (A > B)
            {
                result = A + B;
            }
            else if (A == B)
            {
                result = A * B;
            }
            else if (A < B)
            {
                result = A - B;
            }
            return result;

        }

        public static int Task7(int X, int Y)
        {
            int result = 0;
            if (X > 0 && Y > 0)
            {
                result = 1;
            }
            else if (X < 0 && Y > 0)
            {
                result = 2;
            }
            else if (X < 0 && Y < 0)
            {
                result = 3;
            }
            else if (X > 0 && Y < 0)
            {
                result = 4;
            }
            else if (X == 0 && Y == 0)
            {
                result = 0;
            }
            return result;

        }

        public static void Task8(ref int A, ref int B, ref int C)
        {
            if (A > B)
            {
                int temp = A;
                A = B;
                B = temp;
            }
            if (A > C)
            {
                int temp = A;
                A = C;
                C = temp;
            }
            if (B > C)
            {
                int temp = B;
                B = C;
                C = temp;
            }
        }
        public static (double? X1, double? X2) Task9(double A, double B, double C)
        {
            double D = B * B - 4 * A * C;
            if (D == 0)
            {
                double x = -B / (2 * A);

                return (x, x);
            }
            else if (D > 0)
            {
                double x1 = (-B + Math.Sqrt(D)) / (2 * A);
                double x2 = (-B - Math.Sqrt(D)) / (2 * A);

                return (x1, x2);
            }
            else
            {
                return (null, null);
            }
        }

        public static string SubTask10(string A)
        {
            int _A = Convert.ToInt32(A);
            string result= " ";
            switch (_A)
            {
                case 1:
                    {
                        result = "one";
                        break;
                    }
                case 2:
                    {
                        result = "two";
                        break;
                    }
                case 3:
                    {
                        result = "three";
                        break;
                    }
                case 4:
                    {
                        result = "four";
                        break;
                    }
                case 5:
                    {
                        result = "five";
                        break;
                    }
                case 6:
                    {
                        result = "six";
                        break;
                    }
                case 7:
                    {
                        result = "seven";
                        break;
                    }
                case 8:
                    {
                        result = "eight";
                        break;
                    }
                case 9:
                    {
                        result = "nine";
                        break;
                    }
            }
            return result;
        }

        public static string Task10(string A)
        {
            int _A = Convert.ToInt32(A);
            string result = null;
            switch (_A)
            {
                case 10:
                    {
                        result = "Ten";
                        break;
                    }
                case 11:
                    {
                        result = "Eleven";
                        break;
                    }
                case 12:
                    {
                        result = "Twelve";
                        break;
                    }
                case 13:
                    {
                        result = "Thirteen";
                        break;
                    }
                case 14:
                    {
                        result = "Fourteen";
                        break;
                    }
                case 15:
                    {
                        result = "Fiveteen";
                        break;
                    }
                case 16:
                    {
                        result = "Sixteen";
                        break;
                    }
                case 17:
                    {
                        result = "Seventeen";
                        break;
                    }
                case 18:
                    {
                        result = "Eighteen";
                        break;
                    }
                case 19:
                    {
                        result = "Nineteen";
                        break;
                    }
                case 20:
                    {
                        result = "Twenty";
                        break;
                    }
                case 30:
                    {
                        result = "Thirty";
                        break;
                    }
                case 40:
                    {
                        result = "Fourty";
                        break;
                    }
                case 50:
                    {
                        result = "Fifty";
                        break;
                    }
                case 60:
                    {
                        result = "Sixty";
                        break;
                    }
                case 70:
                    {
                        result = "Seventy";
                        break;
                    }
                case 80:
                    {
                        result = "Eighty";
                        break;
                    }
                case 90:
                    {
                        result = "Ninety";
                        break;
                    }
                default:
                    {
                        if (_A > 0)
                        {
                            result = Task10(A.Substring(0, 1) + "0") + " " + SubTask10(A.Substring(1));
                        }
                        break;
                    }
            }
            return result;
        }

        public static int GetAToPowerB(int a, int b)
        {
            int result = 1;
            if(b < 0)
            {
                throw new Exception("Second value mast be bigger or equal to zero!");
            }
            for (int i = 1; i <= b; i++)
            {
                result *= a;
            }

            return result;
        }
        public static int DividedbyA(int a)
        {
            int count = 0;
            const int maxNumber = 1000;
            for (int i = 1; i <= maxNumber; i++)
            {
                if (i % a == 0)
                {
                    count++;
                }
            }

            return count;
        }
        public static int GetSquareLessA(int a)
        {
            int count = 0;
            for (int i = 1; i <= a; i++)
            {
                if ((i * i < a))
                {
                    count++;
                }
            }

            return count;
        }

        public static int GetGreatestDivisor(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }

            return a;
        }
        public static int GetSumAtoBdivide7(int a, int b)
        {
            int sum = 0;
            const int divider = 7;
            if (a > b)
            {
                int temp = a;
                a = b;
                b = temp;
            }
            for (; a <= b; a++)
            {
                if (a % divider == 0)
                {
                    sum += a;
                }
            }

            return sum;
        }

        public static int GetNumberFibonachi(int n)
        {
            int prev = 1;
            int next = 1;
            int sum = 0;
            for (int i = 2; i < n; i++)
            {
                sum = prev + next;
                prev = next;
                next = sum;
            }

            return sum;
        }

        public static int EuclidAlgoritm(int a, int b)
        {
            while ((a != 0) && (b != 0))
            {
                if (a > b)
                    a -= b;
                else
                    b -= a;
            }

            return Math.Max(a, b);
        }

        //public static double GetDihotomy(int cube)
        //{

        //}

        public static int GetOddCount(int a)
        {
            int check = 0, count = 0;
            const int divider = 10;
            while (a != 0)
            {
                check = a % divider;
                a /= divider;
                if (check % 2 != 0)
                {
                    count++;
                }
            }

            return count;
        }

        public static int GetNumberMirror(int a)
        {
            int b = 0;
            const int divider = 10;
            while (a != 0)
            {
                int c = a % divider;
                b = b * divider + c;
                a /= divider;
            }

            return b;
        }

        public static bool OddLessEven(int n)
        {
            double even = 0, odd = 0;
            for (int i = 1; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    even++;
                }
                else
                {
                    odd++;
                }
            }

            if (even > odd)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool GetSameNumbers(int a, int b)
        {
            int count = 0;
            const int divider = 10;
            while (a != 0)
            {
                int tempA = a % divider;
                while (b != 0)
                {
                    int tempB = b % divider;
                    if (tempA == tempB)
                    {
                        count++;
                    }

                    b = b / divider;
                }

                a = a / divider;
            }

            if (count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static int ArrayMin(int[] A)
        {
            return A[ArrayMinID(A)];
        }

        public static int ArrayMax(int[] A)
        {
            return A[ArrayMaxID(A)];
        }

        public static int ArrayMinID(int[] A)
        {
            if(A == null || A.Length == 0)
            {
                throw new ArgumentException("No min element in empty array");
            }

            int minID = 0;
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] < A[minID])
                {
                    minID = i;
                }
            }

            return minID;
        }

        public static int ArrayMaxID(int[] A)
        {
            if (A == null || A.Length == 0)
            {
                throw new ArgumentException("No max element in empty array");
            }

            int maxID = 0;
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] > A[maxID])
                {
                    maxID = i;
                }
            }

            return maxID;
        }

        public static int SumOddID(int[] A)
        {
            if (A == null || A.Length == 0)
            {
                throw new ArgumentException("No odd element in empty array");
            }

            int sum = 0;
            for (int i = 0; i < A.Length; i+= 2)
            {
                    sum += A[i];
            }

            return sum;
        }

        public static int[] ArrayReverse(int[] A)
        {
            if (A == null || A.Length == 0)
            {
                throw new ArgumentException("Array is empty");
            }

            int i = 0;
            int j = A.Length - 1;
            for (i = 0; i < j; i++)
            {
                int temp = A[i];
                A[i] = A[j];
                A[j] = temp;
                i++;
                j--;
            }

            return A;
        }

        public static int CountOdd(int[] A)
        {
            if (A == null || A.Length == 0)
            {
                throw new ArgumentException("No odd element in empty array");
            }

            int count = 0;
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] % 2 == 1)
                {
                    count++;
                }
            }

            return count;
        }

        public static int[] ArrayHalfSwap(int[] A)
        {
            if (A == null || A.Length == 0)
            {
                throw new ArgumentException("Array is empty");
            }

            int count1 = 0;
            int count2 = (A.Length + 1) / 2;
            for (int i = count2; i < A.Length; i++)
            {
                int temp = A[count1];
                A[count1] = A[count2];
                A[count2] = temp;
                count1++;
                count2++;
            }
            return A;
        }

        public static int[] ArrayBubleSortUp(int[] A)
        {
            if (A == null || A.Length == 0)
            {
                throw new ArgumentException("Array is empty");
            }

            for (int i = 0; i < A.Length; i++)
            {
                for (int j = i + 1; j < A.Length - 1; j++)
                {
                    if (A[i] > A[j])
                    {
                        int temp = A[i];
                        A[i] = A[j];
                        A[j] = temp;
                    }
                }
            }

            return A;
        }

        public static int[] ArrayInsertSortDown(int[] A)
        {
            if (A == null || A.Length == 0)
            {
                throw new ArgumentException("Array is empty");
            }

            for (int i = 0; i < A.Length; i++)
            {
                int key = A[i];
                int j = i;
                while ((j > 1) && A[j - 1] > key)
                {
                    int temp = A[j - 1];
                    A[j - 1] = A[j];
                    A[j] = temp;
                    j--;
                }

                A[j] = key;
            }

            return A;
        }
    }
}


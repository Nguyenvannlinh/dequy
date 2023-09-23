using System.Text;

namespace dequy
{
    class hetcuu
    {
        static void Main(String[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.Write("12, 22 là ví dụ/n chọn bài tập: ");
            int l = int.Parse(Console.ReadLine());
            switch (l)
            {
                case 1:
                    Console.Write("\nnhập số n: ");
                    int y = int.Parse(Console.ReadLine());
                    Console.WriteLine($"\nkết quả là: {part_1(y)}");
                    break;
                case 2:
                    Console.Write("\nnhập số n: ");
                    int o = int.Parse(Console.ReadLine());
                    //Console.WriteLine($"{tongbp(o)}");
                    Console.WriteLine($"\nkết quả là: {part_2(o)}");

                    break;
                case 3:
                    Console.Write("\nnhập số n: ");
                    double t = double.Parse(Console.ReadLine());
                    Console.WriteLine($"\nkết quả là: {part_3(t)}");
                    break;
                case 4:
                    Console.Write("\nnhập số n: ");
                    int q = int.Parse(Console.ReadLine());
                    Console.Write("\nnhập số x: ");
                    double w = double.Parse(Console.ReadLine());
                    Console.WriteLine($"\nkết quả là: {part_4(q, w)}");
                    break;
                case 5:
                    Console.Write("\nnhập số n: ");
                    double u = double.Parse(Console.ReadLine());
                    Console.WriteLine($"\nkết quả là: {part_5(u)}");
                    break;
                case 6:
                    Console.Write("\nnhập số n: ");
                    int r = int.Parse(Console.ReadLine());
                    Console.Write("\nnhập số x: ");
                    int v = int.Parse(Console.ReadLine());
                    Console.WriteLine($"\nkết quả là: {part_6(r, v)}");
                    break;
                case 7:
                    Console.Write("\nnhập số n: ");
                    int k = int.Parse(Console.ReadLine());
                    Console.WriteLine($"\nkết quả là: {part_7(k)}");
                    break;
                case 8:
                    Console.Write("\nnhập số n: ");
                    double s = double.Parse(Console.ReadLine());
                    Console.WriteLine($"\nkết quả là: {part_8(1, s)}");
                    break;
                case 9:
                    Console.Write("\nnhập số n: ");
                    int z = int.Parse(Console.ReadLine());
                    part_9(z, "");
                    break;
                case 10:

                    Console.Write("\nnhập số n: ");
                    int sq = int.Parse(Console.ReadLine());
                    part_10(sq, 0);

                    if (min == int.MaxValue)
                    {
                        Console.WriteLine("Không có cách phân tích số " + sq + " thành tổng các phần tử của dãy a.");
                    }
                    else
                    {
                        Console.WriteLine("Cách phân tích số " + sq + " thành tổng các phần tử của dãy a có ít số hạng nhất:");
                        foreach (var num in ab)
                        {
                            Console.Write(num + " ");
                        }
                    }
                    break;
                case 11:
                    Console.Write("\nnhập số n: ");
                    double sw = double.Parse(Console.ReadLine());
                    Console.Write("\nnhập số x: ");
                    double vn = double.Parse(Console.ReadLine());
                    Console.WriteLine($"\nUCLN là: {part_11(vn, sw)}\nBCNN: {TimBCNN(vn, sw)}");
                    break;
                case 12:
                    int m = 0;
                    while (true)
                    {
                        Console.Write("\nnhập số n: ");
                        int n = int.Parse(Console.ReadLine());
                        Console.WriteLine(part_15(n));
                        if (m == 2)
                        {
                            break;
                        }
                        m++;
                    }
                    break;
                case 13:
                    Console.Write("\nnhập số n: ");
                    int c = int.Parse(Console.ReadLine());
                    Console.WriteLine($"kết quả: {part_13(c)}");
                    break;
                case 22:
                    Console.Write("độ dài mảng :");
                    int h = int.Parse(Console.ReadLine());
                    int[] a = new int[h];
                    part_22(a, h, 0);
                    break;
                default: Console.WriteLine("hết rồi"); break;
            }
        }



        static int part_15(int n)
        {
            if (n < 2) { return n; }
            return part_15(n - 1) + part_15(n - 2);
        }
        static void part_22(int[] n, int x, int y)
        {
            if (x == y)
            {
                for (int i = 0; i < x; i++)
                {
                    Console.Write(n[i]);
                }
                Console.WriteLine("\n");
            }
            else
            {
                n[y] = 0;

                //Console.WriteLine("số 0");
                //for (int i = 0; i < x; i++)
                //{
                //    Console.Write(n[i] + "\n");
                //}
                //Console.WriteLine("\n" + x, y + 1);
                part_22(n, x, y + 1);
                n[y] = 1;

                //Console.WriteLine("số 1");
                //for (int i = 0; i < x; i++)
                //{
                //    Console.Write(n[i]);
                //}
                //Console.WriteLine("\n" + x, y + 1);
                part_22(n, x, y + 1);
            }
        }


        static int part_1(int n )//5
        {
            if (n == 1) { return n; }
            return part_1(n - 1) + n;
        }


        static int part_2(int n)
        {
            if (n == 1) { return n; }
            else
            {
                Console.WriteLine($"{part_2(n - 1) + n * n} = ({n}-1) + {n}*{n}");
                return part_2(n - 1) + n * n;
            }
        }
        static double part_3(double n)
        {
            if (n == 1) { return n; }
            return part_3(n - 1) + 1 / n;
        }

        static double part_4(int n, double x)
        {
            if (n == 0) { return 1; }
            else Console.WriteLine($"{n}{x}"); return part_4(n - 1, x) * x;
        }

        static double part_5(double n)
        {
            if (n % 2 == 1) { return n; }
            else return part_5(n / 2);
        }

        static int part_6(int n, int x)
        {
            if (x == 0) { return n; }
            else return x % n;
        }

        static int part_7(int n)
        {
            if (n < 10) { return 1; }
            return part_7(n / 10) + 1;
        }
        static double part_8(double n, double x)
        {
            if (n == x) return (Math.Sqrt(n));
            else return Math.Sqrt((n) + part_8(n + 1, x));
        }

        static void part_9(int n, string x)
        {
            if (n == 0)
            {
                Console.WriteLine(x);
                return;
            }

            for (int i = 1; i <= n; i++)
            {
                part_9(n - i, x + i + "\t");
            }
        }

        static List<int> a = new List<int> { 1, 2, 3, 4, 5 }; 
        static List<int> aa = new List<int>(); 
        static List<int> ab = new List<int>(); 
        static int min = int.MaxValue; 
        static void part_10(int n, int l)
        {
                if (n == 0)
                {
                    
                    if (aa.Count < min)
                    {
                        min = aa.Count;
                        ab.Clear();
                        ab.AddRange(aa);
                    }
                    return;
                }

                for (int i = l; i < a.Count; i++)
                {
                    if (n - a[i] >= 0)
                    {
                        aa.Add(a[i]);
                        part_10(n - a[i], i + 1);
                        aa.RemoveAt(aa.Count - 1);
                    }
                }
            }
        static double part_11(double z, double g)
        {
            if (g == 0)
                return z;
            return part_11(g, z % g);
        }
        static double TimBCNN(double z, double g)
        {
            double ucln = part_11(z, g);
            return (z * g) / ucln;
        }

        static int part_13(int x)
        {
            if (x == 1) return x;
            else return x * (part_13(x - 1));
        }
        static long tongbp(int n)
        {
            if (n == 1)
            {
                return 1;
            }
            else
            {
                Console.WriteLine($"{tongbp(n - 1) + n * n} = ({n}-1) + {n}*{n}");
                return tongbp(n - 1) + n * n;
            }
        }
    }
}

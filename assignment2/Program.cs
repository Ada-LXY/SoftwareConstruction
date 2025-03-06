using System;
using System.IO.Pipes;
class assignment2_3
{
    static bool[] exit = new bool[101];
    static int num = 0;
    static int[] ans = new int[101];
    static int[] findsu()
        {
            for (int i = 2; i <= 100; ++i)
            {
            
                if (exit[i] == false)
                {
                    //Console.WriteLine(ans[num]);
                    ans[++num] = i;
                    for (int times = 1; i * times <= 100; times += 1)
                    {
                        exit[i * times] = true;
                    }
                }
            }
        return ans;
        }
    static int Main()
    {
        int[] ans = findsu();
        for (int i = 1;i <= num; i++)
        {
            Console.WriteLine(ans[i]);
        }
        return 0;
    }
}
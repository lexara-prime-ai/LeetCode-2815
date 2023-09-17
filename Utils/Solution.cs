namespace MaxSum.Utils;

public class Solution {
    public int MaxSum(int[] nums) 
    {
        var (max0, max1) = (new int [10], new int [10]);

        foreach(var n in nums)
        {
            var md = GetMaxDigit(n);

            if(n >= max0[md])
            {
                (max1[md], max0[md]) = (max0[md], n);
            }
            else if(n > max1[md])
            {
                max1[md] = n;
            }
        }

        var maxSum = -1;

        for(var i=1; i<10; i++)
        {
            if(max1[i] > 0)
                maxSum = Math.Max(maxSum, max0[i] + max1[i]);
        }

        return maxSum;
    }

    int GetMaxDigit(int n)
    {
        var max = n % 10;

        for(n /= 10; n > 0; n /= 10) max = Math.Max(max, n % 10);

        return max;
    }
}
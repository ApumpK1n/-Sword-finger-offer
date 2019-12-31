//扑克牌顺子
using System.Collections.Generic;
using System.Collections;

class Solution
{
    public bool IsContinuous(int[] numbers)
    {
        // write code here
        if (numbers.Length <= 0) return false;
        if (numbers.Length > 5) return false;
        int Zero = 0;
        bool bSame = false;
        ArrayList newNum = new ArrayList();
        foreach (int num in numbers)
        {
            if (num == 0) Zero += 1;
            else
            {
                if (!newNum.Contains(num)) newNum.Add(num);
            }
        }

        if (numbers.Length - newNum.Count != Zero) return false;

        int total = 0;
        newNum.Sort();
        for(int index=0; index<newNum.Count-1; index++)
        {
            total += (int)(System.Math.Abs((int)newNum[index] - (int)newNum[index+1])) - 1;
        }
        if(total <= Zero) return true;
        else return false;
    }
}
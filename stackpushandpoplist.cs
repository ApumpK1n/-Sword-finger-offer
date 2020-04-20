//栈的压入、弹出序列
using System.Collections;
using System.Collections.Generic;
using System.Linq;
class Solution
{
    public bool IsPopOrder(int[] pushV, int[] popV)
    {
        // write code here
        if (popV.Length > 0)
        {
            int popNum = popV[0];
            popV = popV.Skip(1).ToArray();
            int index = ArrayList.IndexOf(pushV, popNum);
            ArrayList<int> pushCloneV = pushV.Take(index).ToArray();
            foreach(int num in pushCloneV)
            {
                if (popV.Contains(num))
                {
                    continue;
                }
                else return false;
            }
        }
        else return true;
        return IsPopOrder(pushV, popV);
    }
}
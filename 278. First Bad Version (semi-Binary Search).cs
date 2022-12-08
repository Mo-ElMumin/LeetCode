/* The isBadVersion API is defined in the parent class VersionControl.
      bool IsBadVersion(int version); */

public class Solution : VersionControl {
    public int FirstBadVersion(int n) 
    {
        int stillGood = 1;
        int mid; 

        while (stillGood <= n)
        {   
            mid = stillGood + (n - stillGood) / 2;

            if (IsBadVersion(mid))
            {
                n = mid - 1;
            }
            else
            {
                stillGood = mid + 1;
            }
        }

        return n + 1;
    }
}

// Q1: Duplicate Integer
// Given an integer array nums, return true if any value appears more than once in the array, otherwise return false.

public class Solution 
{
  public bool hasDuplicate(int[] nums) 
  {
    HashSet<int> numsSet = new HashSet<int>();
    foreach (int num in nums)
    {
      if (numsSet.Contains(num)) return true;
      numsSet.Add(num);
    }
    return false;
  }
}

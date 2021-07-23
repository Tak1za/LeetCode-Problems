/*
 * @lc app=leetcode id=20 lang=csharp
 *
 * [20] Valid Parentheses
 */

// @lc code=start
public class Solution
{
    Stack<char> bucket = new Stack<char>();
    public bool IsValid(string s)
    {
        foreach (var c in s)
        {
            if (c == '(' || c == '[' || c == '{')
            {
                bucket.Push(c);
            }
            else
            {
                if (bucket.Count == 0)
                {
                    return false;
                }
                if (bucket.Peek() == '(' && c == ')')
                {
                    bucket.Pop();
                }
                else if (bucket.Peek() == '[' && c == ']')
                {
                    bucket.Pop();
                }
                else if (bucket.Peek() == '{' && c == '}')
                {
                    bucket.Pop();
                }
                else
                {
                    return false;
                }
            }
        }

        if (bucket.Count == 0)
        {
            return true;
        }
        return false;
    }
}
// @lc code=end


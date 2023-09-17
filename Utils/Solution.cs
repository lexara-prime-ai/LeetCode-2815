namespace MaxSum.Utils;
public class Solution
{
    // public static int SUM = 0;
    public int MaxSum(int[] nums)
    {
        List<int> TEMP_ARRAY = new();
        // Loop through array
        for (int i = 0; i < nums.Length - 1; i++)
        {
            int SUM = nums[i] + nums[i + 1];

            // Check if the digit, SUM, contain equal digits
            // Convert SUM to string
            string CONVERTED_OUPTUT = SUM.ToString();

            // Convert CONVERTED_OUTPUT to array
            char[] CHARS = CONVERTED_OUPTUT.ToCharArray();

            // Check if a single CHAR's length > 1 & first index is == last index
            if (CHARS.Length > 1 && CHARS[0] == CHARS[1])
            {
                // Covert CHARS back to string
                string OUTPUT = new(CHARS);

                // Convert current OUTPUT to int
                int TEMP = int.Parse(OUTPUT);
                // Add TEMP value to TEMP_ARRAY
                TEMP_ARRAY.Add(TEMP);
            }
        }
        if (TEMP_ARRAY.Count > 0)
        {
            // Sort the list from lowest to highest
            TEMP_ARRAY.Sort();
            TEMP_ARRAY.Reverse();

            return TEMP_ARRAY[0];
        }
        return -1;
    }
}
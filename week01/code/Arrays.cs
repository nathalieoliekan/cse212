
public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  
    /// For example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  
    /// Assume that length is a positive integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
        // Step 1: Make a new array with the given length.
        // Step 2: Use a loop to go through each index.
        // Step 3: At each spot in the array, add number * (i + 1) to get the next multiple.
        // Step 4: Return the filled array.

        double[] result = new double[length];

        for (int i = 0; i < length; i++)
        {
            result[i] = number * (i + 1);
        }

        return result;
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  
    /// For example, if the data is List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 
    /// then the list after the function runs should be List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        // Step 1: Find the count of the list.
        // Step 2: Figure out where to split it — from the end, we take the last 'amount' numbers.
        // Step 3: Use GetRange to grab the last part (right side).
        // Step 4: Use GetRange to grab the first part (left side).
        // Step 5: Clear the original list and add the right part first, then the left part.

        int count = data.Count;

        // Get the last 'amount' numbers (right part)
        List<int> right = data.GetRange(count - amount, amount);

        // Get the rest (left part)
        List<int> left = data.GetRange(0, count - amount);

        // Clear original and put it back in the right order
        data.Clear();
        data.AddRange(right);
        data.AddRange(left);
    }
}

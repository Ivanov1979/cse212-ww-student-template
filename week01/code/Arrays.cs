using System;
using System.Collections.Generic;

public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
        // PLAN:
        // 1) Create a new array of doubles called result with a size equal to length.
        // 2) Use a for loop to go through each index of the array from 0 to length - 1.
        // 3) At each index i, calculate the multiple by multiplying number by (i + 1).
        //    - This ensures the first value is number * 1, not number * 0.
        // 4) Store the calculated value in result[i].
        // 5) After the loop finishes, return the result array.

        double[] result = new double[length];

        for (int i = 0; i < length; i++)
        {
            result[i] = number * (i + 1);
        }

        return result;
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        // PLAN:
        // 1) Calculate the index where the last 'amount' elements begin.
        //    - This is data.Count - amount.
        // 2) Create a new list called tail that contains the last 'amount' elements
        //    using GetRange(startIndex, amount).
        // 3) Create another list called head that contains the remaining elements
        //    from the beginning of the list up to the start of tail.
        // 4) Clear the original list because the function must modify the existing list.
        // 5) Add the elements from tail back into the list first.
        // 6) Add the elements from head back into the list after tail.
        // 7) The list is now rotated to the right by the specified amount.

        int splitIndex = data.Count - amount;

        List<int> tail = data.GetRange(splitIndex, amount);
        List<int> head = data.GetRange(0, splitIndex);

        data.Clear();
        data.AddRange(tail);
        data.AddRange(head);
    }
}

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
        // Step 1: Construct an array to contain the multiples.
        double[] multiples = new double[length];

        // Step 2: Loop above each point in the array.
        for (int i = 0; i < length; i++)
        {
            
            // Step 3: Calculate the multiple.
            multiples[i] = number * (i + 1);
        
        }

        // Step 4: Bring back the array.
        return multiples; 
    
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

        // Security check for testing.
        if (data.Count == 0)
            return;

        //Regulating amount first.
          amount = amount % data.Count;

        // Step 1: Compute the cut point.
        int startIndex = data.Count - amount;


        // Step 2: Obtain tail of the list, the part that seemingly laps the head.
        List<int> endPart = data.GetRange(startIndex, amount);

        // Step 3: Obtain the head of the list, the part that seemingly laps the tail.
        List<int> beginningPart = data.GetRange(0, startIndex);


         // Step 4: Remove the original list.
         data.Clear();


         // Step 5: Attach the changed pieces in the list.
         data.AddRange(endPart);
         data.AddRange(beginningPart);




    }
}

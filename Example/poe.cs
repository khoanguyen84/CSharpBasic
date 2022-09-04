namespace Example 
{
    public class POE 
    {
        public int f (int[] numbers) 
        {
            int sumLeft = 0;
            int sumRight = 0;
            for (int idx = 1; idx <= numbers.Length - 2; idx++) 
            {
                sumLeft = 0;
                sumRight = 0;
                for (int i = 0; i < idx; i++) {
                    sumLeft += numbers[i];
                }
                for (int j = idx + 1; j < numbers.Length; j++) {
                    sumRight += numbers[j];
                }

                if (sumLeft == sumRight)
                    return idx;
            }

            return -1;
        }
    }
}
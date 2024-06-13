namespace BinaryGap
{
    public static class Main
    {
        public static int Solution(int N)
        {
            byte longestGap = 0;
            byte startIndex = 0;
            byte endIndex = 0;
            byte currentIndex = 0;
            while (N > 0)
            {
                currentIndex++;

                int lastBit = N & 1; // Get the least significant bit
                N >>= 1; // Right shift N by 1

                if (lastBit == 1)
                {
                    startIndex = currentIndex;
                    endIndex = currentIndex;
                }
                else if (startIndex != 0)
                {
                    endIndex = currentIndex;
                    longestGap = (byte)Math.Max(longestGap, endIndex - startIndex);
                }
            }

            return longestGap;
        }
    }
}

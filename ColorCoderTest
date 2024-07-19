using System;
using System.Diagnostics;
using System.Drawing;

namespace TelCo.ColorCoder
{
    class ColorCoderTest
    {
        public static void testGetColorFromPairNumber(int pairNumber)
        {
            ColorPair testPair1 = ColorCoder.GetColorFromPairNumber(pairNumber);
            Console.WriteLine("[In]Pair Number: {0},[Out] Colors: {1}\n", pairNumber, testPair1);
            Debug.Assert(testPair1.majorColor == Color.White);
            Debug.Assert(testPair1.minorColor == Color.Brown);
        }
        public static void GetPairNumberFromColor(ColorPair testPair2)
        {
            int pairNumber = ColorCoder.GetPairNumberFromColor(testPair2);
            Console.WriteLine("[In]Colors: {0}, [Out] PairNumber: {1}\n", testPair2, pairNumber);
            Debug.Assert(pairNumber == 18);
        }
    }
}

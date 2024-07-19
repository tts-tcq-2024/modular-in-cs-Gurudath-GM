using System;
using System.Diagnostics;
using System.Drawing;

namespace TelCo.ColorCoder
{
    class ColorCoderTest
    {
        public static void testGetColorFromPairNumber(int pairNumber, Color expectedMajorColor, Color expectedMinorColor)
        {
            ColorPair testPair1 = ColorCoder.GetColorFromPairNumber(pairNumber);
            Console.WriteLine("[In]Pair Number: {0},[Out] Colors: {1}\n", pairNumber, testPair1);
            Debug.Assert(testPair1.majorColor == expectedMajorColor);
            Debug.Assert(testPair1.minorColor == expectedMinorColor);
        }
        public static void GetPairNumberFromColor(ColorPair testPair2, int expectedPairNumber)
        {
            int pairNumber = ColorCoder.GetPairNumberFromColor(testPair2);
            Console.WriteLine("[In]Colors: {0}, [Out] PairNumber: {1}\n", testPair2, pairNumber);
            Debug.Assert(pairNumber == expectedPairNumber);
        }
    }
}

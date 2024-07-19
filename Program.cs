using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;

namespace TelCo.ColorCoder
{
    class Program
    {
        private static void Main(string[] args)
        {
            ColorCoderTest.testGetColorFromPairNumber(4, Color.White, Color.Brown);
            ColorCoderTest.testGetColorFromPairNumber(5, Color.White, Color.SlateGray);
            ColorCoderTest.testGetColorFromPairNumber(23, Color.Violet, Color.Green);
            ColorPair testPair2 = new ColorPair() { majorColor = Color.Yellow, minorColor = Color.Green };
            ColorCoderTest.GetPairNumberFromColor(testPair2, 18);
            testPair2 = new ColorPair() { majorColor = Color.Red, minorColor = Color.Blue };
            ColorCoderTest.GetPairNumberFromColor(testPair2, 6);
        }
    }
}

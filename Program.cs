using System;
using System.Diagnostics;
using System.Drawing;

namespace TelCo.ColorCoder
{
    class Program
    {
        private static void Main(string[] args)
        {
            ColorCoderTest.testGetColorFromPairNumber(4);
            ColorCoderTest.testGetColorFromPairNumber(5);
            ColorCoderTest.testGetColorFromPairNumber(23);
            
            ColorPair testPair2 = new ColorPair() { majorColor = Color.Yellow, minorColor = Color.Green };
            ColorCoderTest.GetPairNumberFromColor(testPair2);
            testPair2 = new ColorPair() { majorColor = Color.Red, minorColor = Color.Blue };
            ColorCoderTest.GetPairNumberFromColor(testPair2);
        }
    }
}

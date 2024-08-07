using System;
using System.Diagnostics;
using System.Drawing;

namespace TelCo.ColorCoder
{
    static class ColorCoder
    {
        public static ColorPair GetColorFromPairNumber(int pairNumber)
        {
            ValidatePairNumber(pairNumber);
            int zeroBasedPairNumber = pairNumber - 1;
            int majorIndex = zeroBasedPairNumber / ColorMap.colorMapMinor.Length;
            int minorIndex = zeroBasedPairNumber % ColorMap.colorMapMinor.Length;
            return new ColorPair() { majorColor = ColorMap.colorMapMajor[majorIndex],
                minorColor = ColorMap.colorMapMinor[minorIndex]
            };
        }
        private static void ValidatePairNumber(int pairNumber)
        {
            if (pairNumber < 1 || pairNumber > ColorMap.colorMapMinor.Length * ColorMap.colorMapMajor.Length)
            {
                throw new ArgumentOutOfRangeException(
                    string.Format("Argument PairNumber:{0} is outside the allowed range", pairNumber));
            }
        }
        public static int GetPairNumberFromColor(ColorPair pair)
        {
            int minorIndex = GetColorIndex(ColorMap.colorMapMinor, pair.minorColor);
            int majorIndex = GetColorIndex(ColorMap.colorMapMajor, pair.majorColor);
            if (majorIndex == -1 || minorIndex == -1)
                throw new ArgumentException(string.Format("Unknown Colors: {0}", pair.ToString()));
            return (majorIndex * ColorMap.colorMapMinor.Length) + (minorIndex + 1);
        }
        private static int GetColorIndex(Color[] arraryOfColors, Color color)
        {
            for (int i = 0; i < arraryOfColors.Length; i++)
            {
                if (arraryOfColors[i] == color)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}

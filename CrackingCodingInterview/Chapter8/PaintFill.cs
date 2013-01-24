using System;

namespace CrackingCodingInterview.Chapter8
{
    [Reference(
        Page = 64
        , Number = "8.6"
        , Description = "Implement the 'paint fill' function that one might see on many image editing programs." +
                        "That is, given a screen (represented by a 2-dimensional array of Colors), a" +
                        "point, and a new color, fill in the surrounding area until you hit a border of that color")]
    public class PaintFill : Algorithm<Tuple<Color[,], int, int, Color>, Color[,]>
    {
        protected override Color[,] OnExecute(Tuple<Color[,], int, int, Color> arg)
        {
            Color[,] picture = arg.Item1;
            int x = arg.Item2;
            int y = arg.Item3;
            Color newColor = arg.Item4;

            Fill(picture, x, y, picture[x, y], newColor);

            return picture;
        }

        private static void Fill(Color[,] picture, int x, int y, Color oldColor, Color newColor)
        {
            if (x < 0 
                || x >= picture.GetLength(0) 
                || y < 0 
                || y >= picture.GetLength(1)
                || picture[x, y] != oldColor)
            {
                return;
            }
            
            picture[x, y] = newColor;
            Fill(picture, x - 1, y, oldColor, newColor);
            Fill(picture, x + 1, y, oldColor, newColor);
            Fill(picture, x, y - 1, oldColor, newColor);
            Fill(picture, x, y + 1, oldColor, newColor);
        }
    }

    public enum Color
    {
        Red, 
        Green,
        Blue
    }
}

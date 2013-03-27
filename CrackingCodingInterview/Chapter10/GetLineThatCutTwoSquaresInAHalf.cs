using System;

namespace CrackingCodingInterview.Chapter10
{
    [Reference(
       Page = 68
       , Number = "10.5"
       , Description = "Given two squares on a two dimensional plane, find a line that would cut these two squares in half."
       , NoTestRequired = true
       )]
    public class GetLineThatCutTwoSquaresInAHalf : Algorithm<Tuple<Square, Square>, Line>
    {
        protected override Line OnExecute(Tuple<Square, Square> arg)
        {
            Square square1 = arg.Item1;

            Point center1 = Center(square1);
            Point center2 = Center(arg.Item2);

            if (center1 == center2)
            {
                return new Line(

                       square1.TopLeft,
                       square1.BottomRight
                    );
            }

            return new Line
                (
                    center1,
                    center2
                );
        }

        private static Point Center(Square square)
        {
            Point topLeft = square.TopLeft;
            Point bottomRight = square.BottomRight;

            return new Point
                (
                    Mediana(topLeft.X, bottomRight.X),
                    Mediana(topLeft.Y, bottomRight.Y)
                );
        }

        private static int Mediana(int a1, int a2)
        {
            return (a1 + a2) / 2;
        }
    }

    public class Square
    {
        public Point TopLeft { get; set; }
        public Point BottomRight { get; set; }
    }
}

using System;

namespace CrackingCodingInterview.Chapter10
{
    public class Line
    {
        public Line(Point start, Point end)
        {
            End = end;
            Start = start;

            CalculateSlopAndIntercept();
        }

        private void CalculateSlopAndIntercept()
        {
            if (Math.Abs(Start.X - End.X) > Double.Epsilon)
            {
                Slope = (Start.Y - End.Y)/(Start.X - End.X);
                Intercept = Start.Y - Slope.Value * End.X;
            }
            else
            {
                Slope = null;
                Intercept = Start.X;
            }
        }

        public Point Start { get; private set; }
        public Point End { get; private set; }
        public double? Slope { get; private set; }
        public double Intercept { get; private set; }

        public override int GetHashCode()
        {
            return (int)(Slope.GetValueOrDefault() * 1000) | (int)(Intercept * 1000);
        }
        public override bool Equals(object obj)
        {
            Line line = (Line) obj;

            if ((IsDoubleEqual(line.Slope.GetValueOrDefault(), Slope.GetValueOrDefault()))
                && (IsDoubleEqual(line.Intercept, Intercept)))
            {
                return true;
            }

            return false;
        }

        private bool IsDoubleEqual(double x, double y)
        {
            return Math.Abs(x - y) < Double.Epsilon;
        }
    }
}
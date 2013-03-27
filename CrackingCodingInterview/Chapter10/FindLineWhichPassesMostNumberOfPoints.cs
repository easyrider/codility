using System.Collections.Generic;

namespace CrackingCodingInterview.Chapter10
{

    [Reference(
       Page = 68
       , Number = "10.6"
       , Description = "Given a two dimensional graph with points on it, find a line which passes the most number of points."
       , NoTestRequired = true
       )]
    public class FindLineWhichPassesMostNumberOfPoints : Algorithm<Point[], Line>
    {
        protected override Line OnExecute(Point[] points)
        {
            Line bestLine = null;
            Dictionary<Line, int> linesCount = new Dictionary<Line, int>();

            for (int i = 0; i < points.Length; i++)
            {
                for (int j = i + 1; j < points.Length; j++)
                {
                    Line line = new Line(points[i], points[j]);

                    if (!linesCount.ContainsKey(line))
                    {
                        linesCount.Add(line, 0);
                    }

                    linesCount[line] = linesCount[line] + 1;

                    if (bestLine == null || (linesCount[line] > linesCount[bestLine]))
                    {
                        bestLine = line;
                    }
                }
            }

            return bestLine;
        }
    }
}

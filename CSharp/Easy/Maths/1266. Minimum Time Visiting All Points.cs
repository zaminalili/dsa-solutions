namespace CSharp.Easy.Maths;

public class Solution1266
{
    public int MinTimeToVisitAllPoints(int[][] points) 
    {
        int time = 0;
        for (int i = 0; i < points.Length-1; i++)
        {
            int diffX = Math.Abs(points[i+1][0] - points[i][0]);
            int diffY = Math.Abs(points[i+1][1] - points[i][1]);
            time += diffX >= diffY ? diffX : diffY;
        }

        return time;    
    }
}

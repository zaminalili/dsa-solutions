namespace CSharp.Easy.Maths;

public class ConstructTheRectangle
{
    public int[] ConstructRectangle(int area) 
    {
        int w = (int)Math.Sqrt(area);

        while(area % w != 0) 
            w--;
    
        return [area/w, w];
    }
}

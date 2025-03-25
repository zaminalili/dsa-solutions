namespace CSharp.Easy.Maths;

public class ConstructTheRectangle
{
    public int[] ConstructRectangle(int area) 
    {
        int w = (int)Math.Sqrt(area);

        while(w > 0) 
        {
            var l = (double)area / (double)w;
            if(l- (double)(int)l == 0) 
                return [(int)l, w];
            w--;
        }

        return [w, w];
    }
}

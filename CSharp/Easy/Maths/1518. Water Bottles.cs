namespace CSharp.Easy.Maths;

public class WaterBottles
{
    public int NumWaterBottles(int numBottles, int numExchange)
    {
        int result = numBottles;

        while (numBottles >= numExchange)
        {
            int div = numBottles / numExchange;
            result += div;
            numBottles = div + (numBottles % numExchange);
        }

        return result;
    }
}

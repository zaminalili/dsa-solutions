namespace CSharp.Easy.SuperEasyProblems;

public class RobotReturnToOrigin
{
    public bool JudgeCircle(string moves) 
    {
        int[] position = [0, 0];

        foreach (var move in moves)
        {
            switch (move)
            {
                case 'R':
                    position[0]++; 
                    break;
                case 'L':
                    position[0]--;
                    break;
                case 'U':
                    position[1]++;
                    break;
                case 'D':
                    position[1]--;
                    break;
            }
        }

        return position[0] == 0 && position[1] == 0;
    }
}

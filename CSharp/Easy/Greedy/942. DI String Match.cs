public static class DIStringMatch942
{
    public static int[] DiStringMatch(string s) 
    {
        var len = s.Length;
        var max = len;
        var min = 0;
        var perm = new int[len+1];

        for (int i = 0; i < len; i++)
        {
            if(s[i] == 'I')
                perm[i] = min++;
            else 
                perm[i] = max--;
        }

        perm[len] = min;

        return perm; 
    }
}

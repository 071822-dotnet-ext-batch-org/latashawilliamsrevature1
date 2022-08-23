public static int pickingNumbers(List<int> a)
    {
        a.Sort();
        int diff = 0;
        int temp = 0;
        for(int i = 0 ; i < a.Count; i++){
            for(int j = i ; j < a.Count ; j++)
            {
             int num = a[j] - a[i];
            if( num == 0 || num == 1)
            {
                 diff++;
            }
            }
            if(diff > temp)
                temp = diff;
            diff = 0;
        }
        return temp;
    }
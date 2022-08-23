public static int hurdleRace(int k, List<int> height)
    {
            var max = height.Max();
            var diff = max - k;
            return diff < 0 ? 0 : diff;
    }

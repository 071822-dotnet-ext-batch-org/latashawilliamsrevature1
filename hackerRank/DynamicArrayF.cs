public static List<int> dynamicArray(int n, List<List<int>> queries)
    {
        var userInput = Console.ReadLine();
        var userInputSplits = userInput.Split(' ');
        var numberOfSequences = n.Parse(userInputSplits[0]);
        var numberOfQueries = n.Parse(userInputSplits[1]);
        var seqList = new List<List<int>>(new List<int>[numberOfSequences]);
        var lastAns = 0;
        for (var i = 0; i < numberOfQueries; i++)
        {
            userInput = Console.ReadLine();
            userInputSplits = userInput.Split(' ');
            var queryType = n.Parse(userInputSplits[0]);
            var x = n.Parse(userInputSplits[1]);
            var y = n.Parse(userInputSplits[2]);
            var seqIndex = (x ^ lastAns) % numberOfSequences;
            switch (queryType)
            {
                case 1:
                    if (seqList[seqIndex] != null)
                        seqList[seqIndex].Add(y);
                    else
                    {
                        queries = new List<int>();
                        queries.Add(y);
                        seqList[seqIndex] = queries;
                    }
                    break;
                case 2:
                    queries = seqList[seqIndex];
                    lastAns = queries[y % queries.Count];
                    Console.WriteLine(lastAns);
                    break;
            }
    }
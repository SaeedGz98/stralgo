namespace Graphs.WordLadder
{
    public static class WordLadderProblem
    {
        public static int LadderLength(string beginWord, string endWord, IList<string> wordList)
        {
            if (!wordList.Contains(endWord))
                return 0;

            Dictionary<string, List<string>> nei = new();
            wordList.Add(beginWord);

            foreach (var word in wordList)
            {
                for (int i = 0; i < word.Length; i++)
                {
                    string pattern = word[..i] + "*" + word[(i + 1)..];

                    if (nei.ContainsKey(pattern))
                        nei[pattern].Add(word);
                    else
                        nei.Add(pattern, new List<string>() { word });
                }
            }

            HashSet<string> visited = new()
            {
                beginWord
            };

            Queue<string> queue = new();
            queue.Enqueue(beginWord);
            int res = 1;

            while (queue.Count > 0)
            {
                foreach (var i in Enumerable.Range(0, queue.Count))
                {
                    string word = queue.Dequeue();

                    if (word == endWord)
                        return res;

                    for (int j = 0; j < word.Length; j++)
                    {
                        string pattern = word[..j] + "*" + word[(j + 1)..];

                        foreach (string neiWord in nei[pattern])
                        {
                            if (!visited.Contains(neiWord))
                            {
                                visited.Add(neiWord);
                                queue.Enqueue(neiWord);
                            }
                        }
                    }
                }
                res++;
            }

            return 0;
        }
    }
}
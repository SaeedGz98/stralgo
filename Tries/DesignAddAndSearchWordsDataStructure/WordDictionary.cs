using System.Collections.Generic;

namespace Tries.DesignAddAndSearchWordsDataStructure
{
    public class TrieNode
    {
        public Dictionary<char, TrieNode> Children { get; set; }
        public bool EndOfWord { get; set; }

        public TrieNode()
        {
            Children = new();
            EndOfWord = false;
        }
    }

    public class WordDictionary
    {
        private readonly TrieNode Root;

        public WordDictionary()
        {
            Root = new();
        }

        public void AddWord(string word)
        {
            TrieNode cur = Root;

            foreach (char character in word)
            {
                if (!cur.Children.ContainsKey(character))
                    cur.Children[character] = new();

                cur = cur.Children[character];
            }

            cur.EndOfWord = true;
        }

        public bool Search(string word)
        {
            bool DFS(int j, TrieNode node)
            {
                TrieNode cur = node;

                for (int i = j; i < word.Length; i++)
                {
                    if (word[i] == '.')
                    {
                        foreach (TrieNode child in cur.Children.Values)
                        {
                            if (DFS(i + 1, child))
                                return true;
                        }

                        return false;
                    }
                    else
                    {
                        if (!cur.Children.ContainsKey(word[i]))
                            return false;

                        cur = cur.Children[word[i]];
                    }
                }

                return cur.EndOfWord;
            }

            return DFS(0, Root);
        }
    }
}
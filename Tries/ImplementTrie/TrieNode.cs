using System.Collections.Generic;

namespace Tries.ImplementTrie
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
}
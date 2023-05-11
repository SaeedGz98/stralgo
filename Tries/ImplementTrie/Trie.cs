namespace Tries.ImplementTrie
{
    public class Trie
    {
        private TrieNode Root { get; set; }

        public Trie()
        {
            Root = new();
        }

        public void Insert(string word)
        {
            TrieNode cur = Root;

            foreach (char character in word)
            {
                if (!cur.Children.ContainsKey(character))
                    cur.Children[character] = new TrieNode();

                cur = cur.Children[character];
            }

            cur.EndOfWord = true;
        }

        public bool Search(string word)
        {
            (bool Found, TrieNode Node) = TraversePhrase(word);

            return Found && Node.EndOfWord;
        }

        public bool StartsWith(string prefix)
        {
            (bool Found, _) = TraversePhrase(prefix);

            return Found;
        }

        private (bool Found, TrieNode Node) TraversePhrase(string phrase)
        {
            TrieNode cur = Root;

            foreach (char character in phrase)
            {
                if (!cur.Children.ContainsKey(character))
                    return (false, null);

                cur = cur.Children[character];
            }

            return (true, cur);
        }
    }
}
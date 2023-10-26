using System;
using System.Runtime.CompilerServices;

namespace _26._10._23
{
    internal class Song
    {
        string name;
        string author;
        Song prev;
        public void Name(string name)
        {
            this.name = name;
        }
        public void Author(string author)
        {
            this.author = author;
        }
        public void Prev(Song prev)
        {
            this.prev = prev;
        }

        public void PrintSong()
        {
            Console.WriteLine($"{author} - {name}");
        }
        public string Title() { return $"{author} - {name}"; }
        public override bool Equals(object d)
        {
            return RuntimeHelpers.Equals(this, d);
        }

    }
}

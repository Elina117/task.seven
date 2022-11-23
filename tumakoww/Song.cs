using System;
namespace tumakoww
{
    internal class Song
    {
        internal string name { get; set; }
        internal string author { get; set; }
        internal string Title()
        {
            return $"Песня <<{name}>>, автор - {author}";
        }
        internal bool Equals(Object song1, Object song2)
        {
            if (song1.Equals(song2))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        internal bool Equals(Song song1, Song song2)
        {
            if (song1.name.Equals(song2.name) && song1.author.Equals(song2.author))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        internal Song(string name, string author)
        {
            this.name = name;
            this.author = author;
        }


    }
}


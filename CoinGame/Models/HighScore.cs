using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinGame.Models
{
    public class HighScore: IComparable<HighScore>, IEquatable<HighScore>
    {
        public int Score { get; set; }
        public string Name { get; set; }

        public HighScore(string name, int score)
        {
            this.Score = score;
            this.Name = name;
        }

        public int CompareTo(HighScore other)
        {
            return other.Score > this.Score ? 1 : -1;
        }

        public bool Equals(HighScore other)
        {
            return other.Name.ToLower() == this.Name.ToLower();
        }
    }
}

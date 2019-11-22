using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shooter.Model
{
    public class Player : MyNotify
    {
        private string nick;
        public string Nick
        {
            get
            {
                return nick;
            }
            set
            {
                nick = value;
                NotifyPropertyChanged(nameof(Nick));
            }
        }

        private int score;
        public int Score
        {
            get
            {
                return score;
            }
            set
            {
                score = value;
                NotifyPropertyChanged(nameof(Score));
            }
        }
    }
}

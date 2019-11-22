using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using System.Windows.Shapes;

namespace Shooter.Models
{
    public class Enemy : MyNotify
    {
        private Ellipse myEnemy;
        public Ellipse MyEnemy
        {
            get
            {
                return myEnemy;
            }
            set
            {
                myEnemy = value;
                NotifyPropertyChanged(nameof(MyEnemy));
            }
        }

        private int positionX;
        public int PositionX
        {
            get
            {
                return positionX;
            }
            set
            {
                positionX = value;
                NotifyPropertyChanged(nameof(PositionX));
            }
        }

        private int positionY;
        public int PositionY
        {
            get
            {
                return positionY;
            }
            set
            {
                positionY = value;
                NotifyPropertyChanged(nameof(PositionY));
            }
        }

        public Enemy(int x, int y)
        {
            PositionX = x;
            PositionY = y;
        }

        public void Draw(Window win)
        {
            myEnemy.Height = 10;
            myEnemy.Width = 10;
            myEnemy.Fill = Brushes.White;
            myEnemy.HorizontalAlignment = HorizontalAlignment.Center;
            myEnemy.VerticalAlignment = VerticalAlignment.Center;

        }
    }
}

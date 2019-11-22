using Shooter.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Shooter.Views
{
    /// <summary>
    /// Interaction logic for GameControl.xaml
    /// </summary>
    public partial class GameControl : UserControl
    {
        private GameViewModel myViewModel;
        public GameViewModel MyViewModel
        {
            get
            {
                return myViewModel;
            }
            set
            {
                myViewModel = value;
            }
        }

        public GameControl()
        {
            InitializeComponent();
            MyViewModel = new GameViewModel();
            DataContext = MyViewModel;
        }
    }
}

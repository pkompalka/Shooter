using Shooter.Model;
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
    /// Interaction logic for GameSettingsControl.xaml
    /// </summary>
    public partial class GameSettingsControl : UserControl
    {
        private GameSettingsViewModel myViewModel;
        public GameSettingsViewModel MyViewModel
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

        public GameSettingsControl()
        {
            InitializeComponent();
            MyViewModel = new GameSettingsViewModel();
            DataContext = MyViewModel;
        }

        public GameSettingsControl(Player tmPlayer)
        {
            InitializeComponent();
            MyViewModel = new GameSettingsViewModel(tmPlayer);
            DataContext = MyViewModel;
        }
    }
}

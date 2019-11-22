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
    /// Interaction logic for MenuControl.xaml
    /// </summary>
    public partial class MenuControl : UserControl
    {
        private MenuViewModel myViewModel;
        public MenuViewModel MyViewModel
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

        public MenuControl()
        {
            InitializeComponent();
            MyViewModel = new MenuViewModel();
            DataContext = MyViewModel;
        }
    }
}

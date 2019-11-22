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
    /// Interaction logic for EnterNickControl.xaml
    /// </summary>
    public partial class EnterNickControl : UserControl
    {
        private EnterNickViewModel myViewModel;
        public EnterNickViewModel MyViewModel
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

        public EnterNickControl()
        {
            InitializeComponent();
            MyViewModel = new EnterNickViewModel();
            DataContext = MyViewModel;
        }
    }
}

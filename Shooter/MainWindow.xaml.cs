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
using MahApps.Metro.Controls;
using Shooter.ViewModels;
using Shooter.Views;

namespace Shooter
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        //private MainWindowViewModel myViewModel;
        //public MainWindowViewModel MyViewModel
        //{
        //    get
        //    {
        //        return myViewModel;
        //    }
        //    set
        //    {
        //        myViewModel = value;
        //    }
        //}
        
        public MainWindow()
        {
            InitializeComponent();
            //myMenu.Content = new MenuControl();
            ContentArea.Content = new MenuControl();
            //MyViewModel = new MainWindowViewModel();
            //DataContext = MyViewModel;
        }
    }
}

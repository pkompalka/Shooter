using Shooter.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace Shooter.ViewModels
{
    public class MainWindowViewModel : MyNotify
    {
        //private ICommand buttonStart;
        //public ICommand ButtonStart
        //{
        //    get
        //    {
        //        return buttonStart ?? (buttonStart = new DelegateCommand(x => ButtonStartMethod(x)));
        //    }
        //    set
        //    {
        //        buttonStart = value;
        //    }

        //}

        //private EnterNickControl nickControl;
        //public EnterNickControl NickControl
        //{
        //    get
        //    {
        //        return nickControl;
        //    }
        //    set
        //    {
        //        nickControl = value;
        //        NotifyPropertyChanged(nameof(NickControl));
        //    }
        //}

        //private Window tmpWindow;
        //public Window TmpWindow
        //{
        //    get
        //    {
        //        return tmpWindow;
        //    }
        //    set
        //    {
        //        tmpWindow = value;
        //        NotifyPropertyChanged(nameof(TmpWindow));
        //    }
        //}

        //public void ButtonStartMethod(object sender)
        //{
        //    NickControl = new EnterNickControl();
        //    TmpWindow = new Window();
        //    TmpWindow = (Window)sender;
        //    TmpWindow.Content = NickControl;
        //}
    }
}

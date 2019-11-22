using Shooter.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Shooter.ViewModels
{
    public class MenuViewModel : MyNotify
    {
        private ICommand buttonStart;
        public ICommand ButtonStart
        {
            get
            {
                return buttonStart ?? (buttonStart = new DelegateCommand(x => ButtonStartMethod(x)));
            }
            set
            {
                buttonStart = value;
            }

        }

        private ICommand buttonClose;
        public ICommand ButtonClose
        {
            get
            {
                return buttonClose ?? (buttonClose = new DelegateCommand(x => ButtonCloseMethod(x)));
            }
            set
            {
                buttonClose = value;
            }

        }

        private EnterNickControl nickControl;
        public EnterNickControl NickControl
        {
            get
            {
                return nickControl;
            }
            set
            {
                nickControl = value;
                NotifyPropertyChanged(nameof(NickControl));
            }
        }

        private Window tmpWindow;
        public Window TmpWindow
        {
            get
            {
                return tmpWindow;
            }
            set
            {
                tmpWindow = value;
                NotifyPropertyChanged(nameof(TmpWindow));
            }
        }

        public void ButtonStartMethod(object sender)
        {
            NickControl = new EnterNickControl();
            TmpWindow = new Window();
            UserControl u1 = new UserControl();
            u1 = (UserControl)sender;
            TmpWindow = Window.GetWindow(u1);
            TmpWindow.Content = NickControl;
        }

        public void ButtonCloseMethod(object sender)
        {
            TmpWindow = new Window();
            UserControl u1 = new UserControl();
            u1 = (UserControl)sender;
            TmpWindow = Window.GetWindow(u1);
            TmpWindow.Close();
        }
    }
}

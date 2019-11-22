using Shooter.Model;
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
    public class GameSettingsViewModel : MyNotify
    {
        private Player myPlayer;
        public Player MyPlayer
        {
            get
            {
                return myPlayer;
            }
            set
            {
                myPlayer = value;
                NotifyPropertyChanged(nameof(MyPlayer));
            }
        }

        private string title;
        public string Title
        {
            get
            {
                return title;
            }
            set
            {
                title = value;
                NotifyPropertyChanged(nameof(Title));
            }
        }

        private ICommand buttonNext;
        public ICommand ButtonNext
        {
            get
            {
                return buttonNext ?? (buttonNext = new DelegateCommand(x => ButtonNextMethod(x)));
            }
            set
            {
                buttonNext = value;
            }
        }

        private ICommand buttonBack;
        public ICommand ButtonBack
        {
            get
            {
                return buttonBack ?? (buttonBack = new DelegateCommand(x => ButtonBackMethod(x)));
            }
            set
            {
                buttonBack = value;
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

        private GameControl gameControl;
        public GameControl GameControl
        {
            get
            {
                return gameControl;
            }
            set
            {
                gameControl = value;
                NotifyPropertyChanged(nameof(GameControl));
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

        public GameSettingsViewModel()
        {
        }

        public GameSettingsViewModel(Player tmpPlayer)
        {
            MyPlayer = tmpPlayer;
            Title = "Welcome " + MyPlayer.Nick + "!";
        }

        public void ButtonNextMethod(object sender)
        {
            GameControl = new GameControl();
            TmpWindow = new Window();
            UserControl u1 = new UserControl();
            u1 = (UserControl)sender;
            TmpWindow = Window.GetWindow(u1);
            TmpWindow.Content = GameControl;

        }

        public void ButtonBackMethod(object sender)
        {
            NickControl = new EnterNickControl();
            TmpWindow = new Window();
            UserControl u1 = new UserControl();
            u1 = (UserControl)sender;
            TmpWindow = Window.GetWindow(u1);
            TmpWindow.Content = NickControl;
        }

    }
}

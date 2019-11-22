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
using System.Windows.Navigation;

namespace Shooter.ViewModels
{
    public class EnterNickViewModel : MyNotify
    {
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

        private string playerNick;
        public string PlayerNick
        {
            get
            {
                return playerNick;
            }
            set
            {
                playerNick = value;
                NotifyPropertyChanged(nameof(PlayerNick));
            }
        }

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

        private GameSettingsControl settingsControl;
        public GameSettingsControl SettingsControl
        {
            get
            {
                return settingsControl;
            }
            set
            {
                settingsControl = value;
                NotifyPropertyChanged(nameof(SettingsControl));
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

        public EnterNickViewModel()
        {
            MyPlayer = new Player();
            Title = "Enter nick";
        }

        public void ButtonNextMethod(object sender)
        {
            if (PlayerNick != "" )
            {
                MyPlayer.Nick = PlayerNick;
                SettingsControl = new GameSettingsControl(MyPlayer);
                TmpWindow = new Window();
                UserControl u1 = new UserControl();
                u1 = (UserControl)sender;
                TmpWindow = Window.GetWindow(u1);
                TmpWindow.Content = SettingsControl;

            }
            else
                Title = "Wrong nick";
        }

        public void ButtonBackMethod(object sender)
        {
            MenuControl StartWindow = new MenuControl();
            TmpWindow = new Window();
            UserControl u1 = new UserControl();
            u1 = (UserControl)sender;
            TmpWindow = Window.GetWindow(u1);
            TmpWindow.Content = StartWindow;
        }
    }
}

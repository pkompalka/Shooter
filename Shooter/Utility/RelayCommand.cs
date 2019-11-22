using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Shooter
{
    public class DelegateCommand : ICommand
    {
        #region Variables and Properties
        /// <summary>
        /// Can execute delegate.
        /// </summary>
        public Predicate<object> CanExecuteDelegate { get; set; }
        /// <summary>
        /// Execute delegate.
        /// </summary>
        public Action<object> ExecuteDelegate { get; set; }

        protected bool isExecuting;
        /// <summary>
        /// Occurs when the command is executing.
        /// </summary>
        public bool IsExecuting
        {
            get
            {
                return isExecuting;
            }
            private set
            {
                isExecuting = value;
            }
        }
        /// <summary>
        /// Occurs when changes occur that affect whether or not the command should execute.
        /// </summary>
        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }
        #endregion

        /// <summary>
        /// Creates a new instance of a <see cref="DelegateCommand"/>.
        /// </summary>
        /// <param name="execute">The execute.</param>
        /// <param name="canExecute">The can execute.</param>
        public DelegateCommand(Action<object> execute, Predicate<object> canExecute = null)
        {
            isExecuting = false;
            this.CanExecuteDelegate = canExecute;
            this.ExecuteDelegate = execute ?? throw new ArgumentNullException("Execute");
        }

        /// <summary>
        /// Raises the <see cref="CanExecuteChanged" /> event.
        /// </summary>
        public void OnCanExecuteChanged()
        {
            CommandManager.InvalidateRequerySuggested();
        }

        /// <summary>
        /// Defines the method that determines whether the command can execute in its current state.
        /// </summary>
        /// <param name="parameter">Data used by the command.  If the command does not require data to be passed, this object can be set to null.</param>
        /// <returns>
        /// true if this command can be executed; otherwise, false.
        /// </returns>
        public virtual bool CanExecute(object parameter)
        {
            return (CanExecuteDelegate != null) ? (!IsExecuting && CanExecuteDelegate(parameter)) : !IsExecuting;
        }

        /// <summary>
        /// Defines the method to be called when the command is invoked.
        /// </summary>
        /// <param name="parameter">Data used by the command.  If the command does not require data to be passed, this object can be set to null.</param>
        public virtual void Execute(object parameter)
        {
            try
            {
                IsExecuting = true;
                OnExecute(parameter);
            }
            finally
            {
                IsExecuting = false;
                OnCanExecuteChanged();
            }
        }

        /// <summary>
        /// Executes the command.
        /// </summary>
        /// <param name="parameter">The parameter.</param>
        protected void OnExecute(object parameter)
        {
            ExecuteDelegate(parameter);
        }
    }
}

using System;
using System.Collections.Generic;

namespace Command.Sample
{
    public class MacroCommand: ICommand
    {
        private Stack<ICommand> Commands;

        public void Execute()
        {
            foreach(var command in Commands)
            {
                command.Execute();
            }
        }

        public void Append(ICommand command)
        {
            if (command != this)
            {
                Commands.Push(command);
            }
        }

        public void Undo()
        {
            if (Commands.Count != 0)
            {
                Commands.Pop();
            }
        }

        public void Clear()
        {
            Commands.Clear();
        }
    }
}

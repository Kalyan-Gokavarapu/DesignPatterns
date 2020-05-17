using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern
{
  class Calculator
  {
    public int val;
    public List<ICommand> history = new List<ICommand>();
    public Calculator()
    {
      this.val = 0;
    }
    public void executeCommand(ICommand cmd)
    {
      this.val = cmd.execute(this.val);
      this.history.Add(cmd);
    }

    public void undo()
    {
      ICommand cmd = this.history[this.history.Count - 1];
      this.history.RemoveAt(this.history.Count - 1);
      this.val = cmd.undo(this.val);
    }
  }
}

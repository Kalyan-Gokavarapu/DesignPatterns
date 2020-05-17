namespace CommandPattern
{
    class SubCommand : ICommand
    {
      int _valueToAdd;
      public SubCommand(int valueToAdd)
      {
        this._valueToAdd = valueToAdd;
      }

      public int execute(int val)
      {
        return val - this._valueToAdd;
      }

      public int undo(int val)
      {
        return this._valueToAdd + val;
      }

    }
}

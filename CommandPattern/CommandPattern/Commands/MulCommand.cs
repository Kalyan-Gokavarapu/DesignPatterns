namespace CommandPattern
{
    class MulCommand : ICommand
    {
      int _valueToAdd;
      public MulCommand(int valueToAdd)
      {
        this._valueToAdd = valueToAdd;
      }

      public int execute(int val)
      {
        return val * this._valueToAdd;
      }

      public int undo(int val)
      {
        return  val / this._valueToAdd;
      }

    }
}

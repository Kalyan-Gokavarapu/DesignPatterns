namespace CommandPattern
{
    interface ICommand
    {
      int execute(int val);
      int undo(int val);      
    }
}

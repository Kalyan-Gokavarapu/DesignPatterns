using System;
using System.Collections.Generic;

namespace CommandPattern
{
  partial class Program
  {
    static void Main(string[] args)
    {
      //Calculator myCal = new Calculator();
      //myCal.add(10);
      //myCal.add(10);
      //Console.WriteLine(myCal.val);


      //AddCommand cmd = new AddCommand(10);
      //Console.WriteLine(cmd.execute(10));

      Calculator myCal = new Calculator();
      myCal.executeCommand(new AddCommand(10));
      myCal.executeCommand(new AddCommand(30));
      myCal.executeCommand(new MulCommand(10));
      myCal.executeCommand(new MulCommand(10));     
      myCal.undo();

      Console.WriteLine(myCal.val);

      Console.Read();
    }

    //class AddCommandThenMul : ICommand
    //{
    //  int _valueToAdd;
    //  public AddCommandThenMul(int valueToAddthenMul)
    //  {
    //    this._valueToAdd = valueToAddthenMul;
    //  }

    //  public int execute(int val)
    //  {
    //    return val + this._valueToAdd;
    //  }

    //  public int undo(int val)
    //  {
    //    return this._valueToAdd - val;
    //  }

    //}
  }
}

using System;
using System.Reflection;

public class TrameEventArgs : EventArgs
{
    public string Datas { get; private set; }

    public TrameEventArgs(string datas)
    {
        this.Datas = datas;
    }
}
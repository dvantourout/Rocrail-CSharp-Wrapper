using System;
using System.Reflection;

public class ElementEventArgs : EventArgs
{
    public object Element { get; private set; }
    public string ElementName { get; private set; }
    public string ID { get; private set; }

    public ElementEventArgs(object element, string elementName, string id)
    {
        this.Element = element;
        this.ElementName = elementName;
        this.ID = id;
    }
}
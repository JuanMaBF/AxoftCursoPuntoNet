using System;
using DelegadosEventosCS;
public class Form1
{
    public Form1()
    {
        // Add Button1_Click as an event handler for Button1's Click event
        Button1.Click += new DelegadosEventosCS.EventHandler(Button1_Click);
    }
    Button Button1 = new Button();
    void Button1_Click(object sender, EventArgs e)
    {
        Console.WriteLine("Button1 was clicked!");
    }
    public void Disconnect()
    {
        Button1.Click -= new DelegadosEventosCS.EventHandler(Button1_Click);
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Note_Phong.Utils
{
    public class MyEventArgs : EventArgs
    {
        public MyEventArgs()
        {
        }
        public MyEventArgs(string name, int id)
        {
            this.Name = name;
            this.Id = id;
        }
        public string Name{get; set;}
        public int Id { get; set;}
    }
}

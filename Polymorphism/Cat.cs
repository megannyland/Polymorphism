using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms; //needed for MessageBox

namespace Polymorphism
{
    class Cat : Animal
    {
        //Field
        private string _name;

        // constructor
        public Cat(string name)
            : base("Cat")
        {
            _name = name;
        }
         //name property
         public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        //makesound method
        public override void MakeSound()
        {
            MessageBox.Show("Meow");
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Polymorphism
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //the ShowAnimalInfo method accepts an Animal
        //object as an argument. it displays the object's
        //species and calls its makesound method
        private void ShowAnimalInfo (Animal animal)
        {
            MessageBox.Show("Species:" + animal.Species);
            animal.MakeSound();
        }
        private void createAnimaButton_click(object sender, EventArgs e)
        {
            Animal myAnimal = new Animal("regular animal");
            ShowAnimalInfo(myAnimal);
        }
        private void createDogButton_click(object sender, EventArgs e)
        {
            Dog myDog = new Dog("Fido");
            MessageBox.Show("The dog's name is" + myDog.Name);
            ShowAnimalInfo(myDog);
        }
        private void createCatButton_click(object sender, EventArgs e)
        {
            Cat myCat = new Cat("Kitty");
            MessageBox.Show("The cat's name is" + myCat.Name);
            ShowAnimalInfo(myCat);
        }

        private void exitButton_Click(object sender,EventArgs e)
        {
            //close the form
            this.Close();
        }

    }
}

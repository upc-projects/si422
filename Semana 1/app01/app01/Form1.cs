using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app01
{
    public partial class Form1 : Form
    {
        List<Dog> dog_list = new List<Dog>();
        public Form1()
        {
            InitializeComponent();
            Animal a = new Animal();
            int rnumber = a.GenerateRandomCode();
            lbl_code.Text = rnumber.ToString();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            var dog_code = Int32.Parse(lbl_code.Text);
            var dog_name = tbox_name.Text;
            var dog_race = cbox_race.Text;
            var dog_weight = Double.Parse(tbox_weight.Text);
            var dog_size = Double.Parse(tbox_size.Text);
            var dog_age = Int32.Parse(tbox_age.Text);

            Console.WriteLine(dog_code.ToString(), dog_name, dog_race, dog_size, dog_weight, dog_age);

            Dog dog = new Dog(dog_code,dog_name,dog_race,dog_size,dog_weight,dog_age);
            var listviewitem = new ListViewItem();
            listviewitem.SubItems.Add(dog.Name);
            listviewitem.SubItems.Add(dog.Age.ToString());
            listviewitem.SubItems.Add(dog.Size.ToString());
            listviewitem.SubItems.Add(dog.Weight.ToString());
            listviewitem.SubItems.Add(dog.Race.ToString());
            listviewitem.SubItems.Add(dog.Code.ToString());

            list_view_animals.Items.Add(listviewitem);
            dog_list.Add(dog);
            int rnumber = dog.GenerateRandomCode();
            lbl_code.Text = rnumber.ToString();
            CleanUp();

        }


        public void CleanUp()
        {
            tbox_age.Clear();
            tbox_name.Clear();
            tbox_size.Clear();
            tbox_weight.Clear();
            cbox_race.SelectedIndex = -1;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}

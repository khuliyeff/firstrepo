using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sinema_App
{
    public partial class Cinema : Form
    {
        public Cinema()
        {
            InitializeComponent();
        }

        public int Selected { get; private set; }

        private void Cinema_Load(object sender, EventArgs e)
        {
            var kino = new Cinemaa(1, "Sadece Sen",  "21:00");
            var kino2 = new Cinemaa(2, "Grey Wolf",  "19:45");
            var kino3 = new Cinemaa(3,"A Ghost Story", "14:00");
            var kino4 = new Cinemaa(4,"Mudbound",  "16:30");
            var kino5 = new Cinemaa(5, " Dunkirk", "12:30");
            for (int i = 1; i < 21; i++)
            {
                poeple_box.Items.Add(i);
            }
               
            
            foreach (var item in Cinemaa.list_data)
            {
                CinameName_box.Items.Add(item.Name);               
                CinemaData_Box.Items.Add(item.Data);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            var sel_item = Convert.ToInt32(poeple_box.SelectedItem);
            price_show_box.Text = Convert.ToString(sel_item * 6);
        }

        private void button1_Click(object sender, EventArgs e)
        {           
            var rezerve = new Rezerv();
            rezerve.Show();
        }

        private void poeple_box_SelectedIndexChanged(object sender, EventArgs e)
        {
            var sel_item = Convert.ToInt32(poeple_box.SelectedItem);
            price_show_box.Text = Convert.ToString(sel_item *  5);
        }
    }
    public class Cinemaa
    {
        public static List<Cinemaa> list_data = new List<Cinemaa>();
        public int Id;
        public string Name;      
        public string Data;
        public Cinemaa(int _id,string _name,  string _data)
        {
            Id = _id;
            Name = _name;          
            Data = _data;
            list_data.Add(this);

        }
        

    }
   
}

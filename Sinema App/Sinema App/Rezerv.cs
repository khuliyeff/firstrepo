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
    public partial class Rezerv : Form
    {
        
        public int cergesirasi = 20;
        public static List<Button> buttonlist = new List<Button>();
        public Rezerv()
        {
            int count = 1;
            InitializeComponent();
            for (int i = 0; i < 7; i++)
            {

                for (int j = 0; j < 7; j++)
                {
                    var btn = new Button();
                    btn.Left = j * 55;
                    btn.Top =  i* 55;
                    btn.Width = 50;
                    btn.Height = 50;
                    btn.Text = count.ToString();
                    Controls.Add(btn);
                    count++;
                    btn.Click += new EventHandler(this.ClickMe);
                    
                }
            }

            

        }
        void ClickMe(object sender, EventArgs e)
        {
            var myBtn = sender as Button;
            



            if (myBtn.BackColor==Color.Yellow)
            {
                MessageBox.Show("Rezerv");
               
            }
            else
            {
                myBtn.BackColor = Color.Blue;
                buttonlist.Add(myBtn);
            }
           
            
            
        }
        private void Rezerv_Load(object sender, EventArgs e)
        {

        }

        private void Rezerv_Btn_Click(object sender, EventArgs e)
        {
            foreach (var item in buttonlist)
            {
                item.BackColor = Color.Yellow;
            }
        }
    }
}

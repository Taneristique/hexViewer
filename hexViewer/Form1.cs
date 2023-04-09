using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace hexViewer
{ 
    public partial class Form1 : Form
    {
        string path;
        ByteViewer bv;
        private bool checkIfAnyFileSelected; //use it to check if already a path parameter given 
        OpenFileDialog fileSearcher;
        public Form1()
        {
            InitializeComponent();
            this.Text = "HEX Viewer By TaNeRiStIqUe";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(Form1Closed);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkIfAnyFileSelected)  
            {
                /*
                  reinitilise ByteViewer and OpenFileDialog objects each time 
                  each time user requested a new path. 
                 */
                fileSearcher.Dispose();
                Controls.Remove(bv);
            }
            
             fileSearcher = new OpenFileDialog();           
         
            if (fileSearcher.ShowDialog()== System.Windows.Forms.DialogResult.OK)
            {   
                path= fileSearcher.FileName;
                label1.Visible = false;
                bv = new ByteViewer();
                bv.SetFile(@path);
                Controls.Add(bv);
                checkIfAnyFileSelected = true;
            }
        }
       private void Form1Closed(object sender, EventArgs e)
        {
            MessageBox.Show("Thank you very much for using my application😊If you want to support me, here is my bitcoin address  bc1qlxuf6n0sqhqjmekys24uswps6gj4srln4rp6f4\nOnly send btc to it from BTC(SegWit) network.");
        }
    }
}

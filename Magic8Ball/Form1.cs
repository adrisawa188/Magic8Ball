using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Magic8Ball
{

    public partial class Form1 : Form
    {
        Random randGen = new Random();
        
       

       
        public Form1()   
        {
            InitializeComponent();  
            
        }

        private void inputButton_Click(object sender, EventArgs e)
        {
            int randomValue;
            randomValue = randGen.Next(1, 7);

            switch (Convert.ToString (randomValue))
            {
                case "1":
                    outputLabel.Text = "Very Likely"; 
                    break;
                case "2":
                    outputLabel.Text = "Yes";
                    break;
                case "3":
                    outputLabel.Text = "No";
                    break;
                case "4":
                    outputLabel.Text = "Very Doubtful";
                    break;
                case "5":
                    outputLabel.Text = "It Is Certain";
                    break;
                case "6":
                    outputLabel.Text = "Don't Count On It";
                    break;






            }
        }
    }
}

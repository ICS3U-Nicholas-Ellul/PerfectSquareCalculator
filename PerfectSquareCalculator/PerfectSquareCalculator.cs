/*
 * Created by: Nicholas Ellul
 * Created on: 13-Oct-2015
 * Created for: ICS3U
 * Daily Assignment – Unit 3-09
 * This program lists perfect squares up to a certain number.
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PerfectSquareCalculator
{
    public partial class frmPerfectSquareCalculator : Form
    {
        public frmPerfectSquareCalculator()
        {
            InitializeComponent();
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            //input
            int inputValue = Convert.ToInt32(this.nudInput.Value);
            int counter = 0;
            double squareRootAsDouble;
            int squareRootAsInt;

            //process
            this.lstOutput.Items.Clear();
            while (counter <= inputValue)
            {
                squareRootAsDouble = Math.Sqrt(counter);
                squareRootAsInt = Convert.ToInt32(squareRootAsDouble);

                if (squareRootAsDouble == squareRootAsInt)
                {
                    //output
                    this.lstOutput.Items.Add(counter);


                }

                counter++;
            }
           
        }

        private void mniExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

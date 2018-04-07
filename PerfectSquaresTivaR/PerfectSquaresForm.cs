using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
 * Created by: Tiva Rait
 * Created on: 04-06-2018
 * Created for: ICS3U Programming
 * Daily Assignment – Day #21 - Perfect Squares
 * This program allows you to select a number and then it...
 * ...calculates all of the square roots up until that number.
*/

namespace PerfectSquaresTivaR
{
    public partial class frmPerfectSquares : Form
    {
        public frmPerfectSquares()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            // Declare Variables
            int endingValue;
            int value;
            Double squareRootAsDouble;
            int squareRootAsInteger;

            // Setting the values to 1
            value = 0;

            // Clear all the items from the list box
            this.lstSquares.Items.Clear();

            // Get the user's end value from the number up-down box
            endingValue = Convert.ToInt32(this.nudEndValue.Value);

            // State any perfect squares between the min value and selected value
            while (value <= endingValue)
            {
                // Increment value by 1
                value += 1;

                // Take the square root of the value
                squareRootAsDouble = Math.Sqrt(value);

                // Convert the double to an integer
                squareRootAsInteger = Convert.ToInt32(squareRootAsDouble);

                // The only way they can equal is if there are no decimals
                if (squareRootAsInteger == squareRootAsDouble)
                {
                    this.lstSquares.Items.Add(value + " is a perfect square");
                    this.Refresh();
                }
            }
   
        }
    }
}

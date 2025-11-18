using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Backprop;


namespace BackPropagation
{
    public partial class Form1 : Form
    {

        NeuralNet nn;
        public Form1()
        {
            InitializeComponent();
        }

        private void createNeuralNetBtnClick(object sender, EventArgs e)
        {
            // nn = new NeuralNet(2,100,1); // for OR function
            nn = new NeuralNet(4, 300, 1); // for AND function
                             // ^ input, hidden, output neurons
        }

        private void trainNeuralNetBtnClick(object sender, EventArgs e)
        {
            // Training for OR function
            /*
            for (int x = 0; x < 100; x++)
            {
                nn.setInputs(0, 0.0);
                nn.setInputs(1, 0.0);
                nn.setDesiredOutput(0, 0.0);
                nn.learn();

                nn.setInputs(0, 0.0);
                nn.setInputs(1, 1.0);
                nn.setDesiredOutput(0, 1.0);
                nn.learn();

                nn.setInputs(0, 1.0);
                nn.setInputs(1, 0.0);
                nn.setDesiredOutput(0, 1.0);
                nn.learn();

                nn.setInputs(0, 1.0);
                nn.setInputs(1, 1.0);
                nn.setDesiredOutput(0, 1.0);
                nn.learn();
            }
            */

            // Training for AND function

            // 1. the 16-combination of 4-inputs
            int[,] inputs = new int[,]
            {
                    {0,0,0,0},
                    {0,0,0,1},
                    {0,0,1,0},
                    {0,0,1,1},
                    {0,1,0,0},
                    {0,1,0,1},
                    {0,1,1,0},
                    {0,1,1,1},
                    {1,0,0,0},
                    {1,0,0,1},
                    {1,0,1,0},
                    {1,0,1,1},
                    {1,1,0,0},
                    {1,1,0,1},
                    {1,1,1,0},
                    {1,1,1,1},
            };

            double[] outputs = new double[]
            {
                0,0,0,0,
                0,0,0,0,
                0,0,0,0,
                0,0,0,
                1   // Only the last case (1111) is 1
            };


            // 2. Train the model as we loop through the 16 combinations
            for (int epoch = 0; epoch < 100; epoch++) { 
                for (int i = 0; i < 16; i++) 
                {
                    nn.setInputs(0, inputs[i, 0]);
                    nn.setInputs(1, inputs[i, 1]);
                    nn.setInputs(2, inputs[i, 2]);
                    nn.setInputs(3, inputs[i, 3]);

                    nn.setDesiredOutput(0, outputs[i]);
                    nn.learn();
                }
            }

        }

        private void testBtnClick(object sender, EventArgs e)
        {

            // Testing for OR function
            /*
            nn.setInputs(0, Convert.ToDouble(textBox1.Text));
            nn.setInputs(1, Convert.ToDouble(textBox2.Text));
            nn.run();
            */

            // Testing for AND function
            nn.setInputs(0, Convert.ToDouble(input1.Text));
            nn.setInputs(1, Convert.ToDouble(input2.Text));
            nn.setInputs(2, Convert.ToDouble(input3.Text));
            nn.setInputs(3, Convert.ToDouble(input4.Text));


            outputN.Text = "" + nn.getOuputData(0); // convert to string
        }
    }
}

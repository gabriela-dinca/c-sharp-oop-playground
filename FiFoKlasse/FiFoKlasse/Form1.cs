using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FiFoKlasse
{
    public partial class Form1 : Form
    {
        FiFo FiFoBuffer = new FiFo();
        public Form1()
        {
            InitializeComponent();
        }

        private void btbWriteValueInFiFo_Click(object sender, EventArgs e)
        {
            int input;
            try
            {
                input = Convert.ToInt32(tbValueToWrite.Text);
                FiFoBuffer.WriteValue(input);
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }

            DisplayBuffer();
            DisplayFiFo();
        }

        private void DisplayFiFo()
        {
            tbHead.Text = FiFoBuffer.Head.ToString();
            tbTail.Text = FiFoBuffer.Tail.ToString();
            tbSize.Text = FiFoBuffer.Size.ToString();
            tbState.Text = FiFoBuffer.IsFull == true ? "FiFo-Buffer voll" : "FiFo-Buffer leer";
            tbMax.Text = FiFoBuffer.Max.ToString();
            tbMin.Text = FiFoBuffer.Min.ToString();

            int[] FiFoValues = FiFoBuffer.Values;
            lbFiFo.Items.Clear();
            foreach (int value in FiFoValues)
            {
                lbFiFo.Items.Add(value.ToString());
            }

        }

        private void DisplayBuffer()
        {
            if (FiFoBuffer.Head > -1)
            {
                lbSortedFiFo.Items.Clear();
                int[] sortedFiFoValues = FiFoBuffer.ReadSortedFiFo();
                foreach (int value in sortedFiFoValues)
                {
                    lbSortedFiFo.Items.Add(value.ToString());
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            FiFoBuffer.Clear();
        }
    }
}

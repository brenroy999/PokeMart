using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PokeMart
{
    public partial class Form1 : Form
    {
        //Final Calculation Slots
        int slot1Price = 0;
        int slot2Price = 0;
        int slot3Price = 0;
        int slot4Price = 0;
        int slot5Price = 0;
        int slot6Price = 0;
        int slot7Price = 0;
        int slot8Price = 0;
        int slot9Price = 0;
        int slot10Price = 0;
        int slot11Price = 0;
        int slot12Price = 0;
        int slot13Price = 0;

        const double TAXES = 0.13;

        double subTotal, totalWithTax;

        public Form1()
        {
            InitializeComponent();
        }

        private void martLocation_SelectedItemChanged(object sender, EventArgs e)
        { 
            if (martLocation.SelectedIndex == 0) //Oldale Town
            {
                //Items
                labelSlot1.Text = "Poké Ball";
                slot1Amount.Value = 0;
                slot1Price = 200;

                labelSlot2.Text = "Potion";
                slot2Amount.Value = 0;
                slot2Price = 100;

                labelSlot3.Text = "Antidote";
                slot3Amount.Value = 0;
                slot3Price = 100;

                labelSlot4.Text = "Parlyz Heal";
                slot4Amount.Value = 0;
                slot4Price = 200;

                labelSlot5.Text = "Awakening";
                slot5Amount.Value = 0;
                slot5Price = 200;

                labelSlot6.Visible = false;
                slot6Amount.Visible = false;
                slot6Amount.Value = 0;

                labelSlot7.Visible = false;
                slot7Amount.Visible = false;
                slot7Amount.Value = 0;

                labelSlot8.Visible = false;
                slot8Amount.Visible = false;
                slot8Amount.Value = 0;

                labelSlot9.Visible = false;
                slot9Amount.Visible = false;
                slot9Amount.Value = 0;

                labelSlot10.Visible = false;
                slot10Amount.Visible = false;
                slot10Amount.Value = 0;

                labelSlot11.Visible = false;
                slot11Amount.Visible = false;
                slot11Amount.Value = 0;

                labelSlot12.Visible = false;
                slot12Amount.Visible = false;
                slot12Amount.Value = 0;

                labelSlot13.Visible = false;
                slot13Amount.Visible = false;
                slot13Amount.Value = 0;


                debugLabel.Text ="Location Changed to Oldale";

                this.Height = 655;
                Thread.Sleep(400);
                Refresh();
            }

            if (martLocation.SelectedIndex == 1) //Petalburg City
            {
                //Items
                labelSlot1.Text = "Poké Ball";
                slot1Amount.Value = 0;
                slot1Price = 200;

                labelSlot2.Text = "Potion";
                slot2Amount.Value = 0;
                slot2Price = 100;

                labelSlot3.Text = "Antidote";
                slot3Amount.Value = 0;
                slot3Price = 100;

                labelSlot4.Text = "Parlyz Heal";
                slot4Amount.Value = 0;
                slot4Price = 200;

                labelSlot5.Text = "Awakening";
                slot5Amount.Value = 0;
                slot5Price = 200;

                labelSlot6.Text = "Great Ball";
                slot6Amount.Value = 0;
                slot6Price = 600;

                labelSlot7.Text = "Super Potion";
                slot7Amount.Value = 0;
                slot7Price = 700;

                labelSlot8.Text = "Escape Rope";
                slot8Amount.Value = 0;
                slot8Price = 550;

                labelSlot9.Text = "Repel";
                slot9Amount.Value = 0;
                slot9Price = 250;

                labelSlot10.Text = "X Speed";
                slot10Amount.Value = 0;
                slot10Price = 350;

                labelSlot11.Text = "X Attack";
                slot11Amount.Value = 0;
                slot11Price = 500;

                labelSlot12.Text = "X Defend";
                slot12Amount.Value = 0;
                slot12Price = 550;

                labelSlot13.Text = "Orange Mail";
                slot13Amount.Value = 0;
                slot13Price = 50;

                labelSlot6.Visible = true;
                slot6Amount.Visible = true;

                labelSlot7.Visible = true;
                slot7Amount.Visible = true;

                labelSlot8.Visible = true;
                slot8Amount.Visible = true;

                labelSlot9.Visible = true;
                slot9Amount.Visible = true;

                labelSlot10.Visible = true;
                slot10Amount.Visible = true;

                labelSlot11.Visible = true;
                slot11Amount.Visible = true;

                labelSlot12.Visible = true;
                slot12Amount.Visible = true;

                labelSlot13.Visible = true;
                slot13Amount.Visible = true;


                debugLabel.Text = "Location Changed to Petalburg";
            }

            if (martLocation.SelectedIndex == 2)
            {
                //Items
                labelSlot1.Text = "Poké Ball";
                slot1Amount.Value = 0;
                slot1Price = 200;

                labelSlot2.Text = "Potion";
                slot2Amount.Value = 0;
                slot2Price = 100;

                labelSlot3.Text = "Antidote";
                slot3Amount.Value = 0;
                slot3Price = 100;

                labelSlot4.Text = "Parlyz Heal";
                slot4Amount.Value = 0;
                slot4Price = 200;

                labelSlot5.Text = "Awakening";
                slot5Amount.Value = 0;
                slot5Price = 200;

                labelSlot6.Text = "Great Ball";
                slot6Amount.Value = 0;
                slot6Price = 600;

                labelSlot7.Text = "Super Potion";
                slot7Amount.Value = 0;
                slot7Price = 700;

                labelSlot8.Text = "Escape Rope";
                slot8Amount.Value = 0;
                slot8Price = 550;

                labelSlot9.Text = "Repel";
                slot9Amount.Value = 0;
                slot9Price = 250;

                labelSlot10.Text = "X Speed";
                slot10Amount.Value = 0;
                slot10Price = 350;

                labelSlot11.Text = "X Attack";
                slot11Amount.Value = 0;
                slot11Price = 500;

                labelSlot12.Text = "X Defend";
                slot12Amount.Value = 0;
                slot12Price = 550;

                labelSlot13.Text = "Orange Mail";
                slot13Amount.Value = 0;
                slot13Price = 50;

                labelSlot6.Visible = true;
                slot6Amount.Visible = true;

                labelSlot7.Visible = true;
                slot7Amount.Visible = true;

                labelSlot8.Visible = true;
                slot8Amount.Visible = true;

                labelSlot9.Visible = true;
                slot9Amount.Visible = true;

                labelSlot10.Visible = true;
                slot10Amount.Visible = true;

                labelSlot11.Visible = true;
                slot11Amount.Visible = true;

                labelSlot12.Visible = true;
                slot12Amount.Visible = true;

                labelSlot13.Visible = true;
                slot13Amount.Visible = true;

                debugLabel.Text = "Location Changed to Rustboro";
            }


        }

        private void drawDates(Graphics graphics)
        {
            Graphics g = this.CreateGraphics();
            SolidBrush BlueBrush = new SolidBrush(Color.Blue);
            SolidBrush WhiteBrush = new SolidBrush(Color.White);
            //Title Bar
            g.FillRectangle(BlueBrush, 0, 0, 600, 70);
            g.FillEllipse(WhiteBrush, 5, 5, 60, 60);
            g.FillEllipse(BlueBrush, 17, 17, 36, 36);
            g.FillRectangle(BlueBrush, 0, 32, 70, 6);
            g.FillEllipse(WhiteBrush, 23, 23, 24, 24);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            drawDates(e.Graphics);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Height = (109);
            this.Width = (460);

           // SoundPlayer martMusic = new SoundPlayer(Properties.Resources.PokeMart);
           // martMusic.PlayLooping();
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            double item1 = Convert.ToDouble(slot1Amount.Value) * (slot1Price);
            double item2 = Convert.ToDouble(slot2Amount.Value) * (slot2Price);
            double item3 = Convert.ToDouble(slot3Amount.Value) * (slot3Price);
            double item4 = Convert.ToDouble(slot3Amount.Value) * (slot4Price);
            double item5 = Convert.ToDouble(slot3Amount.Value) * (slot5Price);
            double item6 = Convert.ToDouble(slot3Amount.Value) * (slot6Price);
            double item7 = Convert.ToDouble(slot3Amount.Value) * (slot7Price);
            double item8 = Convert.ToDouble(slot3Amount.Value) * (slot8Price);
            double item9 = Convert.ToDouble(slot3Amount.Value) * (slot9Price);
            double item10 = Convert.ToDouble(slot3Amount.Value) * (slot10Price);
            double item11 = Convert.ToDouble(slot3Amount.Value) * (slot11Price);
            double item12 = Convert.ToDouble(slot3Amount.Value) * (slot12Price);
            double item13 = Convert.ToDouble(slot3Amount.Value) * (slot13Price);


            subTotal = (item1 + item2 + item3 + item4 + item5 + item6 + item7 + item8 + item9 + item10 + item11 + item12+ item13);

            double amountOfTaxes = subTotal * TAXES;
            totalWithTax = subTotal + amountOfTaxes;

            labelCalculation.Text = "Order Subtotal: " + subTotal +
                                    "\nTaxes: " + amountOfTaxes +
                                    "\n----------------------------------------" +
                                    "\n\nTotal Price: " + (totalWithTax);
        }

        private void buttonPay_Click(object sender, EventArgs e)
        {

            this.Width = 600;
            Refresh();

            Graphics A = this.CreateGraphics();
            SolidBrush blackBrush = new SolidBrush(Color.Black);
            SolidBrush whiteBrush = new SolidBrush(Color.White);
            Font receiptFont = new Font("Courier New", 10, FontStyle.Bold);

            A.FillRectangle(blackBrush, 348, 84, 220, 390);
            A.FillRectangle(whiteBrush, 349, 85, 218, 388);



            int y = 90;

            A.DrawString("PokéMart Online" +
                       "\nOrdering Service" + "\n", receiptFont, blackBrush, 355, y);

            y = 110;

            if (slot1Amount.Value != 0)
            {
                y += 20;
                A.DrawString("\n" + labelSlot1.Text + " x" + slot1Amount.Value + " @ " + slot1Price, receiptFont, blackBrush, 355, y);
            }

            if (slot2Amount.Value != 0)
            {
                y += 20;
                A.DrawString("\n" + labelSlot2.Text + " x" + slot2Amount.Value + " @ " + slot2Price, receiptFont, blackBrush, 355, y);
            }

            if (slot3Amount.Value != 0)
            {
                y += 20;
                A.DrawString("\n" + labelSlot3.Text + " x" + slot3Amount.Value + " @ " + slot3Price, receiptFont, blackBrush, 355, y);
            }

            if (slot4Amount.Value != 0)
            {
                y += 20;
                A.DrawString("\n" + labelSlot4.Text + " x" + slot4Amount.Value + " @ " + slot4Price, receiptFont, blackBrush, 355, y);
            }

            if (slot5Amount.Value != 0)
            {
                y += 20;
                A.DrawString("\n" + labelSlot5.Text + " x" + slot5Amount.Value + " @ " + slot5Price, receiptFont, blackBrush, 355, y);
            }

            if (slot6Amount.Value != 0)
            {
                y += 20;
                A.DrawString("\n" + labelSlot6.Text + " x" + slot6Amount.Value + " @ " + slot6Price, receiptFont, blackBrush, 355, y);
            }

            if (slot7Amount.Value != 0)
            {
                y += 20;
                A.DrawString("\n" + labelSlot7.Text + " x" + slot7Amount.Value + " @ " + slot7Price, receiptFont, blackBrush, 355, y);
            }

            if (slot8Amount.Value != 0)
            {
                y += 20;
                A.DrawString("\n" + labelSlot8.Text + " x" + slot8Amount.Value + " @ " + slot8Price, receiptFont, blackBrush, 355, y);
            }

            if (slot9Amount.Value != 0)
            {
                y += 20;
                A.DrawString("\n" + labelSlot9.Text + " x" + slot9Amount.Value + " @ " + slot9Price, receiptFont, blackBrush, 355, y);
            }

            if (slot10Amount.Value != 0)
            {
                y += 20;
                A.DrawString("\n" + labelSlot10.Text + " x" + slot10Amount.Value + " @ " + slot10Price, receiptFont, blackBrush, 355, y);
            }

            if (slot11Amount.Value != 0)
            {
                y += 20;
                A.DrawString("\n" + labelSlot11.Text + " x" + slot11Amount.Value + " @ " + slot11Price, receiptFont, blackBrush, 355, y);
            }

            if (slot12Amount.Value != 0)
            {
                y += 20;
                A.DrawString("\n" + labelSlot12.Text + " x" + slot12Amount.Value + " @ " + slot12Price, receiptFont, blackBrush, 355, y);
            }

            if (slot13Amount.Value != 0)
            {
                y += 20;
                A.DrawString("\n" + labelSlot13.Text + " x" + slot13Amount.Value + " @ " + slot13Price, receiptFont, blackBrush, 355, y);
            }
        }
    }
}

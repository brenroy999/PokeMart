namespace PokeMart
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.martLocation = new System.Windows.Forms.DomainUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.slot1Amount = new System.Windows.Forms.NumericUpDown();
            this.labelSlot1 = new System.Windows.Forms.Label();
            this.labelSlot2 = new System.Windows.Forms.Label();
            this.slot2Amount = new System.Windows.Forms.NumericUpDown();
            this.slot3Amount = new System.Windows.Forms.NumericUpDown();
            this.labelSlot3 = new System.Windows.Forms.Label();
            this.slot5Amount = new System.Windows.Forms.NumericUpDown();
            this.labelSlot5 = new System.Windows.Forms.Label();
            this.slot4Amount = new System.Windows.Forms.NumericUpDown();
            this.labelSlot4 = new System.Windows.Forms.Label();
            this.debugLabel = new System.Windows.Forms.Label();
            this.slot6Amount = new System.Windows.Forms.NumericUpDown();
            this.labelSlot6 = new System.Windows.Forms.Label();
            this.slot12Amount = new System.Windows.Forms.NumericUpDown();
            this.labelSlot12 = new System.Windows.Forms.Label();
            this.slot10Amount = new System.Windows.Forms.NumericUpDown();
            this.labelSlot10 = new System.Windows.Forms.Label();
            this.slot11Amount = new System.Windows.Forms.NumericUpDown();
            this.labelSlot11 = new System.Windows.Forms.Label();
            this.slot9Amount = new System.Windows.Forms.NumericUpDown();
            this.labelSlot9 = new System.Windows.Forms.Label();
            this.slot8Amount = new System.Windows.Forms.NumericUpDown();
            this.labelSlot8 = new System.Windows.Forms.Label();
            this.labelSlot7 = new System.Windows.Forms.Label();
            this.slot7Amount = new System.Windows.Forms.NumericUpDown();
            this.slot13Amount = new System.Windows.Forms.NumericUpDown();
            this.labelSlot13 = new System.Windows.Forms.Label();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.buttonPay = new System.Windows.Forms.Button();
            this.labelCalculation = new System.Windows.Forms.Label();
            this.textBoxTender = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.labelError = new System.Windows.Forms.Label();
            this.buttonOrderRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.slot1Amount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slot2Amount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slot3Amount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slot5Amount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slot4Amount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slot6Amount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slot12Amount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slot10Amount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slot11Amount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slot9Amount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slot8Amount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slot7Amount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slot13Amount)).BeginInit();
            this.SuspendLayout();
            // 
            // martLocation
            // 
            this.martLocation.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.martLocation.Items.Add("Oldale Town");
            this.martLocation.Items.Add("Petalburg City");
            this.martLocation.Items.Add("Rustboro City");
            this.martLocation.Items.Add("Slateport City");
            this.martLocation.Items.Add("Mauville City");
            this.martLocation.Items.Add("Verdanturf Town");
            this.martLocation.Items.Add("Fallabor Town");
            this.martLocation.Items.Add("Lavaridge Town");
            this.martLocation.Items.Add("Fortree City");
            this.martLocation.Items.Add("Mossdeep City");
            this.martLocation.Items.Add("Sootopolis City");
            this.martLocation.Items.Add("Ever Grande City");
            this.martLocation.Location = new System.Drawing.Point(93, 12);
            this.martLocation.Name = "martLocation";
            this.martLocation.Size = new System.Drawing.Size(209, 24);
            this.martLocation.TabIndex = 0;
            this.martLocation.Text = "PokéMart Location";
            this.martLocation.SelectedItemChanged += new System.EventHandler(this.martLocation_SelectedItemChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Blue;
            this.label1.Font = new System.Drawing.Font("Impact", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(75, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Please Select a PokéMart Location Above";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkBlue;
            this.label2.Location = new System.Drawing.Point(12, 608);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(281, 9);
            this.label2.TabIndex = 2;
            this.label2.Text = "PokéMart is a Trademark of PokéMart Distribution International";
            // 
            // slot1Amount
            // 
            this.slot1Amount.Location = new System.Drawing.Point(99, 84);
            this.slot1Amount.Name = "slot1Amount";
            this.slot1Amount.Size = new System.Drawing.Size(41, 20);
            this.slot1Amount.TabIndex = 3;
            // 
            // labelSlot1
            // 
            this.labelSlot1.AutoSize = true;
            this.labelSlot1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSlot1.Location = new System.Drawing.Point(12, 84);
            this.labelSlot1.Name = "labelSlot1";
            this.labelSlot1.Size = new System.Drawing.Size(66, 16);
            this.labelSlot1.TabIndex = 4;
            this.labelSlot1.Text = "Poké Ball";
            // 
            // labelSlot2
            // 
            this.labelSlot2.AutoSize = true;
            this.labelSlot2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSlot2.Location = new System.Drawing.Point(12, 110);
            this.labelSlot2.Name = "labelSlot2";
            this.labelSlot2.Size = new System.Drawing.Size(46, 16);
            this.labelSlot2.TabIndex = 5;
            this.labelSlot2.Text = "Potion";
            // 
            // slot2Amount
            // 
            this.slot2Amount.Location = new System.Drawing.Point(99, 110);
            this.slot2Amount.Name = "slot2Amount";
            this.slot2Amount.Size = new System.Drawing.Size(41, 20);
            this.slot2Amount.TabIndex = 6;
            // 
            // slot3Amount
            // 
            this.slot3Amount.Location = new System.Drawing.Point(99, 136);
            this.slot3Amount.Name = "slot3Amount";
            this.slot3Amount.Size = new System.Drawing.Size(41, 20);
            this.slot3Amount.TabIndex = 8;
            // 
            // labelSlot3
            // 
            this.labelSlot3.AutoSize = true;
            this.labelSlot3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSlot3.Location = new System.Drawing.Point(12, 136);
            this.labelSlot3.Name = "labelSlot3";
            this.labelSlot3.Size = new System.Drawing.Size(57, 16);
            this.labelSlot3.TabIndex = 7;
            this.labelSlot3.Text = "Antidote";
            // 
            // slot5Amount
            // 
            this.slot5Amount.Location = new System.Drawing.Point(99, 188);
            this.slot5Amount.Name = "slot5Amount";
            this.slot5Amount.Size = new System.Drawing.Size(41, 20);
            this.slot5Amount.TabIndex = 10;
            // 
            // labelSlot5
            // 
            this.labelSlot5.AutoSize = true;
            this.labelSlot5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSlot5.Location = new System.Drawing.Point(12, 188);
            this.labelSlot5.Name = "labelSlot5";
            this.labelSlot5.Size = new System.Drawing.Size(74, 16);
            this.labelSlot5.TabIndex = 9;
            this.labelSlot5.Text = "Awakening";
            // 
            // slot4Amount
            // 
            this.slot4Amount.Location = new System.Drawing.Point(99, 162);
            this.slot4Amount.Name = "slot4Amount";
            this.slot4Amount.Size = new System.Drawing.Size(41, 20);
            this.slot4Amount.TabIndex = 12;
            // 
            // labelSlot4
            // 
            this.labelSlot4.AutoSize = true;
            this.labelSlot4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSlot4.Location = new System.Drawing.Point(12, 162);
            this.labelSlot4.Name = "labelSlot4";
            this.labelSlot4.Size = new System.Drawing.Size(77, 16);
            this.labelSlot4.TabIndex = 11;
            this.labelSlot4.Text = "Parlyz Heal";
            // 
            // debugLabel
            // 
            this.debugLabel.AutoSize = true;
            this.debugLabel.Location = new System.Drawing.Point(12, 61);
            this.debugLabel.Name = "debugLabel";
            this.debugLabel.Size = new System.Drawing.Size(39, 13);
            this.debugLabel.TabIndex = 13;
            this.debugLabel.Text = "Debug";
            // 
            // slot6Amount
            // 
            this.slot6Amount.Location = new System.Drawing.Point(100, 214);
            this.slot6Amount.Name = "slot6Amount";
            this.slot6Amount.Size = new System.Drawing.Size(41, 20);
            this.slot6Amount.TabIndex = 15;
            // 
            // labelSlot6
            // 
            this.labelSlot6.AutoSize = true;
            this.labelSlot6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSlot6.Location = new System.Drawing.Point(13, 214);
            this.labelSlot6.Name = "labelSlot6";
            this.labelSlot6.Size = new System.Drawing.Size(60, 16);
            this.labelSlot6.TabIndex = 14;
            this.labelSlot6.Text = "X Speed";
            // 
            // slot12Amount
            // 
            this.slot12Amount.Location = new System.Drawing.Point(265, 214);
            this.slot12Amount.Name = "slot12Amount";
            this.slot12Amount.Size = new System.Drawing.Size(41, 20);
            this.slot12Amount.TabIndex = 27;
            // 
            // labelSlot12
            // 
            this.labelSlot12.AutoSize = true;
            this.labelSlot12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSlot12.Location = new System.Drawing.Point(167, 214);
            this.labelSlot12.Name = "labelSlot12";
            this.labelSlot12.Size = new System.Drawing.Size(56, 16);
            this.labelSlot12.TabIndex = 26;
            this.labelSlot12.Text = "X Attack";
            // 
            // slot10Amount
            // 
            this.slot10Amount.Location = new System.Drawing.Point(264, 162);
            this.slot10Amount.Name = "slot10Amount";
            this.slot10Amount.Size = new System.Drawing.Size(41, 20);
            this.slot10Amount.TabIndex = 25;
            // 
            // labelSlot10
            // 
            this.labelSlot10.AutoSize = true;
            this.labelSlot10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSlot10.Location = new System.Drawing.Point(166, 162);
            this.labelSlot10.Name = "labelSlot10";
            this.labelSlot10.Size = new System.Drawing.Size(45, 16);
            this.labelSlot10.TabIndex = 24;
            this.labelSlot10.Text = "Repel";
            // 
            // slot11Amount
            // 
            this.slot11Amount.Location = new System.Drawing.Point(264, 188);
            this.slot11Amount.Name = "slot11Amount";
            this.slot11Amount.Size = new System.Drawing.Size(41, 20);
            this.slot11Amount.TabIndex = 23;
            // 
            // labelSlot11
            // 
            this.labelSlot11.AutoSize = true;
            this.labelSlot11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSlot11.Location = new System.Drawing.Point(166, 188);
            this.labelSlot11.Name = "labelSlot11";
            this.labelSlot11.Size = new System.Drawing.Size(63, 16);
            this.labelSlot11.TabIndex = 22;
            this.labelSlot11.Text = "X Defend";
            // 
            // slot9Amount
            // 
            this.slot9Amount.Location = new System.Drawing.Point(264, 136);
            this.slot9Amount.Name = "slot9Amount";
            this.slot9Amount.Size = new System.Drawing.Size(41, 20);
            this.slot9Amount.TabIndex = 21;
            // 
            // labelSlot9
            // 
            this.labelSlot9.AutoSize = true;
            this.labelSlot9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSlot9.Location = new System.Drawing.Point(166, 136);
            this.labelSlot9.Name = "labelSlot9";
            this.labelSlot9.Size = new System.Drawing.Size(92, 16);
            this.labelSlot9.TabIndex = 20;
            this.labelSlot9.Text = "Escape Rope";
            // 
            // slot8Amount
            // 
            this.slot8Amount.Location = new System.Drawing.Point(264, 110);
            this.slot8Amount.Name = "slot8Amount";
            this.slot8Amount.Size = new System.Drawing.Size(41, 20);
            this.slot8Amount.TabIndex = 19;
            // 
            // labelSlot8
            // 
            this.labelSlot8.AutoSize = true;
            this.labelSlot8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSlot8.Location = new System.Drawing.Point(166, 110);
            this.labelSlot8.Name = "labelSlot8";
            this.labelSlot8.Size = new System.Drawing.Size(85, 16);
            this.labelSlot8.TabIndex = 18;
            this.labelSlot8.Text = "Super Potion";
            // 
            // labelSlot7
            // 
            this.labelSlot7.AutoSize = true;
            this.labelSlot7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSlot7.Location = new System.Drawing.Point(166, 84);
            this.labelSlot7.Name = "labelSlot7";
            this.labelSlot7.Size = new System.Drawing.Size(67, 16);
            this.labelSlot7.TabIndex = 17;
            this.labelSlot7.Text = "Great Ball";
            // 
            // slot7Amount
            // 
            this.slot7Amount.Location = new System.Drawing.Point(264, 84);
            this.slot7Amount.Name = "slot7Amount";
            this.slot7Amount.Size = new System.Drawing.Size(41, 20);
            this.slot7Amount.TabIndex = 16;
            // 
            // slot13Amount
            // 
            this.slot13Amount.Location = new System.Drawing.Point(100, 240);
            this.slot13Amount.Name = "slot13Amount";
            this.slot13Amount.Size = new System.Drawing.Size(41, 20);
            this.slot13Amount.TabIndex = 29;
            // 
            // labelSlot13
            // 
            this.labelSlot13.AutoSize = true;
            this.labelSlot13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSlot13.Location = new System.Drawing.Point(13, 240);
            this.labelSlot13.Name = "labelSlot13";
            this.labelSlot13.Size = new System.Drawing.Size(81, 16);
            this.labelSlot13.TabIndex = 28;
            this.labelSlot13.Text = "Orange Mail";
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Location = new System.Drawing.Point(15, 276);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(126, 24);
            this.buttonCalculate.TabIndex = 30;
            this.buttonCalculate.Text = "Calculate";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // buttonPay
            // 
            this.buttonPay.Location = new System.Drawing.Point(16, 464);
            this.buttonPay.Name = "buttonPay";
            this.buttonPay.Size = new System.Drawing.Size(125, 24);
            this.buttonPay.TabIndex = 31;
            this.buttonPay.Text = "Pay and Print Receipt";
            this.buttonPay.UseVisualStyleBackColor = true;
            this.buttonPay.Click += new System.EventHandler(this.buttonPay_Click);
            // 
            // labelCalculation
            // 
            this.labelCalculation.AutoSize = true;
            this.labelCalculation.Location = new System.Drawing.Point(16, 316);
            this.labelCalculation.Name = "labelCalculation";
            this.labelCalculation.Size = new System.Drawing.Size(127, 65);
            this.labelCalculation.TabIndex = 32;
            this.labelCalculation.Text = "Order Subtotal:\r\nTaxes:\r\n----------------------------------------\r\n\r\nTotal Price:" +
    "";
            // 
            // textBoxTender
            // 
            this.textBoxTender.Location = new System.Drawing.Point(73, 408);
            this.textBoxTender.Name = "textBoxTender";
            this.textBoxTender.Size = new System.Drawing.Size(67, 20);
            this.textBoxTender.TabIndex = 33;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 409);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 16);
            this.label3.TabIndex = 34;
            this.label3.Text = "Tender:";
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelError.Location = new System.Drawing.Point(12, 436);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(242, 16);
            this.labelError.TabIndex = 35;
            this.labelError.Text = "Error: Please Use Numeric Values Only";
            this.labelError.Visible = false;
            // 
            // buttonOrderRefresh
            // 
            this.buttonOrderRefresh.Location = new System.Drawing.Point(16, 511);
            this.buttonOrderRefresh.Name = "buttonOrderRefresh";
            this.buttonOrderRefresh.Size = new System.Drawing.Size(125, 24);
            this.buttonOrderRefresh.TabIndex = 36;
            this.buttonOrderRefresh.Text = "New Order";
            this.buttonOrderRefresh.UseVisualStyleBackColor = true;
            this.buttonOrderRefresh.Click += new System.EventHandler(this.buttonOrderRefresh_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(584, 626);
            this.Controls.Add(this.buttonOrderRefresh);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxTender);
            this.Controls.Add(this.labelCalculation);
            this.Controls.Add(this.buttonPay);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.slot13Amount);
            this.Controls.Add(this.labelSlot13);
            this.Controls.Add(this.slot12Amount);
            this.Controls.Add(this.labelSlot12);
            this.Controls.Add(this.slot10Amount);
            this.Controls.Add(this.labelSlot10);
            this.Controls.Add(this.slot11Amount);
            this.Controls.Add(this.labelSlot11);
            this.Controls.Add(this.slot9Amount);
            this.Controls.Add(this.labelSlot9);
            this.Controls.Add(this.slot8Amount);
            this.Controls.Add(this.labelSlot8);
            this.Controls.Add(this.labelSlot7);
            this.Controls.Add(this.slot7Amount);
            this.Controls.Add(this.slot6Amount);
            this.Controls.Add(this.labelSlot6);
            this.Controls.Add(this.debugLabel);
            this.Controls.Add(this.slot4Amount);
            this.Controls.Add(this.labelSlot4);
            this.Controls.Add(this.slot5Amount);
            this.Controls.Add(this.labelSlot5);
            this.Controls.Add(this.slot3Amount);
            this.Controls.Add(this.labelSlot3);
            this.Controls.Add(this.slot2Amount);
            this.Controls.Add(this.labelSlot2);
            this.Controls.Add(this.labelSlot1);
            this.Controls.Add(this.slot1Amount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.martLocation);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = " PokeMart Online Ordering Service";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.slot1Amount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slot2Amount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slot3Amount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slot5Amount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slot4Amount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slot6Amount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slot12Amount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slot10Amount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slot11Amount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slot9Amount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slot8Amount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slot7Amount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slot13Amount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DomainUpDown martLocation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown slot1Amount;
        private System.Windows.Forms.Label labelSlot1;
        private System.Windows.Forms.Label labelSlot2;
        private System.Windows.Forms.NumericUpDown slot2Amount;
        private System.Windows.Forms.NumericUpDown slot3Amount;
        private System.Windows.Forms.Label labelSlot3;
        private System.Windows.Forms.NumericUpDown slot5Amount;
        private System.Windows.Forms.Label labelSlot5;
        private System.Windows.Forms.NumericUpDown slot4Amount;
        private System.Windows.Forms.Label labelSlot4;
        private System.Windows.Forms.Label debugLabel;
        private System.Windows.Forms.NumericUpDown slot6Amount;
        private System.Windows.Forms.Label labelSlot6;
        private System.Windows.Forms.NumericUpDown slot12Amount;
        private System.Windows.Forms.Label labelSlot12;
        private System.Windows.Forms.NumericUpDown slot10Amount;
        private System.Windows.Forms.Label labelSlot10;
        private System.Windows.Forms.NumericUpDown slot11Amount;
        private System.Windows.Forms.Label labelSlot11;
        private System.Windows.Forms.NumericUpDown slot9Amount;
        private System.Windows.Forms.Label labelSlot9;
        private System.Windows.Forms.NumericUpDown slot8Amount;
        private System.Windows.Forms.Label labelSlot8;
        private System.Windows.Forms.Label labelSlot7;
        private System.Windows.Forms.NumericUpDown slot7Amount;
        private System.Windows.Forms.NumericUpDown slot13Amount;
        private System.Windows.Forms.Label labelSlot13;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.Button buttonPay;
        private System.Windows.Forms.Label labelCalculation;
        private System.Windows.Forms.TextBox textBoxTender;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.Button buttonOrderRefresh;
    }
}


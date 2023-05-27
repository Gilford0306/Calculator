using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Calculator
{
    partial class Form1
    {
        const string fileName = "calculatorlog.txt";
        private float X;
        private float Y;
        bool Operator = false;
        string Y2 = string.Empty;
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
           this.components = new System.ComponentModel.Container();
            this.pageSetupDialog1 = new PageSetupDialog();
            this.contextMenuStrip1 = new ContextMenuStrip(this.components);
            textBox1 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            button11 = new Button();
            button12 = new Button();
            button13 = new Button();
            button14 = new Button();
            button15 = new Button();
            button16 = new Button();
            button17 = new Button();
            button18 = new Button();
            button19 = new Button();
           
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new Size(61, 4);
            // 
            // textBox1
            // 
            this.textBox1.Location = new Point(53, 28);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new Size(730, 60);
            this.textBox1.Font = new Font("Microsoft Sans Serif", 20);
            this.textBox1.TextAlign = HorizontalAlignment.Right;
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = string.Empty;
            this.textBox1.ReadOnly = true;
            // 
            // button1
            // 
            this.button1.Location = new Point(53, 94);
            this.button1.Name = "button1";
            this.button1.Size = new Size(117, 109);
            this.button1.TabIndex = 2;
            this.button1.Text = "1";
            this.button1.Font = new Font("Microsoft Sans Serif", 15);
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += Button_Click;

            // 
            // button2
            // 
            this.button2.Location = new Point(176, 94);
            this.button2.Name = "button2";
            this.button2.Font = new Font("Microsoft Sans Serif", 15);
            this.button2.Size = new Size(117, 109);
            this.button2.TabIndex = 3;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += Button_Click;
            // 
            // button3
            // 
            this.button3.Location = new Point(299, 94);
            this.button3.Font = new Font("Microsoft Sans Serif", 15);
            this.button3.Name = "button3";
            this.button3.Size = new Size(117, 109);
            this.button3.TabIndex = 4;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += Button_Click;
            // 
            // button4
            // 
            this.button4.Location = new Point(299, 209);
            this.button4.Font = new Font("Microsoft Sans Serif", 15);
            this.button4.Name = "button4";
            this.button4.Size = new Size(117, 109);
            this.button4.TabIndex = 7;
            this.button4.Text = "6";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += Button_Click;
            // 
            // button5
            // 
            this.button5.Location = new Point(176, 209);
            this.button5.Font = new Font("Microsoft Sans Serif", 15);
            this.button5.Name = "button5";
            this.button5.Size = new Size(117, 109);
            this.button5.TabIndex = 6;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += Button_Click;
            // 
            // button6
            // 
            this.button6.Location = new Point(53, 209);
            this.button6.Font = new Font("Microsoft Sans Serif", 15);
            this.button6.Name = "button6";
            this.button6.Size = new Size(117, 109);
            this.button6.TabIndex = 5;
            this.button6.Text = "4";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += Button_Click;
            // 
            // button7
            // 
            this.button7.Location = new Point(299, 324);
            this.button7.Font = new Font("Microsoft Sans Serif", 15);
            this.button7.Name = "button7";
            this.button7.Size = new Size(117, 109);
            this.button7.TabIndex = 10;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += Button_Click;
            // 
            // button8
            // 
            this.button8.Location = new Point(176, 324);
            this.button8.Font = new Font("Microsoft Sans Serif", 15);
            this.button8.Name = "button8";
            this.button8.Size = new Size(117, 109);
            this.button8.TabIndex = 9;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += Button_Click;
            // 
            // button9
            // 
            this.button9.Location = new Point(53, 324);
            this.button9.Font = new Font("Microsoft Sans Serif", 15);
            this.button9.Name = "button9";
            this.button9.Size = new Size(117, 109);
            this.button9.TabIndex = 8;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += Button_Click;
            // 
            // button10
            // 
            this.button10.Location = new Point(422, 94);
            this.button10.Font = new Font("Microsoft Sans Serif", 15);
            this.button10.Name = "+";
            this.button10.Size = new Size(117, 109);
            this.button10.TabIndex = 11;
            this.button10.Text = "+";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += Button_Clicplus;
            // 
            // button11
            // 
            this.button11.Location = new Point(422, 209);
            this.button11.Font = new Font("Microsoft Sans Serif", 15);
            this.button11.Name = "button11";
            this.button11.Size = new Size(117, 109);
            this.button11.TabIndex = 12;
            this.button11.Text = "-";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += Button_Clicminus;
            // 
            // button12
            // 
            this.button12.Location = new Point(422, 324);
            this.button12.Font = new Font("Microsoft Sans Serif", 15);
            this.button12.Name = "=";
            this.button12.Size = new Size(117, 109);
            this.button12.TabIndex = 13;
            this.button12.Text = "=";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += Button_Clicequc;
            // 
            // button13
            // 
            this.button13.Location = new Point(543, 324);
            this.button13.Font = new Font("Microsoft Sans Serif", 15);
            this.button13.Name = "*";
            this.button13.Size = new Size(117, 109);
            this.button13.TabIndex = 16;
            this.button13.Text = "X";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += Button_ClicMulti;
            // 
            // button14
            // 
            this.button14.Location = new Point(543, 209);
            this.button14.Font = new Font("Microsoft Sans Serif", 15);
            this.button14.Name = "/";
            this.button14.Size = new Size(117, 109);
            this.button14.TabIndex = 15;
            this.button14.Text = "/";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += Button_ClicDiv;
            // 
            // button15
            // 
            this.button15.Location = new Point(543, 94);
            this.button15.Font = new Font("Microsoft Sans Serif", 15);
            this.button15.Name = "button15";
            this.button15.Size = new Size(117, 109);
            this.button15.TabIndex = 14;
            this.button15.Text = "Clear";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += Button_Clear;
            // 
            // button16
            // 
            this.button16.Location = new Point(666, 324);
            this.button16.Font = new Font("Microsoft Sans Serif", 15);
            this.button16.Name = "button16";
            this.button16.Size = new Size(117, 109);
            this.button16.TabIndex = 19;
            this.button16.Text = "0";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += Button_Click;

            // 
            // button17
            // 
            this.button17.Location = new Point(666, 209);
            this.button17.Font = new Font("Microsoft Sans Serif", 15);
            this.button17.Name = "button17";
            this.button17.Size = new Size(117, 109);
            this.button17.TabIndex = 18;
            this.button17.Text = ",";
            this.button17.UseVisualStyleBackColor = true;
            this.button17.Click += Button_Click;
            // 
            // button18
            // 
            this.button18.Location = new Point(666, 94);
            this.button18.Font = new Font("Microsoft Sans Serif", 15);
            this.button18.Name = "button18";
            this.button18.Size = new Size(117, 109);
            this.button18.TabIndex = 17;
            this.button18.Text = "+/-";
            this.button18.UseVisualStyleBackColor = true;
            this.button18.Click += Button_reverse;

            // 
            // button19
            // 
            this.button19.Location = new Point(270, 439);
            this.button19.Name = "button19";
            this.button19.Size = new Size(292, 109);
            this.button19.TabIndex = 18;
            this.button19.Text = "See full log";
            this.button19.Font = new Font("Microsoft Sans Serif", 15);
            this.button19.UseVisualStyleBackColor = true;
            this.button19.Click += Button_CliLog;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new SizeF(8F, 16F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(820, 600);
            this.Controls.Add(this.button19);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.button17);
            this.Controls.Add(this.button18);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void Button_CliLog(object sender, EventArgs e)
        {
            if (File.Exists(fileName))
            {
                string str = File.ReadAllText(fileName);
                MessageBox.Show(str, "log");
            }
            else
                MessageBox.Show("log is empty", "log");
        }

        private void Button_Clicequc(object sender, EventArgs e)
        {
            if (Y2 != string.Empty)
            {
                Y = float.Parse(Y2);
                Y2 = string.Empty;
            }

            if (this.textBox1.Text.Contains('+'))
                this.textBox1.Text += $"=" + Convert.ToString(X+Y);
            else if (this.textBox1.Text.Contains('-'))
                this.textBox1.Text += $"=" + Convert.ToString(X-Y);
            else if (this.textBox1.Text.Contains('*'))
                this.textBox1.Text += $"=" + Convert.ToString(X*Y);
            else if (this.textBox1.Text.Contains('/') && Y != 0)
                this.textBox1.Text += $"=" + Convert.ToString(X/Y);
            else if (this.textBox1.Text.Contains('/') && Y == 0)
                this.textBox1.Text = "divided by 0";

            button12.Enabled = false;
            button18.Enabled = false;
            Operator = true;
            File.AppendAllText(fileName, this.textBox1.Text + "\n");
        }

        private void Button_Clear(object sender, EventArgs e)
        {
            Y2 = string.Empty;
            this.textBox1.Text = string.Empty;
            Operator = false;
            this.button18.Enabled = true;

        }
        private void Button_reverse(object sender, EventArgs e)
        {
            if (this.textBox1.Text.Contains('+') || this.textBox1.Text.Contains('-') && Operator == true|| this.textBox1.Text.Contains('*') || this.textBox1.Text.Contains('/'))
            {
                if (Y2.Contains('-'))
                {
                    Y2 = Y2.Trim('-') ;
                    
                }
                else    
                Y2 = "-" + Y2;

                if (this.textBox1.Text.Contains('+'))
                {
                    string[] numb = this.textBox1.Text.Split('+');
                    numb[0] = numb[0] + '+';
                    numb[1] = Y2;
                    this.textBox1.Text = string.Concat(numb);
                }
                else if (this.textBox1.Text.Contains('-'))
                {
                    string[] numb = this.textBox1.Text.Split('-');
                    numb[0] = numb[0] + '-';
                    numb[1] = Y2;
                    this.textBox1.Text = string.Concat(numb);
                }
                else if (this.textBox1.Text.Contains('*'))
                {
                    string[] numb = this.textBox1.Text.Split('*');
                    numb[0] = numb[0] + '*';
                    numb[1] = Y2;
                    this.textBox1.Text = string.Concat(numb);
                }
                else if (this.textBox1.Text.Contains('/'))
                {
                    string[] numb = this.textBox1.Text.Split('/');
                    numb[0] = numb[0] + '/';
                    numb[1] = Y2;
                    this.textBox1.Text = string.Concat(numb);
                }

            }

            else
            {
                if (this.textBox1.Text.Contains('-'))
                    this.textBox1.Text = this.textBox1.Text.Trim('-');
                else 
                    this.textBox1.Text ="-"+ this.textBox1.Text;

            }
            
        }

        private void Button_ClicMulti(object sender, EventArgs e)
        {
            if (this.textBox1.Text.Contains('+') && Operator == true)
            {
                this.textBox1.Text = Convert.ToString(X + Y) + "*";
                X = X + Y;
            }
            else if (this.textBox1.Text.Contains('-') && Operator == true)
            {
                this.textBox1.Text = Convert.ToString(X - Y) + "*";

                X = X - Y;
            }
            else if (this.textBox1.Text.Contains('*') && Operator == true)
            {
                this.textBox1.Text = Convert.ToString(X * Y) + "*";
                X = X * Y;
            }
            else if (this.textBox1.Text.Contains('/') && Y != 0 && Operator == true)
            {
                this.textBox1.Text = Convert.ToString(X / Y) + "*";
                X = X / Y;
            }
            else if (this.textBox1.Text.Contains('/') && Y == 0 && Operator == true)
            {
                this.textBox1.Text = "divided by 0";
            }

            else
            {
                X = float.Parse(this.textBox1.Text);
                this.textBox1.Text += "*";
            }
            button12.Enabled = true;
            Operator = true;
        }

        private void Button_Clicminus(object sender, EventArgs e)
        {
            if (this.textBox1.Text.Contains('+') && Operator == true)
            {
                this.textBox1.Text = Convert.ToString(X + Y) + "/";
                X = X + Y;
            }
            else if (this.textBox1.Text.Contains('-') && Operator == true)
            {
                this.textBox1.Text = Convert.ToString(X - Y) + "/";
                X = X - Y;
            }
            else if (this.textBox1.Text.Contains('*') && Operator == true)
            {
                this.textBox1.Text = Convert.ToString(X * Y) + "/";
                X = X * Y;
            }
            else if (this.textBox1.Text.Contains('/') && Y != 0 && Operator == true)
            {

                this.textBox1.Text = Convert.ToString(X / Y) + "/";
                X = X / Y;

            }
            else if (this.textBox1.Text.Contains('/') && Y == 0 && Operator == true)
            {
                this.textBox1.Text = "divided by 0";
            }

            else
            {
                X = float.Parse(this.textBox1.Text);
                this.textBox1.Text += "-";
            }
            button12.Enabled = true;
            Operator = true;
        }

        private void Button_ClicDiv(object sender, EventArgs e)
        {
            if (this.textBox1.Text.Contains('+') && Operator == true)
            {
                this.textBox1.Text = Convert.ToString(X + Y) + "/";
                X = X + Y;
            }
            else if (this.textBox1.Text.Contains('-') && Operator == true)
            {
                this.textBox1.Text = Convert.ToString(X - Y) + "/";
                X = X - Y;
            }
            else if (this.textBox1.Text.Contains('*') && Operator == true)
            {
                this.textBox1.Text = Convert.ToString(X * Y) + "/";
                X = X * Y;
            }
            else if (this.textBox1.Text.Contains('/') && Y != 0 && Operator == true)
            {

                this.textBox1.Text = Convert.ToString (X/Y) + "/";
                X = X / Y;

            }
            else if (this.textBox1.Text.Contains('/') && Y == 0 && Operator == true)
            {
                this.textBox1.Text = "divided by 0";
            }

            else
            {
                X = float.Parse(this.textBox1.Text);
                this.textBox1.Text += "/";
            }
            button12.Enabled = true;
            Operator = true;
        }

        private void Button_Clicplus(object sender, EventArgs e)
        {
            if (this.textBox1.Text.Contains('+'))
            {
                if (Y2 != string.Empty)
                {
                    Y = float.Parse(Y2);
                    Y2 = string.Empty;
                }
                this.textBox1.Text = Convert.ToString(X + Y) + "+";
                X = X + Y;
            }
            else if (this.textBox1.Text.Contains('-') && Operator == true)
            {
                if (Y2 != string.Empty)
                {
                    Y = float.Parse(Y2);
                    Y2 = string.Empty;
                }
                this.textBox1.Text = Convert.ToString(X - Y) + "-";
                X = X - Y;
            }
            else
            {
                X = float.Parse(this.textBox1.Text);
                this.textBox1.Text += "+";
            }
            button12.Enabled = true;
            Operator = true;
        }

        private void Button_Click(object sender, System.EventArgs e)
        {
            if (this.textBox1.Text.Contains('='))
                this.textBox1.Text = (sender as Button).Text;

            else if (this.textBox1.Text == string.Empty)
                this.textBox1.Text = (sender as Button).Text;

            else if (this.textBox1.Text.Contains('+') || this.textBox1.Text.Contains('-') || this.textBox1.Text.Contains('*')|| this.textBox1.Text.Contains('/'))
            {
                Y2 += (sender as Button).Text;
                this.textBox1.Text += (sender as Button).Text;

            }
            else
                this.textBox1.Text += (sender as Button).Text;

            button12.Enabled = true;
        }


        #endregion

         PageSetupDialog pageSetupDialog1;
         ContextMenuStrip contextMenuStrip1;
         TextBox textBox1;
         Button button1;
         Button button2;
         Button button3;
         Button button4;
         Button button5;
         Button button6;
         Button button7;
         Button button8;
         Button button9;
         Button button10;
         Button button11;
         Button button12;
         Button button13;
         Button button14;
         Button button15;
         Button button16;
         Button button17;
         Button button18;
         Button button19;
    }
}


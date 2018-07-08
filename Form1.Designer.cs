using System;

namespace Assignment1
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
            this.button1 = new System.Windows.Forms.Button();
            this.widthBar = new System.Windows.Forms.TrackBar();
            this.twoplaces = new System.Windows.Forms.RadioButton();
            this.threeplaces = new System.Windows.Forms.RadioButton();
            this.fourplaces = new System.Windows.Forms.RadioButton();
            this.rectangleBtn = new System.Windows.Forms.RadioButton();
            this.ellipseBtn = new System.Windows.Forms.RadioButton();
            this.triangleBtn = new System.Windows.Forms.RadioButton();
            this.areaTxt = new System.Windows.Forms.TextBox();
            this.heightTxt = new System.Windows.Forms.TextBox();
            this.circumTxt = new System.Windows.Forms.TextBox();
            this.widthTxt = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.heightBar = new System.Windows.Forms.TrackBar();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shapeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ellipseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rectangleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rightAngledTriangleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.widthLbl = new System.Windows.Forms.Label();
            this.heightLbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.circumLbl = new System.Windows.Forms.Label();
            this.areaLbl = new System.Windows.Forms.Label();
            this.LineColourButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.widthBar)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.heightBar)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(345, 450);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // widthBar
            // 
            this.widthBar.Location = new System.Drawing.Point(431, 306);
            this.widthBar.Maximum = 150;
            this.widthBar.Minimum = 50;
            this.widthBar.Name = "widthBar";
            this.widthBar.Size = new System.Drawing.Size(258, 45);
            this.widthBar.TabIndex = 1;
            this.widthBar.Value = 100;
            this.widthBar.Scroll += new System.EventHandler(this.widthBar_Scroll);
            // 
            // twoplaces
            // 
            this.twoplaces.AutoSize = true;
            this.twoplaces.Location = new System.Drawing.Point(11, 20);
            this.twoplaces.Name = "twoplaces";
            this.twoplaces.Size = new System.Drawing.Size(65, 17);
            this.twoplaces.TabIndex = 2;
            this.twoplaces.Text = "2 places";
            this.twoplaces.UseVisualStyleBackColor = true;
            this.twoplaces.CheckedChanged += new System.EventHandler(this.RadioButtons_OnChange);
            // 
            // threeplaces
            // 
            this.threeplaces.AutoSize = true;
            this.threeplaces.Location = new System.Drawing.Point(11, 43);
            this.threeplaces.Name = "threeplaces";
            this.threeplaces.Size = new System.Drawing.Size(65, 17);
            this.threeplaces.TabIndex = 3;
            this.threeplaces.Text = "3 places";
            this.threeplaces.CheckedChanged += new System.EventHandler(this.RadioButtons_OnChange);
            // 
            // fourplaces
            // 
            this.fourplaces.AutoSize = true;
            this.fourplaces.Location = new System.Drawing.Point(11, 66);
            this.fourplaces.Name = "fourplaces";
            this.fourplaces.Size = new System.Drawing.Size(65, 17);
            this.fourplaces.TabIndex = 4;
            this.fourplaces.Text = "4 places";
            this.fourplaces.UseVisualStyleBackColor = true;
            this.fourplaces.CheckedChanged += new System.EventHandler(this.RadioButtons_OnChange);
            // 
            // rectangleBtn
            // 
            this.rectangleBtn.AutoSize = true;
            this.rectangleBtn.Location = new System.Drawing.Point(12, 43);
            this.rectangleBtn.Name = "rectangleBtn";
            this.rectangleBtn.Size = new System.Drawing.Size(74, 17);
            this.rectangleBtn.TabIndex = 5;
            this.rectangleBtn.Text = "Rectangle";
            this.rectangleBtn.UseVisualStyleBackColor = true;
            this.rectangleBtn.Click += new System.EventHandler(this.drawButton_Click);
            // 
            // ellipseBtn
            // 
            this.ellipseBtn.AutoSize = true;
            this.ellipseBtn.Location = new System.Drawing.Point(12, 20);
            this.ellipseBtn.Name = "ellipseBtn";
            this.ellipseBtn.Size = new System.Drawing.Size(55, 17);
            this.ellipseBtn.TabIndex = 6;
            this.ellipseBtn.Text = "Ellipse";
            this.ellipseBtn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ellipseBtn.UseVisualStyleBackColor = true;
            this.ellipseBtn.Click += new System.EventHandler(this.drawButton_Click);
            // 
            // triangleBtn
            // 
            this.triangleBtn.AutoSize = true;
            this.triangleBtn.Location = new System.Drawing.Point(12, 66);
            this.triangleBtn.Name = "triangleBtn";
            this.triangleBtn.Size = new System.Drawing.Size(127, 17);
            this.triangleBtn.TabIndex = 7;
            this.triangleBtn.Text = "Right-Angled Triangle";
            this.triangleBtn.UseVisualStyleBackColor = true;
            this.triangleBtn.Click += new System.EventHandler(this.drawButton_Click);
            // 
            // areaTxt
            // 
            this.areaTxt.Location = new System.Drawing.Point(70, 365);
            this.areaTxt.Name = "areaTxt";
            this.areaTxt.Size = new System.Drawing.Size(100, 20);
            this.areaTxt.TabIndex = 8;
            this.areaTxt.Text = "0.00";
            // 
            // heightTxt
            // 
            this.heightTxt.Location = new System.Drawing.Point(281, 365);
            this.heightTxt.Name = "heightTxt";
            this.heightTxt.Size = new System.Drawing.Size(100, 20);
            this.heightTxt.TabIndex = 9;
            this.heightTxt.Text = "100";
            // 
            // circumTxt
            // 
            this.circumTxt.Location = new System.Drawing.Point(70, 306);
            this.circumTxt.Name = "circumTxt";
            this.circumTxt.Size = new System.Drawing.Size(100, 20);
            this.circumTxt.TabIndex = 10;
            this.circumTxt.Text = "0.00";
            // 
            // widthTxt
            // 
            this.widthTxt.Location = new System.Drawing.Point(281, 306);
            this.widthTxt.Name = "widthTxt";
            this.widthTxt.Size = new System.Drawing.Size(100, 20);
            this.widthTxt.TabIndex = 11;
            this.widthTxt.Text = "100";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.fourplaces);
            this.groupBox1.Controls.Add(this.threeplaces);
            this.groupBox1.Controls.Add(this.twoplaces);
            this.groupBox1.Location = new System.Drawing.Point(436, 69);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(100, 100);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Decimal";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.triangleBtn);
            this.groupBox2.Controls.Add(this.ellipseBtn);
            this.groupBox2.Controls.Add(this.rectangleBtn);
            this.groupBox2.Location = new System.Drawing.Point(560, 69);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(145, 100);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Shape";
            // 
            // heightBar
            // 
            this.heightBar.Location = new System.Drawing.Point(436, 365);
            this.heightBar.Maximum = 150;
            this.heightBar.Minimum = 50;
            this.heightBar.Name = "heightBar";
            this.heightBar.Size = new System.Drawing.Size(253, 45);
            this.heightBar.TabIndex = 14;
            this.heightBar.Value = 100;
            this.heightBar.Scroll += new System.EventHandler(this.heightBar_Scroll);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.shapeToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(751, 24);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.printToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            this.printToolStripMenuItem.Text = "Print";
            this.printToolStripMenuItem.Click += new System.EventHandler(this.printToolStripMenuItem_Click);
            // 
            // shapeToolStripMenuItem
            // 
            this.shapeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ellipseToolStripMenuItem,
            this.rectangleToolStripMenuItem,
            this.rightAngledTriangleToolStripMenuItem});
            this.shapeToolStripMenuItem.Name = "shapeToolStripMenuItem";
            this.shapeToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.shapeToolStripMenuItem.Text = "Shape";
            // 
            // ellipseToolStripMenuItem
            // 
            this.ellipseToolStripMenuItem.Name = "ellipseToolStripMenuItem";
            this.ellipseToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.ellipseToolStripMenuItem.Text = "Ellipse";
            this.ellipseToolStripMenuItem.Click += new System.EventHandler(this.ellipseStripMenu_Click);
            // 
            // rectangleToolStripMenuItem
            // 
            this.rectangleToolStripMenuItem.Name = "rectangleToolStripMenuItem";
            this.rectangleToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.rectangleToolStripMenuItem.Text = "Rectangle";
            this.rectangleToolStripMenuItem.Click += new System.EventHandler(this.rectangleStripMenu_Click);
            // 
            // rightAngledTriangleToolStripMenuItem
            // 
            this.rightAngledTriangleToolStripMenuItem.Name = "rightAngledTriangleToolStripMenuItem";
            this.rightAngledTriangleToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.rightAngledTriangleToolStripMenuItem.Text = "Right-Angled Triangle";
            this.rightAngledTriangleToolStripMenuItem.Click += new System.EventHandler(this.triangleStripMenu_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click_1);
            // 
            // widthLbl
            // 
            this.widthLbl.AutoSize = true;
            this.widthLbl.Location = new System.Drawing.Point(278, 286);
            this.widthLbl.Name = "widthLbl";
            this.widthLbl.Size = new System.Drawing.Size(35, 13);
            this.widthLbl.TabIndex = 16;
            this.widthLbl.Text = "Width";
            // 
            // heightLbl
            // 
            this.heightLbl.AutoSize = true;
            this.heightLbl.Location = new System.Drawing.Point(278, 346);
            this.heightLbl.Name = "heightLbl";
            this.heightLbl.Size = new System.Drawing.Size(38, 13);
            this.heightLbl.TabIndex = 17;
            this.heightLbl.Text = "Height";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(433, 287);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Min = 50";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(648, 287);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Max = 150";
            // 
            // circumLbl
            // 
            this.circumLbl.AutoSize = true;
            this.circumLbl.Location = new System.Drawing.Point(67, 286);
            this.circumLbl.Name = "circumLbl";
            this.circumLbl.Size = new System.Drawing.Size(75, 13);
            this.circumLbl.TabIndex = 20;
            this.circumLbl.Text = "Circumference";
            // 
            // areaLbl
            // 
            this.areaLbl.AutoSize = true;
            this.areaLbl.Location = new System.Drawing.Point(67, 346);
            this.areaLbl.Name = "areaLbl";
            this.areaLbl.Size = new System.Drawing.Size(29, 13);
            this.areaLbl.TabIndex = 21;
            this.areaLbl.Text = "Area";
            // 
            // LineColourButton
            // 
            this.LineColourButton.Location = new System.Drawing.Point(473, 450);
            this.LineColourButton.Name = "LineColourButton";
            this.LineColourButton.Size = new System.Drawing.Size(99, 22);
            this.LineColourButton.TabIndex = 22;
            this.LineColourButton.Text = "Colour Picker";
            this.LineColourButton.UseVisualStyleBackColor = true;
            this.LineColourButton.Click += new System.EventHandler(this.LineColourButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(259, 226);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 485);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.LineColourButton);
            this.Controls.Add(this.areaLbl);
            this.Controls.Add(this.circumLbl);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.heightLbl);
            this.Controls.Add(this.widthLbl);
            this.Controls.Add(this.heightBar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.widthTxt);
            this.Controls.Add(this.circumTxt);
            this.Controls.Add(this.heightTxt);
            this.Controls.Add(this.areaTxt);
            this.Controls.Add(this.widthBar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.widthBar)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.heightBar)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TrackBar widthBar;
        private System.Windows.Forms.RadioButton twoplaces;
        private System.Windows.Forms.RadioButton threeplaces;
        private System.Windows.Forms.RadioButton fourplaces;
        private System.Windows.Forms.RadioButton rectangleBtn;
        private System.Windows.Forms.RadioButton ellipseBtn;
        private System.Windows.Forms.RadioButton triangleBtn;
        private System.Windows.Forms.TextBox areaTxt;
        private System.Windows.Forms.TextBox heightTxt;
        private System.Windows.Forms.TextBox circumTxt;
        private System.Windows.Forms.TextBox widthTxt;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TrackBar heightBar;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem shapeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ellipseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Label widthLbl;
        private System.Windows.Forms.Label heightLbl;
        private System.Windows.Forms.ToolStripMenuItem rectangleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rightAngledTriangleToolStripMenuItem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label circumLbl;
        private System.Windows.Forms.Label areaLbl;
        private System.Windows.Forms.Button LineColourButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
    }
}


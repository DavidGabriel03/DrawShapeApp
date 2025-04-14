namespace WindowsFormsApp2
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
            this.MainPanel = new System.Windows.Forms.Panel();
            this.buttonErase = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonLine = new System.Windows.Forms.Button();
            this.buttonCircle = new System.Windows.Forms.Button();
            this.buttonTriangle = new System.Windows.Forms.Button();
            this.buttonRectangle = new System.Windows.Forms.Button();
            this.buttonResize = new System.Windows.Forms.Button();
            this.buttonMove = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Pic = new System.Windows.Forms.PictureBox();
            this.MainPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pic)).BeginInit();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.MainPanel.Controls.Add(this.buttonErase);
            this.MainPanel.Controls.Add(this.buttonSave);
            this.MainPanel.Controls.Add(this.buttonLine);
            this.MainPanel.Controls.Add(this.buttonCircle);
            this.MainPanel.Controls.Add(this.buttonTriangle);
            this.MainPanel.Controls.Add(this.buttonRectangle);
            this.MainPanel.Controls.Add(this.buttonResize);
            this.MainPanel.Controls.Add(this.buttonMove);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Margin = new System.Windows.Forms.Padding(0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(800, 47);
            this.MainPanel.TabIndex = 1;
            // 
            // buttonErase
            // 
            this.buttonErase.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonErase.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonErase.Image = ((System.Drawing.Image)(resources.GetObject("buttonErase.Image")));
            this.buttonErase.Location = new System.Drawing.Point(117, 0);
            this.buttonErase.Name = "buttonErase";
            this.buttonErase.Size = new System.Drawing.Size(39, 47);
            this.buttonErase.TabIndex = 7;
            this.buttonErase.UseVisualStyleBackColor = true;
            this.buttonErase.Click += new System.EventHandler(this.buttonErase_Click);
            this.buttonErase.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Pic_MouseMove);
            // 
            // buttonSave
            // 
            this.buttonSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonSave.BackgroundImage")));
            this.buttonSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonSave.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonSave.Location = new System.Drawing.Point(78, 0);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(39, 47);
            this.buttonSave.TabIndex = 6;
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonLine
            // 
            this.buttonLine.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonLine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonLine.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonLine.Image = ((System.Drawing.Image)(resources.GetObject("buttonLine.Image")));
            this.buttonLine.Location = new System.Drawing.Point(644, 0);
            this.buttonLine.Margin = new System.Windows.Forms.Padding(0);
            this.buttonLine.Name = "buttonLine";
            this.buttonLine.Size = new System.Drawing.Size(39, 47);
            this.buttonLine.TabIndex = 5;
            this.buttonLine.UseVisualStyleBackColor = false;
            this.buttonLine.Click += new System.EventHandler(this.buttonLine_Click);
            this.buttonLine.Paint += new System.Windows.Forms.PaintEventHandler(this.Pic_Paint);
            // 
            // buttonCircle
            // 
            this.buttonCircle.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonCircle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonCircle.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonCircle.Image = ((System.Drawing.Image)(resources.GetObject("buttonCircle.Image")));
            this.buttonCircle.Location = new System.Drawing.Point(683, 0);
            this.buttonCircle.Margin = new System.Windows.Forms.Padding(0);
            this.buttonCircle.Name = "buttonCircle";
            this.buttonCircle.Size = new System.Drawing.Size(39, 47);
            this.buttonCircle.TabIndex = 4;
            this.buttonCircle.UseVisualStyleBackColor = false;
            this.buttonCircle.Click += new System.EventHandler(this.buttonCircle_Click);
            this.buttonCircle.Paint += new System.Windows.Forms.PaintEventHandler(this.Pic_Paint);
            // 
            // buttonTriangle
            // 
            this.buttonTriangle.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonTriangle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonTriangle.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonTriangle.Image = ((System.Drawing.Image)(resources.GetObject("buttonTriangle.Image")));
            this.buttonTriangle.Location = new System.Drawing.Point(722, 0);
            this.buttonTriangle.Margin = new System.Windows.Forms.Padding(0);
            this.buttonTriangle.Name = "buttonTriangle";
            this.buttonTriangle.Size = new System.Drawing.Size(39, 47);
            this.buttonTriangle.TabIndex = 3;
            this.buttonTriangle.UseVisualStyleBackColor = false;
            this.buttonTriangle.Click += new System.EventHandler(this.buttonTriangle_Click);
            this.buttonTriangle.Paint += new System.Windows.Forms.PaintEventHandler(this.Pic_Paint);
            // 
            // buttonRectangle
            // 
            this.buttonRectangle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonRectangle.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonRectangle.Image = ((System.Drawing.Image)(resources.GetObject("buttonRectangle.Image")));
            this.buttonRectangle.Location = new System.Drawing.Point(761, 0);
            this.buttonRectangle.Margin = new System.Windows.Forms.Padding(0);
            this.buttonRectangle.Name = "buttonRectangle";
            this.buttonRectangle.Size = new System.Drawing.Size(39, 47);
            this.buttonRectangle.TabIndex = 2;
            this.buttonRectangle.UseVisualStyleBackColor = true;
            this.buttonRectangle.Click += new System.EventHandler(this.buttonRectangle_Click);
            this.buttonRectangle.Paint += new System.Windows.Forms.PaintEventHandler(this.Pic_Paint);
            this.buttonRectangle.Resize += new System.EventHandler(this.buttonResize_Click);
            // 
            // buttonResize
            // 
            this.buttonResize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonResize.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonResize.Image = ((System.Drawing.Image)(resources.GetObject("buttonResize.Image")));
            this.buttonResize.Location = new System.Drawing.Point(39, 0);
            this.buttonResize.Name = "buttonResize";
            this.buttonResize.Size = new System.Drawing.Size(39, 47);
            this.buttonResize.TabIndex = 1;
            this.buttonResize.UseVisualStyleBackColor = true;
            this.buttonResize.Click += new System.EventHandler(this.buttonResize_Click);
            // 
            // buttonMove
            // 
            this.buttonMove.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonMove.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonMove.Image = ((System.Drawing.Image)(resources.GetObject("buttonMove.Image")));
            this.buttonMove.Location = new System.Drawing.Point(0, 0);
            this.buttonMove.Name = "buttonMove";
            this.buttonMove.Size = new System.Drawing.Size(39, 47);
            this.buttonMove.TabIndex = 0;
            this.buttonMove.UseVisualStyleBackColor = true;
            this.buttonMove.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Right;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(647, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 38);
            this.label1.TabIndex = 2;
            this.label1.Text = "Shapes";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label2.Dock = System.Windows.Forms.DockStyle.Left;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 38);
            this.label2.TabIndex = 3;
            this.label2.Text = "Actions";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 47);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 38);
            this.panel1.TabIndex = 4;
            // 
            // Pic
            // 
            this.Pic.Location = new System.Drawing.Point(0, 80);
            this.Pic.Name = "Pic";
            this.Pic.Size = new System.Drawing.Size(800, 373);
            this.Pic.TabIndex = 5;
            this.Pic.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Pic);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.MainPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MainPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Pic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Button buttonLine;
        private System.Windows.Forms.Button buttonCircle;
        private System.Windows.Forms.Button buttonTriangle;
        private System.Windows.Forms.Button buttonRectangle;
        private System.Windows.Forms.Button buttonResize;
        private System.Windows.Forms.Button buttonMove;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonErase;
        private System.Windows.Forms.PictureBox Pic;
    }
}


namespace ColorTransformations
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            recoloringToolStripMenuItem = new ToolStripMenuItem();
            translationToolStripMenuItem = new ToolStripMenuItem();
            rotationToolStripMenuItem = new ToolStripMenuItem();
            scalingToolStripMenuItem = new ToolStripMenuItem();
            shearingToolStripMenuItem = new ToolStripMenuItem();
            transformColorsOnlyToolStripMenuItem = new ToolStripMenuItem();
            translationToolStripMenuItem1 = new ToolStripMenuItem();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            rotationToolStripMenuItem1 = new ToolStripMenuItem();
            scalingToolStripMenuItem1 = new ToolStripMenuItem();
            shearingToolStripMenuItem1 = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { recoloringToolStripMenuItem, transformColorsOnlyToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // recoloringToolStripMenuItem
            // 
            recoloringToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { translationToolStripMenuItem, rotationToolStripMenuItem, scalingToolStripMenuItem, shearingToolStripMenuItem });
            recoloringToolStripMenuItem.Name = "recoloringToolStripMenuItem";
            recoloringToolStripMenuItem.Size = new Size(76, 20);
            recoloringToolStripMenuItem.Text = "Recoloring";
            // 
            // translationToolStripMenuItem
            // 
            translationToolStripMenuItem.Name = "translationToolStripMenuItem";
            translationToolStripMenuItem.Size = new Size(180, 22);
            translationToolStripMenuItem.Text = "Translation";
            translationToolStripMenuItem.Click += translationToolStripMenuItem_Click;
            // 
            // rotationToolStripMenuItem
            // 
            rotationToolStripMenuItem.Name = "rotationToolStripMenuItem";
            rotationToolStripMenuItem.Size = new Size(180, 22);
            rotationToolStripMenuItem.Text = "Rotation";
            rotationToolStripMenuItem.Click += rotationToolStripMenuItem_Click;
            // 
            // scalingToolStripMenuItem
            // 
            scalingToolStripMenuItem.Name = "scalingToolStripMenuItem";
            scalingToolStripMenuItem.Size = new Size(180, 22);
            scalingToolStripMenuItem.Text = "Scaling";
            scalingToolStripMenuItem.Click += scalingToolStripMenuItem_Click;
            // 
            // shearingToolStripMenuItem
            // 
            shearingToolStripMenuItem.Name = "shearingToolStripMenuItem";
            shearingToolStripMenuItem.Size = new Size(180, 22);
            shearingToolStripMenuItem.Text = "Shearing";
            shearingToolStripMenuItem.Click += shearingToolStripMenuItem_Click;
            // 
            // transformColorsOnlyToolStripMenuItem
            // 
            transformColorsOnlyToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { translationToolStripMenuItem1, rotationToolStripMenuItem1, scalingToolStripMenuItem1, shearingToolStripMenuItem1 });
            transformColorsOnlyToolStripMenuItem.Name = "transformColorsOnlyToolStripMenuItem";
            transformColorsOnlyToolStripMenuItem.Size = new Size(137, 20);
            transformColorsOnlyToolStripMenuItem.Text = "Transform Colors Only";
            // 
            // translationToolStripMenuItem1
            // 
            translationToolStripMenuItem1.Name = "translationToolStripMenuItem1";
            translationToolStripMenuItem1.Size = new Size(180, 22);
            translationToolStripMenuItem1.Text = "Translation";
            translationToolStripMenuItem1.Click += translationToolStripMenuItem1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 271);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(279, 167);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(297, 273);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(249, 165);
            textBox2.TabIndex = 2;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(552, 273);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(249, 165);
            textBox3.TabIndex = 3;
            // 
            // rotationToolStripMenuItem1
            // 
            rotationToolStripMenuItem1.Name = "rotationToolStripMenuItem1";
            rotationToolStripMenuItem1.Size = new Size(180, 22);
            rotationToolStripMenuItem1.Text = "Rotation";
            rotationToolStripMenuItem1.Click += rotationToolStripMenuItem1_Click;
            // 
            // scalingToolStripMenuItem1
            // 
            scalingToolStripMenuItem1.Name = "scalingToolStripMenuItem1";
            scalingToolStripMenuItem1.Size = new Size(180, 22);
            scalingToolStripMenuItem1.Text = "Scaling";
            scalingToolStripMenuItem1.Click += scalingToolStripMenuItem1_Click;
            // 
            // shearingToolStripMenuItem1
            // 
            shearingToolStripMenuItem1.Name = "shearingToolStripMenuItem1";
            shearingToolStripMenuItem1.Size = new Size(180, 22);
            shearingToolStripMenuItem1.Text = "Shearing";
            shearingToolStripMenuItem1.Click += shearingToolStripMenuItem1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem recoloringToolStripMenuItem;
        private ToolStripMenuItem translationToolStripMenuItem;
        private ToolStripMenuItem rotationToolStripMenuItem;
        private ToolStripMenuItem scalingToolStripMenuItem;
        private ToolStripMenuItem shearingToolStripMenuItem;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private ToolStripMenuItem transformColorsOnlyToolStripMenuItem;
        private ToolStripMenuItem translationToolStripMenuItem1;
        private ToolStripMenuItem rotationToolStripMenuItem1;
        private ToolStripMenuItem scalingToolStripMenuItem1;
        private ToolStripMenuItem shearingToolStripMenuItem1;
    }
}
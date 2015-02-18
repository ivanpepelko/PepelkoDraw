namespace PepelkoDraw {
    partial class MainWindow {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoActionButton = new System.Windows.Forms.ToolStripMenuItem();
            this.redoActionButton = new System.Windows.Forms.ToolStripMenuItem();
            this.colorPicker = new System.Windows.Forms.ColorDialog();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.buttonLine = new System.Windows.Forms.ToolStripButton();
            this.buttonEllipse = new System.Windows.Forms.ToolStripButton();
            this.buttonRectangle = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.penWidthBox = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.buttonWidthUp = new System.Windows.Forms.ToolStripButton();
            this.buttonWidthDown = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.colorButton = new System.Windows.Forms.ToolStripButton();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.undoActionButton,
            this.redoActionButton});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "mainMenuStrip";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(37, 20);
            this.toolStripMenuItem1.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // undoActionButton
            // 
            this.undoActionButton.Enabled = false;
            this.undoActionButton.Name = "undoActionButton";
            this.undoActionButton.Size = new System.Drawing.Size(48, 20);
            this.undoActionButton.Text = "Undo";
            this.undoActionButton.Click += new System.EventHandler(this.undoToolStripMenuItem_Click);
            // 
            // redoActionButton
            // 
            this.redoActionButton.Enabled = false;
            this.redoActionButton.Name = "redoActionButton";
            this.redoActionButton.Size = new System.Drawing.Size(46, 20);
            this.redoActionButton.Text = "Redo";
            this.redoActionButton.Click += new System.EventHandler(this.redoActionButton_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // toolStrip
            // 
            this.toolStrip.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buttonLine,
            this.buttonEllipse,
            this.buttonRectangle});
            this.toolStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.toolStrip.Location = new System.Drawing.Point(0, 24);
            this.toolStrip.Margin = new System.Windows.Forms.Padding(0, 0, 1, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(64, 538);
            this.toolStrip.TabIndex = 5;
            this.toolStrip.Text = "toolStrip1";
            // 
            // buttonLine
            // 
            this.buttonLine.CheckOnClick = true;
            this.buttonLine.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.buttonLine.Image = ((System.Drawing.Image)(resources.GetObject("buttonLine.Image")));
            this.buttonLine.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonLine.Name = "buttonLine";
            this.buttonLine.Size = new System.Drawing.Size(61, 19);
            this.buttonLine.Text = "Line";
            this.buttonLine.Click += new System.EventHandler(this.buttonLine_Click);
            // 
            // buttonEllipse
            // 
            this.buttonEllipse.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.buttonEllipse.Image = ((System.Drawing.Image)(resources.GetObject("buttonEllipse.Image")));
            this.buttonEllipse.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonEllipse.Name = "buttonEllipse";
            this.buttonEllipse.Size = new System.Drawing.Size(61, 19);
            this.buttonEllipse.Text = "Ellipse";
            this.buttonEllipse.Click += new System.EventHandler(this.buttonEllipse_Click);
            // 
            // buttonRectangle
            // 
            this.buttonRectangle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.buttonRectangle.Image = ((System.Drawing.Image)(resources.GetObject("buttonRectangle.Image")));
            this.buttonRectangle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonRectangle.Name = "buttonRectangle";
            this.buttonRectangle.Size = new System.Drawing.Size(61, 19);
            this.buttonRectangle.Text = "Rectangle";
            this.buttonRectangle.Click += new System.EventHandler(this.buttonRectangle_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.penWidthBox,
            this.toolStripLabel2,
            this.buttonWidthUp,
            this.buttonWidthDown,
            this.toolStripSeparator1,
            this.toolStripLabel3,
            this.colorButton});
            this.toolStrip1.Location = new System.Drawing.Point(64, 537);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(720, 25);
            this.toolStrip1.TabIndex = 6;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(39, 22);
            this.toolStripLabel1.Text = "Width";
            // 
            // penWidthBox
            // 
            this.penWidthBox.Name = "penWidthBox";
            this.penWidthBox.ReadOnly = true;
            this.penWidthBox.Size = new System.Drawing.Size(25, 25);
            this.penWidthBox.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(19, 22);
            this.toolStripLabel2.Text = "px";
            // 
            // buttonWidthUp
            // 
            this.buttonWidthUp.AutoToolTip = false;
            this.buttonWidthUp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.buttonWidthUp.Image = ((System.Drawing.Image)(resources.GetObject("buttonWidthUp.Image")));
            this.buttonWidthUp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonWidthUp.Name = "buttonWidthUp";
            this.buttonWidthUp.Size = new System.Drawing.Size(23, 22);
            this.buttonWidthUp.Text = "toolStripButton2";
            this.buttonWidthUp.Click += new System.EventHandler(this.buttonWidthUp_Click);
            // 
            // buttonWidthDown
            // 
            this.buttonWidthDown.AutoToolTip = false;
            this.buttonWidthDown.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.buttonWidthDown.Image = ((System.Drawing.Image)(resources.GetObject("buttonWidthDown.Image")));
            this.buttonWidthDown.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonWidthDown.Name = "buttonWidthDown";
            this.buttonWidthDown.Size = new System.Drawing.Size(23, 22);
            this.buttonWidthDown.Text = "toolStripButton3";
            this.buttonWidthDown.Click += new System.EventHandler(this.buttonWidthDown_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(36, 22);
            this.toolStripLabel3.Text = "Color";
            // 
            // colorButton
            // 
            this.colorButton.AutoToolTip = false;
            this.colorButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.colorButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.colorButton.Name = "colorButton";
            this.colorButton.Size = new System.Drawing.Size(23, 22);
            this.colorButton.Text = "toolStripButton2";
            this.colorButton.Click += new System.EventHandler(this.colorButton_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "MainWindow";
            this.Text = "PepelkoDraw";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.MainWindow_Paint);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MainWindow_KeyPress);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainWindow_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainWindow_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MainWindow_MouseUp);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ColorDialog colorPicker;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton buttonLine;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox penWidthBox;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripButton buttonWidthUp;
        private System.Windows.Forms.ToolStripButton buttonWidthDown;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripButton colorButton;
        private System.Windows.Forms.ToolStripButton buttonEllipse;
        private System.Windows.Forms.ToolStripMenuItem undoActionButton;
        private System.Windows.Forms.ToolStripMenuItem redoActionButton;
        private System.Windows.Forms.ToolStripButton buttonRectangle;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
    }
}


namespace Viewer
{
    partial class ViewerForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewerForm));
            this.viewerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьПапкуСИзображениямиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timerMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.помощьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.listView1 = new System.Windows.Forms.ListView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pictureBoxImg = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.btNext = new System.Windows.Forms.Button();
            this.btTimer = new System.Windows.Forms.Button();
            this.btBack = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImg)).BeginInit();
            this.SuspendLayout();
            // 
            // viewerToolStripMenuItem
            // 
            this.viewerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьПапкуСИзображениямиToolStripMenuItem,
            this.timerMenuItem,
            this.выходToolStripMenuItem});
            this.viewerToolStripMenuItem.Name = "viewerToolStripMenuItem";
            this.viewerToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.viewerToolStripMenuItem.Text = "Viewer";
            // 
            // открытьПапкуСИзображениямиToolStripMenuItem
            // 
            this.открытьПапкуСИзображениямиToolStripMenuItem.Name = "открытьПапкуСИзображениямиToolStripMenuItem";
            this.открытьПапкуСИзображениямиToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.открытьПапкуСИзображениямиToolStripMenuItem.Size = new System.Drawing.Size(301, 22);
            this.открытьПапкуСИзображениямиToolStripMenuItem.Text = "Открыть папку с изображениями";
            this.открытьПапкуСИзображениямиToolStripMenuItem.Click += new System.EventHandler(this.buttonOpen_Click);
            // 
            // timerMenuItem
            // 
            this.timerMenuItem.Enabled = false;
            this.timerMenuItem.Name = "timerMenuItem";
            this.timerMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T)));
            this.timerMenuItem.Size = new System.Drawing.Size(301, 22);
            this.timerMenuItem.Text = "Просмотр по таймеру";
            this.timerMenuItem.Click += new System.EventHandler(this.timer_Tick);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(301, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // помощьToolStripMenuItem
            // 
            this.помощьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оПрограммеToolStripMenuItem});
            this.помощьToolStripMenuItem.Name = "помощьToolStripMenuItem";
            this.помощьToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.помощьToolStripMenuItem.Text = "Помощь";
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.HelpToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewerToolStripMenuItem,
            this.помощьToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.CadetBlue;
            this.splitContainer1.Panel1.Controls.Add(this.listView1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.pictureBoxImg);
            this.splitContainer1.Panel2.Controls.Add(this.textBox1);
            this.splitContainer1.Panel2.Controls.Add(this.button4);
            this.splitContainer1.Panel2.Controls.Add(this.btNext);
            this.splitContainer1.Panel2.Controls.Add(this.btTimer);
            this.splitContainer1.Panel2.Controls.Add(this.btBack);
            this.splitContainer1.Size = new System.Drawing.Size(800, 426);
            this.splitContainer1.SplitterDistance = 266;
            this.splitContainer1.TabIndex = 1;
            // 
            // listView1
            // 
            this.listView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.listView1.HideSelection = false;
            this.listView1.LargeImageList = this.imageList1;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(134, 426);
            this.listView1.SmallImageList = this.imageList1;
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseClick);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(50, 50);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // pictureBoxImg
            // 
            this.pictureBoxImg.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxImg.InitialImage = null;
            this.pictureBoxImg.Location = new System.Drawing.Point(21, 45);
            this.pictureBoxImg.Name = "pictureBoxImg";
            this.pictureBoxImg.Padding = new System.Windows.Forms.Padding(50);
            this.pictureBoxImg.Size = new System.Drawing.Size(483, 299);
            this.pictureBoxImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxImg.TabIndex = 5;
            this.pictureBoxImg.TabStop = false;
            this.pictureBoxImg.WaitOnLoad = true;
            this.pictureBoxImg.Click += new System.EventHandler(this.pictureBoxImg_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(127, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(274, 20);
            this.textBox1.TabIndex = 4;
            // 
            // button4
            // 
            this.button4.AutoSize = true;
            this.button4.BackColor = System.Drawing.Color.Navy;
            this.button4.Location = new System.Drawing.Point(21, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 35);
            this.button4.TabIndex = 3;
            this.button4.Text = "Open folder";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.buttonOpen_Click);
            // 
            // btNext
            // 
            this.btNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btNext.BackColor = System.Drawing.Color.Navy;
            this.btNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btNext.Enabled = false;
            this.btNext.Location = new System.Drawing.Point(277, 379);
            this.btNext.Name = "btNext";
            this.btNext.Size = new System.Drawing.Size(80, 35);
            this.btNext.TabIndex = 2;
            this.btNext.Text = "Next";
            this.btNext.UseVisualStyleBackColor = false;
            this.btNext.Click += new System.EventHandler(this.btNext_Click);
            // 
            // btTimer
            // 
            this.btTimer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btTimer.BackColor = System.Drawing.Color.Navy;
            this.btTimer.Enabled = false;
            this.btTimer.Location = new System.Drawing.Point(148, 379);
            this.btTimer.Name = "btTimer";
            this.btTimer.Size = new System.Drawing.Size(80, 35);
            this.btTimer.TabIndex = 1;
            this.btTimer.Text = "Timer on";
            this.btTimer.UseVisualStyleBackColor = false;
            this.btTimer.Click += new System.EventHandler(this.timer_Tick);
            // 
            // btBack
            // 
            this.btBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btBack.BackColor = System.Drawing.Color.Navy;
            this.btBack.Enabled = false;
            this.btBack.Location = new System.Drawing.Point(21, 379);
            this.btBack.Name = "btBack";
            this.btBack.Size = new System.Drawing.Size(80, 35);
            this.btBack.TabIndex = 0;
            this.btBack.Text = "Back";
            this.btBack.UseVisualStyleBackColor = false;
            this.btBack.Click += new System.EventHandler(this.btBack_Click);
            // 
            // ViewerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.Color.Snow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ViewerForm";
            this.Text = "Viewer";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem viewerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьПапкуСИзображениямиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem timerMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem помощьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btNext;
        private System.Windows.Forms.Button btTimer;
        private System.Windows.Forms.Button btBack;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ListView listView1;
        public System.Windows.Forms.PictureBox pictureBoxImg;
    }
}


namespace AppForDataset
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            menuStrip1 = new MenuStrip();
            файлToolStripMenuItem = new ToolStripMenuItem();
            CreateToolStripMenuItem = new ToolStripMenuItem();
            OpenToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator = new ToolStripSeparator();
            SaveToolStripMenuItem = new ToolStripMenuItem();
            SaveAsToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            ExitToolStripMenuItem = new ToolStripMenuItem();
            операцииСДаннымиToolStripMenuItem = new ToolStripMenuItem();
            UpdatePriceToolStripMenuItem = new ToolStripMenuItem();
            ReturnProductToolStripMenuItem = new ToolStripMenuItem();
            справкаToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator5 = new ToolStripSeparator();
            AboutProgrammToolStripMenuItem = new ToolStripMenuItem();
            dataGridView1 = new DataGridView();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { файлToolStripMenuItem, операцииСДаннымиToolStripMenuItem, справкаToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            файлToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { CreateToolStripMenuItem, OpenToolStripMenuItem, toolStripSeparator, SaveToolStripMenuItem, SaveAsToolStripMenuItem, toolStripSeparator1, ExitToolStripMenuItem });
            файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            файлToolStripMenuItem.Size = new Size(48, 20);
            файлToolStripMenuItem.Text = "&Файл";
            // 
            // CreateToolStripMenuItem
            // 
            CreateToolStripMenuItem.Image = (Image)resources.GetObject("CreateToolStripMenuItem.Image");
            CreateToolStripMenuItem.ImageTransparentColor = Color.Magenta;
            CreateToolStripMenuItem.Name = "CreateToolStripMenuItem";
            CreateToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.N;
            CreateToolStripMenuItem.Size = new Size(173, 22);
            CreateToolStripMenuItem.Text = "&Создать";
            CreateToolStripMenuItem.Click += CreateToolStripMenuItem_Click;
            // 
            // OpenToolStripMenuItem
            // 
            OpenToolStripMenuItem.Image = (Image)resources.GetObject("OpenToolStripMenuItem.Image");
            OpenToolStripMenuItem.ImageTransparentColor = Color.Magenta;
            OpenToolStripMenuItem.Name = "OpenToolStripMenuItem";
            OpenToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.O;
            OpenToolStripMenuItem.Size = new Size(173, 22);
            OpenToolStripMenuItem.Text = "&Открыть";
            OpenToolStripMenuItem.Click += OpenToolStripMenuItem_Click;
            // 
            // toolStripSeparator
            // 
            toolStripSeparator.Name = "toolStripSeparator";
            toolStripSeparator.Size = new Size(170, 6);
            // 
            // SaveToolStripMenuItem
            // 
            SaveToolStripMenuItem.Image = (Image)resources.GetObject("SaveToolStripMenuItem.Image");
            SaveToolStripMenuItem.ImageTransparentColor = Color.Magenta;
            SaveToolStripMenuItem.Name = "SaveToolStripMenuItem";
            SaveToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.S;
            SaveToolStripMenuItem.Size = new Size(173, 22);
            SaveToolStripMenuItem.Text = "&Сохранить";
            SaveToolStripMenuItem.Click += SaveToolStripMenuItem_Click;
            // 
            // SaveAsToolStripMenuItem
            // 
            SaveAsToolStripMenuItem.Name = "SaveAsToolStripMenuItem";
            SaveAsToolStripMenuItem.Size = new Size(173, 22);
            SaveAsToolStripMenuItem.Text = "Сохранить &как";
            SaveAsToolStripMenuItem.Click += SaveAsToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(170, 6);
            // 
            // ExitToolStripMenuItem
            // 
            ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            ExitToolStripMenuItem.Size = new Size(173, 22);
            ExitToolStripMenuItem.Text = "Вы&ход";
            ExitToolStripMenuItem.Click += ExitToolStripMenuItem_Click;
            // 
            // операцииСДаннымиToolStripMenuItem
            // 
            операцииСДаннымиToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { UpdatePriceToolStripMenuItem, ReturnProductToolStripMenuItem });
            операцииСДаннымиToolStripMenuItem.Name = "операцииСДаннымиToolStripMenuItem";
            операцииСДаннымиToolStripMenuItem.Size = new Size(138, 20);
            операцииСДаннымиToolStripMenuItem.Text = "Операции с данными";
            // 
            // UpdatePriceToolStripMenuItem
            // 
            UpdatePriceToolStripMenuItem.Name = "UpdatePriceToolStripMenuItem";
            UpdatePriceToolStripMenuItem.Size = new Size(280, 22);
            UpdatePriceToolStripMenuItem.Text = "Обновить цену";
            UpdatePriceToolStripMenuItem.Click += UpdatePriceToolStripMenuItem_Click;
            // 
            // ReturnProductToolStripMenuItem
            // 
            ReturnProductToolStripMenuItem.Name = "ReturnProductToolStripMenuItem";
            ReturnProductToolStripMenuItem.Size = new Size(280, 22);
            ReturnProductToolStripMenuItem.Text = "Вернуть выбранный товар владельцу";
            ReturnProductToolStripMenuItem.Click += ReturnProductToolStripMenuItem_Click;
            // 
            // справкаToolStripMenuItem
            // 
            справкаToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { toolStripSeparator5, AboutProgrammToolStripMenuItem });
            справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            справкаToolStripMenuItem.Size = new Size(65, 20);
            справкаToolStripMenuItem.Text = "&Справка";
            // 
            // toolStripSeparator5
            // 
            toolStripSeparator5.Name = "toolStripSeparator5";
            toolStripSeparator5.Size = new Size(155, 6);
            // 
            // AboutProgrammToolStripMenuItem
            // 
            AboutProgrammToolStripMenuItem.Name = "AboutProgrammToolStripMenuItem";
            AboutProgrammToolStripMenuItem.Size = new Size(158, 22);
            AboutProgrammToolStripMenuItem.Text = "&О программе…";
            AboutProgrammToolStripMenuItem.Click += AboutProgrammToolStripMenuItem_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 27);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(776, 411);
            dataGridView1.TabIndex = 1;
            dataGridView1.DataError += dataGridView1_DataError;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            Text = "Комиссионный магазин бытовой техники";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem файлToolStripMenuItem;
        private ToolStripMenuItem CreateToolStripMenuItem;
        private ToolStripMenuItem OpenToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator;
        private ToolStripMenuItem SaveToolStripMenuItem;
        private ToolStripMenuItem SaveAsToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem печатьToolStripMenuItem;
        private ToolStripMenuItem предварительныйпросмотрToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem ExitToolStripMenuItem;
        private ToolStripMenuItem отменитьToolStripMenuItem;
        private ToolStripMenuItem повторитьToolStripMenuItem;
        private ToolStripMenuItem вырезатьToolStripMenuItem;
        private ToolStripMenuItem копироватьToolStripMenuItem;
        private ToolStripMenuItem вставитьToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripMenuItem выбратьвсеToolStripMenuItem;
        private ToolStripMenuItem инструментыToolStripMenuItem;
        private ToolStripMenuItem настройкиToolStripMenuItem;
        private ToolStripMenuItem параметрыToolStripMenuItem;
        private ToolStripMenuItem справкаToolStripMenuItem;
        private ToolStripMenuItem содержимоеToolStripMenuItem;
        private ToolStripMenuItem индексToolStripMenuItem;
        private ToolStripMenuItem поискToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator5;
        private ToolStripMenuItem AboutProgrammToolStripMenuItem;
        private DataGridView dataGridView1;
        private ToolStripMenuItem операцииСДаннымиToolStripMenuItem;
        private ToolStripMenuItem UpdatePriceToolStripMenuItem;
        private ToolStripMenuItem ReturnProductToolStripMenuItem;
    }
}
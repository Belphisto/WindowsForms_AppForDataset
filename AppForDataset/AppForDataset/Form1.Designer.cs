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
            toolStrip1 = new ToolStrip();
            CreateToolStripButton = new ToolStripButton();
            OpenToolStripButton = new ToolStripButton();
            SaveToolStripButton = new ToolStripButton();
            toolStripSeparator3 = new ToolStripSeparator();
            toolStripSeparator6 = new ToolStripSeparator();
            AboutProgrammToolStripButton = new ToolStripButton();
            SellToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            toolStrip1.SuspendLayout();
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
            CreateToolStripMenuItem.Size = new Size(180, 22);
            CreateToolStripMenuItem.Text = "&Создать";
            CreateToolStripMenuItem.Click += CreateToolStripMenuItem_Click;
            // 
            // OpenToolStripMenuItem
            // 
            OpenToolStripMenuItem.Image = (Image)resources.GetObject("OpenToolStripMenuItem.Image");
            OpenToolStripMenuItem.ImageTransparentColor = Color.Magenta;
            OpenToolStripMenuItem.Name = "OpenToolStripMenuItem";
            OpenToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.O;
            OpenToolStripMenuItem.Size = new Size(180, 22);
            OpenToolStripMenuItem.Text = "&Открыть";
            OpenToolStripMenuItem.Click += OpenToolStripMenuItem_Click;
            // 
            // toolStripSeparator
            // 
            toolStripSeparator.Name = "toolStripSeparator";
            toolStripSeparator.Size = new Size(177, 6);
            // 
            // SaveToolStripMenuItem
            // 
            SaveToolStripMenuItem.Image = (Image)resources.GetObject("SaveToolStripMenuItem.Image");
            SaveToolStripMenuItem.ImageTransparentColor = Color.Magenta;
            SaveToolStripMenuItem.Name = "SaveToolStripMenuItem";
            SaveToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.S;
            SaveToolStripMenuItem.Size = new Size(180, 22);
            SaveToolStripMenuItem.Text = "&Сохранить";
            SaveToolStripMenuItem.Click += SaveToolStripMenuItem_Click;
            // 
            // SaveAsToolStripMenuItem
            // 
            SaveAsToolStripMenuItem.Name = "SaveAsToolStripMenuItem";
            SaveAsToolStripMenuItem.Size = new Size(180, 22);
            SaveAsToolStripMenuItem.Text = "Сохранить &как";
            SaveAsToolStripMenuItem.Click += SaveAsToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(177, 6);
            // 
            // ExitToolStripMenuItem
            // 
            ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            ExitToolStripMenuItem.Size = new Size(180, 22);
            ExitToolStripMenuItem.Text = "Вы&ход";
            ExitToolStripMenuItem.Click += ExitToolStripMenuItem_Click;
            // 
            // операцииСДаннымиToolStripMenuItem
            // 
            операцииСДаннымиToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { UpdatePriceToolStripMenuItem, ReturnProductToolStripMenuItem, SellToolStripMenuItem });
            операцииСДаннымиToolStripMenuItem.Name = "операцииСДаннымиToolStripMenuItem";
            операцииСДаннымиToolStripMenuItem.Size = new Size(138, 20);
            операцииСДаннымиToolStripMenuItem.Text = "Операции с данными";
            // 
            // UpdatePriceToolStripMenuItem
            // 
            UpdatePriceToolStripMenuItem.Name = "UpdatePriceToolStripMenuItem";
            UpdatePriceToolStripMenuItem.Size = new Size(310, 22);
            UpdatePriceToolStripMenuItem.Text = "Провести уценку товара";
            UpdatePriceToolStripMenuItem.Click += UpdatePriceToolStripMenuItem_Click;
            // 
            // ReturnProductToolStripMenuItem
            // 
            ReturnProductToolStripMenuItem.Name = "ReturnProductToolStripMenuItem";
            ReturnProductToolStripMenuItem.Size = new Size(310, 22);
            ReturnProductToolStripMenuItem.Text = "Вернуть нераспроданный товар владельцу";
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
            toolStripSeparator5.Size = new Size(177, 6);
            // 
            // AboutProgrammToolStripMenuItem
            // 
            AboutProgrammToolStripMenuItem.Name = "AboutProgrammToolStripMenuItem";
            AboutProgrammToolStripMenuItem.Size = new Size(180, 22);
            AboutProgrammToolStripMenuItem.Text = "&О программе…";
            AboutProgrammToolStripMenuItem.Click += AboutProgrammToolStripMenuItem_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 52);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(776, 386);
            dataGridView1.TabIndex = 1;
            dataGridView1.DataError += dataGridView1_DataError;
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { CreateToolStripButton, OpenToolStripButton, SaveToolStripButton, toolStripSeparator3, toolStripSeparator6, AboutProgrammToolStripButton });
            toolStrip1.Location = new Point(0, 24);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 25);
            toolStrip1.TabIndex = 2;
            toolStrip1.Text = "toolStrip1";
            // 
            // CreateToolStripButton
            // 
            CreateToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            CreateToolStripButton.Image = (Image)resources.GetObject("CreateToolStripButton.Image");
            CreateToolStripButton.ImageTransparentColor = Color.Magenta;
            CreateToolStripButton.Name = "CreateToolStripButton";
            CreateToolStripButton.Size = new Size(23, 22);
            CreateToolStripButton.Text = "&Создать";
            // 
            // OpenToolStripButton
            // 
            OpenToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            OpenToolStripButton.Image = (Image)resources.GetObject("OpenToolStripButton.Image");
            OpenToolStripButton.ImageTransparentColor = Color.Magenta;
            OpenToolStripButton.Name = "OpenToolStripButton";
            OpenToolStripButton.Size = new Size(23, 22);
            OpenToolStripButton.Text = "&Открыть";
            // 
            // SaveToolStripButton
            // 
            SaveToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            SaveToolStripButton.Image = (Image)resources.GetObject("SaveToolStripButton.Image");
            SaveToolStripButton.ImageTransparentColor = Color.Magenta;
            SaveToolStripButton.Name = "SaveToolStripButton";
            SaveToolStripButton.Size = new Size(23, 22);
            SaveToolStripButton.Text = "&Сохранить";
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(6, 25);
            // 
            // toolStripSeparator6
            // 
            toolStripSeparator6.Name = "toolStripSeparator6";
            toolStripSeparator6.Size = new Size(6, 25);
            // 
            // AboutProgrammToolStripButton
            // 
            AboutProgrammToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            AboutProgrammToolStripButton.Image = (Image)resources.GetObject("AboutProgrammToolStripButton.Image");
            AboutProgrammToolStripButton.ImageTransparentColor = Color.Magenta;
            AboutProgrammToolStripButton.Name = "AboutProgrammToolStripButton";
            AboutProgrammToolStripButton.Size = new Size(23, 22);
            AboutProgrammToolStripButton.Text = "С&правка";
            // 
            // SellToolStripMenuItem
            // 
            SellToolStripMenuItem.Name = "SellToolStripMenuItem";
            SellToolStripMenuItem.Size = new Size(310, 22);
            SellToolStripMenuItem.Text = "Продать товар";
            SellToolStripMenuItem.Click += SellToolStripMenuItem_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(toolStrip1);
            Controls.Add(dataGridView1);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MainMenuStrip = menuStrip1;
            MinimizeBox = false;
            Name = "MainForm";
            Text = "Комиссионный магазин бытовой техники";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
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
        private ToolStripMenuItem SellToolStripMenuItem;
        private ToolStrip toolStrip1;
        private ToolStripButton CreateToolStripButton;
        private ToolStripButton OpenToolStripButton;
        private ToolStripButton SaveToolStripButton;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripSeparator toolStripSeparator6;
        private ToolStripButton AboutProgrammToolStripButton;
    }
}
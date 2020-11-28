namespace VkSearchApp
{
    partial class MainForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.tag_textbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.likes_min_textbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Page_numbox = new System.Windows.Forms.NumericUpDown();
            this.search_results = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.source_list = new System.Windows.Forms.CheckedListBox();
            this.different_source = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.search_type = new System.Windows.Forms.ComboBox();
            this.general_search_panel = new System.Windows.Forms.Panel();
            this.author_id = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.litach_pan = new System.Windows.Forms.Panel();
            this.copy_links = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Page_numbox)).BeginInit();
            this.search_results.SuspendLayout();
            this.panel1.SuspendLayout();
            this.general_search_panel.SuspendLayout();
            this.litach_pan.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(24, 47);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.SearchButtonClick);
            // 
            // tag_textbox
            // 
            this.tag_textbox.Location = new System.Drawing.Point(6, 26);
            this.tag_textbox.Name = "tag_textbox";
            this.tag_textbox.Size = new System.Drawing.Size(100, 20);
            this.tag_textbox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Search";
            // 
            // likes_min_textbox
            // 
            this.likes_min_textbox.Location = new System.Drawing.Point(6, 76);
            this.likes_min_textbox.Name = "likes_min_textbox";
            this.likes_min_textbox.Size = new System.Drawing.Size(100, 20);
            this.likes_min_textbox.TabIndex = 3;
            this.likes_min_textbox.Text = "100";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "likes_min";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Page";
            // 
            // Page_numbox
            // 
            this.Page_numbox.Location = new System.Drawing.Point(6, 130);
            this.Page_numbox.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.Page_numbox.Name = "Page_numbox";
            this.Page_numbox.Size = new System.Drawing.Size(100, 20);
            this.Page_numbox.TabIndex = 8;
            this.Page_numbox.ValueChanged += new System.EventHandler(this.PageNumberValueChanged);
            // 
            // search_results
            // 
            this.search_results.AutoSize = true;
            this.search_results.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.search_results.ColumnCount = 4;
            this.search_results.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.search_results.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.search_results.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 261F));
            this.search_results.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 81F));
            this.search_results.Controls.Add(this.label4, 0, 0);
            this.search_results.Controls.Add(this.label5, 1, 0);
            this.search_results.Controls.Add(this.label7, 3, 0);
            this.search_results.Controls.Add(this.label6, 2, 0);
            this.search_results.Location = new System.Drawing.Point(3, 3);
            this.search_results.Name = "search_results";
            this.search_results.RowCount = 2;
            this.search_results.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.search_results.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.search_results.Size = new System.Drawing.Size(414, 90);
            this.search_results.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 50);
            this.label4.TabIndex = 0;
            this.label4.Text = "id";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 50);
            this.label5.TabIndex = 1;
            this.label5.Text = "likes";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(336, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 50);
            this.label7.TabIndex = 3;
            this.label7.Text = "Copy";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(75, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(255, 50);
            this.label6.TabIndex = 4;
            this.label6.Text = "URL";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.search_results);
            this.panel1.Location = new System.Drawing.Point(183, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(452, 439);
            this.panel1.TabIndex = 10;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(24, 82);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.ClearButtonClick);
            // 
            // source_list
            // 
            this.source_list.CheckOnClick = true;
            this.source_list.FormattingEnabled = true;
            this.source_list.Items.AddRange(new object[] {
            "litprn",
            "top_chtivo",
            "quality_journal",
            "internetpasta",
            "diewelle0"});
            this.source_list.Location = new System.Drawing.Point(6, 162);
            this.source_list.Name = "source_list";
            this.source_list.Size = new System.Drawing.Size(100, 79);
            this.source_list.TabIndex = 12;
            // 
            // different_source
            // 
            this.different_source.Location = new System.Drawing.Point(6, 273);
            this.different_source.Name = "different_source";
            this.different_source.Size = new System.Drawing.Size(100, 20);
            this.different_source.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 252);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Different source";
            // 
            // search_type
            // 
            this.search_type.FormattingEnabled = true;
            this.search_type.Items.AddRange(new object[] {
            "General_search",
            "litach.inc"});
            this.search_type.Location = new System.Drawing.Point(24, 12);
            this.search_type.Name = "search_type";
            this.search_type.Size = new System.Drawing.Size(121, 21);
            this.search_type.TabIndex = 15;
            this.search_type.SelectedIndexChanged += new System.EventHandler(this.SeclectSearchTypeIndexChanged);
            // 
            // general_search_panel
            // 
            this.general_search_panel.Controls.Add(this.button3);
            this.general_search_panel.Controls.Add(this.label1);
            this.general_search_panel.Controls.Add(this.tag_textbox);
            this.general_search_panel.Controls.Add(this.label8);
            this.general_search_panel.Controls.Add(this.likes_min_textbox);
            this.general_search_panel.Controls.Add(this.different_source);
            this.general_search_panel.Controls.Add(this.label2);
            this.general_search_panel.Controls.Add(this.source_list);
            this.general_search_panel.Controls.Add(this.label3);
            this.general_search_panel.Controls.Add(this.Page_numbox);
            this.general_search_panel.Location = new System.Drawing.Point(24, 111);
            this.general_search_panel.Name = "general_search_panel";
            this.general_search_panel.Size = new System.Drawing.Size(131, 340);
            this.general_search_panel.TabIndex = 16;
            // 
            // author_id
            // 
            this.author_id.Location = new System.Drawing.Point(6, 17);
            this.author_id.Name = "author_id";
            this.author_id.Size = new System.Drawing.Size(106, 20);
            this.author_id.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 1);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "Author id";
            // 
            // litach_pan
            // 
            this.litach_pan.Controls.Add(this.copy_links);
            this.litach_pan.Controls.Add(this.label9);
            this.litach_pan.Controls.Add(this.author_id);
            this.litach_pan.Location = new System.Drawing.Point(24, 111);
            this.litach_pan.Name = "litach_pan";
            this.litach_pan.Size = new System.Drawing.Size(131, 73);
            this.litach_pan.TabIndex = 18;
            // 
            // copy_links
            // 
            this.copy_links.Location = new System.Drawing.Point(6, 44);
            this.copy_links.Name = "copy_links";
            this.copy_links.Size = new System.Drawing.Size(106, 23);
            this.copy_links.TabIndex = 18;
            this.copy_links.Text = "Copy all links";
            this.copy_links.UseVisualStyleBackColor = true;
            this.copy_links.Click += new System.EventHandler(this.CopyAuthorLinksButtonClick);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(6, 311);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 26);
            this.button3.TabIndex = 15;
            this.button3.Text = "Refactor buffer";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.RefactorBufferButtonClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 477);
            this.Controls.Add(this.litach_pan);
            this.Controls.Add(this.general_search_panel);
            this.Controls.Add(this.search_type);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainFormLoad);
            ((System.ComponentModel.ISupportInitialize)(this.Page_numbox)).EndInit();
            this.search_results.ResumeLayout(false);
            this.search_results.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.general_search_panel.ResumeLayout(false);
            this.general_search_panel.PerformLayout();
            this.litach_pan.ResumeLayout(false);
            this.litach_pan.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tag_textbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox likes_min_textbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown Page_numbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TableLayoutPanel search_results;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckedListBox source_list;
        private System.Windows.Forms.TextBox different_source;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox search_type;
        private System.Windows.Forms.Panel general_search_panel;
        private System.Windows.Forms.TextBox author_id;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel litach_pan;
        private System.Windows.Forms.Button copy_links;
        private System.Windows.Forms.Button button3;
    }
}


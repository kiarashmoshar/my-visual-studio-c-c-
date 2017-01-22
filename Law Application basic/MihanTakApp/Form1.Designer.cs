namespace MihanTakApp
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            this.textBoxPN = new System.Windows.Forms.TextBox();
            this.textBoxPLN = new System.Windows.Forms.TextBox();
            this.textBoxEN = new System.Windows.Forms.TextBox();
            this.textBoxELN = new System.Windows.Forms.TextBox();
            this.textBoxE = new System.Windows.Forms.TextBox();
            this.textBoxUC = new System.Windows.Forms.TextBox();
            this.textBoxP = new System.Windows.Forms.TextBox();
            this.textBoxEP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Save = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.Search = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label9 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.searchNameToolStrip = new System.Windows.Forms.ToolStrip();
            this.englishNameToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.englishNameToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.searchNameToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.persianNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.englishNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.persianLNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.englishLNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailPassDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.infoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mihanTakDataSet = new MihanTakApp.MihanTakDataSet();
            this.infoTableAdapter = new MihanTakApp.MihanTakDataSetTableAdapters.infoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.searchNameToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.infoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mihanTakDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxPN
            // 
            this.textBoxPN.Location = new System.Drawing.Point(142, 67);
            this.textBoxPN.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.textBoxPN.Name = "textBoxPN";
            this.textBoxPN.Size = new System.Drawing.Size(391, 30);
            this.textBoxPN.TabIndex = 0;
            this.textBoxPN.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBoxPLN
            // 
            this.textBoxPLN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.textBoxPLN.Location = new System.Drawing.Point(1060, 68);
            this.textBoxPLN.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.textBoxPLN.Name = "textBoxPLN";
            this.textBoxPLN.Size = new System.Drawing.Size(400, 30);
            this.textBoxPLN.TabIndex = 1;
            // 
            // textBoxEN
            // 
            this.textBoxEN.Location = new System.Drawing.Point(142, 105);
            this.textBoxEN.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.textBoxEN.Name = "textBoxEN";
            this.textBoxEN.Size = new System.Drawing.Size(391, 30);
            this.textBoxEN.TabIndex = 2;
            // 
            // textBoxELN
            // 
            this.textBoxELN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.textBoxELN.Location = new System.Drawing.Point(1060, 102);
            this.textBoxELN.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.textBoxELN.Name = "textBoxELN";
            this.textBoxELN.Size = new System.Drawing.Size(400, 30);
            this.textBoxELN.TabIndex = 3;
            // 
            // textBoxE
            // 
            this.textBoxE.Location = new System.Drawing.Point(142, 141);
            this.textBoxE.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.textBoxE.Name = "textBoxE";
            this.textBoxE.Size = new System.Drawing.Size(391, 30);
            this.textBoxE.TabIndex = 4;
            // 
            // textBoxUC
            // 
            this.textBoxUC.Location = new System.Drawing.Point(143, 179);
            this.textBoxUC.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.textBoxUC.Name = "textBoxUC";
            this.textBoxUC.Size = new System.Drawing.Size(391, 30);
            this.textBoxUC.TabIndex = 5;
            // 
            // textBoxP
            // 
            this.textBoxP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.textBoxP.Location = new System.Drawing.Point(1060, 179);
            this.textBoxP.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.textBoxP.Name = "textBoxP";
            this.textBoxP.Size = new System.Drawing.Size(400, 30);
            this.textBoxP.TabIndex = 6;
            // 
            // textBoxEP
            // 
            this.textBoxEP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.textBoxEP.Location = new System.Drawing.Point(1060, 142);
            this.textBoxEP.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.textBoxEP.Name = "textBoxEP";
            this.textBoxEP.Size = new System.Drawing.Size(400, 30);
            this.textBoxEP.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(14, 75);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "نام(فارسی)";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(871, 72);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "نام خانوادگی (فارسی)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(14, 105);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "First Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(871, 110);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 25);
            this.label4.TabIndex = 11;
            this.label4.Text = "Last Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(14, 141);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 25);
            this.label5.TabIndex = 12;
            this.label5.Text = "Email";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(15, 183);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 25);
            this.label6.TabIndex = 13;
            this.label6.Text = "User Code";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(871, 179);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 25);
            this.label7.TabIndex = 14;
            this.label7.Text = "Password";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(871, 146);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(165, 25);
            this.label8.TabIndex = 15;
            this.label8.Text = "Email Password";
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(519, 431);
            this.Save.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(160, 71);
            this.Save.TabIndex = 16;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(701, 431);
            this.Clear.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(156, 71);
            this.Clear.TabIndex = 17;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(892, 431);
            this.Search.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(156, 71);
            this.Search.TabIndex = 18;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel1.Location = new System.Drawing.Point(707, 656);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(271, 25);
            this.linkLabel1.TabIndex = 19;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "kiarashmoshar@gmail.com";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(577, 656);
            this.label9.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 18);
            this.label9.TabIndex = 20;
            this.label9.Text = "Email me at:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.persianNameDataGridViewTextBoxColumn,
            this.englishNameDataGridViewTextBoxColumn,
            this.persianLNameDataGridViewTextBoxColumn,
            this.englishLNameDataGridViewTextBoxColumn,
            this.userCodeDataGridViewTextBoxColumn,
            this.passCodeDataGridViewTextBoxColumn,
            this.emailAddressDataGridViewTextBoxColumn,
            this.emailPassDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.infoBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(303, 237);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(844, 169);
            this.dataGridView1.TabIndex = 21;
            // 
            // searchNameToolStrip
            // 
            this.searchNameToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.searchNameToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.englishNameToolStripLabel,
            this.englishNameToolStripTextBox,
            this.searchNameToolStripButton});
            this.searchNameToolStrip.Location = new System.Drawing.Point(0, 0);
            this.searchNameToolStrip.Name = "searchNameToolStrip";
            this.searchNameToolStrip.Size = new System.Drawing.Size(1785, 27);
            this.searchNameToolStrip.TabIndex = 22;
            this.searchNameToolStrip.Text = "searchNameToolStrip";
            // 
            // englishNameToolStripLabel
            // 
            this.englishNameToolStripLabel.Name = "englishNameToolStripLabel";
            this.englishNameToolStripLabel.Size = new System.Drawing.Size(99, 24);
            this.englishNameToolStripLabel.Text = "EnglishName:";
            // 
            // englishNameToolStripTextBox
            // 
            this.englishNameToolStripTextBox.Name = "englishNameToolStripTextBox";
            this.englishNameToolStripTextBox.Size = new System.Drawing.Size(100, 27);
            // 
            // searchNameToolStripButton
            // 
            this.searchNameToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.searchNameToolStripButton.Name = "searchNameToolStripButton";
            this.searchNameToolStripButton.Size = new System.Drawing.Size(97, 24);
            this.searchNameToolStripButton.Text = "SearchName";
            this.searchNameToolStripButton.Click += new System.EventHandler(this.searchNameToolStripButton_Click);
            // 
            // persianNameDataGridViewTextBoxColumn
            // 
            this.persianNameDataGridViewTextBoxColumn.DataPropertyName = "PersianName";
            this.persianNameDataGridViewTextBoxColumn.HeaderText = "PersianName";
            this.persianNameDataGridViewTextBoxColumn.Name = "persianNameDataGridViewTextBoxColumn";
            // 
            // englishNameDataGridViewTextBoxColumn
            // 
            this.englishNameDataGridViewTextBoxColumn.DataPropertyName = "EnglishName";
            this.englishNameDataGridViewTextBoxColumn.HeaderText = "EnglishName";
            this.englishNameDataGridViewTextBoxColumn.Name = "englishNameDataGridViewTextBoxColumn";
            // 
            // persianLNameDataGridViewTextBoxColumn
            // 
            this.persianLNameDataGridViewTextBoxColumn.DataPropertyName = "PersianLName";
            this.persianLNameDataGridViewTextBoxColumn.HeaderText = "PersianLName";
            this.persianLNameDataGridViewTextBoxColumn.Name = "persianLNameDataGridViewTextBoxColumn";
            // 
            // englishLNameDataGridViewTextBoxColumn
            // 
            this.englishLNameDataGridViewTextBoxColumn.DataPropertyName = "EnglishLName";
            this.englishLNameDataGridViewTextBoxColumn.HeaderText = "EnglishLName";
            this.englishLNameDataGridViewTextBoxColumn.Name = "englishLNameDataGridViewTextBoxColumn";
            // 
            // userCodeDataGridViewTextBoxColumn
            // 
            this.userCodeDataGridViewTextBoxColumn.DataPropertyName = "UserCode";
            this.userCodeDataGridViewTextBoxColumn.HeaderText = "UserCode";
            this.userCodeDataGridViewTextBoxColumn.Name = "userCodeDataGridViewTextBoxColumn";
            // 
            // passCodeDataGridViewTextBoxColumn
            // 
            this.passCodeDataGridViewTextBoxColumn.DataPropertyName = "PassCode";
            this.passCodeDataGridViewTextBoxColumn.HeaderText = "PassCode";
            this.passCodeDataGridViewTextBoxColumn.Name = "passCodeDataGridViewTextBoxColumn";
            // 
            // emailAddressDataGridViewTextBoxColumn
            // 
            this.emailAddressDataGridViewTextBoxColumn.DataPropertyName = "EmailAddress";
            this.emailAddressDataGridViewTextBoxColumn.HeaderText = "EmailAddress";
            this.emailAddressDataGridViewTextBoxColumn.Name = "emailAddressDataGridViewTextBoxColumn";
            // 
            // emailPassDataGridViewTextBoxColumn
            // 
            this.emailPassDataGridViewTextBoxColumn.DataPropertyName = "EmailPass";
            this.emailPassDataGridViewTextBoxColumn.HeaderText = "EmailPass";
            this.emailPassDataGridViewTextBoxColumn.Name = "emailPassDataGridViewTextBoxColumn";
            // 
            // infoBindingSource
            // 
            this.infoBindingSource.DataMember = "info";
            this.infoBindingSource.DataSource = this.mihanTakDataSet;
            // 
            // mihanTakDataSet
            // 
            this.mihanTakDataSet.DataSetName = "MihanTakDataSet";
            this.mihanTakDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // infoTableAdapter
            // 
            this.infoTableAdapter.ClearBeforeFill = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MihanTakApp.Properties.Resources.Background_HD_Perfect_C83;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1785, 701);
            this.Controls.Add(this.searchNameToolStrip);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxEP);
            this.Controls.Add(this.textBoxP);
            this.Controls.Add(this.textBoxUC);
            this.Controls.Add(this.textBoxE);
            this.Controls.Add(this.textBoxELN);
            this.Controls.Add(this.textBoxEN);
            this.Controls.Add(this.textBoxPLN);
            this.Controls.Add(this.textBoxPN);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.searchNameToolStrip.ResumeLayout(false);
            this.searchNameToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.infoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mihanTakDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxPN;
        private System.Windows.Forms.TextBox textBoxPLN;
        private System.Windows.Forms.TextBox textBoxEN;
        private System.Windows.Forms.TextBox textBoxELN;
        private System.Windows.Forms.TextBox textBoxE;
        private System.Windows.Forms.TextBox textBoxUC;
        private System.Windows.Forms.TextBox textBoxP;
        private System.Windows.Forms.TextBox textBoxEP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MihanTakDataSet mihanTakDataSet;
        private System.Windows.Forms.BindingSource infoBindingSource;
        private MihanTakDataSetTableAdapters.infoTableAdapter infoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn persianNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn englishNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn persianLNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn englishLNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailPassDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStrip searchNameToolStrip;
        private System.Windows.Forms.ToolStripLabel englishNameToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox englishNameToolStripTextBox;
        private System.Windows.Forms.ToolStripButton searchNameToolStripButton;
    }
}


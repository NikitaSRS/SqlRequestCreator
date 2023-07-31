namespace ParentElement
{
    partial class UCTableCreating
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.TBAttributes = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.CBTypes = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TBSize = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CBPK = new System.Windows.Forms.CheckBox();
            this.CBNULL = new System.Windows.Forms.CheckBox();
            this.CBidentity = new System.Windows.Forms.CheckBox();
            this.TB1 = new System.Windows.Forms.TextBox();
            this.TB2 = new System.Windows.Forms.TextBox();
            this.TB3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TBAttributes
            // 
            this.TBAttributes.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.TBAttributes.Location = new System.Drawing.Point(28, 32);
            this.TBAttributes.Name = "TBAttributes";
            this.TBAttributes.Size = new System.Drawing.Size(200, 35);
            this.TBAttributes.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Attribute name:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1252, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 75);
            this.button1.TabIndex = 2;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CBTypes
            // 
            this.CBTypes.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.CBTypes.FormattingEnabled = true;
            this.CBTypes.Items.AddRange(new object[] {
            "bigint",
            "numeric",
            "bit",
            "smallint",
            "decimal",
            "smallmoney",
            "int",
            "tinyint",
            "money",
            "float",
            "real",
            "date",
            "datetimeoffset",
            "datetime2",
            "smalldatetime",
            "datetime",
            "time",
            "char",
            "varchar",
            "text",
            "nchar",
            "nvarchar",
            "ntext",
            "binary",
            "varbinary",
            "image"});
            this.CBTypes.Location = new System.Drawing.Point(234, 32);
            this.CBTypes.Name = "CBTypes";
            this.CBTypes.Size = new System.Drawing.Size(200, 37);
            this.CBTypes.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(231, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Type:";
            // 
            // TBSize
            // 
            this.TBSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.TBSize.Location = new System.Drawing.Point(440, 32);
            this.TBSize.Name = "TBSize";
            this.TBSize.Size = new System.Drawing.Size(100, 35);
            this.TBSize.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(437, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Size:";
            // 
            // CBPK
            // 
            this.CBPK.AutoSize = true;
            this.CBPK.Location = new System.Drawing.Point(563, 16);
            this.CBPK.Name = "CBPK";
            this.CBPK.Size = new System.Drawing.Size(87, 17);
            this.CBPK.TabIndex = 7;
            this.CBPK.Text = "Primary Key?";
            this.CBPK.UseVisualStyleBackColor = true;
            this.CBPK.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // CBNULL
            // 
            this.CBNULL.AutoSize = true;
            this.CBNULL.Location = new System.Drawing.Point(563, 74);
            this.CBNULL.Name = "CBNULL";
            this.CBNULL.Size = new System.Drawing.Size(60, 17);
            this.CBNULL.TabIndex = 8;
            this.CBNULL.Text = "NULL?";
            this.CBNULL.UseVisualStyleBackColor = true;
            // 
            // CBidentity
            // 
            this.CBidentity.AutoSize = true;
            this.CBidentity.Location = new System.Drawing.Point(563, 46);
            this.CBidentity.Name = "CBidentity";
            this.CBidentity.Size = new System.Drawing.Size(66, 17);
            this.CBidentity.TabIndex = 9;
            this.CBidentity.Text = "Identity?";
            this.CBidentity.UseVisualStyleBackColor = true;
            this.CBidentity.CheckedChanged += new System.EventHandler(this.CBidentity_CheckedChanged);
            // 
            // TB1
            // 
            this.TB1.Location = new System.Drawing.Point(636, 46);
            this.TB1.Name = "TB1";
            this.TB1.ReadOnly = true;
            this.TB1.Size = new System.Drawing.Size(20, 20);
            this.TB1.TabIndex = 10;
            // 
            // TB2
            // 
            this.TB2.Location = new System.Drawing.Point(662, 46);
            this.TB2.Name = "TB2";
            this.TB2.ReadOnly = true;
            this.TB2.Size = new System.Drawing.Size(20, 20);
            this.TB2.TabIndex = 11;
            // 
            // TB3
            // 
            this.TB3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.TB3.Location = new System.Drawing.Point(707, 32);
            this.TB3.Name = "TB3";
            this.TB3.Size = new System.Drawing.Size(200, 35);
            this.TB3.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(704, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Parameters:";
            // 
            // UCTableCreating
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TB3);
            this.Controls.Add(this.TB2);
            this.Controls.Add(this.TB1);
            this.Controls.Add(this.CBidentity);
            this.Controls.Add(this.CBNULL);
            this.Controls.Add(this.CBPK);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TBSize);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CBTypes);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TBAttributes);
            this.Name = "UCTableCreating";
            this.Size = new System.Drawing.Size(1340, 100);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.TextBox TBAttributes;
        private System.Windows.Forms.ComboBox CBTypes;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox TBSize;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox CBPK;
        private System.Windows.Forms.CheckBox CBNULL;
        private System.Windows.Forms.CheckBox CBidentity;
        private System.Windows.Forms.TextBox TB1;
        private System.Windows.Forms.TextBox TB2;
        public System.Windows.Forms.TextBox TB3;
        private System.Windows.Forms.Label label4;
    }
}

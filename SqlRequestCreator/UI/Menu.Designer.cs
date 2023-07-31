
namespace SqlRequestCreator
{
    partial class SqlRequestCreatorF : ParentForm.Forms.FormParent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SqlRequestCreatorF));
            this.butLanguageChange = new System.Windows.Forms.Button();
            this.butCreateTable = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.butSelect = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // butLanguageChange
            // 
            this.butLanguageChange.Location = new System.Drawing.Point(1472, 12);
            this.butLanguageChange.Name = "butLanguageChange";
            this.butLanguageChange.Size = new System.Drawing.Size(100, 100);
            this.butLanguageChange.TabIndex = 1;
            this.butLanguageChange.Text = "EN";
            this.butLanguageChange.UseVisualStyleBackColor = true;
            this.butLanguageChange.Click += new System.EventHandler(this.butLanguageChange_Click);
            // 
            // butCreateTable
            // 
            this.butCreateTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.butCreateTable.Location = new System.Drawing.Point(12, 12);
            this.butCreateTable.Name = "butCreateTable";
            this.butCreateTable.Size = new System.Drawing.Size(350, 100);
            this.butCreateTable.TabIndex = 2;
            this.butCreateTable.Text = "Create table";
            this.butCreateTable.UseVisualStyleBackColor = true;
            this.butCreateTable.Click += new System.EventHandler(this.butCreateTable_Click);
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // butSelect
            // 
            this.butSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.butSelect.Location = new System.Drawing.Point(12, 145);
            this.butSelect.Name = "butSelect";
            this.butSelect.Size = new System.Drawing.Size(350, 100);
            this.butSelect.TabIndex = 3;
            this.butSelect.Text = "Create Request";
            this.butSelect.UseVisualStyleBackColor = true;
            // 
            // SqlRequestCreatorF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1584, 861);
            this.Controls.Add(this.butSelect);
            this.Controls.Add(this.butCreateTable);
            this.Controls.Add(this.butLanguageChange);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = true;
            this.Name = "SqlRequestCreatorF";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SqlRequestCreatorF_FormClosing);
            this.Load += new System.EventHandler(this.SqlRequestCreatorF_Load);
            this.Controls.SetChildIndex(this.butLanguageChange, 0);
            this.Controls.SetChildIndex(this.butCreateTable, 0);
            this.Controls.SetChildIndex(this.butSelect, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button butLanguageChange;
        public System.Windows.Forms.Button butCreateTable;
        private System.Windows.Forms.Timer timer;
        public System.Windows.Forms.Button butSelect;
    }
}



namespace SqlRequestCreator.UI
{
    partial class TableCreatingF
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
            this.butBack = new System.Windows.Forms.Button();
            this.TBScheme = new System.Windows.Forms.TextBox();
            this.TBTableName = new System.Windows.Forms.TextBox();
            this.butAdd = new System.Windows.Forms.Button();
            this.FLP = new System.Windows.Forms.FlowLayoutPanel();
            this.butCompile = new System.Windows.Forms.Button();
            this.CBAttr = new System.Windows.Forms.ComboBox();
            this.GBFK = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TBTable = new System.Windows.Forms.TextBox();
            this.TBAttrib = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.butAddFK = new System.Windows.Forms.Button();
            this.GBFK.SuspendLayout();
            this.SuspendLayout();
            // 
            // butBack
            // 
            this.butBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.25F);
            this.butBack.Location = new System.Drawing.Point(1408, 12);
            this.butBack.Name = "butBack";
            this.butBack.Size = new System.Drawing.Size(164, 64);
            this.butBack.TabIndex = 2;
            this.butBack.Text = "------>";
            this.butBack.UseVisualStyleBackColor = true;
            this.butBack.Click += new System.EventHandler(this.butBack_Click);
            // 
            // TBScheme
            // 
            this.TBScheme.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.TBScheme.Location = new System.Drawing.Point(1368, 99);
            this.TBScheme.Name = "TBScheme";
            this.TBScheme.Size = new System.Drawing.Size(200, 35);
            this.TBScheme.TabIndex = 4;
            this.TBScheme.Enter += new System.EventHandler(this.TBScheme_Enter);
            // 
            // TBTableName
            // 
            this.TBTableName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.TBTableName.Location = new System.Drawing.Point(1368, 140);
            this.TBTableName.Name = "TBTableName";
            this.TBTableName.Size = new System.Drawing.Size(200, 35);
            this.TBTableName.TabIndex = 5;
            this.TBTableName.Enter += new System.EventHandler(this.TBTableName_Enter);
            // 
            // butAdd
            // 
            this.butAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.butAdd.Location = new System.Drawing.Point(1368, 733);
            this.butAdd.Name = "butAdd";
            this.butAdd.Size = new System.Drawing.Size(200, 50);
            this.butAdd.TabIndex = 7;
            this.butAdd.Text = "Add new attribute";
            this.butAdd.UseVisualStyleBackColor = true;
            this.butAdd.Click += new System.EventHandler(this.butAdd_Click);
            // 
            // FLP
            // 
            this.FLP.BackColor = System.Drawing.Color.Azure;
            this.FLP.Location = new System.Drawing.Point(12, 34);
            this.FLP.Name = "FLP";
            this.FLP.Size = new System.Drawing.Size(1340, 771);
            this.FLP.TabIndex = 8;
            this.FLP.CursorChanged += new System.EventHandler(this.FLP_CursorChanged);
            this.FLP.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.FLP_ControlAdded);
            this.FLP.Enter += new System.EventHandler(this.FLP_Enter);
            // 
            // butCompile
            // 
            this.butCompile.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.butCompile.Location = new System.Drawing.Point(1368, 677);
            this.butCompile.Name = "butCompile";
            this.butCompile.Size = new System.Drawing.Size(200, 50);
            this.butCompile.TabIndex = 9;
            this.butCompile.Text = "Compiling request";
            this.butCompile.UseVisualStyleBackColor = true;
            this.butCompile.Click += new System.EventHandler(this.butCompile_Click);
            // 
            // CBAttr
            // 
            this.CBAttr.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.CBAttr.FormattingEnabled = true;
            this.CBAttr.Location = new System.Drawing.Point(6, 40);
            this.CBAttr.Name = "CBAttr";
            this.CBAttr.Size = new System.Drawing.Size(100, 37);
            this.CBAttr.TabIndex = 10;
            this.CBAttr.Enter += new System.EventHandler(this.CBAttr_Enter);
            // 
            // GBFK
            // 
            this.GBFK.Controls.Add(this.butAddFK);
            this.GBFK.Controls.Add(this.label3);
            this.GBFK.Controls.Add(this.label2);
            this.GBFK.Controls.Add(this.TBAttrib);
            this.GBFK.Controls.Add(this.TBTable);
            this.GBFK.Controls.Add(this.label1);
            this.GBFK.Controls.Add(this.CBAttr);
            this.GBFK.Location = new System.Drawing.Point(1368, 181);
            this.GBFK.Name = "GBFK";
            this.GBFK.Size = new System.Drawing.Size(200, 268);
            this.GBFK.TabIndex = 10;
            this.GBFK.TabStop = false;
            this.GBFK.Text = "Foreign Keys";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Choose attribute";
            // 
            // TBTable
            // 
            this.TBTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.TBTable.Location = new System.Drawing.Point(9, 108);
            this.TBTable.Name = "TBTable";
            this.TBTable.Size = new System.Drawing.Size(185, 35);
            this.TBTable.TabIndex = 12;
            // 
            // TBAttrib
            // 
            this.TBAttrib.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.TBAttrib.Location = new System.Drawing.Point(9, 171);
            this.TBAttrib.Name = "TBAttrib";
            this.TBAttrib.Size = new System.Drawing.Size(185, 35);
            this.TBAttrib.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Foreign table";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Foreign attribute";
            // 
            // butAddFK
            // 
            this.butAddFK.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.butAddFK.Location = new System.Drawing.Point(9, 212);
            this.butAddFK.Name = "butAddFK";
            this.butAddFK.Size = new System.Drawing.Size(185, 50);
            this.butAddFK.TabIndex = 11;
            this.butAddFK.Text = "Add FK";
            this.butAddFK.UseVisualStyleBackColor = true;
            this.butAddFK.Click += new System.EventHandler(this.button1_Click);
            // 
            // TableCreatingF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1584, 861);
            this.Controls.Add(this.GBFK);
            this.Controls.Add(this.butCompile);
            this.Controls.Add(this.FLP);
            this.Controls.Add(this.butAdd);
            this.Controls.Add(this.TBTableName);
            this.Controls.Add(this.TBScheme);
            this.Controls.Add(this.butBack);
            this.Name = "TableCreatingF";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TableCreatingF_FormClosing);
            this.Controls.SetChildIndex(this.butBack, 0);
            this.Controls.SetChildIndex(this.TBScheme, 0);
            this.Controls.SetChildIndex(this.TBTableName, 0);
            this.Controls.SetChildIndex(this.butAdd, 0);
            this.Controls.SetChildIndex(this.FLP, 0);
            this.Controls.SetChildIndex(this.butCompile, 0);
            this.Controls.SetChildIndex(this.GBFK, 0);
            this.GBFK.ResumeLayout(false);
            this.GBFK.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butBack;
        private System.Windows.Forms.TextBox TBScheme;
        private System.Windows.Forms.TextBox TBTableName;
        private System.Windows.Forms.Button butAdd;
        private System.Windows.Forms.FlowLayoutPanel FLP;
        private System.Windows.Forms.Button butCompile;
        private System.Windows.Forms.ComboBox CBAttr;
        private System.Windows.Forms.GroupBox GBFK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TBAttrib;
        private System.Windows.Forms.TextBox TBTable;
        private System.Windows.Forms.Button butAddFK;
    }
}
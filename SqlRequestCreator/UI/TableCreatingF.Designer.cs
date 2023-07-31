
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
            // 
            // TableCreatingF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1584, 861);
            this.Controls.Add(this.FLP);
            this.Controls.Add(this.butAdd);
            this.Controls.Add(this.TBTableName);
            this.Controls.Add(this.TBScheme);
            this.Controls.Add(this.butBack);
            this.Name = "TableCreatingF";
            this.Text = "TableCreatingF";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TableCreatingF_FormClosing);
            this.Controls.SetChildIndex(this.butBack, 0);
            this.Controls.SetChildIndex(this.TBScheme, 0);
            this.Controls.SetChildIndex(this.TBTableName, 0);
            this.Controls.SetChildIndex(this.butAdd, 0);
            this.Controls.SetChildIndex(this.FLP, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butBack;
        private System.Windows.Forms.TextBox TBScheme;
        private System.Windows.Forms.TextBox TBTableName;
        private System.Windows.Forms.Button butAdd;
        private System.Windows.Forms.FlowLayoutPanel FLP;
    }
}
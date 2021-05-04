
namespace SuperShop
{
    partial class Search_Update
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
            this.label1 = new System.Windows.Forms.Label();
            this.dtItems = new System.Windows.Forms.DataGridView();
            this.bt_Load = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Search = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.tb_IpriceUpdate = new System.Windows.Forms.TextBox();
            this.tb_InameUpdate = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_SrchId = new System.Windows.Forms.TextBox();
            this.btn_Back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtItems)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.MintCream;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(301, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search and Update";
            // 
            // dtItems
            // 
            this.dtItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtItems.Location = new System.Drawing.Point(455, 122);
            this.dtItems.Name = "dtItems";
            this.dtItems.Size = new System.Drawing.Size(240, 150);
            this.dtItems.TabIndex = 1;
            // 
            // bt_Load
            // 
            this.bt_Load.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Load.Location = new System.Drawing.Point(154, 173);
            this.bt_Load.Name = "bt_Load";
            this.bt_Load.Size = new System.Drawing.Size(124, 38);
            this.bt_Load.TabIndex = 13;
            this.bt_Load.Text = "Load";
            this.bt_Load.UseVisualStyleBackColor = true;
            this.bt_Load.Click += new System.EventHandler(this.bt_Load_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(301, 318);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 24);
            this.label2.TabIndex = 14;
            this.label2.Text = "Update Panel";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.MintCream;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(330, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 26);
            this.label3.TabIndex = 15;
            this.label3.Text = "Load to See";
            // 
            // btn_Search
            // 
            this.btn_Search.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.Location = new System.Drawing.Point(603, 361);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(124, 38);
            this.btn_Search.TabIndex = 21;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Update.Location = new System.Drawing.Point(431, 557);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(124, 38);
            this.btn_Update.TabIndex = 20;
            this.btn_Update.Text = "Update";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // tb_IpriceUpdate
            // 
            this.tb_IpriceUpdate.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_IpriceUpdate.Location = new System.Drawing.Point(331, 493);
            this.tb_IpriceUpdate.Name = "tb_IpriceUpdate";
            this.tb_IpriceUpdate.Size = new System.Drawing.Size(224, 32);
            this.tb_IpriceUpdate.TabIndex = 19;
            // 
            // tb_InameUpdate
            // 
            this.tb_InameUpdate.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_InameUpdate.Location = new System.Drawing.Point(331, 430);
            this.tb_InameUpdate.Name = "tb_InameUpdate";
            this.tb_InameUpdate.Size = new System.Drawing.Size(224, 32);
            this.tb_InameUpdate.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(150, 433);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 24);
            this.label4.TabIndex = 17;
            this.label4.Text = "Item Name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(138, 496);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 24);
            this.label5.TabIndex = 16;
            this.label5.Text = "Item Price:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(150, 368);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 24);
            this.label6.TabIndex = 22;
            this.label6.Text = "Item Id:";
            // 
            // tb_SrchId
            // 
            this.tb_SrchId.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_SrchId.Location = new System.Drawing.Point(331, 365);
            this.tb_SrchId.Name = "tb_SrchId";
            this.tb_SrchId.Size = new System.Drawing.Size(224, 32);
            this.tb_SrchId.TabIndex = 23;
            // 
            // btn_Back
            // 
            this.btn_Back.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Back.Location = new System.Drawing.Point(132, 557);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(124, 38);
            this.btn_Back.TabIndex = 24;
            this.btn_Back.Text = "Back";
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // Search_Update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 659);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.tb_SrchId);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.tb_IpriceUpdate);
            this.Controls.Add(this.tb_InameUpdate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bt_Load);
            this.Controls.Add(this.dtItems);
            this.Controls.Add(this.label1);
            this.Name = "Search_Update";
            this.Text = "Search_Update";
            ((System.ComponentModel.ISupportInitialize)(this.dtItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtItems;
        private System.Windows.Forms.Button bt_Load;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.TextBox tb_IpriceUpdate;
        private System.Windows.Forms.TextBox tb_InameUpdate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_SrchId;
        private System.Windows.Forms.Button btn_Back;
    }
}

namespace SuperShop
{
    partial class Delete
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
            this.tb_SrchId = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_Search = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.bt_Load = new System.Windows.Forms.Button();
            this.dtItems = new System.Windows.Forms.DataGridView();
            this.btn_Back = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.tb_IpriceUpdate = new System.Windows.Forms.TextBox();
            this.tb_InameUpdate = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtItems)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Lavender;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(347, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Delete Items";
            // 
            // tb_SrchId
            // 
            this.tb_SrchId.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_SrchId.Location = new System.Drawing.Point(303, 383);
            this.tb_SrchId.Name = "tb_SrchId";
            this.tb_SrchId.Size = new System.Drawing.Size(224, 32);
            this.tb_SrchId.TabIndex = 30;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(122, 386);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 24);
            this.label6.TabIndex = 29;
            this.label6.Text = "Item Id:";
            // 
            // btn_Search
            // 
            this.btn_Search.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.Location = new System.Drawing.Point(575, 379);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(124, 38);
            this.btn_Search.TabIndex = 28;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.MintCream;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(351, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 26);
            this.label3.TabIndex = 26;
            this.label3.Text = "Load to See";
            // 
            // bt_Load
            // 
            this.bt_Load.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Load.Location = new System.Drawing.Point(126, 191);
            this.bt_Load.Name = "bt_Load";
            this.bt_Load.Size = new System.Drawing.Size(124, 38);
            this.bt_Load.TabIndex = 25;
            this.bt_Load.Text = "Load";
            this.bt_Load.UseVisualStyleBackColor = true;
            this.bt_Load.Click += new System.EventHandler(this.bt_Load_Click);
            // 
            // dtItems
            // 
            this.dtItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtItems.Location = new System.Drawing.Point(427, 140);
            this.dtItems.Name = "dtItems";
            this.dtItems.Size = new System.Drawing.Size(240, 150);
            this.dtItems.TabIndex = 24;
            // 
            // btn_Back
            // 
            this.btn_Back.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Back.Location = new System.Drawing.Point(126, 614);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(124, 38);
            this.btn_Back.TabIndex = 31;
            this.btn_Back.Text = "Back";
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Delete.Location = new System.Drawing.Point(575, 614);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(124, 38);
            this.btn_Delete.TabIndex = 32;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // tb_IpriceUpdate
            // 
            this.tb_IpriceUpdate.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_IpriceUpdate.Location = new System.Drawing.Point(301, 509);
            this.tb_IpriceUpdate.Name = "tb_IpriceUpdate";
            this.tb_IpriceUpdate.Size = new System.Drawing.Size(224, 32);
            this.tb_IpriceUpdate.TabIndex = 36;
            // 
            // tb_InameUpdate
            // 
            this.tb_InameUpdate.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_InameUpdate.Location = new System.Drawing.Point(301, 446);
            this.tb_InameUpdate.Name = "tb_InameUpdate";
            this.tb_InameUpdate.Size = new System.Drawing.Size(224, 32);
            this.tb_InameUpdate.TabIndex = 35;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(120, 449);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 24);
            this.label4.TabIndex = 34;
            this.label4.Text = "Item Name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(108, 512);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 24);
            this.label5.TabIndex = 33;
            this.label5.Text = "Item Price:";
            // 
            // Delete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(800, 716);
            this.Controls.Add(this.tb_IpriceUpdate);
            this.Controls.Add(this.tb_InameUpdate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.tb_SrchId);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bt_Load);
            this.Controls.Add(this.dtItems);
            this.Controls.Add(this.label1);
            this.Name = "Delete";
            this.Text = "Delete";
            ((System.ComponentModel.ISupportInitialize)(this.dtItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_SrchId;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bt_Load;
        private System.Windows.Forms.DataGridView dtItems;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.TextBox tb_IpriceUpdate;
        private System.Windows.Forms.TextBox tb_InameUpdate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}
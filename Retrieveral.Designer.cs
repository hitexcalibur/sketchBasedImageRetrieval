namespace GraphicalCS
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SelectPicBox = new System.Windows.Forms.PictureBox();
            this.QueryPicBox = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.LVQueryByVision = new System.Windows.Forms.ListView();
            this.OpenQueryImg = new System.Windows.Forms.Button();
            this.OpenDataBase = new System.Windows.Forms.Button();
            this.ExFeature = new System.Windows.Forms.Button();
            this.DetectOnVision = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.DatabaseTextBox = new System.Windows.Forms.TextBox();
            this.QueryByVisionList = new System.Windows.Forms.ImageList(this.components);
            this.Draw = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SelectPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QueryPicBox)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SelectPicBox);
            this.groupBox1.Controls.Add(this.QueryPicBox);
            this.groupBox1.Location = new System.Drawing.Point(1, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 383);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SelectPic";
            // 
            // SelectPicBox
            // 
            this.SelectPicBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.SelectPicBox.Location = new System.Drawing.Point(6, 207);
            this.SelectPicBox.Name = "SelectPicBox";
            this.SelectPicBox.Size = new System.Drawing.Size(188, 175);
            this.SelectPicBox.TabIndex = 1;
            this.SelectPicBox.TabStop = false;
            // 
            // QueryPicBox
            // 
            this.QueryPicBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.QueryPicBox.Location = new System.Drawing.Point(6, 20);
            this.QueryPicBox.Name = "QueryPicBox";
            this.QueryPicBox.Size = new System.Drawing.Size(188, 175);
            this.QueryPicBox.TabIndex = 0;
            this.QueryPicBox.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.LVQueryByVision);
            this.groupBox2.Location = new System.Drawing.Point(207, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(427, 258);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "QueryResult";
            // 
            // LVQueryByVision
            // 
            this.LVQueryByVision.Location = new System.Drawing.Point(6, 20);
            this.LVQueryByVision.Name = "LVQueryByVision";
            this.LVQueryByVision.Size = new System.Drawing.Size(415, 232);
            this.LVQueryByVision.TabIndex = 2;
            this.LVQueryByVision.UseCompatibleStateImageBehavior = false;
            // 
            // OpenQueryImg
            // 
            this.OpenQueryImg.Location = new System.Drawing.Point(213, 287);
            this.OpenQueryImg.Name = "OpenQueryImg";
            this.OpenQueryImg.Size = new System.Drawing.Size(103, 23);
            this.OpenQueryImg.TabIndex = 2;
            this.OpenQueryImg.Text = "Open Query";
            this.OpenQueryImg.UseVisualStyleBackColor = true;
            this.OpenQueryImg.Click += new System.EventHandler(this.OpenQueryImg_Click);
            // 
            // OpenDataBase
            // 
            this.OpenDataBase.Location = new System.Drawing.Point(213, 345);
            this.OpenDataBase.Name = "OpenDataBase";
            this.OpenDataBase.Size = new System.Drawing.Size(103, 23);
            this.OpenDataBase.TabIndex = 3;
            this.OpenDataBase.Text = "Open DataBase";
            this.OpenDataBase.UseVisualStyleBackColor = true;
            this.OpenDataBase.Click += new System.EventHandler(this.OpenDataBase_Click);
            // 
            // ExFeature
            // 
            this.ExFeature.Location = new System.Drawing.Point(351, 308);
            this.ExFeature.Name = "ExFeature";
            this.ExFeature.Size = new System.Drawing.Size(223, 23);
            this.ExFeature.TabIndex = 4;
            this.ExFeature.Text = "Extract Features";
            this.ExFeature.UseVisualStyleBackColor = true;
            this.ExFeature.Click += new System.EventHandler(this.ExFeature_Click);
            // 
            // DetectOnVision
            // 
            this.DetectOnVision.Location = new System.Drawing.Point(351, 337);
            this.DetectOnVision.Name = "DetectOnVision";
            this.DetectOnVision.Size = new System.Drawing.Size(223, 23);
            this.DetectOnVision.TabIndex = 5;
            this.DetectOnVision.Text = "Detect On Vision";
            this.DetectOnVision.UseVisualStyleBackColor = true;
            this.DetectOnVision.Click += new System.EventHandler(this.DetectOnVision_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(65, 418);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 6;
            this.label1.Text = "DataBase Path";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DatabaseTextBox
            // 
            this.DatabaseTextBox.Location = new System.Drawing.Point(171, 417);
            this.DatabaseTextBox.Name = "DatabaseTextBox";
            this.DatabaseTextBox.ReadOnly = true;
            this.DatabaseTextBox.Size = new System.Drawing.Size(334, 21);
            this.DatabaseTextBox.TabIndex = 7;
            // 
            // QueryByVisionList
            // 
            this.QueryByVisionList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.QueryByVisionList.ImageSize = new System.Drawing.Size(16, 16);
            this.QueryByVisionList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // Draw
            // 
            this.Draw.Location = new System.Drawing.Point(213, 316);
            this.Draw.Name = "Draw";
            this.Draw.Size = new System.Drawing.Size(103, 23);
            this.Draw.TabIndex = 8;
            this.Draw.Text = "Draw";
            this.Draw.UseVisualStyleBackColor = true;
            this.Draw.Click += new System.EventHandler(this.Draw_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 450);
            this.Controls.Add(this.Draw);
            this.Controls.Add(this.DatabaseTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DetectOnVision);
            this.Controls.Add(this.ExFeature);
            this.Controls.Add(this.OpenDataBase);
            this.Controls.Add(this.OpenQueryImg);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "ImageRetrieval";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SelectPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QueryPicBox)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.PictureBox QueryPicBox;
        private System.Windows.Forms.PictureBox SelectPicBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView LVQueryByVision;
        private System.Windows.Forms.Button OpenQueryImg;
        private System.Windows.Forms.Button OpenDataBase;
        private System.Windows.Forms.Button ExFeature;
        private System.Windows.Forms.Button DetectOnVision;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox DatabaseTextBox;
        private System.Windows.Forms.ImageList QueryByVisionList;
        private System.Windows.Forms.Button Draw;
    }
}


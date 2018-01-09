namespace StuQuery.Forms
{
    partial class AttributeQueryForm
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
            this.cboLayer = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.listBoxField = new System.Windows.Forms.ListBox();
            this.listBoxValue = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBoxSql = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.Btnequal = new System.Windows.Forms.Button();
            this.btnunequal = new System.Windows.Forms.Button();
            this.btnis = new System.Windows.Forms.Button();
            this.btnlike = new System.Windows.Forms.Button();
            this.btnmore = new System.Windows.Forms.Button();
            this.Btnless = new System.Windows.Forms.Button();
            this.btnmoe = new System.Windows.Forms.Button();
            this.btnloe = new System.Windows.Forms.Button();
            this.btnor = new System.Windows.Forms.Button();
            this.btnnull = new System.Windows.Forms.Button();
            this.Btnnot = new System.Windows.Forms.Button();
            this.btnand = new System.Windows.Forms.Button();
            this.btnin = new System.Windows.Forms.Button();
            this.btnunderline = new System.Windows.Forms.Button();
            this.btnpercent = new System.Windows.Forms.Button();
            this.Btncharacter = new System.Windows.Forms.Button();
            this.btnbetween = new System.Windows.Forms.Button();
            this.btnspace = new System.Windows.Forms.Button();
            this.btnempty = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboLayer
            // 
            this.cboLayer.FormattingEnabled = true;
            this.cboLayer.Location = new System.Drawing.Point(68, 12);
            this.cboLayer.Name = "cboLayer";
            this.cboLayer.Size = new System.Drawing.Size(306, 20);
            this.cboLayer.TabIndex = 0;
            this.cboLayer.SelectedIndexChanged += new System.EventHandler(this.cboLayer_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(50, 21);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "图层：";
            // 
            // listBoxField
            // 
            this.listBoxField.FormattingEnabled = true;
            this.listBoxField.ItemHeight = 12;
            this.listBoxField.Location = new System.Drawing.Point(12, 71);
            this.listBoxField.Name = "listBoxField";
            this.listBoxField.Size = new System.Drawing.Size(169, 124);
            this.listBoxField.TabIndex = 2;
            this.listBoxField.SelectedIndexChanged += new System.EventHandler(this.listBoxField_SelectedIndexChanged);
            this.listBoxField.DoubleClick += new System.EventHandler(this.listBoxField_DoubleClick);
            // 
            // listBoxValue
            // 
            this.listBoxValue.FormattingEnabled = true;
            this.listBoxValue.ItemHeight = 12;
            this.listBoxValue.Location = new System.Drawing.Point(205, 71);
            this.listBoxValue.Name = "listBoxValue";
            this.listBoxValue.Size = new System.Drawing.Size(169, 124);
            this.listBoxValue.TabIndex = 3;
            this.listBoxValue.DoubleClick += new System.EventHandler(this.listBoxValue_DoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnempty);
            this.groupBox1.Controls.Add(this.btnspace);
            this.groupBox1.Controls.Add(this.btnbetween);
            this.groupBox1.Controls.Add(this.Btncharacter);
            this.groupBox1.Controls.Add(this.btnpercent);
            this.groupBox1.Controls.Add(this.btnunderline);
            this.groupBox1.Controls.Add(this.btnin);
            this.groupBox1.Controls.Add(this.btnand);
            this.groupBox1.Controls.Add(this.Btnnot);
            this.groupBox1.Controls.Add(this.btnnull);
            this.groupBox1.Controls.Add(this.btnor);
            this.groupBox1.Controls.Add(this.btnloe);
            this.groupBox1.Controls.Add(this.btnmoe);
            this.groupBox1.Controls.Add(this.Btnless);
            this.groupBox1.Controls.Add(this.btnmore);
            this.groupBox1.Controls.Add(this.btnlike);
            this.groupBox1.Controls.Add(this.btnis);
            this.groupBox1.Controls.Add(this.btnunequal);
            this.groupBox1.Controls.Add(this.Btnequal);
            this.groupBox1.Location = new System.Drawing.Point(15, 218);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(346, 164);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "表达式";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 44);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(50, 21);
            this.textBox2.TabIndex = 5;
            this.textBox2.Text = "字段：";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(205, 44);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(50, 21);
            this.textBox3.TabIndex = 6;
            this.textBox3.Text = "取值：";
            // 
            // textBoxSql
            // 
            this.textBoxSql.Location = new System.Drawing.Point(12, 423);
            this.textBoxSql.Name = "textBoxSql";
            this.textBoxSql.Size = new System.Drawing.Size(362, 21);
            this.textBoxSql.TabIndex = 7;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(12, 396);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(169, 21);
            this.textBox5.TabIndex = 8;
            this.textBox5.Text = "Select * From Table Where：";
            // 
            // Btnequal
            // 
            this.Btnequal.Location = new System.Drawing.Point(6, 20);
            this.Btnequal.Name = "Btnequal";
            this.Btnequal.Size = new System.Drawing.Size(60, 30);
            this.Btnequal.TabIndex = 0;
            this.Btnequal.Text = "=";
            this.Btnequal.UseVisualStyleBackColor = true;
            this.Btnequal.Click += new System.EventHandler(this.Btnequal_Click);
            // 
            // btnunequal
            // 
            this.btnunequal.Location = new System.Drawing.Point(72, 20);
            this.btnunequal.Name = "btnunequal";
            this.btnunequal.Size = new System.Drawing.Size(60, 30);
            this.btnunequal.TabIndex = 1;
            this.btnunequal.Text = "!=";
            this.btnunequal.UseVisualStyleBackColor = true;
            // 
            // btnis
            // 
            this.btnis.Location = new System.Drawing.Point(138, 20);
            this.btnis.Name = "btnis";
            this.btnis.Size = new System.Drawing.Size(60, 30);
            this.btnis.TabIndex = 2;
            this.btnis.Text = "is";
            this.btnis.UseVisualStyleBackColor = true;
            this.btnis.Click += new System.EventHandler(this.btnis_Click);
            // 
            // btnlike
            // 
            this.btnlike.Location = new System.Drawing.Point(204, 20);
            this.btnlike.Name = "btnlike";
            this.btnlike.Size = new System.Drawing.Size(60, 30);
            this.btnlike.TabIndex = 3;
            this.btnlike.Text = "like";
            this.btnlike.UseVisualStyleBackColor = true;
            // 
            // btnmore
            // 
            this.btnmore.Location = new System.Drawing.Point(270, 20);
            this.btnmore.Name = "btnmore";
            this.btnmore.Size = new System.Drawing.Size(60, 30);
            this.btnmore.TabIndex = 4;
            this.btnmore.Text = ">";
            this.btnmore.UseVisualStyleBackColor = true;
            this.btnmore.Click += new System.EventHandler(this.btnmore_Click);
            // 
            // Btnless
            // 
            this.Btnless.Location = new System.Drawing.Point(6, 56);
            this.Btnless.Name = "Btnless";
            this.Btnless.Size = new System.Drawing.Size(60, 30);
            this.Btnless.TabIndex = 5;
            this.Btnless.Text = "<";
            this.Btnless.UseVisualStyleBackColor = true;
            // 
            // btnmoe
            // 
            this.btnmoe.Location = new System.Drawing.Point(72, 56);
            this.btnmoe.Name = "btnmoe";
            this.btnmoe.Size = new System.Drawing.Size(60, 30);
            this.btnmoe.TabIndex = 6;
            this.btnmoe.Text = ">=";
            this.btnmoe.UseVisualStyleBackColor = true;
            // 
            // btnloe
            // 
            this.btnloe.Location = new System.Drawing.Point(138, 56);
            this.btnloe.Name = "btnloe";
            this.btnloe.Size = new System.Drawing.Size(60, 30);
            this.btnloe.TabIndex = 7;
            this.btnloe.Text = "<=";
            this.btnloe.UseVisualStyleBackColor = true;
            // 
            // btnor
            // 
            this.btnor.Location = new System.Drawing.Point(204, 56);
            this.btnor.Name = "btnor";
            this.btnor.Size = new System.Drawing.Size(60, 30);
            this.btnor.TabIndex = 8;
            this.btnor.Text = "Or";
            this.btnor.UseVisualStyleBackColor = true;
            // 
            // btnnull
            // 
            this.btnnull.Location = new System.Drawing.Point(270, 56);
            this.btnnull.Name = "btnnull";
            this.btnnull.Size = new System.Drawing.Size(60, 30);
            this.btnnull.TabIndex = 9;
            this.btnnull.Text = "Null";
            this.btnnull.UseVisualStyleBackColor = true;
            // 
            // Btnnot
            // 
            this.Btnnot.Location = new System.Drawing.Point(6, 92);
            this.Btnnot.Name = "Btnnot";
            this.Btnnot.Size = new System.Drawing.Size(60, 30);
            this.Btnnot.TabIndex = 10;
            this.Btnnot.Text = "Not";
            this.Btnnot.UseVisualStyleBackColor = true;
            // 
            // btnand
            // 
            this.btnand.Location = new System.Drawing.Point(72, 92);
            this.btnand.Name = "btnand";
            this.btnand.Size = new System.Drawing.Size(60, 30);
            this.btnand.TabIndex = 11;
            this.btnand.Text = "And";
            this.btnand.UseVisualStyleBackColor = true;
            // 
            // btnin
            // 
            this.btnin.Location = new System.Drawing.Point(138, 92);
            this.btnin.Name = "btnin";
            this.btnin.Size = new System.Drawing.Size(60, 30);
            this.btnin.TabIndex = 12;
            this.btnin.Text = "In";
            this.btnin.UseVisualStyleBackColor = true;
            // 
            // btnunderline
            // 
            this.btnunderline.Location = new System.Drawing.Point(204, 92);
            this.btnunderline.Name = "btnunderline";
            this.btnunderline.Size = new System.Drawing.Size(60, 30);
            this.btnunderline.TabIndex = 13;
            this.btnunderline.Text = "_";
            this.btnunderline.UseVisualStyleBackColor = true;
            // 
            // btnpercent
            // 
            this.btnpercent.Location = new System.Drawing.Point(270, 92);
            this.btnpercent.Name = "btnpercent";
            this.btnpercent.Size = new System.Drawing.Size(60, 30);
            this.btnpercent.TabIndex = 14;
            this.btnpercent.Text = "%";
            this.btnpercent.UseVisualStyleBackColor = true;
            // 
            // Btncharacter
            // 
            this.Btncharacter.Location = new System.Drawing.Point(6, 128);
            this.Btncharacter.Name = "Btncharacter";
            this.Btncharacter.Size = new System.Drawing.Size(75, 30);
            this.Btncharacter.TabIndex = 15;
            this.Btncharacter.Text = "\'\'";
            this.Btncharacter.UseVisualStyleBackColor = true;
            this.Btncharacter.Click += new System.EventHandler(this.Btncharacter_Click);
            // 
            // btnbetween
            // 
            this.btnbetween.Location = new System.Drawing.Point(91, 128);
            this.btnbetween.Name = "btnbetween";
            this.btnbetween.Size = new System.Drawing.Size(75, 30);
            this.btnbetween.TabIndex = 16;
            this.btnbetween.Text = "Between";
            this.btnbetween.UseVisualStyleBackColor = true;
            // 
            // btnspace
            // 
            this.btnspace.Location = new System.Drawing.Point(174, 128);
            this.btnspace.Name = "btnspace";
            this.btnspace.Size = new System.Drawing.Size(75, 30);
            this.btnspace.TabIndex = 17;
            this.btnspace.Text = "空格";
            this.btnspace.UseVisualStyleBackColor = true;
            // 
            // btnempty
            // 
            this.btnempty.Location = new System.Drawing.Point(255, 128);
            this.btnempty.Name = "btnempty";
            this.btnempty.Size = new System.Drawing.Size(75, 30);
            this.btnempty.TabIndex = 18;
            this.btnempty.Text = "清空";
            this.btnempty.UseVisualStyleBackColor = true;
            this.btnempty.Click += new System.EventHandler(this.btnempty_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(12, 450);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(97, 30);
            this.btnOK.TabIndex = 19;
            this.btnOK.Text = "查找";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(248, 450);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 30);
            this.button1.TabIndex = 20;
            this.button1.Text = "取消";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // AttributeQueryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 487);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBoxSql);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listBoxValue);
            this.Controls.Add(this.listBoxField);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.cboLayer);
            this.Name = "AttributeQueryForm";
            this.Text = "属性查询";
            this.Load += new System.EventHandler(this.AttributeQueryForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboLayer;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox listBoxField;
        private System.Windows.Forms.ListBox listBoxValue;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnempty;
        private System.Windows.Forms.Button btnspace;
        private System.Windows.Forms.Button btnbetween;
        private System.Windows.Forms.Button Btncharacter;
        private System.Windows.Forms.Button btnpercent;
        private System.Windows.Forms.Button btnunderline;
        private System.Windows.Forms.Button btnin;
        private System.Windows.Forms.Button btnand;
        private System.Windows.Forms.Button Btnnot;
        private System.Windows.Forms.Button btnnull;
        private System.Windows.Forms.Button btnor;
        private System.Windows.Forms.Button btnloe;
        private System.Windows.Forms.Button btnmoe;
        private System.Windows.Forms.Button Btnless;
        private System.Windows.Forms.Button btnmore;
        private System.Windows.Forms.Button btnlike;
        private System.Windows.Forms.Button btnis;
        private System.Windows.Forms.Button btnunequal;
        private System.Windows.Forms.Button Btnequal;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBoxSql;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button button1;
    }
}
namespace app01
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbox_name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbox_race = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbox_age = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbox_weight = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbox_size = new System.Windows.Forms.TextBox();
            this.list_view_animals = new System.Windows.Forms.ListView();
            this.btn_add = new System.Windows.Forms.Button();
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.age = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.size = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.weight = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.race = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lbl_code = new System.Windows.Forms.Label();
            this.code = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // tbox_name
            // 
            this.tbox_name.Location = new System.Drawing.Point(39, 78);
            this.tbox_name.Name = "tbox_name";
            this.tbox_name.Size = new System.Drawing.Size(100, 20);
            this.tbox_name.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(422, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "label3";
            // 
            // cbox_race
            // 
            this.cbox_race.FormattingEnabled = true;
            this.cbox_race.Items.AddRange(new object[] {
            "Chihuahua",
            "Dalmata",
            "Dogo",
            "Pastor Aleman"});
            this.cbox_race.Location = new System.Drawing.Point(425, 77);
            this.cbox_race.Name = "cbox_race";
            this.cbox_race.Size = new System.Drawing.Size(121, 21);
            this.cbox_race.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "label4";
            // 
            // tbox_age
            // 
            this.tbox_age.Location = new System.Drawing.Point(39, 151);
            this.tbox_age.Name = "tbox_age";
            this.tbox_age.Size = new System.Drawing.Size(100, 20);
            this.tbox_age.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(303, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "label5";
            // 
            // tbox_weight
            // 
            this.tbox_weight.Location = new System.Drawing.Point(306, 151);
            this.tbox_weight.Name = "tbox_weight";
            this.tbox_weight.Size = new System.Drawing.Size(100, 20);
            this.tbox_weight.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(595, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "label6";
            // 
            // tbox_size
            // 
            this.tbox_size.Location = new System.Drawing.Point(598, 150);
            this.tbox_size.Name = "tbox_size";
            this.tbox_size.Size = new System.Drawing.Size(100, 20);
            this.tbox_size.TabIndex = 10;
            // 
            // list_view_animals
            // 
            this.list_view_animals.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.code,
            this.name,
            this.age,
            this.size,
            this.weight,
            this.race});
            this.list_view_animals.Location = new System.Drawing.Point(23, 225);
            this.list_view_animals.Name = "list_view_animals";
            this.list_view_animals.Size = new System.Drawing.Size(804, 244);
            this.list_view_animals.TabIndex = 11;
            this.list_view_animals.UseCompatibleStateImageBehavior = false;
            this.list_view_animals.View = System.Windows.Forms.View.Details;
            this.list_view_animals.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(662, 191);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(109, 23);
            this.btn_add.TabIndex = 12;
            this.btn_add.Text = "button1";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // name
            // 
            this.name.DisplayIndex = 0;
            this.name.Text = "Nombre";
            this.name.Width = 169;
            // 
            // age
            // 
            this.age.DisplayIndex = 1;
            this.age.Text = "Age";
            this.age.Width = 87;
            // 
            // size
            // 
            this.size.DisplayIndex = 2;
            this.size.Text = "Size";
            this.size.Width = 82;
            // 
            // weight
            // 
            this.weight.DisplayIndex = 3;
            this.weight.Text = "Weight";
            this.weight.Width = 131;
            // 
            // race
            // 
            this.race.DisplayIndex = 4;
            this.race.Text = "Race";
            this.race.Width = 102;
            // 
            // lbl_code
            // 
            this.lbl_code.AutoSize = true;
            this.lbl_code.Location = new System.Drawing.Point(91, 29);
            this.lbl_code.Name = "lbl_code";
            this.lbl_code.Size = new System.Drawing.Size(35, 13);
            this.lbl_code.TabIndex = 13;
            this.lbl_code.Text = "label7";
            // 
            // code
            // 
            this.code.DisplayIndex = 5;
            this.code.Text = "Code";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 481);
            this.Controls.Add(this.lbl_code);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.list_view_animals);
            this.Controls.Add(this.tbox_size);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbox_weight);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbox_age);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbox_race);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbox_name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbox_name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbox_race;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbox_age;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbox_weight;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbox_size;
        private System.Windows.Forms.ListView list_view_animals;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.ColumnHeader age;
        private System.Windows.Forms.ColumnHeader size;
        private System.Windows.Forms.ColumnHeader weight;
        private System.Windows.Forms.ColumnHeader race;
        private System.Windows.Forms.ColumnHeader code;
        private System.Windows.Forms.Label lbl_code;
    }
}


namespace _3rdassignment
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
            this.namelabel = new System.Windows.Forms.Label();
            this.contactlabel = new System.Windows.Forms.Label();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.itemcombobox = new System.Windows.Forms.ComboBox();
            this.showbutton = new System.Windows.Forms.Button();
            this.Savebutton = new System.Windows.Forms.Button();
            this.quantitytextbox = new System.Windows.Forms.TextBox();
            this.addresstextbox = new System.Windows.Forms.TextBox();
            this.phonenobox = new System.Windows.Forms.TextBox();
            this.nametextbox = new System.Windows.Forms.TextBox();
            this.quantitylabel = new System.Windows.Forms.Label();
            this.orderlabel = new System.Windows.Forms.Label();
            this.adresslabel = new System.Windows.Forms.Label();
            this.itemrichtextbox = new System.Windows.Forms.RichTextBox();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // namelabel
            // 
            this.namelabel.AutoSize = true;
            this.namelabel.Location = new System.Drawing.Point(34, 50);
            this.namelabel.Name = "namelabel";
            this.namelabel.Size = new System.Drawing.Size(106, 13);
            this.namelabel.TabIndex = 0;
            this.namelabel.Text = "Customer Information";
            // 
            // contactlabel
            // 
            this.contactlabel.AutoSize = true;
            this.contactlabel.Location = new System.Drawing.Point(34, 84);
            this.contactlabel.Name = "contactlabel";
            this.contactlabel.Size = new System.Drawing.Size(61, 13);
            this.contactlabel.TabIndex = 1;
            this.contactlabel.Text = "Contact No";
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.itemcombobox);
            this.groupBox.Controls.Add(this.showbutton);
            this.groupBox.Controls.Add(this.Savebutton);
            this.groupBox.Controls.Add(this.quantitytextbox);
            this.groupBox.Controls.Add(this.addresstextbox);
            this.groupBox.Controls.Add(this.phonenobox);
            this.groupBox.Controls.Add(this.nametextbox);
            this.groupBox.Controls.Add(this.quantitylabel);
            this.groupBox.Controls.Add(this.orderlabel);
            this.groupBox.Controls.Add(this.adresslabel);
            this.groupBox.Controls.Add(this.namelabel);
            this.groupBox.Controls.Add(this.contactlabel);
            this.groupBox.Location = new System.Drawing.Point(38, 36);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(369, 286);
            this.groupBox.TabIndex = 2;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Customer Information";
            // 
            // itemcombobox
            // 
            this.itemcombobox.FormattingEnabled = true;
            this.itemcombobox.Items.AddRange(new object[] {
            "Black",
            "Cold",
            "Hot",
            "Regular"});
            this.itemcombobox.Location = new System.Drawing.Point(146, 143);
            this.itemcombobox.Name = "itemcombobox";
            this.itemcombobox.Size = new System.Drawing.Size(152, 21);
            this.itemcombobox.TabIndex = 12;
            // 
            // showbutton
            // 
            this.showbutton.Location = new System.Drawing.Point(146, 241);
            this.showbutton.Name = "showbutton";
            this.showbutton.Size = new System.Drawing.Size(75, 23);
            this.showbutton.TabIndex = 11;
            this.showbutton.Text = "Show";
            this.showbutton.UseVisualStyleBackColor = true;
            this.showbutton.Click += new System.EventHandler(this.showbutton_Click);
            // 
            // Savebutton
            // 
            this.Savebutton.Location = new System.Drawing.Point(246, 241);
            this.Savebutton.Name = "Savebutton";
            this.Savebutton.Size = new System.Drawing.Size(75, 23);
            this.Savebutton.TabIndex = 10;
            this.Savebutton.Text = "Save";
            this.Savebutton.UseVisualStyleBackColor = true;
            this.Savebutton.Click += new System.EventHandler(this.Savebutton_Click);
            // 
            // quantitytextbox
            // 
            this.quantitytextbox.Location = new System.Drawing.Point(146, 179);
            this.quantitytextbox.Name = "quantitytextbox";
            this.quantitytextbox.Size = new System.Drawing.Size(175, 20);
            this.quantitytextbox.TabIndex = 9;
            // 
            // addresstextbox
            // 
            this.addresstextbox.Location = new System.Drawing.Point(146, 110);
            this.addresstextbox.Name = "addresstextbox";
            this.addresstextbox.Size = new System.Drawing.Size(175, 20);
            this.addresstextbox.TabIndex = 7;
            // 
            // phonenobox
            // 
            this.phonenobox.Location = new System.Drawing.Point(146, 77);
            this.phonenobox.Name = "phonenobox";
            this.phonenobox.Size = new System.Drawing.Size(175, 20);
            this.phonenobox.TabIndex = 6;
            // 
            // nametextbox
            // 
            this.nametextbox.Location = new System.Drawing.Point(146, 47);
            this.nametextbox.Name = "nametextbox";
            this.nametextbox.Size = new System.Drawing.Size(175, 20);
            this.nametextbox.TabIndex = 5;
            // 
            // quantitylabel
            // 
            this.quantitylabel.AutoSize = true;
            this.quantitylabel.Location = new System.Drawing.Point(34, 186);
            this.quantitylabel.Name = "quantitylabel";
            this.quantitylabel.Size = new System.Drawing.Size(46, 13);
            this.quantitylabel.TabIndex = 4;
            this.quantitylabel.Text = "Quantity";
            // 
            // orderlabel
            // 
            this.orderlabel.AutoSize = true;
            this.orderlabel.Location = new System.Drawing.Point(34, 151);
            this.orderlabel.Name = "orderlabel";
            this.orderlabel.Size = new System.Drawing.Size(33, 13);
            this.orderlabel.TabIndex = 3;
            this.orderlabel.Text = "Order";
            // 
            // adresslabel
            // 
            this.adresslabel.AutoSize = true;
            this.adresslabel.Location = new System.Drawing.Point(34, 117);
            this.adresslabel.Name = "adresslabel";
            this.adresslabel.Size = new System.Drawing.Size(45, 13);
            this.adresslabel.TabIndex = 2;
            this.adresslabel.Text = "Address";
            // 
            // itemrichtextbox
            // 
            this.itemrichtextbox.Location = new System.Drawing.Point(463, 36);
            this.itemrichtextbox.Name = "itemrichtextbox";
            this.itemrichtextbox.Size = new System.Drawing.Size(278, 286);
            this.itemrichtextbox.TabIndex = 3;
            this.itemrichtextbox.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.itemrichtextbox);
            this.Controls.Add(this.groupBox);
            this.Name = "Form1";
            this.Text = "Coffeeshop";
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label namelabel;
        private System.Windows.Forms.Label contactlabel;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Button Savebutton;
        private System.Windows.Forms.TextBox quantitytextbox;
        private System.Windows.Forms.TextBox addresstextbox;
        private System.Windows.Forms.TextBox phonenobox;
        private System.Windows.Forms.TextBox nametextbox;
        private System.Windows.Forms.Label quantitylabel;
        private System.Windows.Forms.Label orderlabel;
        private System.Windows.Forms.Label adresslabel;
        private System.Windows.Forms.RichTextBox itemrichtextbox;
        private System.Windows.Forms.Button showbutton;
        private System.Windows.Forms.ComboBox itemcombobox;
    }
}


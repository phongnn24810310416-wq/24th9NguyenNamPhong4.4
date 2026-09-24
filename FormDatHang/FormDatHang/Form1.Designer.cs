namespace FormDatHang
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lstMenu = new ListBox();
            lstSelected = new ListBox();
            btnAdd = new Button();
            btnRemove = new Button();
            lblTotal = new Label();
            SuspendLayout();
            // 
            // lstMenu
            // 
            lstMenu.FormattingEnabled = true;
            lstMenu.Location = new Point(200, 150);
            lstMenu.Name = "lstMenu";
            lstMenu.SelectionMode = SelectionMode.MultiExtended;
            lstMenu.Size = new Size(120, 94);
            lstMenu.TabIndex = 0;
            // 
            // lstSelected
            // 
            lstSelected.FormattingEnabled = true;
            lstSelected.Location = new Point(430, 150);
            lstSelected.Name = "lstSelected";
            lstSelected.Size = new Size(120, 94);
            lstSelected.TabIndex = 1;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(338, 167);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 2;
            btnAdd.Text = ">";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnRemove
            // 
            btnRemove.Location = new Point(338, 209);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(75, 23);
            btnRemove.TabIndex = 3;
            btnRemove.Text = "<";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(338, 267);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(97, 15);
            lblTotal.TabIndex = 4;
            lblTotal.Text = "Tổng tiền: 0 VNĐ";
            lblTotal.Click += lblTotal_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblTotal);
            Controls.Add(btnRemove);
            Controls.Add(btnAdd);
            Controls.Add(lstSelected);
            Controls.Add(lstMenu);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstMenu;
        private ListBox lstSelected;
        private Button btnAdd;
        private Button btnRemove;
        private Label lblTotal;
    }
}

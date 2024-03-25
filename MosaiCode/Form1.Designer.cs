namespace MosaiCode
{
    partial class MosaiCode
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MosaiCode));
            txtLink = new TextBox();
            bt_CriarQR = new Button();
            pctQR = new PictureBox();
            bt_Cola = new Button();
            lb01 = new Label();
            ((System.ComponentModel.ISupportInitialize)pctQR).BeginInit();
            SuspendLayout();
            // 
            // txtLink
            // 
            txtLink.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtLink.Location = new Point(29, 48);
            txtLink.Name = "txtLink";
            txtLink.Size = new Size(302, 27);
            txtLink.TabIndex = 0;
            txtLink.TextAlign = HorizontalAlignment.Center;
            // 
            // bt_CriarQR
            // 
            bt_CriarQR.BackColor = Color.DarkGreen;
            bt_CriarQR.Cursor = Cursors.Hand;
            bt_CriarQR.FlatStyle = FlatStyle.Popup;
            bt_CriarQR.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bt_CriarQR.ForeColor = SystemColors.Window;
            bt_CriarQR.Location = new Point(29, 366);
            bt_CriarQR.Name = "bt_CriarQR";
            bt_CriarQR.Size = new Size(302, 51);
            bt_CriarQR.TabIndex = 1;
            bt_CriarQR.Text = "GERAR QR CODE";
            bt_CriarQR.UseVisualStyleBackColor = false;
            bt_CriarQR.Click += bt_CriarQR_Click;
            // 
            // pctQR
            // 
            pctQR.BorderStyle = BorderStyle.FixedSingle;
            pctQR.Location = new Point(29, 81);
            pctQR.Name = "pctQR";
            pctQR.Size = new Size(302, 279);
            pctQR.TabIndex = 2;
            pctQR.TabStop = false;
            // 
            // bt_Cola
            // 
            bt_Cola.AccessibleDescription = "Colar da área de transferência";
            bt_Cola.BackColor = Color.Transparent;
            bt_Cola.CausesValidation = false;
            bt_Cola.Cursor = Cursors.Hand;
            bt_Cola.FlatAppearance.BorderSize = 0;
            bt_Cola.FlatStyle = FlatStyle.Flat;
            bt_Cola.ForeColor = Color.Transparent;
            bt_Cola.Image = (Image)resources.GetObject("bt_Cola.Image");
            bt_Cola.Location = new Point(328, 47);
            bt_Cola.Name = "bt_Cola";
            bt_Cola.Size = new Size(30, 28);
            bt_Cola.TabIndex = 3;
            bt_Cola.Tag = "";
            bt_Cola.UseVisualStyleBackColor = false;
            bt_Cola.Click += bt_Cola_Click;
            // 
            // lb01
            // 
            lb01.AutoSize = true;
            lb01.Font = new Font("Gadugi", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb01.Location = new Point(101, 20);
            lb01.Name = "lb01";
            lb01.Size = new Size(165, 25);
            lb01.TabIndex = 4;
            lb01.Text = "Cole o Link aqui:";
            // 
            // MosaiCode
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(467, 450);
            Controls.Add(pctQR);
            Controls.Add(lb01);
            Controls.Add(bt_CriarQR);
            Controls.Add(txtLink);
            Controls.Add(bt_Cola);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "MosaiCode";
            Text = "MosaiCode";
            ((System.ComponentModel.ISupportInitialize)pctQR).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtLink;
        private Button bt_CriarQR;
        private PictureBox pctQR;
        private Button bt_Cola;
        private Label lb01;
    }
}

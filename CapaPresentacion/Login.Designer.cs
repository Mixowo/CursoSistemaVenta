namespace CapaPresentacion
{
    partial class Login
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
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.btningresar = new FontAwesome.Sharp.IconButton();
            this.btncancelar = new FontAwesome.Sharp.IconButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtnumdoc = new System.Windows.Forms.TextBox();
            this.txtclave = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(333, 323);
            this.label1.TabIndex = 0;
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Store;
            this.iconPictureBox1.IconColor = System.Drawing.Color.White;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 242;
            this.iconPictureBox1.Location = new System.Drawing.Point(40, 41);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(242, 245);
            this.iconPictureBox1.TabIndex = 1;
            this.iconPictureBox1.TabStop = false;
            // 
            // btningresar
            // 
            this.btningresar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btningresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btningresar.ForeColor = System.Drawing.Color.Black;
            this.btningresar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btningresar.IconColor = System.Drawing.Color.Black;
            this.btningresar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btningresar.Location = new System.Drawing.Point(383, 242);
            this.btningresar.Name = "btningresar";
            this.btningresar.Size = new System.Drawing.Size(149, 44);
            this.btningresar.TabIndex = 2;
            this.btningresar.Text = "Ingresar";
            this.btningresar.UseVisualStyleBackColor = false;
            this.btningresar.Click += new System.EventHandler(this.btningresar_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btncancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncancelar.ForeColor = System.Drawing.Color.Black;
            this.btncancelar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btncancelar.IconColor = System.Drawing.Color.Black;
            this.btncancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btncancelar.Location = new System.Drawing.Point(556, 242);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(143, 44);
            this.btncancelar.TabIndex = 3;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = false;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(380, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Num. Documento";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(380, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Contraseña";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtnumdoc
            // 
            this.txtnumdoc.Location = new System.Drawing.Point(383, 66);
            this.txtnumdoc.Name = "txtnumdoc";
            this.txtnumdoc.Size = new System.Drawing.Size(364, 22);
            this.txtnumdoc.TabIndex = 6;
            this.txtnumdoc.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtclave
            // 
            this.txtclave.Location = new System.Drawing.Point(383, 176);
            this.txtclave.Name = "txtclave";
            this.txtclave.PasswordChar = '?';
            this.txtclave.Size = new System.Drawing.Size(364, 22);
            this.txtclave.TabIndex = 7;
            this.txtclave.TextChanged += new System.EventHandler(this.txtclave_TextChanged);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(844, 323);
            this.Controls.Add(this.txtclave);
            this.Controls.Add(this.txtnumdoc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btningresar);
            this.Controls.Add(this.iconPictureBox1);
            this.Controls.Add(this.label1);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private FontAwesome.Sharp.IconButton btningresar;
        private FontAwesome.Sharp.IconButton btncancelar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtnumdoc;
        private System.Windows.Forms.TextBox txtclave;
    }
}
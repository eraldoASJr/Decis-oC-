namespace aulaProjetoDecisao
{
    partial class Peso
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
            this.BtnPesoJoaoMaria = new System.Windows.Forms.Button();
            this.BtnVerificar = new System.Windows.Forms.Button();
            this.lblPeso1 = new System.Windows.Forms.Label();
            this.lblPeso2 = new System.Windows.Forms.Label();
            this.txtPeso1 = new System.Windows.Forms.TextBox();
            this.txtPeso2 = new System.Windows.Forms.TextBox();
            this.lblNome1 = new System.Windows.Forms.Label();
            this.txtNome1 = new System.Windows.Forms.TextBox();
            this.lblNome2 = new System.Windows.Forms.Label();
            this.txtNome2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnPesoJoaoMaria
            // 
            this.BtnPesoJoaoMaria.Location = new System.Drawing.Point(37, 160);
            this.BtnPesoJoaoMaria.Name = "BtnPesoJoaoMaria";
            this.BtnPesoJoaoMaria.Size = new System.Drawing.Size(234, 111);
            this.BtnPesoJoaoMaria.TabIndex = 0;
            this.BtnPesoJoaoMaria.Text = "Peso Joao e Maria";
            this.BtnPesoJoaoMaria.UseVisualStyleBackColor = true;
            this.BtnPesoJoaoMaria.Click += new System.EventHandler(this.BtnPesoJoaoMaria_Click);
            // 
            // BtnVerificar
            // 
            this.BtnVerificar.Location = new System.Drawing.Point(519, 425);
            this.BtnVerificar.Name = "BtnVerificar";
            this.BtnVerificar.Size = new System.Drawing.Size(370, 59);
            this.BtnVerificar.TabIndex = 1;
            this.BtnVerificar.Text = "Verificar";
            this.BtnVerificar.UseVisualStyleBackColor = true;
            // 
            // lblPeso1
            // 
            this.lblPeso1.AutoSize = true;
            this.lblPeso1.Location = new System.Drawing.Point(512, 114);
            this.lblPeso1.Name = "lblPeso1";
            this.lblPeso1.Size = new System.Drawing.Size(119, 42);
            this.lblPeso1.TabIndex = 2;
            this.lblPeso1.Text = "Peso ";
            // 
            // lblPeso2
            // 
            this.lblPeso2.AutoSize = true;
            this.lblPeso2.Location = new System.Drawing.Point(512, 314);
            this.lblPeso2.Name = "lblPeso2";
            this.lblPeso2.Size = new System.Drawing.Size(108, 42);
            this.lblPeso2.TabIndex = 3;
            this.lblPeso2.Text = "Peso";
            // 
            // txtPeso1
            // 
            this.txtPeso1.Location = new System.Drawing.Point(676, 111);
            this.txtPeso1.Name = "txtPeso1";
            this.txtPeso1.Size = new System.Drawing.Size(100, 49);
            this.txtPeso1.TabIndex = 4;
            // 
            // txtPeso2
            // 
            this.txtPeso2.Location = new System.Drawing.Point(676, 314);
            this.txtPeso2.Name = "txtPeso2";
            this.txtPeso2.Size = new System.Drawing.Size(100, 49);
            this.txtPeso2.TabIndex = 5;
            // 
            // lblNome1
            // 
            this.lblNome1.AutoSize = true;
            this.lblNome1.Location = new System.Drawing.Point(512, 38);
            this.lblNome1.Name = "lblNome1";
            this.lblNome1.Size = new System.Drawing.Size(121, 42);
            this.lblNome1.TabIndex = 6;
            this.lblNome1.Text = "Nome";
            // 
            // txtNome1
            // 
            this.txtNome1.Location = new System.Drawing.Point(676, 38);
            this.txtNome1.Name = "txtNome1";
            this.txtNome1.Size = new System.Drawing.Size(239, 49);
            this.txtNome1.TabIndex = 7;
            // 
            // lblNome2
            // 
            this.lblNome2.AutoSize = true;
            this.lblNome2.Location = new System.Drawing.Point(512, 251);
            this.lblNome2.Name = "lblNome2";
            this.lblNome2.Size = new System.Drawing.Size(121, 42);
            this.lblNome2.TabIndex = 8;
            this.lblNome2.Text = "Nome";
            // 
            // txtNome2
            // 
            this.txtNome2.Location = new System.Drawing.Point(676, 244);
            this.txtNome2.Name = "txtNome2";
            this.txtNome2.Size = new System.Drawing.Size(247, 49);
            this.txtNome2.TabIndex = 9;
            // 
            // Peso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(23F, 42F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.txtNome2);
            this.Controls.Add(this.lblNome2);
            this.Controls.Add(this.txtNome1);
            this.Controls.Add(this.lblNome1);
            this.Controls.Add(this.txtPeso2);
            this.Controls.Add(this.txtPeso1);
            this.Controls.Add(this.lblPeso2);
            this.Controls.Add(this.lblPeso1);
            this.Controls.Add(this.BtnVerificar);
            this.Controls.Add(this.BtnPesoJoaoMaria);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.Name = "Peso";
            this.Text = "Peso";
            this.Load += new System.EventHandler(this.Peso_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnPesoJoaoMaria;
        private System.Windows.Forms.Button BtnVerificar;
        private System.Windows.Forms.Label lblPeso1;
        private System.Windows.Forms.Label lblPeso2;
        private System.Windows.Forms.TextBox txtPeso1;
        private System.Windows.Forms.TextBox txtPeso2;
        private System.Windows.Forms.Label lblNome1;
        private System.Windows.Forms.TextBox txtNome1;
        private System.Windows.Forms.Label lblNome2;
        private System.Windows.Forms.TextBox txtNome2;
    }
}
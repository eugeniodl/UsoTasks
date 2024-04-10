namespace WinTasks
{
    partial class FrmTasks
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
            this.btnIniciar = new System.Windows.Forms.Button();
            this.pb1 = new System.Windows.Forms.ProgressBar();
            this.pb2 = new System.Windows.Forms.ProgressBar();
            this.pb3 = new System.Windows.Forms.ProgressBar();
            this.pb4 = new System.Windows.Forms.ProgressBar();
            this.txtConteo1 = new System.Windows.Forms.TextBox();
            this.txtConteo2 = new System.Windows.Forms.TextBox();
            this.txtConteo3 = new System.Windows.Forms.TextBox();
            this.txtConteo4 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnIniciar
            // 
            this.btnIniciar.Location = new System.Drawing.Point(39, 37);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(75, 23);
            this.btnIniciar.TabIndex = 0;
            this.btnIniciar.Text = "Iniciar";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // pb1
            // 
            this.pb1.Location = new System.Drawing.Point(39, 80);
            this.pb1.Name = "pb1";
            this.pb1.Size = new System.Drawing.Size(100, 23);
            this.pb1.TabIndex = 1;
            // 
            // pb2
            // 
            this.pb2.Location = new System.Drawing.Point(172, 80);
            this.pb2.Name = "pb2";
            this.pb2.Size = new System.Drawing.Size(100, 23);
            this.pb2.TabIndex = 2;
            // 
            // pb3
            // 
            this.pb3.Location = new System.Drawing.Point(299, 80);
            this.pb3.Name = "pb3";
            this.pb3.Size = new System.Drawing.Size(100, 23);
            this.pb3.TabIndex = 3;
            // 
            // pb4
            // 
            this.pb4.Location = new System.Drawing.Point(425, 80);
            this.pb4.Name = "pb4";
            this.pb4.Size = new System.Drawing.Size(100, 23);
            this.pb4.TabIndex = 4;
            // 
            // txtConteo1
            // 
            this.txtConteo1.Location = new System.Drawing.Point(39, 122);
            this.txtConteo1.Multiline = true;
            this.txtConteo1.Name = "txtConteo1";
            this.txtConteo1.Size = new System.Drawing.Size(100, 301);
            this.txtConteo1.TabIndex = 5;
            // 
            // txtConteo2
            // 
            this.txtConteo2.Location = new System.Drawing.Point(172, 122);
            this.txtConteo2.Multiline = true;
            this.txtConteo2.Name = "txtConteo2";
            this.txtConteo2.Size = new System.Drawing.Size(100, 301);
            this.txtConteo2.TabIndex = 6;
            // 
            // txtConteo3
            // 
            this.txtConteo3.Location = new System.Drawing.Point(299, 122);
            this.txtConteo3.Multiline = true;
            this.txtConteo3.Name = "txtConteo3";
            this.txtConteo3.Size = new System.Drawing.Size(100, 301);
            this.txtConteo3.TabIndex = 7;
            // 
            // txtConteo4
            // 
            this.txtConteo4.Location = new System.Drawing.Point(425, 122);
            this.txtConteo4.Multiline = true;
            this.txtConteo4.Name = "txtConteo4";
            this.txtConteo4.Size = new System.Drawing.Size(100, 301);
            this.txtConteo4.TabIndex = 8;
            // 
            // FrmTasks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 450);
            this.Controls.Add(this.txtConteo4);
            this.Controls.Add(this.txtConteo3);
            this.Controls.Add(this.txtConteo2);
            this.Controls.Add(this.txtConteo1);
            this.Controls.Add(this.pb4);
            this.Controls.Add(this.pb3);
            this.Controls.Add(this.pb2);
            this.Controls.Add(this.pb1);
            this.Controls.Add(this.btnIniciar);
            this.Name = "FrmTasks";
            this.Text = "FrmTasks";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnIniciar;
        private ProgressBar pb1;
        private ProgressBar pb2;
        private ProgressBar pb3;
        private ProgressBar pb4;
        private TextBox txtConteo1;
        private TextBox txtConteo2;
        private TextBox txtConteo3;
        private TextBox txtConteo4;
    }
}
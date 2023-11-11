namespace Componentes
{
    partial class F_Timer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_Timer));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btn_iniciarT1 = new System.Windows.Forms.Button();
            this.btn_pararT1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_reiniciarT1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bt_iniciarCarro = new System.Windows.Forms.Button();
            this.timer_carro = new System.Windows.Forms.Timer(this.components);
            this.bt_pararCarro = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btn_iniciarT1
            // 
            this.btn_iniciarT1.Location = new System.Drawing.Point(13, 13);
            this.btn_iniciarT1.Name = "btn_iniciarT1";
            this.btn_iniciarT1.Size = new System.Drawing.Size(75, 23);
            this.btn_iniciarT1.TabIndex = 0;
            this.btn_iniciarT1.Text = "Iniciar";
            this.btn_iniciarT1.UseVisualStyleBackColor = true;
            this.btn_iniciarT1.Click += new System.EventHandler(this.btn_iniciarT1_Click);
            // 
            // btn_pararT1
            // 
            this.btn_pararT1.Location = new System.Drawing.Point(94, 12);
            this.btn_pararT1.Name = "btn_pararT1";
            this.btn_pararT1.Size = new System.Drawing.Size(75, 23);
            this.btn_pararT1.TabIndex = 1;
            this.btn_pararT1.Text = "Parar";
            this.btn_pararT1.UseVisualStyleBackColor = true;
            this.btn_pararT1.Click += new System.EventHandler(this.btn_pararT1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // bt_reiniciarT1
            // 
            this.bt_reiniciarT1.Location = new System.Drawing.Point(175, 12);
            this.bt_reiniciarT1.Name = "bt_reiniciarT1";
            this.bt_reiniciarT1.Size = new System.Drawing.Size(75, 23);
            this.bt_reiniciarT1.TabIndex = 3;
            this.bt_reiniciarT1.Text = "Reiniciar";
            this.bt_reiniciarT1.UseVisualStyleBackColor = true;
            this.bt_reiniciarT1.Click += new System.EventHandler(this.bt_reiniciarT1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 126);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(88, 78);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // bt_iniciarCarro
            // 
            this.bt_iniciarCarro.Location = new System.Drawing.Point(15, 97);
            this.bt_iniciarCarro.Name = "bt_iniciarCarro";
            this.bt_iniciarCarro.Size = new System.Drawing.Size(75, 23);
            this.bt_iniciarCarro.TabIndex = 5;
            this.bt_iniciarCarro.Text = "Iniciar Carro";
            this.bt_iniciarCarro.UseVisualStyleBackColor = true;
            this.bt_iniciarCarro.Click += new System.EventHandler(this.bt_iniciarCarro_Click);
            // 
            // timer_carro
            // 
            this.timer_carro.Tick += new System.EventHandler(this.timer_carro_Tick);
            // 
            // bt_pararCarro
            // 
            this.bt_pararCarro.Location = new System.Drawing.Point(96, 97);
            this.bt_pararCarro.Name = "bt_pararCarro";
            this.bt_pararCarro.Size = new System.Drawing.Size(75, 23);
            this.bt_pararCarro.TabIndex = 6;
            this.bt_pararCarro.Text = "Parar Carro";
            this.bt_pararCarro.UseVisualStyleBackColor = true;
            this.bt_pararCarro.Click += new System.EventHandler(this.bt_pararCarro_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 216);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "label2";
            // 
            // F_Timer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bt_pararCarro);
            this.Controls.Add(this.bt_iniciarCarro);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.bt_reiniciarT1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_pararT1);
            this.Controls.Add(this.btn_iniciarT1);
            this.Name = "F_Timer";
            this.Text = "F_Timer";
            this.Load += new System.EventHandler(this.F_Timer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btn_iniciarT1;
        private System.Windows.Forms.Button btn_pararT1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_reiniciarT1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button bt_iniciarCarro;
        private System.Windows.Forms.Timer timer_carro;
        private System.Windows.Forms.Button bt_pararCarro;
        private System.Windows.Forms.Label label2;
    }
}
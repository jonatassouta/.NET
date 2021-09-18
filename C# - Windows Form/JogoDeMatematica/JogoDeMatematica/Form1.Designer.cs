
namespace JogoDeMatematica
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.TimeLabel = new System.Windows.Forms.Label();
            this.startQuiz = new System.Windows.Forms.Button();
            this.plusLeftLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.plusRightLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.somar = new System.Windows.Forms.NumericUpDown();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.multLeft = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.multRigth = new System.Windows.Forms.Label();
            this.multiplicacao = new System.Windows.Forms.NumericUpDown();
            this.subLeft = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.subRight = new System.Windows.Forms.Label();
            this.subtracao = new System.Windows.Forms.NumericUpDown();
            this.divLeft = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.divRigth = new System.Windows.Forms.Label();
            this.divisao = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.somar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.multiplicacao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subtracao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.divisao)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-6, -2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 47);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tempo Restante";
            // 
            // TimeLabel
            // 
            this.TimeLabel.AutoSize = true;
            this.TimeLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TimeLabel.Font = new System.Drawing.Font("Sitka Small", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeLabel.Location = new System.Drawing.Point(237, 7);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(155, 33);
            this.TimeLabel.TabIndex = 1;
            this.TimeLabel.Text = "30 segundos";
            // 
            // startQuiz
            // 
            this.startQuiz.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.startQuiz.Font = new System.Drawing.Font("Sitka Small", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startQuiz.ForeColor = System.Drawing.Color.Black;
            this.startQuiz.Location = new System.Drawing.Point(63, 312);
            this.startQuiz.Name = "startQuiz";
            this.startQuiz.Size = new System.Drawing.Size(335, 51);
            this.startQuiz.TabIndex = 2;
            this.startQuiz.Text = "Iniciar Quiz";
            this.startQuiz.UseVisualStyleBackColor = false;
            this.startQuiz.Click += new System.EventHandler(this.startQuiz_Click);
            // 
            // plusLeftLabel
            // 
            this.plusLeftLabel.AutoSize = true;
            this.plusLeftLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plusLeftLabel.Location = new System.Drawing.Point(59, 77);
            this.plusLeftLabel.Name = "plusLeftLabel";
            this.plusLeftLabel.Size = new System.Drawing.Size(20, 24);
            this.plusLeftLabel.TabIndex = 3;
            this.plusLeftLabel.Text = "?";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(226, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "=";
            // 
            // plusRightLabel
            // 
            this.plusRightLabel.AutoSize = true;
            this.plusRightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plusRightLabel.Location = new System.Drawing.Point(174, 77);
            this.plusRightLabel.Name = "plusRightLabel";
            this.plusRightLabel.Size = new System.Drawing.Size(20, 24);
            this.plusRightLabel.TabIndex = 3;
            this.plusRightLabel.Text = "?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(118, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "+";
            // 
            // somar
            // 
            this.somar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.somar.Location = new System.Drawing.Point(284, 72);
            this.somar.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.somar.Name = "somar";
            this.somar.Size = new System.Drawing.Size(120, 29);
            this.somar.TabIndex = 4;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // multLeft
            // 
            this.multLeft.AutoSize = true;
            this.multLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multLeft.Location = new System.Drawing.Point(59, 199);
            this.multLeft.Name = "multLeft";
            this.multLeft.Size = new System.Drawing.Size(20, 24);
            this.multLeft.TabIndex = 3;
            this.multLeft.Text = "?";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(226, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 24);
            this.label5.TabIndex = 3;
            this.label5.Text = "=";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(118, 199);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 24);
            this.label6.TabIndex = 3;
            this.label6.Text = "x";
            // 
            // multRigth
            // 
            this.multRigth.AutoSize = true;
            this.multRigth.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multRigth.Location = new System.Drawing.Point(174, 199);
            this.multRigth.Name = "multRigth";
            this.multRigth.Size = new System.Drawing.Size(20, 24);
            this.multRigth.TabIndex = 3;
            this.multRigth.Text = "?";
            // 
            // multiplicacao
            // 
            this.multiplicacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multiplicacao.Location = new System.Drawing.Point(284, 194);
            this.multiplicacao.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.multiplicacao.Name = "multiplicacao";
            this.multiplicacao.Size = new System.Drawing.Size(120, 29);
            this.multiplicacao.TabIndex = 4;
            // 
            // subLeft
            // 
            this.subLeft.AutoSize = true;
            this.subLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subLeft.Location = new System.Drawing.Point(59, 136);
            this.subLeft.Name = "subLeft";
            this.subLeft.Size = new System.Drawing.Size(20, 24);
            this.subLeft.TabIndex = 3;
            this.subLeft.Text = "?";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(226, 136);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(21, 24);
            this.label9.TabIndex = 3;
            this.label9.Text = "=";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(118, 136);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(16, 24);
            this.label10.TabIndex = 3;
            this.label10.Text = "-";
            // 
            // subRight
            // 
            this.subRight.AutoSize = true;
            this.subRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subRight.Location = new System.Drawing.Point(174, 136);
            this.subRight.Name = "subRight";
            this.subRight.Size = new System.Drawing.Size(20, 24);
            this.subRight.TabIndex = 3;
            this.subRight.Text = "?";
            // 
            // subtracao
            // 
            this.subtracao.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtracao.Location = new System.Drawing.Point(284, 131);
            this.subtracao.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.subtracao.Name = "subtracao";
            this.subtracao.Size = new System.Drawing.Size(120, 29);
            this.subtracao.TabIndex = 4;
            // 
            // divLeft
            // 
            this.divLeft.AutoSize = true;
            this.divLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.divLeft.Location = new System.Drawing.Point(59, 260);
            this.divLeft.Name = "divLeft";
            this.divLeft.Size = new System.Drawing.Size(20, 24);
            this.divLeft.TabIndex = 3;
            this.divLeft.Text = "?";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(226, 260);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(21, 24);
            this.label13.TabIndex = 3;
            this.label13.Text = "=";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(118, 260);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(15, 24);
            this.label14.TabIndex = 3;
            this.label14.Text = "/";
            // 
            // divRigth
            // 
            this.divRigth.AutoSize = true;
            this.divRigth.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.divRigth.Location = new System.Drawing.Point(174, 260);
            this.divRigth.Name = "divRigth";
            this.divRigth.Size = new System.Drawing.Size(20, 24);
            this.divRigth.TabIndex = 3;
            this.divRigth.Text = "?";
            // 
            // divisao
            // 
            this.divisao.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.divisao.Location = new System.Drawing.Point(284, 255);
            this.divisao.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.divisao.Name = "divisao";
            this.divisao.Size = new System.Drawing.Size(120, 29);
            this.divisao.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(461, 381);
            this.Controls.Add(this.divisao);
            this.Controls.Add(this.subtracao);
            this.Controls.Add(this.multiplicacao);
            this.Controls.Add(this.somar);
            this.Controls.Add(this.divRigth);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.subRight);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.multRigth);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.plusRightLabel);
            this.Controls.Add(this.divLeft);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.subLeft);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.multLeft);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.plusLeftLabel);
            this.Controls.Add(this.startQuiz);
            this.Controls.Add(this.TimeLabel);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.somar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.multiplicacao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subtracao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.divisao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label TimeLabel;
        private System.Windows.Forms.Button startQuiz;
        private System.Windows.Forms.Label plusLeftLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label plusRightLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown somar;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label multLeft;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label multRigth;
        private System.Windows.Forms.NumericUpDown multiplicacao;
        private System.Windows.Forms.Label subLeft;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label subRight;
        private System.Windows.Forms.NumericUpDown subtracao;
        private System.Windows.Forms.Label divLeft;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label divRigth;
        private System.Windows.Forms.NumericUpDown divisao;
    }
}


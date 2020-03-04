namespace TopScore
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
            this.clickme = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.record = new System.Windows.Forms.TextBox();
            this.pontos = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tempo = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // clickme
            // 
            this.clickme.BackColor = System.Drawing.Color.Transparent;
            this.clickme.BackgroundImage = global::TopScore.Properties.Resources.fly_2;
            this.clickme.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.clickme.FlatAppearance.BorderSize = 0;
            this.clickme.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.clickme.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.clickme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clickme.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clickme.Location = new System.Drawing.Point(477, 255);
            this.clickme.Margin = new System.Windows.Forms.Padding(4);
            this.clickme.Name = "clickme";
            this.clickme.Size = new System.Drawing.Size(100, 100);
            this.clickme.TabIndex = 0;
            this.clickme.UseVisualStyleBackColor = false;
            this.clickme.Click += new System.EventHandler(this.clickme_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(449, 528);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(224, 73);
            this.button2.TabIndex = 1;
            this.button2.Text = "GO!";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(765, 90);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 39);
            this.label1.TabIndex = 2;
            this.label1.Text = "Record";
            // 
            // record
            // 
            this.record.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.record.Location = new System.Drawing.Point(919, 90);
            this.record.Margin = new System.Windows.Forms.Padding(4);
            this.record.Name = "record";
            this.record.Size = new System.Drawing.Size(132, 46);
            this.record.TabIndex = 3;
            this.record.Text = "0";
            this.record.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pontos
            // 
            this.pontos.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pontos.Location = new System.Drawing.Point(917, 15);
            this.pontos.Margin = new System.Windows.Forms.Padding(4);
            this.pontos.Name = "pontos";
            this.pontos.Size = new System.Drawing.Size(132, 46);
            this.pontos.TabIndex = 5;
            this.pontos.Text = "0";
            this.pontos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(709, 15);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 39);
            this.label2.TabIndex = 4;
            this.label2.Text = "Pontuação";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(71, 21);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 39);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tempo";
            // 
            // tempo
            // 
            this.tempo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tempo.Location = new System.Drawing.Point(68, 84);
            this.tempo.Margin = new System.Windows.Forms.Padding(4);
            this.tempo.Name = "tempo";
            this.tempo.Size = new System.Drawing.Size(132, 46);
            this.tempo.TabIndex = 7;
            this.tempo.Text = "10";
            this.tempo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TopScore.Properties.Resources.d31345678632460cb3b9b3f1eb82d509;
            this.ClientSize = new System.Drawing.Size(1067, 615);
            this.Controls.Add(this.tempo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pontos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.record);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.clickme);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button clickme;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox record;
        private System.Windows.Forms.TextBox pontos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tempo;
        private System.Windows.Forms.Timer timer1;
    }
}


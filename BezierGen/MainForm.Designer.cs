namespace BezierGen
{
    partial class MainForm
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.comboBox_documentType = new System.Windows.Forms.ComboBox();
            this.label_documentType = new System.Windows.Forms.Label();
            this.label_points = new System.Windows.Forms.Label();
            this.textBox_seed = new System.Windows.Forms.TextBox();
            this.label_seed = new System.Windows.Forms.Label();
            this.button_genSeed = new System.Windows.Forms.Button();
            this.button_genCurve = new System.Windows.Forms.Button();
            this.comboBox_points = new System.Windows.Forms.ComboBox();
            this.label_stroke = new System.Windows.Forms.Label();
            this.comboBox_stroke = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.splitContainer1.Panel1.Controls.Add(this.comboBox_stroke);
            this.splitContainer1.Panel1.Controls.Add(this.comboBox_points);
            this.splitContainer1.Panel1.Controls.Add(this.button_genCurve);
            this.splitContainer1.Panel1.Controls.Add(this.button_genSeed);
            this.splitContainer1.Panel1.Controls.Add(this.textBox_seed);
            this.splitContainer1.Panel1.Controls.Add(this.label_stroke);
            this.splitContainer1.Panel1.Controls.Add(this.label_seed);
            this.splitContainer1.Panel1.Controls.Add(this.label_points);
            this.splitContainer1.Panel1.Controls.Add(this.label_documentType);
            this.splitContainer1.Panel1.Controls.Add(this.comboBox_documentType);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(1014, 450);
            this.splitContainer1.SplitterDistance = 46;
            this.splitContainer1.TabIndex = 0;
            // 
            // comboBox_documentType
            // 
            this.comboBox_documentType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.comboBox_documentType.ForeColor = System.Drawing.Color.Black;
            this.comboBox_documentType.FormattingEnabled = true;
            this.comboBox_documentType.Location = new System.Drawing.Point(131, 14);
            this.comboBox_documentType.Name = "comboBox_documentType";
            this.comboBox_documentType.Size = new System.Drawing.Size(161, 21);
            this.comboBox_documentType.TabIndex = 0;
            // 
            // label_documentType
            // 
            this.label_documentType.AutoSize = true;
            this.label_documentType.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_documentType.ForeColor = System.Drawing.SystemColors.Window;
            this.label_documentType.Location = new System.Drawing.Point(12, 14);
            this.label_documentType.Name = "label_documentType";
            this.label_documentType.Size = new System.Drawing.Size(113, 19);
            this.label_documentType.TabIndex = 1;
            this.label_documentType.Text = "Document Type";
            // 
            // label_points
            // 
            this.label_points.AutoSize = true;
            this.label_points.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_points.ForeColor = System.Drawing.SystemColors.Window;
            this.label_points.Location = new System.Drawing.Point(298, 14);
            this.label_points.Name = "label_points";
            this.label_points.Size = new System.Drawing.Size(50, 19);
            this.label_points.TabIndex = 2;
            this.label_points.Text = "Points";
            // 
            // textBox_seed
            // 
            this.textBox_seed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.textBox_seed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_seed.ForeColor = System.Drawing.Color.Black;
            this.textBox_seed.Location = new System.Drawing.Point(615, 15);
            this.textBox_seed.Name = "textBox_seed";
            this.textBox_seed.Size = new System.Drawing.Size(106, 20);
            this.textBox_seed.TabIndex = 5;
            // 
            // label_seed
            // 
            this.label_seed.AutoSize = true;
            this.label_seed.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_seed.ForeColor = System.Drawing.SystemColors.Window;
            this.label_seed.Location = new System.Drawing.Point(567, 14);
            this.label_seed.Name = "label_seed";
            this.label_seed.Size = new System.Drawing.Size(42, 19);
            this.label_seed.TabIndex = 4;
            this.label_seed.Text = "Seed";
            // 
            // button_genSeed
            // 
            this.button_genSeed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.button_genSeed.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.button_genSeed.Location = new System.Drawing.Point(727, 13);
            this.button_genSeed.Name = "button_genSeed";
            this.button_genSeed.Size = new System.Drawing.Size(90, 23);
            this.button_genSeed.TabIndex = 6;
            this.button_genSeed.Text = "Generate seed";
            this.button_genSeed.UseVisualStyleBackColor = false;
            // 
            // button_genCurve
            // 
            this.button_genCurve.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.button_genCurve.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.button_genCurve.Location = new System.Drawing.Point(823, 13);
            this.button_genCurve.Name = "button_genCurve";
            this.button_genCurve.Size = new System.Drawing.Size(97, 23);
            this.button_genCurve.TabIndex = 7;
            this.button_genCurve.Text = "Generate curve";
            this.button_genCurve.UseVisualStyleBackColor = false;
            this.button_genCurve.Click += new System.EventHandler(this.button_genCurve_Click);
            // 
            // comboBox_points
            // 
            this.comboBox_points.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.comboBox_points.ForeColor = System.Drawing.Color.Black;
            this.comboBox_points.FormattingEnabled = true;
            this.comboBox_points.Location = new System.Drawing.Point(354, 14);
            this.comboBox_points.Name = "comboBox_points";
            this.comboBox_points.Size = new System.Drawing.Size(71, 21);
            this.comboBox_points.TabIndex = 8;
            // 
            // label_stroke
            // 
            this.label_stroke.AutoSize = true;
            this.label_stroke.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_stroke.ForeColor = System.Drawing.SystemColors.Window;
            this.label_stroke.Location = new System.Drawing.Point(431, 14);
            this.label_stroke.Name = "label_stroke";
            this.label_stroke.Size = new System.Drawing.Size(53, 19);
            this.label_stroke.TabIndex = 2;
            this.label_stroke.Text = "Stroke";
            // 
            // comboBox_stroke
            // 
            this.comboBox_stroke.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.comboBox_stroke.ForeColor = System.Drawing.Color.Black;
            this.comboBox_stroke.FormattingEnabled = true;
            this.comboBox_stroke.Location = new System.Drawing.Point(490, 14);
            this.comboBox_stroke.Name = "comboBox_stroke";
            this.comboBox_stroke.Size = new System.Drawing.Size(71, 21);
            this.comboBox_stroke.TabIndex = 8;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            this.ClientSize = new System.Drawing.Size(1014, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ComboBox comboBox_documentType;
        private System.Windows.Forms.Label label_documentType;
        private System.Windows.Forms.Label label_points;
        private System.Windows.Forms.TextBox textBox_seed;
        private System.Windows.Forms.Label label_seed;
        private System.Windows.Forms.Button button_genSeed;
        private System.Windows.Forms.ComboBox comboBox_points;
        private System.Windows.Forms.Button button_genCurve;
        private System.Windows.Forms.ComboBox comboBox_stroke;
        private System.Windows.Forms.Label label_stroke;
    }
}


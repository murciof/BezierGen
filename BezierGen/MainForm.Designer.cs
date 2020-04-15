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
            this.menuPanel = new System.Windows.Forms.Panel();
            this.comboBox_stroke = new System.Windows.Forms.ComboBox();
            this.comboBox_points = new System.Windows.Forms.ComboBox();
            this.comboBox_documentType = new System.Windows.Forms.ComboBox();
            this.button_genCurve = new System.Windows.Forms.Button();
            this.label_documentType = new System.Windows.Forms.Label();
            this.button_genSeed = new System.Windows.Forms.Button();
            this.label_points = new System.Windows.Forms.Label();
            this.textBox_marginY = new System.Windows.Forms.TextBox();
            this.label_marginX = new System.Windows.Forms.Label();
            this.textBox_marginX = new System.Windows.Forms.TextBox();
            this.label_marginY = new System.Windows.Forms.Label();
            this.textBox_seed = new System.Windows.Forms.TextBox();
            this.label_seed = new System.Windows.Forms.Label();
            this.label_stroke = new System.Windows.Forms.Label();
            this.canvasPanel = new System.Windows.Forms.Panel();
            this.additionalPanel = new System.Windows.Forms.Panel();
            this.button_mag5x = new System.Windows.Forms.Button();
            this.button_mag4x = new System.Windows.Forms.Button();
            this.button_orientationL = new System.Windows.Forms.Button();
            this.button_orientationP = new System.Windows.Forms.Button();
            this.button_mag3x = new System.Windows.Forms.Button();
            this.button_mag2x = new System.Windows.Forms.Button();
            this.button_mag1x = new System.Windows.Forms.Button();
            this.trackBar_curveLimit = new System.Windows.Forms.TrackBar();
            this.comboBox_curveType = new System.Windows.Forms.ComboBox();
            this.label_curveType = new System.Windows.Forms.Label();
            this.label_curveLimit = new System.Windows.Forms.Label();
            this.menuPanel.SuspendLayout();
            this.additionalPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_curveLimit)).BeginInit();
            this.SuspendLayout();
            // 
            // menuPanel
            // 
            this.menuPanel.Controls.Add(this.comboBox_stroke);
            this.menuPanel.Controls.Add(this.comboBox_points);
            this.menuPanel.Controls.Add(this.comboBox_documentType);
            this.menuPanel.Controls.Add(this.button_genCurve);
            this.menuPanel.Controls.Add(this.label_documentType);
            this.menuPanel.Controls.Add(this.label_points);
            this.menuPanel.Controls.Add(this.textBox_marginY);
            this.menuPanel.Controls.Add(this.label_marginX);
            this.menuPanel.Controls.Add(this.textBox_marginX);
            this.menuPanel.Controls.Add(this.label_marginY);
            this.menuPanel.Controls.Add(this.label_stroke);
            this.menuPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.menuPanel.Location = new System.Drawing.Point(0, 0);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(1166, 38);
            this.menuPanel.TabIndex = 0;
            // 
            // comboBox_stroke
            // 
            this.comboBox_stroke.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.comboBox_stroke.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_stroke.ForeColor = System.Drawing.Color.Black;
            this.comboBox_stroke.FormattingEnabled = true;
            this.comboBox_stroke.Location = new System.Drawing.Point(662, 8);
            this.comboBox_stroke.Name = "comboBox_stroke";
            this.comboBox_stroke.Size = new System.Drawing.Size(71, 21);
            this.comboBox_stroke.TabIndex = 9;
            // 
            // comboBox_points
            // 
            this.comboBox_points.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.comboBox_points.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_points.ForeColor = System.Drawing.Color.Black;
            this.comboBox_points.FormattingEnabled = true;
            this.comboBox_points.Location = new System.Drawing.Point(526, 8);
            this.comboBox_points.Name = "comboBox_points";
            this.comboBox_points.Size = new System.Drawing.Size(71, 21);
            this.comboBox_points.TabIndex = 7;
            // 
            // comboBox_documentType
            // 
            this.comboBox_documentType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.comboBox_documentType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_documentType.ForeColor = System.Drawing.Color.Black;
            this.comboBox_documentType.FormattingEnabled = true;
            this.comboBox_documentType.Location = new System.Drawing.Point(131, 8);
            this.comboBox_documentType.Name = "comboBox_documentType";
            this.comboBox_documentType.Size = new System.Drawing.Size(161, 21);
            this.comboBox_documentType.TabIndex = 1;
            // 
            // button_genCurve
            // 
            this.button_genCurve.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.button_genCurve.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.button_genCurve.Location = new System.Drawing.Point(739, 7);
            this.button_genCurve.Name = "button_genCurve";
            this.button_genCurve.Size = new System.Drawing.Size(97, 23);
            this.button_genCurve.TabIndex = 13;
            this.button_genCurve.Text = "Generate curve";
            this.button_genCurve.UseVisualStyleBackColor = false;
            this.button_genCurve.Click += new System.EventHandler(this.button_genCurve_Click);
            // 
            // label_documentType
            // 
            this.label_documentType.AutoSize = true;
            this.label_documentType.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_documentType.ForeColor = System.Drawing.SystemColors.Window;
            this.label_documentType.Location = new System.Drawing.Point(12, 9);
            this.label_documentType.Name = "label_documentType";
            this.label_documentType.Size = new System.Drawing.Size(113, 19);
            this.label_documentType.TabIndex = 0;
            this.label_documentType.Text = "Document Type";
            // 
            // button_genSeed
            // 
            this.button_genSeed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.button_genSeed.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.button_genSeed.Location = new System.Drawing.Point(695, 9);
            this.button_genSeed.Name = "button_genSeed";
            this.button_genSeed.Size = new System.Drawing.Size(90, 23);
            this.button_genSeed.TabIndex = 12;
            this.button_genSeed.Text = "Generate seed";
            this.button_genSeed.UseVisualStyleBackColor = false;
            // 
            // label_points
            // 
            this.label_points.AutoSize = true;
            this.label_points.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_points.ForeColor = System.Drawing.SystemColors.Window;
            this.label_points.Location = new System.Drawing.Point(470, 9);
            this.label_points.Name = "label_points";
            this.label_points.Size = new System.Drawing.Size(50, 19);
            this.label_points.TabIndex = 6;
            this.label_points.Text = "Points";
            // 
            // textBox_marginY
            // 
            this.textBox_marginY.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.textBox_marginY.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_marginY.ForeColor = System.Drawing.Color.Black;
            this.textBox_marginY.Location = new System.Drawing.Point(420, 8);
            this.textBox_marginY.Name = "textBox_marginY";
            this.textBox_marginY.Size = new System.Drawing.Size(44, 20);
            this.textBox_marginY.TabIndex = 5;
            // 
            // label_marginX
            // 
            this.label_marginX.AutoSize = true;
            this.label_marginX.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_marginX.ForeColor = System.Drawing.SystemColors.Window;
            this.label_marginX.Location = new System.Drawing.Point(298, 9);
            this.label_marginX.Name = "label_marginX";
            this.label_marginX.Size = new System.Drawing.Size(30, 19);
            this.label_marginX.TabIndex = 2;
            this.label_marginX.Text = "Mx";
            // 
            // textBox_marginX
            // 
            this.textBox_marginX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.textBox_marginX.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_marginX.ForeColor = System.Drawing.Color.Black;
            this.textBox_marginX.Location = new System.Drawing.Point(334, 8);
            this.textBox_marginX.Name = "textBox_marginX";
            this.textBox_marginX.Size = new System.Drawing.Size(44, 20);
            this.textBox_marginX.TabIndex = 3;
            // 
            // label_marginY
            // 
            this.label_marginY.AutoSize = true;
            this.label_marginY.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_marginY.ForeColor = System.Drawing.SystemColors.Window;
            this.label_marginY.Location = new System.Drawing.Point(384, 9);
            this.label_marginY.Name = "label_marginY";
            this.label_marginY.Size = new System.Drawing.Size(30, 19);
            this.label_marginY.TabIndex = 4;
            this.label_marginY.Text = "My";
            // 
            // textBox_seed
            // 
            this.textBox_seed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.textBox_seed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_seed.ForeColor = System.Drawing.Color.Black;
            this.textBox_seed.Location = new System.Drawing.Point(584, 10);
            this.textBox_seed.Name = "textBox_seed";
            this.textBox_seed.Size = new System.Drawing.Size(106, 20);
            this.textBox_seed.TabIndex = 11;
            // 
            // label_seed
            // 
            this.label_seed.AutoSize = true;
            this.label_seed.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_seed.ForeColor = System.Drawing.SystemColors.Window;
            this.label_seed.Location = new System.Drawing.Point(537, 11);
            this.label_seed.Name = "label_seed";
            this.label_seed.Size = new System.Drawing.Size(42, 19);
            this.label_seed.TabIndex = 10;
            this.label_seed.Text = "Seed";
            // 
            // label_stroke
            // 
            this.label_stroke.AutoSize = true;
            this.label_stroke.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_stroke.ForeColor = System.Drawing.SystemColors.Window;
            this.label_stroke.Location = new System.Drawing.Point(603, 9);
            this.label_stroke.Name = "label_stroke";
            this.label_stroke.Size = new System.Drawing.Size(53, 19);
            this.label_stroke.TabIndex = 8;
            this.label_stroke.Text = "Stroke";
            // 
            // canvasPanel
            // 
            this.canvasPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.canvasPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.canvasPanel.Location = new System.Drawing.Point(0, 38);
            this.canvasPanel.Name = "canvasPanel";
            this.canvasPanel.Size = new System.Drawing.Size(1166, 412);
            this.canvasPanel.TabIndex = 1;
            this.canvasPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.canvasPanel_Paint);
            // 
            // additionalPanel
            // 
            this.additionalPanel.Controls.Add(this.label_curveLimit);
            this.additionalPanel.Controls.Add(this.trackBar_curveLimit);
            this.additionalPanel.Controls.Add(this.comboBox_curveType);
            this.additionalPanel.Controls.Add(this.button_mag5x);
            this.additionalPanel.Controls.Add(this.button_mag4x);
            this.additionalPanel.Controls.Add(this.label_curveType);
            this.additionalPanel.Controls.Add(this.button_orientationL);
            this.additionalPanel.Controls.Add(this.button_orientationP);
            this.additionalPanel.Controls.Add(this.button_mag3x);
            this.additionalPanel.Controls.Add(this.button_genSeed);
            this.additionalPanel.Controls.Add(this.button_mag2x);
            this.additionalPanel.Controls.Add(this.button_mag1x);
            this.additionalPanel.Controls.Add(this.textBox_seed);
            this.additionalPanel.Controls.Add(this.label_seed);
            this.additionalPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.additionalPanel.Location = new System.Drawing.Point(0, 411);
            this.additionalPanel.Name = "additionalPanel";
            this.additionalPanel.Size = new System.Drawing.Size(1166, 39);
            this.additionalPanel.TabIndex = 2;
            // 
            // button_mag5x
            // 
            this.button_mag5x.BackColor = System.Drawing.Color.Transparent;
            this.button_mag5x.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.button_mag5x.Location = new System.Drawing.Point(177, 9);
            this.button_mag5x.Name = "button_mag5x";
            this.button_mag5x.Size = new System.Drawing.Size(37, 23);
            this.button_mag5x.TabIndex = 20;
            this.button_mag5x.Text = "5x";
            this.button_mag5x.UseVisualStyleBackColor = false;
            this.button_mag5x.Click += new System.EventHandler(this.button_mag5x_Click);
            // 
            // button_mag4x
            // 
            this.button_mag4x.BackColor = System.Drawing.Color.Transparent;
            this.button_mag4x.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.button_mag4x.Location = new System.Drawing.Point(135, 9);
            this.button_mag4x.Name = "button_mag4x";
            this.button_mag4x.Size = new System.Drawing.Size(37, 23);
            this.button_mag4x.TabIndex = 19;
            this.button_mag4x.Text = "4x";
            this.button_mag4x.UseVisualStyleBackColor = false;
            this.button_mag4x.Click += new System.EventHandler(this.button_mag4x_Click);
            // 
            // button_orientationL
            // 
            this.button_orientationL.BackColor = System.Drawing.Color.Transparent;
            this.button_orientationL.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.button_orientationL.Location = new System.Drawing.Point(250, 9);
            this.button_orientationL.Name = "button_orientationL";
            this.button_orientationL.Size = new System.Drawing.Size(26, 23);
            this.button_orientationL.TabIndex = 18;
            this.button_orientationL.Text = "L";
            this.button_orientationL.UseVisualStyleBackColor = false;
            this.button_orientationL.Click += new System.EventHandler(this.button_orientationL_Click);
            // 
            // button_orientationP
            // 
            this.button_orientationP.BackColor = System.Drawing.Color.Transparent;
            this.button_orientationP.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.button_orientationP.Location = new System.Drawing.Point(219, 9);
            this.button_orientationP.Name = "button_orientationP";
            this.button_orientationP.Size = new System.Drawing.Size(26, 23);
            this.button_orientationP.TabIndex = 17;
            this.button_orientationP.Text = "P";
            this.button_orientationP.UseVisualStyleBackColor = false;
            this.button_orientationP.Click += new System.EventHandler(this.button_orientationP_Click);
            // 
            // button_mag3x
            // 
            this.button_mag3x.BackColor = System.Drawing.Color.Transparent;
            this.button_mag3x.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.button_mag3x.Location = new System.Drawing.Point(93, 9);
            this.button_mag3x.Name = "button_mag3x";
            this.button_mag3x.Size = new System.Drawing.Size(37, 23);
            this.button_mag3x.TabIndex = 16;
            this.button_mag3x.Text = "3x";
            this.button_mag3x.UseVisualStyleBackColor = false;
            this.button_mag3x.Click += new System.EventHandler(this.button_mag3x_Click);
            // 
            // button_mag2x
            // 
            this.button_mag2x.BackColor = System.Drawing.Color.Transparent;
            this.button_mag2x.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.button_mag2x.Location = new System.Drawing.Point(51, 9);
            this.button_mag2x.Name = "button_mag2x";
            this.button_mag2x.Size = new System.Drawing.Size(37, 23);
            this.button_mag2x.TabIndex = 15;
            this.button_mag2x.Text = "2x";
            this.button_mag2x.UseVisualStyleBackColor = false;
            this.button_mag2x.Click += new System.EventHandler(this.button_mag2x_Click);
            // 
            // button_mag1x
            // 
            this.button_mag1x.BackColor = System.Drawing.Color.Transparent;
            this.button_mag1x.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.button_mag1x.Location = new System.Drawing.Point(9, 9);
            this.button_mag1x.Name = "button_mag1x";
            this.button_mag1x.Size = new System.Drawing.Size(37, 23);
            this.button_mag1x.TabIndex = 14;
            this.button_mag1x.Text = "1x";
            this.button_mag1x.UseVisualStyleBackColor = false;
            this.button_mag1x.Click += new System.EventHandler(this.button_mag1x_Click);
            // 
            // trackBar_curveLimit
            // 
            this.trackBar_curveLimit.LargeChange = 10;
            this.trackBar_curveLimit.Location = new System.Drawing.Point(791, 7);
            this.trackBar_curveLimit.Maximum = 50;
            this.trackBar_curveLimit.Name = "trackBar_curveLimit";
            this.trackBar_curveLimit.Size = new System.Drawing.Size(104, 45);
            this.trackBar_curveLimit.SmallChange = 5;
            this.trackBar_curveLimit.TabIndex = 0;
            this.trackBar_curveLimit.TickFrequency = 5;
            this.trackBar_curveLimit.Scroll += new System.EventHandler(this.trackBar_curveLimit_Scroll);
            // 
            // comboBox_curveType
            // 
            this.comboBox_curveType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.comboBox_curveType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_curveType.ForeColor = System.Drawing.Color.Black;
            this.comboBox_curveType.FormattingEnabled = true;
            this.comboBox_curveType.Location = new System.Drawing.Point(371, 10);
            this.comboBox_curveType.Name = "comboBox_curveType";
            this.comboBox_curveType.Size = new System.Drawing.Size(161, 21);
            this.comboBox_curveType.TabIndex = 15;
            // 
            // label_curveType
            // 
            this.label_curveType.AutoSize = true;
            this.label_curveType.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_curveType.ForeColor = System.Drawing.SystemColors.Window;
            this.label_curveType.Location = new System.Drawing.Point(281, 11);
            this.label_curveType.Name = "label_curveType";
            this.label_curveType.Size = new System.Drawing.Size(85, 19);
            this.label_curveType.TabIndex = 14;
            this.label_curveType.Text = "Curve Type";
            // 
            // label_curveLimit
            // 
            this.label_curveLimit.AutoSize = true;
            this.label_curveLimit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_curveLimit.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label_curveLimit.Location = new System.Drawing.Point(901, 13);
            this.label_curveLimit.Name = "label_curveLimit";
            this.label_curveLimit.Size = new System.Drawing.Size(53, 15);
            this.label_curveLimit.TabIndex = 21;
            this.label_curveLimit.Text = "No Limit";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            this.ClientSize = new System.Drawing.Size(1166, 450);
            this.Controls.Add(this.additionalPanel);
            this.Controls.Add(this.canvasPanel);
            this.Controls.Add(this.menuPanel);
            this.Name = "MainForm";
            this.Text = "BezierGen";
            this.menuPanel.ResumeLayout(false);
            this.menuPanel.PerformLayout();
            this.additionalPanel.ResumeLayout(false);
            this.additionalPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_curveLimit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel menuPanel;
        private System.Windows.Forms.ComboBox comboBox_stroke;
        private System.Windows.Forms.ComboBox comboBox_points;
        private System.Windows.Forms.ComboBox comboBox_documentType;
        private System.Windows.Forms.Button button_genCurve;
        private System.Windows.Forms.Label label_documentType;
        private System.Windows.Forms.Button button_genSeed;
        private System.Windows.Forms.Label label_points;
        private System.Windows.Forms.TextBox textBox_marginY;
        private System.Windows.Forms.Label label_marginX;
        private System.Windows.Forms.TextBox textBox_marginX;
        private System.Windows.Forms.Label label_marginY;
        private System.Windows.Forms.TextBox textBox_seed;
        private System.Windows.Forms.Label label_seed;
        private System.Windows.Forms.Label label_stroke;
        private System.Windows.Forms.Panel canvasPanel;
        private System.Windows.Forms.Panel additionalPanel;
        private System.Windows.Forms.Button button_mag1x;
        private System.Windows.Forms.Button button_mag3x;
        private System.Windows.Forms.Button button_mag2x;
        private System.Windows.Forms.Button button_orientationL;
        private System.Windows.Forms.Button button_orientationP;
        private System.Windows.Forms.Button button_mag5x;
        private System.Windows.Forms.Button button_mag4x;
        private System.Windows.Forms.TrackBar trackBar_curveLimit;
        private System.Windows.Forms.Label label_curveLimit;
        private System.Windows.Forms.ComboBox comboBox_curveType;
        private System.Windows.Forms.Label label_curveType;
    }
}


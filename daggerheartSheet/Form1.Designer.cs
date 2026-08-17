namespace daggerheartSheet
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelBoxName = new System.Windows.Forms.Label();
            this.panelBoxName = new System.Windows.Forms.Panel();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelBoxPronouns = new System.Windows.Forms.Label();
            this.labelBoxHeritage = new System.Windows.Forms.Label();
            this.labelBoxClass = new System.Windows.Forms.Label();
            this.textBoxPronouns = new System.Windows.Forms.TextBox();
            this.textBoxHeritage = new System.Windows.Forms.TextBox();
            this.textBoxClass = new System.Windows.Forms.TextBox();
            this.labelBoxLevel = new System.Windows.Forms.Label();
            this.numericUpDownLevel = new System.Windows.Forms.NumericUpDown();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelBoxName.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLevel)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Location = new System.Drawing.Point(-3, 1);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(806, 446);
            this.tabControl.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(798, 420);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Atributos e Recursos";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(798, 420);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Inventário e Experiências";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panelBoxName);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(798, 420);
            this.panel1.TabIndex = 0;
            // 
            // labelBoxName
            // 
            this.labelBoxName.AutoSize = true;
            this.labelBoxName.Location = new System.Drawing.Point(6, 6);
            this.labelBoxName.Name = "labelBoxName";
            this.labelBoxName.Size = new System.Drawing.Size(38, 13);
            this.labelBoxName.TabIndex = 0;
            this.labelBoxName.Text = "Nome:";
            // 
            // panelBoxName
            // 
            this.panelBoxName.BackColor = System.Drawing.Color.Gainsboro;
            this.panelBoxName.Controls.Add(this.numericUpDownLevel);
            this.panelBoxName.Controls.Add(this.labelBoxLevel);
            this.panelBoxName.Controls.Add(this.textBoxClass);
            this.panelBoxName.Controls.Add(this.textBoxHeritage);
            this.panelBoxName.Controls.Add(this.textBoxPronouns);
            this.panelBoxName.Controls.Add(this.labelBoxClass);
            this.panelBoxName.Controls.Add(this.labelBoxHeritage);
            this.panelBoxName.Controls.Add(this.labelBoxPronouns);
            this.panelBoxName.Controls.Add(this.textBoxName);
            this.panelBoxName.Controls.Add(this.labelBoxName);
            this.panelBoxName.Location = new System.Drawing.Point(11, 16);
            this.panelBoxName.Name = "panelBoxName";
            this.panelBoxName.Size = new System.Drawing.Size(332, 128);
            this.panelBoxName.TabIndex = 1;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(75, 3);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 20);
            this.textBoxName.TabIndex = 2;
            this.textBoxName.Text = "nome aqui";
            this.textBoxName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxName_KeyDown);
            // 
            // labelBoxPronouns
            // 
            this.labelBoxPronouns.AutoSize = true;
            this.labelBoxPronouns.Location = new System.Drawing.Point(6, 37);
            this.labelBoxPronouns.Name = "labelBoxPronouns";
            this.labelBoxPronouns.Size = new System.Drawing.Size(57, 13);
            this.labelBoxPronouns.TabIndex = 3;
            this.labelBoxPronouns.Text = "Pronomes:";
            // 
            // labelBoxHeritage
            // 
            this.labelBoxHeritage.AutoSize = true;
            this.labelBoxHeritage.Location = new System.Drawing.Point(9, 69);
            this.labelBoxHeritage.Name = "labelBoxHeritage";
            this.labelBoxHeritage.Size = new System.Drawing.Size(56, 13);
            this.labelBoxHeritage.TabIndex = 4;
            this.labelBoxHeritage.Text = "Linhagem:";
            // 
            // labelBoxClass
            // 
            this.labelBoxClass.AutoSize = true;
            this.labelBoxClass.Location = new System.Drawing.Point(9, 101);
            this.labelBoxClass.Name = "labelBoxClass";
            this.labelBoxClass.Size = new System.Drawing.Size(41, 13);
            this.labelBoxClass.TabIndex = 5;
            this.labelBoxClass.Text = "Classe:";
            // 
            // textBoxPronouns
            // 
            this.textBoxPronouns.Location = new System.Drawing.Point(75, 34);
            this.textBoxPronouns.Name = "textBoxPronouns";
            this.textBoxPronouns.Size = new System.Drawing.Size(100, 20);
            this.textBoxPronouns.TabIndex = 6;
            this.textBoxPronouns.Text = "pronomes aqui";
            this.textBoxPronouns.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxPronouns_KeyDown);
            // 
            // textBoxHeritage
            // 
            this.textBoxHeritage.Location = new System.Drawing.Point(75, 66);
            this.textBoxHeritage.Name = "textBoxHeritage";
            this.textBoxHeritage.Size = new System.Drawing.Size(100, 20);
            this.textBoxHeritage.TabIndex = 7;
            this.textBoxHeritage.Text = "linhagem aqui";
            this.textBoxHeritage.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxHeritage_KeyDown);
            // 
            // textBoxClass
            // 
            this.textBoxClass.Location = new System.Drawing.Point(75, 98);
            this.textBoxClass.Name = "textBoxClass";
            this.textBoxClass.Size = new System.Drawing.Size(100, 20);
            this.textBoxClass.TabIndex = 8;
            this.textBoxClass.Text = "classe aqui";
            this.textBoxClass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxClass_KeyDown);
            // 
            // labelBoxLevel
            // 
            this.labelBoxLevel.AutoSize = true;
            this.labelBoxLevel.Location = new System.Drawing.Point(226, 32);
            this.labelBoxLevel.Name = "labelBoxLevel";
            this.labelBoxLevel.Size = new System.Drawing.Size(36, 13);
            this.labelBoxLevel.TabIndex = 9;
            this.labelBoxLevel.Text = "Nível:";
            // 
            // numericUpDownLevel
            // 
            this.numericUpDownLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownLevel.Location = new System.Drawing.Point(229, 48);
            this.numericUpDownLevel.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownLevel.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownLevel.Name = "numericUpDownLevel";
            this.numericUpDownLevel.Size = new System.Drawing.Size(49, 38);
            this.numericUpDownLevel.TabIndex = 10;
            this.numericUpDownLevel.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panelBoxName.ResumeLayout(false);
            this.panelBoxName.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLevel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelBoxName;
        private System.Windows.Forms.Panel panelBoxName;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelBoxPronouns;
        private System.Windows.Forms.Label labelBoxHeritage;
        private System.Windows.Forms.TextBox textBoxPronouns;
        private System.Windows.Forms.Label labelBoxClass;
        private System.Windows.Forms.TextBox textBoxClass;
        private System.Windows.Forms.TextBox textBoxHeritage;
        private System.Windows.Forms.Label labelBoxLevel;
        private System.Windows.Forms.NumericUpDown numericUpDownLevel;
    }
}


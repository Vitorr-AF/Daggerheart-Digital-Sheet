namespace daggerheartSheet
{
    partial class FormAddSkill
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
            this.labelSkillName = new System.Windows.Forms.Label();
            this.textBoxSkillName = new System.Windows.Forms.TextBox();
            this.labelSkillType = new System.Windows.Forms.Label();
            this.comboBoxSkillType = new System.Windows.Forms.ComboBox();
            this.comboBoxSkillTrait = new System.Windows.Forms.ComboBox();
            this.labelSkillTrait = new System.Windows.Forms.Label();
            this.comboBoxSkillSource = new System.Windows.Forms.ComboBox();
            this.labelSkillSource = new System.Windows.Forms.Label();
            this.comboBoxSkillRange = new System.Windows.Forms.ComboBox();
            this.labelSkillRange = new System.Windows.Forms.Label();
            this.comboBoxSkillDomain = new System.Windows.Forms.ComboBox();
            this.labelSkillDomain = new System.Windows.Forms.Label();
            this.numericUpDownRecallCost = new System.Windows.Forms.NumericUpDown();
            this.labelRecallCost = new System.Windows.Forms.Label();
            this.textBoxSkillDamage = new System.Windows.Forms.TextBox();
            this.labelSkillDamage = new System.Windows.Forms.Label();
            this.textBoxSkillDescription = new System.Windows.Forms.TextBox();
            this.labelSkillDescription = new System.Windows.Forms.Label();
            this.buttonSkillColor = new System.Windows.Forms.Button();
            this.buttonCancelSkill = new System.Windows.Forms.Button();
            this.buttonSaveSkill = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRecallCost)).BeginInit();
            this.SuspendLayout();
            // 
            // labelSkillName
            // 
            this.labelSkillName.AutoSize = true;
            this.labelSkillName.Location = new System.Drawing.Point(13, 13);
            this.labelSkillName.Name = "labelSkillName";
            this.labelSkillName.Size = new System.Drawing.Size(106, 13);
            this.labelSkillName.TabIndex = 0;
            this.labelSkillName.Text = "Nome da Habilidade:";
            // 
            // textBoxSkillName
            // 
            this.textBoxSkillName.Location = new System.Drawing.Point(13, 30);
            this.textBoxSkillName.Name = "textBoxSkillName";
            this.textBoxSkillName.Size = new System.Drawing.Size(130, 20);
            this.textBoxSkillName.TabIndex = 1;
            // 
            // labelSkillType
            // 
            this.labelSkillType.AutoSize = true;
            this.labelSkillType.Location = new System.Drawing.Point(195, 13);
            this.labelSkillType.Name = "labelSkillType";
            this.labelSkillType.Size = new System.Drawing.Size(31, 13);
            this.labelSkillType.TabIndex = 2;
            this.labelSkillType.Text = "Tipo:";
            // 
            // comboBoxSkillType
            // 
            this.comboBoxSkillType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSkillType.FormattingEnabled = true;
            this.comboBoxSkillType.Items.AddRange(new object[] {
            "",
            "Habilidade",
            "Magia"});
            this.comboBoxSkillType.Location = new System.Drawing.Point(198, 30);
            this.comboBoxSkillType.Name = "comboBoxSkillType";
            this.comboBoxSkillType.Size = new System.Drawing.Size(161, 21);
            this.comboBoxSkillType.TabIndex = 3;
            // 
            // comboBoxSkillTrait
            // 
            this.comboBoxSkillTrait.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSkillTrait.FormattingEnabled = true;
            this.comboBoxSkillTrait.Items.AddRange(new object[] {
            "",
            "Agilidade",
            "Força",
            "Finesse",
            "Instinto",
            "Presença",
            "Conhecimento"});
            this.comboBoxSkillTrait.Location = new System.Drawing.Point(387, 30);
            this.comboBoxSkillTrait.Name = "comboBoxSkillTrait";
            this.comboBoxSkillTrait.Size = new System.Drawing.Size(161, 21);
            this.comboBoxSkillTrait.TabIndex = 5;
            // 
            // labelSkillTrait
            // 
            this.labelSkillTrait.AutoSize = true;
            this.labelSkillTrait.Location = new System.Drawing.Point(384, 13);
            this.labelSkillTrait.Name = "labelSkillTrait";
            this.labelSkillTrait.Size = new System.Drawing.Size(46, 13);
            this.labelSkillTrait.TabIndex = 4;
            this.labelSkillTrait.Text = "Atributo:";
            // 
            // comboBoxSkillSource
            // 
            this.comboBoxSkillSource.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSkillSource.FormattingEnabled = true;
            this.comboBoxSkillSource.Items.AddRange(new object[] {
            "Classe/Subclasse",
            "Carta de Dominio",
            "Ancestraldade/Comunidade",
            "Outros"});
            this.comboBoxSkillSource.Location = new System.Drawing.Point(198, 85);
            this.comboBoxSkillSource.Name = "comboBoxSkillSource";
            this.comboBoxSkillSource.Size = new System.Drawing.Size(161, 21);
            this.comboBoxSkillSource.TabIndex = 7;
            // 
            // labelSkillSource
            // 
            this.labelSkillSource.AutoSize = true;
            this.labelSkillSource.Location = new System.Drawing.Point(195, 68);
            this.labelSkillSource.Name = "labelSkillSource";
            this.labelSkillSource.Size = new System.Drawing.Size(37, 13);
            this.labelSkillSource.TabIndex = 6;
            this.labelSkillSource.Text = "Fonte:";
            // 
            // comboBoxSkillRange
            // 
            this.comboBoxSkillRange.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSkillRange.FormattingEnabled = true;
            this.comboBoxSkillRange.Items.AddRange(new object[] {
            "",
            "Corpo-a-corpo",
            "Muito perto",
            "Perto",
            "Distante",
            "Muito distante"});
            this.comboBoxSkillRange.Location = new System.Drawing.Point(387, 85);
            this.comboBoxSkillRange.Name = "comboBoxSkillRange";
            this.comboBoxSkillRange.Size = new System.Drawing.Size(161, 21);
            this.comboBoxSkillRange.TabIndex = 9;
            // 
            // labelSkillRange
            // 
            this.labelSkillRange.AutoSize = true;
            this.labelSkillRange.Location = new System.Drawing.Point(384, 68);
            this.labelSkillRange.Name = "labelSkillRange";
            this.labelSkillRange.Size = new System.Drawing.Size(49, 13);
            this.labelSkillRange.TabIndex = 8;
            this.labelSkillRange.Text = "Alcance:";
            // 
            // comboBoxSkillDomain
            // 
            this.comboBoxSkillDomain.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSkillDomain.FormattingEnabled = true;
            this.comboBoxSkillDomain.Items.AddRange(new object[] {
            "",
            "Arcano",
            "Códice",
            "Esplendor",
            "Falange",
            "Graça",
            "Lâmina",
            "Meia-noite",
            "Sabedoria",
            "Sangue",
            "Valor"});
            this.comboBoxSkillDomain.Location = new System.Drawing.Point(198, 135);
            this.comboBoxSkillDomain.Name = "comboBoxSkillDomain";
            this.comboBoxSkillDomain.Size = new System.Drawing.Size(161, 21);
            this.comboBoxSkillDomain.TabIndex = 11;
            // 
            // labelSkillDomain
            // 
            this.labelSkillDomain.AutoSize = true;
            this.labelSkillDomain.Location = new System.Drawing.Point(195, 118);
            this.labelSkillDomain.Name = "labelSkillDomain";
            this.labelSkillDomain.Size = new System.Drawing.Size(50, 13);
            this.labelSkillDomain.TabIndex = 10;
            this.labelSkillDomain.Text = "Domínio:";
            // 
            // numericUpDownRecallCost
            // 
            this.numericUpDownRecallCost.Location = new System.Drawing.Point(390, 191);
            this.numericUpDownRecallCost.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownRecallCost.Name = "numericUpDownRecallCost";
            this.numericUpDownRecallCost.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownRecallCost.TabIndex = 12;
            // 
            // labelRecallCost
            // 
            this.labelRecallCost.AutoSize = true;
            this.labelRecallCost.Location = new System.Drawing.Point(387, 175);
            this.labelRecallCost.Name = "labelRecallCost";
            this.labelRecallCost.Size = new System.Drawing.Size(83, 13);
            this.labelRecallCost.TabIndex = 13;
            this.labelRecallCost.Text = "Custo de Troca:";
            // 
            // textBoxSkillDamage
            // 
            this.textBoxSkillDamage.Location = new System.Drawing.Point(387, 136);
            this.textBoxSkillDamage.Name = "textBoxSkillDamage";
            this.textBoxSkillDamage.Size = new System.Drawing.Size(161, 20);
            this.textBoxSkillDamage.TabIndex = 15;
            // 
            // labelSkillDamage
            // 
            this.labelSkillDamage.AutoSize = true;
            this.labelSkillDamage.Location = new System.Drawing.Point(387, 119);
            this.labelSkillDamage.Name = "labelSkillDamage";
            this.labelSkillDamage.Size = new System.Drawing.Size(36, 13);
            this.labelSkillDamage.TabIndex = 14;
            this.labelSkillDamage.Text = "Dano:";
            // 
            // textBoxSkillDescription
            // 
            this.textBoxSkillDescription.Location = new System.Drawing.Point(12, 190);
            this.textBoxSkillDescription.Multiline = true;
            this.textBoxSkillDescription.Name = "textBoxSkillDescription";
            this.textBoxSkillDescription.Size = new System.Drawing.Size(369, 153);
            this.textBoxSkillDescription.TabIndex = 16;
            // 
            // labelSkillDescription
            // 
            this.labelSkillDescription.AutoSize = true;
            this.labelSkillDescription.Location = new System.Drawing.Point(13, 174);
            this.labelSkillDescription.Name = "labelSkillDescription";
            this.labelSkillDescription.Size = new System.Drawing.Size(58, 13);
            this.labelSkillDescription.TabIndex = 17;
            this.labelSkillDescription.Text = "Descrição:";
            // 
            // buttonSkillColor
            // 
            this.buttonSkillColor.Location = new System.Drawing.Point(413, 226);
            this.buttonSkillColor.Name = "buttonSkillColor";
            this.buttonSkillColor.Size = new System.Drawing.Size(116, 99);
            this.buttonSkillColor.TabIndex = 18;
            this.buttonSkillColor.Text = "Escolher Cor";
            this.buttonSkillColor.UseVisualStyleBackColor = true;
            this.buttonSkillColor.Click += new System.EventHandler(this.buttonSkillColor_Click);
            // 
            // buttonCancelSkill
            // 
            this.buttonCancelSkill.Location = new System.Drawing.Point(16, 349);
            this.buttonCancelSkill.Name = "buttonCancelSkill";
            this.buttonCancelSkill.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelSkill.TabIndex = 19;
            this.buttonCancelSkill.Text = "Cancelar";
            this.buttonCancelSkill.UseVisualStyleBackColor = true;
            this.buttonCancelSkill.Click += new System.EventHandler(this.buttonCancelSkill_Click);
            // 
            // buttonSaveSkill
            // 
            this.buttonSaveSkill.Location = new System.Drawing.Point(473, 349);
            this.buttonSaveSkill.Name = "buttonSaveSkill";
            this.buttonSaveSkill.Size = new System.Drawing.Size(75, 23);
            this.buttonSaveSkill.TabIndex = 20;
            this.buttonSaveSkill.Text = "Salvar";
            this.buttonSaveSkill.UseVisualStyleBackColor = true;
            this.buttonSaveSkill.Click += new System.EventHandler(this.buttonSaveSkill_Click);
            // 
            // FormAddSkill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 387);
            this.Controls.Add(this.buttonSaveSkill);
            this.Controls.Add(this.buttonCancelSkill);
            this.Controls.Add(this.buttonSkillColor);
            this.Controls.Add(this.labelSkillDescription);
            this.Controls.Add(this.textBoxSkillDescription);
            this.Controls.Add(this.textBoxSkillDamage);
            this.Controls.Add(this.labelSkillDamage);
            this.Controls.Add(this.labelRecallCost);
            this.Controls.Add(this.numericUpDownRecallCost);
            this.Controls.Add(this.comboBoxSkillDomain);
            this.Controls.Add(this.labelSkillDomain);
            this.Controls.Add(this.comboBoxSkillRange);
            this.Controls.Add(this.labelSkillRange);
            this.Controls.Add(this.comboBoxSkillSource);
            this.Controls.Add(this.labelSkillSource);
            this.Controls.Add(this.comboBoxSkillTrait);
            this.Controls.Add(this.labelSkillTrait);
            this.Controls.Add(this.comboBoxSkillType);
            this.Controls.Add(this.labelSkillType);
            this.Controls.Add(this.textBoxSkillName);
            this.Controls.Add(this.labelSkillName);
            this.Name = "FormAddSkill";
            this.Text = "Adicionar Habilidade";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRecallCost)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSkillName;
        private System.Windows.Forms.TextBox textBoxSkillName;
        private System.Windows.Forms.Label labelSkillType;
        private System.Windows.Forms.ComboBox comboBoxSkillType;
        private System.Windows.Forms.ComboBox comboBoxSkillTrait;
        private System.Windows.Forms.Label labelSkillTrait;
        private System.Windows.Forms.ComboBox comboBoxSkillSource;
        private System.Windows.Forms.Label labelSkillSource;
        private System.Windows.Forms.ComboBox comboBoxSkillRange;
        private System.Windows.Forms.Label labelSkillRange;
        private System.Windows.Forms.ComboBox comboBoxSkillDomain;
        private System.Windows.Forms.Label labelSkillDomain;
        private System.Windows.Forms.NumericUpDown numericUpDownRecallCost;
        private System.Windows.Forms.Label labelRecallCost;
        private System.Windows.Forms.TextBox textBoxSkillDamage;
        private System.Windows.Forms.Label labelSkillDamage;
        private System.Windows.Forms.TextBox textBoxSkillDescription;
        private System.Windows.Forms.Label labelSkillDescription;
        private System.Windows.Forms.Button buttonSkillColor;
        private System.Windows.Forms.Button buttonCancelSkill;
        private System.Windows.Forms.Button buttonSaveSkill;
    }
}
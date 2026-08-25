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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxSkillName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxSkillType = new System.Windows.Forms.ComboBox();
            this.comboBoxSkillTrait = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxSkillSource = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxSkillRange = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxSkillDomain = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.numericUpDownRecallCost = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxSkillDamage = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxSkillDescription = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.buttonSkillColor = new System.Windows.Forms.Button();
            this.buttonCancelSkill = new System.Windows.Forms.Button();
            this.buttonSaveSkill = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRecallCost)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome da Habilidade:";
            // 
            // textBoxSkillName
            // 
            this.textBoxSkillName.Location = new System.Drawing.Point(13, 30);
            this.textBoxSkillName.Name = "textBoxSkillName";
            this.textBoxSkillName.Size = new System.Drawing.Size(130, 20);
            this.textBoxSkillName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(195, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tipo:";
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(384, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Atributo:";
            // 
            // comboBoxSkillSource
            // 
            this.comboBoxSkillSource.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSkillSource.FormattingEnabled = true;
            this.comboBoxSkillSource.Items.AddRange(new object[] {
            "Classe/Subclasse",
            "Carta de Domínio",
            "Ancestraldade/Comunidade",
            "Outros"});
            this.comboBoxSkillSource.Location = new System.Drawing.Point(198, 85);
            this.comboBoxSkillSource.Name = "comboBoxSkillSource";
            this.comboBoxSkillSource.Size = new System.Drawing.Size(161, 21);
            this.comboBoxSkillSource.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(195, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Fonte:";
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(384, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Alcance:";
            // 
            // comboBoxSkillDomain
            // 
            this.comboBoxSkillDomain.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSkillDomain.FormattingEnabled = true;
            this.comboBoxSkillDomain.Location = new System.Drawing.Point(198, 135);
            this.comboBoxSkillDomain.Name = "comboBoxSkillDomain";
            this.comboBoxSkillDomain.Size = new System.Drawing.Size(161, 21);
            this.comboBoxSkillDomain.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(195, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Domínio:";
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
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(387, 175);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Custo de Troca:";
            // 
            // textBoxSkillDamage
            // 
            this.textBoxSkillDamage.Location = new System.Drawing.Point(387, 136);
            this.textBoxSkillDamage.Name = "textBoxSkillDamage";
            this.textBoxSkillDamage.Size = new System.Drawing.Size(161, 20);
            this.textBoxSkillDamage.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(387, 119);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Dano:";
            // 
            // textBoxSkillDescription
            // 
            this.textBoxSkillDescription.Location = new System.Drawing.Point(12, 190);
            this.textBoxSkillDescription.Multiline = true;
            this.textBoxSkillDescription.Name = "textBoxSkillDescription";
            this.textBoxSkillDescription.Size = new System.Drawing.Size(369, 153);
            this.textBoxSkillDescription.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 174);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Descrição:";
            // 
            // buttonSkillColor
            // 
            this.buttonSkillColor.Location = new System.Drawing.Point(413, 226);
            this.buttonSkillColor.Name = "buttonSkillColor";
            this.buttonSkillColor.Size = new System.Drawing.Size(116, 99);
            this.buttonSkillColor.TabIndex = 18;
            this.buttonSkillColor.Text = "Escolher Cor";
            this.buttonSkillColor.UseVisualStyleBackColor = true;
            // 
            // buttonCancelSkill
            // 
            this.buttonCancelSkill.Location = new System.Drawing.Point(16, 349);
            this.buttonCancelSkill.Name = "buttonCancelSkill";
            this.buttonCancelSkill.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelSkill.TabIndex = 19;
            this.buttonCancelSkill.Text = "Cancelar";
            this.buttonCancelSkill.UseVisualStyleBackColor = true;
            // 
            // buttonSaveSkill
            // 
            this.buttonSaveSkill.Location = new System.Drawing.Point(473, 349);
            this.buttonSaveSkill.Name = "buttonSaveSkill";
            this.buttonSaveSkill.Size = new System.Drawing.Size(75, 23);
            this.buttonSaveSkill.TabIndex = 20;
            this.buttonSaveSkill.Text = "Salvar";
            this.buttonSaveSkill.UseVisualStyleBackColor = true;
            // 
            // FormAddSkill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 387);
            this.Controls.Add(this.buttonSaveSkill);
            this.Controls.Add(this.buttonCancelSkill);
            this.Controls.Add(this.buttonSkillColor);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBoxSkillDescription);
            this.Controls.Add(this.textBoxSkillDamage);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.numericUpDownRecallCost);
            this.Controls.Add(this.comboBoxSkillDomain);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBoxSkillRange);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBoxSkillSource);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBoxSkillTrait);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxSkillType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxSkillName);
            this.Controls.Add(this.label1);
            this.Name = "FormAddSkill";
            this.Text = "Adicionar Habilidade";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRecallCost)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxSkillName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxSkillType;
        private System.Windows.Forms.ComboBox comboBoxSkillTrait;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxSkillSource;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxSkillRange;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxSkillDomain;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numericUpDownRecallCost;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxSkillDamage;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxSkillDescription;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button buttonSkillColor;
        private System.Windows.Forms.Button buttonCancelSkill;
        private System.Windows.Forms.Button buttonSaveSkill;
    }
}
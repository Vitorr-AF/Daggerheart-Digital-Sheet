namespace daggerheartSheet
{
    partial class FormAddItem
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxItemName = new System.Windows.Forms.TextBox();
            this.textBoxItemDescription = new System.Windows.Forms.TextBox();
            this.comboBoxItemType = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxItemTier = new System.Windows.Forms.ComboBox();
            this.comboBoxItemTrait = new System.Windows.Forms.ComboBox();
            this.comboBoxItemRange = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonSaveItem = new System.Windows.Forms.Button();
            this.buttonCancelItem = new System.Windows.Forms.Button();
            this.buttonItemColor = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.numericUpDownItemAmount = new System.Windows.Forms.NumericUpDown();
            this.textBoxItemDamage = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownItemAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome do item:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Descrição:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(189, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tipo:";
            // 
            // textBoxItemName
            // 
            this.textBoxItemName.Location = new System.Drawing.Point(15, 26);
            this.textBoxItemName.Name = "textBoxItemName";
            this.textBoxItemName.Size = new System.Drawing.Size(168, 20);
            this.textBoxItemName.TabIndex = 3;
            // 
            // textBoxItemDescription
            // 
            this.textBoxItemDescription.Location = new System.Drawing.Point(15, 131);
            this.textBoxItemDescription.Multiline = true;
            this.textBoxItemDescription.Name = "textBoxItemDescription";
            this.textBoxItemDescription.Size = new System.Drawing.Size(502, 178);
            this.textBoxItemDescription.TabIndex = 4;
            // 
            // comboBoxItemType
            // 
            this.comboBoxItemType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxItemType.FormattingEnabled = true;
            this.comboBoxItemType.Items.AddRange(new object[] {
            "Armadura",
            "Cadeira de rodas de combate",
            "Consumivel",
            "Item",
            "Arma primaria",
            "Arma secundária"});
            this.comboBoxItemType.Location = new System.Drawing.Point(192, 40);
            this.comboBoxItemType.Name = "comboBoxItemType";
            this.comboBoxItemType.Size = new System.Drawing.Size(152, 21);
            this.comboBoxItemType.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(358, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tier:";
            // 
            // comboBoxItemTier
            // 
            this.comboBoxItemTier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxItemTier.FormattingEnabled = true;
            this.comboBoxItemTier.Items.AddRange(new object[] {
            "Nenhum",
            "1",
            "2",
            "3",
            "4"});
            this.comboBoxItemTier.Location = new System.Drawing.Point(361, 40);
            this.comboBoxItemTier.Name = "comboBoxItemTier";
            this.comboBoxItemTier.Size = new System.Drawing.Size(152, 21);
            this.comboBoxItemTier.TabIndex = 7;
            // 
            // comboBoxItemTrait
            // 
            this.comboBoxItemTrait.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxItemTrait.FormattingEnabled = true;
            this.comboBoxItemTrait.Items.AddRange(new object[] {
            "Agilidade",
            "Força",
            "Finesse",
            "Conhecimento",
            "Instinto",
            "Presença"});
            this.comboBoxItemTrait.Location = new System.Drawing.Point(192, 87);
            this.comboBoxItemTrait.Name = "comboBoxItemTrait";
            this.comboBoxItemTrait.Size = new System.Drawing.Size(152, 21);
            this.comboBoxItemTrait.TabIndex = 8;
            // 
            // comboBoxItemRange
            // 
            this.comboBoxItemRange.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxItemRange.FormattingEnabled = true;
            this.comboBoxItemRange.Items.AddRange(new object[] {
            "",
            "Corpo-a-corpo",
            "Muito perto",
            "Perto",
            "Distante",
            "Muito distante"});
            this.comboBoxItemRange.Location = new System.Drawing.Point(361, 87);
            this.comboBoxItemRange.Name = "comboBoxItemRange";
            this.comboBoxItemRange.Size = new System.Drawing.Size(152, 21);
            this.comboBoxItemRange.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(189, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Atributo:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(358, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Alcance:";
            // 
            // buttonSaveItem
            // 
            this.buttonSaveItem.Location = new System.Drawing.Point(438, 321);
            this.buttonSaveItem.Name = "buttonSaveItem";
            this.buttonSaveItem.Size = new System.Drawing.Size(75, 23);
            this.buttonSaveItem.TabIndex = 12;
            this.buttonSaveItem.Text = "Salvar";
            this.buttonSaveItem.UseVisualStyleBackColor = true;
            this.buttonSaveItem.Click += new System.EventHandler(this.buttonSaveItem_Click);
            // 
            // buttonCancelItem
            // 
            this.buttonCancelItem.Location = new System.Drawing.Point(15, 321);
            this.buttonCancelItem.Name = "buttonCancelItem";
            this.buttonCancelItem.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelItem.TabIndex = 13;
            this.buttonCancelItem.Text = "Cancelar";
            this.buttonCancelItem.UseVisualStyleBackColor = true;
            this.buttonCancelItem.Click += new System.EventHandler(this.buttonCancelItem_Click);
            // 
            // buttonItemColor
            // 
            this.buttonItemColor.Location = new System.Drawing.Point(587, 159);
            this.buttonItemColor.Name = "buttonItemColor";
            this.buttonItemColor.Size = new System.Drawing.Size(116, 99);
            this.buttonItemColor.TabIndex = 15;
            this.buttonItemColor.Text = "Escolher Cor";
            this.buttonItemColor.UseVisualStyleBackColor = true;
            this.buttonItemColor.Click += new System.EventHandler(this.buttonItemColor_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(531, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Quantidade:";
            // 
            // numericUpDownItemAmount
            // 
            this.numericUpDownItemAmount.Location = new System.Drawing.Point(534, 41);
            this.numericUpDownItemAmount.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownItemAmount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownItemAmount.Name = "numericUpDownItemAmount";
            this.numericUpDownItemAmount.Size = new System.Drawing.Size(152, 20);
            this.numericUpDownItemAmount.TabIndex = 17;
            this.numericUpDownItemAmount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // textBoxItemDamage
            // 
            this.textBoxItemDamage.Location = new System.Drawing.Point(534, 88);
            this.textBoxItemDamage.Name = "textBoxItemDamage";
            this.textBoxItemDamage.Size = new System.Drawing.Size(152, 20);
            this.textBoxItemDamage.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(531, 72);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Dano:";
            // 
            // FormAddItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 356);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxItemDamage);
            this.Controls.Add(this.numericUpDownItemAmount);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.buttonItemColor);
            this.Controls.Add(this.buttonCancelItem);
            this.Controls.Add(this.buttonSaveItem);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBoxItemRange);
            this.Controls.Add(this.comboBoxItemTrait);
            this.Controls.Add(this.comboBoxItemTier);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBoxItemType);
            this.Controls.Add(this.textBoxItemDescription);
            this.Controls.Add(this.textBoxItemName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormAddItem";
            this.Text = "Adicionar Item";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownItemAmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxItemName;
        private System.Windows.Forms.TextBox textBoxItemDescription;
        private System.Windows.Forms.ComboBox comboBoxItemType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxItemTier;
        private System.Windows.Forms.ComboBox comboBoxItemTrait;
        private System.Windows.Forms.ComboBox comboBoxItemRange;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonSaveItem;
        private System.Windows.Forms.Button buttonCancelItem;
        private System.Windows.Forms.Button buttonItemColor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numericUpDownItemAmount;
        private System.Windows.Forms.TextBox textBoxItemDamage;
        private System.Windows.Forms.Label label8;
    }
}
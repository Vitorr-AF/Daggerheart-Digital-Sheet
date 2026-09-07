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
            this.labelItemName = new System.Windows.Forms.Label();
            this.labelItemDescription = new System.Windows.Forms.Label();
            this.labelItemType = new System.Windows.Forms.Label();
            this.textBoxItemName = new System.Windows.Forms.TextBox();
            this.textBoxItemDescription = new System.Windows.Forms.TextBox();
            this.comboBoxItemType = new System.Windows.Forms.ComboBox();
            this.labelItemTier = new System.Windows.Forms.Label();
            this.comboBoxItemTier = new System.Windows.Forms.ComboBox();
            this.comboBoxItemTrait = new System.Windows.Forms.ComboBox();
            this.comboBoxItemRange = new System.Windows.Forms.ComboBox();
            this.labelItemTrait = new System.Windows.Forms.Label();
            this.labelItemRange = new System.Windows.Forms.Label();
            this.buttonSaveItem = new System.Windows.Forms.Button();
            this.buttonCancelItem = new System.Windows.Forms.Button();
            this.buttonItemColor = new System.Windows.Forms.Button();
            this.labelItemAmount = new System.Windows.Forms.Label();
            this.numericUpDownItemAmount = new System.Windows.Forms.NumericUpDown();
            this.textBoxItemDamage = new System.Windows.Forms.TextBox();
            this.labelItemDamage = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownItemAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // labelItemName
            // 
            this.labelItemName.AutoSize = true;
            this.labelItemName.Location = new System.Drawing.Point(12, 9);
            this.labelItemName.Name = "labelItemName";
            this.labelItemName.Size = new System.Drawing.Size(75, 13);
            this.labelItemName.TabIndex = 0;
            this.labelItemName.Text = "Nome do item:";
            // 
            // labelItemDescription
            // 
            this.labelItemDescription.AutoSize = true;
            this.labelItemDescription.Location = new System.Drawing.Point(12, 114);
            this.labelItemDescription.Name = "labelItemDescription";
            this.labelItemDescription.Size = new System.Drawing.Size(58, 13);
            this.labelItemDescription.TabIndex = 1;
            this.labelItemDescription.Text = "Descrição:";
            // 
            // labelItemType
            // 
            this.labelItemType.AutoSize = true;
            this.labelItemType.Location = new System.Drawing.Point(189, 25);
            this.labelItemType.Name = "labelItemType";
            this.labelItemType.Size = new System.Drawing.Size(31, 13);
            this.labelItemType.TabIndex = 2;
            this.labelItemType.Text = "Tipo:";
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
            "",
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
            // labelItemTier
            // 
            this.labelItemTier.AutoSize = true;
            this.labelItemTier.Location = new System.Drawing.Point(358, 25);
            this.labelItemTier.Name = "labelItemTier";
            this.labelItemTier.Size = new System.Drawing.Size(28, 13);
            this.labelItemTier.TabIndex = 6;
            this.labelItemTier.Text = "Tier:";
            // 
            // comboBoxItemTier
            // 
            this.comboBoxItemTier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxItemTier.FormattingEnabled = true;
            this.comboBoxItemTier.Items.AddRange(new object[] {
            "",
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
            "",
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
            // labelItemTrait
            // 
            this.labelItemTrait.AutoSize = true;
            this.labelItemTrait.Location = new System.Drawing.Point(189, 71);
            this.labelItemTrait.Name = "labelItemTrait";
            this.labelItemTrait.Size = new System.Drawing.Size(46, 13);
            this.labelItemTrait.TabIndex = 10;
            this.labelItemTrait.Text = "Atributo:";
            // 
            // labelItemRange
            // 
            this.labelItemRange.AutoSize = true;
            this.labelItemRange.Location = new System.Drawing.Point(358, 71);
            this.labelItemRange.Name = "labelItemRange";
            this.labelItemRange.Size = new System.Drawing.Size(49, 13);
            this.labelItemRange.TabIndex = 11;
            this.labelItemRange.Text = "Alcance:";
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
            // labelItemAmount
            // 
            this.labelItemAmount.AutoSize = true;
            this.labelItemAmount.Location = new System.Drawing.Point(531, 25);
            this.labelItemAmount.Name = "labelItemAmount";
            this.labelItemAmount.Size = new System.Drawing.Size(65, 13);
            this.labelItemAmount.TabIndex = 16;
            this.labelItemAmount.Text = "Quantidade:";
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
            // labelItemDamage
            // 
            this.labelItemDamage.AutoSize = true;
            this.labelItemDamage.Location = new System.Drawing.Point(531, 72);
            this.labelItemDamage.Name = "labelItemDamage";
            this.labelItemDamage.Size = new System.Drawing.Size(36, 13);
            this.labelItemDamage.TabIndex = 19;
            this.labelItemDamage.Text = "Dano:";
            // 
            // FormAddItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 356);
            this.Controls.Add(this.labelItemDamage);
            this.Controls.Add(this.textBoxItemDamage);
            this.Controls.Add(this.numericUpDownItemAmount);
            this.Controls.Add(this.labelItemAmount);
            this.Controls.Add(this.buttonItemColor);
            this.Controls.Add(this.buttonCancelItem);
            this.Controls.Add(this.buttonSaveItem);
            this.Controls.Add(this.labelItemRange);
            this.Controls.Add(this.labelItemTrait);
            this.Controls.Add(this.comboBoxItemRange);
            this.Controls.Add(this.comboBoxItemTrait);
            this.Controls.Add(this.comboBoxItemTier);
            this.Controls.Add(this.labelItemTier);
            this.Controls.Add(this.comboBoxItemType);
            this.Controls.Add(this.textBoxItemDescription);
            this.Controls.Add(this.textBoxItemName);
            this.Controls.Add(this.labelItemType);
            this.Controls.Add(this.labelItemDescription);
            this.Controls.Add(this.labelItemName);
            this.Name = "FormAddItem";
            this.Text = "Adicionar Item";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownItemAmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelItemName;
        private System.Windows.Forms.Label labelItemDescription;
        private System.Windows.Forms.Label labelItemType;
        private System.Windows.Forms.TextBox textBoxItemName;
        private System.Windows.Forms.TextBox textBoxItemDescription;
        private System.Windows.Forms.ComboBox comboBoxItemType;
        private System.Windows.Forms.Label labelItemTier;
        private System.Windows.Forms.ComboBox comboBoxItemTier;
        private System.Windows.Forms.ComboBox comboBoxItemTrait;
        private System.Windows.Forms.ComboBox comboBoxItemRange;
        private System.Windows.Forms.Label labelItemTrait;
        private System.Windows.Forms.Label labelItemRange;
        private System.Windows.Forms.Button buttonSaveItem;
        private System.Windows.Forms.Button buttonCancelItem;
        private System.Windows.Forms.Button buttonItemColor;
        private System.Windows.Forms.Label labelItemAmount;
        private System.Windows.Forms.NumericUpDown numericUpDownItemAmount;
        private System.Windows.Forms.TextBox textBoxItemDamage;
        private System.Windows.Forms.Label labelItemDamage;
    }
}
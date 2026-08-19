using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace daggerheartSheet
{
    public partial class FormAddItem : Form
    {
        public FormAddItem()
        {
            InitializeComponent();
        }

        public string ItemName { get; set; }
        public string ItemDescription { get; set; }
        public string ItemType { get; set; }
        public string ItemTier { get; set; }
        public string ItemTrait { get; set; }
        public string ItemRange { get; set; }
        public Color chosenColor { get; set; } = Color.White;
        public string ItemDamage { get; set; }
        public string ItemAmount { get; set; }

        private void buttonSaveItem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxItemName.Text))
            {
                MessageBox.Show("Digite o nome do item!!!");
                return;
            }

            ItemName = textBoxItemName.Text;
            ItemDescription = textBoxItemDescription.Text;
            ItemType = comboBoxItemType.Text;
            ItemTier = comboBoxItemTier.Text;
            ItemTrait = comboBoxItemTrait.Text;
            ItemRange = comboBoxItemRange.Text;
            ItemDamage = textBoxItemDamage.Text;
            ItemAmount = numericUpDownItemAmount.Text;

            DialogResult = DialogResult.OK;
            Close();

        }

        private void buttonCancelItem_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void buttonItemColor_Click(object sender, EventArgs e)
        {
            using (ColorDialog dialog = new ColorDialog())
            {
                if(dialog.ShowDialog() == DialogResult.OK)
                {
                    chosenColor = dialog.Color;
                    buttonItemColor.BackColor = chosenColor;
                    buttonItemColor.ForeColor = Helper.GetContrastColor(chosenColor);
                }
            }
        }
    }
}

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
    public partial class FormAddSkill : Form
    {
        public FormAddSkill()
        {
            InitializeComponent();
        }

        public string SkillName { get; set; }
        public string SkillDescription { get; set; }
        public string SkillSource { get; set; }
        public int SkillRecallCost { get; set; }
        public string SkillType { get; set; }
        public string SkillRange { get; set; }
        public string SkillDamage { get; set; }
        public string SkillTrait { get; set; }
        public string SkillDomain { get; set; }
        public Color chosenColor { get; set; } = Color.White;

        private void buttonSaveSkill_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxSkillName.Text) || string.IsNullOrWhiteSpace(comboBoxSkillSource.Text))
            {
                MessageBox.Show("Digite o nome da habilidade e selecione a fonte !!!");
                return;
            }


            SkillName = textBoxSkillName.Text;
            SkillDescription = textBoxSkillDescription.Text;
            SkillSource = comboBoxSkillSource.Text;
            SkillRecallCost = (int)numericUpDownRecallCost.Value;
            SkillType = comboBoxSkillType.Text;
            SkillRange = comboBoxSkillRange.Text;
            SkillDamage = textBoxSkillDamage.Text;
            SkillTrait = comboBoxSkillTrait.Text;
            SkillDomain = comboBoxSkillDomain.Text;

            DialogResult = DialogResult.OK;
            Close();
        }

        private void buttonCancelSkill_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void buttonSkillColor_Click(object sender, EventArgs e)
        {
            using (ColorDialog dialog = new ColorDialog())
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    chosenColor = dialog.Color;
                    buttonSkillColor.BackColor = chosenColor;
                    buttonSkillColor.ForeColor = Helper.GetContrastColor(chosenColor);
                }
            }
        }
    }
}

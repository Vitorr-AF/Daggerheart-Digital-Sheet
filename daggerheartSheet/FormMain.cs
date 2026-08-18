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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void textBoxName_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                this.ActiveControl = null;
                e.SuppressKeyPress = true;
            }
        }

        private void textBoxPronouns_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.ActiveControl = null;
                e.SuppressKeyPress = true;
            }
        }

        private void textBoxHeritage_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.ActiveControl = null;
                e.SuppressKeyPress = true;
            }
        }

        private void textBoxClass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.ActiveControl = null;
                e.SuppressKeyPress = true;
            }
        }

        private void buttonAddItem_Click(object sender, EventArgs e)
        {
            using (FormAddItem window = new FormAddItem())
            {
                if (window.ShowDialog() == DialogResult.OK)
                {
                    
                    
                    if(window.ShowDialog() == DialogResult.OK)
                    {
                        Panel itemPanel = new Panel();

                        InventoryItem item = new InventoryItem
                        {
                            Name = window.ItemName,
                            Description = window.ItemDescription,
                            Type = window.ItemType,
                            Tier = int.TryParse(window.ItemTier, out int tier) ? tier : 0,
                            Trait = window.ItemTrait,
                            Range = window.ItemRange
                        };

                            

                        // Panel size
                        itemPanel.Width = flowLayoutInventory.ClientSize.Width - 25; 
                        itemPanel.Height = 80;

                        // Panel color
                        itemPanel.BackColor = Color.FromArgb(60, 60, 60);
                        itemPanel.Margin = new Padding(5);

                        // Panel Text
                        Label nameLabel = new Label();
                        nameLabel.Text = window.ItemName;
                        nameLabel.ForeColor = Color.White;
                        nameLabel.Font = new Font("Segoe UI", 11, FontStyle.Bold);
                        nameLabel.Location = new Point(10, 10);
                        nameLabel.AutoSize = true;

                        itemPanel.Tag = item;
                        itemPanel.Click += ItemPanel_Click;
                        itemPanel.Controls.Add(nameLabel);

                        flowLayoutInventory.Controls.Add(itemPanel);
                    }
                    

                }
            }
        }

        private void ItemPanel_Click(object sender, EventArgs e)
        {
            Panel panel = (Panel)sender;

            InventoryItem item = (InventoryItem)panel.Tag;

            MessageBox.Show(item.Description);
        }
    }
}

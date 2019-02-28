using System;
using System.Windows.Forms;

namespace Model_First
{
    public partial class Form2 : Form
    {

        public string CatName { get; private set; }
        public string Age { get; private set; }
        public string OwnerName { get; private set; }

        public Form2(TypeEdit typeEdit)
        {
            InitializeComponent();
            this.DialogResult = DialogResult.Cancel;

            switch (typeEdit)
            {
                case TypeEdit.addCat:
                    {
                        this.Text = "Add cat";
                        labelCatName.Visible = true;
                        labelAge.Visible = true;
                        textBoxCatName.Visible = true;
                        textBoxAge.Visible = true;
                        break;
                    }
                case TypeEdit.addOwner:
                    {
                        this.Text = "Add owner";
                        labelCatName.Visible = false;
                        labelAge.Visible = false;
                        textBoxCatName.Visible = false;
                        textBoxAge.Visible = false;
                        break;
                    }
                case TypeEdit.deleteCat:
                    {
                        this.Text = "Delete cat";
                        labelCatName.Visible = true;
                        labelAge.Visible = false;
                        textBoxCatName.Visible = true;
                        textBoxAge.Visible = false;
                        break;
                    }
            }
        }

        private void buttonAccept_Click(object sender, EventArgs e)
        {
            CatName = textBoxCatName.Text;
            Age = textBoxAge.Text;
            OwnerName = textBoxNewOwnerName.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}

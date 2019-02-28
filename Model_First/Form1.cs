using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Model_First
{
    public partial class Form1 : Form
    {
        CatsModelContainer db = new CatsModelContainer();
        EventArgs args = new EventArgs();
        public Form1()
        {
            InitializeComponent();
            SetVisibleSearch(false);
            allCatsToolStripMenuItem_Click(this, args);
            chart1.Series[0].XValueMember = "name";
            chart1.Series[0].YValueMembers = "count";
        }

        private void SetVisibleSearch(bool visible, string labelText = "Cat name")
        {
            labelSearchBy.Visible = visible;
            textBoxSearch.Visible = visible;
            buttonSearch.Visible = visible;
            chart1.Visible = !visible;
            pictureBox1.Visible = !visible;
            if (visible)
            {
                textBoxSearch.Text = "";
                labelSearchBy.Text = labelText;
            }
        }

        private void allCatsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.CatsSet.Select(c => new { c.Name, c.Age, c.Owner.Surname }).ToList();
        }

        private void byCatNameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetVisibleSearch(true, "Cat name");
        }

        private void byAgeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetVisibleSearch(true, "Age");
        }

        private void byOwnerNameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetVisibleSearch(true, "Owner name");
        }

        private void namesOfCatsInAlphabeticalOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.CatsSet.Select(c => new { c.Name }).Distinct().OrderBy(c=>c.Name).ToList();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            if (labelSearchBy.Text == "Cat name")
                dataGridView1.DataSource = db.CatsSet.Select(c => new { c.Name, c.Age, c.Owner.Surname }).Where(a => a.Name == textBoxSearch.Text).ToList();
            else if (labelSearchBy.Text == "Age")
            {
                try
                {
                    int age = -1;
                    if (!Int32.TryParse(textBoxSearch.Text, out age) || age <= 0)
                        throw new Exception("Error! Your age value is incorrect.");
                    dataGridView1.DataSource = db.CatsSet.Select(c => new { c.Name, c.Age, c.Owner.Surname }).Where(a => a.Age == age).ToList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (labelSearchBy.Text == "Owner name")
                dataGridView1.DataSource = db.CatsSet.Select(c => new { c.Name, c.Age, c.Owner.Surname }).Where(a => a.Surname == textBoxSearch.Text).ToList();
            SetVisibleSearch(false);
        }

        private void showDiagramByOwnersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetVisibleSearch(false);
            pictureBox1.Visible = false;
            chart1.DataSource = db.CatsSet.GroupBy(c => c.Owner.Surname).Select(x => new { name = x.Key, count = x.Count() }).ToList();
            chart1.Invalidate();
        }

        private void whoHaveMoreThanTwoCatsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetVisibleSearch(false);
            pictureBox1.Visible = false;
            chart1.DataSource = db.CatsSet.GroupBy(c => c.Owner.Surname).Select(x => new { name = x.Key, count = x.Count() }).Where(c=>c.count>2).ToList();
            chart1.Invalidate();
        }

        private void averageAgeOfCatsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            double ageAvg = db.CatsSet.Average(a => a.Age);
            MessageBox.Show("Average age of cats = "+ageAvg.ToString("f2"));
        }

        private void addCatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeData(TypeEdit.addCat);
            allCatsToolStripMenuItem_Click(this, args);
        }

        private void addOwnerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeData(TypeEdit.addOwner);
            dataGridView1.DataSource = db.OwnersSet.Select(c => new { Owners = c.Surname }).ToList();
        }

        private void deleteCatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeData(TypeEdit.deleteCat);
            allCatsToolStripMenuItem_Click(this, args);
        }

        private void ChangeData(TypeEdit typeEdit)
        {
            using (Form2 form2 = new Form2(typeEdit))
            {
                if (form2.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        int age = 0;
                        if (typeEdit == TypeEdit.addCat && !Int32.TryParse(form2.Age, out age))
                            throw new Exception("Error! Your cat age is incorrect.");
                        if (form2.OwnerName == "")
                            throw new Exception("Error! You don't write owner name.");
                        if ((typeEdit == TypeEdit.addCat || typeEdit == TypeEdit.deleteCat) && form2.CatName == "")
                            throw new Exception("Error! You don't write cat name.");
                        //db.Database.BeginTransaction();
                        switch (typeEdit)
                        {
                            case TypeEdit.addCat:
                                {
                                    AddOwner(form2);
                                    db.SaveChanges();
                                    Cats cat = new Cats()
                                    {
                                        Name = form2.CatName,
                                        Age = age,
                                        Owner = db.OwnersSet.FirstOrDefault(o => o.Surname == form2.OwnerName)
                                    };
                                    db.CatsSet.Add(cat);
                                    break;
                                }
                            case TypeEdit.addOwner:
                                {
                                    AddOwner(form2);
                                    break;
                                }
                            case TypeEdit.deleteCat:
                                {
                                    Cats cat = db.CatsSet.FirstOrDefault(a => a.Name == form2.CatName && a.Owner.Surname == form2.OwnerName);
                                    if(cat!=null)
                                        db.CatsSet.Remove(cat);
                                    else
                                        throw new Exception("Error! The cat has not been deleted from the database, as there is no such cat and (or) owner in the database.");
                                    break;
                                }
                        }
                        //db.Database.BeginTransaction().Commit();
                        db.SaveChanges();
                    }
                    catch (Exception ex)
                    {
                        //db.Database.BeginTransaction().Rollback();
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void AddOwner(Form2 form2)
        {
            Owners owner = db.OwnersSet.FirstOrDefault(o => o.Surname == form2.OwnerName);
            if (owner == null)
            {
                owner = new Owners { Surname = form2.OwnerName };
            }
            db.OwnersSet.Add(owner);
        }
    }
}

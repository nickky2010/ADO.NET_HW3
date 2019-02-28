using DataBase_First.App_Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBase_First
{
    public partial class Form1 : Form
    {
        СompetitionsEntities db = new СompetitionsEntities();
        public Form1()
        {
            InitializeComponent();
            dataGridView1.DataSource = db.Sportsmens.Select(s => new
            {
                Surname_sportsmen = s.Surname,
                Sport = s.Sport.Name,
                Country = s.Country.Name,
                Result = s.ResultOfCompetition
            }).ToList();
        }
    }
}

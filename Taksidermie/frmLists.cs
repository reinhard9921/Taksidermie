using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Taksidermie
{
    public partial class frmLists : Form
    {
        public frmLists()
        {
            InitializeComponent();
        }
        DataHandler dh = new DataHandler();
        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void FrmLists_Load(object sender, EventArgs e)
        {

            dgvAnimals.DataSource = dh.ReadAnimalType();
            dgvAnimals.DataMember = "tblAnimal";
            dgvMountType.DataSource = dh.ReadMountType();
            dgvMountType.DataMember = "tblMountType";
        }
        int Animal;
        private void DgvAnimals_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvAnimals.CurrentCell != null)
            {
                try
                {
                    int index = dgvAnimals.CurrentCell.RowIndex;

                    Animal = (int)dgvAnimals.Rows[index].Cells[0].Value;

                    string animalType = dgvAnimals.Rows[index].Cells[1].Value.ToString();
                    txtAnimals.Text = animalType;




                }
                catch (Exception r)
                {

                    MessageBox.Show("Selection Change " + r);
                }
            }
        }
        int mountType;
        private void DgvMountType_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvMountType.CurrentCell != null)
            {
                try
                {
                    int index = dgvMountType.CurrentCell.RowIndex;

                    mountType = (int)dgvMountType.Rows[index].Cells[0].Value;

                    string animalType = dgvMountType.Rows[index].Cells[1].Value.ToString();
                    txtMountType.Text = animalType;




                }
                catch (Exception r)
                {

                    MessageBox.Show("Selection Change " + r);
                }
            }
        }

        private void BtnAddAnimal_Click(object sender, EventArgs e)
        {
            dh.AddAnimalType(txtAnimals.Text);
            dgvAnimals.DataSource = null;
            dgvAnimals.DataSource = dh.ReadAnimalType();
            dgvAnimals.DataMember = "tblAnimal";
        }

        private void BtnUpdateAnimal_Click(object sender, EventArgs e)
        {
            dh.UpdateAnimalType(txtAnimals.Text, Animal);
            dgvAnimals.DataSource = null;
            dgvAnimals.DataSource = dh.ReadAnimalType();
            dgvAnimals.DataMember = "tblAnimal";
        }

        private void BtnDeleteAnimal_Click(object sender, EventArgs e)
        {
            dh.DeleteAnimalType(Animal);
            dgvAnimals.DataSource = null;
            dgvAnimals.DataSource = dh.ReadAnimalType();
            dgvAnimals.DataMember = "tblAnimal";
        }

        private void BtnAddMount_Click(object sender, EventArgs e)
        {
            dh.AddMountType(txtMountType.Text);
            dgvMountType.DataSource = null;
            dgvMountType.DataSource = dh.ReadMountType();
            dgvMountType.DataMember = "tblMountType";
        }

        private void BtnUpdateMount_Click(object sender, EventArgs e)
        {
            dh.UpdateMountType(txtMountType.Text, mountType);
            dgvMountType.DataSource = null;
            dgvMountType.DataSource = dh.ReadMountType();
            dgvMountType.DataMember = "tblMountType";
        }

        private void BtnDeleteMount_Click(object sender, EventArgs e)
        {
            dh.DeleteMountType(mountType);
            dgvMountType.DataSource = null;
            dgvMountType.DataSource = dh.ReadMountType();
            dgvMountType.DataMember = "tblMountType";
        }
    }
}

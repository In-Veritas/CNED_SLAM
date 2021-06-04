using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;

namespace Devoir_SLAM
{
    public partial class View : Form
    {
        private bool login = false;
        bool ajouter = false;
        bool absence = false;
        bool modifier = false;
        bool supprimer = false;
        bool personnel = false;
        public View()
        {
            InitializeComponent();
            resetter();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {
        }

        public void resetter()
        {
            grpData.Enabled = false;
            grpLogin.Enabled = true;
            btnShowAb.Enabled = false;
            btnShowPers.Enabled = false;
            btnInsert.Enabled = false;
            btnCancel.Enabled = false;
            txtbUsername.Focus();
        }

        public void logon()
        {
            grpData.Enabled = true;
            grpLogin.Enabled = false;
            btnShowAb.Enabled = true;
            btnShowPers.Enabled = true;
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            dal Request = new dal();
            Responsable res = new Responsable(txtbUsername.Text, txtbPassword.Text);
            if (Request.sendLogin(res))
            {
                MessageBox.Show("Login Successful");
                logon();
            }
            else
            {
                MessageBox.Show("Invalid Credentials/Connection to server unavailable");
            }
        }

        public void btnAjouter_Click(object sender, EventArgs e)
        {
            txtNom.Enabled = true;
            txtPrenom.Enabled = true;
            txtTel.Enabled = true;
            txtMail.Enabled = true;
            txtDateF.Enabled = true;
            txtPersA.Enabled = true;
            btnCancel.Enabled = true;
            btnInsert.Enabled = true;
            btnCancel.Visible = true;
            btnInsert.Visible = true;
            if (radioPersonnel.Checked)
            {
                ajouter = true;
                absence = false;
                modifier = false;
                supprimer = false;
                personnel = true;
                addPersonelBox.Visible = true;
                grpbAbsence.Visible = false;
            }
            if (radioAbsences.Checked)
            {
                ajouter = true;
                absence = true;
                modifier = false;
                supprimer = false;
                personnel = false;
                addPersonelBox.Visible = false;
                grpbAbsence.Visible = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void radioPersonnel_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioAbsences_CheckedChanged(object sender, EventArgs e)
        {

        }

        public void btnModifier_Click(object sender, EventArgs e)
        {
            MessageBox.Show("First field will be used as reference, and the others will be updated");
            txtNom.Enabled = true;
            txtPrenom.Enabled = true;
            txtTel.Enabled = true;
            txtMail.Enabled = true;
            txtDateF.Enabled = true;
            txtPersA.Enabled = true;
            btnCancel.Enabled = true;
            btnInsert.Enabled = true;
            btnCancel.Visible = true;
            btnInsert.Visible = true;
            if (radioPersonnel.Checked)
            {
                ajouter = false;
                absence = false;
                modifier = true;
                supprimer = false;
                personnel = true;
                addPersonelBox.Visible = true;
                grpbAbsence.Visible = false;

            }
            if (radioAbsences.Checked)
            {
                ajouter = false;
                absence = true;
                modifier = true;
                supprimer = false;
                personnel = false;
                addPersonelBox.Visible = false;
                grpbAbsence.Visible = true;

            }
        }

        public void btnSupprimer_Click(object sender, EventArgs e)
        {
            MessageBox.Show("First field will be used as reference for which row will be deleted from the system");
            txtNom.Enabled = false;
            txtPrenom.Enabled = false;
            txtTel.Enabled = false;
            txtMail.Enabled = false;
            txtDateF.Enabled = false;
            txtPersA.Enabled = false;
            btnCancel.Enabled = true;
            btnInsert.Enabled = true;
            btnCancel.Visible = true;
            btnInsert.Visible = true;
            if (radioPersonnel.Checked)
            {
                ajouter = false;
                absence = false;
                modifier = false;
                supprimer = true;
                personnel = true;
                addPersonelBox.Visible = true;
                grpbAbsence.Visible = false;


            }
            if (radioAbsences.Checked)
            {
                ajouter = false;
                absence = true;
                modifier = false;
                supprimer = true;
                personnel = false;
                addPersonelBox.Visible = false;
                grpbAbsence.Visible = true;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            listTables.Items.Clear();
            List<string[]> personnelList = Connection.conInstance.Select("personnel", 6);
            string line = "";
            for (int i = 0; i < personnelList.Count; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    if(j == 5)
                    {
                        line = line + (personnelList[i][j] + "\n");
                    }
                    line = line + (personnelList[i][j] + "\t");
                }
                listTables.Items.Add(line);
                line = "";
            }
        }

        public void button3_Click(object sender, EventArgs e)
        {

            if (absence == true)
            {
                if(ajouter == true)
                {
                    Connection.conInstance.Insert("absence", "(datedebut, datefin, personne_absente)", "(\"" + txtDateD.Text + "\",\"" + txtDateF.Text + "\",\"" + txtPersA.Text + "\")");
                }
                else if(modifier == true)
                {
                    Connection.conInstance.Update("absence", "datedebut = \"" + txtDateD.Text + "\", datefin = \"" + txtDateF.Text + "\", personne_absente = \"" + txtPersA.Text + "\"", "datedebut = \"" + txtDateD.Text + "\"");
                }
                else if(supprimer == true)
                {
                    Connection.conInstance.Delete("absence", "datedebut = \"" + txtDateD.Text + "\"");
                }
            }
            else if(personnel == true)
            {
                if (ajouter == true)
                {
                    Connection.conInstance.Insert("personnel", "(idpersonnel, nom, prenom, tel, mail)", "(\"" + txtId.Text + "\",\"" + txtNom.Text + "\",\"" + txtPrenom.Text + "\",\"" + txtTel.Text + "\",\"" + txtMail.Text + "\")");
                }
                else if (modifier == true)
                {
                    Connection.conInstance.Update("personnel", "idpersonnel = \"" + txtId.Text + "\", nom = \""+ txtNom.Text+ "\", prenom = \"" + txtPrenom.Text + "\", tel = \"" + txtTel.Text + "\", mail = \"" + txtMail.Text + "\"", "idpersonnel = " + txtId.Text);
                }
                else if (supprimer == true)
                {
                    Connection.conInstance.Delete("personnel", "idpersonnel = " + txtId.Text + "");
                }
            }
            txtId.Text = "";
            txtDateD.Text = "";
            txtNom.Text = "";
            txtPrenom.Text = "";
            txtTel.Text = "";
            txtMail.Text = "";
            txtDateF.Text = "";
            txtPersA.Text = "";

        }

        private void btnShowAb_Click(object sender, EventArgs e)
        {
            listTables.Items.Clear();
            List<string[]> absenceList = Connection.conInstance.Select("absence", 4);
            string line = "";
            for (int i = 0; i < absenceList.Count; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (j == 3)
                    {
                        line = line + (absenceList[i][j] + "\n");
                    }
                    line = line + (absenceList[i][j] + "\t");
                }
                listTables.Items.Add(line);
                line = "";
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtId.Text = "";
            txtDateD.Text = "";
            txtNom.Text = "";
            txtPrenom.Text = "";
            txtTel.Text = "";
            txtMail.Text = "";
            txtDateF.Text = "";
            txtPersA.Text = "";
            grpbAbsence.Visible = false;
            addPersonelBox.Visible = false;
            radioAbsences.Checked = false;
            radioPersonnel.Checked = false;
        }
    }
}

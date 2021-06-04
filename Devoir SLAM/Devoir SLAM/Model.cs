using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Devoir_SLAM;
using System.Text;
using System.Security.Cryptography;

namespace Devoir_SLAM
{
    public partial class View : Form { }
}

namespace Model
{
    static class Model
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Devoir_SLAM.View());
        }
    }
    class Connection
    {
        private static readonly MySqlConnection con;
        public static Connection conInstance = new Connection();


        static Connection()
        {

            string connectionString;
            connectionString = "SERVER=localhost; DATABASE=mediatek86; UID=root; PASSWORD= all0755;";
            con = new MySqlConnection(connectionString);
        }

        private Connection()
        {
        }

        public void Insert(string table, string columns, string values)
        {
            string query = "INSERT INTO " + table + columns + " VALUES " + values + ";";
            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.ExecuteNonQuery();
                this.CloseConnection();
            }
        }
        public void Update(string table, string attributes, string condition)
        {
            string query = "UPDATE " + table + " SET " + attributes +" WHERE " + condition + ";";
            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = query;
                cmd.Connection = con;
                cmd.ExecuteNonQuery();
                this.CloseConnection();
            }
        }
        public void Delete(string table, string condition)
        {
            string query = "DELETE FROM " + table + " WHERE " + condition + ";";

            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.ExecuteNonQuery();
                this.CloseConnection();
            }
        }
        public List<string[]> Select(string table, int columns, string selection = "*", string extra = " ")
        {
            string query = "SELECT " + selection + " FROM " + table + " " + extra + ";";
            List<string[]> selectedTable = new List<string[]>();

            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, con);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    String[] row = new String[columns];
                    for (int i = 0; i < dataReader.FieldCount; i++)
                    {
                        row[i] = dataReader[i].ToString();
                    }
                    selectedTable.Add(row);
                }

                dataReader.Close();
                this.CloseConnection();
                return selectedTable;
            }
            else
            {
                return selectedTable;
            }
        }
        private bool OpenConnection()
        {
            try
            {
                con.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Cannot connect to server.  Contact administrator");
                        break;

                    case 1045:
                        MessageBox.Show("Invalid username/password, please try again");
                        break;
                }
                return false;
            }
        }
        private bool CloseConnection()
        {
            try
            {
                con.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
    }

    public class dal
    {
        private string connectionString = "SERVER=localhost; DATABASE=mediatek86; UID=root; PASSWORD=all0755;";
        public bool sendLogin(Responsable res)
        {
            List<string[]> responsablesList = Connection.conInstance.Select("responsable", 2);
            if (responsablesList[0][0] == res.username && responsablesList[0][1] == ComputeSha256Hash(res.password))
            {
                return true;
            }
            else
            {
                return false;
            }
        } 
        public void addPersonnel(Personnel pers)
        {
            Connection.conInstance.Insert("personnel", "(idpersonnel, nom, prenom, tel, mail, absences)", "('" + pers.idpersonnel.ToString() +"','"+ pers.nom + "','" + pers.prenom + "','" + pers.tel + "','" + pers.mail + "','" + pers.absences + "')");
        }
        public void modifyPersonnel(Personnel pers)
        {
            string table = "personnel";
            string attributes = "idpersonnel = '" + pers.idpersonnel.ToString() + "', nom = '" + pers.nom + "', prenom = '" + pers.prenom + "', tel = '" + pers.tel + "', mail = '" + pers.mail + "', absences = '" + pers.absences;
            string condition = "idpersonnel == '" + pers.idpersonnel.ToString() + "'";
            Connection.conInstance.Update(table, attributes, condition);
        }
        public void deletePersonnel(Personnel pers)
        {
            string table = "personnel";
            string condition = "idpersonnel == '" + pers.idpersonnel.ToString() + "'";
            Connection.conInstance.Delete(table, condition);

        }
        public List<string[]> showAbsences()
        {
            List<string[]> absencesList = Connection.conInstance.Select("absence", 3);
            return absencesList;
        }
        public void addAbsence(Absence abs)
        {
            Connection.conInstance.Insert("absence", "(datedebut, datefin, personneAbsente)", "('" + abs.datedebut + "','" + abs.datefin + "','" + abs.personneAbsente + "')");
        }
        public void modifyAbsence(Absence abs)
        {
            string table = "absence";
            string attributes = "datedebut = '" + abs.datedebut + "', datefin = '" + abs.datefin + "', personneAbsente = '" + abs.personneAbsente + "'";
            string condition = "datebut == '" + abs.datedebut + "'";
            Connection.conInstance.Update(table, attributes, condition);
        }
        public void deleteAbsence(Absence abs)
        {
            string table = "absence";
            string condition = "datedebut == '" + abs.datedebut + "'";
            Connection.conInstance.Delete(table, condition);
        }
        public string ComputeSha256Hash(string rawData)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }
    }

    public class Responsable
    {
        public string username;
        public string password;
        public Responsable(string login, string pwd)
        {
            username = login;
            password = pwd;
        }
    }

    public class Personnel
    {
        public int idpersonnel;
        public string nom;
        public string prenom;
        public string tel;
        public string mail;
        public string absences = null;
    }

    class service
    {
        private int idservice;
    }

    public class Absence
    {
        public string datedebut;
        public string datefin;
        public string personneAbsente;
    }

    class motif
    {
        private int idmotif;
        private string dateAbsence;
        private string libelle;
    }

}
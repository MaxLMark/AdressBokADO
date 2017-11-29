using AdressBok.DAL;
using AdressBok.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdressBok
{
    public partial class AdressBok : Form
    {
        public AdressBok()
        {
            InitializeComponent();
        }

        private void btnSkapaNyKontakt_Click(object sender, EventArgs e)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@Namn", txtNamn.Text),
                new SqlParameter("@Gatuadress", txtGatuAdress.Text),
                new SqlParameter("@Postnummer", txtPostnummer.Text),
                new SqlParameter("@Postort", txtPostOrt.Text),
                new SqlParameter("@Telefon", txtTelefon.Text),
                new SqlParameter("@Email", txtEmail.Text),
                new SqlParameter("@TypID", ((KontaktTyp) cbKontaktTyp.SelectedItem).TypID)

            };
            var command = @"INSERT INTO [Kontakt] (Namn,Gatuadress,Postnummer,Postort,Telefon,Email, TypID)
                            VALUES (@Namn, @Gatuadress, @Postnummer, @Postort, @Telefon, @Email, @TypID)";

            DataAccess dataAccess = new DataAccess();
            var result = dataAccess.ExecuteNonQuery(command, CommandType.Text, parameters);

            if (result == true)
            {
                LoadKontakter();
            }

        }

        private void AdressBok_Load(object sender, EventArgs e)
        {
            //Hämta data för griden
            LoadKontakter();
            var dataAccess = new DataAccess();
            var commandText = "select * from KontaktTyp";
            var kontaktTyper = dataAccess.ExecuteSelectCommand(commandText, CommandType.Text);

            cbKontaktTyp.Items.AddRange(GetKontaktTyper(kontaktTyper).ToArray());

        }

        private void LoadKontakter()
        {
            var dataAccess = new DataAccess();
            var commandText = @"select KontaktID, Email, Namn, Gatuadress, PostNummer, PostOrt, Telefon, Kontakt.TypID, TypNamn from Kontakt
                                INNER JOIN KontaktTyp ON KontaktTyp.TypID = Kontakt.TypID; ";

            DataSet kontakter = dataAccess.ExecuteSelectCommand(commandText, CommandType.Text);

            gwKontaktLista.DataSource = kontakter.Tables[0];
        }

        private List<KontaktTyp> GetKontaktTyper(DataSet dataSet)
        {
            var items = new List<KontaktTyp>();
            foreach (DataRow row in dataSet.Tables[0].Rows)
            {
                items.Add(new KontaktTyp
                {
                    TypID = row.Field<int>("TypId"),
                    TypNamn = row.Field<string>("TypNamn")
                });

            }
            return items;
        }

        private void gwKontaktLista_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.gwKontaktLista.Rows[e.RowIndex];

                txtNamn.Text = row.Cells["Namn"].Value.ToString();
                txtGatuAdress.Text = row.Cells["Gatuadress"].Value.ToString();
                txtPostnummer.Text = row.Cells["Postnummer"].Value.ToString();
                txtPostOrt.Text = row.Cells["Postort"].Value.ToString();
                txtTelefon.Text = row.Cells["Telefon"].Value.ToString();
                txtEmail.Text = row.Cells["Email"].Value.ToString();
                foreach (KontaktTyp item in cbKontaktTyp.Items)
                {
                    if (item.TypID == Convert.ToInt32(row.Cells["TypId"].Value))
                    {
                        cbKontaktTyp.SelectedItem = item;
                        break;
                    }
                }

            }
        }

        private void cbEditera_CheckedChanged(object sender, EventArgs e)
        {
            {
                txtEmail.Enabled = cbEditera.Checked;
                txtGatuAdress.Enabled = cbEditera.Checked;
                txtNamn.Enabled = cbEditera.Checked;
                txtPostnummer.Enabled = cbEditera.Checked;
                txtPostOrt.Enabled = cbEditera.Checked;
                txtTelefon.Enabled = cbEditera.Checked;
                cbKontaktTyp.Enabled = cbEditera.Checked;
                btnSpara.Enabled = cbEditera.Checked;

            }
        }

        private void btnRadera_Click(object sender, EventArgs e)
        {

            var selectedRow = gwKontaktLista.SelectedRows[0];

            if (selectedRow != null)
            {

                SqlParameter[] parameters = new SqlParameter[]
                {
                new SqlParameter("@KontaktID", selectedRow.Cells["KontaktID"].Value.ToString())
                };
                var command = @"DELETE from KONTAKT where KontaktID = @KontaktID";

                DataAccess dataAccess = new DataAccess();
                var result = dataAccess.ExecuteNonQuery(command, CommandType.Text, parameters);

                if (result == true)
                {
                    LoadKontakter();
                }
            }
        }

        private void btnSök_Click(object sender, EventArgs e)
        {
            string Name = txtSök.Text.ToString();
            string Postort = txtSök1.Text.ToString();
            string KontaktTyp = "";

            if (cbSökKontaktTyp.SelectedItem != null)
            {
                KontaktTyp = cbSökKontaktTyp.SelectedItem.ToString();
            }

            var command = @"SELECT * FROM Kontakt JOIN KontaktTyp ON Kontakt.TypID = KontaktTyp.TypID WHERE Namn LIKE '%" + Name + "%' AND postort LIKE '%" + Postort + "%' AND typnamn LIKE '%" + KontaktTyp + "%' ";

            DataAccess dataaccess = new DataAccess();
            DataSet sökresultat = dataaccess.ExecuteSelectCommand(command, CommandType.Text);

            gwKontaktLista.DataSource = sökresultat.Tables[0];

        }

        private void btnSpara_Click(object sender, EventArgs e)
        {

            var selectedRow = gwKontaktLista.SelectedRows[0];

            if (selectedRow != null)
            {

                SqlParameter[] parameters = new SqlParameter[]
                {
                new SqlParameter("@KontaktID", selectedRow.Cells["KontaktID"].Value.ToString())
                };
                var command = @"Update Kontakt SET Namn = '" + txtNamn.Text + "', Postnummer = '" + int.Parse(txtPostnummer.Text) + "', Postort = '" + txtPostOrt.Text + "', Telefon = '" + txtTelefon.Text + "', Email = '" + txtEmail.Text + "' WHERE  KontaktID = @KontaktID";

                DataAccess dataAccess = new DataAccess();
                var result = dataAccess.ExecuteNonQuery(command, CommandType.Text, parameters);
                if (result)
                {
                    MessageBox.Show("Sparat ny info");
                    LoadKontakter();
                }
            }

        }

    }
}

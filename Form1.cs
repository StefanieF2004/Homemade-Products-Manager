using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Security.Cryptography;


namespace DomasniProizvodi1
{
    public partial class Form1 : Form
    {
        //za konekcijata
        string connString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Media\Desktop\faks\VTORA\cetvrt semestar\bazi na podatoci\DomasniProizvodi1.accdb;";
        OleDbConnection conn;

        public Form1()
        {
            InitializeComponent();
            conn = new OleDbConnection(connString);
            LoadKlienti();
            LoadProizvodi();
            LoadNaracki();
        }

        //ZA VCITUVANJE NA PODATOCI VO TABELA
        private void LoadKlienti()
        {
            try
            {
                conn.Open();
                string query = "SELECT ID, Ime, Prezime, Telefon, Email, Adresa FROM Klienti";
                OleDbDataAdapter adapter = new OleDbDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvKlienti.DataSource = dt;

                dgvKlienti.Columns["ID"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Грешка: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        //PRI KLIK NA KELIJA OD TABELATA
        private void dgvKlienti_CellContentClick(object sender, DataGridViewCellEventArgs e)

        {
            //MessageBox.Show("Кликнат е ред: " + e.RowIndex.ToString());

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvKlienti.Rows[e.RowIndex];//se zema selektiraniot red

                txtIme.Text = row.Cells["Ime"].Value?.ToString() ?? "";//proveruva dali e null vrednost
                txtPrezime.Text = row.Cells["Prezime"].Value?.ToString() ?? "";
                txtTelefon.Text = row.Cells["Telefon"].Value?.ToString() ?? "";
                txtEmail.Text = row.Cells["Email"].Value?.ToString() ?? "";
                txtAdresa.Text = row.Cells["Adresa"].Value?.ToString() ?? "";
            }
        }


        //ZA DODAVANJE NA KLIENT
        private void btnDodadiKlient_Click_1(object sender, EventArgs e)
        {
            // 1.Validacija
            if (string.IsNullOrWhiteSpace(txtIme.Text) ||
                string.IsNullOrWhiteSpace(txtPrezime.Text))
            {
                MessageBox.Show("Име и Презиме се задолжителни полиња.");
                return;
            }

            // 2.Podgotovka na podatoci
            string ime = txtIme.Text.Trim();
            string prezime = txtPrezime.Text.Trim();
            string telefon = txtTelefon.Text.Trim();
            string email = txtEmail.Text.Trim();
            string adresa = txtAdresa.Text.Trim();

            // 3. SQL со '?' placeholder
            string sql = "INSERT INTO Klienti (Ime, Prezime, Telefon, Email, Adresa) VALUES (?, ?, ?, ?, ?)";

            try
            {
                using (OleDbConnection cn = new OleDbConnection(connString))
                using (OleDbCommand cmd = new OleDbCommand(sql, cn))
                {
                    // 4. mora zapazen redosled
                    cmd.Parameters.AddWithValue("?", ime);
                    cmd.Parameters.AddWithValue("?", prezime);
                    cmd.Parameters.AddWithValue("?", telefon);
                    cmd.Parameters.AddWithValue("?", email);
                    cmd.Parameters.AddWithValue("?", adresa);

                    cn.Open();
                    int rows = cmd.ExecuteNonQuery();
                    MessageBox.Show(rows > 0 ? "Клиентот е успешно додаден." : "Не беше додаден клиент.");
                }

                // 5.azuriranje na UI
                LoadKlienti();
                ClearKlientInputFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Грешка при додавање клиент: " + ex.Message);
            }
        }

        // CISTENJE NA POLETO
        private void ClearKlientInputFields()
        {
            txtIme.Clear();
            txtPrezime.Clear();
            txtTelefon.Clear();
            txtEmail.Clear();
            txtAdresa.Clear();
        }

        //BRISENJE NA KLIENT
        private void btnIzbrisiKlient_Click(object sender, EventArgs e)
        {

            // Проверка дали има селектиран ред
            if (dgvKlienti.CurrentRow == null)
            {
                MessageBox.Show("Изберете клиент за бришење.");
                return;
            }

            // Zemanje na id od selektiraniot klient
            int id;
            try
            {
                id = Convert.ToInt32(dgvKlienti.CurrentRow.Cells["ID"].Value);//zema id celija
            }
            catch
            {
                MessageBox.Show("Не може да се добие ID од селектираниот клиент.");
                return;
            }

            //Potvrda za brisenje
            DialogResult dr = MessageBox.Show("Дали сте сигурни дека сакате да го избришете клиентот?",
                                              "Потврда",
                                              MessageBoxButtons.YesNo,
                                              MessageBoxIcon.Warning);
            if (dr != DialogResult.Yes)
                return;

            // Бришење од базата
            try
            {
                using (OleDbConnection cn = new OleDbConnection(connString))
                {
                    string query = "DELETE FROM Klienti WHERE ID = ?";
                    using (OleDbCommand cmd = new OleDbCommand(query, cn))
                    {
                        cmd.Parameters.AddWithValue("?", id);
                        cn.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                            MessageBox.Show("Клиентот е избришан успешно.");
                        else
                            MessageBox.Show("Не е избришан ниту еден запис.");
                    }
                }

                // Освежи ја табелата во DataGridView
                LoadKlienti();
                ClearKlientInputFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Грешка при бришење: " + ex.Message);
            }
        }


        //IZMENUVANJE NA KLIENT
        private void btnIzmeniKlient_Click_1(object sender, EventArgs e)
        {

            if (dgvKlienti.CurrentRow == null) return;

            var row = dgvKlienti.CurrentRow;
            int id = Convert.ToInt32(row.Cells["ID"].Value);

            // Проверка на валидност
            if (string.IsNullOrWhiteSpace(txtIme.Text) || string.IsNullOrWhiteSpace(txtPrezime.Text))
            {
                MessageBox.Show("Име и Презиме се задолжителни полиња.");
                return;
            }

            try
            {
                using (OleDbConnection cn = new OleDbConnection(connString))
                using (OleDbCommand cmd = new OleDbCommand(
                    "UPDATE Klienti SET Ime=?, Prezime=?, Telefon=?, Email=?, Adresa=? WHERE ID=?", cn))
                {
                    cmd.Parameters.AddWithValue("?", txtIme.Text.Trim());
                    cmd.Parameters.AddWithValue("?", txtPrezime.Text.Trim());
                    cmd.Parameters.AddWithValue("?", txtTelefon.Text.Trim());
                    cmd.Parameters.AddWithValue("?", txtEmail.Text.Trim());
                    cmd.Parameters.AddWithValue("?", txtAdresa.Text.Trim());
                    cmd.Parameters.AddWithValue("?", id);

                    cn.Open();
                    int rows = cmd.ExecuteNonQuery();// akcija vrz bazata
                    MessageBox.Show(rows > 0 ? "Клиентот е успешно изменет." : "Не е најден клиент со тоа ID.");
                }

                LoadKlienti();
                ClearKlientInputFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Грешка при измена на клиент: " + ex.Message);
            }
        }











        //ZA PROIZVODI
        //pri klik
        private void dgvProizvodi_CellContentClick(object sender, DataGridViewCellEventArgs e)

        {
            if (e.RowIndex < 0) return;
            var r = dgvProizvodi.Rows[e.RowIndex];

            txtImeProizvod.Text = r.Cells["Ime"].Value?.ToString();//ne nulti->vo string
            txtCena.Text = r.Cells["Cena"].Value?.ToString();
            txtSoSostojki.Text = r.Cells["SoSostojki"].Value?.ToString();
        }


        //vcituvanje od tabela proizvodi
        private DataTable dtProizvodi;
        private void LoadProizvodi()
        {
            conn.Open();
            dtProizvodi = new DataTable();
            new OleDbDataAdapter("SELECT * FROM Proizvodi", conn).Fill(dtProizvodi);
            conn.Close();
            dgvProizvodi.DataSource = dtProizvodi;
        }




        //ZA ISPISUVANJE NA SOSTAV
        private void btnOpis_Click(object sender, EventArgs e)
        {
            string imeProizvod = txtImeProizvod.Text.Trim();

            if (string.IsNullOrEmpty(imeProizvod))
            {
                MessageBox.Show("Внеси име на производ!");
                return;
            }

            try
            {
                using (OleDbConnection cn = new OleDbConnection(connString))
                {
                    string query = "SELECT SoSostojki, Cena FROM Proizvodi WHERE Ime = ?";
                    using (OleDbCommand cmd = new OleDbCommand(query, cn))
                    {
                        cmd.Parameters.AddWithValue("?", imeProizvod);
                        cn.Open();

                        using (OleDbDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())  // ако има ред
                            {
                                txtSoSostojki.Text = reader["SoSostojki"].ToString();
                                txtCena.Text = reader["Cena"].ToString();
                            }
                            else
                            {
                                MessageBox.Show("Не е пронајден производ со тоа име.");
                                txtSoSostojki.Clear();
                                txtCena.Clear();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Грешка при читање на податоците: " + ex.Message);
            }
        }







        //ZA NARACKI


        private void LoadNaracki()
        {
            OleDbConnection conn = new OleDbConnection(connString);
            try
            {
                conn.Open();
                OleDbDataAdapter adapter = new OleDbDataAdapter("SELECT * FROM Naracki", conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvNaracki.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Грешка: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }

        }

        private void btnCena_Click(object sender, EventArgs e)
        {
            DateTime izbranaData = dtDatum.Value.Date;

            try
            {
                using (OleDbConnection cn = new OleDbConnection(connString))
                {
                    string query = "SELECT SUM(VkupnaSuma) FROM Naracki WHERE Datum = ?";
                    using (OleDbCommand cmd = new OleDbCommand(query, cn))
                    {
                        cmd.Parameters.AddWithValue("?", izbranaData);

                        cn.Open();
                        object result = cmd.ExecuteScalar();

                        if (result != null && result != DBNull.Value)
                        {
                            txtVkupnaCena.Text = Convert.ToDecimal(result).ToString("C");
                        }
                        else
                        {
                            txtVkupnaCena.Text = "";
                            MessageBox.Show("Нема нарачки за внесениот датум.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Грешка при повлекување на сумата: " + ex.Message);
            }
        }

        private void btnProsecnaCena_Click(object sender, EventArgs e)
        {
            DateTime izbranaData = dtDatum.Value.Date;
            OleDbConnection cn = new OleDbConnection(connString);
            OleDbCommand cmd = null;

            try
            {
                string query = "SELECT AVG(VkupnaSuma) FROM Naracki WHERE Datum = ?";
                cmd = new OleDbCommand(query, cn);
                cmd.Parameters.AddWithValue("?", izbranaData);

                cn.Open();
                object result = cmd.ExecuteScalar();

                if (result != null && result != DBNull.Value)
                {
                    decimal avgCena = Convert.ToDecimal(result);
                    txtVkupnaCena.Text = avgCena.ToString("C"); // ja prikazuva
                }
                else
                {
                    txtVkupnaCena.Text = "";
                    MessageBox.Show("Нема нарачки за внесениот датум.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Грешка при пресметка на просечна цена: " + ex.Message);
            }
            finally
            {
                if (cmd != null)
                    cmd.Dispose();
                if (cn.State == ConnectionState.Open)
                    cn.Close();
                cn.Dispose();
            }
        }

        private void PrikaziKupuvaci_Click(object sender, EventArgs e)
        {
            DateTime izbranaData = dtDatum.Value.Date;

            OleDbConnection cn = new OleDbConnection(connString);
            OleDbCommand cmd = null;
            OleDbDataReader reader = null;

            try
            {
                string query = @"
            SELECT DISTINCT K.Ime, K.Prezime
            FROM Naracki N
            INNER JOIN Klienti K ON N.KlientID = K.ID
            WHERE N.Datum = ?
        ";

                cmd = new OleDbCommand(query, cn);
                cmd.Parameters.AddWithValue("?", izbranaData);

                cn.Open();
                reader = cmd.ExecuteReader();

                List<string> kupuvaci = new List<string>();
                while (reader.Read())
                {
                    kupuvaci.Add(reader["Ime"].ToString());
                    kupuvaci.Add(reader["Prezime"].ToString());
                }

                if (kupuvaci.Count > 0)
                {
                    txtKupuvaci.Text = string.Join("  ", kupuvaci);
                }
                else
                {
                    txtKupuvaci.Text = "";
                    MessageBox.Show("Нема купувачи за тој датум.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Грешка: " + ex.Message);
            }
            finally
            {
                if (reader != null)
                    reader.Close();
                if (cmd != null)
                    cmd.Dispose();
                if (cn.State == ConnectionState.Open)
                    cn.Close();
                cn.Dispose();
            }
        }

      
    }
}

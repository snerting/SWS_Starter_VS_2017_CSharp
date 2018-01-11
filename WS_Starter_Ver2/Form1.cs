using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WS_Starter_Ver2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        private void btnGetData_Click(object sender, EventArgs e)
        {
            btnGetData.Enabled = false;
            this.Cursor = Cursors.WaitCursor;

            try
            {
                var brukerAutoriasasjon = new WS_Foretak.BrukerAutorisasjon
                {
                    BrukerID = txtUsername.Text,
                    Passord = txtPassword.Text
                };

                var foretak = new WS_Foretak.Foretak {BrukerAutorisasjonValue = brukerAutoriasasjon};
                var fs = new WS_Foretak.ForetakSok {Navn = txtCompanyName.Text};
                var fsResponse = foretak.sokForetak(fs);

                if (fsResponse.ForetakData != null)
                {
                    dgvResponse.DataSource = fsResponse.ForetakData;
                }

                var sbMessageSummary = new StringBuilder();
                if (fsResponse.Meldinger != null)
                {
                    var i = 1;
                    foreach (var message in fsResponse.Meldinger)
                    {
                        sbMessageSummary.AppendLine(
                            $"Message nr {i++}: {message.MeldingsKode} {message.MeldingsTekst} ");
                    }
                }

                this.Cursor = Cursors.Default;

                if (sbMessageSummary.Length > 1)
                {
                    MessageBox.Show(sbMessageSummary.ToString());
                }
            }
            catch (Exception ex)
            {
                this.Cursor = Cursors.Default;
                MessageBox.Show($"Errormessage: {ex.Message}");
            }
            finally
            {
                btnGetData.Enabled = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnGetReellerettighetshavere_Click(object sender, EventArgs e)
        {
            btnGetReellerettighetshavere.Enabled = false;
            this.Cursor = Cursors.WaitCursor;

            try
            {
                var brukerAutoriasasjon = new WS_Foretak.BrukerAutorisasjon
                {
                    BrukerID = txtUsername.Text,
                    Passord = txtPassword.Text
                };

                var foretak = new WS_Foretak.Foretak {BrukerAutorisasjonValue = brukerAutoriasasjon};
                var hf = new WS_Foretak.HentForetak
                {
                    Orgnr = int.Parse(textBoxOrgnrReellerettighetshavere.Text),
                    ReelleRettighetshavere = true
                };

                var hfResponse = foretak.hentForetakinfo(hf);

                if (hfResponse.Rettighetshavere != null)
                {
                    dgvReellerettighetshavere.DataSource = hfResponse.Rettighetshavere;
                }

                var sbMessageSummary = new StringBuilder();

                if (hfResponse.Meldinger != null)
                {
                    var i = 1;
                    foreach (var message in hfResponse.Meldinger)
                    {
                        sbMessageSummary.AppendLine(
                            $"Message nr {i++}: {message.MeldingsKode} {message.MeldingsTekst} ");
                    }
                }

                this.Cursor = Cursors.Default;

                if (sbMessageSummary.Length > 1)
                {
                    MessageBox.Show(sbMessageSummary.ToString());
                }
            }
            catch (Exception ex)
            {
                this.Cursor = Cursors.Default;
                MessageBox.Show($"Errormessage: {ex.Message}");
            }
            finally
            {
                btnGetReellerettighetshavere.Enabled = true;
            }
        }

        private void btnPersonSearch_Click(object sender, EventArgs e)
        {
            btnPersonSearch.Enabled = false;
            this.Cursor = Cursors.WaitCursor;

            try
            {
                var brukerAutorisasjonPerson = new WS_Personinfo.BrukerAutorisasjon()
                {
                    BrukerID = txtUsername.Text,
                    Passord = txtPassword.Text
                };

                var person = new WS_Personinfo.Person() {BrukerAutorisasjonValue = brukerAutorisasjonPerson};

                var hp = new WS_Personinfo.PersonSok();


                hp.Fodselsdato = dtpBornDate.Value;


                if (!string.IsNullOrEmpty(tbFirstName.Text))
                {
                    hp.Fornavn = tbFirstName.Text;
                }

                if (!string.IsNullOrEmpty(tbLastName.Text))
                {
                    hp.Etternavn = tbLastName.Text;
                }

                var psResponse = person.sokPerson(hp);


                if (psResponse.Personalia != null)
                {
                    dgvPersonSearch.DataSource = psResponse.Personalia;
                }

                var sbMessageSummary = new StringBuilder();

                if (psResponse.Meldinger != null)
                {
                    var i = 1;
                    foreach (var message in psResponse.Meldinger)
                    {
                        sbMessageSummary.AppendLine(
                            $"Message nr {i++}: {message.MeldingsKode} {message.MeldingsTekst} ");
                    }
                }

                this.Cursor = Cursors.Default;

                if (sbMessageSummary.Length > 1)
                {
                    MessageBox.Show(sbMessageSummary.ToString());
                }
            }
            catch (Exception ex)
            {
                this.Cursor = Cursors.Default;
                MessageBox.Show($"Errormessage: {ex.Message}");
            }
            finally
            {
                btnPersonSearch.Enabled = true;
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}

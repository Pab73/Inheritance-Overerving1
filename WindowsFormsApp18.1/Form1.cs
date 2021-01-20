using System;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApp18._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Rekening rek = new Rekening("789-85296374-785", 0);
        Spaarrekening spaarRek = new Spaarrekening();
        Zichtrekening zichtRek = new Zichtrekening("456-456456-45", 0);
        private void Form1_Load(object sender, EventArgs e)
        {
            spaarRek.Rekeningnr = "123-45689324-654";
            spaarRek.Saldo = 0;
            spaarRek.Percentage = 5;
            UitSchrijven();
        }
        void PuntNaarKomma()
        {
            txtRek.Text = txtRek.Text.Replace('.', ',');
            txtSpaarRek.Text = txtSpaarRek.Text.Replace('.', ',');
            txtZichtRek.Text = txtZichtRek.Text.Replace('.', ',');
        }
        public double GetalDoubleCheck(string ingave)
        {
            double eenBedrag;
            if (!double.TryParse(ingave, out eenBedrag))
            {
                MessageBox.Show("Gelieve een bedrag in te geven. ", "Mededeling. ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return eenBedrag;
        }
        void UitSchrijven()
        {
            labelRekeningSaldo.Text = rek.ToString();
            labelSpaarRekeningSaldoRente.Text = spaarRek.ToString();
            labelZichtRekeningSaldo.Text = zichtRek.ToString();
            txtRek.Text = "";
            txtSpaarRek.Text = "";
            txtZichtRek.Text = "";
        }
        private void btnRekPlus_Click(object sender, EventArgs e)
        {
            PuntNaarKomma();
            rek.Storten(GetalDoubleCheck(txtRek.Text));
            UitSchrijven();
        }
        private void btnSRekPlus_Click(object sender, EventArgs e)
        {
            PuntNaarKomma();
            spaarRek.Storten(GetalDoubleCheck(txtSpaarRek.Text));
            UitSchrijven();
        }
        private void btnRente_Click(object sender, EventArgs e)
        {
            spaarRek.SchrijfRenteBij();
            UitSchrijven();
        }
        private void btnZichtRekPlus_Click(object sender, EventArgs e)
        {
            PuntNaarKomma();
            zichtRek.Storten(GetalDoubleCheck(txtZichtRek.Text));
            UitSchrijven();
        }
        private void btnRekMin_Click(object sender, EventArgs e)
        {
            PuntNaarKomma();
            rek.Afhalen(GetalDoubleCheck(txtRek.Text));
            UitSchrijven();
        }
        private void btnSRekMin_Click(object sender, EventArgs e)
        {
            PuntNaarKomma();
            spaarRek.Afhalen(GetalDoubleCheck(txtSpaarRek.Text));
            UitSchrijven();
        }
        private void btnZichtRekMin_Click(object sender, EventArgs e)
        {
            PuntNaarKomma();
            zichtRek.Afhalen(GetalDoubleCheck(txtZichtRek.Text));
            UitSchrijven();
        }
    }
}

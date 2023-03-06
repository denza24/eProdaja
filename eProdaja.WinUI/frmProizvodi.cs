using eProdaja.Models;

namespace eProdaja.WinUI
{
    public partial class frmProizvodi : Form
    {
        public APIService ProizvodiService { get; set; } = new APIService("Proizvodi");
        public frmProizvodi()
        {
            InitializeComponent();
        }

        private async void frmProizvodi_Load(object sender, EventArgs e)
        {
            var data = await ProizvodiService.Get<List<ProizvodiDto>>();

            dgvProizvodi.DataSource = data;
        }
    }
}

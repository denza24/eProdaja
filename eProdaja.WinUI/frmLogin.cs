namespace eProdaja.WinUI
{
    public partial class frmLogin : Form
    {
        public APIService APIService { get; set; } = new APIService("account");

        public frmLogin()
        {
            InitializeComponent();
        }


        private async void btnLogin_Click(object sender, EventArgs e)
        {
            var korisnickoIme = txtKorisnickoIme.Text;
            var password = txtPassword.Text;

            var user = await APIService.Login(korisnickoIme, password);
            if (user == null) return;

            this.DialogResult = DialogResult.OK;
        }
    }
}

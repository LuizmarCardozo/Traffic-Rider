using System;
using System.Windows.Forms;
using Microsoft.Web.WebView2.WinForms;

namespace Traffic_Rider
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load; // Garante que o evento `Load` está vinculado corretamente

            // Define o modo tela cheia ao abrir
            this.FormBorderStyle = FormBorderStyle.None; // Remove bordas
            this.WindowState = FormWindowState.Maximized; // Maximiza a janela
            this.KeyPreview = true; // Permite capturar teclas no formulário
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            await InicializarWebView();
            this.ActiveControl = null; // Remove o foco inicial do WebView2
            this.Focus(); // Foca no próprio formulário
        }

        private async System.Threading.Tasks.Task InicializarWebView()
        {
            try
            {
                await webView21.EnsureCoreWebView2Async();
                webView21.Source = new Uri("https://www.crazygames.com.br/embed/traffic-rider-vvq"); // Apenas o jogo, sem o site
                webView21.Dock = DockStyle.Fill; // Garante que o WebView2 ocupe toda a tela
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar o WebView2: " + ex.Message);
            }
        }

        // Permite que o jogo seja fechado ao pressionar "Esc"
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                FecharJogo(); // Chama o método para encerrar a aplicação
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        // Método para encerrar corretamente o processo da aplicação
        private void FecharJogo()
        {
            this.Close(); // Fecha a janela principal
            Application.Exit(); // Encerra completamente o aplicativo
            Environment.Exit(0); // Mata qualquer processo residual
        }
    }
}
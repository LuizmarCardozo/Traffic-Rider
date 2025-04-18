namespace Traffic_Rider
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView21;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
            ((System.ComponentModel.ISupportInitialize)webView21).BeginInit();
            SuspendLayout();

            // Configuração do WebView2
            webView21.AllowExternalDrop = true;
            webView21.CreationProperties = null;
            webView21.DefaultBackgroundColor = Color.White;
            webView21.Dock = DockStyle.Fill; // Ajuste para preencher a tela
            webView21.Name = "webView21";
            webView21.TabIndex = 0;
            webView21.ZoomFactor = 1D;

            // Configuração do Form1
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(webView21);
            Name = "Form1";
            Text = "Traffic Rider";
            Load += Form1_Load; // Garante que o evento de carregamento está vinculado

            ((System.ComponentModel.ISupportInitialize)webView21).EndInit();
            ResumeLayout(false);
        }

        #endregion
    }
}
namespace WinFormsApp7
{
    partial class Form1
    {
        private System.Windows.Forms.TextBox txtRate;
        private System.Windows.Forms.TextBox txtEuros;
        private System.Windows.Forms.TextBox txtDollars;
        private System.Windows.Forms.Button btnToDollars;
        private System.Windows.Forms.Button btnToEuros;
        private System.Windows.Forms.Label lblDollars;
        private System.Windows.Forms.Label lblEuros;

        private void InitializeComponent()
        {
            this.txtRate = new System.Windows.Forms.TextBox();
            this.txtEuros = new System.Windows.Forms.TextBox();
            this.txtDollars = new System.Windows.Forms.TextBox();
            this.btnToDollars = new System.Windows.Forms.Button();
            this.btnToEuros = new System.Windows.Forms.Button();
            this.lblDollars = new System.Windows.Forms.Label();
            this.lblEuros = new System.Windows.Forms.Label();
            this.SuspendLayout();

            // txtRate
            this.txtRate.Location = new System.Drawing.Point(12, 12);
            this.txtRate.Name = "txtRate";
            this.txtRate.Size = new System.Drawing.Size(100, 20);
            this.txtRate.TabIndex = 0;
            this.txtRate.Text = "Enter EUR/USD Rate";

            // txtEuros
            this.txtEuros.Location = new System.Drawing.Point(12, 38);
            this.txtEuros.Name = "txtEuros";
            this.txtEuros.Size = new System.Drawing.Size(100, 20);
            this.txtEuros.TabIndex = 1;
            this.txtEuros.Text = "Enter Euros";

            // txtDollars
            this.txtDollars.Location = new System.Drawing.Point(12, 64);
            this.txtDollars.Name = "txtDollars";
            this.txtDollars.Size = new System.Drawing.Size(100, 20);
            this.txtDollars.TabIndex = 2;
            this.txtDollars.Text = "Enter Dollars";

            // btnToDollars
            this.btnToDollars.Location = new System.Drawing.Point(118, 36);
            this.btnToDollars.Name = "btnToDollars";
            this.btnToDollars.Size = new System.Drawing.Size(75, 23);
            this.btnToDollars.TabIndex = 3;
            this.btnToDollars.Text = "To Dollars";
            this.btnToDollars.UseVisualStyleBackColor = true;
            this.btnToDollars.Click += new System.EventHandler(this.btnToDollars_Click);

            // btnToEuros
            this.btnToEuros.Location = new System.Drawing.Point(118, 62);
            this.btnToEuros.Name = "btnToEuros";
            this.btnToEuros.Size = new System.Drawing.Size(75, 23);
            this.btnToEuros.TabIndex = 4;
            this.btnToEuros.Text = "To Euros";
            this.btnToEuros.UseVisualStyleBackColor = true;
            this.btnToEuros.Click += new System.EventHandler(this.btnToEuros_Click);

            // lblDollars
            this.lblDollars.Location = new System.Drawing.Point(12, 90);
            this.lblDollars.Name = "lblDollars";
            this.lblDollars.Size = new System.Drawing.Size(200, 23);
            this.lblDollars.TabIndex = 5;

            // lblEuros
            this.lblEuros.Location = new System.Drawing.Point(12, 113);
            this.lblEuros.Name = "lblEuros";
            this.lblEuros.Size = new System.Drawing.Size(200, 23);
            this.lblEuros.TabIndex = 6;

            // Form1
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lblEuros);
            this.Controls.Add(this.lblDollars);
            this.Controls.Add(this.btnToEuros);
            this.Controls.Add(this.btnToDollars);
            this.Controls.Add(this.txtDollars);
            this.Controls.Add(this.txtEuros);
            this.Controls.Add(this.txtRate);
            this.Name = "Form1";
            this.Text = "Currency Converter";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }

}

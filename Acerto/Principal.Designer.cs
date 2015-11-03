namespace Acerto
{
    partial class Principal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btPesquisa = new System.Windows.Forms.Button();
            this.divTopo = new System.Windows.Forms.FlowLayoutPanel();
            this.lblConexao = new System.Windows.Forms.Label();
            this.lblnaoproc = new System.Windows.Forms.Label();
            this.tabelaNProc = new System.Windows.Forms.DataGridView();
            this.topo = new System.Windows.Forms.FlowLayoutPanel();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.panelPesquisa = new System.Windows.Forms.Panel();
            this.pesquisar = new System.Windows.Forms.NumericUpDown();
            this.lblFilial = new System.Windows.Forms.Label();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.panelExecutar = new System.Windows.Forms.Panel();
            this.panelResults = new System.Windows.Forms.FlowLayoutPanel();
            this.estatisticas = new System.Windows.Forms.Label();
            this.btCorrigir = new System.Windows.Forms.Button();
            this.grpCondi = new System.Windows.Forms.Panel();
            this.chkTrans = new System.Windows.Forms.CheckBox();
            this.chkVendas = new System.Windows.Forms.CheckBox();
            this.condLabel = new System.Windows.Forms.Label();
            this.painelPesquisa = new System.Windows.Forms.TextBox();
            this.divdir = new System.Windows.Forms.FlowLayoutPanel();
            this.lblResults = new System.Windows.Forms.Label();
            this.txtProcessos = new System.Windows.Forms.TextBox();
            this.divesq = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaNProc)).BeginInit();
            this.topo.SuspendLayout();
            this.panelPesquisa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pesquisar)).BeginInit();
            this.panelExecutar.SuspendLayout();
            this.panelResults.SuspendLayout();
            this.grpCondi.SuspendLayout();
            this.divdir.SuspendLayout();
            this.divesq.SuspendLayout();
            this.SuspendLayout();
            // 
            // btPesquisa
            // 
            this.btPesquisa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btPesquisa.Location = new System.Drawing.Point(343, 0);
            this.btPesquisa.Name = "btPesquisa";
            this.btPesquisa.Size = new System.Drawing.Size(106, 29);
            this.btPesquisa.TabIndex = 1;
            this.btPesquisa.Text = "Pesquisar";
            this.btPesquisa.UseVisualStyleBackColor = true;
            this.btPesquisa.Click += new System.EventHandler(this.btPesquisa_Click);
            // 
            // divTopo
            // 
            this.divTopo.AutoSize = true;
            this.divTopo.Dock = System.Windows.Forms.DockStyle.Top;
            this.divTopo.Location = new System.Drawing.Point(0, 0);
            this.divTopo.Name = "divTopo";
            this.divTopo.Size = new System.Drawing.Size(1454, 0);
            this.divTopo.TabIndex = 1;
            // 
            // lblConexao
            // 
            this.lblConexao.AutoSize = true;
            this.lblConexao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblConexao.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblConexao.Location = new System.Drawing.Point(8, 5);
            this.lblConexao.Name = "lblConexao";
            this.lblConexao.Size = new System.Drawing.Size(125, 37);
            this.lblConexao.TabIndex = 0;
            this.lblConexao.Text = "Desconectado";
            this.lblConexao.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblnaoproc
            // 
            this.lblnaoproc.AutoSize = true;
            this.lblnaoproc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblnaoproc.Location = new System.Drawing.Point(8, 10);
            this.lblnaoproc.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.lblnaoproc.Name = "lblnaoproc";
            this.lblnaoproc.Size = new System.Drawing.Size(140, 17);
            this.lblnaoproc.TabIndex = 0;
            this.lblnaoproc.Text = "Não Processadas:";
            // 
            // tabelaNProc
            // 
            this.tabelaNProc.AllowUserToAddRows = false;
            this.tabelaNProc.AllowUserToDeleteRows = false;
            this.tabelaNProc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tabelaNProc.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.tabelaNProc.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.tabelaNProc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabelaNProc.Location = new System.Drawing.Point(8, 32);
            this.tabelaNProc.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.tabelaNProc.MinimumSize = new System.Drawing.Size(0, 300);
            this.tabelaNProc.Name = "tabelaNProc";
            this.tabelaNProc.ReadOnly = true;
            this.tabelaNProc.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tabelaNProc.Size = new System.Drawing.Size(847, 555);
            this.tabelaNProc.TabIndex = 5;
            // 
            // topo
            // 
            this.topo.AutoSize = true;
            this.topo.Controls.Add(this.lblConexao);
            this.topo.Controls.Add(this.splitter1);
            this.topo.Controls.Add(this.panelPesquisa);
            this.topo.Controls.Add(this.splitter2);
            this.topo.Controls.Add(this.panelExecutar);
            this.topo.Dock = System.Windows.Forms.DockStyle.Top;
            this.topo.Location = new System.Drawing.Point(0, 0);
            this.topo.Name = "topo";
            this.topo.Padding = new System.Windows.Forms.Padding(5);
            this.topo.Size = new System.Drawing.Size(1454, 47);
            this.topo.TabIndex = 4;
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.splitter1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitter1.Location = new System.Drawing.Point(139, 8);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(1, 31);
            this.splitter1.TabIndex = 3;
            this.splitter1.TabStop = false;
            // 
            // panelPesquisa
            // 
            this.panelPesquisa.Controls.Add(this.pesquisar);
            this.panelPesquisa.Controls.Add(this.lblFilial);
            this.panelPesquisa.Controls.Add(this.btPesquisa);
            this.panelPesquisa.Location = new System.Drawing.Point(146, 8);
            this.panelPesquisa.Name = "panelPesquisa";
            this.panelPesquisa.Size = new System.Drawing.Size(449, 31);
            this.panelPesquisa.TabIndex = 5;
            // 
            // pesquisar
            // 
            this.pesquisar.Location = new System.Drawing.Point(56, 5);
            this.pesquisar.Maximum = new decimal(new int[] {
            61,
            0,
            0,
            0});
            this.pesquisar.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.pesquisar.Name = "pesquisar";
            this.pesquisar.Size = new System.Drawing.Size(281, 20);
            this.pesquisar.TabIndex = 5;
            this.pesquisar.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblFilial
            // 
            this.lblFilial.AutoSize = true;
            this.lblFilial.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblFilial.Location = new System.Drawing.Point(3, 6);
            this.lblFilial.Name = "lblFilial";
            this.lblFilial.Size = new System.Drawing.Size(47, 17);
            this.lblFilial.TabIndex = 3;
            this.lblFilial.Text = "Filial:";
            // 
            // splitter2
            // 
            this.splitter2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.splitter2.Location = new System.Drawing.Point(601, 8);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(1, 31);
            this.splitter2.TabIndex = 6;
            this.splitter2.TabStop = false;
            // 
            // panelExecutar
            // 
            this.panelExecutar.Controls.Add(this.panelResults);
            this.panelExecutar.Controls.Add(this.btCorrigir);
            this.panelExecutar.Controls.Add(this.grpCondi);
            this.panelExecutar.Location = new System.Drawing.Point(608, 8);
            this.panelExecutar.Name = "panelExecutar";
            this.panelExecutar.Size = new System.Drawing.Size(834, 31);
            this.panelExecutar.TabIndex = 7;
            // 
            // panelResults
            // 
            this.panelResults.Controls.Add(this.estatisticas);
            this.panelResults.Location = new System.Drawing.Point(378, 1);
            this.panelResults.Name = "panelResults";
            this.panelResults.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.panelResults.Size = new System.Drawing.Size(402, 29);
            this.panelResults.TabIndex = 3;
            // 
            // estatisticas
            // 
            this.estatisticas.AutoSize = true;
            this.estatisticas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.estatisticas.Location = new System.Drawing.Point(3, 5);
            this.estatisticas.Name = "estatisticas";
            this.estatisticas.Size = new System.Drawing.Size(94, 17);
            this.estatisticas.TabIndex = 0;
            this.estatisticas.Text = "Processados:";
            this.estatisticas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btCorrigir
            // 
            this.btCorrigir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btCorrigir.Location = new System.Drawing.Point(266, 1);
            this.btCorrigir.Name = "btCorrigir";
            this.btCorrigir.Size = new System.Drawing.Size(106, 29);
            this.btCorrigir.TabIndex = 2;
            this.btCorrigir.Text = "Corrigir";
            this.btCorrigir.UseVisualStyleBackColor = true;
            // 
            // grpCondi
            // 
            this.grpCondi.Controls.Add(this.chkTrans);
            this.grpCondi.Controls.Add(this.chkVendas);
            this.grpCondi.Controls.Add(this.condLabel);
            this.grpCondi.Location = new System.Drawing.Point(3, 0);
            this.grpCondi.Name = "grpCondi";
            this.grpCondi.Size = new System.Drawing.Size(369, 31);
            this.grpCondi.TabIndex = 0;
            // 
            // chkTrans
            // 
            this.chkTrans.AutoSize = true;
            this.chkTrans.Location = new System.Drawing.Point(144, 8);
            this.chkTrans.Name = "chkTrans";
            this.chkTrans.Size = new System.Drawing.Size(96, 17);
            this.chkTrans.TabIndex = 6;
            this.chkTrans.Text = "Transferências";
            this.chkTrans.UseVisualStyleBackColor = true;
            // 
            // chkVendas
            // 
            this.chkVendas.AutoSize = true;
            this.chkVendas.Location = new System.Drawing.Point(76, 7);
            this.chkVendas.Name = "chkVendas";
            this.chkVendas.Size = new System.Drawing.Size(62, 17);
            this.chkVendas.TabIndex = 5;
            this.chkVendas.Text = "Vendas";
            this.chkVendas.UseVisualStyleBackColor = true;
            // 
            // condLabel
            // 
            this.condLabel.AutoSize = true;
            this.condLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.condLabel.Location = new System.Drawing.Point(3, 6);
            this.condLabel.Name = "condLabel";
            this.condLabel.Size = new System.Drawing.Size(67, 17);
            this.condLabel.TabIndex = 4;
            this.condLabel.Text = "Corrigir:";
            // 
            // painelPesquisa
            // 
            this.painelPesquisa.Location = new System.Drawing.Point(0, 0);
            this.painelPesquisa.Name = "painelPesquisa";
            this.painelPesquisa.Size = new System.Drawing.Size(100, 20);
            this.painelPesquisa.TabIndex = 0;
            // 
            // divdir
            // 
            this.divdir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.divdir.Controls.Add(this.lblResults);
            this.divdir.Controls.Add(this.txtProcessos);
            this.divdir.Dock = System.Windows.Forms.DockStyle.Right;
            this.divdir.Location = new System.Drawing.Point(865, 47);
            this.divdir.Name = "divdir";
            this.divdir.Padding = new System.Windows.Forms.Padding(6, 10, 0, 0);
            this.divdir.Size = new System.Drawing.Size(589, 599);
            this.divdir.TabIndex = 5;
            // 
            // lblResults
            // 
            this.lblResults.AutoSize = true;
            this.lblResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblResults.Location = new System.Drawing.Point(9, 13);
            this.lblResults.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.lblResults.Name = "lblResults";
            this.lblResults.Size = new System.Drawing.Size(88, 17);
            this.lblResults.TabIndex = 1;
            this.lblResults.Text = "Processos:";
            // 
            // txtProcessos
            // 
            this.txtProcessos.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtProcessos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.txtProcessos.Location = new System.Drawing.Point(9, 33);
            this.txtProcessos.MinimumSize = new System.Drawing.Size(4, 20);
            this.txtProcessos.Multiline = true;
            this.txtProcessos.Name = "txtProcessos";
            this.txtProcessos.ReadOnly = true;
            this.txtProcessos.Size = new System.Drawing.Size(566, 554);
            this.txtProcessos.TabIndex = 2;
            this.txtProcessos.Text = "Aqui exibirá os ocorrimentos...";
            // 
            // divesq
            // 
            this.divesq.AutoSize = true;
            this.divesq.Controls.Add(this.lblnaoproc);
            this.divesq.Controls.Add(this.tabelaNProc);
            this.divesq.Dock = System.Windows.Forms.DockStyle.Left;
            this.divesq.Location = new System.Drawing.Point(0, 47);
            this.divesq.Name = "divesq";
            this.divesq.Padding = new System.Windows.Forms.Padding(5);
            this.divesq.Size = new System.Drawing.Size(863, 599);
            this.divesq.TabIndex = 3;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1454, 646);
            this.Controls.Add(this.divdir);
            this.Controls.Add(this.divesq);
            this.Controls.Add(this.topo);
            this.Controls.Add(this.divTopo);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "Principal";
            this.Text = "Acerto";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Principal_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tabelaNProc)).EndInit();
            this.topo.ResumeLayout(false);
            this.topo.PerformLayout();
            this.panelPesquisa.ResumeLayout(false);
            this.panelPesquisa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pesquisar)).EndInit();
            this.panelExecutar.ResumeLayout(false);
            this.panelResults.ResumeLayout(false);
            this.panelResults.PerformLayout();
            this.grpCondi.ResumeLayout(false);
            this.grpCondi.PerformLayout();
            this.divdir.ResumeLayout(false);
            this.divdir.PerformLayout();
            this.divesq.ResumeLayout(false);
            this.divesq.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btPesquisa;
        private System.Windows.Forms.FlowLayoutPanel divTopo;
        private System.Windows.Forms.Label lblConexao;
        private System.Windows.Forms.Label lblnaoproc;
        private System.Windows.Forms.FlowLayoutPanel topo;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.TextBox painelPesquisa;
        private System.Windows.Forms.Panel panelPesquisa;
        private System.Windows.Forms.Label lblFilial;
        private System.Windows.Forms.DataGridView tabelaNProc;
        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.FlowLayoutPanel divdir;
        private System.Windows.Forms.FlowLayoutPanel divesq;
        private System.Windows.Forms.Panel panelExecutar;
        private System.Windows.Forms.Panel grpCondi;
        private System.Windows.Forms.Label condLabel;
        private System.Windows.Forms.CheckBox chkTrans;
        private System.Windows.Forms.CheckBox chkVendas;
        private System.Windows.Forms.Label lblResults;
        private System.Windows.Forms.TextBox txtProcessos;
        private System.Windows.Forms.Button btCorrigir;
        private System.Windows.Forms.FlowLayoutPanel panelResults;
        private System.Windows.Forms.Label estatisticas;
        private System.Windows.Forms.NumericUpDown pesquisar;
    }
}


namespace Acerto
{
    partial class Produto
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Produto));
            this.tabelaLayoutProd = new System.Windows.Forms.TableLayoutPanel();
            this.ProdTabelaTopEsq = new System.Windows.Forms.TableLayoutPanel();
            this.divProdTopEsq = new System.Windows.Forms.FlowLayoutPanel();
            this.lblProdMaterial = new System.Windows.Forms.Label();
            this.lblProdSerie = new System.Windows.Forms.Label();
            this.ProdDivTopDir = new System.Windows.Forms.FlowLayoutPanel();
            this.ProdLblFilial = new System.Windows.Forms.Label();
            this.ProdTabelaCentro = new System.Windows.Forms.TableLayoutPanel();
            this.prodGridSaldos = new System.Windows.Forms.DataGridView();
            this.ProdGridHist = new System.Windows.Forms.DataGridView();
            this.tabelaLayoutProd.SuspendLayout();
            this.ProdTabelaTopEsq.SuspendLayout();
            this.divProdTopEsq.SuspendLayout();
            this.ProdDivTopDir.SuspendLayout();
            this.ProdTabelaCentro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prodGridSaldos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProdGridHist)).BeginInit();
            this.SuspendLayout();
            // 
            // tabelaLayoutProd
            // 
            this.tabelaLayoutProd.ColumnCount = 1;
            this.tabelaLayoutProd.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tabelaLayoutProd.Controls.Add(this.ProdTabelaTopEsq, 0, 0);
            this.tabelaLayoutProd.Controls.Add(this.ProdTabelaCentro, 0, 1);
            this.tabelaLayoutProd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabelaLayoutProd.Location = new System.Drawing.Point(0, 0);
            this.tabelaLayoutProd.Margin = new System.Windows.Forms.Padding(0);
            this.tabelaLayoutProd.Name = "tabelaLayoutProd";
            this.tabelaLayoutProd.RowCount = 2;
            this.tabelaLayoutProd.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tabelaLayoutProd.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tabelaLayoutProd.Size = new System.Drawing.Size(832, 292);
            this.tabelaLayoutProd.TabIndex = 0;
            // 
            // ProdTabelaTopEsq
            // 
            this.ProdTabelaTopEsq.ColumnCount = 2;
            this.ProdTabelaTopEsq.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ProdTabelaTopEsq.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 253F));
            this.ProdTabelaTopEsq.Controls.Add(this.divProdTopEsq, 0, 0);
            this.ProdTabelaTopEsq.Controls.Add(this.ProdDivTopDir, 1, 0);
            this.ProdTabelaTopEsq.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProdTabelaTopEsq.Location = new System.Drawing.Point(3, 3);
            this.ProdTabelaTopEsq.Name = "ProdTabelaTopEsq";
            this.ProdTabelaTopEsq.RowCount = 1;
            this.ProdTabelaTopEsq.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ProdTabelaTopEsq.Size = new System.Drawing.Size(826, 24);
            this.ProdTabelaTopEsq.TabIndex = 2;
            // 
            // divProdTopEsq
            // 
            this.divProdTopEsq.Controls.Add(this.lblProdMaterial);
            this.divProdTopEsq.Controls.Add(this.lblProdSerie);
            this.divProdTopEsq.Dock = System.Windows.Forms.DockStyle.Fill;
            this.divProdTopEsq.Location = new System.Drawing.Point(0, 0);
            this.divProdTopEsq.Margin = new System.Windows.Forms.Padding(0);
            this.divProdTopEsq.Name = "divProdTopEsq";
            this.divProdTopEsq.Size = new System.Drawing.Size(573, 24);
            this.divProdTopEsq.TabIndex = 1;
            // 
            // lblProdMaterial
            // 
            this.lblProdMaterial.AutoSize = true;
            this.lblProdMaterial.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProdMaterial.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblProdMaterial.Location = new System.Drawing.Point(0, 0);
            this.lblProdMaterial.Margin = new System.Windows.Forms.Padding(0);
            this.lblProdMaterial.Name = "lblProdMaterial";
            this.lblProdMaterial.Size = new System.Drawing.Size(83, 24);
            this.lblProdMaterial.TabIndex = 0;
            this.lblProdMaterial.Text = "Material";
            // 
            // lblProdSerie
            // 
            this.lblProdSerie.AutoSize = true;
            this.lblProdSerie.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProdSerie.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblProdSerie.Location = new System.Drawing.Point(83, 0);
            this.lblProdSerie.Margin = new System.Windows.Forms.Padding(0);
            this.lblProdSerie.Name = "lblProdSerie";
            this.lblProdSerie.Size = new System.Drawing.Size(59, 24);
            this.lblProdSerie.TabIndex = 1;
            this.lblProdSerie.Text = "Serie";
            // 
            // ProdDivTopDir
            // 
            this.ProdDivTopDir.Controls.Add(this.ProdLblFilial);
            this.ProdDivTopDir.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProdDivTopDir.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.ProdDivTopDir.Location = new System.Drawing.Point(573, 0);
            this.ProdDivTopDir.Margin = new System.Windows.Forms.Padding(0);
            this.ProdDivTopDir.Name = "ProdDivTopDir";
            this.ProdDivTopDir.Size = new System.Drawing.Size(253, 24);
            this.ProdDivTopDir.TabIndex = 2;
            // 
            // ProdLblFilial
            // 
            this.ProdLblFilial.AutoSize = true;
            this.ProdLblFilial.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProdLblFilial.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ProdLblFilial.Location = new System.Drawing.Point(193, 0);
            this.ProdLblFilial.Margin = new System.Windows.Forms.Padding(0);
            this.ProdLblFilial.Name = "ProdLblFilial";
            this.ProdLblFilial.Size = new System.Drawing.Size(60, 24);
            this.ProdLblFilial.TabIndex = 1;
            this.ProdLblFilial.Text = "Filial:";
            // 
            // ProdTabelaCentro
            // 
            this.ProdTabelaCentro.ColumnCount = 1;
            this.ProdTabelaCentro.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.ProdTabelaCentro.Controls.Add(this.prodGridSaldos, 0, 1);
            this.ProdTabelaCentro.Controls.Add(this.ProdGridHist, 0, 0);
            this.ProdTabelaCentro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProdTabelaCentro.Location = new System.Drawing.Point(0, 30);
            this.ProdTabelaCentro.Margin = new System.Windows.Forms.Padding(0);
            this.ProdTabelaCentro.Name = "ProdTabelaCentro";
            this.ProdTabelaCentro.RowCount = 2;
            this.ProdTabelaCentro.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ProdTabelaCentro.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.ProdTabelaCentro.Size = new System.Drawing.Size(832, 262);
            this.ProdTabelaCentro.TabIndex = 3;
            // 
            // prodGridSaldos
            // 
            this.prodGridSaldos.AllowUserToAddRows = false;
            this.prodGridSaldos.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.prodGridSaldos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.prodGridSaldos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.prodGridSaldos.BackgroundColor = System.Drawing.SystemColors.HotTrack;
            this.prodGridSaldos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.prodGridSaldos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.prodGridSaldos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.prodGridSaldos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.prodGridSaldos.DefaultCellStyle = dataGridViewCellStyle3;
            this.prodGridSaldos.Dock = System.Windows.Forms.DockStyle.Top;
            this.prodGridSaldos.EnableHeadersVisualStyles = false;
            this.prodGridSaldos.Location = new System.Drawing.Point(3, 149);
            this.prodGridSaldos.Name = "prodGridSaldos";
            this.prodGridSaldos.ReadOnly = true;
            this.prodGridSaldos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.prodGridSaldos.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.prodGridSaldos.RowHeadersVisible = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.prodGridSaldos.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.prodGridSaldos.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.prodGridSaldos.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.prodGridSaldos.Size = new System.Drawing.Size(826, 110);
            this.prodGridSaldos.TabIndex = 1;
            // 
            // ProdGridHist
            // 
            this.ProdGridHist.AllowUserToAddRows = false;
            this.ProdGridHist.AllowUserToDeleteRows = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ProdGridHist.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.ProdGridHist.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ProdGridHist.BackgroundColor = System.Drawing.SystemColors.HotTrack;
            this.ProdGridHist.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ProdGridHist.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.ProdGridHist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.InactiveBorder;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ProdGridHist.DefaultCellStyle = dataGridViewCellStyle8;
            this.ProdGridHist.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProdGridHist.EnableHeadersVisualStyles = false;
            this.ProdGridHist.Location = new System.Drawing.Point(3, 3);
            this.ProdGridHist.Name = "ProdGridHist";
            this.ProdGridHist.ReadOnly = true;
            this.ProdGridHist.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ProdGridHist.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.ProdGridHist.RowHeadersVisible = false;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.InactiveBorder;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ProdGridHist.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.ProdGridHist.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ProdGridHist.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ProdGridHist.Size = new System.Drawing.Size(826, 140);
            this.ProdGridHist.TabIndex = 0;
            // 
            // Produto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(832, 292);
            this.Controls.Add(this.tabelaLayoutProd);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(550, 330);
            this.Name = "Produto";
            this.Text = "Produto";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Produto_FormClosed);
            this.Load += new System.EventHandler(this.Produto_Load);
            this.tabelaLayoutProd.ResumeLayout(false);
            this.ProdTabelaTopEsq.ResumeLayout(false);
            this.divProdTopEsq.ResumeLayout(false);
            this.divProdTopEsq.PerformLayout();
            this.ProdDivTopDir.ResumeLayout(false);
            this.ProdDivTopDir.PerformLayout();
            this.ProdTabelaCentro.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.prodGridSaldos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProdGridHist)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tabelaLayoutProd;
        private System.Windows.Forms.TableLayoutPanel ProdTabelaTopEsq;
        private System.Windows.Forms.FlowLayoutPanel divProdTopEsq;
        private System.Windows.Forms.Label lblProdMaterial;
        private System.Windows.Forms.Label lblProdSerie;
        private System.Windows.Forms.FlowLayoutPanel ProdDivTopDir;
        private System.Windows.Forms.Label ProdLblFilial;
        private System.Windows.Forms.TableLayoutPanel ProdTabelaCentro;
        private System.Windows.Forms.DataGridView ProdGridHist;
        private System.Windows.Forms.DataGridView prodGridSaldos;
    }
}
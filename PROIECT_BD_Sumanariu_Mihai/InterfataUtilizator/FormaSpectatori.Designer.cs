
namespace DotNetOracle
{
    partial class SPECTATOR
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SPECTATOR));
            this.dgvBileteAchitate = new System.Windows.Forms.DataGridView();
            this.lblNumeSpectator = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvMeciuriSpectatori = new System.Windows.Forms.DataGridView();
            this.btnCumparaBilet = new System.Windows.Forms.Button();
            this.lblLocuriDisponibile = new System.Windows.Forms.Label();
            this.lblMeci = new System.Windows.Forms.Label();
            this.lblMeciSelectat = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblNr = new System.Windows.Forms.Label();
            this.txtNrScaun = new System.Windows.Forms.TextBox();
            this.txtNume = new System.Windows.Forms.TextBox();
            this.txtNrScaunEditare = new System.Windows.Forms.TextBox();
            this.txtNumeEditare = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblFinal = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnActualizeaza = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.gbInformatiiBileteAchitate = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBileteAchitate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMeciuriSpectatori)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.gbInformatiiBileteAchitate.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvBileteAchitate
            // 
            this.dgvBileteAchitate.BackgroundColor = System.Drawing.Color.LemonChiffon;
            this.dgvBileteAchitate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBileteAchitate.Location = new System.Drawing.Point(9, 48);
            this.dgvBileteAchitate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvBileteAchitate.Name = "dgvBileteAchitate";
            this.dgvBileteAchitate.RowHeadersWidth = 51;
            this.dgvBileteAchitate.RowTemplate.Height = 24;
            this.dgvBileteAchitate.Size = new System.Drawing.Size(604, 283);
            this.dgvBileteAchitate.TabIndex = 14;
            this.dgvBileteAchitate.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBileteAchitate_CellContentClick);
            // 
            // lblNumeSpectator
            // 
            this.lblNumeSpectator.AutoSize = true;
            this.lblNumeSpectator.Location = new System.Drawing.Point(60, 391);
            this.lblNumeSpectator.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumeSpectator.Name = "lblNumeSpectator";
            this.lblNumeSpectator.Size = new System.Drawing.Size(68, 25);
            this.lblNumeSpectator.TabIndex = 8;
            this.lblNumeSpectator.Text = "Nume";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 450);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "Nr.Scaun";
            // 
            // dgvMeciuriSpectatori
            // 
            this.dgvMeciuriSpectatori.BackgroundColor = System.Drawing.Color.LemonChiffon;
            this.dgvMeciuriSpectatori.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMeciuriSpectatori.Location = new System.Drawing.Point(8, 44);
            this.dgvMeciuriSpectatori.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvMeciuriSpectatori.Name = "dgvMeciuriSpectatori";
            this.dgvMeciuriSpectatori.RowHeadersWidth = 51;
            this.dgvMeciuriSpectatori.RowTemplate.Height = 24;
            this.dgvMeciuriSpectatori.Size = new System.Drawing.Size(1280, 308);
            this.dgvMeciuriSpectatori.TabIndex = 11;
            this.dgvMeciuriSpectatori.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMeciuriSpectatori_CellContentClick);
            // 
            // btnCumparaBilet
            // 
            this.btnCumparaBilet.BackColor = System.Drawing.Color.LightYellow;
            this.btnCumparaBilet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCumparaBilet.Location = new System.Drawing.Point(847, 374);
            this.btnCumparaBilet.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCumparaBilet.Name = "btnCumparaBilet";
            this.btnCumparaBilet.Size = new System.Drawing.Size(416, 139);
            this.btnCumparaBilet.TabIndex = 13;
            this.btnCumparaBilet.Text = "Cumpara Bilet";
            this.btnCumparaBilet.UseVisualStyleBackColor = false;
            this.btnCumparaBilet.Click += new System.EventHandler(this.btnCumparaBilet_Click);
            // 
            // lblLocuriDisponibile
            // 
            this.lblLocuriDisponibile.AutoSize = true;
            this.lblLocuriDisponibile.Location = new System.Drawing.Point(364, 458);
            this.lblLocuriDisponibile.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLocuriDisponibile.Name = "lblLocuriDisponibile";
            this.lblLocuriDisponibile.Size = new System.Drawing.Size(225, 25);
            this.lblLocuriDisponibile.TabIndex = 14;
            this.lblLocuriDisponibile.Text = "Nr. Max. Locuri Disp.: ";
            // 
            // lblMeci
            // 
            this.lblMeci.AutoSize = true;
            this.lblMeci.Location = new System.Drawing.Point(60, 505);
            this.lblMeci.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMeci.Name = "lblMeci";
            this.lblMeci.Size = new System.Drawing.Size(58, 25);
            this.lblMeci.TabIndex = 17;
            this.lblMeci.Text = "Meci";
            // 
            // lblMeciSelectat
            // 
            this.lblMeciSelectat.AutoSize = true;
            this.lblMeciSelectat.Location = new System.Drawing.Point(118, 505);
            this.lblMeciSelectat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMeciSelectat.Name = "lblMeciSelectat";
            this.lblMeciSelectat.Size = new System.Drawing.Size(0, 25);
            this.lblMeciSelectat.TabIndex = 18;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.lblNr);
            this.groupBox1.Controls.Add(this.txtNrScaun);
            this.groupBox1.Controls.Add(this.txtNume);
            this.groupBox1.Controls.Add(this.lblMeciSelectat);
            this.groupBox1.Controls.Add(this.lblMeci);
            this.groupBox1.Controls.Add(this.lblLocuriDisponibile);
            this.groupBox1.Controls.Add(this.btnCumparaBilet);
            this.groupBox1.Controls.Add(this.dgvMeciuriSpectatori);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblNumeSpectator);
            this.groupBox1.Location = new System.Drawing.Point(8, 11);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(1348, 569);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Meciuri actuale (selectati meciul dorit)";
            // 
            // lblNr
            // 
            this.lblNr.AutoSize = true;
            this.lblNr.Location = new System.Drawing.Point(579, 458);
            this.lblNr.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNr.Name = "lblNr";
            this.lblNr.Size = new System.Drawing.Size(0, 25);
            this.lblNr.TabIndex = 21;
            // 
            // txtNrScaun
            // 
            this.txtNrScaun.Location = new System.Drawing.Point(136, 450);
            this.txtNrScaun.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNrScaun.Name = "txtNrScaun";
            this.txtNrScaun.Size = new System.Drawing.Size(217, 31);
            this.txtNrScaun.TabIndex = 20;
            // 
            // txtNume
            // 
            this.txtNume.Location = new System.Drawing.Point(136, 386);
            this.txtNume.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNume.Name = "txtNume";
            this.txtNume.Size = new System.Drawing.Size(217, 31);
            this.txtNume.TabIndex = 19;
            // 
            // txtNrScaunEditare
            // 
            this.txtNrScaunEditare.Location = new System.Drawing.Point(147, 111);
            this.txtNrScaunEditare.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNrScaunEditare.Name = "txtNrScaunEditare";
            this.txtNrScaunEditare.Size = new System.Drawing.Size(217, 31);
            this.txtNrScaunEditare.TabIndex = 27;
            // 
            // txtNumeEditare
            // 
            this.txtNumeEditare.Location = new System.Drawing.Point(147, 39);
            this.txtNumeEditare.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNumeEditare.Name = "txtNumeEditare";
            this.txtNumeEditare.Size = new System.Drawing.Size(217, 31);
            this.txtNumeEditare.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(129, 158);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 25);
            this.label1.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 111);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 25);
            this.label5.TabIndex = 22;
            this.label5.Text = "Nr.Scaun";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(56, 39);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 25);
            this.label6.TabIndex = 21;
            this.label6.Text = "Nume";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.lblFinal);
            this.groupBox2.Controls.Add(this.btnDelete);
            this.groupBox2.Controls.Add(this.btnActualizeaza);
            this.groupBox2.Controls.Add(this.txtNrScaunEditare);
            this.groupBox2.Controls.Add(this.txtNumeEditare);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(668, 34);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(610, 261);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Actualizare Bilete Cumparate";
            // 
            // lblFinal
            // 
            this.lblFinal.AutoSize = true;
            this.lblFinal.BackColor = System.Drawing.Color.Transparent;
            this.lblFinal.Location = new System.Drawing.Point(118, 158);
            this.lblFinal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFinal.Name = "lblFinal";
            this.lblFinal.Size = new System.Drawing.Size(0, 25);
            this.lblFinal.TabIndex = 30;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Ivory;
            this.btnDelete.Location = new System.Drawing.Point(366, 183);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(189, 58);
            this.btnDelete.TabIndex = 29;
            this.btnDelete.Text = "Sterge";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnActualizeaza
            // 
            this.btnActualizeaza.BackColor = System.Drawing.Color.Ivory;
            this.btnActualizeaza.Location = new System.Drawing.Point(169, 183);
            this.btnActualizeaza.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnActualizeaza.Name = "btnActualizeaza";
            this.btnActualizeaza.Size = new System.Drawing.Size(170, 58);
            this.btnActualizeaza.TabIndex = 28;
            this.btnActualizeaza.Text = "Actualizeaza";
            this.btnActualizeaza.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(54, 158);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 35);
            this.label2.TabIndex = 24;
            this.label2.Text = "Meci";
            // 
            // gbInformatiiBileteAchitate
            // 
            this.gbInformatiiBileteAchitate.BackColor = System.Drawing.Color.Transparent;
            this.gbInformatiiBileteAchitate.Controls.Add(this.dgvBileteAchitate);
            this.gbInformatiiBileteAchitate.Controls.Add(this.groupBox2);
            this.gbInformatiiBileteAchitate.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.gbInformatiiBileteAchitate.Location = new System.Drawing.Point(18, 581);
            this.gbInformatiiBileteAchitate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbInformatiiBileteAchitate.Name = "gbInformatiiBileteAchitate";
            this.gbInformatiiBileteAchitate.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbInformatiiBileteAchitate.Size = new System.Drawing.Size(1338, 353);
            this.gbInformatiiBileteAchitate.TabIndex = 21;
            this.gbInformatiiBileteAchitate.TabStop = false;
            this.gbInformatiiBileteAchitate.Text = "Informatii Bilete Achitate";
            // 
            // SPECTATOR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1404, 945);
            this.Controls.Add(this.gbInformatiiBileteAchitate);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "SPECTATOR";
            this.Text = "FormaSpectatori";
            this.Load += new System.EventHandler(this.FormaSpectatori_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBileteAchitate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMeciuriSpectatori)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.gbInformatiiBileteAchitate.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvBileteAchitate;
        private System.Windows.Forms.Label lblNumeSpectator;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvMeciuriSpectatori;
        private System.Windows.Forms.Button btnCumparaBilet;
        private System.Windows.Forms.Label lblLocuriDisponibile;
        private System.Windows.Forms.Label lblMeci;
        private System.Windows.Forms.Label lblMeciSelectat;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtNrScaun;
        private System.Windows.Forms.TextBox txtNume;
        private System.Windows.Forms.TextBox txtNrScaunEditare;
        private System.Windows.Forms.TextBox txtNumeEditare;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnActualizeaza;
        private System.Windows.Forms.GroupBox gbInformatiiBileteAchitate;
        private System.Windows.Forms.Label lblNr;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblFinal;
    }
}
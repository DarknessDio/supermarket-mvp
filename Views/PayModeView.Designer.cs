namespace Supermarket_mvp_2.Views
{
    partial class PayModeView
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
            Panel1 = new Panel();
            Pb1 = new PictureBox();
            LblPay = new Label();
            tabControl1 = new TabControl();
            tabPagePayModeList = new TabPage();
            BtnClose = new Button();
            BtnNew = new Button();
            DgPayMode = new DataGridView();
            BtnDelete = new Button();
            BtnSearch = new Button();
            TxtSearch = new TextBox();
            BtnEdit = new Button();
            LblSearch = new Label();
            tabPagePayModeDetail = new TabPage();
            BtnCancel = new Button();
            BtnSave = new Button();
            TxtPayModeObservation = new TextBox();
            label2 = new Label();
            TxtPayModeName = new TextBox();
            label1 = new Label();
            TxtPayModeId = new TextBox();
            LblPayId = new Label();
            Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Pb1).BeginInit();
            tabControl1.SuspendLayout();
            tabPagePayModeList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgPayMode).BeginInit();
            tabPagePayModeDetail.SuspendLayout();
            SuspendLayout();
            // 
            // Panel1
            // 
            Panel1.Controls.Add(Pb1);
            Panel1.Controls.Add(LblPay);
            Panel1.Dock = DockStyle.Top;
            Panel1.Location = new Point(0, 0);
            Panel1.Name = "Panel1";
            Panel1.Size = new Size(971, 125);
            Panel1.TabIndex = 0;
            // 
            // Pb1
            // 
            Pb1.Image = Properties.Resources.buy;
            Pb1.Location = new Point(12, 21);
            Pb1.Name = "Pb1";
            Pb1.Size = new Size(143, 91);
            Pb1.SizeMode = PictureBoxSizeMode.Zoom;
            Pb1.TabIndex = 1;
            Pb1.TabStop = false;
            // 
            // LblPay
            // 
            LblPay.AutoSize = true;
            LblPay.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            LblPay.Location = new Point(181, 40);
            LblPay.Name = "LblPay";
            LblPay.Size = new Size(169, 46);
            LblPay.TabIndex = 0;
            LblPay.Text = "Pay Mode";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPagePayModeList);
            tabControl1.Controls.Add(tabPagePayModeDetail);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 125);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(971, 421);
            tabControl1.TabIndex = 1;
            // 
            // tabPagePayModeList
            // 
            tabPagePayModeList.Controls.Add(BtnClose);
            tabPagePayModeList.Controls.Add(BtnNew);
            tabPagePayModeList.Controls.Add(DgPayMode);
            tabPagePayModeList.Controls.Add(BtnDelete);
            tabPagePayModeList.Controls.Add(BtnSearch);
            tabPagePayModeList.Controls.Add(TxtSearch);
            tabPagePayModeList.Controls.Add(BtnEdit);
            tabPagePayModeList.Controls.Add(LblSearch);
            tabPagePayModeList.Location = new Point(4, 29);
            tabPagePayModeList.Name = "tabPagePayModeList";
            tabPagePayModeList.Padding = new Padding(3);
            tabPagePayModeList.Size = new Size(963, 388);
            tabPagePayModeList.TabIndex = 0;
            tabPagePayModeList.Text = "Pay Mode List";
            tabPagePayModeList.UseVisualStyleBackColor = true;
            // 
            // BtnClose
            // 
            BtnClose.Image = Properties.Resources.cerrar;
            BtnClose.Location = new Point(549, 248);
            BtnClose.Name = "BtnClose";
            BtnClose.Size = new Size(113, 47);
            BtnClose.TabIndex = 7;
            BtnClose.UseVisualStyleBackColor = true;
            // 
            // BtnNew
            // 
            BtnNew.Image = Properties.Resources._new;
            BtnNew.Location = new Point(549, 92);
            BtnNew.Name = "BtnNew";
            BtnNew.Size = new Size(113, 45);
            BtnNew.TabIndex = 4;
            BtnNew.UseVisualStyleBackColor = true;
            // 
            // DgPayMode
            // 
            DgPayMode.AllowUserToAddRows = false;
            DgPayMode.AllowUserToDeleteRows = false;
            DgPayMode.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgPayMode.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgPayMode.Location = new Point(8, 92);
            DgPayMode.Name = "DgPayMode";
            DgPayMode.ReadOnly = true;
            DgPayMode.RowHeadersWidth = 51;
            DgPayMode.RowTemplate.Height = 29;
            DgPayMode.Size = new Size(515, 288);
            DgPayMode.TabIndex = 3;
            // 
            // BtnDelete
            // 
            BtnDelete.Image = Properties.Resources.delete;
            BtnDelete.Location = new Point(549, 196);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(113, 46);
            BtnDelete.TabIndex = 6;
            BtnDelete.UseVisualStyleBackColor = true;
            // 
            // BtnSearch
            // 
            BtnSearch.Image = Properties.Resources.cancel;
            BtnSearch.Location = new Point(479, 37);
            BtnSearch.Name = "BtnSearch";
            BtnSearch.Size = new Size(44, 45);
            BtnSearch.TabIndex = 2;
            BtnSearch.UseVisualStyleBackColor = true;
            // 
            // TxtSearch
            // 
            TxtSearch.Location = new Point(8, 46);
            TxtSearch.Name = "TxtSearch";
            TxtSearch.PlaceholderText = "Data to search";
            TxtSearch.Size = new Size(465, 27);
            TxtSearch.TabIndex = 1;
            // 
            // BtnEdit
            // 
            BtnEdit.Image = Properties.Resources.edit;
            BtnEdit.Location = new Point(549, 143);
            BtnEdit.Name = "BtnEdit";
            BtnEdit.Size = new Size(113, 47);
            BtnEdit.TabIndex = 5;
            BtnEdit.UseVisualStyleBackColor = true;
            // 
            // LblSearch
            // 
            LblSearch.AutoSize = true;
            LblSearch.Location = new Point(8, 13);
            LblSearch.Name = "LblSearch";
            LblSearch.Size = new Size(122, 20);
            LblSearch.TabIndex = 0;
            LblSearch.Text = "Search Pay Mode";
            // 
            // tabPagePayModeDetail
            // 
            tabPagePayModeDetail.Controls.Add(BtnCancel);
            tabPagePayModeDetail.Controls.Add(BtnSave);
            tabPagePayModeDetail.Controls.Add(TxtPayModeObservation);
            tabPagePayModeDetail.Controls.Add(label2);
            tabPagePayModeDetail.Controls.Add(TxtPayModeName);
            tabPagePayModeDetail.Controls.Add(label1);
            tabPagePayModeDetail.Controls.Add(TxtPayModeId);
            tabPagePayModeDetail.Controls.Add(LblPayId);
            tabPagePayModeDetail.Location = new Point(4, 29);
            tabPagePayModeDetail.Name = "tabPagePayModeDetail";
            tabPagePayModeDetail.Padding = new Padding(3);
            tabPagePayModeDetail.Size = new Size(963, 388);
            tabPagePayModeDetail.TabIndex = 1;
            tabPagePayModeDetail.Text = "Pay Mode Detail";
            tabPagePayModeDetail.UseVisualStyleBackColor = true;
            // 
            // BtnCancel
            // 
            BtnCancel.Image = Properties.Resources.cancel;
            BtnCancel.Location = new Point(167, 312);
            BtnCancel.Name = "BtnCancel";
            BtnCancel.Size = new Size(94, 57);
            BtnCancel.TabIndex = 7;
            BtnCancel.UseVisualStyleBackColor = true;
            // 
            // BtnSave
            // 
            BtnSave.Image = Properties.Resources.save;
            BtnSave.Location = new Point(16, 312);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new Size(94, 57);
            BtnSave.TabIndex = 6;
            BtnSave.UseVisualStyleBackColor = true;
            // 
            // TxtPayModeObservation
            // 
            TxtPayModeObservation.Location = new Point(19, 231);
            TxtPayModeObservation.Multiline = true;
            TxtPayModeObservation.Name = "TxtPayModeObservation";
            TxtPayModeObservation.PlaceholderText = "Pay Mode Observation";
            TxtPayModeObservation.Size = new Size(281, 66);
            TxtPayModeObservation.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 208);
            label2.Name = "label2";
            label2.Size = new Size(158, 20);
            label2.TabIndex = 4;
            label2.Text = "Pay Mode Observation";
            // 
            // TxtPayModeName
            // 
            TxtPayModeName.Location = new Point(19, 135);
            TxtPayModeName.Name = "TxtPayModeName";
            TxtPayModeName.PlaceholderText = "Pay Mode Name";
            TxtPayModeName.Size = new Size(281, 27);
            TxtPayModeName.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 112);
            label1.Name = "label1";
            label1.Size = new Size(118, 20);
            label1.TabIndex = 2;
            label1.Text = "Pay Mode Name";
            // 
            // TxtPayModeId
            // 
            TxtPayModeId.Location = new Point(19, 45);
            TxtPayModeId.Name = "TxtPayModeId";
            TxtPayModeId.Size = new Size(242, 27);
            TxtPayModeId.TabIndex = 1;
            // 
            // LblPayId
            // 
            LblPayId.AutoSize = true;
            LblPayId.Location = new Point(19, 22);
            LblPayId.Name = "LblPayId";
            LblPayId.Size = new Size(91, 20);
            LblPayId.TabIndex = 0;
            LblPayId.Text = "Pay Mode Id";
            // 
            // PayModeView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(971, 546);
            Controls.Add(tabControl1);
            Controls.Add(Panel1);
            Name = "PayModeView";
            Text = "Pay Mode Management";
            Panel1.ResumeLayout(false);
            Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Pb1).EndInit();
            tabControl1.ResumeLayout(false);
            tabPagePayModeList.ResumeLayout(false);
            tabPagePayModeList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DgPayMode).EndInit();
            tabPagePayModeDetail.ResumeLayout(false);
            tabPagePayModeDetail.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel Panel1;
        private Label LblPay;
        private PictureBox Pb1;
        private TabControl tabControl1;
        private TabPage tabPagePayModeList;
        private TabPage tabPagePayModeDetail;
        private Label LblSearch;
        private Button BtnSearch;
        private TextBox TxtSearch;
        private Button BtnEdit;
        private Button BtnClose;
        private Button BtnDelete;
        private Button BtnNew;
        private DataGridView DgPayMode;
        private Label LblPayId;
        private Label label2;
        private TextBox TxtPayModeName;
        private Label label1;
        private TextBox TxtPayModeId;
        private Button BtnCancel;
        private Button BtnSave;
        private TextBox TxtPayModeObservation;
    }
}
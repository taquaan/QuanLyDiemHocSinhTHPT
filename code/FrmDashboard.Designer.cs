
namespace QuanLyDiemHocSinhTHPT
{
  partial class FrmDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDashboard));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMenuToggle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.MenuPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.btnThongTinGV = new System.Windows.Forms.Button();
            this.btnQuanLyDiem = new System.Windows.Forms.Button();
            this.btnHoTro = new System.Windows.Forms.Button();
            this.btnDangXuat = new System.Windows.Forms.Button();
            this.DropKhoa = new System.Windows.Forms.ComboBox();
            this.DropLop = new System.Windows.Forms.ComboBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.dgvHocSinh = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.MenuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHocSinh)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnMenuToggle);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1047, 55);
            this.panel1.TabIndex = 0;
            // 
            // btnMenuToggle
            // 
            this.btnMenuToggle.Image = ((System.Drawing.Image)(resources.GetObject("btnMenuToggle.Image")));
            this.btnMenuToggle.Location = new System.Drawing.Point(12, 12);
            this.btnMenuToggle.Name = "btnMenuToggle";
            this.btnMenuToggle.Size = new System.Drawing.Size(37, 34);
            this.btnMenuToggle.TabIndex = 2;
            this.btnMenuToggle.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(794, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "HỆ THỐNG QUẢN LÝ ĐIỂM";
            // 
            // MenuPanel
            // 
            this.MenuPanel.BackColor = System.Drawing.Color.White;
            this.MenuPanel.Controls.Add(this.btnThongTinGV);
            this.MenuPanel.Controls.Add(this.btnQuanLyDiem);
            this.MenuPanel.Controls.Add(this.btnHoTro);
            this.MenuPanel.Controls.Add(this.btnDangXuat);
            this.MenuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuPanel.Location = new System.Drawing.Point(0, 55);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Size = new System.Drawing.Size(235, 704);
            this.MenuPanel.TabIndex = 1;
            // 
            // btnThongTinGV
            // 
            this.btnThongTinGV.BackColor = System.Drawing.Color.LightGreen;
            this.btnThongTinGV.ForeColor = System.Drawing.Color.Black;
            this.btnThongTinGV.Image = ((System.Drawing.Image)(resources.GetObject("btnThongTinGV.Image")));
            this.btnThongTinGV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThongTinGV.Location = new System.Drawing.Point(3, 3);
            this.btnThongTinGV.Name = "btnThongTinGV";
            this.btnThongTinGV.Size = new System.Drawing.Size(230, 60);
            this.btnThongTinGV.TabIndex = 2;
            this.btnThongTinGV.Text = "Thông tin chi tiết GV";
            this.btnThongTinGV.UseVisualStyleBackColor = false;
            // 
            // btnQuanLyDiem
            // 
            this.btnQuanLyDiem.BackColor = System.Drawing.Color.LightGreen;
            this.btnQuanLyDiem.ForeColor = System.Drawing.Color.Black;
            this.btnQuanLyDiem.Image = ((System.Drawing.Image)(resources.GetObject("btnQuanLyDiem.Image")));
            this.btnQuanLyDiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuanLyDiem.Location = new System.Drawing.Point(3, 69);
            this.btnQuanLyDiem.Name = "btnQuanLyDiem";
            this.btnQuanLyDiem.Size = new System.Drawing.Size(229, 65);
            this.btnQuanLyDiem.TabIndex = 2;
            this.btnQuanLyDiem.Text = "Quản lý điểm HS";
            this.btnQuanLyDiem.UseVisualStyleBackColor = false;
            // 
            // btnHoTro
            // 
            this.btnHoTro.BackColor = System.Drawing.Color.LightGreen;
            this.btnHoTro.ForeColor = System.Drawing.Color.Black;
            this.btnHoTro.Image = ((System.Drawing.Image)(resources.GetObject("btnHoTro.Image")));
            this.btnHoTro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHoTro.Location = new System.Drawing.Point(3, 140);
            this.btnHoTro.Name = "btnHoTro";
            this.btnHoTro.Size = new System.Drawing.Size(229, 65);
            this.btnHoTro.TabIndex = 3;
            this.btnHoTro.Text = "Hỗ trợ";
            this.btnHoTro.UseVisualStyleBackColor = false;
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.BackColor = System.Drawing.Color.LightGreen;
            this.btnDangXuat.ForeColor = System.Drawing.Color.Black;
            this.btnDangXuat.Image = ((System.Drawing.Image)(resources.GetObject("btnDangXuat.Image")));
            this.btnDangXuat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDangXuat.Location = new System.Drawing.Point(3, 211);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(229, 60);
            this.btnDangXuat.TabIndex = 2;
            this.btnDangXuat.Text = "Đăng xuất";
            this.btnDangXuat.UseVisualStyleBackColor = false;
            // 
            // DropKhoa
            // 
            this.DropKhoa.FormattingEnabled = true;
            this.DropKhoa.Location = new System.Drawing.Point(241, 77);
            this.DropKhoa.Name = "DropKhoa";
            this.DropKhoa.Size = new System.Drawing.Size(133, 24);
            this.DropKhoa.TabIndex = 2;
            // 
            // DropLop
            // 
            this.DropLop.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DropLop.FormattingEnabled = true;
            this.DropLop.Location = new System.Drawing.Point(402, 77);
            this.DropLop.Name = "DropLop";
            this.DropLop.Size = new System.Drawing.Size(133, 24);
            this.DropLop.TabIndex = 3;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTimKiem.Location = new System.Drawing.Point(886, 72);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(149, 46);
            this.btnTimKiem.TabIndex = 4;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // dgvHocSinh
            // 
            this.dgvHocSinh.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvHocSinh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHocSinh.Location = new System.Drawing.Point(3, 124);
            this.dgvHocSinh.Name = "dgvHocSinh";
            this.dgvHocSinh.RowHeadersWidth = 51;
            this.dgvHocSinh.RowTemplate.Height = 24;
            this.dgvHocSinh.Size = new System.Drawing.Size(1044, 635);
            this.dgvHocSinh.TabIndex = 5;
            // 
            // FrmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 759);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.DropLop);
            this.Controls.Add(this.DropKhoa);
            this.Controls.Add(this.MenuPanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvHocSinh);
            this.Name = "FrmDashboard";
            this.Text = "FrmDashboard";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.MenuPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHocSinh)).EndInit();
            this.ResumeLayout(false);

    }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel MenuPanel;
        private System.Windows.Forms.Button btnQuanLyDiem;
        private System.Windows.Forms.Button btnThongTinGV;
        private System.Windows.Forms.Button btnDangXuat;
        private System.Windows.Forms.Button btnHoTro;
        private System.Windows.Forms.Button btnMenuToggle;
        private System.Windows.Forms.ComboBox DropKhoa;
        private System.Windows.Forms.ComboBox DropLop;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.DataGridView dgvHocSinh;
    }
}
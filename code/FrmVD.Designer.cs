
namespace QuanLyDiemHocSinhTHPT
{
  partial class FrmVD
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
            this.dataGridHocSinh = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridHocSinh)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridHocSinh
            // 
            this.dataGridHocSinh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridHocSinh.Location = new System.Drawing.Point(63, 70);
            this.dataGridHocSinh.Name = "dataGridHocSinh";
            this.dataGridHocSinh.Size = new System.Drawing.Size(644, 341);
            this.dataGridHocSinh.TabIndex = 0;
            // 
            // FrmVD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridHocSinh);
            this.Name = "FrmVD";
            this.Text = "FrmVD";
            this.Load += new System.EventHandler(this.FrmVD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridHocSinh)).EndInit();
            this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.DataGridView dataGridHocSinh;
  }
}
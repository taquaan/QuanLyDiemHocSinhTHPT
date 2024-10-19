
namespace QuanLyDiemHocSinhTHPT
{
  partial class FrmSuaDiem
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
            this.dtaThongTin = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtaThongTin)).BeginInit();
            this.SuspendLayout();
            // 
            // dtaThongTin
            // 
            this.dtaThongTin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtaThongTin.Location = new System.Drawing.Point(54, 142);
            this.dtaThongTin.Name = "dtaThongTin";
            this.dtaThongTin.Size = new System.Drawing.Size(658, 181);
            this.dtaThongTin.TabIndex = 0;
            // 
            // FrmSuaDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dtaThongTin);
            this.Name = "FrmSuaDiem";
            this.Text = "FrmSuaDiem";
            ((System.ComponentModel.ISupportInitialize)(this.dtaThongTin)).EndInit();
            this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.DataGridView dtaThongTin;
  }
}

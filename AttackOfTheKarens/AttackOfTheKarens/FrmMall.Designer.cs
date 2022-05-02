namespace AttackOfTheKarens {
  partial class FrmMall {
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
      this.components = new System.ComponentModel.Container();
      this.panMall = new System.Windows.Forms.Panel();
      this.tmrKarenSpawner = new System.Windows.Forms.Timer(this.components);
      this.tmrUpdateKarens = new System.Windows.Forms.Timer(this.components);
      this.tmrMoveOwner = new System.Windows.Forms.Timer(this.components);
      this.SuspendLayout();
      // 
      // panMall
      // 
      this.panMall.BackColor = System.Drawing.Color.Transparent;
      this.panMall.Location = new System.Drawing.Point(12, 12);
      this.panMall.Name = "panMall";
      this.panMall.Size = new System.Drawing.Size(561, 539);
      this.panMall.TabIndex = 0;
      // 
      // tmrKarenSpawner
      // 
      this.tmrKarenSpawner.Tick += new System.EventHandler(this.tmrKarenSpawner_Tick);
      // 
      // tmrUpdateKarens
      // 
      this.tmrUpdateKarens.Enabled = true;
      this.tmrUpdateKarens.Interval = 40;
      this.tmrUpdateKarens.Tick += new System.EventHandler(this.tmrUpdateKarens_Tick);
      // 
      // tmrMoveOwner
      // 
      this.tmrMoveOwner.Enabled = true;
      this.tmrMoveOwner.Interval = 120;
      this.tmrMoveOwner.Tick += new System.EventHandler(this.tmrMoveOwner_Tick);
      // 
      // FrmMall
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.Black;
      this.BackgroundImage = global::AttackOfTheKarens.Properties.Resources.mall_bg;
      this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.ClientSize = new System.Drawing.Size(984, 698);
      this.Controls.Add(this.panMall);
      this.Name = "FrmMall";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Attack of the Karens!!";
      this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmMall_FormClosed);
      this.Load += new System.EventHandler(this.FrmMall_Load);
      this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FrmMall_KeyUp);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Panel panMall;
    private System.Windows.Forms.Timer tmrKarenSpawner;
    private System.Windows.Forms.Timer tmrUpdateKarens;
    private System.Windows.Forms.Timer tmrMoveOwner;
  }
}

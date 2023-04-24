namespace Demo2
{
    partial class MainForm
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
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.createNewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.operatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.tinhLienThongToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.cayKhungToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.duyetDoThiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateToolStripMenuItem,
            this.operatorToolStripMenuItem,
            this.saveToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(972, 28);
			this.menuStrip1.TabIndex = 1;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// updateToolStripMenuItem
			// 
			this.updateToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createNewToolStripMenuItem});
			this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
			this.updateToolStripMenuItem.Size = new System.Drawing.Size(125, 24);
			this.updateToolStripMenuItem.Text = "Cập nhật đồ thị";
			// 
			// createNewToolStripMenuItem
			// 
			this.createNewToolStripMenuItem.Name = "createNewToolStripMenuItem";
			this.createNewToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
			this.createNewToolStripMenuItem.Text = "Tạo mới đồ thị";
			this.createNewToolStripMenuItem.Click += new System.EventHandler(this.createNewToolStripMenuItem_Click);
			// 
			// operatorToolStripMenuItem
			// 
			this.operatorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tinhLienThongToolStripMenuItem,
            this.cayKhungToolStripMenuItem,
            this.duyetDoThiToolStripMenuItem});
			this.operatorToolStripMenuItem.Name = "operatorToolStripMenuItem";
			this.operatorToolStripMenuItem.Size = new System.Drawing.Size(85, 24);
			this.operatorToolStripMenuItem.Text = "Tính toán";
			// 
			// tinhLienThongToolStripMenuItem
			// 
			this.tinhLienThongToolStripMenuItem.Name = "tinhLienThongToolStripMenuItem";
			this.tinhLienThongToolStripMenuItem.Size = new System.Drawing.Size(275, 26);
			this.tinhLienThongToolStripMenuItem.Text = "Kiểm tra số miền liên thông";
			this.tinhLienThongToolStripMenuItem.Click += new System.EventHandler(this.tinhLienThongToolStripMenuItem_Click);
			// 
			// cayKhungToolStripMenuItem
			// 
			this.cayKhungToolStripMenuItem.Name = "cayKhungToolStripMenuItem";
			this.cayKhungToolStripMenuItem.Size = new System.Drawing.Size(275, 26);
			this.cayKhungToolStripMenuItem.Text = "Cây khung tối thiểu";
			this.cayKhungToolStripMenuItem.Click += new System.EventHandler(this.cayKhungToolStripMenuItem_Click);
			// 
			// duyetDoThiToolStripMenuItem
			// 
			this.duyetDoThiToolStripMenuItem.Name = "duyetDoThiToolStripMenuItem";
			this.duyetDoThiToolStripMenuItem.Size = new System.Drawing.Size(275, 26);
			this.duyetDoThiToolStripMenuItem.Text = "Duyệt đồ thị";
			this.duyetDoThiToolStripMenuItem.Click += new System.EventHandler(this.duyetDoThiToolStripMenuItem_Click);
			// 
			// saveToolStripMenuItem
			// 
			this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
			this.saveToolStripMenuItem.Size = new System.Drawing.Size(67, 24);
			this.saveToolStripMenuItem.Text = "Lưu lại";
			this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(972, 649);
			this.Controls.Add(this.menuStrip1);
			this.IsMdiContainer = true;
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "MainForm";
			this.Text = "MainForm";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem updateToolStripMenuItem;
        private ToolStripMenuItem operatorToolStripMenuItem;
        private ToolStripMenuItem tinhLienThongToolStripMenuItem;
        private ToolStripMenuItem cayKhungToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem createNewToolStripMenuItem;
        private ToolStripMenuItem duyetDoThiToolStripMenuItem;
		private SaveFileDialog saveFileDialog1;
	}
}
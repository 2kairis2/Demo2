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
			menuStrip1 = new MenuStrip();
			updateToolStripMenuItem = new ToolStripMenuItem();
			createNewToolStripMenuItem = new ToolStripMenuItem();
			operatorToolStripMenuItem = new ToolStripMenuItem();
			tinhLienThongToolStripMenuItem = new ToolStripMenuItem();
			duyetDoThiToolStripMenuItem = new ToolStripMenuItem();
			eulerToolStripMenuItem = new ToolStripMenuItem();
			saveToolStripMenuItem = new ToolStripMenuItem();
			saveFileDialog1 = new SaveFileDialog();
			menuStrip1.SuspendLayout();
			SuspendLayout();
			// 
			// menuStrip1
			// 
			menuStrip1.ImageScalingSize = new Size(20, 20);
			menuStrip1.Items.AddRange(new ToolStripItem[] { updateToolStripMenuItem, operatorToolStripMenuItem, saveToolStripMenuItem });
			menuStrip1.Location = new Point(0, 0);
			menuStrip1.Name = "menuStrip1";
			menuStrip1.Size = new Size(972, 28);
			menuStrip1.TabIndex = 1;
			menuStrip1.Text = "menuStrip1";
			// 
			// updateToolStripMenuItem
			// 
			updateToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { createNewToolStripMenuItem });
			updateToolStripMenuItem.Name = "updateToolStripMenuItem";
			updateToolStripMenuItem.Size = new Size(125, 24);
			updateToolStripMenuItem.Text = "Cập nhật đồ thị";
			updateToolStripMenuItem.Click += updateToolStripMenuItem_Click;
			// 
			// createNewToolStripMenuItem
			// 
			createNewToolStripMenuItem.Name = "createNewToolStripMenuItem";
			createNewToolStripMenuItem.Size = new Size(224, 26);
			createNewToolStripMenuItem.Text = "Tạo mới đồ thị";
			createNewToolStripMenuItem.Click += createNewToolStripMenuItem_Click;
			// 
			// operatorToolStripMenuItem
			// 
			operatorToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { tinhLienThongToolStripMenuItem, duyetDoThiToolStripMenuItem, eulerToolStripMenuItem });
			operatorToolStripMenuItem.Name = "operatorToolStripMenuItem";
			operatorToolStripMenuItem.Size = new Size(85, 24);
			operatorToolStripMenuItem.Text = "Tính toán";
			// 
			// tinhLienThongToolStripMenuItem
			// 
			tinhLienThongToolStripMenuItem.Name = "tinhLienThongToolStripMenuItem";
			tinhLienThongToolStripMenuItem.Size = new Size(275, 26);
			tinhLienThongToolStripMenuItem.Text = "Kiểm tra số miền liên thông";
			tinhLienThongToolStripMenuItem.Click += tinhLienThongToolStripMenuItem_Click;
			// 
			// duyetDoThiToolStripMenuItem
			// 
			duyetDoThiToolStripMenuItem.Name = "duyetDoThiToolStripMenuItem";
			duyetDoThiToolStripMenuItem.Size = new Size(275, 26);
			duyetDoThiToolStripMenuItem.Text = "Duyệt đồ thị";
			duyetDoThiToolStripMenuItem.Click += duyetDoThiToolStripMenuItem_Click;
			// 
			// eulerToolStripMenuItem
			// 
			eulerToolStripMenuItem.Name = "eulerToolStripMenuItem";
			eulerToolStripMenuItem.Size = new Size(275, 26);
			eulerToolStripMenuItem.Text = "Euler";
			eulerToolStripMenuItem.Click += eulerToolStripMenuItem_Click;
			// 
			// saveToolStripMenuItem
			// 
			saveToolStripMenuItem.Name = "saveToolStripMenuItem";
			saveToolStripMenuItem.Size = new Size(67, 24);
			saveToolStripMenuItem.Text = "Lưu lại";
			saveToolStripMenuItem.Click += saveToolStripMenuItem_Click;
			// 
			// MainForm
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(972, 649);
			Controls.Add(menuStrip1);
			IsMdiContainer = true;
			MainMenuStrip = menuStrip1;
			Name = "MainForm";
			Text = "MainForm";
			menuStrip1.ResumeLayout(false);
			menuStrip1.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private MenuStrip menuStrip1;
		private ToolStripMenuItem updateToolStripMenuItem;
		private ToolStripMenuItem operatorToolStripMenuItem;
		private ToolStripMenuItem tinhLienThongToolStripMenuItem;
		private ToolStripMenuItem saveToolStripMenuItem;
		private ToolStripMenuItem createNewToolStripMenuItem;
		private ToolStripMenuItem duyetDoThiToolStripMenuItem;
		private SaveFileDialog saveFileDialog1;
		private ToolStripMenuItem eulerToolStripMenuItem;
	}
}
namespace Demo2
{
	partial class DrawForm
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			myPanel = new Panel();
			btnSave = new Button();
			btnExit = new Button();
			SuspendLayout();
			// 
			// myPanel
			// 
			myPanel.BackColor = SystemColors.ButtonHighlight;
			myPanel.Location = new Point(7, 6);
			myPanel.Name = "myPanel";
			myPanel.Size = new Size(675, 435);
			myPanel.TabIndex = 0;
			myPanel.Paint += myPanel_Paint;
			myPanel.MouseClick += myPanel_MouseClick;
			myPanel.MouseDown += myPanel_MouseDown;
			myPanel.MouseMove += myPanel_MouseMove;
			myPanel.MouseUp += myPanel_MouseUp;
			// 
			// btnSave
			// 
			btnSave.FlatStyle = FlatStyle.System;
			btnSave.Location = new Point(702, 107);
			btnSave.Name = "btnSave";
			btnSave.Size = new Size(94, 29);
			btnSave.TabIndex = 0;
			btnSave.Text = "Cập nhật";
			btnSave.UseVisualStyleBackColor = true;
			btnSave.Click += btnSave_Click;
			// 
			// btnExit
			// 
			btnExit.Location = new Point(702, 189);
			btnExit.Name = "btnExit";
			btnExit.Size = new Size(94, 29);
			btnExit.TabIndex = 1;
			btnExit.Text = "Thoát";
			btnExit.UseVisualStyleBackColor = true;
			btnExit.Click += btnExit_Click;
			// 
			// DrawForm
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(820, 457);
			Controls.Add(btnExit);
			Controls.Add(btnSave);
			Controls.Add(myPanel);
			Name = "DrawForm";
			Text = "Draw Form";
			Load += DrawForm_Load;
			ResumeLayout(false);
		}

		#endregion

		private Panel myPanel;
		private Button btnSave;
		private Button btnExit;
	}
}
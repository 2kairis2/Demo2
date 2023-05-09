using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Windows.Forms.VisualStyles;
using static Demo2.Graph;

namespace Demo2
{
	public partial class MainForm : Form
	{
		public Graph graph;
		DrawForm dform;

		public MainForm()
		{
			InitializeComponent();
		}

		private void createNewToolStripMenuItem_Click(object sender, EventArgs e)
		{
			dform = new DrawForm();
			dform.MdiParent = this;
			dform.Show();
		}

		private void duyetDoThiToolStripMenuItem_Click(object sender, EventArgs e)
		{

			if (graph == null || graph.n <= 0)
				return;

			string inputString = "";

			//Tạo một MessageBox tùy chỉnh với một TextBox để nhập dữ liệu

			if (MessageBox.Show("Vui lòng nhập nút khởi đầu: ", "Input Box", MessageBoxButtons.OKCancel) == DialogResult.OK)
			{
				TextBox textBox = new TextBox();
				Form inputForm = new Form();
				inputForm.Text = "Nhập nút bắt đầu: ";
				inputForm.Height = 100;
				inputForm.Width = 400;
				inputForm.StartPosition = FormStartPosition.CenterScreen;
				textBox.Parent = inputForm;
				textBox.Location = new Point(20, 20);
				Button okButton = new Button();
				okButton.Parent = inputForm;
				okButton.Text = "OK";
				okButton.DialogResult = DialogResult.OK;
				okButton.Location = new Point(50, 50);
				Button cancelButton = new Button();
				cancelButton.Parent = inputForm;
				cancelButton.Text = "Cancel";
				cancelButton.DialogResult = DialogResult.Cancel;
				cancelButton.Location = new Point(130, 50);
				inputForm.AcceptButton = okButton;
				inputForm.CancelButton = cancelButton;

				//Hiển thị MessageBox tùy chỉnh và lấy giá trị được nhập vào nếu người dùng nhấn OK
				if (inputForm.ShowDialog() == DialogResult.OK)
				{
					inputString = textBox.Text;
				}
			}


			//Kiểm tra xem người dùng đã nhập chuỗi hay chưa
			if (inputString != "")
			{
				int inputNode = -1;
				try
				{
					inputNode = int.Parse(inputString);
				}
				catch (Exception ex)
				{
					MessageBox.Show("Giá trị nhập không đúng!");
				}

				if (inputNode < 0 || inputNode > this.graph.n)
					MessageBox.Show("Giá trị node bị lỗi!");

				List<int> result = this.graph.dfs(inputNode);

				string result_dfs = "";
				for (int i = 0; i < result.Count; i++)
					result_dfs += result[i].ToString() + " ";


				MessageBox.Show(result_dfs);
			}

		}

		private void tinhLienThongToolStripMenuItem_Click(object sender, EventArgs e)
		{
			bool[] visted = new bool[this.graph.n + 1];
			int num = 0;

			for (int i = 1; i <= this.graph.n; i++)
				visted[i] = false;

			for (int i = 1; i <= this.graph.n; i++)
			{
				if (!visted[i])
				{
					num++;
					List<int> dfs_resut = this.graph.dfs(i);

					foreach (int node in dfs_resut)
						visted[node] = true;
				}
			}

			MessageBox.Show("Số miền liên thông là : " + num.ToString());
		}

		private void cayKhungToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}

		private void saveToolStripMenuItem_Click(object sender, EventArgs e)
		{

			// Hiển thị hộp thoại SaveFileDialog
			SaveFileDialog saveFileDialog1 = new SaveFileDialog();
			saveFileDialog1.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
			saveFileDialog1.ShowDialog();

			// Nếu người dùng chọn OK và tên file không rỗng
			if (saveFileDialog1.ShowDialog() == DialogResult.OK && saveFileDialog1.FileName != "")
			{
				// Mở file để ghi
				StreamWriter sw = new StreamWriter(saveFileDialog1.FileName);
				List<Edge> edges = dform.edges;

				// Ghi dữ liệu vào file
				foreach (Edge edge in edges)
				{
					sw.Write(edge.StartNode.Label + " " + edge.EndNode.Label + '\n');
				}

				// Đóng file
				sw.Close();

				MessageBox.Show("File đã được lưu.");
			}


		}

		private void updateToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}

		private void eulerToolStripMenuItem_Click(object sender, EventArgs e)
		{


			if (graph == null || graph.n <= 0)
				return;
			
				List<int> eulerCycle = this.graph.Fleury(1);

				if (eulerCycle == null)
				{
					MessageBox.Show("Không tồn tại chu trình Euler!");
					return;
				}

				string cycleString = "";
				foreach (int node in eulerCycle)
					cycleString += node.ToString() + " ";

				MessageBox.Show("Chu trình Euler: " + cycleString);

			

		}






	}
}

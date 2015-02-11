using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace GraphicalCS
{
	/// <summary>
	/// </summary>
	public class CircleForm : System.Windows.Forms.Form
	{
		internal System.Windows.Forms.Label lblCx;
		internal System.Windows.Forms.Label lblCy;
		internal System.Windows.Forms.Label lblR;
		private System.Windows.Forms.Button btnSubmit;
		private System.Windows.Forms.Button btnCancle;
		private Point start;
		private Point end;
		private float angle1;
		private float angle2;
		private bool boolvalue;
		internal System.Windows.Forms.TextBox CircleX;
		internal System.Windows.Forms.TextBox CircleY;
		internal System.Windows.Forms.TextBox CircleRadius;
		private System.Windows.Forms.Label AngleStart;
		private System.Windows.Forms.Label AngleEnd;
		private System.Windows.Forms.TextBox StartA;
		private System.Windows.Forms.TextBox LastA;

		public Point startP
		{
			get
			{
				return start;
			}
		}

		public Point endP
		{
			get
			{
				return end;
			}
		}

		public float FirstAngle
		{
			get
			{
				return angle1;
			}
		}
		public float EndAngle
		{
			get
			{
				return angle2;
			}
		}
		public bool cancle
		{
			get
			{
				return boolvalue;
			}
		}
		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.Container components = null;

		public CircleForm()
		{
			//
			// Windows 窗体设计器支持所必需的
			//
			InitializeComponent();

			//
			// TODO: 在 InitializeComponent 调用后添加任何构造函数代码
			//
		}

		/// <summary>
		/// 清理所有正在使用的资源。
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows 窗体设计器生成的代码
		/// <summary>
		/// 设计器支持所需的方法 - 不要使用代码编辑器修改
		/// 此方法的内容。
		/// </summary>
		private void InitializeComponent()
		{
			this.lblCx = new System.Windows.Forms.Label();
			this.lblCy = new System.Windows.Forms.Label();
			this.lblR = new System.Windows.Forms.Label();
			this.CircleX = new System.Windows.Forms.TextBox();
			this.CircleY = new System.Windows.Forms.TextBox();
			this.CircleRadius = new System.Windows.Forms.TextBox();
			this.btnSubmit = new System.Windows.Forms.Button();
			this.btnCancle = new System.Windows.Forms.Button();
			this.AngleStart = new System.Windows.Forms.Label();
			this.AngleEnd = new System.Windows.Forms.Label();
			this.StartA = new System.Windows.Forms.TextBox();
			this.LastA = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// lblCx
			// 
			this.lblCx.Location = new System.Drawing.Point(24, 16);
			this.lblCx.Name = "lblCx";
			this.lblCx.Size = new System.Drawing.Size(67, 17);
			this.lblCx.TabIndex = 5;
			this.lblCx.Text = "Center X";
			this.lblCx.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblCy
			// 
			this.lblCy.Location = new System.Drawing.Point(24, 48);
			this.lblCy.Name = "lblCy";
			this.lblCy.Size = new System.Drawing.Size(67, 17);
			this.lblCy.TabIndex = 7;
			this.lblCy.Text = "Center Y";
			this.lblCy.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblR
			// 
			this.lblR.Location = new System.Drawing.Point(24, 80);
			this.lblR.Name = "lblR";
			this.lblR.Size = new System.Drawing.Size(67, 17);
			this.lblR.TabIndex = 9;
			this.lblR.Text = "Radius";
			this.lblR.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// CircleX
			// 
			this.CircleX.Location = new System.Drawing.Point(120, 16);
			this.CircleX.Name = "CircleX";
			this.CircleX.Size = new System.Drawing.Size(48, 21);
			this.CircleX.TabIndex = 10;
			this.CircleX.Text = "0";
			this.CircleX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CircleX_KeyPress);
			// 
			// CircleY
			// 
			this.CircleY.Location = new System.Drawing.Point(120, 48);
			this.CircleY.Name = "CircleY";
			this.CircleY.Size = new System.Drawing.Size(48, 21);
			this.CircleY.TabIndex = 11;
			this.CircleY.Text = "0";
			this.CircleY.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CircleY_KeyPress);
			// 
			// CircleRadius
			// 
			this.CircleRadius.Location = new System.Drawing.Point(120, 80);
			this.CircleRadius.Name = "CircleRadius";
			this.CircleRadius.Size = new System.Drawing.Size(48, 21);
			this.CircleRadius.TabIndex = 12;
			this.CircleRadius.Text = "0";
			this.CircleRadius.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CircleRadius_KeyPress);
			// 
			// btnSubmit
			// 
			this.btnSubmit.Location = new System.Drawing.Point(192, 56);
			this.btnSubmit.Name = "btnSubmit";
			this.btnSubmit.TabIndex = 13;
			this.btnSubmit.Text = "Submit";
			this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
			// 
			// btnCancle
			// 
			this.btnCancle.Location = new System.Drawing.Point(192, 104);
			this.btnCancle.Name = "btnCancle";
			this.btnCancle.TabIndex = 14;
			this.btnCancle.Text = "Cancle";
			this.btnCancle.Click += new System.EventHandler(this.btnCancle_Click);
			// 
			// AngleStart
			// 
			this.AngleStart.Location = new System.Drawing.Point(24, 112);
			this.AngleStart.Name = "AngleStart";
			this.AngleStart.Size = new System.Drawing.Size(67, 17);
			this.AngleStart.TabIndex = 15;
			this.AngleStart.Text = "AngleX";
			// 
			// AngleEnd
			// 
			this.AngleEnd.Location = new System.Drawing.Point(24, 144);
			this.AngleEnd.Name = "AngleEnd";
			this.AngleEnd.Size = new System.Drawing.Size(67, 17);
			this.AngleEnd.TabIndex = 16;
			this.AngleEnd.Text = "AngleLast";
			// 
			// StartA
			// 
			this.StartA.Location = new System.Drawing.Point(120, 112);
			this.StartA.Name = "StartA";
			this.StartA.Size = new System.Drawing.Size(48, 21);
			this.StartA.TabIndex = 17;
			this.StartA.Text = "0";
			this.StartA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.StartA_KeyPress);
			// 
			// LastA
			// 
			this.LastA.Location = new System.Drawing.Point(120, 144);
			this.LastA.Name = "LastA";
			this.LastA.Size = new System.Drawing.Size(48, 21);
			this.LastA.TabIndex = 18;
			this.LastA.Text = "0";
			this.LastA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.LastA_KeyPress);
			// 
			// CircleForm
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(304, 182);
			this.Controls.Add(this.LastA);
			this.Controls.Add(this.StartA);
			this.Controls.Add(this.AngleEnd);
			this.Controls.Add(this.AngleStart);
			this.Controls.Add(this.btnCancle);
			this.Controls.Add(this.btnSubmit);
			this.Controls.Add(this.CircleRadius);
			this.Controls.Add(this.CircleY);
			this.Controls.Add(this.CircleX);
			this.Controls.Add(this.lblR);
			this.Controls.Add(this.lblCy);
			this.Controls.Add(this.lblCx);
			this.Name = "CircleForm";
			this.Text = "CircleForm";
			this.ResumeLayout(false);

		}
		#endregion

		private void btnSubmit_Click(object sender, System.EventArgs e)
		{
			boolvalue = false;
			start.X =	Convert.ToInt32(this.CircleX.Text);
			start.Y = Convert.ToInt32(this.CircleY.Text);
			end.X = Convert.ToInt32(this.CircleX.Text) + Convert.ToInt32(this.CircleRadius.Text);
			end.Y = start.Y;
			if((start.X==end.X)&&(end.Y==end.Y))
				end.Y += 1;
			angle1 = Convert.ToSingle(this.StartA.Text);
			angle2 = Convert.ToSingle(this.LastA.Text);
			this.Hide();
		}

		private void btnCancle_Click(object sender, System.EventArgs e)
		{
			boolvalue = true;
			this.Hide();
		}

		private void CircleX_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			if((e.KeyChar<48||e.KeyChar>57)&&e.KeyChar!=8)
				e.Handled = true;
		}

		private void CircleY_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			if((e.KeyChar<48||e.KeyChar>57)&&e.KeyChar!=8)
				e.Handled = true;
		}

		private void CircleRadius_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			if((e.KeyChar<48||e.KeyChar>57)&&e.KeyChar!=8)
				e.Handled = true;
		}

		private void StartA_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			if((e.KeyChar<48||e.KeyChar>57)&&e.KeyChar!=8)
				e.Handled = true;
		}

		private void LastA_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			if((e.KeyChar<48||e.KeyChar>57)&&e.KeyChar!=8)
				e.Handled = true;
		}	
	}
}

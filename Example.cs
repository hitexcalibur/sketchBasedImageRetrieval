using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace GraphicalCS
{
	/// <summary>
	/// Beziers 的摘要说明。
	/// </summary>
	public class Example : System.Windows.Forms.Form
	{
		private System.Windows.Forms.PictureBox BeziersBox;
		private MousePoint newPoint;
		private System.Windows.Forms.MainMenu beziersMenu;
		private System.Windows.Forms.MenuItem menuItem1;
		private System.Windows.Forms.ContextMenu contextMenu;
		private System.Windows.Forms.MenuItem Line;
		private System.Windows.Forms.MenuItem Rectangle;
		private System.Windows.Forms.MenuItem Bezier;
		private System.Windows.Forms.MenuItem sp;
		private System.Windows.Forms.MenuItem Exit;
		private System.Windows.Forms.MenuItem Style;
		private System.Windows.Forms.MenuItem Change;
		private System.Windows.Forms.MenuItem Finish;
		private System.Windows.Forms.MenuItem Clear;
		private MainWindow.ImageType newType;
		private System.Windows.Forms.MenuItem AddPoint;
		private System.Windows.Forms.MenuItem Dash;
		private System.Windows.Forms.MenuItem DashDot;
		private System.Windows.Forms.MenuItem DashDotDot;
		private System.Windows.Forms.MenuItem Dot;
		private System.Windows.Forms.MenuItem Solid;
		private System.Windows.Forms.MenuItem FiveStar;
		private System.Windows.Forms.MenuItem LineCap;
		private System.Drawing.Drawing2D.LineCap scap;
		private System.Drawing.Drawing2D.LineCap ecap;
		private System.Windows.Forms.MenuItem PrintScreen;
		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Example()
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
			this.BeziersBox = new System.Windows.Forms.PictureBox();
			this.contextMenu = new System.Windows.Forms.ContextMenu();
			this.Style = new System.Windows.Forms.MenuItem();
			this.Dash = new System.Windows.Forms.MenuItem();
			this.DashDot = new System.Windows.Forms.MenuItem();
			this.DashDotDot = new System.Windows.Forms.MenuItem();
			this.Dot = new System.Windows.Forms.MenuItem();
			this.Solid = new System.Windows.Forms.MenuItem();
			this.LineCap = new System.Windows.Forms.MenuItem();
			this.Change = new System.Windows.Forms.MenuItem();
			this.Finish = new System.Windows.Forms.MenuItem();
			this.AddPoint = new System.Windows.Forms.MenuItem();
			this.Clear = new System.Windows.Forms.MenuItem();
			this.PrintScreen = new System.Windows.Forms.MenuItem();
			this.beziersMenu = new System.Windows.Forms.MainMenu();
			this.menuItem1 = new System.Windows.Forms.MenuItem();
			this.Line = new System.Windows.Forms.MenuItem();
			this.Rectangle = new System.Windows.Forms.MenuItem();
			this.FiveStar = new System.Windows.Forms.MenuItem();
			this.Bezier = new System.Windows.Forms.MenuItem();
			this.sp = new System.Windows.Forms.MenuItem();
			this.Exit = new System.Windows.Forms.MenuItem();
			this.SuspendLayout();
			// 
			// BeziersBox
			// 
			this.BeziersBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.BeziersBox.ContextMenu = this.contextMenu;
			this.BeziersBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.BeziersBox.Location = new System.Drawing.Point(0, 0);
			this.BeziersBox.Name = "BeziersBox";
			this.BeziersBox.Size = new System.Drawing.Size(640, 302);
			this.BeziersBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.BeziersBox.TabIndex = 0;
			this.BeziersBox.TabStop = false;
			this.BeziersBox.Paint += new System.Windows.Forms.PaintEventHandler(this.BeziersBox_Paint);
			this.BeziersBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BeziersBox_MouseUp);
			this.BeziersBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BeziersBox_MouseMove);
			this.BeziersBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BeziersBox_MouseDown);
			// 
			// contextMenu
			// 
			this.contextMenu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																						this.Style,
																						this.Change,
																						this.Finish,
																						this.AddPoint,
																						this.Clear,
																						this.PrintScreen});
			// 
			// Style
			// 
			this.Style.Index = 0;
			this.Style.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																				  this.Dash,
																				  this.DashDot,
																				  this.DashDotDot,
																				  this.Dot,
																				  this.Solid,
																				  this.LineCap});
			this.Style.Text = "Line &Style";
			// 
			// Dash
			// 
			this.Dash.Index = 0;
			this.Dash.Text = "&Dash";
			this.Dash.Click += new System.EventHandler(this.Dash_Click);
			// 
			// DashDot
			// 
			this.DashDot.Index = 1;
			this.DashDot.Text = "DashDo&t";
			this.DashDot.Click += new System.EventHandler(this.DashDot_Click);
			// 
			// DashDotDot
			// 
			this.DashDotDot.Index = 2;
			this.DashDotDot.Text = "DashD&otDot";
			this.DashDotDot.Click += new System.EventHandler(this.DashDotDot_Click);
			// 
			// Dot
			// 
			this.Dot.Index = 3;
			this.Dot.Text = "Dot";
			this.Dot.Click += new System.EventHandler(this.Dot_Click);
			// 
			// Solid
			// 
			this.Solid.Index = 4;
			this.Solid.Text = "&Solid";
			this.Solid.Click += new System.EventHandler(this.Solid_Click);
			// 
			// LineCap
			// 
			this.LineCap.Index = 5;
			this.LineCap.Text = "&LineCap";
			this.LineCap.Click += new System.EventHandler(this.LineCap_Click);
			// 
			// Change
			// 
			this.Change.Index = 1;
			this.Change.Text = "&Change";
			this.Change.Click += new System.EventHandler(this.Change_Click);
			// 
			// Finish
			// 
			this.Finish.Index = 2;
			this.Finish.Text = "&Finish";
			this.Finish.Click += new System.EventHandler(this.Finish_Click);
			// 
			// AddPoint
			// 
			this.AddPoint.Index = 3;
			this.AddPoint.Text = "&Add";
			this.AddPoint.Click += new System.EventHandler(this.AddPoint_Click);
			// 
			// Clear
			// 
			this.Clear.Index = 4;
			this.Clear.Text = "&Clear";
			this.Clear.Click += new System.EventHandler(this.Clear_Click);
			// 
			// PrintScreen
			// 
			this.PrintScreen.Index = 5;
			this.PrintScreen.Text = "&PrintScreen";
			this.PrintScreen.Click += new System.EventHandler(this.PrintScreen_Click);
			// 
			// beziersMenu
			// 
			this.beziersMenu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																						this.menuItem1});
			// 
			// menuItem1
			// 
			this.menuItem1.Index = 0;
			this.menuItem1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.Line,
																					  this.Rectangle,
																					  this.FiveStar,
																					  this.Bezier,
																					  this.sp,
																					  this.Exit});
			this.menuItem1.Text = "&Function";
			// 
			// Line
			// 
			this.Line.Index = 0;
			this.Line.Text = "&Line";
			this.Line.Click += new System.EventHandler(this.Line_Click);
			// 
			// Rectangle
			// 
			this.Rectangle.Index = 1;
			this.Rectangle.Text = "&Rectangle";
			this.Rectangle.Click += new System.EventHandler(this.Rectangle_Click);
			// 
			// FiveStar
			// 
			this.FiveStar.Index = 2;
			this.FiveStar.Text = "&FiveStar";
			this.FiveStar.Click += new System.EventHandler(this.FiveStar_Click);
			// 
			// Bezier
			// 
			this.Bezier.Index = 3;
			this.Bezier.Text = "&Beziers";
			this.Bezier.Click += new System.EventHandler(this.Bezier_Click);
			// 
			// sp
			// 
			this.sp.Index = 4;
			this.sp.Text = "-";
			// 
			// Exit
			// 
			this.Exit.Index = 5;
			this.Exit.Text = "&Exit";
			this.Exit.Click += new System.EventHandler(this.Exit_Click);
			// 
			// Example
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(640, 302);
			this.Controls.Add(this.BeziersBox);
			this.Menu = this.beziersMenu;
			this.Name = "Example";
			this.Text = "Example";
			this.ResumeLayout(false);

		}
		#endregion
		#region Beziers
		DShapeList beziersList = new DShapeList();
		DShapeList pointList = new DShapeList();
		PointCollection tpointCollection = new PointCollection();
		PointCollection pointCollection = new PointCollection();
		NewRegion regionCollection = new NewRegion();
		int beziersPoint;
		int BezierIndex;
		Number pointNumber = new Number();
		Number pointSum = new Number();
		bool pointChange = false;
		#endregion
		DashStyle style;
		Pen stylePen = new Pen(Color.DarkRed);
		DShapeList drawingList = new DShapeList();
		Point[] star = new Point[10];
		int starCount = 0;
		DShapeList tempPoint = new DShapeList();

		private void BeziersBox_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			if (e.Button != MouseButtons.Left)
				return;
			newPoint = new MousePoint(e.X, e.Y);
			switch(newType)
			{
				case MainWindow.ImageType.CircleAt:
					star[starCount++] = newPoint.StartP;
					tempPoint.Add(new DPoint(new Point[]{newPoint.StartP}, Color.DarkRed,1));
					BeziersBox.Invalidate();
					break;
				case MainWindow.ImageType.Beziers:
					tpointCollection.Add(newPoint.StartP);
					newPoint.StartP.Offset(-2,-2);
					Rectangle r = new Rectangle(newPoint.StartP,new Size(4,4));
					Region rr = new Region(r);
					regionCollection.Add(rr);
					Point startp2 = newPoint.StartP;
					startp2.Offset(4,4);
					pointList.Add(new DHollowRectangle(new Point[]{newPoint.StartP,startp2},Color.DarkRed,1));
					BeziersBox.Invalidate();
					break;
				case MainWindow.ImageType.Set:
					for(int i=0;i<regionCollection.Count;i++)
					{
						if(regionCollection[i].IsVisible(newPoint.StartP))
						{
							newPoint = new MousePoint(e.X,e.Y);
							beziersPoint = i;
							BezierIndex = Found(i);
							pointChange = true;
							break;
						}
					}
					break;
			}
		}

		private void BeziersBox_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			if (e.Button != MouseButtons.Left)
				return;
			newPoint.EndX = e.X;
			newPoint.EndY = e.Y;
			switch(newType)
			{
				case MainWindow.ImageType.Set:	
					if(pointChange ==false)
						return;
					newPoint.EndP.Offset(-2,-2);
					Rectangle r = new Rectangle(newPoint.EndP,new Size(4,4));
					Region rr = new Region(r);
					regionCollection[beziersPoint]=rr;
					pointCollection[beziersPoint]=newPoint.EndP;
					Point[] p = MakePoints();
					Point endp2 = newPoint.StartP;
					endp2.Offset(4,4);
					pointList[beziersPoint] = new DHollowRectangle(new Point[]{newPoint.EndP,endp2},Color.DarkRed, 1);
					beziersList[BezierIndex] = new DBeziers(p,Color.Black,1);
					break;
			}
			BeziersBox.Invalidate();
		}

		private void BeziersBox_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			switch(newType)
			{
				case MainWindow.ImageType.Line:
					drawingList.Add(new DPLine(newPoint.StartP,newPoint.EndP,Color.Black,style,scap,ecap));
					break;
				case MainWindow.ImageType.Rectangle:
					drawingList.Add(new DPRectangle(newPoint.Rect,Color.Blue,style));
					break;
				case MainWindow.ImageType.CircleAt:
					if(starCount ==10)
					{
						pointChange = true;
						starCount=0;
						tempPoint = new DShapeList();
					}
					break;
				case MainWindow.ImageType.Set:
					pointChange = false;
					break;
			}
			BeziersBox.Invalidate();
		}

		private void BeziersBox_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
		{
			Graphics g = e.Graphics;
			switch(newType)
			{
				case MainWindow.ImageType.Line:
					g.DrawLine(stylePen,newPoint.StartP,newPoint.EndP);
					break;
				case MainWindow.ImageType.Rectangle:
					g.DrawRectangle(stylePen,newPoint.Rect);
					break;
				case MainWindow.ImageType.CircleAt:
					tempPoint.DrawList(g);
					if(starCount == 0&&pointChange==true)
					{
						GraphicsPath path = new GraphicsPath();
						path.AddLines(star);
						PathGradientBrush pthGrBrush = new PathGradientBrush(path);
						pthGrBrush.CenterColor = Color.FromArgb(255, 255, 0, 0);
						Color[] colors = {
											 Color.FromArgb(255, 0, 0, 0),
											 Color.FromArgb(255, 0, 255, 0),
											 Color.FromArgb(255, 0, 0, 255), 
											 Color.FromArgb(255, 255, 255, 255),
											 Color.FromArgb(255, 0, 0, 0),
											 Color.FromArgb(255, 0, 255, 0),
											 Color.FromArgb(255, 0, 0, 255),
											 Color.FromArgb(255, 255, 255, 255),
											 Color.FromArgb(255, 0, 0, 0),  
											 Color.FromArgb(255, 0, 255, 0)};
						pthGrBrush.SurroundColors = colors;
						e.Graphics.FillPath(pthGrBrush, path);
					}
					break;
				case MainWindow.ImageType.Beziers:
					Rectangle r = new Rectangle(newPoint.StartP,new Size(4,4));
					g.DrawRectangle(new Pen(Color.DarkRed),r);
					break;
			}			
			drawingList.DrawList(g);
			pointList.DrawList(g);
			beziersList.DrawList(g);
		}

		private void Line_Click(object sender, System.EventArgs e)
		{
			newType = MainWindow.ImageType.Line;
		}

		private void Rectangle_Click(object sender, System.EventArgs e)
		{
			newType = MainWindow.ImageType.Rectangle;
		}

		private void FiveStar_Click(object sender, System.EventArgs e)
		{
			newType = MainWindow.ImageType.CircleAt;
		}

		private void Bezier_Click(object sender, System.EventArgs e)
		{
			newType = MainWindow.ImageType.Beziers;
		}

		private void Exit_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void Finish_Click(object sender, System.EventArgs e)
		{
			if(newType != MainWindow.ImageType.Beziers)
				return;
			if((tpointCollection.Count%3)!=1 || (tpointCollection.Count==1))
			{
				MessageBox.Show("Please input points%3 = 1");
				return;
			}
			pointNumber.Add(tpointCollection.Count);
			Point[] point = new Point[tpointCollection.Count];
			int i = 0;
			foreach(Point newP in tpointCollection)
			{
				point[i++]=newP;
			}
			beziersList.Add(new DBeziers(point,Color.Black,1));
			BeziersBox.Invalidate();
			pointCollection.AddRange(point);
			pointSum.Add(pointCollection.Count);
			tpointCollection.RemoveRange(0,tpointCollection.Count);
		}

		private void Clear_Click(object sender, System.EventArgs e)
		{
			beziersList = new DShapeList();
			pointList = new DShapeList();
			tpointCollection = new PointCollection();
			pointCollection = new PointCollection();
			regionCollection = new NewRegion();
			beziersPoint = 0;
			BezierIndex = 0;
			pointNumber = new Number();
			pointSum = new Number();
			drawingList = new DShapeList();
			pointChange = false;
			star = new Point[10];
			starCount = 0;
			tempPoint = new DShapeList();
			newType = MainWindow.ImageType.Empty;
			this.BeziersBox.Image=null;
			BeziersBox.Invalidate();
		}

		private void Change_Click(object sender, System.EventArgs e)
		{
			newType = MainWindow.ImageType.Set;
		}

		private int Found(int i)
		{
			int j;
			for(j=0;j<pointSum.Count;j++)
			{
				if(i<pointSum[j])
					break;
			}
			return j;
		}

		private Point[] MakePoints()
		{
			int start;
			int count;
			count = pointNumber[BezierIndex];
			Point[] npoint = new Point[count];
			if(BezierIndex ==0)
				start = 0;
			else
				start = pointSum[BezierIndex-1];
			for(int k=0;k<count;k++)
			{
				npoint[k]=pointCollection[start++];
			}
			return npoint;
		}

		private void AddPoint_Click(object sender, System.EventArgs e)
		{
			newType = MainWindow.ImageType.Beziers;
		}

		private void Dash_Click(object sender, System.EventArgs e)
		{
			style = DashStyle.Dash;
			stylePen.DashStyle = DashStyle.Dash;
		}

		private void DashDot_Click(object sender, System.EventArgs e)
		{
			style = DashStyle.DashDot;
			stylePen.DashStyle  = DashStyle.DashDot;
		}

		private void DashDotDot_Click(object sender, System.EventArgs e)
		{
			style = DashStyle.DashDotDot;
			stylePen.DashStyle = DashStyle.DashDotDot;
		}

		private void Dot_Click(object sender, System.EventArgs e)
		{
			style = DashStyle.Dot;
			stylePen.DashStyle = DashStyle.Dot;
		}

		private void Solid_Click(object sender, System.EventArgs e)
		{
			style = DashStyle.Solid;
			stylePen.DashStyle = DashStyle.Solid;
		}

		private void LineCap_Click(object sender, System.EventArgs e)
		{
			stylePen.EndCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;
			stylePen.StartCap = System.Drawing.Drawing2D.LineCap.RoundAnchor;
			ecap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;
			scap = System.Drawing.Drawing2D.LineCap.RoundAnchor;
		}

		private void PrintScreen_Click(object sender, System.EventArgs e)
		{
			SavePic s = new SavePic();
			this.BeziersBox.Image = s.newImage;
		}
	}
}
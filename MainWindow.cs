using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Drawing.Drawing2D;
using System.IO;
using System.Drawing.Imaging;

namespace GraphicalCS
{
	/// <summary>
	/// Summary description for MainWindow.
	/// </summary>
	public class MainWindow : System.Windows.Forms.Form
	{
		internal System.Windows.Forms.Button AddFilledRectangle;
		internal System.Windows.Forms.Button AddHollowRectangle;
		internal System.Windows.Forms.Button AddPoint;
		internal System.Windows.Forms.PictureBox Drawing;
		private System.Windows.Forms.Button AddLine;
		internal System.Windows.Forms.Button AddHollowEllipse;
		internal System.Windows.Forms.Button AddFilledEllipse;
		private System.Windows.Forms.Button AddCircle;
		private System.Windows.Forms.Button AddFillCircle;
		private System.Windows.Forms.Button AddPath;
		private System.Windows.Forms.Button btnEraser;
		private System.Windows.Forms.GroupBox grpTool;
        private System.Windows.Forms.MainMenu mainMenu;
		private System.Windows.Forms.MenuItem menuItemEs;
		private System.Windows.Forms.MenuItem menuItemSize1;
		private System.Windows.Forms.MenuItem menuItemmenuItemSize2;
		private System.Windows.Forms.MenuItem menuItemSize3;
		private System.Windows.Forms.ContextMenu cntMenu;
		private System.Windows.Forms.Button btnText;
        private System.Windows.Forms.MenuItem menuItemCA;
		private System.Windows.Forms.StatusBar statusBar;
		private System.Windows.Forms.StatusBarPanel statusBarImageType;
		private System.Windows.Forms.StatusBarPanel statusBarPoint;
		private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
		private System.Windows.Forms.MenuItem menuItemClose;

		private System.Windows.Forms.Button Black;
		private System.Windows.Forms.Button White;
		private System.Windows.Forms.Button Red;
		private System.Windows.Forms.Button blue;
		private System.Windows.Forms.Button Yellow;
		private System.Windows.Forms.Button Cyan;
		private System.Windows.Forms.Button Magenta;
		private System.Windows.Forms.Button LawnGreen;
		private System.Windows.Forms.Button btnColor;
		private System.Windows.Forms.Button MoreColor;
		private System.Windows.Forms.GroupBox ColorBox;
        private System.Windows.Forms.ColorDialog colorDialog;
		private System.Windows.Forms.ContextMenu Curvecontext;
		private System.Windows.Forms.MenuItem Curve;
		private System.Windows.Forms.MenuItem ClosedCurve;
        private System.Windows.Forms.MenuItem menuItemLw;
		private System.Windows.Forms.MenuItem Advance;
		private System.Windows.Forms.MenuItem FadeInOut;
		private System.Windows.Forms.MenuItem GrayScale;
		private System.Windows.Forms.MenuItem GrayScale1;
		private System.Windows.Forms.MenuItem GrayScale2;
		private System.Windows.Forms.MenuItem grayScale3;
		private System.Windows.Forms.MenuItem GrayScale4;
		private System.Windows.Forms.MenuItem Inverse;
		private System.Windows.Forms.MenuItem Flashligt;
        private System.Windows.Forms.MenuItem BlurAndSharpen;
        private System.Windows.Forms.Button btnPick;
        private System.Windows.Forms.ImageList imageList;
		private System.Windows.Forms.ContextMenu ToolContext;
		private System.Windows.Forms.MenuItem Change;
		private System.Windows.Forms.MenuItem NotChange;
		private System.Windows.Forms.ContextMenu ToolContext2;
		private System.Windows.Forms.MenuItem Change2;
		private System.Windows.Forms.MenuItem NotChange2;
		private System.ComponentModel.IContainer components;
        private Button button1;

        public Form1 fm1;

		/// <summary>
		/// 图形枚举。
		/// </summary>
		public enum ImageType
		{
			Empty,
			Point,
			Line,
			Rectangle,
			FillRectangle,
			Circle,
			FillCircle,
			Ellipse,
			FillEllipse,
			Path,
			Eraser,
			Text,
			CircleAt,
			Polygon,
			Curve,
			ClosedCurve,
			Beziers,
			Set,
			Pick
		}

		public MainWindow(Form1 fm)
		{
            fm1 = fm;
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
			//
			// TODO: Add any constructor code after InitializeComponent call
			//
			this.SetStyle(ControlStyles.DoubleBuffer | //双重缓冲
				ControlStyles.UserPaint | 
				ControlStyles.AllPaintingInWmPaint,
				true);
			this.UpdateStyles();

		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// 主体窗架生成 
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.AddFilledRectangle = new System.Windows.Forms.Button();
            this.AddHollowRectangle = new System.Windows.Forms.Button();
            this.AddPoint = new System.Windows.Forms.Button();
            this.Drawing = new System.Windows.Forms.PictureBox();
            this.cntMenu = new System.Windows.Forms.ContextMenu();
            this.menuItemEs = new System.Windows.Forms.MenuItem();
            this.menuItemSize1 = new System.Windows.Forms.MenuItem();
            this.menuItemmenuItemSize2 = new System.Windows.Forms.MenuItem();
            this.menuItemSize3 = new System.Windows.Forms.MenuItem();
            this.menuItemCA = new System.Windows.Forms.MenuItem();
            this.menuItemClose = new System.Windows.Forms.MenuItem();
            this.menuItemLw = new System.Windows.Forms.MenuItem();
            this.Advance = new System.Windows.Forms.MenuItem();
            this.FadeInOut = new System.Windows.Forms.MenuItem();
            this.GrayScale = new System.Windows.Forms.MenuItem();
            this.GrayScale1 = new System.Windows.Forms.MenuItem();
            this.GrayScale2 = new System.Windows.Forms.MenuItem();
            this.grayScale3 = new System.Windows.Forms.MenuItem();
            this.GrayScale4 = new System.Windows.Forms.MenuItem();
            this.Inverse = new System.Windows.Forms.MenuItem();
            this.Flashligt = new System.Windows.Forms.MenuItem();
            this.BlurAndSharpen = new System.Windows.Forms.MenuItem();
            this.AddHollowEllipse = new System.Windows.Forms.Button();
            this.AddFilledEllipse = new System.Windows.Forms.Button();
            this.AddLine = new System.Windows.Forms.Button();
            this.AddCircle = new System.Windows.Forms.Button();
            this.grpTool = new System.Windows.Forms.GroupBox();
            this.Curvecontext = new System.Windows.Forms.ContextMenu();
            this.Curve = new System.Windows.Forms.MenuItem();
            this.ClosedCurve = new System.Windows.Forms.MenuItem();
            this.btnEraser = new System.Windows.Forms.Button();
            this.AddPath = new System.Windows.Forms.Button();
            this.AddFillCircle = new System.Windows.Forms.Button();
            this.btnText = new System.Windows.Forms.Button();
            this.mainMenu = new System.Windows.Forms.MainMenu(this.components);
            this.statusBar = new System.Windows.Forms.StatusBar();
            this.statusBarImageType = new System.Windows.Forms.StatusBarPanel();
            this.statusBarPoint = new System.Windows.Forms.StatusBarPanel();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.btnColor = new System.Windows.Forms.Button();
            this.Magenta = new System.Windows.Forms.Button();
            this.blue = new System.Windows.Forms.Button();
            this.Red = new System.Windows.Forms.Button();
            this.White = new System.Windows.Forms.Button();
            this.Black = new System.Windows.Forms.Button();
            this.Yellow = new System.Windows.Forms.Button();
            this.LawnGreen = new System.Windows.Forms.Button();
            this.Cyan = new System.Windows.Forms.Button();
            this.MoreColor = new System.Windows.Forms.Button();
            this.ColorBox = new System.Windows.Forms.GroupBox();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.btnPick = new System.Windows.Forms.Button();
            this.ToolContext = new System.Windows.Forms.ContextMenu();
            this.Change = new System.Windows.Forms.MenuItem();
            this.NotChange = new System.Windows.Forms.MenuItem();
            this.ToolContext2 = new System.Windows.Forms.ContextMenu();
            this.Change2 = new System.Windows.Forms.MenuItem();
            this.NotChange2 = new System.Windows.Forms.MenuItem();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Drawing)).BeginInit();
            this.grpTool.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarImageType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPoint)).BeginInit();
            this.ColorBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // AddFilledRectangle
            // 
            this.AddFilledRectangle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddFilledRectangle.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.AddFilledRectangle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AddFilledRectangle.BackgroundImage")));
            this.AddFilledRectangle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddFilledRectangle.Image = ((System.Drawing.Image)(resources.GetObject("AddFilledRectangle.Image")));
            this.AddFilledRectangle.Location = new System.Drawing.Point(48, 48);
            this.AddFilledRectangle.Name = "AddFilledRectangle";
            this.AddFilledRectangle.Size = new System.Drawing.Size(26, 26);
            this.AddFilledRectangle.TabIndex = 17;
            this.AddFilledRectangle.UseVisualStyleBackColor = false;
            this.AddFilledRectangle.Click += new System.EventHandler(this.AddFilledRectangle_Click);
            // 
            // AddHollowRectangle
            // 
            this.AddHollowRectangle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddHollowRectangle.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.AddHollowRectangle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AddHollowRectangle.BackgroundImage")));
            this.AddHollowRectangle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddHollowRectangle.Image = ((System.Drawing.Image)(resources.GetObject("AddHollowRectangle.Image")));
            this.AddHollowRectangle.Location = new System.Drawing.Point(8, 48);
            this.AddHollowRectangle.Name = "AddHollowRectangle";
            this.AddHollowRectangle.Size = new System.Drawing.Size(26, 26);
            this.AddHollowRectangle.TabIndex = 16;
            this.AddHollowRectangle.UseVisualStyleBackColor = false;
            this.AddHollowRectangle.Click += new System.EventHandler(this.AddHollowRectangle_Click);
            // 
            // AddPoint
            // 
            this.AddPoint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddPoint.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.AddPoint.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AddPoint.BackgroundImage")));
            this.AddPoint.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddPoint.Location = new System.Drawing.Point(8, 16);
            this.AddPoint.Name = "AddPoint";
            this.AddPoint.Size = new System.Drawing.Size(26, 26);
            this.AddPoint.TabIndex = 15;
            this.AddPoint.UseVisualStyleBackColor = false;
            this.AddPoint.Click += new System.EventHandler(this.AddPoint_Click);
            // 
            // Drawing
            // 
            this.Drawing.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.Drawing.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Drawing.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Drawing.ContextMenu = this.cntMenu;
            this.Drawing.Location = new System.Drawing.Point(8, 8);
            this.Drawing.Name = "Drawing";
            this.Drawing.Size = new System.Drawing.Size(567, 427);
            this.Drawing.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Drawing.TabIndex = 14;
            this.Drawing.TabStop = false;
            this.Drawing.MouseLeave += new System.EventHandler(this.Drawing_MouseLeave);
            this.Drawing.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Drawing_MouseMove);
            this.Drawing.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Drawing_MouseDown);
            this.Drawing.Paint += new System.Windows.Forms.PaintEventHandler(this.Drawing_Paint);
            this.Drawing.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Drawing_MouseUp);
            this.Drawing.MouseEnter += new System.EventHandler(this.Drawing_MouseEnter);
            // 
            // cntMenu
            // 
            this.cntMenu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItemEs,
            this.menuItemCA,
            this.menuItemClose,
            this.menuItemLw,
            this.Advance});
            // 
            // menuItemEs
            // 
            this.menuItemEs.Index = 0;
            this.menuItemEs.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItemSize1,
            this.menuItemmenuItemSize2,
            this.menuItemSize3});
            this.menuItemEs.Text = "&EraserSize";
            // 
            // menuItemSize1
            // 
            this.menuItemSize1.Index = 0;
            this.menuItemSize1.Text = "&Small";
            this.menuItemSize1.Click += new System.EventHandler(this.menuItemSize1_Click);
            // 
            // menuItemmenuItemSize2
            // 
            this.menuItemmenuItemSize2.Index = 1;
            this.menuItemmenuItemSize2.Text = "&Middle";
            this.menuItemmenuItemSize2.Click += new System.EventHandler(this.menuItemmenuItemSize2_Click);
            // 
            // menuItemSize3
            // 
            this.menuItemSize3.Index = 2;
            this.menuItemSize3.Text = "&Large";
            this.menuItemSize3.Click += new System.EventHandler(this.menuItemSize3_Click);
            // 
            // menuItemCA
            // 
            this.menuItemCA.Index = 1;
            this.menuItemCA.Text = "Circle &At";
            this.menuItemCA.Click += new System.EventHandler(this.menuItemCA_Click);
            // 
            // menuItemClose
            // 
            this.menuItemClose.Index = 2;
            this.menuItemClose.Text = "&Close";
            this.menuItemClose.Click += new System.EventHandler(this.menuItemClose_Click);
            // 
            // menuItemLw
            // 
            this.menuItemLw.Index = 3;
            this.menuItemLw.Text = "&LineWidth";
            this.menuItemLw.Click += new System.EventHandler(this.menuItemLw_Click);
            // 
            // Advance
            // 
            this.Advance.Index = 4;
            this.Advance.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.FadeInOut,
            this.GrayScale,
            this.Inverse,
            this.Flashligt,
            this.BlurAndSharpen});
            this.Advance.Text = "&Advance";
            // 
            // FadeInOut
            // 
            this.FadeInOut.Index = 0;
            this.FadeInOut.Text = "&FadeInOut";
            this.FadeInOut.Click += new System.EventHandler(this.FadeInOut_Click);
            // 
            // GrayScale
            // 
            this.GrayScale.Index = 1;
            this.GrayScale.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.GrayScale1,
            this.GrayScale2,
            this.grayScale3,
            this.GrayScale4});
            this.GrayScale.Text = "&GrayScale";
            // 
            // GrayScale1
            // 
            this.GrayScale1.Index = 0;
            this.GrayScale1.Text = "GrayScale&1";
            this.GrayScale1.Click += new System.EventHandler(this.GrayScale1_Click);
            // 
            // GrayScale2
            // 
            this.GrayScale2.Index = 1;
            this.GrayScale2.Text = "GrayScale&2";
            this.GrayScale2.Click += new System.EventHandler(this.GrayScale2_Click);
            // 
            // grayScale3
            // 
            this.grayScale3.Index = 2;
            this.grayScale3.Text = "GrayScale&3";
            this.grayScale3.Click += new System.EventHandler(this.grayScale3_Click);
            // 
            // GrayScale4
            // 
            this.GrayScale4.Index = 3;
            this.GrayScale4.Text = "GrayScale&4";
            this.GrayScale4.Click += new System.EventHandler(this.GrayScale4_Click);
            // 
            // Inverse
            // 
            this.Inverse.Index = 2;
            this.Inverse.Text = "&Inverse";
            this.Inverse.Click += new System.EventHandler(this.Inverse_Click);
            // 
            // Flashligt
            // 
            this.Flashligt.Index = 3;
            this.Flashligt.Text = "&Flashligt";
            this.Flashligt.Click += new System.EventHandler(this.Flashligt_Click);
            // 
            // BlurAndSharpen
            // 
            this.BlurAndSharpen.Index = 4;
            this.BlurAndSharpen.Text = "&BlurAndSharpen";
            this.BlurAndSharpen.Click += new System.EventHandler(this.BlurAndSharpen_Click);
            // 
            // AddHollowEllipse
            // 
            this.AddHollowEllipse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddHollowEllipse.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.AddHollowEllipse.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AddHollowEllipse.BackgroundImage")));
            this.AddHollowEllipse.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddHollowEllipse.Image = ((System.Drawing.Image)(resources.GetObject("AddHollowEllipse.Image")));
            this.AddHollowEllipse.Location = new System.Drawing.Point(8, 80);
            this.AddHollowEllipse.Name = "AddHollowEllipse";
            this.AddHollowEllipse.Size = new System.Drawing.Size(26, 26);
            this.AddHollowEllipse.TabIndex = 19;
            this.AddHollowEllipse.UseVisualStyleBackColor = false;
            this.AddHollowEllipse.Click += new System.EventHandler(this.AddHollowEllipse_Click);
            // 
            // AddFilledEllipse
            // 
            this.AddFilledEllipse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddFilledEllipse.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.AddFilledEllipse.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AddFilledEllipse.BackgroundImage")));
            this.AddFilledEllipse.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddFilledEllipse.Image = ((System.Drawing.Image)(resources.GetObject("AddFilledEllipse.Image")));
            this.AddFilledEllipse.Location = new System.Drawing.Point(48, 80);
            this.AddFilledEllipse.Name = "AddFilledEllipse";
            this.AddFilledEllipse.Size = new System.Drawing.Size(26, 26);
            this.AddFilledEllipse.TabIndex = 22;
            this.AddFilledEllipse.UseVisualStyleBackColor = false;
            this.AddFilledEllipse.Click += new System.EventHandler(this.AddFilledEllipse_Click);
            // 
            // AddLine
            // 
            this.AddLine.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddLine.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.AddLine.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AddLine.BackgroundImage")));
            this.AddLine.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddLine.Location = new System.Drawing.Point(48, 16);
            this.AddLine.Name = "AddLine";
            this.AddLine.Size = new System.Drawing.Size(26, 26);
            this.AddLine.TabIndex = 23;
            this.AddLine.UseVisualStyleBackColor = false;
            this.AddLine.Click += new System.EventHandler(this.AddLine_Click);
            // 
            // AddCircle
            // 
            this.AddCircle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddCircle.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.AddCircle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AddCircle.BackgroundImage")));
            this.AddCircle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddCircle.Image = ((System.Drawing.Image)(resources.GetObject("AddCircle.Image")));
            this.AddCircle.Location = new System.Drawing.Point(8, 112);
            this.AddCircle.Name = "AddCircle";
            this.AddCircle.Size = new System.Drawing.Size(26, 26);
            this.AddCircle.TabIndex = 24;
            this.AddCircle.UseVisualStyleBackColor = false;
            this.AddCircle.Click += new System.EventHandler(this.AddCircle_Click);
            // 
            // grpTool
            // 
            this.grpTool.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.grpTool.Controls.Add(this.btnEraser);
            this.grpTool.Controls.Add(this.btnPick);
            this.grpTool.Controls.Add(this.AddPath);
            this.grpTool.Controls.Add(this.AddFillCircle);
            this.grpTool.Controls.Add(this.AddPoint);
            this.grpTool.Controls.Add(this.AddLine);
            this.grpTool.Controls.Add(this.AddHollowRectangle);
            this.grpTool.Controls.Add(this.AddFilledRectangle);
            this.grpTool.Controls.Add(this.AddHollowEllipse);
            this.grpTool.Controls.Add(this.AddFilledEllipse);
            this.grpTool.Controls.Add(this.AddCircle);
            this.grpTool.Controls.Add(this.btnText);
            this.grpTool.Location = new System.Drawing.Point(647, 8);
            this.grpTool.Name = "grpTool";
            this.grpTool.Size = new System.Drawing.Size(82, 216);
            this.grpTool.TabIndex = 25;
            this.grpTool.TabStop = false;
            // 
            // Curvecontext
            // 
            this.Curvecontext.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.Curve,
            this.ClosedCurve});
            // 
            // Curve
            // 
            this.Curve.Index = 0;
            this.Curve.Text = "Curve";
            this.Curve.Click += new System.EventHandler(this.Curve_Click);
            // 
            // ClosedCurve
            // 
            this.ClosedCurve.Index = 1;
            this.ClosedCurve.Text = "ClosedCurve";
            this.ClosedCurve.Click += new System.EventHandler(this.ClosedCurve_Click);
            // 
            // btnEraser
            // 
            this.btnEraser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEraser.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEraser.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEraser.BackgroundImage")));
            this.btnEraser.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEraser.Location = new System.Drawing.Point(48, 144);
            this.btnEraser.Name = "btnEraser";
            this.btnEraser.Size = new System.Drawing.Size(26, 26);
            this.btnEraser.TabIndex = 27;
            this.btnEraser.UseVisualStyleBackColor = false;
            this.btnEraser.Click += new System.EventHandler(this.btnEraser_Click);
            // 
            // AddPath
            // 
            this.AddPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddPath.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.AddPath.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AddPath.BackgroundImage")));
            this.AddPath.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddPath.Image = ((System.Drawing.Image)(resources.GetObject("AddPath.Image")));
            this.AddPath.Location = new System.Drawing.Point(8, 144);
            this.AddPath.Name = "AddPath";
            this.AddPath.Size = new System.Drawing.Size(26, 26);
            this.AddPath.TabIndex = 26;
            this.AddPath.UseVisualStyleBackColor = false;
            this.AddPath.Click += new System.EventHandler(this.AddPath_Click);
            // 
            // AddFillCircle
            // 
            this.AddFillCircle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddFillCircle.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.AddFillCircle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AddFillCircle.BackgroundImage")));
            this.AddFillCircle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddFillCircle.Image = ((System.Drawing.Image)(resources.GetObject("AddFillCircle.Image")));
            this.AddFillCircle.Location = new System.Drawing.Point(48, 112);
            this.AddFillCircle.Name = "AddFillCircle";
            this.AddFillCircle.Size = new System.Drawing.Size(26, 26);
            this.AddFillCircle.TabIndex = 25;
            this.AddFillCircle.UseVisualStyleBackColor = false;
            this.AddFillCircle.Click += new System.EventHandler(this.AddFillCircle_Click);
            // 
            // btnText
            // 
            this.btnText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnText.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnText.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnText.BackgroundImage")));
            this.btnText.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnText.Location = new System.Drawing.Point(8, 176);
            this.btnText.Name = "btnText";
            this.btnText.Size = new System.Drawing.Size(26, 26);
            this.btnText.TabIndex = 26;
            this.btnText.UseVisualStyleBackColor = false;
            this.btnText.Click += new System.EventHandler(this.btnText_Click);
            // 
            // statusBar
            // 
            this.statusBar.Location = new System.Drawing.Point(0, 443);
            this.statusBar.Name = "statusBar";
            this.statusBar.Panels.AddRange(new System.Windows.Forms.StatusBarPanel[] {
            this.statusBarImageType,
            this.statusBarPoint});
            this.statusBar.ShowPanels = true;
            this.statusBar.Size = new System.Drawing.Size(744, 22);
            this.statusBar.TabIndex = 26;
            // 
            // statusBarImageType
            // 
            this.statusBarImageType.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Spring;
            this.statusBarImageType.Name = "statusBarImageType";
            this.statusBarImageType.Width = 675;
            // 
            // statusBarPoint
            // 
            this.statusBarPoint.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Contents;
            this.statusBarPoint.Name = "statusBarPoint";
            this.statusBarPoint.Text = "Point:";
            this.statusBarPoint.Width = 52;
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.FileName = "NewFile";
            this.saveFileDialog.Filter = "JPeg Image(*.jpg)|*.jpg|Bitmap Image(*.bmp)|*.bmp|Gif Image(*.gif)|*.gif";
            this.saveFileDialog.FilterIndex = 2;
            this.saveFileDialog.Title = "Save As";
            this.saveFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog_FileOk);
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "JPeg Image(*.jpg)|*.jpg|Bitmap Image(*.bmp)|*.bmp|Gif Image(*.gif)|*.gif";
            this.openFileDialog.FilterIndex = 2;
            this.openFileDialog.Title = "Open File";
            // 
            // btnColor
            // 
            this.btnColor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btnColor.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnColor.Location = new System.Drawing.Point(12, 10);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(24, 24);
            this.btnColor.TabIndex = 32;
            this.btnColor.UseVisualStyleBackColor = false;
            // 
            // Magenta
            // 
            this.Magenta.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.Magenta.BackColor = System.Drawing.Color.Magenta;
            this.Magenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Magenta.Location = new System.Drawing.Point(24, 88);
            this.Magenta.Name = "Magenta";
            this.Magenta.Size = new System.Drawing.Size(15, 15);
            this.Magenta.TabIndex = 31;
            this.Magenta.UseVisualStyleBackColor = false;
            this.Magenta.Click += new System.EventHandler(this.Magenta_Click);
            // 
            // blue
            // 
            this.blue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.blue.BackColor = System.Drawing.Color.Blue;
            this.blue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.blue.Location = new System.Drawing.Point(24, 56);
            this.blue.Name = "blue";
            this.blue.Size = new System.Drawing.Size(15, 15);
            this.blue.TabIndex = 3;
            this.blue.UseVisualStyleBackColor = false;
            this.blue.Click += new System.EventHandler(this.blue_Click);
            // 
            // Red
            // 
            this.Red.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.Red.BackColor = System.Drawing.Color.Red;
            this.Red.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Red.Location = new System.Drawing.Point(8, 56);
            this.Red.Name = "Red";
            this.Red.Size = new System.Drawing.Size(15, 15);
            this.Red.TabIndex = 2;
            this.Red.UseVisualStyleBackColor = false;
            this.Red.Click += new System.EventHandler(this.Red_Click);
            // 
            // White
            // 
            this.White.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.White.BackColor = System.Drawing.Color.White;
            this.White.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.White.Location = new System.Drawing.Point(24, 40);
            this.White.Name = "White";
            this.White.Size = new System.Drawing.Size(15, 15);
            this.White.TabIndex = 1;
            this.White.UseVisualStyleBackColor = false;
            this.White.Click += new System.EventHandler(this.White_Click);
            // 
            // Black
            // 
            this.Black.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.Black.BackColor = System.Drawing.Color.Black;
            this.Black.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Black.Location = new System.Drawing.Point(8, 40);
            this.Black.Name = "Black";
            this.Black.Size = new System.Drawing.Size(15, 15);
            this.Black.TabIndex = 0;
            this.Black.UseVisualStyleBackColor = false;
            this.Black.Click += new System.EventHandler(this.Black_Click);
            // 
            // Yellow
            // 
            this.Yellow.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.Yellow.BackColor = System.Drawing.Color.Yellow;
            this.Yellow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Yellow.Location = new System.Drawing.Point(8, 72);
            this.Yellow.Name = "Yellow";
            this.Yellow.Size = new System.Drawing.Size(15, 15);
            this.Yellow.TabIndex = 28;
            this.Yellow.UseVisualStyleBackColor = false;
            this.Yellow.Click += new System.EventHandler(this.Yellow_Click);
            // 
            // LawnGreen
            // 
            this.LawnGreen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.LawnGreen.BackColor = System.Drawing.Color.LawnGreen;
            this.LawnGreen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LawnGreen.Location = new System.Drawing.Point(24, 72);
            this.LawnGreen.Name = "LawnGreen";
            this.LawnGreen.Size = new System.Drawing.Size(15, 15);
            this.LawnGreen.TabIndex = 29;
            this.LawnGreen.UseVisualStyleBackColor = false;
            this.LawnGreen.Click += new System.EventHandler(this.LawnGreen_Click);
            // 
            // Cyan
            // 
            this.Cyan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.Cyan.BackColor = System.Drawing.Color.Cyan;
            this.Cyan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cyan.Location = new System.Drawing.Point(8, 88);
            this.Cyan.Name = "Cyan";
            this.Cyan.Size = new System.Drawing.Size(15, 15);
            this.Cyan.TabIndex = 30;
            this.Cyan.UseVisualStyleBackColor = false;
            this.Cyan.Click += new System.EventHandler(this.Cyan_Click);
            // 
            // MoreColor
            // 
            this.MoreColor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MoreColor.BackColor = System.Drawing.SystemColors.HighlightText;
            this.MoreColor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.MoreColor.Location = new System.Drawing.Point(664, 348);
            this.MoreColor.Name = "MoreColor";
            this.MoreColor.Size = new System.Drawing.Size(50, 24);
            this.MoreColor.TabIndex = 28;
            this.MoreColor.Text = "More>>";
            this.MoreColor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MoreColor.UseVisualStyleBackColor = false;
            this.MoreColor.Click += new System.EventHandler(this.MoreColor_Click);
            // 
            // ColorBox
            // 
            this.ColorBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ColorBox.Controls.Add(this.blue);
            this.ColorBox.Controls.Add(this.Red);
            this.ColorBox.Controls.Add(this.btnColor);
            this.ColorBox.Controls.Add(this.Magenta);
            this.ColorBox.Controls.Add(this.White);
            this.ColorBox.Controls.Add(this.Black);
            this.ColorBox.Controls.Add(this.Yellow);
            this.ColorBox.Controls.Add(this.LawnGreen);
            this.ColorBox.Controls.Add(this.Cyan);
            this.ColorBox.Location = new System.Drawing.Point(664, 230);
            this.ColorBox.Name = "ColorBox";
            this.ColorBox.Size = new System.Drawing.Size(48, 112);
            this.ColorBox.TabIndex = 29;
            this.ColorBox.TabStop = false;
            // 
            // btnPick
            // 
            this.btnPick.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPick.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPick.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPick.BackgroundImage")));
            this.btnPick.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPick.Location = new System.Drawing.Point(48, 176);
            this.btnPick.Name = "btnPick";
            this.btnPick.Size = new System.Drawing.Size(26, 26);
            this.btnPick.TabIndex = 30;
            this.btnPick.UseVisualStyleBackColor = false;
            this.btnPick.Click += new System.EventHandler(this.btnPick_Click);
            // 
            // ToolContext
            // 
            this.ToolContext.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.Change,
            this.NotChange});
            // 
            // Change
            // 
            this.Change.Index = 0;
            this.Change.Text = "Change";
            this.Change.Click += new System.EventHandler(this.Change_Click);
            // 
            // NotChange
            // 
            this.NotChange.Index = 1;
            this.NotChange.Text = "NotChange";
            this.NotChange.Click += new System.EventHandler(this.NotChange_Click);
            // 
            // ToolContext2
            // 
            this.ToolContext2.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.Change2,
            this.NotChange2});
            // 
            // Change2
            // 
            this.Change2.Index = 0;
            this.Change2.Text = "rChange";
            this.Change2.Click += new System.EventHandler(this.Change2_Click);
            // 
            // NotChange2
            // 
            this.NotChange2.Index = 1;
            this.NotChange2.Text = "rNotChange";
            this.NotChange2.Click += new System.EventHandler(this.NotChange2_Click);
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "");
            this.imageList.Images.SetKeyName(1, "");
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(647, 402);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 31;
            this.button1.Text = "Finish";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
            this.ClientSize = new System.Drawing.Size(744, 465);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ColorBox);
            this.Controls.Add(this.MoreColor);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.grpTool);
            this.Controls.Add(this.Drawing);
            this.Menu = this.mainMenu;
            this.Name = "MainWindow";
            this.Text = "MyPGS";
            ((System.ComponentModel.ISupportInitialize)(this.Drawing)).EndInit();
            this.grpTool.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.statusBarImageType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPoint)).EndInit();
            this.ColorBox.ResumeLayout(false);
            this.ResumeLayout(false);

		}
		#endregion
		/// <summary>
		/// 主函数，程序入口点。
		/// </summary>
		

		#region 申明
		/// <summary>
		/// 图形存储集合等。
		/// </summary>		
		DShapeList drawingList = new DShapeList();							//图元
		DShapeList drawingListUndo = new DShapeList();						//Undo保存
		DShapeList tempPoint = new DShapeList();							//多边形、曲线临时顶点
		DShapeList pointViewList = new DShapeList();						//图元顶点框
		DShapeList notchangeList = new DShapeList();						//不移图元
		DShapeList notchangeListUndo = new DShapeList();

		NewForm newForm = new NewForm();									//字体、线宽窗口
		CircleForm newCircle = new CircleForm();							//顶点圆窗口

		ArrayList pointCollection = new ArrayList();						//多边形、曲线顶点集合
		
		NewRegion regionCollection = new NewRegion();						//图元区域集合
		NewRegion regionCollectionUndo = new NewRegion();
		PointArrayCollection pointArray = new PointArrayCollection();		//图元顶点数组集合
		PointArrayCollection pointArrayUndo = new PointArrayCollection();
		Type drawImageType = new Type();									//图元形状
		Type drawImageTypeUndo = new Type();
		
		NewRegionArray regionArrayCollection = new NewRegionArray();		//图元顶点区域集合
		NewRegionArray regionArrayCollectionUndo = new NewRegionArray();
		
		GraphicsPath regionPath;											//线、多边形区域路径		
		
		Point[] tempPointArray;												//图元顶点临时保存
		Region[] tempRegion;												//图元顶点区域临时数组
		Point[] tempMovePoint;												//拾取起始点保存

		int regionIndex = 0;												//拾取集合索引
		int pointIndex;														//拾取顶点索引
		int Distance;														//圆半径（临时）
		int diameter;														//圆直径（临时）

		bool picked = false;												//拾取与否
		bool changed = false;												//图元变换
		bool mouseMove = false;												//拾取是否移动
		bool eraser = false;

        //零时变量，常量
        private MousePoint newPoint;
        private MousePoint tempChangePoint;
        private ImageType newType;
        private GraphicsPath mousePath;
        private Region newRegion;
        private int EraserSize;
        private Image newImage;
        private string fileName = "NewFile";
        private Color newColor = Color.Black;
        private float lineWidth = 1;
        private ImageType tempType;
		#endregion

		#region 画图事件
		/// <summary>
		/// 画图事件
		/// </summary>		
		private void Drawing_Paint(object sender, System.Windows.Forms.PaintEventArgs e) 
		{
			Graphics displayGraphics = e.Graphics;
			
			switch(newType)
			{
				case ImageType.Point:
					displayGraphics.DrawRectangle(new Pen(newColor,lineWidth),new Rectangle(newPoint.StartP, new Size(1, 1)));
					break;
				case ImageType.Line:
					displayGraphics.DrawLine(new Pen(newColor,lineWidth),newPoint.StartP,newPoint.EndP);
					break;
				case ImageType.Circle:
					displayGraphics.DrawLine(new Pen(newColor),newPoint.StartP,newPoint.EndP);
					break;
				case ImageType.FillCircle:
					displayGraphics.DrawLine(new Pen(newColor),newPoint.StartP,newPoint.EndP);
					break;
				case ImageType.Rectangle:
					displayGraphics.DrawRectangle(new Pen(newColor,lineWidth),newPoint.Rect);
					break;
				case ImageType.FillRectangle:
					displayGraphics.FillRectangle(new SolidBrush(newColor),newPoint.Rect);
					break;
				case ImageType.Ellipse:
					displayGraphics.DrawEllipse(new Pen(newColor,lineWidth),newPoint.Rect);
					break;
				case ImageType.FillEllipse:
					displayGraphics.FillEllipse(new SolidBrush(newColor),newPoint.Rect);
					break;
				case ImageType.Path:
					displayGraphics.DrawPath(new Pen(newColor,lineWidth), mousePath);
					break;
				case ImageType.Eraser:
					displayGraphics.FillRegion(new SolidBrush(newColor), newRegion);
					break;
				case ImageType.Polygon:
					tempPoint.DrawList(displayGraphics);
					break;
				case ImageType.Curve:
					tempPoint.DrawList(displayGraphics);
					break;
				case ImageType.ClosedCurve:
					tempPoint.DrawList(displayGraphics);
					break;
				case ImageType.Empty:
					break;
				case ImageType.Pick:
					if(picked == true)
					{
						pointViewList.DrawList(displayGraphics);
						if(changed == true&&drawImageType[regionIndex]!=(int)ImageType.Path)
						{
							if(drawImageType[regionIndex]==(int)ImageType.Rectangle)
							{
								displayGraphics.DrawRectangle(new Pen(newColor,lineWidth), tempChangePoint.Rect);
							}
							else if(drawImageType[regionIndex]==(int)ImageType.FillRectangle)
							{
								displayGraphics.FillRectangle(new SolidBrush(newColor), tempChangePoint.Rect);
							}
							else if(drawImageType[regionIndex]==(int)ImageType.Ellipse
								||drawImageType[regionIndex]==(int)ImageType.FillEllipse)
							{
								displayGraphics.DrawRectangle(new Pen(Color.Black,1), tempChangePoint.Rect);
							}
						}
					}
					break;
			}
			drawingList.DrawList(displayGraphics);
			if(eraser == true)
				notchangeList.DrawList(displayGraphics);			
			//g.Dispose();
		}
		private void Point2Region(Point[] p)
		{
			Point[] point = new Point[p.Length];
			int j = 0;
			foreach(Point newp in p)
			{
				point[j++]=newp;
			}
			tempRegion = new Region[p.Length];
			for(int i=0;i<p.Length;i++)
			{
				point[i].Offset(-(int)(2*lineWidth),-(int)(2*lineWidth));
				Rectangle r = new Rectangle(point[i],new Size((int)(4*lineWidth),(int)(4*lineWidth)));
				Region rr = new Region(r);
				tempRegion[i] = rr;
			}
		}

		private void RegionMove(int index, int x, int y)
		{
			for(int i=0;i<pointArray[index].Length;i++)
			{
				pointArray[index][i].X = tempMovePoint[i].X + x;
				pointArray[index][i].Y = tempMovePoint[i].Y + y;
			}
		}

		private void PointView(int index)
		{
			Point tempPoint2;
			foreach(Point tempPoint in pointArray[index])
			{
				tempPoint2 = tempPoint;
				tempPoint.Offset(-(int)(2*lineWidth),-(int)(2*lineWidth));
				tempPoint2.Offset((int)(2*lineWidth),(int)(2*lineWidth));
				pointViewList.Add(new DHollowRectangle(new Point[]{tempPoint,tempPoint2},Color.DarkRed,1));
				tempPoint.Offset((int)(2*lineWidth),(int)(2*lineWidth));
			}
		}
		private void PointChange(int index)
		{
			Point tempPoint2;
			for(int i=0;i<pointArray[index].Length;i++)
			{
				tempPoint2 = pointArray[index][i];
				pointArray[index][i].Offset(-(int)(2*lineWidth),-(int)(2*lineWidth));
				tempPoint2.Offset((int)(2*lineWidth),(int)(2*lineWidth));
				pointViewList[i].pointchange(new Point[]{pointArray[index][i],tempPoint2});
				pointArray[index][i].Offset((int)(2*lineWidth),(int)(2*lineWidth));
			}
		}		

		private void RegionChange(int index)
		{
			ImageType tempType = (ImageType)drawImageType[index];
			switch(tempType)
			{
				case ImageType.Point:
					regionCollection[index] = new Region(new Rectangle(pointArray[index][0], new Size((int)lineWidth*4, (int)lineWidth*4)));
					break;
				case ImageType.Line:
					if(Math.Abs((float)(pointArray[index][0].Y-pointArray[index][1].Y)/(float)(pointArray[index][0].X-pointArray[index][1].X))<=1)
					{
						regionPath = new GraphicsPath(new Point[]{
																	 new Point(pointArray[index][0].X,pointArray[index][0].Y-10),
																	 new Point(pointArray[index][1].X,pointArray[index][1].Y-10),
																	 new Point(pointArray[index][1].X,pointArray[index][1].Y+10),
																	 new Point(pointArray[index][0].X,pointArray[index][0].Y+10),
																	 new Point(pointArray[index][0].X,pointArray[index][0].Y-10)
																 },new byte[]{
																				 (byte)PathPointType.Start,
																				 (byte)PathPointType.Line,
																				 (byte)PathPointType.Line,
																				 (byte)PathPointType.Line,
																				 (byte)PathPointType.Line
																			 });
					}
					else
					{
						regionPath = new GraphicsPath(new Point[]{
																	 new Point(pointArray[index][0].X-10,pointArray[index][0].Y),
																	 new Point(pointArray[index][0].X+10,pointArray[index][0].Y),
																	 new Point(pointArray[index][1].X+10,pointArray[index][1].Y),
																	 new Point(pointArray[index][1].X-10,pointArray[index][1].Y),
																	 new Point(pointArray[index][0].X-10,pointArray[index][0].Y)
																 },new byte[]{
																				 (byte)PathPointType.Start,
																				 (byte)PathPointType.Line,
																				 (byte)PathPointType.Line,
																				 (byte)PathPointType.Line,
																				 (byte)PathPointType.Line
																			 });
					}
					regionPath.CloseFigure();
					regionCollection[index] = new Region(regionPath);
					break;
				case ImageType.Circle:
				case ImageType.FillCircle:
					Distance = (int)Math.Sqrt (Math.Pow((pointArray[index][0].X-pointArray[index][1].X),2.0)+Math.Pow((pointArray[index][0].Y-pointArray[index][1].Y),2.0));
					pointArray[index][0].Offset(-Distance,-Distance);
					diameter = Distance*2;					
					regionCollection[index] = new Region(new Rectangle(pointArray[index][0], new Size(diameter, diameter)));
					pointArray[index][0].Offset(Distance,Distance);
					break;				
				case ImageType.Polygon:
				case ImageType.Curve:
				case ImageType.ClosedCurve:
					byte[] tempByte = new byte[pointArray[index].Length];
					for(int i=0;i<pointArray[index].Length;i++)
					{
						if(i==0)
							tempByte[i] = (byte)PathPointType.Start;
						else
							tempByte[i] = (byte)PathPointType.Line;
					}
					regionPath = new GraphicsPath(pointArray[index], tempByte);
					regionPath.CloseFigure();
					regionCollection[index] = new Region(regionPath);		
					break;
				case ImageType.Text:
					break;
			}
		}
		#endregion

		#region 画图框按钮
		/// <summary>
		/// 图画图按钮框事件
		/// </summary>		
		private void AddPoint_Click(object sender, System.EventArgs e)   
		{
			this.statusBar.Panels[0].Text = "Point";
			newType = ImageType.Point;
		}

		private void AddLine_Click(object sender, System.EventArgs e)
		{
			this.statusBar.Panels[0].Text = "Line";
			newType = ImageType.Line;
		}

		private void AddCircle_Click(object sender, System.EventArgs e)
		{
			this.statusBar.Panels[0].Text = "Circle";
			newType = ImageType.Circle;
		}

		private void AddFillCircle_Click(object sender, System.EventArgs e)
		{
			this.statusBar.Panels[0].Text = "FillCircle";
			newType = ImageType.FillCircle;
		}

		private void AddHollowEllipse_Click(object sender, System.EventArgs e) 
		{
			this.statusBar.Panels[0].Text = "Ellipse";
			newType = ImageType.Ellipse;
		}

		private void AddHollowRectangle_Click(object sender, System.EventArgs e) 
		{
			this.statusBar.Panels[0].Text = "Rectangle";
			newType = ImageType.Rectangle;
		}

		private void AddFilledEllipse_Click(object sender, System.EventArgs e) 
		{
			this.statusBar.Panels[0].Text = "FillEllipse";
			newType = ImageType.FillEllipse;
		}

		private void AddFilledRectangle_Click(object sender, System.EventArgs e) 
		{
			this.statusBar.Panels[0].Text = "FillRectangle";
			newType = ImageType.FillRectangle;
		}

		private void AddPath_Click(object sender, System.EventArgs e)
		{
			this.statusBar.Panels[0].Text = "Path";
			newType = ImageType.Path;
		}

		private void btnEraser_Click(object sender, System.EventArgs e)
		{
			this.statusBar.Panels[0].Text = "Eraser";
			newType = ImageType.Eraser;
			EraserSize = 2;
		}

		private void btnText_Click(object sender, System.EventArgs e)
		{
			this.statusBar.Panels[0].Text = "Text";
			newType = ImageType.Text;
			MakeForm();
		}

		private void btnCircleAt_Click(object sender, System.EventArgs e)
		{
			this.statusBar.Panels[0].Text = "CircleAt";
			newType = ImageType.CircleAt;
			MakeCircleAt();
		}

		private void AddPolygon_Click(object sender, System.EventArgs e)
		{
			this.statusBar.Panels[0].Text = "Polygon";
			newType = ImageType.Polygon;
		}
		private void Curve_Click(object sender, System.EventArgs e)
		{
			this.statusBar.Panels[0].Text = "Curve";
			newType = ImageType.Curve;
		}

		private void ClosedCurve_Click(object sender, System.EventArgs e)
		{
			this.statusBar.Panels[0].Text = "ClosedCurve";
			newType = ImageType.ClosedCurve;
		}
		private void btnPick_Click(object sender, System.EventArgs e)
		{
			this.statusBar.Panels[0].Text = "PickUp";
			newType = ImageType.Pick;
		}

		private void Change_Click(object sender, System.EventArgs e)
		{
			if(drawingList.Count==0)
				return;
			picked = false;
			drawingListUndo.Add(drawingList[drawingList.Count-1]);
			drawingList.RemoveAt(drawingList.Count-1);
			regionCollectionUndo.Add(regionCollection[regionCollection.Count-1]);
			regionCollection.RemoveAt(regionCollection.Count-1);
			pointArrayUndo.Add(pointArray[pointArray.Count-1]);
			pointArray.RemoveAt(pointArray.Count-1);
			regionArrayCollectionUndo.Add(regionArrayCollection[regionArrayCollection.Count-1]);
			regionArrayCollection.RemoveAt(regionArrayCollection.Count-1);
			drawImageTypeUndo.Add((ImageType)drawImageType[drawImageType.Count-1]);
			drawImageType.RemoveAt(drawImageType.Count-1);
			newType = ImageType.Empty;
			Drawing.Invalidate();
		}

		private void NotChange_Click(object sender, System.EventArgs e)
		{
			if(notchangeList.Count==0)
				return;
			notchangeListUndo.Add(notchangeList[notchangeList.Count-1]);
			notchangeList.RemoveAt(notchangeList.Count-1);
			Drawing.Invalidate();
		}

		private void Change2_Click(object sender, System.EventArgs e)
		{
			if(drawingListUndo.Count==0)
				return;
			picked = false;
			drawingList.Add(drawingListUndo[drawingListUndo.Count-1]);
			drawingListUndo.RemoveAt(drawingListUndo.Count-1);
			regionCollection.Add(regionCollectionUndo[regionCollectionUndo.Count-1]);
			regionCollectionUndo.RemoveAt(regionCollectionUndo.Count-1);
			pointArray.Add(pointArrayUndo[pointArrayUndo.Count-1]);
			pointArrayUndo.RemoveAt(pointArrayUndo.Count-1);
			regionArrayCollection.Add(regionArrayCollectionUndo[regionArrayCollectionUndo.Count-1]);
			regionArrayCollectionUndo.RemoveAt(regionArrayCollectionUndo.Count-1);
			drawImageType.Add((ImageType)drawImageTypeUndo[drawImageTypeUndo.Count-1]);
			drawImageTypeUndo.RemoveAt(drawImageTypeUndo.Count-1);
			Drawing.Invalidate();
		}

		private void NotChange2_Click(object sender, System.EventArgs e)
		{
			if(notchangeListUndo.Count==0)
				return;
			notchangeList.Add(notchangeListUndo[notchangeListUndo.Count-1]);
			notchangeListUndo.RemoveAt(notchangeListUndo.Count-1);
			Drawing.Invalidate();
		}
		#endregion

		#region 鼠标事件
		/// <summary>
		/// 鼠标事件
		/// </summary>		
		private void Drawing_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			if (e.Button != MouseButtons.Left)
				return;
			newPoint = new MousePoint(e.X, e.Y);
			switch(newType)
			{
				case ImageType.Path:
					mousePath = new GraphicsPath();
					mousePath.AddLine(e.X,e.Y,e.X,e.Y);
					break;
				case ImageType.Eraser:
					eraser = true;
					newPoint.EndX = e.X;
					newPoint.EndY = e.Y;
					Point p = newPoint.StartP;
					p.Offset(-2,-2);
					newRegion = new Region(new Rectangle(p, new Size(4,4)));
					break;
				case ImageType.Text:				
					newForm.Show();
					break;
				case ImageType.Polygon:
					pointCollection.Add(newPoint.StartP);
					tempPoint.Add(new DPoint(new Point[1]{newPoint.StartP}, newColor,lineWidth));
					Drawing.Invalidate();
					break;
				case ImageType.Curve:
					pointCollection.Add(newPoint.StartP);
					tempPoint.Add(new DPoint(new Point[1]{newPoint.StartP}, newColor,lineWidth));
					Drawing.Invalidate();
					break;
				case ImageType.ClosedCurve:
					pointCollection.Add(newPoint.StartP);
					tempPoint.Add(new DPoint(new Point[1]{newPoint.StartP}, newColor,lineWidth));
					Drawing.Invalidate();
					break;
				case ImageType.Pick:
					if(picked == true)
					{
						for(int k=0;k<regionArrayCollection[regionIndex].Length;k++)
						{
							if(regionArrayCollection[regionIndex][k].IsVisible(newPoint.StartP))
							{
								pointIndex = k;
								changed = true;
								break;
							}
							else
								changed = false;
						}
						if(changed == true)
							break;
					}
					int m = regionIndex;
					if(picked == true)
						m = (regionIndex+1)%regionCollection.Count;		//循环下一项开始
					int n = 0;
					for(;n<regionCollection.Count;n++)
					{
						if(m >= regionCollection.Count)
							m = 0;
						if(regionCollection[m++].IsVisible(newPoint.StartP))
						{
							pointViewList = new DShapeList();
							regionIndex = m-1;
							tempMovePoint = new Point[pointArray[regionIndex].Length];
							for(int j=0;j<pointArray[regionIndex].Length;j++)
							{
								tempMovePoint[j] = pointArray[regionIndex][j];
							}
							PointView(regionIndex);
							Drawing.Invalidate();
							picked = true;
							if(drawImageType[regionIndex]==(int)ImageType.Path)
							{
								mousePath = drawingList[regionIndex].pathChange(mousePath,true);
							}
							changed = false;
							break;
						}
						else
						{
							pointViewList = new DShapeList();
							Drawing.Invalidate();
							picked = false;							
						}
					}
					break;
			}
		}

		private void Drawing_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			if (e.Button != MouseButtons.Left)
				return;
			newPoint.EndX = e.X;
			newPoint.EndY = e.Y;
			this.statusBar.Panels[1].Text="Point:"+e.X.ToString() + "," + e.Y.ToString();
			switch(newType)
			{
				case ImageType.Path:
					mousePath.AddLine(e.X,e.Y,e.X,e.Y);
					break;
				case ImageType.Eraser:
					Point p = newPoint.EndP;
					p.Offset(-EraserSize,-EraserSize);
					newRegion = new Region(new Rectangle(p, new Size(EraserSize*2,EraserSize*2)));
					notchangeList.Add(new DEraser(newPoint.EndP, newColor, EraserSize));
					break;
				case ImageType.Pick:
					if(picked == true&&changed !=true)
					{
						mouseMove = true;
						int MoveX = newPoint.EndP.X-newPoint.StartP.X;
						int MoveY = newPoint.EndP.Y-newPoint.StartP.Y;
						RegionMove(regionIndex, MoveX,MoveY);
						if(drawImageType[regionIndex]!=(int)ImageType.Path)
						{
							drawingList[regionIndex].pointchange(pointArray[regionIndex]);							
						}
						else
						{
							regionPath = (GraphicsPath)mousePath.Clone();
							Matrix translateMatrix = new Matrix();
							translateMatrix.Translate(MoveX, MoveY);
							regionPath.Transform(translateMatrix);
							drawingList[regionIndex].pathChange(regionPath,false);
						}
						PointChange(regionIndex);
					}
					if(changed ==true&&drawImageType[regionIndex]!=(int)ImageType.Path)
					{
						mouseMove = true;
						pointArray[regionIndex][pointIndex] = newPoint.EndP;
						if(drawImageType[regionIndex]==(int)ImageType.Rectangle
							||drawImageType[regionIndex]==(int)ImageType.FillRectangle
							||drawImageType[regionIndex]==(int)ImageType.Ellipse
							||drawImageType[regionIndex]==(int)ImageType.FillEllipse)
						{
							tempChangePoint = new MousePoint(pointArray[regionIndex][1-pointIndex].X, pointArray[regionIndex][1-pointIndex].Y);
							tempChangePoint.EndX = pointArray[regionIndex][pointIndex].X;
							tempChangePoint.EndY = pointArray[regionIndex][pointIndex].Y;
							regionCollection[regionIndex] = new Region(tempChangePoint.Rect);
						}	
						drawingList[regionIndex].pointchange(pointArray[regionIndex]);
						PointChange(regionIndex);
					}
					break;
			}
			Drawing.Invalidate();
		}

		private void Drawing_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			switch(newType)
			{
				case ImageType.Point:
					//加顶点
					tempPointArray = new Point[1]{newPoint.StartP};
					pointArray.Add(tempPointArray);
					//加顶点区域
					Point2Region(tempPointArray);
					regionArrayCollection.Add(tempRegion);
					//加图元区域
					newPoint.StartP.Offset(-2,-2);
					regionCollection.Add(new Region(new Rectangle(newPoint.StartP, new Size((int)lineWidth*4, (int)lineWidth*4))));
					drawImageType.Add(ImageType.Point);
					//加图元
					drawingList.Add(new DPoint(tempPointArray,newColor,lineWidth));
					break;
				case ImageType.Line:
					//加顶点
					tempPointArray = new Point[2]{newPoint.StartP,newPoint.EndP};
					pointArray.Add(tempPointArray);
					//加顶点区域
					Point2Region(tempPointArray);
					regionArrayCollection.Add(tempRegion);
					//加图元区域
					if(Math.Abs((float)(newPoint.StartP.Y-newPoint.EndP.Y)/(float)(newPoint.StartP.X-newPoint.EndP.X))<=1)
					{
						regionPath = new GraphicsPath(new Point[]{
																	 new Point(newPoint.StartP.X,newPoint.StartP.Y-10),
																	 new Point(newPoint.EndP.X,newPoint.StartP.Y-10),
																	 new Point(newPoint.EndP.X,newPoint.EndP.Y+10),
																	 new Point(newPoint.StartP.X,newPoint.EndP.Y+10),
																	 new Point(newPoint.StartP.X,newPoint.StartP.Y-10)
																 },new byte[]{
																				 (byte)PathPointType.Start,
																				 (byte)PathPointType.Line,
																				 (byte)PathPointType.Line,
																				 (byte)PathPointType.Line,
																				 (byte)PathPointType.Line
																			 });
					}
					else
					{
						regionPath = new GraphicsPath(new Point[]{
																	 new Point(newPoint.StartP.X-10,newPoint.StartP.Y),
																	 new Point(newPoint.StartP.X+10,newPoint.StartP.Y),
																	 new Point(newPoint.EndP.X+10,newPoint.EndP.Y),
																	 new Point(newPoint.EndP.X-10,newPoint.EndP.Y),
																	 new Point(newPoint.StartP.X-10,newPoint.StartP.Y)
																 },new byte[]{
																				 (byte)PathPointType.Start,
																				 (byte)PathPointType.Line,
																				 (byte)PathPointType.Line,
																				 (byte)PathPointType.Line,
																				 (byte)PathPointType.Line
																			 });
					}
					regionPath.CloseFigure();
					regionCollection.Add(new Region(regionPath));
					drawImageType.Add(ImageType.Line);
					//加图元
					drawingList.Add(new DLine(tempPointArray,newColor,lineWidth));
					break;
				case ImageType.Circle:
					//加顶点
					tempPointArray = new Point[2]{newPoint.StartP, newPoint.EndP};
					pointArray.Add(tempPointArray);
					//加图元
					drawingList.Add(new DHollowCircle(tempPointArray, newColor,lineWidth));			
					//加顶点区域
					Point2Region(tempPointArray);
					regionArrayCollection.Add(tempRegion);
					//加图元区域
					Distance = (int)Math.Sqrt (Math.Pow((tempPointArray[0].X-tempPointArray[1].X),2.0)+Math.Pow((tempPointArray[0].Y-tempPointArray[1].Y),2.0));
					tempPointArray[0].Offset(-Distance,-Distance);
					diameter = Distance*2;					
					regionCollection.Add(new Region(new Rectangle(tempPointArray[0], new Size(diameter, diameter))));
					tempPointArray[0].Offset(Distance,Distance);//指针乃万恶之首
					drawImageType.Add(ImageType.Circle);
					break;
				case ImageType.FillCircle:
					tempPointArray = new Point[2]{newPoint.StartP, newPoint.EndP};
					pointArray.Add(tempPointArray);

					drawingList.Add(new DFilledCircle(tempPointArray, newColor,lineWidth, newColor));
					
					Point2Region(tempPointArray);
					regionArrayCollection.Add(tempRegion);

					Distance = (int)Math.Sqrt (Math.Pow((tempPointArray[0].X-tempPointArray[1].X),2.0)+Math.Pow((tempPointArray[0].Y-tempPointArray[1].Y),2.0));
					tempPointArray[0].Offset(-Distance,-Distance);
					diameter = Distance*2;					
					regionCollection.Add(new Region(new Rectangle(tempPointArray[0], new Size(diameter, diameter))));
					tempPointArray[0].Offset(Distance,Distance);
					drawImageType.Add(ImageType.FillCircle);
					break;
				case ImageType.Rectangle:
					regionCollection.Add(new Region(newPoint.Rect));  //一定要先调用Rect，改变起点、终点
					drawImageType.Add(ImageType.Rectangle);
					tempPointArray = new Point[2]{newPoint.StartP, newPoint.EndP};
					pointArray.Add(tempPointArray);

					Point2Region(tempPointArray);
					regionArrayCollection.Add(tempRegion);

					drawingList.Add(new DHollowRectangle(tempPointArray, newColor,lineWidth));
					break;
				case ImageType.FillRectangle:
					regionCollection.Add(new Region(newPoint.Rect));
					drawImageType.Add(ImageType.FillRectangle);
					tempPointArray = new Point[2]{newPoint.StartP, newPoint.EndP};
					pointArray.Add(tempPointArray);

					Point2Region(tempPointArray);
					regionArrayCollection.Add(tempRegion);

					drawingList.Add(new DFilledRectangle(tempPointArray, newColor,lineWidth, newColor));
					break;
				case ImageType.Ellipse:
					regionCollection.Add(new Region(newPoint.Rect));
					drawImageType.Add(ImageType.Ellipse);
					tempPointArray = new Point[2]{newPoint.StartP, newPoint.EndP};
					pointArray.Add(tempPointArray);

					Point2Region(tempPointArray);
					regionArrayCollection.Add(tempRegion);

					drawingList.Add(new DHollowEllipse(tempPointArray, newColor,lineWidth));
					break;
				case ImageType.FillEllipse:
					regionCollection.Add(new Region(newPoint.Rect));
					drawImageType.Add(ImageType.FillEllipse);
					tempPointArray = new Point[2]{newPoint.StartP, newPoint.EndP};
					pointArray.Add(tempPointArray);

					Point2Region(tempPointArray);
					regionArrayCollection.Add(tempRegion);

					drawingList.Add(new DFilledEllipse(tempPointArray, newColor,lineWidth, newColor));
					break;
				case ImageType.Path:
					drawingList.Add(new DPath(mousePath, newColor,lineWidth));
					tempPointArray = new Point[1]{newPoint.StartP};
					pointArray.Add(tempPointArray);

					Point2Region(tempPointArray);
					regionArrayCollection.Add(tempRegion);

					regionPath = (GraphicsPath)mousePath.Clone();
					regionPath.CloseFigure();
					regionCollection.Add(new Region(regionPath));
					drawImageType.Add(ImageType.Path);
					break;
				case ImageType.Pick:
					if(picked == true&&mouseMove == true&&changed!=true)
					{
						int MoveX = newPoint.EndP.X-newPoint.StartP.X;
						int MoveY = newPoint.EndP.Y-newPoint.StartP.Y;
						regionCollection[regionIndex].Translate(MoveX, MoveY);
						foreach(Region r in regionArrayCollection[regionIndex])
						{
							r.Translate(MoveX, MoveY);
						}
						if(drawImageType[regionIndex]==(int)ImageType.Path)
						{
							Matrix translateMatrix = new Matrix();
							translateMatrix.Translate(MoveX, MoveY);
							mousePath.Transform(translateMatrix);
							drawingList[regionIndex].pathChange(mousePath,false);
						}
					}
					if(changed == true&&mouseMove == true&&drawImageType[regionIndex]!=(int)ImageType.Path)
					{
						int MoveX = newPoint.EndP.X-newPoint.StartP.X;
						int MoveY = newPoint.EndP.Y-newPoint.StartP.Y;
						regionArrayCollection[regionIndex][pointIndex].Translate(MoveX,MoveY);
						RegionChange(regionIndex);
						if(drawImageType[regionIndex]==(int)ImageType.Rectangle
							||drawImageType[regionIndex]==(int)ImageType.FillRectangle
							||drawImageType[regionIndex]==(int)ImageType.Ellipse
							||drawImageType[regionIndex]==(int)ImageType.FillEllipse)
						{
							pointArray[regionIndex][0] = tempChangePoint.StartP;
							pointArray[regionIndex][1] = tempChangePoint.EndP;
							drawingList[regionIndex].pointchange(pointArray[regionIndex]);
							Point2Region(pointArray[regionIndex]);
							regionArrayCollection[regionIndex] = tempRegion;
						}
					}
					mouseMove = false;
					break;
			}
			Drawing.Invalidate();
		}

		private void Drawing_MouseEnter(object sender, System.EventArgs e)
		{
			if(newType != ImageType.Eraser&&newType != ImageType.Pick)
				this.Cursor = System.Windows.Forms.Cursors.Cross;
			else
				this.Cursor = System.Windows.Forms.Cursors.Default;
		}

		private void Drawing_MouseLeave(object sender, System.EventArgs e)
		{
			this.Cursor = System.Windows.Forms.Cursors.Default;
		}
		#endregion

		#region 右键功能
		/// <summary>
		/// 右键功能。
		/// </summary>		
		private void menuItemSize1_Click(object sender, System.EventArgs e)
		{
			EraserSize = 2;
		}

		private void menuItemmenuItemSize2_Click(object sender, System.EventArgs e)
		{
			EraserSize = 4;
		}

		private void menuItemSize3_Click(object sender, System.EventArgs e)
		{
			EraserSize = 6;
		}

		private void menuItemCA_Click(object sender, System.EventArgs e)
		{
			newCircle.Show();
		}

		private void menuItemClose_Click(object sender, System.EventArgs e)
		{
			if(pointCollection.Count==0)
				return;
			tempPointArray = new Point[pointCollection.Count];
			byte[] tempByte = new byte[pointCollection.Count];
			int i = 0;
			foreach(Point newP in pointCollection)
			{
				tempPointArray[i] = newP;
				if(i==0)
					tempByte[i++] = (byte)PathPointType.Start;
				else
					tempByte[i++] = (byte)PathPointType.Line;
			}
			pointArray.Add(tempPointArray);
			Point2Region(tempPointArray);
			regionArrayCollection.Add(tempRegion);

			regionPath = new GraphicsPath(tempPointArray, tempByte);
			regionPath.CloseFigure();
			regionCollection.Add(new Region(regionPath));			
			switch(newType)
			{
				case ImageType.Polygon:
					drawingList.Add(new DPolygon(tempPointArray, newColor,lineWidth));
					drawImageType.Add(ImageType.Polygon);
					break;
				case ImageType.Curve:
					drawingList.Add(new DCurve(tempPointArray, newColor,lineWidth));
					drawImageType.Add(ImageType.Curve);
					break;
				case ImageType.ClosedCurve:
					drawingList.Add(new DClosedCurve(tempPointArray, newColor,lineWidth));
					drawImageType.Add(ImageType.ClosedCurve);
					break;
			}
			Drawing.Invalidate();
			pointCollection.RemoveRange(0,pointCollection.Count);
			tempPoint = new DShapeList();
		}
		private void menuItemLw_Click(object sender, System.EventArgs e)
		{
			tempType = newType;
			newType = ImageType.Set;
			newForm.Show();
			MakeForm();
		}
		#endregion

		#region 窗口事件
		/// <summary>
		/// 窗口事件。
		/// </summary>		
		private void MakeForm()
		{
			newForm.VisibleChanged += new EventHandler(newForm_VisibleChanged); 
		}
	
		private void MakeCircleAt()
		{
			newCircle.VisibleChanged +=new EventHandler(newCircle_VisibleChanged);
		}
		
		private void newForm_VisibleChanged(object sender, System.EventArgs e)
		{
			if(newForm.Visible == false)
			{
				switch(newType)
				{
					case ImageType.Text:
						if(newForm.cancle ==false)
						{
							eraser = true;
							notchangeList.Add(new DText(new Point[]{newPoint.StartP}, newColor, newForm.outText, newForm.txtSize,newForm.TxtFont));
							Drawing.Invalidate();
						}
						break;
					case ImageType.Set:
						if(newForm.cancle == false)
						{
							lineWidth = Convert.ToSingle(newForm.outText);
							newType = tempType;
						}
						break;
				}
			}
		}

		private void newCircle_VisibleChanged(object sender, System.EventArgs e)
		{
			if(newCircle.Visible == false)
			{
				if(newForm.cancle ==false)
				{
					tempPointArray = new Point[2]{newCircle.startP, newCircle.endP};
					pointArray.Add(tempPointArray);
					Point2Region(tempPointArray);
					regionArrayCollection.Add(tempRegion);
					Distance = (int)Math.Sqrt (Math.Pow((tempPointArray[0].X-tempPointArray[1].X),2.0)+Math.Pow((tempPointArray[0].Y-tempPointArray[1].Y),2.0));
					tempPointArray[0].Offset(-Distance,-Distance);
					diameter = Distance*2;
					regionCollection.Add(new Region(new Rectangle(tempPointArray[0], new Size(diameter, diameter))));
					drawingList.Add(new DArc(tempPointArray, newColor,lineWidth,newCircle.FirstAngle,newCircle.EndAngle));
					drawImageType.Add(ImageType.Circle);
					Drawing.Invalidate();
				}
			}
		}

		private void menuBeziers_Click(object sender, System.EventArgs e)
		{
			Example newWindow = new Example();
			newWindow.Show();
		}

		
		#endregion

		#region 主菜单选项
		/// <summary>
		/// 图形存储集合等。
		/// </summary>		
		private void menuNew_Click(object sender, System.EventArgs e)
		{
			drawingList = new DShapeList();
			drawingListUndo = new DShapeList();
			tempPoint = new DShapeList();
			pointViewList = new DShapeList();
			notchangeList = new DShapeList();
			notchangeListUndo = new DShapeList();

			newForm = new NewForm();
			newCircle = new CircleForm();

			pointCollection = new ArrayList();

			regionCollection = new NewRegion();
			regionCollectionUndo = new NewRegion();
			pointArray = new PointArrayCollection();
			pointArrayUndo = new PointArrayCollection();

			regionArrayCollection = new NewRegionArray();
			regionArrayCollectionUndo = new NewRegionArray();
			drawImageType = new Type();
			drawImageTypeUndo = new Type();
			newType = ImageType.Empty;
			
			picked = false;
			changed = false;
			mouseMove = false;
			eraser = false;
			regionIndex = 0;

			Drawing.Invalidate();

			fileName = "NewFile";
			SetFormTitle();
		}

		private void menuOpen_Click(object sender, System.EventArgs e)
		{
			if(openFileDialog.ShowDialog() == DialogResult.OK)
			{
				fileName = openFileDialog.FileName;
				try
				{
					FileStream newStream = (FileStream)openFileDialog.OpenFile();
					newImage = new Bitmap(newStream);
					drawingList = new DShapeList();
					newType = ImageType.Empty;
					Point p = new Point(0,0);

					notchangeList.Add(new DImage(p,newImage));					
					eraser = true;

					Drawing.Invalidate();
					newStream.Close();
					SetFormTitle();
				}
				catch(IOException err)
				{
					MessageBox.Show(err.Message,"myPGS",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
				}
			}
		}

		private void menuSave_Click(object sender, System.EventArgs e)
		{
			if(fileName=="NewFile")
			{
				menuSaveAs_Click(sender,e);
			}
			else
			{
				SaveFile();
			}
		}

		private void menuSaveAs_Click(object sender, System.EventArgs e)
		{
			if(saveFileDialog.ShowDialog() == DialogResult.OK)
			{
				fileName =saveFileDialog.FileName;
				SaveFile();
				SetFormTitle();
			}
		}
		
		protected void SaveFile()
		{
			try
			{
				FileStream newfile = (FileStream)saveFileDialog.OpenFile();

				Point p = new Point(0,0);
				int width;
				int heigh;
				width = Drawing.Width;
				heigh = Drawing.Height;
				Rectangle r= new Rectangle(p,new Size(width,heigh));
				Image i = new Bitmap(width, heigh);
				Graphics g = Graphics.FromImage(i);
				g.FillRectangle(new SolidBrush(Color.White),r);
				if(eraser == true)
					notchangeList.DrawList(g);
				drawingList.DrawList(g);
				newImage = i;

				if(fileName != "")
				{
					switch(saveFileDialog.FilterIndex)
					{
						case 1:
							newImage.Save(newfile,System.Drawing.Imaging.ImageFormat.Jpeg);
							break;
						case 2:
							newImage.Save(newfile,System.Drawing.Imaging.ImageFormat.Bmp);
							break;
						case 3:
							newImage.Save(newfile,System.Drawing.Imaging.ImageFormat.Gif);
							break;
						default:
							newImage.Save(newfile,System.Drawing.Imaging.ImageFormat.Bmp);
							break;
					}
				}
				newfile.Close();
			}
			catch(IOException err)
			{
				MessageBox.Show(err.Message,"myPGS",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
			}
		}

		private void menuExit_Click(object sender, System.EventArgs e)
		{
			Application.Exit();
		}		

		protected void SetFormTitle()
		{
			FileInfo fileinfo = new FileInfo(fileName);
			this.Text = fileinfo.Name + " - myPGS";
		}

		private void Report_Click(object sender, System.EventArgs e)
		{
			System.Diagnostics.Process.Start("/CodeCommentReport/Solution_GraphicalCS.HTM");
		}

		private void Help_Click(object sender, System.EventArgs e)
		{
			System.Diagnostics.Process.Start("pgsHELP.hlp");
		}

		private void About_Click(object sender, System.EventArgs e)
		{
			About about = new About();
			about.Show();
		}
		#endregion

		#region 颜色
		/// <summary>
		/// 颜色。
		/// </summary>		
		private void Black_Click(object sender, System.EventArgs e)
		{
			this.btnColor.BackColor = this.Black.BackColor;
			newColor = this.Black.BackColor;
		}

		private void White_Click(object sender, System.EventArgs e)
		{
			this.btnColor.BackColor = this.White.BackColor;
			newColor = this.White.BackColor;
		}

		private void Red_Click(object sender, System.EventArgs e)
		{
			this.btnColor.BackColor = this.Red.BackColor;
			newColor = this.Red.BackColor;
		}

		private void blue_Click(object sender, System.EventArgs e)
		{
			this.btnColor.BackColor = this.blue.BackColor;
			newColor = this.blue.BackColor;
		}

		private void Yellow_Click(object sender, System.EventArgs e)
		{
			this.btnColor.BackColor = this.Yellow.BackColor;
			newColor = this.Yellow.BackColor;
		}

		private void LawnGreen_Click(object sender, System.EventArgs e)
		{
			this.btnColor.BackColor = this.LawnGreen.BackColor;
			newColor = this.LawnGreen.BackColor;
		}

		private void Cyan_Click(object sender, System.EventArgs e)
		{
			this.btnColor.BackColor = this.Cyan.BackColor;
			newColor = this.Cyan.BackColor;
		}

		private void Magenta_Click(object sender, System.EventArgs e)
		{
			this.btnColor.BackColor = this.Magenta.BackColor;
			newColor = this.Magenta.BackColor;
		}

		private void MoreColor_Click(object sender, System.EventArgs e)
		{
			if(colorDialog.ShowDialog() == DialogResult.OK)
			{
                this.btnColor.BackColor = colorDialog.Color;
				newColor = colorDialog.Color;
			}
		}
		#endregion

		#region 滤境
		/// <summary>
		/// 颜色。
		/// </summary>		
		private void FadeInOut_Click(object sender, System.EventArgs e)
		{
			if(newImage==null)
				return;
			Point p = new Point(0,0);
			int width;
			int heigh;
			width = newImage.Width;
			heigh = newImage.Height;
			Rectangle r= new Rectangle(p,new Size(width,heigh));
			Image im = new Bitmap(width, heigh);
			Graphics gr = Graphics.FromImage(im);
			gr.FillRectangle(new SolidBrush(Color.White),r);
			notchangeList.DrawList(gr);
			newImage = im;
			Graphics g=this.Drawing.CreateGraphics();
			g.Clear(Color.Black);
			Bitmap bitmap=(Bitmap)newImage;
			int iWidth = bitmap.Width;
			int iHeight = bitmap.Height;

			//初始化色彩变换矩阵
			float[][] tem={
			new float[]{0.0f, 0.0f, 0.0f, 0.0f, 0.0f},
			new float[]{0.0f, 0.0f, 0.0f, 0.0f, 0.0f},
			new float[]{0.0f, 0.0f, 0.0f, 0.0f, 0.0f},
			new float[]{0.0f, 0.0f, 0.0f, 1.0f, 0.0f},
			new float[]{0.0f, 0.0f, 0.0f, 0.0f, 1.0f}
						  };
			
			ColorMatrix colorMatrix=new ColorMatrix(tem);
			ImageAttributes imageAtt=new ImageAttributes();

			//从0到1进行修改色彩变换矩阵主对角线上的数值
			//使三种基准色的饱和度渐增
			for(float i=0.0f;i<=1.0f;i+=0.02f)
			{	
				colorMatrix.Matrix00=i;
				colorMatrix.Matrix11=i;
				colorMatrix.Matrix22=i;
				colorMatrix.Matrix33=i;
				//设置色彩校正矩阵
				imageAtt.SetColorMatrix(colorMatrix,
					ColorMatrixFlag.Default,ColorAdjustType.Bitmap);
				//绘制图片
				g.DrawImage(
					bitmap, new Rectangle(0, 0, iWidth, iHeight), 
					0,0,        
					iWidth,iHeight,
					GraphicsUnit.Pixel, 
					imageAtt);
			}

			MessageBox.Show("下面演示淡出效果");
	
			//从1到0进行修改色彩变换矩阵主对角线上的数值
			//依次减少每种色彩分量
			for(float i=1.0f;i>=0.0f;i-=0.02f)
			{	
				colorMatrix.Matrix00=i;
				colorMatrix.Matrix11=i;
				colorMatrix.Matrix22=i;
				colorMatrix.Matrix33=i;
				//设置色彩校正矩阵
				imageAtt.SetColorMatrix(colorMatrix,
					ColorMatrixFlag.Default,ColorAdjustType.Bitmap);
				//绘制图片
				g.DrawImage(
					bitmap, new Rectangle(0, 0, iWidth, iHeight), 
					0,0,        
					iWidth,iHeight,
					GraphicsUnit.Pixel, 
					imageAtt);
			}
			Drawing.Invalidate();
			g.Dispose();
		}

		private void GrayScale1_Click(object sender, System.EventArgs e)
		{
			if(newImage==null)
				return;
			Graphics g=this.Drawing.CreateGraphics();
			g.Clear(Color.White);
			Bitmap image=(Bitmap)newImage;			
			int Width =image.Width-1;
			int Height =image.Height-1;

			Color color;
			//使用平均值进行灰度处理
			for(int i=Width; i>=0;i--)
				for( int j=Height; j>=0;j--)
				{
					color=image.GetPixel(i,j);	
					//求出平均三个色彩分量的平均值
					int middle=(color.R+
						color.G+color.B)/3;
					Color colorResult=Color.FromArgb(255,middle,middle,middle);
					image.SetPixel(i, j, colorResult);
				}	
			//重新绘制灰度化图
			g.DrawImage(
				image, new Rectangle(0, 0, Width, Height));
			g.Dispose();
		}

		private void GrayScale2_Click(object sender, System.EventArgs e)
		{
			if(newImage==null)
				return;
			Graphics g=this.Drawing.CreateGraphics();
			g.Clear(Color.White);
			Bitmap image=(Bitmap)newImage;			
			int Width =image.Width-1;
			int Height =image.Height-1;
			Color color;
			for(int i=Width; i>=0;i--)
			{
				for(int j=Height; j>=0;j--)
				{
					color=image.GetPixel(i,j);	
					int tmp=Math.Max(color.R,color.G);
					int maxcolor=Math.Max(tmp,color.B);
					Color colorResult=Color.FromArgb(255,maxcolor,maxcolor,maxcolor);
					//设置处理后的灰度信息
					image.SetPixel(i, j, colorResult);
				}	
			}

			//重新绘制灰度化图
			g.DrawImage(
				image, new Rectangle(0, 0, Width, Height));
			g.Dispose();
		}

		private void grayScale3_Click(object sender, System.EventArgs e)
		{
			if(newImage==null)
				return;
			Graphics g=this.Drawing.CreateGraphics();
			g.Clear(Color.White);
			Bitmap image=(Bitmap)newImage;			
			int Width =image.Width-1;
			int Height =image.Height-1;
			Color color;
			//使用加权平均法进行灰度处理	
			for(int i=Width; i>=0;i--)
			{
				for(int j=Height; j>=0;j--)
				{
					color=image.GetPixel(i, j);	
					int R=(int)(0.3f*color.R);
					int G=(int)(0.59f*color.G);
					int B=(int)(0.11f*color.B);
			
					Color colorResult=Color.FromArgb(255,R,G,B);
					//设置处理后的灰度信息
					image.SetPixel(i, j, colorResult);
				}	
			}
			//重新绘制灰度化图
			g.DrawImage(
				image, new Rectangle(0, 0, Width, Height));
			g.Dispose();
		}

		private void GrayScale4_Click(object sender, System.EventArgs e)
		{
			if(newImage==null)
				return;
			Graphics g=this.Drawing.CreateGraphics();
			g.Clear(Color.White);
			Bitmap image=(Bitmap)newImage;			
			int Width =image.Width-1;
			int Height =image.Height-1;
			Color color;
			//灰度的还原演示，还原使用最大值法处理的灰度图像image2
			for(int i=Width; i>0;i--)
			{
				for(int j=Height; j>0;j--)
				{
					color=image.GetPixel(i,j);	
					int R=color.R;
					int G=color.G;
					int B=color.B;
					//分别对RGB三种色彩分量进行伪彩色还原

					//进行红色分量的还原
					if(R<127)
						R=0;
					if(R>=192)
						R=255;
					if(R<=191&&R>=128)
						R=4*R-510;

					/*进行绿色分量的还原,为了还原后的绿色分量再次参加比较，
					这里设置一个变量YES表示G是否已经参加了比较*/

					bool yes;
					yes=false;
					if(G<=191&&G>=128&&(!yes))
					{
						G=255;
						yes=true;
					}
					if(G>=192&&(!yes))
					{
						G=1022-4*G;
						yes=true;
					}
					if(G<=63&&(!yes))
					{
						G=254-4*G;
						yes=true;
					}
					if(G<=127&&G>=67&&(!yes))
						G=4*G-257;
			
					//进行蓝色分量的还原
					if(B<=63)
						B=255;
					if(B>=128)
						B=0;
					if(B>=67&&B<=127)
						B=510-4*B;
			
					//还原后的伪彩色
					Color colorResult=Color.FromArgb(255,R,G,B);
					//将还原后的RGB信息重新写入位图
					image.SetPixel(i, j, colorResult);
					
				}	
			}
			//重新绘制还原后的伪彩色位图
			//重新绘制灰度化图
			g.DrawImage(
				image, new Rectangle(0, 0, Width, Height));
			g.Dispose();
		}

		private void Inverse_Click(object sender, System.EventArgs e)
		{
			if(newImage==null)
				return;
			Graphics graphics=this.Drawing.CreateGraphics();
			graphics.Clear(Color.White);					
			graphics.ScaleTransform(0.7f,0.7f);
			Bitmap image=(Bitmap)newImage;					
			int Width =image.Width;
			int Height =image.Height;
			Color color;
			//绘制原图
			//graphics.DrawImage(
				//image, new Rectangle(0, 0, Width, Height));
	
			for(int  i=0;i<Width;i++)
			{
				for( int j=0; j<Height;j++)
				{
					color=image.GetPixel(i, j);
					//将色彩进行反转，获得底片效果
					int r=255-color.R;
					int g=255-color.G;
					int b=255-color.B;
					Color colorResult=Color.FromArgb(255,r,g,b);
					//将还原后的RGB信息重新写入位图
					image.SetPixel(i, j, colorResult);
				}
				//动态绘制底片滤镜效果图
				graphics.DrawImage(
					image, new Rectangle(0, 0, Width, Height));
			}
			//将已经实现了底片效果的位图再反色(恢复到原图)
			for( int i=0;i<Width;i++)
			{
				for( int j=0; j<Height;j++)
				{
					color=image.GetPixel(i, j);
					int r=255-color.R;
					int g=255-color.G;
					int b=255-color.B;
					Color colorResult=Color.FromArgb(255,r,g,b);
					//将还原后的RGB信息重新写入位图
					image.SetPixel(i, j, colorResult);
				}
				//绘制经过两次反色的位图
				graphics.DrawImage(
					image, new Rectangle(0, 0, Width, Height));
			}
			graphics.Dispose();
		}

		private void Flashligt_Click(object sender, System.EventArgs e)
		{
			if(newImage==null)
				return;
			Graphics graphics=this.Drawing.CreateGraphics();
			graphics.Clear(Color.White);	
			Bitmap image=(Bitmap)newImage;
			int Width = image.Width;
			int Height = image.Height;
			int A=Width/2;
			int B=Height/2;
			//Center:图片中心点，发亮此值会让强光中心发生偏移
			Point Center=new Point(A,B);
			//R：强光照射面的半径，即”光晕”
			int R=100;
			Color color;
			Color colorTemp;
			//依次访问每个像素
		
			for(int x=0;x<Width;x++)
			{
				for( int y=0; y<Height;y++)
				{
					Point tmp=new Point(x,y);
					//如果像素位于”光晕”之内
					if(fDistance(tmp,Center)<R)
					{
						color=image.GetPixel(x, y);
						int r,g,b;
						//根据该点距离强光中心点的距离，分别让RGB值变量
						//220:亮度增加常量，该值越大，光亮度越强
						float tmp_r=220.0f*(1.0f-fDistance(tmp,Center)/R);
				
						r=color.R+(int)tmp_r;
						r=Math.Max(0,Math.Min(r,255));
				
						g=color.G+(int)tmp_r;
						g=Math.Max(0,Math.Min(g,255));
						b=color.B+(int)tmp_r;
						b=Math.Max(0,Math.Min(b,255));
		
						colorTemp=Color.FromArgb(255,(int)r,(int)g,(int)b);
						//将增亮后的像素值回写到位图
						image.SetPixel(x, y, colorTemp);
					}
				}
				//动态绘制滤镜效果图
				graphics.DrawImage(
					image, new Rectangle(0, 0, Width, Height));
			}
			graphics.Dispose();
		}
		//计算两点A、B之间的绝对距离
		float fDistance(Point A,Point B)
		{
			double i=Math.Pow((A.X-B.X),2)+Math.Pow((A.Y-B.Y),2);
			return (float)Math.Sqrt(i);
		}

		private void BlurAndSharpen_Click(object sender, System.EventArgs e)
		{
			if(newImage==null)
				return;
			Graphics graphics=this.Drawing.CreateGraphics();
			graphics.Clear(Color.White);		
			graphics.ScaleTransform(0.8f,0.8f);
			//Image tempImage = (Image)newImage.Clone();
			Bitmap image=(Bitmap)newImage;
			int Width = image.Width;
			int Height = image.Height;
			//image2:进行锐化处理
			//Bitmap image2=(Bitmap)newImage.Clone();
			Color colorTemp;
			Color[,] color=new Color[3,3];

			for(int i=1;i<Width-2;i++)
			{
				for( int j=1; j<Height-2;j++)
				{
					//访问周围9个点的RGB值
					color[0,0]=image.GetPixel(i-1, j-1);
					color[0,1]=image.GetPixel(i-1, j);
					color[0,2]=image.GetPixel(i-1, j+1);

					color[1,0]=image.GetPixel(i, j-1);
					color[1,1]=image.GetPixel(i, j);
					color[1,2]=image.GetPixel(i, j+1);

					color[2,0]=image.GetPixel(i+1, j-1);
					color[2,1]=image.GetPixel(i+1, j);
					color[2,2]=image.GetPixel(i+1, j+1);

					int rSum=0;
					int gSum=0;
					int bSum=0;
					//分别求出周围9个点的R、G、B之和
					for(int n=0;n<3;n++)
						for(int nn=0;nn<3;nn++)
						{
							rSum+=color[n,nn].R;	
							gSum+=color[n,nn].G;	
							bSum+=color[n,nn].B;	
						}
					//用RGB的平均值做为当前点的RGB值
					colorTemp=Color.FromArgb(255,
						(int)(rSum/9),(int)(gSum/9),(int)(bSum/9));
					//将计算后的RGB值回写到位图
					image.SetPixel(i, j,colorTemp);
				}
				//绘制经过平滑处理的效果图
				graphics.DrawImage(
					image, new Rectangle(0, 0, Width, Height));
			}

			//进行锐化处理
			Bitmap image2=(Bitmap)newImage.Clone();
			Color colorLeft,colornow;
			//常量dep：锐化系数，此值越大，锐化效果越明显
			float dep=0.550f;
			for(int i=1;i<Width-1; i++)
			{
				for( int j=1;j<Height-1; j++)
				{
					colornow=image2.GetPixel(i, j);	
					colorLeft=image2.GetPixel(i-1, j-1);	

					float r=colornow.R+(colornow.R
						-colorLeft.R*dep);
					r=Math.Min(255,Math.Max(0,r));

					float g=colornow.G+(colornow.G
						-colorLeft.G*dep);
					g=Math.Min(255,Math.Max(0,g));
					float b=colornow.B+(colornow.B
						-colorLeft.B*dep);
					b=Math.Min(255,Math.Max(0,b));
		
					colorTemp=Color.FromArgb(255,(int)r,(int)g,(int)b);

					//将计算后的RGB值回写到位图
					image.SetPixel(i, j, colorTemp);
				}
				graphics.DrawImage(
					image2, new Rectangle(0, 0, Width, Height));
			}
			graphics.Dispose();
		}
		#endregion						

        private void saveFileDialog_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FileStream newfile = (FileStream)saveFileDialog.OpenFile();

            Point p = new Point(0, 0);
            int width;
            int heigh;
            width = Drawing.Width;
            heigh = Drawing.Height;
            Rectangle r = new Rectangle(p, new Size(width, heigh));
            Image i = new Bitmap(width, heigh);
            Graphics g = Graphics.FromImage(i);
            g.FillRectangle(new SolidBrush(Color.White), r);
            if (eraser == true)
                notchangeList.DrawList(g);
            drawingList.DrawList(g);
            newImage = i;

            //newImage.Save("d:\\temp.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);

            fm1.queryImage = newImage;
            fm1.Picture_Show(newImage, fm1.QueryPicBox);

            this.Close();
        }

      
	}
}

using System;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace GraphicalCS
{
	/// <summary>
	/// MousePoint 的摘要说明。
	/// </summary>
	public class MousePoint
	{
		private Point pStart;
		private Point pEnd;
		private Point pRealStart;
		private Point pRealEnd;
		private Size  pRealSize;
		private Rectangle pRect;
		private GraphicsPath pPath;
		public MousePoint(int X, int Y)
		{
			//
			// TODO: 在此处添加构造函数逻辑
			//
			pStart.X = X;
			pStart.Y = Y;
            pEnd.X = X;//Point.Empty;
            pEnd.Y = Y;
			pRealStart = Point.Empty;
			pRealEnd = Point.Empty;
			pRealSize = Size.Empty;
			pRect = Rectangle.Empty;
		}

		public int EndX
		{
			set
			{
				pEnd.X = value;
			}
			get
			{
				return pEnd.X;
			}			
		}

		public int EndY
		{
			set
			{
				pEnd.Y = value;
			}
			get
			{
				return pEnd.Y;
			}			
		}

		public Point StartP
		{
			get
			{
				//ChangeToReal();
				if(pRealStart == Point.Empty)return pStart;
				return pRealStart; 
			}
		}

		public Point EndP
		{
			get
			{
				//ChangeToReal();
				if(pRealEnd == Point.Empty)return pEnd;
				return pRealEnd;
			}
		}

		public Size newSize
		{
			get
			{
				return pRealSize;
			}
		}
			
		public Rectangle Rect
		{
			get
			{
				ChangeToReal();
				pRect.Location=pRealStart;
				pRect.Size= pRealSize;
				return pRect;
			}
		}

		public GraphicsPath Path
		{
			set
			{
				pPath = value;
			}
			get
			{
				return pPath;
			}
		}

		//矩形橡皮筋
		private void ChangeToReal()
		{
			//In first quadrant
			if ((pEnd.X>pStart.X) && (pEnd.Y>pStart.Y))
			{
				pRealStart = pStart;
				pRealEnd = pEnd;
				pRealSize = new Size(pRealEnd.X-pRealStart.X, pRealEnd.Y-pRealStart.Y);
				return;
			}

			//In second quadrant
			if ((pEnd.X<pStart.X) && (pEnd.Y<pStart.Y))
			{
				pRealEnd = pStart;
				pRealStart = pEnd;
				pRealSize = new Size(pRealEnd.X-pRealStart.X, pRealEnd.Y-pRealStart.Y);
				return;
			}

			//In third quadrant
			if ((pEnd.X<pStart.X) && (pEnd.Y>pStart.Y))
			{
				pRealStart.X = pEnd.X;
				pRealStart.Y = pStart.Y;
				pRealEnd.X   = pStart.X;
				pRealEnd.Y   = pEnd.Y;
				pRealSize = new Size(pRealEnd.X-pRealStart.X, pRealEnd.Y-pRealStart.Y);
				return;
			}

			//In forth quadrant
			if ((pEnd.X>pStart.X) && (pEnd.Y<pStart.Y))
			{
				pRealStart.X = pStart.X;
				pRealStart.Y = pEnd.Y;
				pRealEnd.X   = pEnd.X;
				pRealEnd.Y   = pStart.Y;
				pRealSize = new Size(pRealEnd.X-pRealStart.X, pRealEnd.Y-pRealStart.Y);
				return;
			}
		}
	}
}

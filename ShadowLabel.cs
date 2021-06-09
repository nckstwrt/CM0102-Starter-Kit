using System;
using System.ComponentModel;
using System.Collections;
using System.Diagnostics;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace MJW.Guardian.RuntimeComponents
{   
	/// <summary>
	/// Summary description for ShadowLabel.
	/// </summary>
	[ToolboxItem(true)]
	public class ShadowLabel : Label
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private bool _drawGradient = false;
      private Color _startColor = Color.White;
      private Color _endColor = Color.LightSkyBlue;
      private float _angle = 0;

      private bool _drawShadow = true;
      private float _yOffset = 2;
      private float _xOffset = 2;
      private Color _shadowColor = Color.FromArgb(135, 0, 0, 0);
      
		private System.ComponentModel.Container components = null;

		public ShadowLabel(System.ComponentModel.IContainer container)
		{
			///
			/// Required for Windows.Forms Class Composition Designer support
			///
			container.Add(this);
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		public ShadowLabel()
		{
			///
			/// Required for Windows.Forms Class Composition Designer support
			///
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary> 
		/// Clean up any resources being used.
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

      protected override void OnPaint(PaintEventArgs e)
      {
         base.OnPaint (e);
         e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

         if ( _drawGradient == true )
         {
            LinearGradientBrush brush = new LinearGradientBrush( new Rectangle( 0,0, this.Width, this.Height), _startColor, _endColor, _angle, true );
            e.Graphics.FillRectangle( brush, 0, 0, this.Width, this.Height );
         }

         if( _drawShadow == true )
            e.Graphics.DrawString( this.Text, this.Font, new SolidBrush( _shadowColor ), _xOffset, _yOffset, StringFormat.GenericDefault );
         e.Graphics.DrawString( this.Text, this.Font, new SolidBrush( this.ForeColor ), 0, 0, StringFormat.GenericDefault );                  
      }

      [ Category("Gradient"),
      Description("Set to true to draw the gradient background"),
      DefaultValue(true)]
      public bool DrawGradient
      {
         get{ return this._drawGradient; }
         set{ this._drawGradient = value; this.Invalidate(); }
      }

      [ Category("Gradient"),
      Description("The start color of the gradient"),
      DefaultValue(typeof(Color),"Color.White")]
      public Color StartColor
      {
         get{ return this._startColor; }
         set{ this._startColor = value; this.Invalidate(); }
      }

      [ Category("Gradient"),
      Description("The end color of the gradient"),
      DefaultValue(typeof(Color),"Color.LightSkyBlue")]
      public Color EndColor
      {
         get{ return this._endColor; }
         set{ this._endColor = value; this.Invalidate(); }
      }   

      [ Category("Gradient"),
      Description("The angle of the gradient"),
      DefaultValue(0)]
      public float Angle
      {
         get{ return this._angle; }
         set{ this._angle = value; this.Invalidate(); }
      }   
   
      [ Category("Drop Shadow"),
      Description("Set to true to draw the Drop Shadow"),
      DefaultValue(true)]
      public bool DrawShadow
      {
         get{ return this._drawShadow; }
         set{ this._drawShadow = value; this.Invalidate(); }
      }

      [ Category("Drop Shadow"),
      Description("The X Offset used to draw the shadow"),
      DefaultValue(1)]
      public float XOffset
      {
         get{ return this._xOffset; }
         set{ this._xOffset = value; this.Invalidate(); }
      }

      [ Category("Drop Shadow"),
      Description("The Y Offset used to draw the shadow"),
      DefaultValue(1)]
      public float YOffset
      {
         get{ return this._yOffset; }
         set{ this._yOffset = value; this.Invalidate(); }
      }

      [ Category("Drop Shadow"),
      Description("The color used to draw the shadow"),
      DefaultValue(typeof(System.Drawing.Color),"Color.Black")]
      public Color ShadowColor
      {
         get{ return this._shadowColor; }
         set{ this._shadowColor = value; this.Invalidate(); }
      }       

		#region Component Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			components = new System.ComponentModel.Container();         
         this.ForeColor = Color.LightSkyBlue;
		}
		#endregion
	}
}

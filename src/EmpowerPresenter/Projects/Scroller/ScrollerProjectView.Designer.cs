using System.Drawing;
namespace EmpowerPresenter
{
	partial class ScrollerProjectView
	{
		private System.ComponentModel.IContainer components = null;

		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Component Designer generated code
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScrollerProjectView));
			this.themedPanel1 = new Vendisoft.Controls.ThemedPanel();
			this.lblInfo = new System.Windows.Forms.Label();
			this.btnFont = new Vendisoft.Controls.ImageButton();
			this.btnSave = new Vendisoft.Controls.ImageButton();
			this.lblTitle = new System.Windows.Forms.Label();
			this.pnlMainContainer = new System.Windows.Forms.Panel();
			this.txtMessage = new System.Windows.Forms.TextBox();
			this.txtRight = new System.Windows.Forms.TextBox();
			this.txtLeft = new System.Windows.Forms.TextBox();
			this.btnClose = new Vendisoft.Controls.ImageButton();
			this.btnActivate = new Vendisoft.Controls.ImageButton();
			this.themedPanel1.SuspendLayout();
			this.pnlMainContainer.SuspendLayout();
			this.SuspendLayout();
			// 
			// themedPanel1
			// 
			this.themedPanel1.BackColor = System.Drawing.Color.Transparent;
			this.themedPanel1.BottomSplice = 50;
			this.themedPanel1.Controls.Add(this.lblInfo);
			this.themedPanel1.Controls.Add(this.btnFont);
			this.themedPanel1.Controls.Add(this.btnSave);
			this.themedPanel1.Controls.Add(this.lblTitle);
			this.themedPanel1.Controls.Add(this.pnlMainContainer);
			this.themedPanel1.Controls.Add(this.btnClose);
			this.themedPanel1.Controls.Add(this.btnActivate);
			resources.ApplyResources(this.themedPanel1, "themedPanel1");
			this.themedPanel1.Image = global::EmpowerPresenter.Properties.Resources.panelbackground;
			this.themedPanel1.LeftSlice = 50;
			this.themedPanel1.Name = "themedPanel1";
			this.themedPanel1.RightSplice = 50;
			this.themedPanel1.TopSplice = 50;
			// 
			// lblInfo
			// 
			resources.ApplyResources(this.lblInfo, "lblInfo");
			this.lblInfo.BackColor = System.Drawing.Color.Transparent;
			this.lblInfo.Name = "lblInfo";
			// 
			// btnFont
			// 
			this.btnFont.BackColor = System.Drawing.Color.Transparent;
			this.btnFont.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnFont.DisabledImg = global::EmpowerPresenter.Properties.Resources.font_d;
			this.btnFont.IsHighlighted = false;
			this.btnFont.IsPressed = false;
			this.btnFont.IsSelected = false;
			resources.ApplyResources(this.btnFont, "btnFont");
			this.btnFont.Name = "btnFont";
			this.btnFont.NormalImg = global::EmpowerPresenter.Properties.Resources.font_n;
			this.btnFont.OverImg = global::EmpowerPresenter.Properties.Resources.font_n;
			this.btnFont.PressedImg = global::EmpowerPresenter.Properties.Resources.font_n;
			this.btnFont.Tag = "Change font";
			this.btnFont.MouseLeave += new System.EventHandler(this.btnMouseLeave);
			this.btnFont.Click += new System.EventHandler(this.btnFont_Click);
			this.btnFont.MouseEnter += new System.EventHandler(this.btnMouseEnter);
			// 
			// btnSave
			// 
			this.btnSave.BackColor = System.Drawing.Color.Transparent;
			this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnSave.DisabledImg = global::EmpowerPresenter.Properties.Resources.save_dis;
			this.btnSave.IsHighlighted = false;
			this.btnSave.IsPressed = false;
			this.btnSave.IsSelected = false;
			resources.ApplyResources(this.btnSave, "btnSave");
			this.btnSave.Name = "btnSave";
			this.btnSave.NormalImg = global::EmpowerPresenter.Properties.Resources.save;
			this.btnSave.OverImg = global::EmpowerPresenter.Properties.Resources.save;
			this.btnSave.PressedImg = global::EmpowerPresenter.Properties.Resources.save;
			this.btnSave.Tag = "Save";
			this.btnSave.MouseLeave += new System.EventHandler(this.btnMouseLeave);
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			this.btnSave.MouseEnter += new System.EventHandler(this.btnMouseEnter);
			// 
			// lblTitle
			// 
			resources.ApplyResources(this.lblTitle, "lblTitle");
			this.lblTitle.Name = "lblTitle";
			// 
			// pnlMainContainer
			// 
			resources.ApplyResources(this.pnlMainContainer, "pnlMainContainer");
			this.pnlMainContainer.BackColor = System.Drawing.Color.Black;
			this.pnlMainContainer.Controls.Add(this.txtMessage);
			this.pnlMainContainer.Controls.Add(this.txtRight);
			this.pnlMainContainer.Controls.Add(this.txtLeft);
			this.pnlMainContainer.Name = "pnlMainContainer";
			// 
			// txtMessage
			// 
			resources.ApplyResources(this.txtMessage, "txtMessage");
			this.txtMessage.BackColor = System.Drawing.Color.DimGray;
			this.txtMessage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtMessage.ForeColor = System.Drawing.Color.White;
			this.txtMessage.Name = "txtMessage";
			this.txtMessage.TextChanged += new System.EventHandler(this.txtLeft_TextChanged);
			// 
			// txtRight
			// 
			resources.ApplyResources(this.txtRight, "txtRight");
			this.txtRight.BackColor = System.Drawing.Color.DimGray;
			this.txtRight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtRight.ForeColor = System.Drawing.Color.White;
			this.txtRight.Name = "txtRight";
			this.txtRight.TextChanged += new System.EventHandler(this.txtLeft_TextChanged);
			// 
			// txtLeft
			// 
			this.txtLeft.BackColor = System.Drawing.Color.DimGray;
			this.txtLeft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtLeft.ForeColor = System.Drawing.Color.White;
			resources.ApplyResources(this.txtLeft, "txtLeft");
			this.txtLeft.Name = "txtLeft";
			this.txtLeft.TextChanged += new System.EventHandler(this.txtLeft_TextChanged);
			// 
			// btnClose
			// 
			resources.ApplyResources(this.btnClose, "btnClose");
			this.btnClose.BackColor = System.Drawing.Color.Transparent;
			this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnClose.DisabledImg = global::EmpowerPresenter.Properties.Resources.close_n;
			this.btnClose.IsHighlighted = false;
			this.btnClose.IsPressed = false;
			this.btnClose.IsSelected = false;
			this.btnClose.Name = "btnClose";
			this.btnClose.NormalImg = global::EmpowerPresenter.Properties.Resources.close_n;
			this.btnClose.OverImg = global::EmpowerPresenter.Properties.Resources.close_o;
			this.btnClose.PressedImg = global::EmpowerPresenter.Properties.Resources.close_n;
			this.btnClose.Tag = "Close";
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// btnActivate
			// 
			this.btnActivate.BackColor = System.Drawing.Color.Transparent;
			this.btnActivate.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnActivate.DisabledImg = global::EmpowerPresenter.Properties.Resources.activate_btnd;
			this.btnActivate.IsHighlighted = false;
			this.btnActivate.IsPressed = false;
			this.btnActivate.IsSelected = false;
			resources.ApplyResources(this.btnActivate, "btnActivate");
			this.btnActivate.Name = "btnActivate";
			this.btnActivate.NormalImg = global::EmpowerPresenter.Properties.Resources.activate_btnn;
			this.btnActivate.OverImg = ((System.Drawing.Image)(resources.GetObject("btnActivate.OverImg")));
			this.btnActivate.PressedImg = global::EmpowerPresenter.Properties.Resources.activate_btnn;
			this.btnActivate.Click += new System.EventHandler(this.btnActivate_Click);
			// 
			// ScrollerProjectView
			// 
			resources.ApplyResources(this, "$this");
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
			this.Controls.Add(this.themedPanel1);
			this.DoubleBuffered = true;
			this.Name = "ScrollerProjectView";
			this.themedPanel1.ResumeLayout(false);
			this.pnlMainContainer.ResumeLayout(false);
			this.pnlMainContainer.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private Vendisoft.Controls.ThemedPanel themedPanel1;
		private Vendisoft.Controls.ImageButton btnActivate;
		private Vendisoft.Controls.ImageButton btnClose;
		private System.Windows.Forms.Panel pnlMainContainer;
		private System.Windows.Forms.Label lblTitle;
		private System.Windows.Forms.TextBox txtLeft;
		private System.Windows.Forms.TextBox txtRight;
		private System.Windows.Forms.TextBox txtMessage;
		private Vendisoft.Controls.ImageButton btnSave;
		private Vendisoft.Controls.ImageButton btnFont;
		private System.Windows.Forms.Label lblInfo;
	}
}

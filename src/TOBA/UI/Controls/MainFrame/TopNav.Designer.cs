namespace TOBA.UI.Controls.MainFrame
{
	partial class TopNav
	{
		/// <summary> 
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// 清理所有正在使用的资源。
		/// </summary>
		/// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region 组件设计器生成的代码

		/// <summary> 
		/// 设计器支持所需的方法 - 不要修改
		/// 使用代码编辑器修改此方法的内容。
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            this.panLinks = new DevComponents.DotNetBar.PanelEx();
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.label1 = new System.Windows.Forms.Label();
            this.de = new TOBA.UI.Controls.Common.DateComboBox();
            this.btnOpt = new DevComponents.DotNetBar.ButtonX();
            this.btnLogin = new DevComponents.DotNetBar.ButtonX();
            this.btnLogin_None = new DevComponents.DotNetBar.ButtonItem();
            this.btnLogin_New = new DevComponents.DotNetBar.ButtonItem();
            this.btnLoginUsingQr = new DevComponents.DotNetBar.ButtonItem();
            this.btnQueryWithoutLogin = new DevComponents.DotNetBar.ButtonItem();
            this.btnImport = new DevComponents.DotNetBar.ButtonItem();
            this.ctx = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ctxRegDonate = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxRegInner = new System.Windows.Forms.ToolStripMenuItem();
            this.panLinks.SuspendLayout();
            this.panelEx1.SuspendLayout();
            this.ctx.SuspendLayout();
            this.SuspendLayout();
            // 
            // panLinks
            // 
            this.panLinks.CanvasColor = System.Drawing.SystemColors.Control;
            this.panLinks.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panLinks.Controls.Add(this.panelEx1);
            this.panLinks.Controls.Add(this.btnOpt);
            this.panLinks.Controls.Add(this.btnLogin);
            this.panLinks.DisabledBackColor = System.Drawing.Color.Empty;
            this.panLinks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panLinks.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.panLinks.Location = new System.Drawing.Point(0, 0);
            this.panLinks.Name = "panLinks";
            this.panLinks.Size = new System.Drawing.Size(990, 42);
            this.panLinks.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panLinks.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panLinks.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panLinks.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panLinks.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panLinks.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panLinks.Style.GradientAngle = 90;
            this.panLinks.TabIndex = 12;
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx1.Controls.Add(this.label1);
            this.panelEx1.Controls.Add(this.de);
            this.panelEx1.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelEx1.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.panelEx1.Location = new System.Drawing.Point(734, 0);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(256, 42);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.Purple;
            this.label1.Location = new System.Drawing.Point(4, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "售至";
            // 
            // de
            // 
            this.de.FormattingEnabled = true;
            this.de.Location = new System.Drawing.Point(39, 8);
            this.de.Name = "de";
            this.de.Size = new System.Drawing.Size(211, 25);
            this.de.TabIndex = 12;
            // 
            // btnOpt
            // 
            this.btnOpt.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnOpt.ColorTable = DevComponents.DotNetBar.eButtonColor.Orange;
            this.btnOpt.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnOpt.Image = global::TOBA.Properties.Resources.gear_16;
            this.btnOpt.Location = new System.Drawing.Point(182, 0);
            this.btnOpt.Name = "btnOpt";
            this.btnOpt.Size = new System.Drawing.Size(80, 42);
            this.btnOpt.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnOpt.TabIndex = 14;
            this.btnOpt.Text = "设置";
            // 
            // btnLogin
            // 
            this.btnLogin.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnLogin.AntiAlias = true;
            this.btnLogin.AutoExpandOnClick = true;
            this.btnLogin.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnLogin.Image = global::TOBA.Properties.Resources.cou_32_users;
            this.btnLogin.Location = new System.Drawing.Point(0, 0);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(182, 42);
            this.btnLogin.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnLogin.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnLogin_None,
            this.btnLogin_New,
            this.btnLoginUsingQr,
            this.btnQueryWithoutLogin,
            this.btnImport});
            this.btnLogin.SubItemsExpandWidth = 20;
            this.btnLogin.TabIndex = 13;
            this.btnLogin.Text = "<b>登录12306</b>";
            // 
            // btnLogin_None
            // 
            this.btnLogin_None.Enabled = false;
            this.btnLogin_None.Name = "btnLogin_None";
            this.btnLogin_None.Text = "(没有已记录的账号...)";
            // 
            // btnLogin_New
            // 
            this.btnLogin_New.Name = "btnLogin_New";
            this.btnLogin_New.Text = "使用登录对话框...";
            // 
            // btnLoginUsingQr
            // 
            this.btnLoginUsingQr.GlobalItem = false;
            this.btnLoginUsingQr.Name = "btnLoginUsingQr";
            this.btnLoginUsingQr.Text = "使用二维码登录...";
            // 
            // btnQueryWithoutLogin
            // 
            this.btnQueryWithoutLogin.GlobalItem = false;
            this.btnQueryWithoutLogin.Image = global::TOBA.Properties.Resources.testtube_16;
            this.btnQueryWithoutLogin.Name = "btnQueryWithoutLogin";
            this.btnQueryWithoutLogin.Text = "不登录直接查票";
            // 
            // btnImport
            // 
            this.btnImport.GlobalItem = false;
            this.btnImport.Image = global::TOBA.Properties.Resources.layer_import;
            this.btnImport.Name = "btnImport";
            this.btnImport.Text = "导入代购信息";
            // 
            // ctx
            // 
            this.ctx.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctxRegDonate,
            this.ctxRegInner});
            this.ctx.Name = "ctx";
            this.ctx.Size = new System.Drawing.Size(113, 48);
            // 
            // ctxRegDonate
            // 
            this.ctxRegDonate.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold);
            this.ctxRegDonate.ForeColor = System.Drawing.Color.Purple;
            this.ctxRegDonate.Image = global::TOBA.Properties.Resources.heart_16;
            this.ctxRegDonate.Name = "ctxRegDonate";
            this.ctxRegDonate.Size = new System.Drawing.Size(112, 22);
            this.ctxRegDonate.Text = "捐助版";
            // 
            // ctxRegInner
            // 
            this.ctxRegInner.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold);
            this.ctxRegInner.ForeColor = System.Drawing.Color.RoyalBlue;
            this.ctxRegInner.Image = global::TOBA.Properties.Resources.cou_32_users;
            this.ctxRegInner.Name = "ctxRegInner";
            this.ctxRegInner.Size = new System.Drawing.Size(112, 22);
            this.ctxRegInner.Text = "内部版";
            // 
            // TopNav
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panLinks);
            this.Name = "TopNav";
            this.Size = new System.Drawing.Size(990, 42);
            this.panLinks.ResumeLayout(false);
            this.panelEx1.ResumeLayout(false);
            this.panelEx1.PerformLayout();
            this.ctx.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		#endregion

		private DevComponents.DotNetBar.PanelEx panLinks;
		private DevComponents.DotNetBar.ButtonX btnLogin;
		private DevComponents.DotNetBar.ButtonItem btnLogin_None;
		private DevComponents.DotNetBar.ButtonItem btnLogin_New;
		private DevComponents.DotNetBar.ButtonX btnOpt;
		private DevComponents.DotNetBar.ButtonItem btnQueryWithoutLogin;
		private DevComponents.DotNetBar.ButtonItem btnImport;
		private System.Windows.Forms.ContextMenuStrip ctx;
		private System.Windows.Forms.ToolStripMenuItem ctxRegDonate;
		private System.Windows.Forms.ToolStripMenuItem ctxRegInner;
		private DevComponents.DotNetBar.PanelEx panelEx1;
		private System.Windows.Forms.Label label1;
		private Common.DateComboBox de;
		private DevComponents.DotNetBar.ButtonItem btnLoginUsingQr;
	}
}

namespace ProTimer.Views
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.bunifuFormDock = new Bunifu.UI.WinForms.BunifuFormDock();
            this.lblCountdown = new Bunifu.UI.WinForms.BunifuLabel();
            this.lblAppName = new Bunifu.UI.WinForms.BunifuLabel();
            this.countdownTimer = new System.Windows.Forms.Timer(this.components);
            this.bunifuToolTip = new Bunifu.UI.WinForms.BunifuToolTip(this.components);
            this.lblCountdownSet = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuImageButton1 = new Bunifu.UI.WinForms.BunifuImageButton();
            this.bunifuButton1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnInfo = new Bunifu.UI.WinForms.BunifuImageButton();
            this.btnClose = new Bunifu.UI.WinForms.BunifuImageButton();
            this.btnReset = new Bunifu.UI.WinForms.BunifuUserControl();
            this.btnStop = new Bunifu.UI.WinForms.BunifuUserControl();
            this.btnPlayPause = new Bunifu.UI.WinForms.BunifuUserControl();
            this.fontsInstaller = new WK.Libraries.FontsInstallerNS.FontsInstaller(this.components);
            this.SuspendLayout();
            // 
            // bunifuFormDock
            // 
            this.bunifuFormDock.AllowFormDragging = true;
            this.bunifuFormDock.AllowFormDropShadow = true;
            this.bunifuFormDock.AllowFormResizing = false;
            this.bunifuFormDock.AllowHidingBottomRegion = true;
            this.bunifuFormDock.AllowOpacityChangesWhileDragging = false;
            this.bunifuFormDock.BorderOptions.BottomBorder.BorderColor = System.Drawing.Color.Silver;
            this.bunifuFormDock.BorderOptions.BottomBorder.BorderThickness = 1;
            this.bunifuFormDock.BorderOptions.BottomBorder.ShowBorder = true;
            this.bunifuFormDock.BorderOptions.LeftBorder.BorderColor = System.Drawing.Color.Silver;
            this.bunifuFormDock.BorderOptions.LeftBorder.BorderThickness = 1;
            this.bunifuFormDock.BorderOptions.LeftBorder.ShowBorder = true;
            this.bunifuFormDock.BorderOptions.RightBorder.BorderColor = System.Drawing.Color.Silver;
            this.bunifuFormDock.BorderOptions.RightBorder.BorderThickness = 1;
            this.bunifuFormDock.BorderOptions.RightBorder.ShowBorder = true;
            this.bunifuFormDock.BorderOptions.TopBorder.BorderColor = System.Drawing.Color.Silver;
            this.bunifuFormDock.BorderOptions.TopBorder.BorderThickness = 1;
            this.bunifuFormDock.BorderOptions.TopBorder.ShowBorder = true;
            this.bunifuFormDock.ContainerControl = this;
            this.bunifuFormDock.DockingIndicatorsColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(215)))), ((int)(((byte)(233)))));
            this.bunifuFormDock.DockingIndicatorsOpacity = 0.5D;
            this.bunifuFormDock.DockingOptions.DockAll = true;
            this.bunifuFormDock.DockingOptions.DockBottomLeft = true;
            this.bunifuFormDock.DockingOptions.DockBottomRight = true;
            this.bunifuFormDock.DockingOptions.DockFullScreen = true;
            this.bunifuFormDock.DockingOptions.DockLeft = true;
            this.bunifuFormDock.DockingOptions.DockRight = true;
            this.bunifuFormDock.DockingOptions.DockTopLeft = true;
            this.bunifuFormDock.DockingOptions.DockTopRight = true;
            this.bunifuFormDock.FormDraggingOpacity = 0.9D;
            this.bunifuFormDock.ParentForm = this;
            this.bunifuFormDock.ShowCursorChanges = true;
            this.bunifuFormDock.ShowDockingIndicators = true;
            this.bunifuFormDock.TitleBarOptions.AllowFormDragging = true;
            this.bunifuFormDock.TitleBarOptions.BunifuFormDock = this.bunifuFormDock;
            this.bunifuFormDock.TitleBarOptions.DoubleClickToExpandWindow = true;
            this.bunifuFormDock.TitleBarOptions.TitleBarControl = null;
            this.bunifuFormDock.TitleBarOptions.UseBackColorOnDockingIndicators = false;
            // 
            // lblCountdown
            // 
            this.lblCountdown.AutoEllipsis = false;
            this.lblCountdown.CursorType = null;
            this.lblCountdown.Font = new System.Drawing.Font("Product Sans", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountdown.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblCountdown.Location = new System.Drawing.Point(152, 79);
            this.lblCountdown.Name = "lblCountdown";
            this.lblCountdown.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblCountdown.Size = new System.Drawing.Size(413, 124);
            this.lblCountdown.TabIndex = 0;
            this.lblCountdown.Text = "00:00:00";
            this.lblCountdown.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblCountdown.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            this.bunifuToolTip.SetToolTip(this.lblCountdown, "");
            this.bunifuToolTip.SetToolTipIcon(this.lblCountdown, null);
            this.bunifuToolTip.SetToolTipTitle(this.lblCountdown, "");
            // 
            // lblAppName
            // 
            this.lblAppName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblAppName.AutoEllipsis = false;
            this.lblAppName.CursorType = null;
            this.lblAppName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppName.ForeColor = System.Drawing.Color.White;
            this.lblAppName.Location = new System.Drawing.Point(31, 374);
            this.lblAppName.Name = "lblAppName";
            this.lblAppName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblAppName.Size = new System.Drawing.Size(90, 20);
            this.lblAppName.TabIndex = 1;
            this.lblAppName.Text = "PRO<span style=\"color: silver;\">TIMER</span> <span style=\"color: darkgray;\"></spa" +
    "n>";
            this.lblAppName.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblAppName.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            this.bunifuToolTip.SetToolTip(this.lblAppName, "");
            this.bunifuToolTip.SetToolTipIcon(this.lblAppName, null);
            this.bunifuToolTip.SetToolTipTitle(this.lblAppName, "");
            // 
            // countdownTimer
            // 
            this.countdownTimer.Interval = 1000;
            // 
            // bunifuToolTip
            // 
            this.bunifuToolTip.Active = true;
            this.bunifuToolTip.AlignTextWithTitle = false;
            this.bunifuToolTip.AllowAutoClose = false;
            this.bunifuToolTip.AllowFading = true;
            this.bunifuToolTip.AutoCloseDuration = 5000;
            this.bunifuToolTip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.bunifuToolTip.BorderColor = System.Drawing.Color.Gainsboro;
            this.bunifuToolTip.ClickToShowDisplayControl = false;
            this.bunifuToolTip.ConvertNewlinesToBreakTags = true;
            this.bunifuToolTip.DisplayControl = null;
            this.bunifuToolTip.EntryAnimationSpeed = 350;
            this.bunifuToolTip.ExitAnimationSpeed = 200;
            this.bunifuToolTip.GenerateAutoCloseDuration = false;
            this.bunifuToolTip.IconMargin = 6;
            this.bunifuToolTip.InitialDelay = 0;
            this.bunifuToolTip.Name = "bunifuToolTip";
            this.bunifuToolTip.Opacity = 1D;
            this.bunifuToolTip.OverrideToolTipTitles = false;
            this.bunifuToolTip.Padding = new System.Windows.Forms.Padding(10);
            this.bunifuToolTip.ReshowDelay = 100;
            this.bunifuToolTip.ShowAlways = true;
            this.bunifuToolTip.ShowBorders = false;
            this.bunifuToolTip.ShowIcons = true;
            this.bunifuToolTip.ShowShadows = true;
            this.bunifuToolTip.Tag = null;
            this.bunifuToolTip.TextFont = new System.Drawing.Font("Segoe UI", 9F);
            this.bunifuToolTip.TextForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuToolTip.TextMargin = 2;
            this.bunifuToolTip.TitleFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.bunifuToolTip.TitleForeColor = System.Drawing.Color.Black;
            this.bunifuToolTip.ToolTipPosition = new System.Drawing.Point(0, 0);
            this.bunifuToolTip.ToolTipTitle = null;
            // 
            // lblCountdownSet
            // 
            this.lblCountdownSet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblCountdownSet.AutoEllipsis = false;
            this.lblCountdownSet.CursorType = null;
            this.lblCountdownSet.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13F);
            this.lblCountdownSet.ForeColor = System.Drawing.Color.White;
            this.lblCountdownSet.Location = new System.Drawing.Point(322, 53);
            this.lblCountdownSet.Name = "lblCountdownSet";
            this.lblCountdownSet.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblCountdownSet.Size = new System.Drawing.Size(73, 22);
            this.lblCountdownSet.TabIndex = 10;
            this.lblCountdownSet.Text = "30<span style=\"color: silver;\">:00</span><span style=\"color: darkgray;\">:00</span" +
    ">";
            this.lblCountdownSet.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblCountdownSet.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            this.bunifuToolTip.SetToolTip(this.lblCountdownSet, "");
            this.bunifuToolTip.SetToolTipIcon(this.lblCountdownSet, null);
            this.bunifuToolTip.SetToolTipTitle(this.lblCountdownSet, "");
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.ActiveImage = null;
            this.bunifuImageButton1.AllowAnimations = true;
            this.bunifuImageButton1.AllowBuffering = false;
            this.bunifuImageButton1.AllowZooming = false;
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.ErrorImage")));
            this.bunifuImageButton1.FadeWhenInactive = true;
            this.bunifuImageButton1.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.ImageLocation = null;
            this.bunifuImageButton1.ImageMargin = 17;
            this.bunifuImageButton1.ImageSize = new System.Drawing.Size(23, 23);
            this.bunifuImageButton1.ImageZoomSize = new System.Drawing.Size(40, 40);
            this.bunifuImageButton1.InitialImage = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.InitialImage")));
            this.bunifuImageButton1.Location = new System.Drawing.Point(578, 6);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Rotation = 0;
            this.bunifuImageButton1.ShowActiveImage = true;
            this.bunifuImageButton1.ShowCursorChanges = true;
            this.bunifuImageButton1.ShowImageBorders = true;
            this.bunifuImageButton1.ShowSizeMarkers = false;
            this.bunifuImageButton1.Size = new System.Drawing.Size(40, 40);
            this.bunifuImageButton1.TabIndex = 9;
            this.bunifuToolTip.SetToolTip(this.bunifuImageButton1, "Change settings");
            this.bunifuToolTip.SetToolTipIcon(this.bunifuImageButton1, null);
            this.bunifuImageButton1.ToolTipText = "";
            this.bunifuToolTip.SetToolTipTitle(this.bunifuImageButton1, "");
            this.bunifuImageButton1.WaitOnLoad = false;
            this.bunifuImageButton1.Zoom = 17;
            this.bunifuImageButton1.ZoomSpeed = 10;
            // 
            // bunifuButton1
            // 
            this.bunifuButton1.AllowToggling = false;
            this.bunifuButton1.AnimationSpeed = 200;
            this.bunifuButton1.AutoGenerateColors = true;
            this.bunifuButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuButton1.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(168)))), ((int)(((byte)(185)))));
            this.bunifuButton1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuButton1.BackgroundImage")));
            this.bunifuButton1.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton1.ButtonText = "BETA";
            this.bunifuButton1.ButtonTextMarginLeft = 0;
            this.bunifuButton1.ColorContrastOnClick = 45;
            this.bunifuButton1.ColorContrastOnHover = 45;
            this.bunifuButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.bunifuButton1.CustomizableEdges = borderEdges1;
            this.bunifuButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bunifuButton1.DisabledBorderColor = System.Drawing.Color.Empty;
            this.bunifuButton1.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bunifuButton1.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.bunifuButton1.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.bunifuButton1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F);
            this.bunifuButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(125)))), ((int)(((byte)(151)))));
            this.bunifuButton1.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuButton1.IconMarginLeft = 11;
            this.bunifuButton1.IconPadding = 10;
            this.bunifuButton1.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuButton1.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(168)))), ((int)(((byte)(185)))));
            this.bunifuButton1.IdleBorderRadius = 2;
            this.bunifuButton1.IdleBorderThickness = 1;
            this.bunifuButton1.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(168)))), ((int)(((byte)(185)))));
            this.bunifuButton1.IdleIconLeftImage = null;
            this.bunifuButton1.IdleIconRightImage = null;
            this.bunifuButton1.IndicateFocus = false;
            this.bunifuButton1.Location = new System.Drawing.Point(125, 375);
            this.bunifuButton1.Name = "bunifuButton1";
            this.bunifuButton1.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(207)))), ((int)(((byte)(216)))));
            this.bunifuButton1.onHoverState.BorderRadius = 2;
            this.bunifuButton1.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton1.onHoverState.BorderThickness = 1;
            this.bunifuButton1.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(207)))), ((int)(((byte)(216)))));
            this.bunifuButton1.onHoverState.ForeColor = System.Drawing.Color.White;
            this.bunifuButton1.onHoverState.IconLeftImage = null;
            this.bunifuButton1.onHoverState.IconRightImage = null;
            this.bunifuButton1.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(168)))), ((int)(((byte)(185)))));
            this.bunifuButton1.OnIdleState.BorderRadius = 2;
            this.bunifuButton1.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton1.OnIdleState.BorderThickness = 1;
            this.bunifuButton1.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(168)))), ((int)(((byte)(185)))));
            this.bunifuButton1.OnIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(125)))), ((int)(((byte)(151)))));
            this.bunifuButton1.OnIdleState.IconLeftImage = null;
            this.bunifuButton1.OnIdleState.IconRightImage = null;
            this.bunifuButton1.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(92)))), ((int)(((byte)(101)))));
            this.bunifuButton1.OnPressedState.BorderRadius = 2;
            this.bunifuButton1.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton1.OnPressedState.BorderThickness = 1;
            this.bunifuButton1.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(92)))), ((int)(((byte)(101)))));
            this.bunifuButton1.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.bunifuButton1.OnPressedState.IconLeftImage = null;
            this.bunifuButton1.OnPressedState.IconRightImage = null;
            this.bunifuButton1.Size = new System.Drawing.Size(47, 20);
            this.bunifuButton1.TabIndex = 8;
            this.bunifuButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuButton1.TextMarginLeft = 0;
            this.bunifuToolTip.SetToolTip(this.bunifuButton1, "");
            this.bunifuToolTip.SetToolTipIcon(this.bunifuButton1, null);
            this.bunifuToolTip.SetToolTipTitle(this.bunifuButton1, "");
            this.bunifuButton1.UseDefaultRadiusAndThickness = true;
            // 
            // btnInfo
            // 
            this.btnInfo.ActiveImage = null;
            this.btnInfo.AllowAnimations = true;
            this.btnInfo.AllowBuffering = false;
            this.btnInfo.AllowZooming = false;
            this.btnInfo.BackColor = System.Drawing.Color.Transparent;
            this.btnInfo.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btnInfo.ErrorImage")));
            this.btnInfo.FadeWhenInactive = true;
            this.btnInfo.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.btnInfo.Image = ((System.Drawing.Image)(resources.GetObject("btnInfo.Image")));
            this.btnInfo.ImageActive = null;
            this.btnInfo.ImageLocation = null;
            this.btnInfo.ImageMargin = 20;
            this.btnInfo.ImageSize = new System.Drawing.Size(20, 20);
            this.btnInfo.ImageZoomSize = new System.Drawing.Size(40, 40);
            this.btnInfo.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnInfo.InitialImage")));
            this.btnInfo.Location = new System.Drawing.Point(623, 5);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Rotation = 0;
            this.btnInfo.ShowActiveImage = true;
            this.btnInfo.ShowCursorChanges = true;
            this.btnInfo.ShowImageBorders = true;
            this.btnInfo.ShowSizeMarkers = false;
            this.btnInfo.Size = new System.Drawing.Size(40, 40);
            this.btnInfo.TabIndex = 7;
            this.bunifuToolTip.SetToolTip(this.btnInfo, "About ProTimer");
            this.bunifuToolTip.SetToolTipIcon(this.btnInfo, null);
            this.btnInfo.ToolTipText = "";
            this.bunifuToolTip.SetToolTipTitle(this.btnInfo, "");
            this.btnInfo.WaitOnLoad = false;
            this.btnInfo.Zoom = 20;
            this.btnInfo.ZoomSpeed = 10;
            // 
            // btnClose
            // 
            this.btnClose.ActiveImage = null;
            this.btnClose.AllowAnimations = true;
            this.btnClose.AllowBuffering = false;
            this.btnClose.AllowZooming = false;
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btnClose.ErrorImage")));
            this.btnClose.FadeWhenInactive = true;
            this.btnClose.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageActive = null;
            this.btnClose.ImageLocation = null;
            this.btnClose.ImageMargin = 20;
            this.btnClose.ImageSize = new System.Drawing.Size(20, 20);
            this.btnClose.ImageZoomSize = new System.Drawing.Size(40, 40);
            this.btnClose.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnClose.InitialImage")));
            this.btnClose.Location = new System.Drawing.Point(667, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Rotation = 0;
            this.btnClose.ShowActiveImage = true;
            this.btnClose.ShowCursorChanges = true;
            this.btnClose.ShowImageBorders = true;
            this.btnClose.ShowSizeMarkers = false;
            this.btnClose.Size = new System.Drawing.Size(40, 40);
            this.btnClose.TabIndex = 6;
            this.bunifuToolTip.SetToolTip(this.btnClose, "Exit ProTimer");
            this.bunifuToolTip.SetToolTipIcon(this.btnClose, null);
            this.btnClose.ToolTipText = "";
            this.bunifuToolTip.SetToolTipTitle(this.btnClose, "");
            this.btnClose.WaitOnLoad = false;
            this.btnClose.Zoom = 20;
            this.btnClose.ZoomSpeed = 10;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // btnReset
            // 
            this.btnReset.AllowAnimations = true;
            this.btnReset.AllowBorderColorChanges = true;
            this.btnReset.AllowMouseEffects = true;
            this.btnReset.AnimationSpeed = 200;
            this.btnReset.BackColor = System.Drawing.Color.Transparent;
            this.btnReset.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnReset.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(122)))), ((int)(((byte)(144)))));
            this.btnReset.BorderRadius = 2;
            this.btnReset.BorderThickness = 5;
            this.btnReset.ColorContrastOnClick = 30;
            this.btnReset.ColorContrastOnHover = 30;
            this.btnReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReset.Image = ((System.Drawing.Image)(resources.GetObject("btnReset.Image")));
            this.btnReset.ImageMargin = new System.Windows.Forms.Padding(3, 2, 4, -4);
            this.btnReset.Location = new System.Drawing.Point(423, 220);
            this.btnReset.Name = "btnReset";
            this.btnReset.ShowBorders = true;
            this.btnReset.Size = new System.Drawing.Size(78, 78);
            this.btnReset.Style = Bunifu.UI.WinForms.BunifuUserControl.UserControlStyles.Round;
            this.btnReset.TabIndex = 4;
            this.bunifuToolTip.SetToolTip(this.btnReset, "Set new countdown");
            this.bunifuToolTip.SetToolTipIcon(this.btnReset, null);
            this.bunifuToolTip.SetToolTipTitle(this.btnReset, "");
            this.btnReset.Click += new System.EventHandler(this.BtnReset_Click);
            this.btnReset.MouseHover += new System.EventHandler(this.BtnReset_MouseHover);
            // 
            // btnStop
            // 
            this.btnStop.AllowAnimations = true;
            this.btnStop.AllowBorderColorChanges = true;
            this.btnStop.AllowMouseEffects = true;
            this.btnStop.AnimationSpeed = 200;
            this.btnStop.BackColor = System.Drawing.Color.Transparent;
            this.btnStop.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnStop.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(122)))), ((int)(((byte)(144)))));
            this.btnStop.BorderRadius = 2;
            this.btnStop.BorderThickness = 5;
            this.btnStop.ColorContrastOnClick = 30;
            this.btnStop.ColorContrastOnHover = 30;
            this.btnStop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStop.Image = ((System.Drawing.Image)(resources.GetObject("btnStop.Image")));
            this.btnStop.ImageMargin = new System.Windows.Forms.Padding(2, 0, 3, 0);
            this.btnStop.Location = new System.Drawing.Point(215, 220);
            this.btnStop.Name = "btnStop";
            this.btnStop.ShowBorders = true;
            this.btnStop.Size = new System.Drawing.Size(78, 78);
            this.btnStop.Style = Bunifu.UI.WinForms.BunifuUserControl.UserControlStyles.Round;
            this.btnStop.TabIndex = 3;
            this.bunifuToolTip.SetToolTip(this.btnStop, "Stop/reset countdown");
            this.bunifuToolTip.SetToolTipIcon(this.btnStop, null);
            this.bunifuToolTip.SetToolTipTitle(this.btnStop, "");
            this.btnStop.Click += new System.EventHandler(this.BtnStop_Click);
            // 
            // btnPlayPause
            // 
            this.btnPlayPause.AllowAnimations = true;
            this.btnPlayPause.AllowBorderColorChanges = true;
            this.btnPlayPause.AllowMouseEffects = true;
            this.btnPlayPause.AnimationSpeed = 200;
            this.btnPlayPause.BackColor = System.Drawing.Color.Transparent;
            this.btnPlayPause.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(108)))), ((int)(((byte)(83)))));
            this.btnPlayPause.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(108)))), ((int)(((byte)(83)))));
            this.btnPlayPause.BorderRadius = 2;
            this.btnPlayPause.BorderThickness = 2;
            this.btnPlayPause.ColorContrastOnClick = 30;
            this.btnPlayPause.ColorContrastOnHover = 30;
            this.btnPlayPause.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlayPause.Image = ((System.Drawing.Image)(resources.GetObject("btnPlayPause.Image")));
            this.btnPlayPause.ImageMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.btnPlayPause.Location = new System.Drawing.Point(315, 214);
            this.btnPlayPause.Name = "btnPlayPause";
            this.btnPlayPause.ShowBorders = true;
            this.btnPlayPause.Size = new System.Drawing.Size(90, 90);
            this.btnPlayPause.Style = Bunifu.UI.WinForms.BunifuUserControl.UserControlStyles.Round;
            this.btnPlayPause.TabIndex = 2;
            this.bunifuToolTip.SetToolTip(this.btnPlayPause, "Play/pause countdown");
            this.bunifuToolTip.SetToolTipIcon(this.btnPlayPause, null);
            this.bunifuToolTip.SetToolTipTitle(this.btnPlayPause, "");
            this.btnPlayPause.Click += new System.EventHandler(this.BtnPlayPause_Click);
            // 
            // fontsInstaller
            // 
            this.fontsInstaller.AutoInstall = true;
            this.fontsInstaller.AutoRestart = true;
            this.fontsInstaller.ContainerControl = this;
            this.fontsInstaller.CustomInstallerDialog = null;
            this.fontsInstaller.DialogOptions.CollapsedContent = "{Fonts}";
            this.fontsInstaller.DialogOptions.Content = "In order for \'{AppName}\' to look neat and work effectively, {FontsRequiredExpress" +
    "ion} to be installed in your system before proceeding. To view {FontsExpression}" +
    ", click \"See details\".";
            this.fontsInstaller.DialogOptions.CustomIcon = null;
            this.fontsInstaller.DialogOptions.ShowAppIcon = true;
            this.fontsInstaller.DialogOptions.ShowCancelButton = false;
            this.fontsInstaller.DialogOptions.Title = "Fonts installation required";
            this.fontsInstaller.DialogOptions.UseElevationIcon = false;
            this.fontsInstaller.DialogOptions.WindowTitle = "{AppName}";
            this.fontsInstaller.FontsListBullet = "         +";
            this.fontsInstaller.ParentForm = this;
            this.fontsInstaller.TestingMode = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(125)))), ((int)(((byte)(151)))));
            this.ClientSize = new System.Drawing.Size(717, 417);
            this.Controls.Add(this.lblCountdownSet);
            this.Controls.Add(this.bunifuImageButton1);
            this.Controls.Add(this.bunifuButton1);
            this.Controls.Add(this.btnInfo);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnPlayPause);
            this.Controls.Add(this.lblAppName);
            this.Controls.Add(this.lblCountdown);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuFormDock bunifuFormDock;
        private Bunifu.UI.WinForms.BunifuLabel lblAppName;
        private Bunifu.UI.WinForms.BunifuLabel lblCountdown;
        private Bunifu.UI.WinForms.BunifuUserControl btnPlayPause;
        private Bunifu.UI.WinForms.BunifuUserControl btnStop;
        private Bunifu.UI.WinForms.BunifuUserControl btnReset;
        public System.Windows.Forms.Timer countdownTimer;
        private Bunifu.UI.WinForms.BunifuImageButton btnClose;
        private Bunifu.UI.WinForms.BunifuToolTip bunifuToolTip;
        private WK.Libraries.FontsInstallerNS.FontsInstaller fontsInstaller;
        private Bunifu.UI.WinForms.BunifuImageButton btnInfo;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton bunifuButton1;
        private Bunifu.UI.WinForms.BunifuImageButton bunifuImageButton1;
        private Bunifu.UI.WinForms.BunifuLabel lblCountdownSet;
    }
}
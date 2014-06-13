namespace AddToWunderlistForOutlook
{
    partial class WunderlistRibbon : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public WunderlistRibbon()
            : base(Globals.Factory.GetRibbonFactory())
        {
            InitializeComponent();
        }

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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Microsoft.Office.Tools.Ribbon.RibbonDialogLauncher ribbonDialogLauncherImpl1 = this.Factory.CreateRibbonDialogLauncher();
            this.tab1 = this.Factory.CreateRibbonTab();
            this.tabWunderlist = this.Factory.CreateRibbonTab();
            this.groupWunderlist = this.Factory.CreateRibbonGroup();
            this.btnAddToWunderlist = this.Factory.CreateRibbonButton();
            this.tab1.SuspendLayout();
            this.tabWunderlist.SuspendLayout();
            this.groupWunderlist.SuspendLayout();
            // 
            // tab1
            // 
            this.tab1.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
            this.tab1.Label = "TabAddIns";
            this.tab1.Name = "tab1";
            // 
            // tabWunderlist
            // 
            this.tabWunderlist.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
            this.tabWunderlist.ControlId.OfficeId = "TabMail";
            this.tabWunderlist.Groups.Add(this.groupWunderlist);
            this.tabWunderlist.Label = "TabMail";
            this.tabWunderlist.Name = "tabWunderlist";
            // 
            // groupWunderlist
            // 
            this.groupWunderlist.DialogLauncher = ribbonDialogLauncherImpl1;
            this.groupWunderlist.Items.Add(this.btnAddToWunderlist);
            this.groupWunderlist.Label = "Wunderlist";
            this.groupWunderlist.Name = "groupWunderlist";
            this.groupWunderlist.DialogLauncherClick += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.groupWunderlist_DialogLauncherClick);
            // 
            // btnAddToWunderlist
            // 
            this.btnAddToWunderlist.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.btnAddToWunderlist.Image = global::AddToWunderlistForOutlook.Properties.Resources.WunderlistIcon2_64;
            this.btnAddToWunderlist.Label = "Add to Wunderlist";
            this.btnAddToWunderlist.Name = "btnAddToWunderlist";
            this.btnAddToWunderlist.ShowImage = true;
            this.btnAddToWunderlist.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btnAddToWunderlist_Click);
            // 
            // WunderlistRibbon
            // 
            this.Name = "WunderlistRibbon";
            this.RibbonType = "Microsoft.Outlook.Explorer, Microsoft.Outlook.Post.Read";
            this.Tabs.Add(this.tab1);
            this.Tabs.Add(this.tabWunderlist);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.Ribbon1_Load);
            this.tab1.ResumeLayout(false);
            this.tab1.PerformLayout();
            this.tabWunderlist.ResumeLayout(false);
            this.tabWunderlist.PerformLayout();
            this.groupWunderlist.ResumeLayout(false);
            this.groupWunderlist.PerformLayout();

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab tab1;
        private Microsoft.Office.Tools.Ribbon.RibbonTab tabWunderlist;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup groupWunderlist;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnAddToWunderlist;
    }

    partial class ThisRibbonCollection
    {
        internal WunderlistRibbon Ribbon1
        {
            get { return this.GetRibbon<WunderlistRibbon>(); }
        }
    }
}

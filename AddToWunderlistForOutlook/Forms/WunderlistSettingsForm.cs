using System;
using System.Drawing;
using System.Windows.Forms;
using AddToWunderlistForOutlook.Model;
using AddToWunderlistForOutlook.UserControls;
using AddToWunderlistForOutlook.WunderlistApi;

namespace AddToWunderlistForOutlook.Forms
{
    public partial class WunderlistSettingsForm : Form
    {

        private readonly WlListSelector _wlListSelector1;
        private readonly Settings _settings;
        private readonly State _wunderlistState;

        public WunderlistSettingsForm(Settings settings, State wunderlistState)
        {
            _settings = settings;
            _wunderlistState = wunderlistState;

            InitializeComponent();

            _wlListSelector1 = new WlListSelector
                {
                    ListCollection = null,
                    Location = new System.Drawing.Point(16, 56),
                    Name = "wlListSelector1",
                    SelectedListId = "",
                    Size = new Size(269, 91),
                    TabIndex = 12
                };
            groupBox2.Controls.Add(_wlListSelector1);
        }

        private void WunderlistSettingsForm_Load(object sender, EventArgs e)
        {
            txtEmail.Text = _settings.Email;
            txtPassword.Text = _settings.Password;

            _wlListSelector1.EnableListAddition = false;

            RefreshForm();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            _settings.Email = txtEmail.Text;
            _settings.Password = txtPassword.Text;
            _settings.DefaultSaveListId = _wlListSelector1.SelectedListId;

            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel; 
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            _wunderlistState.Authenticate(txtEmail.Text, txtPassword.Text);

            RefreshForm();
        }

        private void RefreshForm()
        {
            if (_wunderlistState.Authenticated)
            {
                btnLogin.Text = @"Authenticated";
                btnLogin.Enabled = false;
            }

            _wunderlistState.GetLists();
            _wlListSelector1.ListCollection = _wunderlistState.WlListCollection;
            _wlListSelector1.SelectedListId = _settings.DefaultSaveListId;
            //_wlListSelector1.EnableSelector = !string.IsNullOrEmpty(_settings.DefaultSaveListId);
        }
  
    }
}

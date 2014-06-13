using System;
using System.Drawing;
using System.Windows.Forms;
using AddToWunderlistForOutlook.Model;
using AddToWunderlistForOutlook.UserControls;
using AddToWunderlistForOutlook.WunderlistApi;
using AddToWunderlistForOutlook.WunderlistApi.Model;
using Microsoft.Office.Interop.Outlook;

namespace AddToWunderlistForOutlook.Forms
{
    public partial class AddTaskActions : Form
    {

        private readonly WlListSelector _wlListSelector1;
        private readonly Panel _pnlSetDueDate;
        private readonly Panel _pnlSetReminder;

        private readonly Settings _settings;
        private readonly State _wunderlistState;
        private readonly MailItem _mailItem;
        private bool _starred;

        public WlTask Task { get; private set; }
        public DateTime ReminderDate { get; private set; }
        public bool SetReminder { get; private set; }
        public string NewListTitle { get; private set; }

        public AddTaskActions(Settings settings, State wunderlistState, MailItem mailItem)
        {
            _settings = settings;
            _wunderlistState = wunderlistState;
            _mailItem = mailItem;

            InitializeComponent();

            _wlListSelector1 = new WlListSelector
                {
                    ListCollection = null,
                    Location = new Point(373, 72),
                    Name = "wlListSelector1",
                    SelectedListId = "",
                    //Size = new Size(269, 91),
                    TabIndex = 12
                };
            Controls.Add(_wlListSelector1);

            _pnlSetDueDate = new Panel
                {
                    Size = dateDueDate.Size,
                    Location = dateDueDate.Location,
                    BackColor = Color.Transparent,
                };
            _pnlSetDueDate.Click += _pnlSetDueDate_Click;

            _pnlSetReminder = new Panel
            {
                Size = dateRemindDate.Size,
                Location = dateRemindDate.Location,
                BackColor = Color.Transparent,
            };
            Controls.Add(_pnlSetDueDate);
            Controls.Add(_pnlSetReminder);
            _pnlSetReminder.Click += _pnlSetReminder_Click;

            pictureBox1.Image = Properties.Resources.starred45;
        }

        void _pnlSetReminder_Click(object sender, EventArgs e)
        {
            dateRemindDate.Enabled = true;
            picRemindMeAccept.Image = Properties.Resources.save16;
            picRemindMeCancel.Image = Properties.Resources.cancel16;
        }

        void _pnlSetDueDate_Click(object sender, EventArgs e)
        {
            dateDueDate.Enabled = true;
            picDueDateAccept.Image = Properties.Resources.save16;
            picDueDateCancel.Image = Properties.Resources.cancel16;
        }

        private void SelectListForm_Load(object sender, EventArgs e)
        {
            txtTitle.Text = _mailItem.Subject;
            txtNote.Text = string.Format("From:\t\t{0}\r\nReceived:\t{1}\r\n\r\n{2}", 
                                        Outlook.Helper.GetSenderSmtpAddress(_mailItem),
                                        _mailItem.ReceivedTime,
                                        _mailItem.Body.Replace("\r\n\r\n \r\n\r\n","\r\n\r\n"));

            _wlListSelector1.ListCollection = _wunderlistState.WlListCollection;
            _wlListSelector1.SelectedListId = _settings.DefaultSaveListId;
            _wlListSelector1.EnableListAddition = true;

            txtTitle.Select(0,0);
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Task = new WlTask
                {
                    Title = txtTitle.Text,
                    Note = txtNote.Text,
                    Starred = _starred,
                };

            NewListTitle = _wlListSelector1.NewListTitle;
            if (_wlListSelector1.SelectedListId != string.Empty) Task.List_Id = _wlListSelector1.SelectedListId;

            if (dateDueDate.Enabled) Task.Due_Date = dateDueDate.Value;

            if (dateRemindDate.Enabled) SetReminder = true;
            ReminderDate = dateRemindDate.Value;

            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = _starred
                                    ? Properties.Resources.starred45
                                    : Properties.Resources.starredribbon45;
            _starred = !_starred;
        }

        private void picDueDateCancel_Click(object sender, EventArgs e)
        {
            dateDueDate.Enabled = false;
            picDueDateAccept.Image = null;
            picDueDateCancel.Image = null;
        }

        private void picRemindMeCancel_Click(object sender, EventArgs e)
        {
            dateRemindDate.Enabled = false;
            picRemindMeAccept.Image = null;
            picRemindMeCancel.Image = null;
        }

    }
}

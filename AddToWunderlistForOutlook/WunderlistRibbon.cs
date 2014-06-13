using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AddToWunderlistForOutlook.Forms;
using AddToWunderlistForOutlook.Model;
using AddToWunderlistForOutlook.WunderlistApi;
using Microsoft.Office.Interop.Outlook;
using Microsoft.Office.Tools.Ribbon;

namespace AddToWunderlistForOutlook
{
    public partial class WunderlistRibbon
    {
        // Current Outlook environment.
        private Explorer _activeExplorer;

        // User settings from AddToWunderlistForOutlook.
        private Settings _settings;

        // Current instance of Wunderlist API.
        private State _wunderlistState;

        // Load method is fired when Outlook is started.
        private void Ribbon1_Load(object sender, RibbonUIEventArgs e)
        {
            // Read the settings from XML.
            _settings = Settings.Deserialize(Settings.SettingsPath);

            // Instantiate a new WunderlistApi.State and authenticate.
            _wunderlistState = new State();
            _wunderlistState.Authenticate(_settings.Email, _settings.Password);
            
            // Retrieve the current Explorer from Outlook.
            _activeExplorer = Globals.ThisAddIn.Application.ActiveExplorer();
            _activeExplorer.SelectionChange += _activeExplorer_SelectionChange;
        }

        // When the selection in Outlook changes.
        void _activeExplorer_SelectionChange()
        {
            // Enable the button when only one message is selected AND Wunderlist API is authenticated.
            btnAddToWunderlist.Enabled = (_wunderlistState.Authenticated && _activeExplorer.Selection.Count == 1);
        }

        // When the Add to Wunderlist button is clicked.
        private void btnAddToWunderlist_Click(object sender, RibbonControlEventArgs e)
        {
            if (_wunderlistState.Authenticated)
            {
                // Retrieve the current email object.
                var mailItem = Outlook.Helper.GetOutlookCurrentMailItem();

                // Instantiate a new AddTaskActions form and pass the Settings, Wunderlist API state and the email object.
                var form = new AddTaskActions(_settings,_wunderlistState, mailItem);

                if (form.ShowDialog() == DialogResult.OK)
                {
                    // If the user has filled in a new List name, first create the new list to get the Id.
                    if (!string.IsNullOrEmpty(form.NewListTitle))
                    {
                        // Add the List Id to the new Task request.
                        form.Task.List_Id = _wunderlistState.AddList(form.NewListTitle).Id;
                    }

                    // Add the task to Wunderlist. This returns the actual task that is created including the new Id.
                    var task = _wunderlistState.AddTask(form.Task);

                    // If the task has been starred by the user, set the star also in Wunderlist.
                    if (form.Task.Starred) _wunderlistState.StarTask(form.Task.Id);

                    // If the reminder is set by the user, add the reminder also in Wunderlist.
                    if (form.SetReminder) _wunderlistState.AddReminder(form.ReminderDate, task.Id);
                }
            }
        }

        // When the dialoglauncher button (the little arrow in the bottom-right-corner of the Add to Wunderlist button) is clicked.
        private void groupWunderlist_DialogLauncherClick(object sender, RibbonControlEventArgs e)
        {
            // Read the settings from XML.
            _settings = Settings.Deserialize(Settings.SettingsPath);

            // Instantiate a new WunderlistSettings form and pass the Settings and the Wunderlist API.
            var form = new WunderlistSettingsForm(_settings, _wunderlistState);

            if (form.ShowDialog() == DialogResult.OK)
            {
                // Save the settings to XML.
                Settings.Serialize(Settings.SettingsPath, _settings);

                // (re-)Authenticate the user to Wunderlist.
                _wunderlistState.Authenticate(_settings.Email, _settings.Password);
            }
        }

    }
}

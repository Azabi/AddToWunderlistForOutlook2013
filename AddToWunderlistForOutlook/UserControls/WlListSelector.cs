using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using AddToWunderlistForOutlook.WunderlistApi.Model;

namespace AddToWunderlistForOutlook.UserControls
{
    public partial class WlListSelector : UserControl
    {

        public bool EnableSelector
        {
            set
            {
                radioButtonInbox.Checked = !value;
                radioButtonList.Checked = value;
                comboBox1.Enabled = value;
            }
        }

        public bool EnableListAddition
        {
            set
            {
                Size = value ? new Size(257, 89) : new Size(257, 57);
            }
        }

        public string NewListTitle { get; private set; }

        private WlListCollection _listCollection;

        public WlListCollection ListCollection
        {
            get { return _listCollection; }
            set
            {
                if (value != null)
                {
                    value.Sort();
                    comboBox1.DataSource = value;
                    comboBox1.DisplayMember = "Title";

                    _listCollection = value;
                }
            }
        }

        public string SelectedListId
        {
            get
            {
                if (radioButtonList.Checked)
                {
                    return ((WlList) comboBox1.SelectedItem).Id;
                }

                return string.Empty;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    comboBox1.SelectedItem = _listCollection.Single(x => x.Id == value);
                    EnableSelector = true;
                }
                else
                {
                    EnableSelector = false;
                }
            }
        }

        public WlListSelector()
        {
            InitializeComponent();
        }

        private void radioButtonInbox_Click(object sender, EventArgs e)
        {
            if (radioButtonList.Checked)
            {
                radioButtonInbox.Checked = false;
                radioButtonList.Checked = true;
                comboBox1.Enabled = true;
            }
            else
            {
                radioButtonInbox.Checked = true;
                radioButtonList.Checked = false;
                comboBox1.Enabled = false;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            NewListTitle = textBox1.Text;
        }

    }
}

using Json.Net;
using Newtonsoft.Json;
using System.Text;

namespace ErrorMessageGenerator
{
    public partial class Form1 : Form
    {
        List<ErrorMessage> errorMessages = new List<ErrorMessage>();
        ErrorMessage CurrentMessage = new ErrorMessage();
        DialogResult MessageResult = DialogResult.None;
        public Form1(string filename)
        {
            InitializeComponent();
            if (filename != "")
            {
                openErrorFile.FileName = filename;
                OpenFileNow();

                MessageResult = errorMessages[0].Condition;
                foreach (ErrorMessage em in errorMessages)
                {
                    MessageResult = em.DisplayMessage(MessageResult);
                }
            }
        }

        class ErrorMessage
        {

            public ErrorMessage()
            {
            }

            public string messageTitle { get; set; }
            public string messageText { get; set; }

            public MessageBoxIcon messageIcon { get; set; }
            public MessageBoxButtons messageBoxButtons { get; set; }
            public MessageBoxDefaultButton messageBoxDefault { get; set; }

            public DialogResult Condition { get; set; }

            public DialogResult DisplayMessage(DialogResult result)
            {
                if ((Condition == DialogResult.None) || (Condition == result))
                {
                    return MessageBox.Show(this.messageText, this.messageTitle, this.messageBoxButtons, this.messageIcon, this.messageBoxDefault);
                } else
                {
                    return result;
                }
            }

            public void PreviewMessage()
            {
                MessageBox.Show(this.messageText, this.messageTitle, this.messageBoxButtons, this.messageIcon, this.messageBoxDefault);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (!Program.ShowGUI) { this.Close(); }
            CurrentMessage.messageBoxDefault = MessageBoxDefaultButton.Button1;
            CurrentMessage.messageBoxButtons = MessageBoxButtons.OK;
            CurrentMessage.messageText = "";
            CurrentMessage.messageTitle = "";
            CurrentMessage.messageIcon = MessageBoxIcon.None;
            CurrentMessage.Condition = DialogResult.None;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            CurrentMessage.messageTitle = messageCaption.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            CurrentMessage.messageText = messageText.Text;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (errorBullet.Checked) { CurrentMessage.messageIcon = MessageBoxIcon.Hand; }
        }

        private void warningBullet_CheckedChanged(object sender, EventArgs e)
        {
            if (warningBullet.Checked) { CurrentMessage.messageIcon = MessageBoxIcon.Exclamation; }
        }

        private void infoBullet_CheckedChanged(object sender, EventArgs e)
        {
            if (infoBullet.Checked) { CurrentMessage.messageIcon = MessageBoxIcon.Information; }
        }

        private void questionBullet_CheckedChanged(object sender, EventArgs e)
        {
            if (questionBullet.Checked) { CurrentMessage.messageIcon = MessageBoxIcon.Question; }
        }

        private void noIconBullet_CheckedChanged(object sender, EventArgs e)
        {
            if (noIconBullet.Checked) { CurrentMessage.messageIcon = MessageBoxIcon.None; }
        }

        private void okOnlyBullet_CheckedChanged(object sender, EventArgs e)
        {
            if (okOnlyBullet.Checked) { CurrentMessage.messageBoxButtons = MessageBoxButtons.OK; }
            oneBullet.Text = "OK";
            twoBullet.Text = "N/A";
            threeBullet.Text = "N/A";
            oneBullet.Enabled = true;
            twoBullet.Enabled = false;
            threeBullet.Enabled = false;
            oneBullet.Checked = true;
            twoBullet.Checked = false;
            threeBullet.Checked = false;
        }

        private void okCancelBullet_CheckedChanged(object sender, EventArgs e)
        {
            if (okCancelBullet.Checked) { CurrentMessage.messageBoxButtons = MessageBoxButtons.OKCancel; }
            else if (ignoreRetryAbortBullet.Checked) { CurrentMessage.messageBoxButtons = MessageBoxButtons.AbortRetryIgnore; }
            else if (retryCancelBullet.Checked) { CurrentMessage.messageBoxButtons = MessageBoxButtons.RetryCancel; }
            else if (yesNoBullet.Checked) { CurrentMessage.messageBoxButtons = MessageBoxButtons.YesNo; }
            else if (continueTryCancelBullet.Checked) { CurrentMessage.messageBoxButtons = MessageBoxButtons.CancelTryContinue; }

            foreach (Control c in messageButtonsPanel.Controls)
            {
                if (c is RadioButton)
                {
                    if (((RadioButton)c).Checked)
                    {
                        if (c.Text.Contains("and") && c.Text.Contains(","))
                        {
                            string[] options = c.Text.Replace("and ", "").Replace(", ", ",").Split(',');
                            oneBullet.Text = options[0];
                            twoBullet.Text = options[1];
                            threeBullet.Text = options[2];
                            oneBullet.Enabled = true;
                            twoBullet.Enabled = true;
                            threeBullet.Enabled = true;
                        } else if (c.Text.Contains("and"))
                        {
                            string[] options = c.Text.Replace(" and ", ",").Split(',');
                            oneBullet.Text = options[0];
                            twoBullet.Text = options[1];
                            threeBullet.Text = "N/A";
                            oneBullet.Enabled = true;
                            twoBullet.Enabled = true;
                            threeBullet.Enabled = false;
                            if (threeBullet.Checked) { threeBullet.Checked = false; oneBullet.Checked = true; }
                        }
                    }
                }
            }
        }

        private void oneBullet_CheckedChanged(object sender, EventArgs e)
        {
            if (oneBullet.Checked) { CurrentMessage.messageBoxDefault = MessageBoxDefaultButton.Button1; }
            if (twoBullet.Checked) { CurrentMessage.messageBoxDefault = MessageBoxDefaultButton.Button2; }
            if (threeBullet.Checked) { CurrentMessage.messageBoxDefault = MessageBoxDefaultButton.Button3; }
        }

        private void cNoneBullet_CheckedChanged(object sender, EventArgs e)
        {
            if (cNoneBullet.Checked) { CurrentMessage.Condition = DialogResult.None; }
            if (cYesBullet.Checked) { CurrentMessage.Condition = DialogResult.Yes; }
            if (cNoBullet.Checked) { CurrentMessage.Condition = DialogResult.No; }
            if (cAbortBullet.Checked) { CurrentMessage.Condition = DialogResult.Abort; }
            if (cRetryBullet.Checked) { CurrentMessage.Condition = DialogResult.Retry; }
            if (cCancelBullet.Checked) { CurrentMessage.Condition = DialogResult.Cancel; }
            if (cContinueBullet.Checked) { CurrentMessage.Condition = DialogResult.Continue; }
            if (cTryBullet.Checked) { CurrentMessage.Condition = DialogResult.TryAgain; }
            if (cIgnoreBullet.Checked) { CurrentMessage.Condition = DialogResult.Ignore; }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CurrentMessage.PreviewMessage();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ErrorMessage em = CopyError(CurrentMessage);
            errorMessages.Add(em);
            UpdateList();
            errorsList.SelectedIndex = errorsList.Items.Count - 1;
        }

        private ErrorMessage CopyError(ErrorMessage cm)
        {
            ErrorMessage em = new ErrorMessage();
            em.Condition = cm.Condition;
            em.messageBoxDefault = cm.messageBoxDefault;
            em.messageText = cm.messageText;
            em.messageTitle = cm.messageTitle;
            em.messageBoxButtons = cm.messageBoxButtons;
            em.messageIcon = cm.messageIcon;
            return em;
        }

        private void UpdateList()
        {
            int memory = errorsList.SelectedIndex;
            errorsList.Items.Clear();
            int i = 0;
            foreach (ErrorMessage em in errorMessages)
            {
                i++;
                errorsList.Items.Add(string.Format("{0}. {1}", i, em.messageTitle));
            }
            errorsList.SelectedIndex = memory;
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            ErrorMessage em = CopyError(CurrentMessage);
            errorMessages[errorsList.SelectedIndex] = em;
            UpdateList();
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            errorMessages.RemoveAt(errorsList.SelectedIndex);
            UpdateList();
        }

        private void runButton_Click(object sender, EventArgs e)
        {
            MessageResult = errorMessages[0].Condition;
            foreach (ErrorMessage em in errorMessages)
            {
                MessageResult = em.DisplayMessage(MessageResult);
            }
        }

        private void errorsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (errorsList.SelectedItems.Count > 0)
            {
                CurrentMessage = CopyError(errorMessages[errorsList.SelectedIndex]);
                messageCaption.Text = CurrentMessage.messageTitle;
                messageText.Text = CurrentMessage.messageText;
                foreach (Control c in this.Controls)
                {
                    if (c is FlowLayoutPanel)
                    {
                        FlowLayoutPanel flo = (FlowLayoutPanel)c;
                        foreach (Control c2 in flo.Controls)
                        {
                            if (c2 is RadioButton)
                            {
                                RadioButton r = (RadioButton)c2;
                                r.Checked = false;
                            }
                        }
                    }
                }
                switch (CurrentMessage.messageIcon)
                {
                    case MessageBoxIcon.Hand:
                        errorBullet.Checked = true;
                        break;
                    case MessageBoxIcon.Exclamation:
                        warningBullet.Checked = true;
                        break;
                    case MessageBoxIcon.Information:
                        infoBullet.Checked = true;
                        break;
                    case MessageBoxIcon.Question:
                        questionBullet.Checked = true;
                        break;
                    default:
                        noIconBullet.Checked = true;
                        break;
                }
                switch (CurrentMessage.messageBoxButtons)
                {
                    case MessageBoxButtons.OK:
                        okOnlyBullet.Checked = true;
                        break;
                    case MessageBoxButtons.OKCancel:
                        okCancelBullet.Checked = true;
                        break;
                    case MessageBoxButtons.AbortRetryIgnore:
                        ignoreRetryAbortBullet.Checked = true;
                        break;
                    case MessageBoxButtons.RetryCancel:
                        retryCancelBullet.Checked = true;
                        break;
                    case MessageBoxButtons.YesNo:
                        yesNoBullet.Checked = true;
                        break;
                    default:
                        continueTryCancelBullet.Checked = true;
                        break;
                }
                switch (CurrentMessage.messageBoxDefault)
                {
                    case MessageBoxDefaultButton.Button1:
                        oneBullet.Checked = true;
                        break;
                    case MessageBoxDefaultButton.Button2:
                        twoBullet.Checked = true;
                        break;
                    case MessageBoxDefaultButton.Button3:
                        threeBullet.Checked = true;
                        break;
                }
                switch (CurrentMessage.Condition)
                {
                    case DialogResult.OK:
                        cOKBullet.Checked = true;
                        break;
                    case DialogResult.Yes:
                        cYesBullet.Checked = true;
                        break;
                    case DialogResult.No:
                        cNoBullet.Checked = true;
                        break;
                    case DialogResult.Cancel:
                        cCancelBullet.Checked = true;
                        break;
                    case DialogResult.Retry:
                        cRetryBullet.Checked = true;
                        break;
                    case DialogResult.Ignore:
                        cIgnoreBullet.Checked = true;
                        break;
                    case DialogResult.Abort:
                        cAbortBullet.Checked = true;
                        break;
                    case DialogResult.TryAgain:
                        cTryBullet.Checked = true;
                        break;
                    case DialogResult.Continue:
                        cContinueBullet.Checked = true;
                        break;
                    default:
                        cNoneBullet.Checked = true;
                        break;
                }
            }
        }

        private void exportButton_Click(object sender, EventArgs e)
        {
            if (saveErrorFile.ShowDialog() == DialogResult.OK)
            {
                StringBuilder sb = new StringBuilder();
                StringWriter sw = new StringWriter(sb);

                string output;

                using (JsonWriter writer = new JsonTextWriter(sw))
                {
                    writer.Formatting = Formatting.Indented;

                    foreach (ErrorMessage em in errorMessages)
                    {
                        writer.WriteStartObject();
                        writer.WritePropertyName("messageTitle");
                        writer.WriteValue(em.messageTitle);
                        writer.WritePropertyName("messageText");
                        writer.WriteValue(em.messageText);
                        writer.WritePropertyName("messageBoxDefault");
                        writer.WriteValue(em.messageBoxDefault);
                        writer.WritePropertyName("messageBoxButtons");
                        writer.WriteValue(em.messageBoxButtons);
                        writer.WritePropertyName("messageIcon");
                        writer.WriteValue(em.messageIcon);
                        writer.WritePropertyName("condition");
                        writer.WriteValue(em.Condition);
                        writer.WriteEndObject();
                    }
                    output = sb.ToString();
                }
                using (FileStream fs = File.Create(saveErrorFile.FileName))
                {
                    StreamWriter strw = new StreamWriter(fs);
                    strw.Write(output);
                    strw.Close();
                }
                MessageBox.Show("File saved!", "Save error message macro", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void importButton_Click(object sender, EventArgs e)
        {
            if (openErrorFile.ShowDialog() == DialogResult.OK)
            {
                OpenFileNow();
                UpdateList();
                errorsList.SelectedIndex = 0;
            }
        }

        private void OpenFileNow()
        {
            string json = "";
            using (FileStream fs = File.OpenRead(openErrorFile.FileName))
            {
                StreamReader sr = new StreamReader(fs);
                string line = sr.ReadLine();
                while ((line != null) && (line.Length > 0))
                {
                    json += line;
                    line = sr.ReadLine();
                }
            }
            string[] jsons = json.Split("}{");
            errorMessages.Clear();
            foreach (string j in jsons)
            {
                json = j + "}";
                if (!json.StartsWith("{"))
                {
                    json = "{" + json;
                }
                if (json.EndsWith("}}"))
                {
                    json = json.Substring(0, json.Length - 1);
                }
                JsonTextReader reader = new JsonTextReader(new StringReader(json));
                string Property = "";
                while (reader.Read())
                {

                    if (reader.Value != null)
                    {
                        if (reader.TokenType == JsonToken.PropertyName)
                        {
                            Property = (string)reader.Value;
                        }
                        else if ((reader.TokenType == JsonToken.String) || (reader.TokenType == JsonToken.Integer))
                        {
                            switch (Property)
                            {
                                case "messageTitle":
                                    CurrentMessage.messageTitle = (string)reader.Value;
                                    break;
                                case "messageText":
                                    CurrentMessage.messageText = (string)reader.Value;
                                    break;
                                case "messageBoxDefault":
                                    CurrentMessage.messageBoxDefault = (MessageBoxDefaultButton)(long)reader.Value;
                                    break;
                                case "messageBoxButtons":
                                    CurrentMessage.messageBoxButtons = (MessageBoxButtons)(long)reader.Value;
                                    break;
                                case "messageIcon":
                                    CurrentMessage.messageIcon = (MessageBoxIcon)(long)reader.Value;
                                    break;
                                case "condition":
                                    CurrentMessage.Condition = (DialogResult)(long)reader.Value;
                                    break;
                            }
                        }
                    }
                    else
                    {
                        if (reader.TokenType == JsonToken.EndObject)
                        {
                            errorMessages.Add(CopyError(CurrentMessage));
                        }
                    }
                }

            }
            UpdateList();
            errorsList.SelectedIndex = 0;
        }
    }
}
/* ***************************************************************************** *\
 * APPLICATION: Talk It!
 * VERSION:     1.0
 * -----------------------------------------------------------------------------
 * AUTHOR:      Mohammad Zunayed Hassan
 * EMAIL:       zunayed-hassan@live.com
 * 
\* ***************************************************************************** */

using System;
using System.Drawing;
using System.Windows.Forms;
using SpeechLib;

namespace Talk_It
{
    public partial class TalkItForm : Form
    {
        private TextBox talkItTextBox;
        private Button talkItButton;

        public TalkItForm()
        {
            InitializeComponent();

            // Form: TalkItForm
            this.Text = "Talk It";
            this.Size = new Size(450, 300);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Icon =
                (Icon) Properties.Resources._118219_matte_blue_and_white_square_icon_symbols_shapes_comment_bubble;

            // Panel: panel
            Panel panel = new Panel();
            panel.Dock = DockStyle.Fill;

            // TextBox: talkItTextBox
            talkItTextBox = new TextBox();
            talkItTextBox.Text = "A lazy brown boy jumps over a crazy semester.";
            talkItTextBox.Select(0, 0);
            talkItTextBox.Font = new Font("Bradley Hand ITC", 18, FontStyle.Bold);
            talkItTextBox.TextAlign = HorizontalAlignment.Center;
            talkItTextBox.WordWrap = true;
            talkItTextBox.ScrollBars = ScrollBars.Both;
            talkItTextBox.Multiline = true;
            talkItTextBox.Size = new Size(395, 170);
            talkItTextBox.Location = new Point(20, 20);
            talkItTextBox.Anchor = AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Bottom;

            // Button: talkItButton
            talkItButton = new Button();
            talkItButton.Text = "Talk It!";
            talkItButton.Font = new Font("Segoe UI", 14, FontStyle.Bold);
            talkItButton.ForeColor = Color.SteelBlue;
            talkItButton.Location = new Point(150, 205);
            talkItButton.Size = new Size(120, 40);
            talkItButton.Anchor = AnchorStyles.Left | AnchorStyles.Bottom | AnchorStyles.Right;
            talkItButton.Image =
                (Image) Properties.Resources._117791_matte_blue_and_white_square_icon_people_things_speech;
            talkItButton.TextImageRelation = TextImageRelation.ImageBeforeText;

            // Label: aboutLabel
            Label aboutLabel = new Label();
            aboutLabel.Text = "Zunayed Hassan";
            aboutLabel.Font = new Font("Segoe UI", 6);
            aboutLabel.Location = new Point(370, 250);

            // Adding new components
            this.Controls.Add(panel);
            panel.Controls.Add(talkItTextBox);
            panel.Controls.Add(talkItButton);
            panel.Controls.Add(aboutLabel);

            // Adding EventHandler
            talkItButton.Click += new EventHandler(talkItButton_Click);
        }

        private void talkItButton_Click(object sender, EventArgs evnt)
        {
            if (talkItTextBox.Text.Trim() != String.Empty)
                (new SpVoice()).Speak(talkItTextBox.Text.Trim(), SpeechVoiceSpeakFlags.SVSFlagsAsync);
            else
                MessageBox.Show("You can't listen from this program unless you type something on text area.", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}

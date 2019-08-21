using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using MQTTnet;


namespace MqttPublisher
{
    public partial class Form1 : Form
    {

        Functions functions;
        ToolTip aciklama;

        private int _CharacterCount;
        string perSecond;

        public Form1()
        {
            InitializeComponent();
            functions = new Functions();
            aciklama = new ToolTip();
            CheckForIllegalCrossThreadCalls = false;

            lblHowManyCharacters.Hide();
            txtHowManyCharacters.Hide();
            _CharacterCount = 0;

            aciklama.SetToolTip(txtGetTopic, "If you use more topic, Topics has to end with ';' ");
            aciklama.ToolTipTitle = "Attention!";
        }
        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                txtGetMessage.Hide();
                lblEnterMessage.Hide();
                lblHowManyCharacters.Show();
                txtHowManyCharacters.Show();
            }
            else
            {
                txtGetMessage.Show();
                lblEnterMessage.Show();
                lblHowManyCharacters.Hide();
                txtHowManyCharacters.Hide();
            }
        }

        private void BtnConnect_Click(object sender, EventArgs e)
        {
            string ipAdress = txtGetIpAddress.Text;
            int portNumber = Convert.ToInt32(txtGetPortNumber.Text);
            functions.mqttConnect(ipAdress, portNumber);
            btnConnect.BackColor = Color.PowderBlue;
        }

        private void BtnPublish_Click(object sender, EventArgs e)
        {
            int total = 0;
            int tempCharCount = 0;

            int.TryParse(txtHowManyCharacters.Text, out tempCharCount);
            _CharacterCount = Convert.ToInt32(tempCharCount);
            int forCount = Convert.ToInt32(txtGetHowManyFor.Text);

            string message = txtGetMessage.Text;
            string topic = txtGetTopic.Text;
            string[] topics = functions.splitText(topic, ';');

            for (int i = 0; i < forCount; i++)
            {
                if (checkBox1.Checked)
                {
                    message = functions.createRandomCharacters(_CharacterCount);
                    functions.convertJson(message);
                }
                else
                {
                    functions.convertJson(message);
                }
                for (int k = 0; k < topics.Length; k++)
                {
                    string topic1 = topics[k];
                    richTbSendedMessages.Text += Environment.NewLine + (i + 1 + ". Sended Message = " + message + " ==> PerSecond : " + perSecond);
                    int messageCount = functions.publish(topic1, message, cmbQosLevel.SelectedIndex);
                    perSecond = Convert.ToString(messageCount);
                    lblSendedMessageCount.Text = messageCount.ToString();
                    total += messageCount;
                    lblSendedTotalMessage.Text = total.ToString();
                }
            }
        }
        private void BtnClear_Click(object sender, EventArgs e)
        {
            richTbSendedMessages.Clear();
            lblSendedMessageCount.Text = "0";
            lblSendedTotalMessage.Text = "0";
        }
        private void BtnDisconnect_Click(object sender, EventArgs e)
        {
            functions.mqttDisconnect();
            btnDisconnect.BackColor = Color.PowderBlue;
            btnConnect.BackColor = default;
        }
    }
}

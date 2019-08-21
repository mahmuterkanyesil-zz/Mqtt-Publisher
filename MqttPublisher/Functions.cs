using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MQTTnet;
using Newtonsoft.Json;
using MQTTnet.Client;
using System.Net;
using MQTTnet.Server;
using MQTTnet.Client.Options;
using MQTTnet.Formatter;
using System.Diagnostics;
using MQTTnet.Protocol;

namespace MqttPublisher
{

    class Functions
    {
        IMqttClient mqttClient;
        Random random = new Random();

        public String createRandomCharacters(int value)
        {
            string letters = "ABCÇDEFGĞHIİJKLMNOÖPRSŞTUÜVYZabcçdefgğhıijklmnoöprsştuüvyz";
            string create = "";
            for (int i = 0; i < value; i++)
            {
                create += letters[random.Next(letters.Length)];
            }
            return create;
        }

        public String[] splitText(string topic, char splitChar)
        {
            string[] text = topic.Split(splitChar);
            return text;
        }

        public String convertJson(string message)
        {
            string convertedMessage = JsonConvert.SerializeObject(message);
            return convertedMessage;
        }

        public async void mqttConnect(string tcpServer, int port)
        {
            if (mqttClient == null)
            {
                var factory = new MqttFactory();
                mqttClient = factory.CreateMqttClient();
                var options = new MqttClientOptionsBuilder()
                    .WithTcpServer(tcpServer, port)
                    .Build();
                await mqttClient.ConnectAsync(options);
            }
        }

        public void mqttDisconnect()
        {
            mqttClient.DisconnectAsync();
            mqttClient = null;
        }

        public int publish(string topic, string sendedMessage, int qosLevel)
        {
            var sentMessagesCount = 0;
            try
            {
                var stopwatch = new Stopwatch();
                stopwatch.Restart();

                while (stopwatch.ElapsedMilliseconds < 1000)
                {
                    try
                    {
                        mqttClient.PublishAsync(topic, sendedMessage, (MQTTnet.Protocol.MqttQualityOfServiceLevel)qosLevel).Wait();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex);
                    }
                    sentMessagesCount++;
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
            }
            return sentMessagesCount;
        }
    }
}

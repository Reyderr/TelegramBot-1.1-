using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telegram.Bot.Types.Enums;
using Telegram.Bot.Args;

namespace TelBot_1._1
{
    public partial class Form1 : Form
    {
        private static Telegram.Bot.TelegramBotClient BOT;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BOT = new Telegram.Bot.TelegramBotClient("508495921:AAHbY2MwO1Gmh6SSOkVO-YoM6oL_vqTTuKY");
            BOT.OnMessage += BotOnMassageReceived;
            BOT.StartReceiving(new UpdateType[] { UpdateType.Message });
            button1.Enabled = false;
        }

            private static async void BotOnMassageReceived(object sender, MessageEventArgs messageEventArgs)
            {
                Telegram.Bot.Types.Message msg = messageEventArgs.Message;
                if (msg == null || msg.Type != MessageType.Text) return;

                String Answer = "";

            switch (msg.Text)
            {
                case "/start": Answer = "http://memesmix.net/media/created/evdc86.jpg"; break;
                case "/sosi": Answer = "Sam sosi"; break;
                case "/sosi_pisos": Answer = "Pizda tobi. Tikai z cela http://memesmix.net/media/created/kieyc4.jpg"; break;
                case "/Anton": Answer = "Pidor)"; break;
                default: Answer = "Lol"; break;
            }
            await BOT.SendTextMessageAsync(msg.Chat.Id, Answer);
            }
        
    }
}

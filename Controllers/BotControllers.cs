using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Telegram.Bot;

using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;

namespace Telegram.Bot
{
    class Program
    {
        static TelegramBotClient Bot = new TelegramBotClient("5743894715:AAH8UWLxPsMF5v3A1GEqjTemts8nLZUev0I");

        static void Main(string[] args)
        {
            Bot.StartReceiving();
            Bot.OnMessage += Bot_OnMessage;

            Console.ReadLine();
        } 
        private static void Bot_OnMessage(object sender, Telegram.Bot.Args.MessageEventArgs e)
    {
        if (e.Message.Type == Telegram.Bot.Types.Enums.MessageType.Text)
        {
            Bot.SendTextMessageAsync(e.Message.Chat.Id, "bienvenido usario a telegram" + e.Message.Chat.Username);
        }
    }
    }
}
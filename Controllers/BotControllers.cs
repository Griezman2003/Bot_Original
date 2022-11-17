using Telegram.Bot;
using System;
using Telegram.Bot.Exceptions;


namespace TelegramBot
{
    class program
    {
        static ITelegramBotClient? _botClient;
        static void Main(string[] args)
        {
              _botClient = new TelegramBotClient("5743894715:AAH8UWLxPsMF5v3A1GEqjTemts8nLZUev0I");
            
            var me = _botClient.GetMeAsync().Result;

            Console.WriteLine($"hi, i am {me.Id} and my name is: {me.FirstName}");
            
            _botClient.OnMessage += _botClient_OnMessage;
            _botClient.StartReceiving();

            Console.WriteLine("please enter any key to exit");
            Console.ReadKey();

            _botClient.StopReceiving();
        }
        private async static void _botClient_OnMessage(object sender, Telegram.Bot.Args.MessageEventArgs e)
        {
            if (e.Message.Text != null)
            {
                Console.WriteLine($"message received");

                if (e.Message.Text.ToLower().Contains("Message"))
                {
                    await _botClient.SendTextMessageAsync(
                    chatId: e.Message.Chat.Id,
                    text:$"this is Message"
                    );
            }
               else if (e.Message.Text.ToLower().Contains("sticker"))
               {
                await _botClient.SendStickerAsync(
                    chatId: e.Message.Chat.Id,sticker:"https://telegramchannels.me/storage/stickers/prosekaikaito/prosekaikaito.png"
                 );
               }
               else if (e.Message.Text.ToLower().Contains("contact"))
               {
                   await _botClient.SendContactAsync(
                    chatId: e.Message.Chat.Id,
                    phoneNumber: "+52 9821075495",
                    firstName:"Gamaliel",
                    lastName:"Garcia"
                   );
               }
            }
        }
    }
}
  
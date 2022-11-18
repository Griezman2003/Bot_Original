using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Telegram.Bot;
using Microsoft.EntityFrameworkCore;

namespace Bot.Controllers
{
    [Route("[Controller]")]
    [ApiController]
    public class BotController: ControllerBase
{

     private readonly BotController bot;
     public BotController(BotController bot)
        {
            this.bot = bot;
        }
        static TelegramBotClient botClient;

       static void Main(string[] args)
       {
          TelegramBotClient Bot = new TelegramBotClient("https://api.telegram.org/bot5743894715:AAH8UWLxPsMF5v3A1GEqjTemts8nLZUev0I/getMe");
        }

        private static async void Post(BotController bot, object sender, Telegram.Bot.Args.MessageEventArgs e)
        {
            await botClient.SendContactAsync(
             chatId: e.Message.Chat.Id,
             phoneNumber: "+52 9821075495",
             firstName: "Gamaliel",
             lastName: "Garcia"
            );
        }
    }
    }
      



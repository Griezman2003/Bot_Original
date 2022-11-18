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
        static ITelegramBotClient? _botClient;

       static void Main(string[] args)
       {
          TelegramBotClient Bot = new TelegramBotClient("5743894715:AAH8UWLxPsMF5v3A1GEqjTemts8nLZUev0I");
         
        [HttpPost]
          private async Task<ActionResult> Post(BotController botController){
            bot.Add(botController);
            await bot.SaveChangesAsync();
            return Ok();
    
    }
        }
       }
    }
      



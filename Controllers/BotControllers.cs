using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Telegram.Bot;
using Telegram.Bot.Types;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Bot.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class BotController: ControllerBase

    {
      [HttpPost]
      public async Task<IActionResult> Post([FromBody] Update update)
      {
         TelegramBotClient client = new TelegramBotClient("https://api.telegram.org/bot5743894715:AAH8UWLxPsMF5v3A1GEqjTemts8nLZUev0I/getMe");
         
         if (update.Type == Telegram.Bot.Types.Enums.UpdateType.Message)
         {
            await client.SendTextMessageAsync(update.Message.From.Id, "answer");
         }
         return Ok();
      }
    }
}

      



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
         TelegramBotClient client = new TelegramBotClient("https://api.telegram.org/bot5303713753:AAGOKvMpgYI_bfDncV3Ody3GrAzw7PdZvcI/getMe");
         
         if (update.Type == Telegram.Bot.Types.Enums.UpdateType.Message)
         {
             await client.SendTextMessageAsync(update.Message.Chat.Id, "bienvenido");
                    
         }
         return Ok();
      }
    }
}
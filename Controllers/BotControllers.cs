using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Bot.Services;
using Telegram.Bot;

namespace Bot.Controllers
{
    [Route("[Controller]")]
    [ApiController]
    public class BotController: ControllerBase
    {
        private readonly TelegramBotClient context;

        public BotController(TelegramBotClient context)
        {
            this.context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Bot>>> Get(){
            return await context.ToListAsync();
        }
   
        [HttpPost]
        public async Task<ActionResult> Post(Bot bot){
            context.Add(bot);
            await context.SaveChangesAsync();
            return Ok();
        }

    }

}
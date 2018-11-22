using System;
using System.Linq;
using Eventures.Web.ViewModels.Events;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Logging;

namespace Eventures.Web.Filters
{
    public class EventsLogFilter : ActionFilterAttribute
    {
        private readonly ILogger logger;
        private CreateEventViewModel model;

        public EventsLogFilter(ILoggerFactory factory)
        {
            this.logger = factory.CreateLogger<EventsLogFilter>();
        }

        public override void OnActionExecuting(ActionExecutingContext context)
        {
            this.model = context.ActionArguments.Values.OfType<CreateEventViewModel>().Single();

            base.OnActionExecuting(context);
        }
        
        public override void OnActionExecuted(ActionExecutedContext context)
        {
            if (this.model != null)
            {
                var user = context.HttpContext.User.Identity.Name;
                var eventName = this.model.Name;
                var start = this.model.Start;
                var end = this.model.End;
                this.logger.LogInformation($"[{DateTime.UtcNow}] Administrator {user} create event {eventName} ({start} / {end}).");
            }

            base.OnActionExecuted(context);
        }
    }
}
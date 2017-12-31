using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Validation;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Web;
using System.Web.Http.Filters;

namespace CandyFramework.WebApi.Filters
{
    public class ErrorFilterAttiribute : ExceptionFilterAttribute, IExceptionFilter
    {
        public override void OnException(HttpActionExecutedContext actionExecutedContext)
        {
            var ex = actionExecutedContext.Exception;
            //Hata loglaması
            var logger = Core.Concrete.Core.CanyLogManager.CreateLogger();
            logger.WriteLog(ex.Message, ex);
            //Zorunluluk hatasının detayları alınarak response ayarlama
            if (ex is DbEntityValidationException)
            {
                var errorResult = new StringBuilder();
                DbEntityValidationException dbEx = (DbEntityValidationException)ex;
                foreach (var validationErrors in dbEx.EntityValidationErrors)
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        var message = $"{validationErrors.Entry.Entity}:{validationError.ErrorMessage}";
                        errorResult.AppendLine(message);
                    }
                actionExecutedContext.Response = actionExecutedContext.Request.CreateErrorResponse(HttpStatusCode.BadRequest, errorResult.ToString());
            } // veri tabanı update edilmediği zaman buna uygun hata kodu döndürmek için
            else if (ex is DbUpdateException)
            {
                DbUpdateException dbEx = (DbUpdateException)ex;
                actionExecutedContext.Response = actionExecutedContext.Request.CreateErrorResponse(HttpStatusCode.UpgradeRequired, dbEx);
            }
            else // Hiç birine uymuyorsa .net'in standart hata handle'ı çalışacak.
            {
                base.OnException(actionExecutedContext);
            }

        }
    }
}
using CandyFramework.BusinessLayer.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CandyFramework.Entity.Entity.ViewModel;
using CandyFramework.DataAccessLayer.Interface;
using CandyFramework.Entity.Entity.Entity;

namespace CandyFramework.BusinessLayer.Concrete
{
    public class SettingService : BaseService<SettingEntity, SettingView>, ISettingService
    {
        #region - Repository -
        private readonly ISettingRepository settingRepository;
        #endregion
        public SettingService(ISettingRepository _settingRepository) : base(_settingRepository)
        {
            settingRepository = _settingRepository;
        }

        public void LoadSettings()
        {
            //fgyonetim@gmail.com|Ktu245002+-|smtp.google.com|587|Candy Framework
            var settings = base.All();
            #region - Mail -
            var mail = settings.FirstOrDefault(x => x.KeyName == "MailSetting");
            if (mail != null)
            {
                var mailArray = mail.Value.Split('|');
                Core.Concrete.Common.Setting.Mail.MailAddress = mailArray[0];
                Core.Concrete.Common.Setting.Mail.MailPassword = mailArray[1];
                Core.Concrete.Common.Setting.Mail.SMTPHost = mailArray[2];
                Core.Concrete.Common.Setting.Mail.SMTPPort = mailArray[3];
                Core.Concrete.Common.Setting.Mail.FromDisplayName = mailArray[4];
            }
            #endregion
            #region - Süper User -
            var superUser = settings.FirstOrDefault(x => x.KeyName == "SuperUser");
            if (superUser != null)
            {
                var superUserArray = superUser.Value.Split('|');
                Core.Concrete.Common.Setting.SuperUser.UserName = superUserArray[0];
                Core.Concrete.Common.Setting.SuperUser.Password = superUserArray[1];
            }
            #endregion
            #region - Error Email -
            var errorToMail = settings.FirstOrDefault(x => x.KeyName == "EMailLogToAddress");
            if (errorToMail != null)
            {
                var toMails = errorToMail.Value.Split(',');
                Core.Concrete.Common.Setting.ErrorMail.ToMails = toMails.ToList();
            }
            var errorCcMail = settings.FirstOrDefault(x => x.KeyName == "EMailLogCCAddress");
            if (errorCcMail != null)
            {
                var ccMails = errorCcMail.Value.Split(',');
                Core.Concrete.Common.Setting.ErrorMail.CsMails = ccMails.ToList();
            }
            #endregion
            #region - Log Etting -
            var log = settings.FirstOrDefault(x => x.KeyName == "LogClass");
            if (log != null)
            {
                Core.Concrete.Common.Setting.LogClass = log.Value;
            }
            #endregion
            Core.Concrete.Common.Setting.SiteName = settings.FirstOrDefault(x => x.KeyName == "SiteName")?.Value;
        }
        public override void Update(SettingView entity)
        {
            base.Update(entity);
            LoadSettings();
        }
        public override void Update(IEnumerable<SettingView> entities)
        {
            base.Update(entities);
            this.LoadSettings();
        }
    }
}

﻿using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using supplyc.Configuration.Dto;

namespace supplyc.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : supplycAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}

using Volo.Abp.Settings;

namespace Abp.MES.Settings;

public class MESSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(MESSettings.MySetting1));
    }
}

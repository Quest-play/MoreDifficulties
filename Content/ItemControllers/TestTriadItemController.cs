using Gatekeeper.CameraScripts.HUD.SkillPanelStuff;
using Gatekeeper.General.Events.Characters;
using GKAPI.Items;

namespace MoreDifficulties.Content.ItemControllers;

public class TestTriadItemController : CustomItemController
{
    public override void OwnerHandleSkillUsed(EventClientCharacterSkillUsed eventData)
    {
        if (IsItemInInventory && eventData.SkillType == SkillType.Third)
        {
            Plugin.Log.LogInfo("TestTriadItemController::HandleThirdSkillUsed");
        }
    }
}
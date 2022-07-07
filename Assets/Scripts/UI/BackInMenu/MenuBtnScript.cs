using UnityEngine;

namespace UI.BackInMenu
{
    public class MenuBtnScript : ButtonSender
    {
        public override void BtnSender()
        {
            UIEvents.SendMenuBtnClick();
            
        }
    }
}

using UI.Events;
using UnityEngine;

namespace UI.BackInMenu
{
    public class MenuBtnScript : ButtonSender
    {
        protected override void BtnSender()
        {
            UIEvents.SendMenuBtnClick();
            
        }
    }
}

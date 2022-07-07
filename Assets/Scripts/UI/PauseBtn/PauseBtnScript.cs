using UI.Events;
using UnityEngine;

namespace UI.PauseBtn
{
    public class PauseBtnScript : ButtonSender
    {
        protected override void BtnSender()
        {
            UIEvents.SendPauseBtnClick();
        }
    }
}
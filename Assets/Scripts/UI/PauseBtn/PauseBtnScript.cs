using UnityEngine;

namespace UI.PauseBtn
{
    public class PauseBtnScript : ButtonSender
    {
        public override void BtnSender()
        {
            UIEvents.SendPauseBtnClick();
        }
    }
}
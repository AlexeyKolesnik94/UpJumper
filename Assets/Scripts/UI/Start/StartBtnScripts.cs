using UI.Events;

namespace UI.Start
{
    public class StartBtnScripts : ButtonSender
    {
        protected override void BtnSender()
        {
            UIEvents.SendStartBtnClick();
        }
    }
}
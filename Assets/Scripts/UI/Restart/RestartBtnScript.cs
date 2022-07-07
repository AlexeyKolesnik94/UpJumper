using UI.Events;

namespace UI.Restart
{
    public class RestartBtnScript : ButtonSender
    {
        protected override void BtnSender()
        {
            UIEvents.SendRestartBtnClick();
        }
        
    }
}

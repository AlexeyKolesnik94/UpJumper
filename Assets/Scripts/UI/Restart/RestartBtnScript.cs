namespace UI.Restart
{
    public class RestartBtnScript : ButtonSender
    {
        public override void BtnSender()
        {
            UIEvents.SendRestartBtnClick();
        }
        
    }
}

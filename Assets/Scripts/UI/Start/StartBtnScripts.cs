namespace UI.Start
{
    public class StartBtnScripts : ButtonSender
    {
        public override void BtnSender()
        {
            UIEvents.SendStartBtnClick();
        }
    }
}
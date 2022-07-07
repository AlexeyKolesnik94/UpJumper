namespace UI.Resume
{
    public class ResumeBtnScript : ButtonSender
    {
        public override void BtnSender()
        {
            UIEvents.SendResumeBtnClick();
        }
    }
}

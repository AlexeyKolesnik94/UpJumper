using UI.Events;

namespace UI.Resume
{
    public class ResumeBtnScript : ButtonSender
    {
        protected override void BtnSender()
        {
            UIEvents.SendResumeBtnClick();
        }
    }
}

namespace MvcApplication1.Models
{
    public interface IPrizeWinningRecorder
    {
        void RecordWin(string name, string email, string promotionCode);
    }
}
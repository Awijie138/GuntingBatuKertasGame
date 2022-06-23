using Agate.MVC.Base;

namespace Game.Module.PlayGame
{
    public interface IPlayGameModel : IBaseModel
    {
        string playerInput { get; }
        string opponentInput { get; }
        string result { get; }
    }
    public class PlayGameModel : BaseModel, IPlayGameModel
    {
        public string playerInput { get; protected set; }
        public string opponentInput { get; protected set; }
        public string result { get; protected set; }

        public void SetPlayerInput(string result)
        {
            playerInput = result;
            SetDataAsDirty();
        }

        public void SetOpponentInput(string result)
        {
            opponentInput = result;
            SetDataAsDirty();
        }

        public void SetResult(string source)
        {
            result = source;
            SetDataAsDirty();
        }

        public void SetNull()
        {
            opponentInput = null;
            result = null;
        }


    }
}
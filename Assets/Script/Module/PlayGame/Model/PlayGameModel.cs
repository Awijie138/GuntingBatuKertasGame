using Agate.MVC.Base;

namespace Game.Module.PlayGame
{
    public interface IPlayGameModel : IBaseModel
    {
        string playerInput { get; }
    }
    public class PlayGameModel : BaseModel, IPlayGameModel
    {
        public string playerInput
        {
            get;
            protected set;
        } = null;

        public void SetInput(string result)
        {
            playerInput = result;
        }
    }
}
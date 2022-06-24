using Agate.MVC.Base;

namespace Game.Module.Output
{
    public class OutputController : DataController<OutputController, OutputModel, IOutputModel>
    {
        public string GetResult(string playerInput, string opponentInput)
        {
            _model.SetPlayerInput(playerInput);
            _model.SetOpponentInput(opponentInput);

            _model.Process();

            return _model.result;
        }


    }
}
using Agate.MVC.Base;
using UnityEngine;

namespace Game.Module.OpponentInput
{
    public class OpponentInputController : DataController<OpponentInputController, OpponentInputModel, IOpponentInputModel>
    {
        public void SetOpponentInput()
        {
            _model.GetOpponentResult();
            SendData();
        }
        public string GetOpponentInput()
        {
            return _model.result;
        }
        public void SendData()
        {
            Debug.Log("Data send to comparrison");
        }

    }
}



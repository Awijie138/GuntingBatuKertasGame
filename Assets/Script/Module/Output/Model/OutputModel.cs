using Agate.MVC.Base;
using Game.Utility;
using UnityEngine;

namespace Game.Module.Output
{
    public interface IOutputModel : IBaseModel
    {
        string playerInput { get; }
        string opponentInput { get; }
        string result { get; }
    }
    public class OutputModel : BaseModel, IOutputModel
    {
        public string playerInput
        {
            get;
            protected set;
        } = null;

        public string opponentInput
        {
            get;
            protected set;
        } = null;

        public string result
        {
            get;
            protected set;
        } = null;

        public void SetPlayerInput(string source)
        {
            playerInput = source;
        }

        public void SetOpponentInput(string source)
        {
            opponentInput = source;
        }

        public void Process()
        {
            switch ((playerInput, opponentInput))
            {
                case (ContsGBK.gunting, ContsGBK.gunting):
                    result = "Draw";
                    break;

                case (ContsGBK.gunting, ContsGBK.batu):
                    result = "Lose";
                    break;

                case (ContsGBK.gunting, ContsGBK.kertas):
                    result = "Win";
                    break;

                case (ContsGBK.batu, ContsGBK.gunting):
                    result = "Win";
                    break;
                case (ContsGBK.batu, ContsGBK.batu):
                    result = "Draw";
                    break;

                case (ContsGBK.batu, ContsGBK.kertas):
                    result = "Lose";
                    break;

                case (ContsGBK.kertas, ContsGBK.gunting):
                    result = "Win";
                    break;

                case (ContsGBK.kertas, ContsGBK.batu):
                    result = "Lose";
                    break;
                case (ContsGBK.kertas, ContsGBK.kertas):
                    result = "Draw";
                    break;

                default:
                    result = "Error";
                    break;
            }
        }
    }
}
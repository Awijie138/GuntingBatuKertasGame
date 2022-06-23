using Agate.MVC.Base;
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

        public string Process(string playerinput, string opponentInput)
        {
            switch ((playerinput, opponentInput))
            {
                case ("Gunting", "Gunting"):
                    result = "Draw";
                    break;

                case ("Gunting", "Batu"):
                    result = "Lose";
                    break;

                case ("Gunting", "Kertas"):
                    result = "Win";
                    break;

                case ("Batu", "Gunting"):
                    result = "Win";
                    break;
                case ("Batu", "Batu"):
                    result = "Draw";
                    break;

                case ("Batu", "Kertas"):
                    result = "Lose";
                    break;

                case ("Kertas", "Gunting"):
                    result = "Win";
                    break;

                case ("Kertas", "Batu"):
                    result = "Lose";
                    break;
                case ("Kertas", "Kertas"):
                    result = "Draw";
                    break;

                default:
                    result = "Error";
                    break;
            }
            return result;
        }
    }
}
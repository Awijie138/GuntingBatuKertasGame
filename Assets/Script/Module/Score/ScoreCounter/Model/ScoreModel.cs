using Agate.MVC.Base;
using UnityEngine;

namespace Game.Module.Score
{
    public interface IScoreModel : IBaseModel
    {
        int win { get; }
        int lose { get; }
        int draw { get; }
    }
    public class ScoreModel : BaseModel, IScoreModel
    {
        public int win { get; protected set; } = 0;
        public int lose { get; protected set; } = 0;
        public int draw { get; protected set; } = 0;

        public void AddWin()
        {
            win++;
            SetDataAsDirty();
        }

        public void AddLose()
        {
            lose++;
            SetDataAsDirty();
        }

        public void AddDraw()
        {
            draw++;
            SetDataAsDirty();
        }

        public void Reset()
        {
            win = 0;
            lose = 0;
            draw = 0;
            SetDataAsDirty();
        }

        public void SetScore(string source)
        {
            switch (source)
            {
                case ("Win"):
                    AddWin();
                    break;
                case ("Lose"):
                    AddLose();
                    break;
                case ("Draw"):
                    AddDraw();
                    break;
                default:
                    break;
            }
        }

    }
}


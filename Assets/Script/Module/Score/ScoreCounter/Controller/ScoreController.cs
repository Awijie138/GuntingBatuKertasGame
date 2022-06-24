using Agate.MVC.Base;
using UnityEngine;

namespace Game.Module.Score
{
    public class ScoreController : ObjectController<ScoreController, ScoreModel, IScoreModel, ScoreView>
    {
        public void SetScoreData(string source)
        {
            _model.SetScore(source);
            Publish<ScoreMessage>(new ScoreMessage());
        }

        public void ResetScoreData()
        {
            _model.Reset();
        }
    }
}
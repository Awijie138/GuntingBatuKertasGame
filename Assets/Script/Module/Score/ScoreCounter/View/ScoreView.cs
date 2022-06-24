using Agate.MVC.Base;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

namespace Game.Module.Score
{
    public class ScoreView : ObjectView<IScoreModel>
    {
        [SerializeField]
        private Text _scoreWin, _scoreLose, _scoreDraw;

        protected override void InitRenderModel(IScoreModel model)
        {
            _scoreWin.text = model.win.ToString();
            _scoreLose.text = model.lose.ToString();
            _scoreDraw.text = model.draw.ToString();
        }

        protected override void UpdateRenderModel(IScoreModel model)
        {
            _scoreWin.text = model.win.ToString();
            _scoreLose.text = model.lose.ToString();
            _scoreDraw.text = model.draw.ToString();
        }
    }
}
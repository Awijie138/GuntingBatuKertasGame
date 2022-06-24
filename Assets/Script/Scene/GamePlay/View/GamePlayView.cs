using Agate.MVC.Base;
using Game.Module.PlayGame;
using Game.Module.Score;
using UnityEngine;


namespace Game.Scene.GamePlay
{
    public class GamePlayView : BaseSceneView
    {
        [SerializeField]
        public PlayGameView PlayGameView;

        [SerializeField]
        public ScoreView ScoreView;

    }
}



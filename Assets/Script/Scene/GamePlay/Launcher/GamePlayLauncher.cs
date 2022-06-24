using Agate.MVC.Base;
using Agate.MVC.Core;
using Game.Boot;
using Game.Module.PlayGame;
using Game.Module.Output;
using Game.Module.OpponentInput;
using Game.Module.Score;
using Game.Module.ScoreAudio;
using Game.Utility;
using System.Collections;
using UnityEngine;

namespace Game.Scene.GamePlay
{
    public class GamePlayLauncher : SceneLauncher<GamePlayLauncher, GamePlayView>
    {
        [SerializeField]
        private GamePlayView _gamePlayView;
        private PlayGameController _playGame;
        private ScoreController _score;


        protected override IConnector[] GetSceneConnectors()
        {
            return new IConnector[]
            {
                new AddScoreAudioConnector()
            };
        }

        protected override IController[] GetSceneDependencies()
        {
            return new IController[]
            {
                new PlayGameController(),
                new OutputController(),
                new OpponentInputController(),
                new ScoreController(),
                new AddScoreAudioController()
            };
        }

        protected override string GetSceneName()
        {
            return GameScene.GamePlay;
        }

        protected override GamePlayView GetSceneView()
        {
            return _gamePlayView;
        }

        protected override IEnumerator InitSceneObject()
        {
            _playGame.SetView(_view.PlayGameView);
            _score.SetView(_view.ScoreView);
            yield return null;
        }

        protected override IEnumerator LaunchScene()
        {
            yield return null;
        }
    }
}

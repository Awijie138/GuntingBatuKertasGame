using Agate.MVC.Base;
using Agate.MVC.Core;
using Game.Boot;
using Game.Module.PlayGame;
using Game.Utilty;
using System.Collections;
using UnityEngine;

namespace Game.Scene.GamePlay
{
    public class GamePlayLauncher : SceneLauncher<GamePlayLauncher, GamePlayView>
    {
        [SerializeField]
        private GamePlayView _gamePlayView;

        private PlayGameController _playGame;


        protected override IConnector[] GetSceneConnectors()
        {
            return new IConnector[]
            {

            };
        }

        protected override IController[] GetSceneDependencies()
        {
            return new IController[]
            {
                new PlayGameController()
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
            _playGame.SetView(_gamePlayView.PlayGameView);
            yield return null;
        }

        protected override IEnumerator LaunchScene()
        {
            yield return null;
        }
    }
}

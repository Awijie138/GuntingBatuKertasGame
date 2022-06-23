using Agate.MVC.Base;
using Agate.MVC.Core;
using Game.Boot;
using System.Collections;
using UnityEngine;

namespace Game.Scene.Gameplay
{
    public class GameplayLauncher : SceneLauncher<GameplayLauncher, GameplayView>
    {
        [SerializeField]
        protected GameplayView _gameplayView;

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

            };
        }

        protected override string GetSceneName()
        {
            return "Gameplay";
        }

        protected override GameplayView GetSceneView()
        {
            return _gameplayView;
        }

        protected override IEnumerator InitSceneObject()
        {
            yield return null;
        }

        protected override IEnumerator LaunchScene()
        {
            yield return null;
        }
    }
}

using Agate.MVC.Base;
using Agate.MVC.Core;
using Game.Boot;
using System.Collections;
using UnityEngine;

namespace Game.Scene.Menu
{
    public class MenuLauncher : SceneLauncher<MenuLauncher, MenuView>
    {

        [SerializeField]
        protected MenuView _menuView;

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
            return "Menu";
        }

        protected override MenuView GetSceneView()
        {
            return _menuView;
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
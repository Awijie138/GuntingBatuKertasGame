
using Agate.MVC.Base;
using Game.Boot;
using Game.Utilty;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Game.Module.Menu
{
    public class MenuController : ObjectController<MenuController, MenuView>
    {
        // Start is called before the first frame update
        public override void SetView(MenuView view)
        {
            base.SetView(view);
            view.Init(OnPlay, OnExit);
        }

        public static void OnPlay()
        {
            Debug.Log("Play");
            SceneManager.LoadScene(GameScene.GamePlay, LoadSceneMode.Additive);
        }

        public void OnExit()
        {
            Application.Quit();
        }

    }
}


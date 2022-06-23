using Agate.MVC.Base;
using Game.Boot;
using Game.Utilty;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Game.Module.PlayGame
{
    public class PlayGameController : ObjectController<PlayGameController, PlayGameView>
    {
        public override void SetView(PlayGameView view)
        {
            base.SetView(view);
            view.Init(ChooseGunting, ChooseBatu, ChooseKertas);
        }

        public void ChooseGunting()
        {
            Debug.Log("Gunting");
        }
        public void ChooseBatu()
        {
            Debug.Log("Batu");
        }
        public void ChooseKertas()
        {
            Debug.Log("Kertas");
        }
    }
}



using Agate.MVC.Base;

using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

namespace Game.Module.PlayGame
{
    public class PlayGameView : BaseView
    {
        [SerializeField]
        private Button _guntingButton;

        [SerializeField]
        private Button _batuButton;

        [SerializeField]
        private Button _kertasButton;


        public void Init(UnityAction chooseGunting, UnityAction chooseBatu, UnityAction chooseKertas)
        {
            _guntingButton.onClick.RemoveAllListeners();
            _guntingButton.onClick.AddListener(chooseGunting);
            _batuButton.onClick.RemoveAllListeners();
            _batuButton.onClick.AddListener(chooseBatu);
            _kertasButton.onClick.RemoveAllListeners();
            _kertasButton.onClick.AddListener(chooseKertas);

        }
    }
}
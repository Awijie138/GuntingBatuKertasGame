using Agate.MVC.Base;

using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

namespace Game.Module.PlayGame
{
    public class PlayGameView : ObjectView<IPlayGameModel>
    {
        [SerializeField]
        private Button _guntingButton, _batuButton, _kertasButton, _okButton;

        [SerializeField]
        private Text _playerInput, _opponentInput, _result;


        public void Init(UnityAction chooseGunting, UnityAction chooseBatu, UnityAction chooseKertas, UnityAction sendEvent)
        {
            _guntingButton.onClick.RemoveAllListeners();
            _guntingButton.onClick.AddListener(chooseGunting);
            _batuButton.onClick.RemoveAllListeners();
            _batuButton.onClick.AddListener(chooseBatu);
            _kertasButton.onClick.RemoveAllListeners();
            _kertasButton.onClick.AddListener(chooseKertas);
            _okButton.onClick.RemoveAllListeners();
            _okButton.onClick.AddListener(sendEvent);

        }

        protected override void InitRenderModel(IPlayGameModel model)
        {
            _playerInput.text = model.playerInput;
            _opponentInput.text = model.opponentInput;
            _result.text = model.result;
        }

        protected override void UpdateRenderModel(IPlayGameModel model)
        {
            _playerInput.text = model.playerInput;
            _opponentInput.text = model.opponentInput;
            _result.text = model.result;
        }
    }
}
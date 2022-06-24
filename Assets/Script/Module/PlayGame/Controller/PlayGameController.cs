using Agate.MVC.Base;
using Game.Module.OpponentInput;
using Game.Module.Output;
using Game.Module.Score;
using Game.Utility;
using UnityEngine.SceneManagement;

namespace Game.Module.PlayGame
{
    public class PlayGameController : ObjectController<PlayGameController, PlayGameModel, IPlayGameModel, PlayGameView>
    {

        private OpponentInputController _opponentInput;
        private OutputController _output;
        private ScoreController _score;


        public override void SetView(PlayGameView view)
        {
            base.SetView(view);
            view.Init(Menu, ChooseGunting, ChooseBatu, ChooseKertas, SendEvent);
        }

        public void Menu()
        {
            SceneManager.LoadScene(GameScene.MainMenu, LoadSceneMode.Additive);
        }

        public void ChooseGunting()
        {
            _model.SetNull();
            _model.SetPlayerInput(ContsGBK.gunting);
        }
        public void ChooseBatu()
        {
            _model.SetNull();
            _model.SetPlayerInput(ContsGBK.batu);

        }
        public void ChooseKertas()
        {
            _model.SetNull();
            _model.SetPlayerInput(ContsGBK.kertas);
        }

        public void SendEvent()
        {
            GetOpponentResult();
            GetResult();
            _score.SetScoreData(_model.result);
        }

        public void GetOpponentResult()
        {
            _opponentInput.SetOpponentInput();
            _model.SetOpponentInput(_opponentInput.GetOpponentInput());
        }

        public void GetResult()
        {
            _model.SetResult(_output.GetResult(_model.playerInput, _model.opponentInput));
        }


    }
}



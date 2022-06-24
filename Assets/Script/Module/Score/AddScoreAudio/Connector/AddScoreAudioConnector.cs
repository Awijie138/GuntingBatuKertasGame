using Agate.MVC.Base;
using Game.Module.Score;

namespace Game.Module.ScoreAudio
{
    public class AddScoreAudioConnector : BaseConnector
    {
        private AddScoreAudioController _addScoreAudio;

        protected override void Connect()
        {
            Subscribe<ScoreMessage>(_addScoreAudio.SetScoreData);
        }

        protected override void Disconnect()
        {
            Unsubscribe<ScoreMessage>(_addScoreAudio.SetScoreData);
        }
    }
}


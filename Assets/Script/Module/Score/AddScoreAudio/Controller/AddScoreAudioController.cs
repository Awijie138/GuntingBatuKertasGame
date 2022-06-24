using UnityEngine;
using Game.Module.Score;

using Agate.MVC.Base;

namespace Game.Module.ScoreAudio
{
    public class AddScoreAudioController : BaseController<AddScoreAudioController>
    {
        public void SetScoreData(ScoreMessage message)
        {
            Debug.Log("Add Score Audio Play");
        }
    }
}
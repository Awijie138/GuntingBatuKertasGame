using Agate.MVC.Base;
using Game.Utility;
using System.Collections.Generic;
using UnityEngine;

namespace Game.Module.OpponentInput
{
    public interface IOpponentInputModel : IBaseModel
    {
        string result { get; }
        List<string> gbk { get; }

    }
    public class OpponentInputModel : BaseModel, IOpponentInputModel
    {
        public string result { get; protected set; } = null;
        public List<string> gbk
        {
            get;
            protected set;
        } = new List<string> { ContsGBK.gunting, ContsGBK.batu, ContsGBK.kertas };

        public string GetOpponentResult()
        {
            int number = Random.Range(0, gbk.Count);

            result = gbk[number];

            return result;
        }
    }
}
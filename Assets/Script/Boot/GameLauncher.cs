using Agate.MVC.Base;
using Agate.MVC.Core;
using System.Collections;

namespace Game.Boot
{
    public class GameLauncher : BaseMain<GameLauncher>, IMain
    {
        protected override IConnector[] GetMainConnectors()
        {
            return new IConnector[]{

            };
        }

        protected override IController[] GetSystemDependencies()
        {
            return new IController[]{

            };
        }

        protected override IEnumerator InitSystem()
        {
            yield return null;
        }

    }
}
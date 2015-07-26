using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLoop
{
    class SplashScreenState : IGameObject
    {
        StateSystem _system;
        public SplashScreenState(StateSystem system)
        {
            _system = system;
        }
        #region IGameObject Members
        void IGameObject.Render()
        {
            System.Console.WriteLine("rendering splash");
        }

        void IGameObject.Update(double elapsedTime)
        {
            System.Console.WriteLine("updating splash");
        }
        #endregion;
    }
}

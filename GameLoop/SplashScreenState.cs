﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tao.OpenGl;

namespace GameLoop
{
    class SplashScreenState : IGameObject
    {
        StateSystem _system;
        double _delayInSeconds = 3;
        public SplashScreenState(StateSystem system)
        {
            _system = system;
        }
        #region IGameObject Members

        public void Update(double elapsedTime)
        {
            _delayInSeconds -= elapsedTime;
            if (_delayInSeconds <= 0)
            {
                _delayInSeconds = 3;
                _system.ChangeState("title_menu");
            }
            //System.Console.WriteLine("updating splash");
        }
        public void Render()
        {
            Gl.glClearColor(1, 1, 1, 1);
            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT);
            Gl.glFinish();
        }

       
        #endregion;
    }
}

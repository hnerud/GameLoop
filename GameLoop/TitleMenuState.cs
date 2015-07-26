using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLoop
{
    class TitleMenuState : IGameObject
    {
        
        void IGameObject.Render()
        {
            Console.WriteLine("render TitleMenuState");
        }

        void IGameObject.Update(double elapsedTime)
        {
            Console.WriteLine("update TitleMenuState");
        }


    }
}

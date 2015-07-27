using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tao.OpenGl;

namespace GameLoop
{
    
    public partial class Form1 : Form
    {
        FastLoop _fastLoop;
        StateSystem _system = new StateSystem();

        bool _fullscreen = false;
        public Form1()
        {
            
            InitializeComponent();
            _openGLControl.InitializeContexts();


            if (_fullscreen)
            {
                FormBorderStyle = FormBorderStyle.None;
                WindowState = FormWindowState.Maximized;
            }
            else
                ClientSize = new Size(1280, 720);

            _system.AddState("splash", new SplashScreenState(_system));
            _system.AddState("title_menu", new TitleMenuState());

            //start state
            _system.ChangeState("splash");
        }

      

        void GameLoop(double elapsedTime)
        {
            _system.Update(elapsedTime);
            _system.Render();
            _openGLControl.Refresh();

        }
        protected override void OnClientSizeChanged(EventArgs e)
        {
            base.OnClientSizeChanged(e);
            Gl.glViewport(0, 0, this.ClientSize.Width, this.ClientSize.Height);
            Setup2DGraphics(ClientSize.Width, ClientSize.Height);
            _fastLoop = new FastLoop(GameLoop);

        }

        private void Setup2DGraphics(double width, double height)
        {
            double halfWidth = width / 2;
            double halfHeight = height / 2;
            Gl.glMatrixMode(Gl.GL_PROJECTION);
            Gl.glLoadIdentity();
            Gl.glOrtho(-halfWidth, halfWidth, -halfHeight, halfHeight, -100, 100);
            Gl.glMatrixMode(Gl.GL_MODELVIEW);
            Gl.glLoadIdentity();
        }

    }
}

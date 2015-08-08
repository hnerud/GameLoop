﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tao.OpenGl;
using Tao.DevIl;

namespace GameLoop
{
    
    public partial class Form1 : Form
    {
<<<<<<< HEAD
        FastLoop _fastLoop;
        StateSystem _system = new StateSystem();

        bool _fullscreen = false;
        TextureManager _textureManager = new TextureManager();
=======
>>>>>>> parent of 8665749... Unit testing phase
        public Form1()
        {
            _fastLoop = new FastLoop(GameLoop);

            InitializeComponent();
            _openGLControl.InitializeContexts();
<<<<<<< HEAD

            // Initialize DevIL
            Il.ilInit();
            Ilu.iluInit();
            Ilut.ilutInit();
            Ilut.ilutRenderer(Ilut.ILUT_OPENGL);

            //Load textures

            _textureManager.LoadTexture("face", "face.tif");
            _textureManager.LoadTexture("face_alpha", "face_alpha.tif");




            if (_fullscreen)
            {
                FormBorderStyle = FormBorderStyle.None;
                WindowState = FormWindowState.Maximized;
            }
            else
                ClientSize = new Size(1280, 720);

            _system.AddState("splash", new SplashScreenState(_system));
            _system.AddState("title_menu", new TitleMenuState());
            _system.AddState("sprite", new DrawSpriteState(_textureManager));
            _system.AddState("sprite_test", new TestSpriteClassState(_textureManager));

            //start state
            _system.ChangeState("sprite_test");
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

=======
        }
>>>>>>> parent of 8665749... Unit testing phase
    }
}

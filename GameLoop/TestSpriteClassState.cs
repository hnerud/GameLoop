﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tao.OpenGl;

namespace GameLoop
{
    class TestSpriteClassState : IGameObject
    {

        TextureManager _textureManager;
        Renderer _renderer = new Renderer();
        sprite _testSprite = new sprite();
        sprite _testSprite2 = new sprite();

        public TestSpriteClassState(TextureManager textureManager)
        {
            _textureManager = textureManager;
            _testSprite.Texture = _textureManager.Get("face_alpha");
            _testSprite.SetHeight(256 * 0.5f);

            _testSprite2.Texture = _textureManager.Get("face_alpha");
            _testSprite2.SetPosition(-256, -256);
            _testSprite2.SetColor(new Color(1, 0, 0, 1));
        }
       public void Render()
        {
            Gl.glClearColor(0.0f, 0.0f, 0.0f, 1.0f);
            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT);
            _renderer.DrawSprite(_testSprite);
            _renderer.DrawSprite(_testSprite2);
            Gl.glFinish();
        }

        public void Update(double elapsedTime)
        {
           
        }
    }
}

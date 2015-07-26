using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameLoop
{
    public partial class Form1 : Form
    {
        StateSystem _system = new StateSystem();
        public Form1()
        {
            InitializeComponent();
            _openGLControl.InitializeContexts();

            _system.AddState("splash", new SplashScreenState(_system));
            _system.AddState("title_menu", new TitleMenuState());

            _system.ChangeState("splash");
        }


    }
}

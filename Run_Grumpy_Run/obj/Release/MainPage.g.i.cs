﻿#pragma checksum "C:\Users\flofl\Desktop\Run_Grumpy_Run-master\Run_Grumpy_Run\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "C99CB187B3D6C202EA45010C46553738"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

using Run_Grumpy_Run;
using System;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Resources;
using System.Windows.Shapes;
using System.Windows.Threading;


namespace Run_Grumpy_Run {
    
    
    public partial class MainPage : System.Windows.Controls.UserControl {
        
        internal System.Windows.Controls.Canvas LayoutRoot;
        
        internal Run_Grumpy_Run.player x_player;
        
        internal System.Windows.Controls.TextBlock DebugBox;
        
        internal System.Windows.Shapes.Rectangle gameOver;
        
        internal System.Windows.Shapes.Rectangle win;
        
        internal System.Windows.Controls.Button _try;
        
        internal System.Windows.Shapes.Rectangle door;
        
        internal System.Windows.Shapes.Rectangle door2;
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Windows.Application.LoadComponent(this, new System.Uri("/Run_Grumpy_Run;component/MainPage.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Canvas)(this.FindName("LayoutRoot")));
            this.x_player = ((Run_Grumpy_Run.player)(this.FindName("x_player")));
            this.DebugBox = ((System.Windows.Controls.TextBlock)(this.FindName("DebugBox")));
            this.gameOver = ((System.Windows.Shapes.Rectangle)(this.FindName("gameOver")));
            this.win = ((System.Windows.Shapes.Rectangle)(this.FindName("win")));
            this._try = ((System.Windows.Controls.Button)(this.FindName("_try")));
            this.door = ((System.Windows.Shapes.Rectangle)(this.FindName("door")));
            this.door2 = ((System.Windows.Shapes.Rectangle)(this.FindName("door2")));
        }
    }
}


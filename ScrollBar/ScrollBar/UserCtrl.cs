﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace ScrollBar
{
    public partial class UserCtrl : UserControl
    {
        public UserCtrl()
        {
            InitializeComponent();
        }
        void ScrollBar_Onpaint(object sender, PaintEventArgs e)
        {
            base.OnPaint(e);
        }
    }
}

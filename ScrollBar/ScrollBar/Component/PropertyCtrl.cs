using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PropertyCtrl
{
    [DefaultEvent("ComPropertyChanged")]
    public class ComPropertyCtrl : Control
    {
        public ComPropertyCtrl()
        { 

        }

        public ComPropertyCtrl(IContainer container)
        {
            container.Add(this); 
        }

        #region 事件委托

        /// <summary>
        /// 委托
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public delegate void LScrolledEventHandler(object sender, LScrollEventArgs e);
        /// <summary>
        /// 发生滚动时引发的事件
        /// </summary>
        public event LScrolledEventHandler LScrolled;

        #endregion

        #region 事件声明
        /// <summary>
        /// 滚动条事件数据                                                                                                                                 
        /// </summary>
        public class LScrollEventArgs : EventArgs
        {
            /// <summary>
            /// 滚动条事件数据
            /// </summary>
            /// <param name="sliderPosition">滑块距顶部（垂直）/左侧（横向）位置</param>
            /// <param name="showPosition">显示位置（正数）</param>
            public LScrollEventArgs(float sliderPosition, float showPosition)
            {
                SliderPosition = sliderPosition;
                //ShowPosition = showPosition;
                ShowPositionPercent = showPosition;
            }

            /// <summary>
            /// 滑块距顶部（垂直）/左侧（横向）位置
            /// </summary>
            public float SliderPosition { get; set; }
            /// <summary>
            /// 显示位置（正数）
            /// </summary>
            public float ShowPosition { get; set; }
            /// <summary>
            /// 显示位置百分比（正数）
            /// </summary>
            public float ShowPositionPercent { get; set; }
        }
        #endregion 
    }
}

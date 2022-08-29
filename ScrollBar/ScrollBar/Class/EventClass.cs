using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventClass
{ 
    /// <summary>
    /// Plugin加载完成事件信息                                                                                                                                 
    /// </summary>
    public class PluginOnLoadedEventArgs : EventArgs
    {
        /// <summary>
        /// 滚动条事件数据
        /// </summary>
        /// <param name="sliderPosition">滑块距顶部（垂直）/左侧（横向）位置</param>
        /// <param name="showPosition">显示位置（正数）</param>
        public PluginOnLoadedEventArgs(string pluginName)
        {
            PluginName = pluginName; 
        }

        /// <summary>
        /// 滑块距顶部（垂直）/左侧（横向）位置
        /// </summary>
        public string PluginName { get; set; } 
    }
}

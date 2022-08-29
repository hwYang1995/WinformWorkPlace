using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Common
{
    class ClassOnShowToolTips
    {
        #region   基础参数
        //信息提示组件
        private static ToolTip _toolTip = new ToolTip();

        #endregion
         
        #region   公有方法 
        /// <summary>
        /// 设置单个控件提示信息
        /// </summary>
        /// <typeparam name="T">组件类型</typeparam>
        /// <param name="t">组件</param>
        /// <param name="tipInfo">需要显示的提示信息</param>
        public static void SettingSingleTipInfo<T>(T t, string tipInfo) where T : Control
        {
            _toolTip.SetToolTip(t, tipInfo);
        }
         
        /// <summary>
        /// 设置多个同种类型的提示信息
        /// </summary>
        /// <typeparam name="T">组件类型</typeparam>
        /// <param name="dic">组件和提示信息字典</param>
        public static void SettingMutiTipInfo<T>(Dictionary<T, string> dic) where T : Control
        {
            if (dic == null || dic.Count <= 0) return;

            foreach (var item in dic)
            {
                _toolTip.SetToolTip(item.Key, item.Value);
            }

        }
 
        #endregion 
 
        #region   私有方法 
        #endregion 
  }
}

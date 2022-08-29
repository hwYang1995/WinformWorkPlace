using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;
using EventClass;
using System.Drawing;
using Common;

namespace PluginNameSpace
{
    [DefaultEvent("PluginLoaded")]
    public class PlguinTemplate:Control
    {
        private BindingSource source = new BindingSource();
        public Dictionary<TextBox, string> dic = new Dictionary<TextBox, string>();
        //OnShowToolTips MoveOverInfoTip = new OnShowToolTips();
        #region 构造函数
        public PlguinTemplate()
        {
            propertiesTitle.Text      = "Property Types:";
            propertiesNames.Text      = "Property names:";
            propertiesTitle.Location  = new System.Drawing.Point(20, 120);
            propertiesNames.Location  = new System.Drawing.Point(20, 140);
            propertiesNames.Size      = new System.Drawing.Size(159, 68);
            propertiesNames.Multiline = true;
            propertiesTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            propertiesNames.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            propertiesTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            propertiesNames.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            dic.Add(propertiesNames, "这是属性控件的名字");
            dic.Add(propertiesTitle, "这是属性控件的标题");
            ClassOnShowToolTips.SettingMutiTipInfo(this.dic);

            Controls.Add(propertiesTitle);
            Controls.Add(propertiesNames);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            CreateControl();

        }
        #endregion

        #region 控件属性
        private TextBox propertiesTitle = new TextBox();
        private TextBox propertiesNames = new TextBox();
        /// <summary>
        /// 背景条颜色
        /// </summary>
        [Category("Property Types"), Description("插件包含的属性")]
        public TextBox PropertyNames
        {
            get { return propertiesNames; }
            set
            {
            }
        }
        #endregion

        #region 事件定义
        /// <summary>
        /// 委托
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public delegate void PluginOnLoadedEventHandler(object sender, PluginOnLoadedEventArgs e);
        /// <summary>
        /// 发生滚动时引发的事件
        /// </summary>
        public event PluginOnLoadedEventHandler onLoaded;
        #endregion

        #region 成员变量 private
        private TextBox        tbProperties = new TextBox();
        private metadataList   metaDataList = new metadataList();
        private PropertyCtrl[] propertyArraies;
        private delegate void UpdateInvoke();//invoke方法创建委托
        #endregion

        #region 成员变量 public
        public metadataList m_metaDataList
        {
            get { return metaDataList; }
            set
            {
                metaDataList = value;
            }
        }
        #endregion

        #region DLLImport
        //[DllImport("kernel32.dll")]
        //private extern static IntPtr LoadLibrary(String path); 
        //[DllImport("kernel32.dll")]
        //private extern static IntPtr GetProcAddress(IntPtr lib, String funcName); 
        //[DllImport("kernel32.dll")]
        //private extern static bool FreeLibrary(IntPtr lib);

        public const string dllStr = "Library\\Win32Project1";
        [DllImport(dllStr)]
        public static extern int init();
        [DllImport(dllStr)]
        static extern int getPropertyList([In, Out]metadata[] metaDataVar);
        [DllImport(dllStr)]
        static extern int propertyChanged([In, Out]metadata[] metaDataVar);
        #endregion

        #region 声明变量 

        #endregion
 
        #region 成员函数 public
        /// <summary>
        /// 创建代理线程，创建属性控件，并更新信息<para /> 
        /// <returns>启动成功返回true，反之返回false</returns>
        /// </summary> 
        public ResultEnum paintUpdate()
        {
            UpdateInvoke cInvok = new UpdateInvoke(onCreateProperties);
            BeginInvoke(cInvok);
            return ResultEnum.rlt_OK;
        }
        /// <summary>
        /// 创建代理线程，通知Plugin更新控件信息<para /> 
        /// <returns>启动成功返回true，反之返回false</returns>
        /// </summary> 
        public ResultEnum updatePropertyValue()
        {
            UpdateInvoke cInvok = new UpdateInvoke(onPaintUpdate);
            BeginInvoke(cInvok);
            return ResultEnum.rlt_OK;
        }
        #endregion

        #region 成员函数 private 
        /// <summary>
        /// Plugin更新控件属性信息<para />  
        /// </summary> 
        private void onCreateProperties()
        {
            int iPropCount  = metaDataList.count;
            propertyArraies = new PropertyCtrl[iPropCount];
            onPaintUpdate();
        } 
        /// <summary>
        /// Plugin更新控件属性信息<para />  
        /// </summary> 
        private void onPaintUpdate()
        {
            int i = 0;
            int iPropCount  = metaDataList.count; 
            string text = "";
            for (; i < iPropCount; i++)
            {
                propertyArraies[i] = new PropertyCtrl(metaDataList.metaData[i]);
                text += propertyArraies[i].pro_propertyName + "\r\n";
            }
            propertiesNames.Text = text;
            Invalidate();
            onLoaded?.Invoke(this, new PluginOnLoadedEventArgs("PluginName"));
        }
        #endregion

    }

    public class PropertyCtrl
    {
        #region 成员变量private
        private char   propertyType;
        private string propertyTip;
        private string propertyName;
        private string propertyValue;
        #endregion 

        #region 成员变量 public
        /// <summary>
        /// 属性的名字
        /// </summary> 
        public string pro_propertyName
        {
            get { return propertyName; }
            set
            {
                propertyName = value; 
            }
        }
        /// <summary>
        /// 属性的tips
        /// </summary> 
        public string pro_propertyTip
        {
            get { return propertyTip; }
            set
            {
                propertyTip = value;
            }
        }
        /// <summary>
        /// 属性的值
        /// </summary> 
        public string pro_propertyValue
        {
            get { return propertyValue; }
            set
            {
                propertyValue = value;
            }
        } 
        /// <summary>
        /// 属性的类型
        /// </summary>
        public char pro_propertyType
        {
            get { return propertyType; }
            set
            {
                propertyType = value;
            }
        }
        #endregion

        #region 构造函数
        public PropertyCtrl(metadata propertyData)
        {
            propertyTip = propertyData.DisplayTips;
            propertyType = propertyData.PropertyType;
            propertyName = propertyData.DisplayName;
            propertyValue = propertyData.PropertyValue;
        }
        #endregion
        
        #region 函数 public
         
        #endregion
    }
}

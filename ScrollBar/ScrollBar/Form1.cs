using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SrollBarControl; //using for Scroll control
using System.Runtime.InteropServices;//using for load Dll
using System.Reflection;
using PluginNameSpace;
using EventClass;
using Common;

namespace ScrollBar
{    
     
    public partial class Form1 : Form
    {
        //[DllImport("D:/VsWorkPlace/ScrollBar/ScrollBar/ScrollBar/bin/Debug/DllPlugin.dll", EntryPoint = "funtion1", CallingConvention = CallingConvention.Cdecl)]
        //public static extern int AlarmShow(); 
        //[DllImport("Library.dll", EntryPoint = "f1", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        ClassLoadDll LoadDLLPlugin = new ClassLoadDll();
        PlguinTemplate pluginObj = new PlguinTemplate();

        int MainFormHeight  = 1080;
        int MainFormLength = 1920;
        int UserCtrlX = 360;
        int UserCtrlY = 12;
        public Form1()
        {
            InitializeComponent();
            MainFormHeight = ClientSize.Height;
            MainFormLength = ClientSize.Width; 
        }
          
        void Form1_Onpaint(object sender, PaintEventArgs e)
        {
            MainFormHeight = this.ClientSize.Height;
            MainFormLength = this.ClientSize.Width;
        }

        void Form1_OnDraged(object sender, EventArgs e)
        {
            MainFormHeight = this.ClientSize.Height;
            MainFormLength = this.ClientSize.Width;
            ScrollBarChanged();
            //Console.WriteLine(" Form1_OnDraged ");
        }

        void UserCtrlPanel_Onpaint(object sender, PaintEventArgs e)
        {
            base.OnPaint(e);
            UserCtrlX = UserCtrlPanel.Location.X;
            UserCtrlY = UserCtrlPanel.Location.Y;
            //Console.WriteLine(" UserCtrl_Onpaint  MainFormLength" + MainFormLength + " UserCtrlX " + UserCtrlX + "  UserCtrlX + 936 " + (UserCtrlX + 936));
            ScrollBarChanged();
        }

        void ScrollBarChanged()
        {
            int offset = (UserCtrlX + 936 - MainFormLength);
            int ScrollBarLen = (936 - offset) * 9 / 10;
             
            if (offset > 0)
            {
                ScrollBarCtrl.Visible = true;
                ScrollBarCtrl.L_CtrlLen = ScrollBarLen;
                ScrollBarCtrl.Size = new System.Drawing.Size(ScrollBarLen, 15);
                ScrollBarCtrl.L_CtrlShowLen = ScrollBarLen * 9 / 10;
                Console.WriteLine("offset  " + offset + " ScrollBarLen  " + ScrollBarLen + "  ScrollBarCtrl.L_CtrlShowLen  " + ScrollBarCtrl.L_CtrlShowLen);
            }
            else { ScrollBarCtrl.Visible = false; };
        }

        private void ScrollBar_LScrolled(object sender, LScrollEventArgs e)
        {
            //Console.WriteLine("ScrollBar_LScrolled  " + e.ShowPosition);

            for (int i = 0; i < UserCtrlPanel.Controls.Count; i++)
            {
                int length = UserCtrlPanel.Controls[i].Width;
                double ScrollPos = Convert.ToDouble(e.ShowPositionPercent);  //percent 0 - 90
                int x = (int)(-(length * ScrollPos) / 2);
                Console.WriteLine("length:  " + length + " ScrollPos " + ScrollPos + "  ScrollBar x " + x + " ScrollPos " + ScrollPos);
                UserCtrlPanel.Controls[i].Location = new Point(x, 0);
            }
        }

        [DllImport("Library\\Win32Project1")]
        public static extern int init();
        [DllImport("Library\\Win32Project1")]
        static extern int getPropertyList([In, Out]metadata[] metaDataVar);
        [DllImport("Library\\Win32Project1")]
        static extern int propertyChanged(int eventEnum, [In, Out]metadata[] metaDataVar);
        private delegate int init1();
        public class Info
        {
            public string Id { get; set; }
            public string Name { get; set; }

        }
        private void DLLLoadBt_Click(object sender, EventArgs e)
        {
            string fileName = "D:\\VsWorkPlace\\VSWorkplace\\ScrollBar\\ScrollBar\\ScrollBar\\bin\\Debug\\Library\\Win32Project1.dll";
            ResultEnum rlt = LoadDLLPlugin.LoadDLLByFileName(fileName);
            IntPtr initFunGet = LoadDLLPlugin.LoadFunByName("_init@0");
            init1 initFun = (init1)Marshal.GetDelegateForFunctionPointer(initFunGet, typeof(init1));
            int ProListCount1 = initFun();

            addPlugin();
            /* 调用接口获得属性数量 */
            int ProListCount = init();
            /* 初始化属性列表 */
            metadataList metaDataListTemp = new metadataList();
            metaDataListTemp.count = ProListCount;
            metaDataListTemp.metaData = new metadata[ProListCount];
            /* 获取所有属性列表的内容 */
            int sizeVal = getPropertyList(metaDataListTemp.metaData);
            pluginObj.m_metaDataList = metaDataListTemp;
            pluginObj.paintUpdate();
            /* 测试内容 */
            PropertiesNameList.Text = metaDataListTemp.metaData[0].DisplayName + "\r\n" +
                                      metaDataListTemp.metaData[1].DisplayName + "\r\n" +
                                      metaDataListTemp.metaData[2].DisplayName + "\r\n" +
                                      metaDataListTemp.metaData[3].DisplayName;
            PropertityTips.Text = metaDataListTemp.metaData[0].DisplayTips;
            PropertyValue.Text  = metaDataListTemp.metaData[0].PropertyValue.ToString();
            /* 创建comBox信息 */
            IList<Info> infoList = new List<Info>();
            Info info1 = new Info() { Id = "0", Name = metaDataListTemp.metaData[0].DisplayName };
            Info info2 = new Info() { Id = "1", Name = metaDataListTemp.metaData[1].DisplayName };
            Info info3 = new Info() { Id = "2", Name = metaDataListTemp.metaData[2].DisplayName };
            Info info4 = new Info() { Id = "3", Name = metaDataListTemp.metaData[3].DisplayName };
            infoList.Add(info1);
            infoList.Add(info2);
            infoList.Add(info3);
            infoList.Add(info4);
            PropertyBind.DataSource    = infoList;
            PropertyBind.ValueMember   = "Id";
            PropertyBind.DisplayMember = "Name"; 
        }
        //private void createCombox
        
        private void addPlugin()
        {
            pluginObj.Location = new System.Drawing.Point(40, 11);
            pluginObj.Size = new System.Drawing.Size(195, 431);
            pluginObj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            pluginObj.onLoaded += new PlguinTemplate.PluginOnLoadedEventHandler(this.onPluginLoaded);
            this.Controls.Add(pluginObj);
        }

        private void onPluginLoaded(object sender, PluginOnLoadedEventArgs e)
        {
            Console.WriteLine(" onPluginLoaded !!!");
        }

        private void propertyValueChanged(object sender, EventArgs e)
        {
            DataChanged();
        }

        private void DataChanged()
        {
            /* 做一下界面的容错处理 */
            int tempValue;
            metadataList metaDataListTemp = new metadataList();
            metaDataListTemp = pluginObj.m_metaDataList;
            if (int.TryParse(PropertyValue.Text, out tempValue))
            {
                metaDataListTemp.metaData[0].PropertyValue = PropertyValue.Text;
            }

            /* 将结构体传给c++端，c++端通过对应的属性值进行，相关逻辑属性值的赋值 */
            int indexOfProperty = PropertyBind.SelectedIndex;
            //IntPtr propertyChanged1 = LoadDLLPlugin;
            int sizeRlt = propertyChanged(metaDataListTemp.metaData[indexOfProperty].DataChangeEvent, metaDataListTemp.metaData);
            DLLOutputValue.Text = metaDataListTemp.metaData[indexOfProperty].PropertyValue;
            pluginObj.m_metaDataList = metaDataListTemp;
            pluginObj.updatePropertyValue();
        }

        private void DLLUnLoadBt_Click(object sender, EventArgs e)
        {  
        }

        private void PropertyBind_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indexOfProperty = PropertyBind.SelectedIndex; 
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace PluginNameSpace
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct metadata
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 30)]
        public string DisplayName;   //属性的名字
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 50)]
        public string DisplayTips;   //属性的解释
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 50)]
        public string PropertyValue;

        public char DataChangeEvent; //事件信号
        public char PropertyType;    //0:string, 1:text, 2:combox

        public int PropertyReturnValue;
    };

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct metadataList
    {
        public metadata[] metaData;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 30)]
        public string pluginName;
        public int count;
    };
}

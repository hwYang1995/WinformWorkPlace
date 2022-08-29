using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using PluginNameSpace;

namespace Common
{
    class ClassLoadDll
    {
        /// <summary>
        /// 装载指定DLL动态库
        /// </summary>
        /// <param name="dllToLoad"></param>
        /// <returns></returns>
        [DllImport("kernel32.dll")]
        public static extern IntPtr LoadLibrary(string dllToLoad);
        /// <summary>
        /// 获得函数的入口地址
        /// </summary>
        /// <param name="hModule"></param>
        /// <param name="procedureName"></param>
        /// <returns></returns>
        [DllImport("kernel32.dll")]
        public static extern IntPtr GetProcAddress(IntPtr hModule, string procedureName);
        /// <summary>
        /// 从内存中卸载动态库
        /// </summary>
        /// <param name="hModule"></param>
        /// <returns></returns>
        [DllImport("kernel32.dll")]
        public static extern bool FreeLibrary(IntPtr hModule);
         

        #region 成员变量 private
        private IntPtr m_pDll;
        #endregion

        #region 成员变量 public
        public IntPtr m_PtrDll
        {
            get { return m_pDll; }
            set {}
        }
        #endregion

        #region 成员函数 public
        /// <summary>
        /// 加载dll
        /// <param name="strDLLFileName">dll文件名</param>
        /// </summary>
        /// <returns name="ResultEnum.rlt_OK">ResultEnum枚举成功</returns>
        public ResultEnum LoadDLLByFileName(string strDLLFileName)
        { 
            m_pDll = LoadLibrary(strDLLFileName);
            return ResultEnum.rlt_OK;
        }
        /// <summary>
        /// 获取函数指针
        /// <param name="strFunName">函数名</param>
        /// </summary>
        /// <returns name="pAddressOfFunctionToCall">函数指针</returns>
        public IntPtr LoadFunByName(string strFunName)
        {
            IntPtr pAddressOfFunctionToCall = GetProcAddress(m_pDll, strFunName);
            return pAddressOfFunctionToCall;
        }
        /// <summary>
        /// 从内存中卸载动态库
        /// </summary> 
        /// <returns name="ResultEnum.rlt_OK">ResultEnum枚举成功</returns>
        public bool FreeDllLibrary(string strDLLFileName)
        { 
            bool result = FreeLibrary(m_pDll);
            return result;
        }
        #endregion
    }
}

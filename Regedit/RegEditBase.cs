using Microsoft.Win32;
using System;

namespace SchoolNetwork.Regedit
{
    internal static class RegEditBase
    {


        private const string RegStr = @"HKEY_CLASSES_ROOT\DesktopBackground\Shell\SchoolNet";


        /// <summary>
        /// 初始化一级菜单
        /// </summary>
        public static void InitializationReg()
        {
            Registry.SetValue(RegStr, "MUIVerb", "校园网");
            Registry.SetValue(RegStr, "SubCommands", "");
        }


        /// <summary>
        /// 创建二级菜单项
        /// </summary>
        /// <param name="item">要添加的菜单选项</param>
        /// <param name="ItemName">菜单显示</param>
        /// <param name="src">启动程序的路径以及参数</param>
        /// 
        public static void SetReg(ContextMenuItem item, string ItemName, string src)
        {
            Registry.SetValue(RegStr + @"\shell\" + item.ToString(), "", ItemName);
            Registry.SetValue(RegStr + @"\shell\" + item.ToString() + @"\command", "", src);

        }

        /// <summary>
        /// 删除二级菜单项
        /// </summary>
        /// <param name="item">要删除的菜单项</param>
        public static void DelSecondReg(ContextMenuItem item)
        {
            RegistryKey key = Registry.ClassesRoot.OpenSubKey(@"DesktopBackground\Shell\SchoolNet\shell", true);
            key.DeleteSubKeyTree(item.ToString());
            key.Close();
        }
        /// <summary>
        /// 删除所有二级子项
        /// </summary>
        public static void DelAllSecongReg()
        {
            RegistryKey key = Registry.ClassesRoot.OpenSubKey(@"DesktopBackground\Shell\SchoolNet", true);
            try
            {
                key.DeleteSubKeyTree(@"shell");
            }
            catch (Exception)
            {
                //捕捉异常，不做处理
            }
            finally
            {
                key.Close();
            }

        }
        /// <summary>
        /// 删除所有菜单项
        /// </summary>
        public static void DelAll()
        {
            RegistryKey key = Registry.ClassesRoot.OpenSubKey(@"DesktopBackground\Shell", true);
            try
            {
                key.DeleteSubKeyTree("SchoolNet");
            }
            catch (Exception)
            {
                //捕捉异常，不做处理
            }
            finally
            {
                key.Close();
            }
        }
    }
}

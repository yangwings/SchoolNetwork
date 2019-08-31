using SchoolNetwork.API;
using SchoolNetwork.Attributes;
using SchoolNetwork.Config;
using SchoolNetwork.Exceptions;
using SchoolNetwork.Forms;
using SchoolNetwork.Interfaces;
using SchoolNetwork.Log;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolNetwork
{
    #region 枚举值
    ///<summary>
    /// 登录返回值
    /// </summary>
    public enum BackCode
    {
        /// <summary>
        /// 登录成功
        /// </summary>
        Sucess = 1,
        /// <summary>
        /// 登录失败
        /// </summary>
        Fail = 0,
        None = 11,
    }
    /// <summary>
    /// 右键菜单选项
    /// </summary> 
    public enum ContextMenuItem
    {
        /// <summary>
        /// 用户姓名
        /// </summary>
        a_UserName = 1,
        /// <summary>
        /// 连接
        /// </summary>
        b_Connect = 2,
        /// <summary>
        /// 断开
        /// </summary>
        c_BreakOff = 3,
        /// <summary>
        /// 用户套餐类型
        /// </summary>
        d_PackageType = 4,
        /// <summary>
        /// 到期时间
        /// </summary>
        e_MaturityTime = 5,
        /// <summary>
        /// 稍候
        /// </summary>
        f_Wait = 6,
        /// <summary>
        /// 关于
        /// </summary>
        g_About = 7

    }
    #endregion

    public static class Start
    {
        public static void Run<TIWebMethod>(string[] args) where TIWebMethod : IWebMethod
        {
            try
            {
                Mutex mutex = new Mutex(true, Application.ProductName, out bool ret);

                if (ret)//未启动
                {
                    
                    Run<TIWebMethod>(Configuration.SetConfig<TIWebMethod>(
                        (LoggingMode)Enum.Parse(typeof(LoggingMode),BackLoggingInfo(() => { return typeof(TIWebMethod).GetCustomAttribute(typeof(LoggerAttribute)); },0)),
                        BackLoggingInfo(() => { return typeof(TIWebMethod).GetCustomAttribute(typeof(LoggerAttribute)); },1)
                        ));
                    mutex.ReleaseMutex();
                }
                else//已启动
                {
                    Communication.Send(args[0]);
                    Application.Exit();//退出程序   
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
            }
        }

        private static string BackLoggingInfo(Func<object> func,UInt16 src) 
        {
            try
            {
                string _back=func.Invoke().GetType().GetRuntimeFields().ToArray()[src].GetValue(func.Invoke()).ToString();
                return _back;
            }
            catch (Exception)
            {
                if (src==0)
                {
                    return LoggingMode.Disabled.ToString();
                }
                else
                {
                    return @"./Login/";
                }
            }
            
        }

        private static void Run<T>(Configuration config) where T : IWebMethod
        {
            List<Type> AttrList = new List<Type>()
            {
                typeof(LoginAttribute),
                typeof(GetUserInfoAttribute),
                typeof(GetCodeAttribute),
                typeof(OfflineAttribute)
            }; 
            foreach (var method in typeof(T).GetMethods(BindingFlags.DeclaredOnly | BindingFlags.Public | BindingFlags.Instance | BindingFlags.NonPublic))
            {
                foreach (var Attr in method.GetCustomAttributes())
                {
                    if (AttrList.Contains(Attr.GetType()))
                    {
                        AttrList.Remove(Attr.GetType());
                        if (config.Dic_type.Values.Contains(method)) { Logger.Error("错误信息：", new AttributeMoreException(typeof(T).Name + "." + method.Name)); throw new AttributeMoreException(typeof(T).Name + "." + method.Name); }
                        config.Dic_type.Add(Attr.GetType().GetField("Name").GetRawConstantValue().ToString(), method);
                        
                    }
                }
            }
            config.ContextMenu.Init();
            StringBuilder temp_u;
            StringBuilder temp_p;

            if(!Expandini.GetiniFile(out temp_u, out temp_p, config)) config.ContextMenu.SetLogin();
            config.ContextMenu.SetUser();
            while (true)
            {
                Communication.Receive(out string message);
                switch ((ContextMenuItem)Enum.Parse(typeof(ContextMenuItem), message))
                {
                    case ContextMenuItem.a_UserName:
                        break;
                    case ContextMenuItem.b_Connect:
                        using (LoginForm loginForm = new LoginForm(config))
                        {
                            var result = loginForm.ShowDialog();
                            if (result == DialogResult.OK)
                            {
                                config.ContextMenu.SetUser();

                                Task.Run(()=> {
                                    var _back=(string[])config.CallMethod("GetUserInfo", new object[] { });
                                    config.ContextMenu.SetUser(_back[0], _back[1], _back[2]);
                                    });
                            }
                        }
                        break;
                    case ContextMenuItem.c_BreakOff:
                        using (OffLineForm offLineForm=new OffLineForm(config))
                        {
                            offLineForm.ShowDialog();
                        }
                        break;
                    case ContextMenuItem.d_PackageType:
                        break;
                    case ContextMenuItem.e_MaturityTime:
                        break;
                    case ContextMenuItem.f_Wait:
                        break;
                    case ContextMenuItem.g_About:
                        break;
                }
            }
        }
       
    }
}

namespace SchoolNetwork.Regedit
{
    internal class ContextMenuRegEdit
    {


        private string RunPath { get; set; }
        private string name { get; set; }
        private static readonly object o = new object();

        public ContextMenuRegEdit(string runPath, string name)
        {
            RunPath = runPath;
            this.name = name;
        }
        /// <summary>
        /// 初始化一级菜单
        /// </summary>
        public void Init()
        {
            lock (o)
            {
                RegEditBase.InitializationReg();
            }
        }

        /// <summary>
        /// 设置登录后界面
        /// </summary>
        public void SetUser()
        {
            lock (o)
            {
                RegEditBase.DelAllSecongReg();
                RegEditBase.SetReg(ContextMenuItem.g_About, "关于", RunPath + name + " " + ContextMenuItem.g_About.ToString());
                RegEditBase.SetReg(ContextMenuItem.c_BreakOff, "断开", RunPath + name + " " + ContextMenuItem.c_BreakOff.ToString());
            }
        }
        /// <summary>
        /// 设置登录后界面,显示个人信息
        /// </summary>
        /// <param name="userName">用户名</param>
        /// <param name="packageType">套餐类型</param>
        /// <param name="dateTime">到期时间</param>
        public void SetUser(string userName, string packageType, string dateTime)
        {

            lock (o)
            {
                RegEditBase.DelAllSecongReg();
                RegEditBase.SetReg(ContextMenuItem.g_About, "关于", RunPath + name+" " + ContextMenuItem.g_About.ToString());
                RegEditBase.SetReg(ContextMenuItem.c_BreakOff, "断开", RunPath + name+" " + ContextMenuItem.c_BreakOff.ToString());


                //TODO 套餐类型及到期时间修改
                RegEditBase.SetReg(ContextMenuItem.e_MaturityTime, "到期时间：" + dateTime, RunPath + name+" " + ContextMenuItem.e_MaturityTime.ToString());
                RegEditBase.SetReg(ContextMenuItem.d_PackageType, "套餐类型：" + packageType, RunPath + name+" " + ContextMenuItem.d_PackageType.ToString());

                RegEditBase.SetReg(ContextMenuItem.a_UserName, "用户名：" + userName, RunPath + name+" " + ContextMenuItem.a_UserName.ToString());

            }
        }

        /// <summary>
        /// 请等待
        /// </summary>
        public void SetWait()
        {
            lock (o)
            {


                RegEditBase.DelAllSecongReg();
                RegEditBase.SetReg(ContextMenuItem.f_Wait, "请稍候", RunPath + name+" " + ContextMenuItem.f_Wait.ToString());
            }
        }

        /// <summary>
        /// 设置登录前界面
        /// </summary>
        public void SetLogin()
        {

            //未登录
            lock (o)
            {
                RegEditBase.DelAllSecongReg();
                RegEditBase.SetReg(ContextMenuItem.g_About, "关于", RunPath + name+" " + ContextMenuItem.g_About.ToString());
                RegEditBase.SetReg(ContextMenuItem.b_Connect, "连接", RunPath + name+" " + ContextMenuItem.b_Connect.ToString());
            }
        }
    }

}

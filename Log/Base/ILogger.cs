namespace SchoolNetwork.Log.Base
{
    /// <summary>
    /// 日志输出接口
    /// </summary>
    internal interface ILogger
    {
        /// <summary>
        /// 输出错误信息
        /// </summary>
        /// <param name="error">错误</param>
        void LogError(string error);

        /// <summary>
        /// 输出警告信息
        /// </summary>
        /// <param name="warning">警告</param>
        void LogWarning(string warning);

        /// <summary>
        /// 输出消息信息
        /// </summary>
        /// <param name="message">消息</param>
        void LogMessage(string message);
    }
}

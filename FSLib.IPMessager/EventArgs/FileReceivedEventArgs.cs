//-----------------------------------------------------------------------------------------------
namespace FSLib.IPMessager.EventArgs
{
	/// <summary>
	/// 包含收到的文件的数据
	/// </summary>
	public class FileReceivedEventArgs : System.EventArgs
	{
        /// <summary>
        /// 发送来的文件所属主机
        /// </summary>
		public Entity.Host Host { get; private set; }
        /// <summary>
        /// 发送来的消息
        /// </summary>
		public Entity.Message Message { get; private set; }
        /// <summary>
        /// 发送来的文件
        /// </summary>
		public Entity.FileTaskInfo File { get; private set; }

		/// <summary>
		/// 创建 <see cref="FileReceivedEventArgs" /> 的新实例
		/// </summary>
		public FileReceivedEventArgs(Entity.Host host, Entity.Message message, Entity.FileTaskInfo file)
		{
			Host = host;
			Message = message;
			File = file;
		}
	}
}

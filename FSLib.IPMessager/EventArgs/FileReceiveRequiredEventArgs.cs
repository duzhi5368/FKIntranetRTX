//-----------------------------------------------------------------------------------------------
using FSLib.IPMessager.Entity;
//-----------------------------------------------------------------------------------------------
namespace FSLib.IPMessager.EventArgs
{
	/// <summary>
	/// 请求接收文件事件-用文件管理器和TCP线程调度信息
	/// </summary>
	public class FileReceiveRequiredEventArgs : System.EventArgs
    {
		/// <summary>
		/// 需要接收的文件任务信息
		/// </summary>
		public FileTaskInfo Task { get; set; }
		/// <summary>
		/// 单个文件信息
		/// </summary>
		public FileTaskItem Item { get; set; }
		/// <summary>
		/// 是否已经处理
		/// </summary>
		public bool IsHandled { get; set; }

		/// <summary>
		/// 创建一个新的 FileReceiveEventArgs 对象.
		/// </summary>
		public FileReceiveRequiredEventArgs(FileTaskInfo task, FileTaskItem item)
		{
			Task = task;
			Item = item;
			IsHandled = false;
		}
	}
}

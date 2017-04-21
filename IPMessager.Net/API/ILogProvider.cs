//-----------------------------------------------------------------------------------------------
namespace IPMessagerNet.API
{
	/// <summary>
	/// 飞鸽传书.Net日志提供插件接口
	/// </summary>
	public interface ILogProvider
	{
		/// <summary>
		/// 请求显示日志查看器
		/// </summary>
		/// <returns></returns>
		void ShowLogViewer();

		/// <summary>
		/// 请求显示日志配置
		/// </summary>
		void ShowLogConfig();
	}
}

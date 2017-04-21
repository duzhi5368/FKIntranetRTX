//-----------------------------------------------------------------------------------------------
namespace FSLib.IPMessager.Network
{
	/// <summary>
	/// IP被要求验证的类
	/// </summary>
	public class IpValidateRequiredEventArgs : NetworkPackageEventArgs
	{
		/// <summary>
		/// 是否抛弃主机包
		/// </summary>
		public bool IsPackageDroped { get; set; }

		/// <summary>
		/// 创建一个新的 IpValidateRequiredEventArgs 对象.
		/// </summary>
		public IpValidateRequiredEventArgs()
		{
			IsPackageDroped = false;
		}
	}
}

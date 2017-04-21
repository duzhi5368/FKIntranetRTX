using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

namespace FSLib.IPMessager.Services
{
	/// <summary>
	/// ��������״̬
	/// </summary>
	public enum ServiceState : int
	{
		/// <summary>
		/// δ��װ
		/// </summary>
		NotInstalled = 0,
		/// <summary>
		/// ��������
		/// </summary>
		Running = 1,
		/// <summary>
		/// �ѽ���
		/// </summary>
		Disabled = 2,
		/// <summary>
		/// ���ش���
		/// </summary>
		LoadingError = 3,
		/// <summary>
		/// δ��ʼ��
		/// </summary>
		UnInitialized = 5,
		/// <summary>
		/// ��ж��
		/// </summary>
		Unload = 4,
		/// <summary>
		/// �����Ѽ���,����δ��ʼ��
		/// </summary>
		TypeLoaded = 6
	}
}

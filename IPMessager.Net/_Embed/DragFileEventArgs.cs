using System;

namespace IPMessagerNet._Embed
{
	/// <summary>
	/// �ļ��Ϸ��¼�����
	/// </summary>
	public class DragFileEventArgs : EventArgs
	{

		public DragFileEventArgs(string[] files)
		{
			Files = files;
		}

		/// <summary>
		/// �������ļ�
		/// </summary>
		public string[] Files { get; private set; }
	}
}

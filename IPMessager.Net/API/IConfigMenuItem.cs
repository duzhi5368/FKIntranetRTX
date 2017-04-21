//-----------------------------------------------------------------------------------------------
using System.Drawing;
//-----------------------------------------------------------------------------------------------
namespace IPMessagerNet.API
{
	interface IConfigMenuItem
	{
		int Height { get; }

		Image Image { get; }

		string Name { get; }

		ConfigPanelBase UserControl { get; }
	}
}

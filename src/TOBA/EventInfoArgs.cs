using System;

namespace TOBA
{
	public class EventInfoArgs : EventArgs
	{
		public string Message { get; set; }

		public object Data { get; set; }

		/// <summary>
		/// ���� <see cref="EventInfoArgs" /> ����ʵ��
		/// </summary>
		public EventInfoArgs()
		{
			Continue = true;
		}

		/// <summary>
		/// ���� <see cref="EventInfoArgs" /> ����ʵ��
		/// </summary>
		public EventInfoArgs(string message, object data=null)
		{
			Message = message;
			Data = data;
			Continue = true;
		}

		/// <summary>
		/// ��û������Ƿ����
		/// </summary>
		public bool Continue { get; set; }
	}
}
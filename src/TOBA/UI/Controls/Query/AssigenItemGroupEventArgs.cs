namespace TOBA.UI.Controls.Query
{
	using System;

	using TOBA.Query.Entity;

	internal class AssignItemGroupEventArgs : EventArgs
	{
		public QueryResultListViewItem Item { get; private set; }

		public QueryResultItem Train { get; private set; }

		/// <summary>
		/// ���� <see cref="AssignItemGroupEventArgs" />  ����ʵ��(AssigenItemGroupEventArgs)
		/// </summary>
		/// <param name="item"></param>
		/// <param name="train"></param>
		public AssignItemGroupEventArgs(QueryResultListViewItem item, QueryResultItem train)
		{
			Item = item;
			Train = train;
		}


	}
}
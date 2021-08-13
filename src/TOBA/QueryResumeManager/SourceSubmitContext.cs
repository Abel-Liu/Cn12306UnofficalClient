using System;
using System.Collections.Generic;
using TOBA.Entity;

namespace TOBA.QueryResumeManager
{
	internal class SourceSubmitContext
	{
		public List<QueryParam> Queries { get; set; }

		public bool Performed { get; set; }

		public bool UsingSharedContext { get; set; }

		public DateTime? CreateTime { get; set; }

		public bool OperationByAutoResume { get; set; }

		/// <summary>
		/// ��û������Ƿ��ύ�ɹ�
		/// </summary>
		public bool IsSubmitSuccess { get; set; }

		/// <summary>
		/// ���� <see cref="SourceSubmitContext" />  ����ʵ��(SourceSubmitContext)
		/// </summary>
		public SourceSubmitContext()
		{
		}
	}
}
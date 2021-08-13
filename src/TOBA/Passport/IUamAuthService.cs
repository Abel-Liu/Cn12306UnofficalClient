namespace TOBA.Passport
{
	using System;
	using System.Threading.Tasks;

	using WebLib;

	interface IUamAuthService
	{
		Task<(bool? valid, string message, string displayName)> AuthTkAsync(NetClient client, Action<string> stateIndicator);

		/// <summary>
		/// У���Ƿ��Ѿ����ص�¼������ͳһ��֤��¼��
		/// </summary>
		/// <param name="session"></param>
		/// <returns></returns>
		Task<(bool logined, string message)> UamtkStaticAsync(Session session);
	}
}
using System.Collections.Generic;
using WeiboSDK.Contracts;
using WeiboSDK.Response.QQ;

namespace WeiboSDK.Request.QQ
{
    /// <summary>
    /// ����һ��΢������
    /// ��ӦAPI��http://open.t.qq.com/api/t/add
    /// </summary>
    public class QQStatusAddRequest : QQRequestBase, IWeiboRequest<QQStatusPostResponse>
    {
        public QQStatusAddRequest(string content)
        {
            Content = content;
        }

        /// <summary>
        /// ΢������
        /// </summary>
        public string Content { get; private set; }

        /// <summary>
        /// �û�IP �����������û��������������IP��ַ������ᱻ��Ϣ���˲��Ծܾ���
        /// </summary>
        public string ClientIp { get; set; }

        /// <summary>
        /// ����
        /// </summary>
        public string Jing { get; set; }

        /// <summary>
        /// γ��
        /// </summary>
        public string Wei { get; set; }

        #region IWeiboRequest<QQStatusPostResponse> Members

        public string Url
        {
            get { return "http://open.t.qq.com/api/t/add"; }
        }

        public IDictionary<string, string> Parameters
        {
            get
            {
                var dict = new WeiboDictionary
                {
                    {"content", Content},
                    {"clientip", ClientIp},
                    {"jing", Jing},
                    {"wei", Wei}
                };

                return dict;
            }
        }

        #endregion
    }
}
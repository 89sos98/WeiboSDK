using System;
using System.Collections.Generic;
using WeiboSDK.Contracts;
using WeiboSDK.Response.QQ;

namespace WeiboSDK.Request.QQ
{
    /// <summary>
    /// ����һ��΢������
    /// ��ӦAPI��http://open.t.qq.com/api/t/comment
    /// </summary>
    public class QQCommentAddRequest : QQRequestBase, IWeiboRequest<QQStatusPostResponse>
    {
        /// <summary>
        /// ���۸���㣨�Ǹ���㣩΢��ID
        /// </summary>
        public string Reid { get; private set; }

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

        public QQCommentAddRequest(string reid, string content)
        {
            Reid = reid;
            Content = content;
        }

        #region IWeiboRequest<QQStatusesResponse> Members

        public string Url
        {
            get { return "http://open.t.qq.com/api/t/comment"; }
        }

        public IDictionary<string, string> Parameters
        {
            get
            {
                var dict = new WeiboDictionary
                {
                    {"reid", Reid},
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
using System.Collections.Generic;
using WeiboSDK.Contracts;
using WeiboSDK.Response.QQ;

namespace WeiboSDK.Request.QQ
{
    /// <summary>
    /// ����һ����ͼƬ��΢������
    /// ��ӦAPI��http://open.t.qq.com/api/t/add_pic
    /// </summary>
    public class QQStatusAddWithPicRequest : QQRequestBase, IUploadRequest<QQStatusPostResponse>
    {
        public QQStatusAddWithPicRequest(string content, string pic)
        {
            Content = content;
            Pic = pic;
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

        /// <summary>
        /// ͼƬ
        /// </summary>
        public string Pic { get; private set; }

        #region IUploadRequest<QQStatusPostResponse> Members

        public string Url
        {
            get { return "http://open.t.qq.com/api/t/add_pic"; }
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

        /// <summary>
        /// ��ȡ���е�Key-Value��ʽ���ļ���������ֵ䡣���У�
        /// Key: ���������
        /// Value: �ļ�·��
        /// </summary>
        /// <returns>�ļ���������ֵ�</returns>
        public IDictionary<string, string> FileParameters
        {
            get
            {
                var dict = new WeiboDictionary {{"pic", Pic}};

                return dict;
            }
        }

        #endregion
    }
}
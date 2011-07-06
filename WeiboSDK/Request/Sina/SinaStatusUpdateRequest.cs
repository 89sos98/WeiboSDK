using System.Collections.Generic;
using WeiboSDK.Contracts;
using WeiboSDK.Response.Sina;

namespace WeiboSDK.Request.Sina
{
    /// <summary>
    /// ����һ��΢����Ϣ����Ҳ����ͬʱת��ĳ��΢����
    /// ��ӦAPI��http://open.weibo.com/wiki/index.php/Statuses/update
    /// </summary>
    public class SinaStatusUpdateRequest : SinaRequestBase, IWeiboRequest<SinaStatusResponse>
    {
        public SinaStatusUpdateRequest(string status)
        {
            Status = status;
        }

        /// <summary>
        /// Ҫ������΢����Ϣ�ı�����
        /// </summary>
        public string Status { get; private set; }

        /// <summary>
        /// Ҫת����΢����ϢID�� 
        /// </summary>
        public long? InReplyToStatusId { get; set; }

        /// <summary>
        /// γ�ȡ���Ч��Χ��-90.0��+90.0��+��ʾ��γ��
        /// </summary>
        public float? Lat { get; set; }

        /// <summary>
        /// ���ȡ���Ч��Χ��-180.0��+180.0��+��ʾ������
        /// </summary>
        public float? Long { get; set; }

        /// <summary>
        /// Ԫ���ݣ���Ҫ��Ϊ�˷��������Ӧ�ü�¼һЩ�ʺ����Լ�ʹ�õ���Ϣ��
        /// ÿ��΢�����԰���һ�����߶��Ԫ���ݡ�����json�ִ�����ʽ�ύ���ִ����Ȳ�����512���ַ����������ݿ����Զ���
        /// </summary>
        public string Annotations { get; set; }

        #region IWeiboRequest<SinaStatusResponse> Members

        public string Url
        {
            get { return "http://api.t.sina.com.cn/statuses/update."; }
        }

        public IDictionary<string, string> Parameters
        {
            get
            {
                var dict = new WeiboDictionary
                {
                    {"status", Status},
                    {"in_reply_to_status_id", InReplyToStatusId},
                    {"lat", Lat},
                    {"long", Long},
                    {"annotations", Annotations}
                };

                return dict;
            }
        }

        #endregion
    }
}
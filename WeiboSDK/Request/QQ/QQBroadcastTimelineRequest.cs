using System.Collections.Generic;
using WeiboSDK.Contracts;
using WeiboSDK.Response.QQ;

namespace WeiboSDK.Request.QQ
{
    /// <summary>
    /// ��ȡ�ҷ���ʱ��������
    /// ��ӦAPI��http://open.t.qq.com/api/statuses/broadcast_timeline
    /// </summary>
    public class QQBroadcastTimelineRequest : QQRequestBase, IWeiboRequest<QQStatusesResponse>
    {
        /// <summary>
        /// ��ҳ��ʶ��0����һҳ��1�����·�ҳ��2���Ϸ�ҳ��
        /// </summary>
        public int? PageFlag { get; set; }

        /// <summary>
        /// ��ҳ��ʼʱ�䣨��һҳ ʱ��0���������·�ҳ������һ�����󷵻ص����һ����¼ʱ�䣩
        /// </summary>
        public string PageTime { get; set; }

        /// <summary>
        /// ÿ�������¼��������1-100����
        /// </summary>
        public int? ReqNum { get; set; }

        /// <summary>
        /// ��һҳ ʱ��0,�������·�ҳ������һ�����󷵻ص����һ����¼ID����ҳ��
        /// </summary>
        public string LastId { get; set; }

        /// <summary>
        /// ��ȡ����, 0x1 ԭ������ 0x2 ת�� 0x8 �ظ� 0x10 �ջ� 0x20 �ἰ 0x40 ����
        /// ������ȡ���������|��(0x1|0x2) �õ�3��type=3����,�����ʾ��ȡ��������
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// ���ݹ��� �����ʾ�������� 1-���ı� 2-������ 4ͼƬ 8-����Ƶ 0x10-����Ƶ
        /// </summary>
        public string ContentType { get; set; }

        /// <summary>
        /// Ȩ�ޱ�ʶ 1 ��ʾֻ��ʾ�ҷ����
        /// </summary>
        public string AccessLevel { get; set; }

        #region IQQRequest<QQStatusesGetResponse> Members

        public string Url
        {
            get { return "http://open.t.qq.com/api/statuses/broadcast_timeline"; }
        }

        public IDictionary<string, string> Parameters
        {
            get
            {
                var dict = new WeiboDictionary
                {
                    {"pageflag", PageFlag},
                    {"pagetime", PageTime},
                    {"reqnum", ReqNum},
                    {"lastid", LastId},
                    {"type", Type},
                    {"contenttype", ContentType},
                    {"accesslevel", AccessLevel}
                };

                return dict;
            }
        }

        #endregion
    }
}
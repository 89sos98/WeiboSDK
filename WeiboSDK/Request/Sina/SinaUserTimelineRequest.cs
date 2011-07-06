using System.Collections.Generic;
using WeiboSDK.Contracts;
using WeiboSDK.Response.Sina;

namespace WeiboSDK.Request.Sina
{
    /// <summary>
    /// �����û����·����΢����Ϣ�б�����
    /// ��ӦAPI��http://open.weibo.com/wiki/index.php/Statuses/user_timeline
    /// </summary>
    public class SinaUserTimelineRequest : SinaRequestBase, IWeiboRequest<SinaStatusesResponse>
    {
        /// <summary>
        /// �û�ID����Ҫ�����������û�ID��΢���ǳơ�
        /// ��΢���ǳ�Ϊ���ֵ��º��û�ID�������壬�ر��ǵ�΢���ǳƺ��û�IDһ����ʱ�򣬽���ʹ�øò���
        /// </summary>
        public long? UserId { get; set; }

        /// <summary>
        /// ΢���ǳƣ���Ҫ�����������û�UID��΢���ǳƣ�������һ�������������ʱ�򣬽���ʹ�øò���
        /// </summary>
        public string ScreenName { get; set; }

        /// <summary>
        /// ��ָ���˲�������ֻ����ID��since_id�󣨼���since_id����ʱ����ģ���΢����Ϣ��
        /// </summary>
        public long? SinceId { get; set; }

        /// <summary>
        /// ��ָ���˲������򷵻�IDС�ڻ����max_id��΢����Ϣ
        /// </summary>
        public long? MaxId { get; set; }

        /// <summary>
        /// ָ��ÿҳ���صļ�¼������
        /// </summary>
        public int? Count { get; set; }

        /// <summary>
        /// ҳ�롣ע�⣺��෵��200����ҳ���ݡ�
        /// </summary>
        public int? Page { get; set; }

        /// <summary>
        /// �Ƿ���ڵ�ǰӦ������ȡ���ݡ�1Ϊ���Ʊ�Ӧ��΢����0Ϊ�������ơ�
        /// </summary>
        public int? BaseApp { get; set; }

        /// <summary>
        /// ΢�����ͣ�0ȫ����1ԭ����2ͼƬ��3��Ƶ��4����. ����ָ�����͵�΢����Ϣ���ݡ�
        /// </summary>
        public int? Feature { get; set; }

        public string Url
        {
            get { return "http://api.t.sina.com.cn/statuses/user_timeline."; }
        }

        public IDictionary<string, string> Parameters
        {
            get
            {
                var dict = new WeiboDictionary
                {
                    {"user_id", UserId},
                    {"screen_name", ScreenName},
                    {"since_id", SinceId},
                    {"max_id", MaxId},
                    {"count", Count},
                    {"page", Page},
                    {"base_app", BaseApp},
                    {"feature", Feature}
                };

                return dict;
            }
        }
    }
}
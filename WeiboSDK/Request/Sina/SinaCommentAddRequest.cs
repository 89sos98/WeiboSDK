using System.Collections.Generic;
using WeiboSDK.Contracts;
using WeiboSDK.Response.Sina;

namespace WeiboSDK.Request.Sina
{
    /// <summary>
    /// ������������
    /// ��ӦAPI��http://open.weibo.com/wiki/index.php/Statuses/comment
    /// </summary>
    public class SinaCommentAddRequest : SinaRequestBase, IWeiboRequest<SinaCommentResponse>
    {
        /// <summary>
        /// Ҫ���۵�΢����ϢID
        /// </summary>
        readonly long _id;

        /// <summary>
        /// �������ݡ�������URLEncode,��Ϣ���ݲ�����140�����֡�
        /// </summary>
        readonly string _comment;

        /// <summary>
        /// Ҫ�ظ�������ID
        /// </summary>
        public long? Cid { get; set; }

        /// <summary>
        /// 1���ظ��в��Զ����롰�ظ�@�û�������0���ظ����Զ����롰�ظ�@�û�����.Ĭ��Ϊ0.
        /// </summary>
        public int? WithoutMention { get; set; }

        /// <summary>
        /// ������һ��ת��΢��ʱ���Ƿ����۸�ԭ΢����0:�����۸�ԭ΢����1�����۸�ԭ΢����Ĭ��0.
        /// </summary>
        public int? CommentOri { get; set; }

        public SinaCommentAddRequest(long id, string comment)
        {
            _id = id;
            _comment = comment;
        }

        public string Url
        {
            get { return "http://api.t.sina.com.cn/statuses/comment."; }
        }

        public IDictionary<string, string> Parameters
        {
            get
            {
                var dict = new WeiboDictionary
                {
                    {"id", _id},
                    {"comment", _comment},
                    {"cid", Cid},
                    {"without_mention", WithoutMention},
                    {"comment_ori", CommentOri}
                };

                return dict;
            }
        }
    }
}
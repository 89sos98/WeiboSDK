using System.Collections.Generic;
using WeiboSDK.Contracts;
using WeiboSDK.Response.Sina;

namespace WeiboSDK.Request.Sina
{
    /// <summary>
    /// ����ͼƬ΢����Ϣ����
    /// ��ӦAPI��http://open.weibo.com/wiki/index.php/Statuses/upload
    /// </summary>
    public class SinaStatusUploadRequest : SinaRequestBase, IUploadRequest<SinaStatusResponse>
    {
        public SinaStatusUploadRequest(string status, string pic)
        {
            Status = status;
            Pic = pic;
        }

        /// <summary>
        /// Ҫ������΢����Ϣ�ı�����
        /// </summary>
        public string Status { get; private set; }

        /// <summary>
        /// Ҫ�ϴ���ͼƬ����֧��JPEG,GIF,PNGͼƬ,Ϊ�շ���400����Ŀǰ�ϴ�ͼƬ��С����ΪС��5M��
        /// </summary>
        public string Pic { get; private set; }

        /// <summary>
        /// γ�ȡ���Ч��Χ��-90.0��+90.0��+��ʾ��γ��
        /// </summary>
        public float? Lat { get; set; }

        /// <summary>
        /// ���ȡ���Ч��Χ��-180.0��+180.0��+��ʾ������
        /// </summary>
        public float? Long { get; set; }

        #region IUploadRequest<SinaStatusResponse> Members

        public string Url
        {
            get { return "http://api.t.sina.com.cn/statuses/upload."; }
        }

        public IDictionary<string, string> Parameters
        {
            get
            {
                var dict = new WeiboDictionary {{"status", Status}, {"lat", Lat}, {"long", Long}};
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
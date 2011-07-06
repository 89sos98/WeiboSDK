using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using WeiboSDK.Contracts;

namespace WeiboSDK.Response.QQ
{
    /// <summary>
    /// �й�΢�������ύ����Ӧ
    /// ��ע������΢��Ҳ��ʹ�ô���Ӧ
    /// </summary>
    public class QQStatusPostResponse : QQResponse, IWeiboResponse
    {
        
        public string Id { get; set; }

        public string Timestamp { get; set; }

        #region IWeiboResponse Members

        public void ConvertFrom(string json)
        {
            var jo = JsonConvert.DeserializeObject<JObject>(json);

            ConvertFrom(jo);

            Id = jo["data"]["id"].ToString();
            Timestamp = jo["data"]["time"].ToString();
        }

        #endregion
    }
}
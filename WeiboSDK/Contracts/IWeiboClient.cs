#region using

using System.Collections.Generic;
using WeiboSDK.Entities;
using WeiboSDK.Enums;

#endregion

namespace WeiboSDK.Contracts
{
    public interface IWeiboClient
    {
        #region Statuses

        /// <summary>
        ///     ��ȡ���¸��µ�20������΢����Ϣ
        /// </summary>
        /// <returns></returns>
        IList<Status> GetPublicWeibos();

        /// <summary>
        ///     ��ȡ���¸��µ�N������΢����Ϣ
        ///     N���Ϊ200
        /// </summary>
        /// <param name="count">ϣ�����ص�΢������</param>
        /// <returns></returns>
        IList<Status> GetPublicWeibos(int count);

        /// <summary>
        /// ��ȡ��ǰ��¼�û���������ע�û�������΢����Ϣ
        /// </summary>
        /// <param name="count">ָ��Ҫ���صļ�¼������Ĭ��ֵ20�����ֵ200</param>
        /// <param name="page">ָ�����ؽ����ҳ�룬Ĭ��ֵΪ1</param>
        /// <param name="sinceId">��ָ���˲�������ֻ����ID��since_id���΢����Ϣ</param>
        /// <param name="maxId">��ָ���˲������򷵻�IDС�ڻ����max_id��΢����Ϣ</param>
        /// <param name="feature">΢�����ͣ�0ȫ����1ԭ����2ͼƬ��3��Ƶ��4����. ����ָ�����͵�΢����Ϣ���ݡ�</param>
        /// <returns></returns>
        IList<Status> GetFriendsWeibos(int count, int page, long? sinceId, long? maxId, Feature feature);

        #endregion

        /// <summary>
        ///     ��ȡָ���û�������΢���б�
        /// </summary>
        /// <param name = "screenName"></param>
        /// <returns></returns>
        IList<Status> GetUserWeibos(string screenName);

        /// <summary>
        ///     ��ָ��΢����������
        /// </summary>
        /// <param name = "id">΢��Id</param>
        /// <param name = "cid"></param>
        /// <param name = "comment">��������</param>
        /// <returns></returns>
        Comment Comment(string id, string cid, string comment);

        /// <summary>
        ///     ��ȡ�ҷ���������
        /// </summary>
        /// <returns></returns>
        IList<Comment> GetMyComments();

        /// <summary>
        ///     ɾ��ָ��Id������
        /// </summary>
        /// <param name = "id"></param>
        /// <returns></returns>
        Comment DestoryComment(string id);

        /// <summary>
        ///     ��ȡ@�ҵ�΢���б�
        /// </summary>
        /// <returns></returns>
        IList<Status> GetMyMentions(string sinceId, string page, string count);

        /// <summary>
        ///     ɾ��ָ��Id��΢��
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Status DestoryStatus(string id);

        /// <summary>
        ///     ��֤��ǰ�û�����Ƿ�Ϸ�
        /// </summary>
        /// <returns></returns>
        User VerifyCredentials();

        /// <summary>
        ///     ����΢��(���������) 
        /// </summary>
        /// <param name="q">�ؼ���</param>
        /// <param name="filterOri">�Ƿ�ԭ�� (0Ϊȫ����5Ϊԭ����4Ϊת����Ĭ��0)</param>
        /// <param name="filterPic">�Ƿ�ͼ (0Ϊȫ����1Ϊ��ͼ��2Ϊ����ͼ)</param>
        /// <param name="fuid">΢������UID</param>
        /// <param name="province">ʡ��ID</param>
        /// <param name="city">����ID</param>
        /// <param name="startTime">��ʼʱ��(unixʱ���)</param>
        /// <param name="endTime">��ֹʱ��(unixʱ���)</param>
        /// <param name="page">ҳ��(��1��ʼ, Ĭ��1)</param>
        /// <param name="count">ÿҳ���ص�΢������Ĭ�Ϸ���10�������200</param>
        /// <returns></returns>
        IList<Status> Search(string q, string filterOri, string filterPic, string fuid, string province, string city,
                             string startTime, string endTime, string page, string count);


        /// <summary>
        /// ��ȡ����΢����Web����·��
        /// </summary>
        /// <param name="id">΢��Id</param>
        /// <param name="userid">�û�Id</param>
        /// <returns></returns>
        string GetWeiboUrl(string id, string userid);

        /// <summary>
        /// �����û���ע�б�����������΢������
        /// </summary>
        /// <returns></returns>
        IList<User> GetMyFriends(string screenName);

        /// <summary>
        /// ����һ��΢����Ϣ
        /// </summary>
        /// <param name="status">΢��</param>
        /// <returns></returns>
        Status UpdateStatus(string status);

        /// <summary>
        /// ����ͼƬ΢����Ϣ
        /// </summary>
        /// <param name="status">΢��</param>
        /// <param name="pic">ͼƬ·��</param>
        /// <returns></returns>
        Status UploadStatus(string status, string pic);

        /// <summary>
        /// ��ȡ��ǰ��¼�û���������ע�û�������΢����Ϣ
        /// </summary>
        /// <returns></returns>
        IList<Status> GetFriendsTimeline(long sinceId);

        /// <summary>
        /// ����΢���ǳƻ�ȡ�����б�
        /// </summary>
        /// <param name="screenName">΢���ǳ�</param>
        /// <returns></returns>
        IList<User> GetFriends(string screenName);
    }
}
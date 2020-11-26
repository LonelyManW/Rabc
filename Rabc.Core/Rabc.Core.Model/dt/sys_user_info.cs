using SqlSugar;
using System;
using System.Collections.Generic;
using System.Text;

namespace Rabc.Core.Model
{
    /// <summary>
    /// 系统用户信息
    /// </summary>
    public class sys_user_info
    {
        /// <summary>
        /// 用户主键
        /// </summary>
        [SugarColumn(IsNullable = false, IsPrimaryKey = true)]
        public int user_id { set; get; }

        /// <summary>
        /// 登录账号
        /// </summary>
        public string login_name { set; get; }

        /// <summary>
        /// 登录密码
        /// </summary>
        public string login_pwd { set; get; }

        /// <summary>
        /// 真实姓名
        /// </summary>
        public string real_name { set; get; }

        /// <summary>
        /// 状态
        /// </summary>
        public int status { set; get; }

        /// <summary>
        /// 备注
        /// </summary>
        public string remark { set; get; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime create_time { set; get; }

        /// <summary>
        /// 修改时间
        /// </summary>
        public DateTime update_time { set; get; }

        /// <summary>
        /// 最后登录时间
        /// </summary>
        public DateTime last_login_time { set; get; }

        /// <summary>
        /// 错误次数
        /// </summary>
        public int error_count { set; get; }

        /// <summary>
        /// 性别
        /// </summary>
        public string sex { set; get; }

        /// <summary>
        /// 年龄
        /// </summary>
        public int age { set; get; }

        /// <summary>
        /// 生日
        /// </summary>
        public DateTime birth { set; get; }

        /// <summary>
        /// 地址
        /// </summary>
        public string address { set; get; }

        /// <summary>
        /// 是否删除
        /// </summary>
        public bool is_delete { set; get; }
    }
}

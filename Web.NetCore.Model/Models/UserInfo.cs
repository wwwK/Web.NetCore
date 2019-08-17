using SqlSugar;
using System;
using System.Collections.Generic;
using System.Text;

namespace Web.NetCore.Model.Models
{

    /// <summary>
    /// 用户表
    /// </summary>
    public class UserInfo
    {
        private System.Int32 _USER_ID;
        /// <summary>
        /// 用户ID
        /// </summary>
        [SugarColumn(IsPrimaryKey = true, IsIdentity = true)]
        public System.Int32 USER_ID { get { return this._USER_ID; } set { this._USER_ID = value; } }

        private System.String _USER_NAME;
        /// <summary>
        /// 用户名称
        /// </summary>
        public System.String USER_NAME { get { return this._USER_NAME; } set { this._USER_NAME = value?.Trim(); } }

        private System.String _USER_LOGIN_NAME;
        /// <summary>
        /// 用户登录名
        /// </summary>
        public System.String USER_LOGIN_NAME { get { return this._USER_LOGIN_NAME; } set { this._USER_LOGIN_NAME = value?.Trim(); } }

        private System.String _USER_EN_NAME;
        /// <summary>
        /// 用户英文名
        /// </summary>
        public System.String USER_EN_NAME { get { return this._USER_EN_NAME; } set { this._USER_EN_NAME = value?.Trim(); } }

        private System.String _USER_PASSWORD;
        /// <summary>
        /// 用户密码
        /// </summary>
        public System.String USER_PASSWORD { get { return this._USER_PASSWORD; } set { this._USER_PASSWORD = value?.Trim(); } }

        private System.String _USER_QQ;
        /// <summary>
        /// 用户QQ
        /// </summary>
        public System.String USER_QQ { get { return this._USER_QQ; } set { this._USER_QQ = value?.Trim(); } }

        private System.String _USER_WECHAT;
        /// <summary>
        /// 用户微信
        /// </summary>
        public System.String USER_WECHAT { get { return this._USER_WECHAT; } set { this._USER_WECHAT = value?.Trim(); } }

        private System.Boolean? _USER_SEX;
        /// <summary>
        /// 用户性别
        /// </summary>
        public System.Boolean? USER_SEX { get { return this._USER_SEX; } set { this._USER_SEX = value ?? default(System.Boolean); } }
    }

}

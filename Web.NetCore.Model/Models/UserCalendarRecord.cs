using SqlSugar;
using System;
using System.Collections.Generic;
using System.Text;

namespace Web.NetCore.Model.Models
{
    /// <summary>
    /// 用户日程
    /// </summary>
    public class UserCalendarRecord
    {
        private System.Int32? _UCR_RECORD_ID;
        /// <summary>
        /// 日程id
        /// </summary>
        public System.Int32? UCR_RECORD_ID { get { return this._UCR_RECORD_ID; } set { this._UCR_RECORD_ID = value ?? default(System.Int32); } }

        private System.Int32? _UCR_USER_ID1;
        /// <summary>
        /// 用户ID
        /// </summary>
        public System.Int32? UCR_USER_ID1 { get { return this._UCR_USER_ID1; } set { this._UCR_USER_ID1 = value ?? default(System.Int32); } }

        private System.Int32 _UCR_ID;
        /// <summary>
        /// 用户日程id
        /// </summary>
        [SugarColumn(IsPrimaryKey = true, IsIdentity = true)]
        public System.Int32 UCR_ID { get { return this._UCR_ID; } set { this._UCR_ID = value; } }
    }

}

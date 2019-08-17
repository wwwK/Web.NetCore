using SqlSugar;
using System;
using System.Collections.Generic;
using System.Text;

namespace Web.NetCore.Model.Models
{
    /// <summary>
    /// 生理期记录
    /// </summary>
    public class PeriodsRecord
    {
        private System.Int32 _PERIODS_ID;
        /// <summary>
        /// 生理期ID
        /// </summary>
        [SugarColumn(IsPrimaryKey = true, IsIdentity = true)]
        public System.Int32 PERIODS_ID { get { return this._PERIODS_ID; } set { this._PERIODS_ID = value; } }

        private System.Int32? _PERIODS_USER_ID;
        /// <summary>
        /// 用户ID
        /// </summary>
        public System.Int32? PERIODS_USER_ID { get { return this._PERIODS_USER_ID; } set { this._PERIODS_USER_ID = value ?? default(System.Int32); } }

        private System.DateTime? _RERIODS_START_TIME;
        /// <summary>
        /// 生理期开始时间
        /// </summary>
        public System.DateTime? RERIODS_START_TIME { get { return this._RERIODS_START_TIME; } set { this._RERIODS_START_TIME = value ?? default(System.DateTime); } }

        private System.DateTime? _RERIODS_END_TIME;
        /// <summary>
        /// 生理期结束时间
        /// </summary>
        public System.DateTime? RERIODS_END_TIME { get { return this._RERIODS_END_TIME; } set { this._RERIODS_END_TIME = value ?? default(System.DateTime); } }
    }
}

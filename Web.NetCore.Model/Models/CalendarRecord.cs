using System;
using System.Collections.Generic;
using System.Text;
using SqlSugar;

namespace Web.NetCore.Model.Models
{
    /// <summary>
    /// 日程记录
    /// </summary>
    public class CalendarRecord
    {
        private System.Int32 _RECORD_ID;
        /// <summary>
        /// 日程id
        /// </summary>
        [SugarColumn(IsPrimaryKey = true, IsIdentity = true)]
        public System.Int32 RECORD_ID { get { return this._RECORD_ID; } set { this._RECORD_ID = value; } }

        private System.DateTime? _RECORD_DATE;
        /// <summary>
        /// 日期
        /// </summary>
        public System.DateTime? RECORD_DATE { get { return this._RECORD_DATE; } set { this._RECORD_DATE = value ?? default(System.DateTime); } }

        private System.String _RECORD_MATTER;
        /// <summary>
        /// 待办事项
        /// </summary>
        public System.String RECORD_MATTER { get { return this._RECORD_MATTER; } set { this._RECORD_MATTER = value?.Trim(); } }

        private System.String _RECORD_ADDRESS;
        /// <summary>
        /// 目的地
        /// </summary>
        public System.String RECORD_ADDRESS { get { return this._RECORD_ADDRESS; } set { this._RECORD_ADDRESS = value?.Trim(); } }

        private System.DateTime? _RECORD_START_DATE;
        /// <summary>
        /// 起始日期
        /// </summary>
        public System.DateTime? RECORD_START_DATE { get { return this._RECORD_START_DATE; } set { this._RECORD_START_DATE = value ?? default(System.DateTime); } }

        private System.DateTime? _RECORD_END_DATE;
        /// <summary>
        /// 结束日期
        /// </summary>
        public System.DateTime? RECORD_END_DATE { get { return this._RECORD_END_DATE; } set { this._RECORD_END_DATE = value ?? default(System.DateTime); } }

        private System.Boolean? _RECORD_IS_LOOP;
        /// <summary>
        /// 循环日程
        /// </summary>
        public System.Boolean? RECORD_IS_LOOP { get { return this._RECORD_IS_LOOP; } set { this._RECORD_IS_LOOP = value ?? default(System.Boolean); } }

        private System.String _RECORD_CYCLE;
        /// <summary>
        /// 循环周期
        /// </summary>
        public System.String RECORD_CYCLE { get { return this._RECORD_CYCLE; } set { this._RECORD_CYCLE = value?.Trim(); } }
    }
}

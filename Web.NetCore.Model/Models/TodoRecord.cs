using SqlSugar;
using System;
using System.Collections.Generic;
using System.Text;

namespace Web.NetCore.Model.Models
{
    /// <summary>
    /// 待办事项
    /// </summary>
    public class TodoRecord
    {
        private System.Int32 _TODO_ID;
        /// <summary>
        /// 待办id
        /// </summary>
        [SugarColumn(IsPrimaryKey = true, IsIdentity = true)]
        public System.Int32 TODO_ID { get { return this._TODO_ID; } set { this._TODO_ID = value; } }

        private System.String _TODO_ITEM;
        /// <summary>
        /// 待办事项
        /// </summary>
        public System.String TODO_ITEM { get { return this._TODO_ITEM; } set { this._TODO_ITEM = value?.Trim(); } }

        private System.DateTime? _TODO_START_DATE;
        /// <summary>
        /// 起始日期
        /// </summary>
        public System.DateTime? TODO_START_DATE { get { return this._TODO_START_DATE; } set { this._TODO_START_DATE = value ?? default(System.DateTime); } }

        private System.DateTime? _TODO_END_DATE;
        /// <summary>
        /// 结束日期
        /// </summary>
        public System.DateTime? TODO_END_DATE { get { return this._TODO_END_DATE; } set { this._TODO_END_DATE = value ?? default(System.DateTime); } }

        private System.DateTime? _TODO_DATE;
        /// <summary>
        /// 日期
        /// </summary>
        public System.DateTime? TODO_DATE { get { return this._TODO_DATE; } set { this._TODO_DATE = value ?? default(System.DateTime); } }
    }
}

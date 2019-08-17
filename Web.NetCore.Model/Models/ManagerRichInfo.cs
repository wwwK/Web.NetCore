using SqlSugar;
using System;
using System.Collections.Generic;
using System.Text;

namespace Web.NetCore.Model.Models
{

    /// <summary>
    /// 理财助手
    /// </summary>
    public class ManagerRichInfo
    {
        private System.Int32 _RICH_ID1;
        /// <summary>
        /// 理财id
        /// </summary>
        [SugarColumn(IsPrimaryKey = true, IsIdentity = true)]
        public System.Int32 RICH_ID1 { get { return this._RICH_ID1; } set { this._RICH_ID1 = value; } }

        private System.DateTime? _RICH_DATE;
        /// <summary>
        /// 日期
        /// </summary>
        public System.DateTime? RICH_DATE { get { return this._RICH_DATE; } set { this._RICH_DATE = value ?? default(System.DateTime); } }

        private System.Decimal? _RICH_GOLD_PRICE;
        /// <summary>
        /// 黄金价格
        /// </summary>
        public System.Decimal? RICH_GOLD_PRICE { get { return this._RICH_GOLD_PRICE; } set { this._RICH_GOLD_PRICE = value ?? default(System.Decimal); } }

        private System.Decimal? _RICH_RISE;
        /// <summary>
        /// 相较涨幅
        /// </summary>
        public System.Decimal? RICH_RISE { get { return this._RICH_RISE; } set { this._RICH_RISE = value ?? default(System.Decimal); } }
    }
}


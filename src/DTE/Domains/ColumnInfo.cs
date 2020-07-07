﻿using DTE.CORE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTE.Domains
{
    public class ColumnInfo
    {
     
        public ColumnInfo(DataTable dt, DataColumn column, SupportedConnectionsTypes connectionType)
        {
            this.ColumnName = column.ColumnName;
            this.Type = column.DataType;
            this.Nullable = column.AllowDBNull;
            this.Extra = column.AutoIncrement;
            this.Def = column.DefaultValue.ToString();
            this.Key = dt.PrimaryKey.Select(x => x.ColumnName).ToList().Contains(column.ColumnName);
        }
        public bool Key { get; set; }
        public string ColumnName { get; set; }
        public Type Type { get; set; }
        public bool Nullable { get; set; }
        public bool Extra { get; set; }
        public string Def { get; set; }

    }
}

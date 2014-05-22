﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Restful.Data.SqlServer
{
    public class SqlServerSession : ISession
    {
        private SqlServerSessionProvider provider;

        public SqlServerSession( string connectionStr )
        {
            this.provider = new SqlServerSessionProvider( connectionStr );
        }

        public ISessionProvider Provider
        {
            get { return this.provider; }
        }

        public void Dispose()
        {
            this.provider.Dispose();
        }
    }
}

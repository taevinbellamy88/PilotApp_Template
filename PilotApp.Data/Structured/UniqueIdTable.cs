﻿using Microsoft.SqlServer.Server;
using System.Data;

namespace PilotApp.PilotApp.Data.Structured
{
    public class UniqueIdTable : IEnumerable<SqlDataRecord>
    {
        private IEnumerable<Guid> _items;

        public UniqueIdTable(IEnumerable<Guid> items)
        {
            _items = items;
        }

        private static SqlDataRecord GetRecord()
        {
            return new SqlDataRecord(
                    new SqlMetaData[] { new SqlMetaData("Data", SqlDbType.UniqueIdentifier) }
               );
        }

        public IEnumerator<SqlDataRecord> GetEnumerator()
        {
            if (_items != null)
            {
                foreach (Guid item in _items)
                {
                    var rec = GetRecord();

                    rec.SetGuid(0, item);

                    yield return rec;
                }
            }

            yield break;
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
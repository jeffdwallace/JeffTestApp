using JeffTestApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JeffTestApp.Repository
{
    public interface IGetGridRepository
    {
        List<GridViewItem> GetGridData();
    }
    public class GetGridRepository : BaseRepository, IGetGridRepository
    {
        public List<GridViewItem> GetGridData()
        {
            var sql = "select * from SalesOrder";

            return Query<GridViewItem>(sql).ToList();
        }
    }
}

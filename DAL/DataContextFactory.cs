using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calendar.DAL
{
    /// <summary>
    /// Factory để tạo DataContext ngắn hạn (per-operation).
    /// Tránh cache stale từ static DataContext chia sẻ.
    /// </summary>
    public static class DataContextFactory
    {
        public static DataClasses1DataContext CreateContext()
        {
            return new DataClasses1DataContext();
        }
    }
}

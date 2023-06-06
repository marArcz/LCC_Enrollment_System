using LCC_ENROLLMENT_SYSTEM.Data;
using LCC_ENROLLMENT_SYSTEM.Models;
using MySqlX.XDevAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace LCC_ENROLLMENT_SYSTEM
{
    internal class TablePaginator<TbModel>
    {
        private enum FetchDirection
        {
            forward,
            backward,
        }
        private int numOfRowsToDisplay = 10;
        private int lastId = 0;
        private FetchDirection dir = FetchDirection.forward;

        public TablePaginator()
        {
            List<TbModel> rows = new();
            AppDbContext db = new();
            
        }
    }
}

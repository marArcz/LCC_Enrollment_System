using LCC_ENROLLMENT_SYSTEM.Data;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LCC_ENROLLMENT_SYSTEM.Models
{
    public class PaginationModel
    {
        private readonly AppDbContext _dbContext;
        public int Count { get; set; } = 0;
        public int numOfRowsToDisplay { get; set; } = 10;
        public int lastId { get; set; } = 0;



        public PaginationModel()
        {
            _dbContext = new();
        }


    }
}

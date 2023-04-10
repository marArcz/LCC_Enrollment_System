using LCC_ENROLLMENT_SYSTEM.Data;
using LCC_ENROLLMENT_SYSTEM.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LCC_ENROLLMENT_SYSTEM
{
    internal class EnrollmentPaginator
    {
        public enum FetchDirection
        {
            forward,
            backward,
        }
        private int lastId = 0;
        private int pageSize = 10;
        private bool hasNext = false;
        private bool hasPrev = false;
        private FetchDirection fetchDirection1 = FetchDirection.forward;
        private List<Enrollment> enrollments;

        public int LastId { get => lastId; set => lastId = value; }
        public int PageSize { get => pageSize; set => pageSize = value; }
        public bool HasNext { get => hasNext; set => hasNext = value; }
        public bool HasPrev { get => hasPrev; set => hasPrev = value; }
        internal FetchDirection FetchDirection1 { get => fetchDirection1; set => fetchDirection1 = value; }
        internal List<Enrollment> Enrollments { get => enrollments; set => enrollments = value; }

        public EnrollmentPaginator(Type type) {
            Enrollments = new List<Enrollment>();

        }

        public List<Enrollment> Fetch(bool movePagination = false)
        {
            AppDbContext db = new();

            if(FetchDirection1 == FetchDirection.forward)
            {
                if (movePagination && Enrollments.Any())
                {
                    Enrollments = Enrollments.OrderBy(s => s.id).ToList();
                    LastId = Enrollments.Last().id;
                }
            }

            return Enrollments;
        }
    }
}

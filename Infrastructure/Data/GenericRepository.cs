using System;

namespace Infrastructure.Data
{
    public class GenericRepository
    {
        private FlashCatStorage _context;

        public GenericRepository(FlashCatStorage context)
        {
            _context = context;
        }
    }
}
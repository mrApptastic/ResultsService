using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using PersonAPI.Data;
using PersonAPI.Models;
using AutoMapper;

namespace PersonAPI.Managers
{
	public interface IPersonManager {
        // Task<ICollection<VibrationNumberViewModel>> GetAllVibrations();
	}

    public class PersonManager: IPersonManager
    {
        private readonly ILogger<PersonManager> _logger;
        private readonly IMapper _mapper;
        private readonly PersonDbContext _context;
        
        public PersonManager(ILogger<PersonManager> logger, IMapper mapper, PersonDbContext context)
        {
            _logger = logger;
            _mapper = mapper;
            _context = context;
        }

        // public async Task<ICollection<VibrationNumberViewModel>> GetAllVibrations()
        // {
        //     var vibrationList = await _context.NameVibrationNumbers.OrderBy(x => x.Vibration).ThenBy(x => x.Destiny).ToListAsync();
            
        //     return _mapper.Map<ICollection<VibrationNumber>, ICollection<VibrationNumberViewModel>>(vibrationList);
        // }
    }
}

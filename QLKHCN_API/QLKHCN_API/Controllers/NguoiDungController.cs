using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using QLKHCN_API.Data;
using System.Collections.Generic;
using System.Threading.Tasks;
using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace QLKHCN_API.Controllers
{
    [Route("api/[controller]/")]
    [ApiController]
    public class NguoiDungController : ControllerBase
    {
        private readonly MyDbContext _context;

        public NguoiDungController(MyDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        [Route("Get-user")]
        public async Task<ActionResult<IEnumerable<NguoiDung>>> Get_user(string input)
        {
            try
            {
                var result = await _context.NguoiDung.Where(a => a.IDUser.ToUpper().Contains(input.ToUpper()) || a.HoTen.ToUpper().Contains(input.ToUpper()) ||  a.DonViCongTac.ToUpper().Contains(input.ToUpper())).Take(5).ToListAsync();
                if (result.Count > 0)
                {
                    return result;
                }
                return NotFound();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
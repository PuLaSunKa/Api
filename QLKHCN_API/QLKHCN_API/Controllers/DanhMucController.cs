using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using QLKHCN_API.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QLKHCN_API.Controllers
{
    [Route("api/[controller]/")]
    [ApiController]
    public class DanhMucController : ControllerBase
    {
        private readonly MyDbContext _context;

        public DanhMucController(MyDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        [Route("Get-issn")]
        public async Task<ActionResult<IEnumerable<DanhMuc>>> Get_issn(string issn)
        {
            try
            {
                var result = await _context.DanhMuc.Where(a => a.issn == issn).ToListAsync();
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

        [HttpGet]
        [Route("Get-eissn")]
        public async Task<ActionResult<IEnumerable<DanhMuc>>> Get_eissn(string eissn)
        {
            try
            {
                var result = await _context.DanhMuc.Where(a => a.eissn == eissn).ToListAsync();
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

        [HttpGet]
        [Route("Get-all")]
        public async Task<ActionResult<IEnumerable<DanhMuc>>> GetAll()
        {
            try
            {
                return Ok(await _context.DanhMuc.ToListAsync());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("search")]
        public async Task<ActionResult<IEnumerable<DanhMuc>>> Search(string key)
        {
            try
            {
                var result = await _context.DanhMuc.Where(a => a.issn == key || a.eissn == key || a.journal_name.Contains(key)).ToListAsync();
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
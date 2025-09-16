using CredentialsAPI.Data;
using CredentialsAPI.Models.Domains;
using CredentialsAPI.Models.Dtos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client.Platforms.Features.DesktopOs.Kerberos;
using System;
using System.Net.NetworkInformation;
using static System.Collections.Specialized.BitVector32;


namespace CredentialsAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CredentialsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public CredentialsController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet("all")]
        public async Task<ActionResult<List<Models.Domains.Credential>>> GetAll()
        {
            List<CredentialDto> result = new List<CredentialDto>();
            var credentials = await _context.Credentials.OrderBy(n => n.Name).ToListAsync();

            if (credentials == null)
            {
                return NotFound();
            }

            foreach (var credential in credentials)
            {
                CredentialDto cred = new CredentialDto
                {
                    Id = credential.Id,
                    Name = credential.Name,
                    Description = credential.Description,
                    Profile = credential.Profile,
                    Subject_ID = credential.Subject_ID,
                    Nickname = credential.Nickname,
                    Area = credential.Area,
                    Section = credential.Section,
                    Username = credential.Username,
                    Password = credential.Password,
                    Email = credential.Email,
                    Url = credential.Url,
                    Operativity = credential.Operativity,
                    User_Admin = credential.User_Admin,
                    Password_First = credential.Password_First,
                    Password_Admin = credential.Password_Admin,
                    Password_3D_Secure = credential.Password_3D_Secure,
                    Password_Dispositiva = credential.Password_Dispositiva,
                    Password_History = credential.Password_History,
                    Sim_Serial = credential.Sim_Serial,
                    Sim_Operator = credential.Sim_Operator,
                    SmartPhone_Model = credential.SmartPhone_Model,
                    SmartPhone_Serial = credential.SmartPhone_Serial,
                    SmartPhone_IMEI = credential.SmartPhone_IMEI,
                    SmartPhone_Supplier = credential.SmartPhone_Supplier,
                    Numero_Cliente = credential.Numero_Cliente,
                    Iban = credential.Iban,
                    Numero_Carta = credential.Numero_Carta,
                    Data_Scadenza = credential.Data_Scadenza,
                    Pin_App = credential.Pin_App,
                    Pin_Carta = credential.Pin_Carta,
                    Pin = credential.Pin,
                    Puk = credential.Puk,
                    Codice_Dispositivo = credential.Codice_Dispositivo,
                    Codice_Sicurezza = credential.Codice_Sicurezza,
                    Frase_Identificativa = credential.Frase_Identificativa,
                    Machine_IP = credential.Machine_IP,
                    Machine_Name = credential.Machine_Name,
                    Machine_Type = credential.Machine_Type,
                    Note = credential.Note,
                    Expired_Date = credential.Expired_Date,
                    Expired = credential.Expired,
                    Active = credential.Active,
                    Modified = credential.Modified,
                    Created = credential.Created
                };
                result.Add(cred);
            }

            return Ok(result);
        }

        // GET: api/Credentials
        [HttpGet]
        public async Task<ActionResult<PaginatedResult<CredentialDto>>> GetCredentials([FromQuery] CredentialFilterDto filter)
        {
            IQueryable<Models.Domains.Credential> query = _context.Credentials;

            // Filtering
            if (!string.IsNullOrWhiteSpace(filter.SearchTerm))
            {
                var searchTerm = filter.SearchTerm.ToLower();
                query = query.Where(c =>
                    c.Name!.ToLower().Contains(searchTerm) ||
                    c.Description!.ToLower().Contains(searchTerm) ||
                    c.Username!.ToLower().Contains(searchTerm) ||
                    c.Email!.ToLower().Contains(searchTerm) ||
                    c.Url!.ToLower().Contains(searchTerm));
            }

            if (filter.Active.HasValue)
            {
                query = query.Where(c => c.Active == filter.Active.Value);
            }

            if (filter.Expired.HasValue)
            {
                query = query.Where(c => c.Expired == filter.Expired.Value);
            }

            // Get total count before pagination
            var totalCount = await query.CountAsync();

            // Sorting
            query = filter.SortAscending
                ? filter.SortField?.ToLower() switch
                {
                    "name" => query.OrderBy(c => c.Name),
                    "username" => query.OrderBy(c => c.Username),
                    "email" => query.OrderBy(c => c.Email),
                    "expired" => query.OrderBy(c => c.Expired),
                    "active" => query.OrderBy(c => c.Active),
                    "modified" => query.OrderBy(c => c.Modified),
                    "created" => query.OrderBy(c => c.Created),
                    _ => query.OrderBy(c => c.Name)
                }
                : filter.SortField?.ToLower() switch
                {
                    "name" => query.OrderByDescending(c => c.Name),
                    "username" => query.OrderByDescending(c => c.Username),
                    "email" => query.OrderByDescending(c => c.Email),
                    "expired" => query.OrderByDescending(c => c.Expired),
                    "active" => query.OrderByDescending(c => c.Active),
                    "modified" => query.OrderByDescending(c => c.Modified),
                    "created" => query.OrderByDescending(c => c.Created),
                    _ => query.OrderByDescending(c => c.Name)
                };

            // Pagination
            var items = await query
                .Skip((filter.PageIndex - 1) * filter.PageSize)
                .Take(filter.PageSize)
                .Select(c => new CredentialDto
                {
                    Id = c.Id,
                    Name = c.Name,
                    Description = c.Description,
                    Profile = c.Profile,
                    Subject_ID = c.Subject_ID,
                    Nickname = c.Nickname,
                    Area = c.Area,
                    Section = c.Section,
                    Username = c.Username,
                    Password = c.Password,
                    Email = c.Email,
                    Url = c.Url,
                    Operativity = c.Operativity,
                    User_Admin = c.User_Admin,
                    Password_First = c.Password_First,
                    Password_Admin = c.Password_Admin,
                    Password_3D_Secure = c.Password_3D_Secure,
                    Password_Dispositiva = c.Password_Dispositiva,
                    Password_History = c.Password_History,
                    Sim_Serial = c.Sim_Serial,
                    Sim_Operator = c.Sim_Operator,
                    SmartPhone_Model = c.SmartPhone_Model,
                    SmartPhone_Serial = c.SmartPhone_Serial,
                    SmartPhone_IMEI = c.SmartPhone_IMEI,
                    SmartPhone_Supplier = c.SmartPhone_Supplier,
                    Numero_Cliente = c.Numero_Cliente,
                    Iban = c.Iban,
                    Numero_Carta = c.Numero_Carta,
                    Data_Scadenza = c.Data_Scadenza,
                    Pin_App = c.Pin_App,
                    Pin_Carta = c.Pin_Carta,
                    Pin = c.Pin,
                    Puk = c.Puk,
                    Codice_Dispositivo = c.Codice_Dispositivo,
                    Codice_Sicurezza = c.Codice_Sicurezza,
                    Frase_Identificativa = c.Frase_Identificativa,
                    Machine_IP = c.Machine_IP,
                    Machine_Name = c.Machine_Name,
                    Machine_Type = c.Machine_Type,
                    Note = c.Note,
                    Expired_Date = c.Expired_Date,
                    Expired = c.Expired,
                    Active = c.Active,
                    Modified = c.Modified,
                    Created = c.Created
                })
                .ToListAsync();

            return new PaginatedResult<CredentialDto>
            {
                Items = items,
                TotalCount = totalCount,
                PageIndex = filter.PageIndex,
                PageSize = filter.PageSize
            };
        }

        // GET: api/Credentials/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CredentialDto>> GetCredential(int id)
        {
            var credential = await _context.Credentials.FindAsync(id);

            if (credential == null)
            {
                return NotFound();
            }

            return new CredentialDto
            {
                Id = credential.Id,
                Name = credential.Name,
                Description = credential.Description,
                Profile = credential.Profile,
                Subject_ID = credential.Subject_ID,
                Nickname = credential.Nickname,
                Area = credential.Area,
                Section = credential.Section,
                Username = credential.Username,
                Password = credential.Password,
                Email = credential.Email,
                Url = credential.Url,
                Operativity = credential.Operativity,
                User_Admin = credential.User_Admin,
                Password_First = credential.Password_First,
                Password_Admin = credential.Password_Admin,
                Password_3D_Secure = credential.Password_3D_Secure,
                Password_Dispositiva = credential.Password_Dispositiva,
                Password_History = credential.Password_History,
                Sim_Serial = credential.Sim_Serial,
                Sim_Operator = credential.Sim_Operator,
                SmartPhone_Model = credential.SmartPhone_Model,
                SmartPhone_Serial = credential.SmartPhone_Serial,
                SmartPhone_IMEI = credential.SmartPhone_IMEI,
                SmartPhone_Supplier = credential.SmartPhone_Supplier,
                Numero_Cliente = credential.Numero_Cliente,
                Iban = credential.Iban,
                Numero_Carta = credential.Numero_Carta,
                Data_Scadenza = credential.Data_Scadenza,
                Pin_App = credential.Pin_App,
                Pin_Carta = credential.Pin_Carta,
                Pin = credential.Pin,
                Puk = credential.Puk,
                Codice_Dispositivo = credential.Codice_Dispositivo,
                Codice_Sicurezza = credential.Codice_Sicurezza,
                Frase_Identificativa = credential.Frase_Identificativa,
                Machine_IP = credential.Machine_IP,
                Machine_Name = credential.Machine_Name,
                Machine_Type = credential.Machine_Type,
                Note = credential.Note,
                Expired_Date = credential.Expired_Date,
                Expired = credential.Expired,
                Active = credential.Active,
                Modified = credential.Modified,
                Created = credential.Created
            };
        }

        // POST: api/Credentials
        [HttpPost]
        public async Task<ActionResult<CredentialDto>> CreateCredential(CredentialCreateDto createDto)
        {
            var credential = new Models.Domains.Credential
            {
                Name = createDto.Name,
                Description = createDto.Description,
                Profile = createDto.Profile,
                Subject_ID = createDto.Subject_ID,
                Nickname = createDto.Nickname,
                Area = createDto.Area,
                Section = createDto.Section,
                Username = createDto.Username,
                Password = createDto.Password,
                Email = createDto.Email,
                Url = createDto.Url,
                Operativity = createDto.Operativity,
                User_Admin = createDto.User_Admin,
                Password_First = createDto.Password_First,
                Password_Admin = createDto.Password_Admin,
                Password_3D_Secure = createDto.Password_3D_Secure,
                Password_Dispositiva = createDto.Password_Dispositiva,
                Password_History = createDto.Password_History,
                Sim_Serial = createDto.Sim_Serial,
                Sim_Operator = createDto.Sim_Operator,
                SmartPhone_Model = createDto.SmartPhone_Model,
                SmartPhone_Serial = createDto.SmartPhone_Serial,
                SmartPhone_IMEI = createDto.SmartPhone_IMEI,
                SmartPhone_Supplier = createDto.SmartPhone_Supplier,
                Numero_Cliente = createDto.Numero_Cliente,
                Iban = createDto.Iban,
                Numero_Carta = createDto.Numero_Carta,
                Data_Scadenza = createDto.Data_Scadenza,
                Pin_App = createDto.Pin_App,
                Pin_Carta = createDto.Pin_Carta,
                Pin = createDto.Pin,
                Puk = createDto.Puk,
                Codice_Dispositivo = createDto.Codice_Dispositivo,
                Codice_Sicurezza = createDto.Codice_Sicurezza,
                Frase_Identificativa = createDto.Frase_Identificativa,
                Machine_IP = createDto.Machine_IP,
                Machine_Name = createDto.Machine_Name,
                Machine_Type = createDto.Machine_Type,
                Note = createDto.Note,
                Expired_Date = createDto.Expired_Date,
                Expired = createDto.Expired,
                Active = createDto.Active,
                Created = DateTime.UtcNow,
                Modified = DateTime.UtcNow
            };

            _context.Credentials.Add(credential);
            await _context.SaveChangesAsync();

            return CreatedAtAction(
                nameof(GetCredential),
                new { id = credential.Id },
                new CredentialDto
                {
                    Id = credential.Id,
                    Name = credential.Name,
                    Description = credential.Description,
                    Profile = credential.Profile,
                    Subject_ID = credential.Subject_ID,
                    Nickname = credential.Nickname,
                    Area = credential.Area,
                    Section = credential.Section,
                    Username = credential.Username,
                    Password = credential.Password,
                    Email = credential.Email,
                    Url = credential.Url,
                    Operativity = credential.Operativity,
                    User_Admin = credential.User_Admin,
                    Password_First = credential.Password_First,
                    Password_Admin = credential.Password_Admin,
                    Password_3D_Secure = credential.Password_3D_Secure,
                    Password_Dispositiva = credential.Password_Dispositiva,
                    Password_History = credential.Password_History,
                    Sim_Serial = credential.Sim_Serial,
                    Sim_Operator = credential.Sim_Operator,
                    SmartPhone_Model = credential.SmartPhone_Model,
                    SmartPhone_Serial = credential.SmartPhone_Serial,
                    SmartPhone_IMEI = credential.SmartPhone_IMEI,
                    SmartPhone_Supplier = credential.SmartPhone_Supplier,
                    Numero_Cliente = credential.Numero_Cliente,
                    Iban = credential.Iban,
                    Numero_Carta = credential.Numero_Carta,
                    Data_Scadenza = credential.Data_Scadenza,
                    Pin_App = credential.Pin_App,
                    Pin_Carta = credential.Pin_Carta,
                    Pin = credential.Pin,
                    Puk = credential.Puk,
                    Codice_Dispositivo = credential.Codice_Dispositivo,
                    Codice_Sicurezza = credential.Codice_Sicurezza,
                    Frase_Identificativa = credential.Frase_Identificativa,
                    Machine_IP = credential.Machine_IP,
                    Machine_Name = credential.Machine_Name,
                    Machine_Type = credential.Machine_Type,
                    Note = credential.Note,
                    Expired_Date = credential.Expired_Date,
                    Expired = credential.Expired,
                    Active = credential.Active,
                    Modified = credential.Modified,
                    Created = credential.Created
                });
        }

        // PUT: api/Credentials/5
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateCredential(int id, CredentialUpdateDto updateDto)
        {
            var credential = await _context.Credentials.FindAsync(id);

            if (credential == null)
            {
                return NotFound();
            }

            credential.Name = updateDto.Name;
            credential.Description = updateDto.Description;
            credential.Profile = updateDto.Profile;
            credential.Subject_ID = updateDto.Subject_ID;
            credential.Nickname = updateDto.Nickname;
            credential.Area = updateDto.Area;
            credential.Section = updateDto.Section;
            credential.Username = updateDto.Username;
            credential.Password = updateDto.Password;
            credential.Email = updateDto.Email;
            credential.Url = updateDto.Url;
            credential.Operativity = updateDto.Operativity;
            credential.User_Admin = updateDto.User_Admin;
            credential.Password_First = updateDto.Password_First;
            credential.Password_Admin = updateDto.Password_Admin;
            credential.Password_3D_Secure = updateDto.Password_3D_Secure;
            credential.Password_Dispositiva = updateDto.Password_Dispositiva;
            credential.Password_History = updateDto.Password_History;
            credential.Sim_Serial = updateDto.Sim_Serial;
            credential.Sim_Operator = updateDto.Sim_Operator;
            credential.SmartPhone_Model = updateDto.SmartPhone_Model;
            credential.SmartPhone_Serial = updateDto.SmartPhone_Serial;
            credential.SmartPhone_IMEI = updateDto.SmartPhone_IMEI;
            credential.SmartPhone_Supplier = updateDto.SmartPhone_Supplier;
            credential.Numero_Cliente = updateDto.Numero_Cliente;
            credential.Iban = updateDto.Iban;
            credential.Numero_Carta = updateDto.Numero_Carta;
            credential.Data_Scadenza = updateDto.Data_Scadenza;
            credential.Pin_App = updateDto.Pin_App;
            credential.Pin_Carta = updateDto.Pin_Carta;
            credential.Pin = updateDto.Pin;
            credential.Puk = updateDto.Puk;
            credential.Codice_Dispositivo = updateDto.Codice_Dispositivo;
            credential.Codice_Sicurezza = updateDto.Codice_Sicurezza;
            credential.Frase_Identificativa = updateDto.Frase_Identificativa;
            credential.Machine_IP = updateDto.Machine_IP;
            credential.Machine_Name = updateDto.Machine_Name;
            credential.Machine_Type = updateDto.Machine_Type;
            credential.Note = updateDto.Note;
            credential.Expired_Date = updateDto.Expired_Date;
            credential.Expired = updateDto.Expired;
            credential.Active = updateDto.Active;
            credential.Modified = DateTime.UtcNow;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CredentialExists(id))
                {
                    return NotFound();
                }
                throw;
            }

            return NoContent();
        }

        // DELETE: api/Credentials/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCredential(int id)
        {
            var credential = await _context.Credentials.FindAsync(id);
            if (credential == null)
            {
                return NotFound();
            }

            _context.Credentials.Remove(credential);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CredentialExists(int id)
        {
            return _context.Credentials.Any(e => e.Id == id);
        }
    }
}
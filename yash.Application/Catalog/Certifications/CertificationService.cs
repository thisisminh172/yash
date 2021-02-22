using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using yash.Data.EF;
using yash.Data.Entities;
using yash.ViewModels.Catalog.Certifications;

namespace yash.Application.Catalog.Certifications
{
    public class CertificationService : ICertificationService
    {
        private readonly YashDbContext _context;
        public CertificationService(YashDbContext context)
        {
            _context = context;
        }
        public async Task<int> Create(CertificationCreateRequest request)
        {
            var certification = new Certification()
            {
                Name = request.Name,
                LinkUrl = request.LinkUrl
            };
            _context.Certifications.Add(certification);
            await _context.SaveChangesAsync();
            return certification.Id;
        }

        public async Task<int> Delete(int certificationId)
        {
            var deleteCertification = await _context.Certifications.FindAsync(certificationId);
            _context.Certifications.Remove(deleteCertification);
            return await _context.SaveChangesAsync();
        }

        public async Task<List<Certification>> GetAll()
        {
            var certifications = await _context.Certifications.ToListAsync();
            return certifications;
        }

        public async Task<Certification> GetById(int certificationId)
        {
            var certification = await _context.Certifications.FindAsync(certificationId);
            return certification;
        }

        public async Task<int> Update(CertificationUpdateRequest request)
        {
            var certification = await _context.Certifications.FindAsync(request.Id);
            if (certification == null)
            {
                return -1;
            }
            certification.Name = request.Name;
            certification.LinkUrl = request.LinkUrl;
            return await _context.SaveChangesAsync();
        }
    }
}

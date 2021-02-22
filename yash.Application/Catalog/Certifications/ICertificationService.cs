using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using yash.Data.Entities;
using yash.ViewModels.Catalog.Certifications;

namespace yash.Application.Catalog.Certifications
{
    public interface ICertificationService
    {
        Task<List<Certification>> GetAll();
        Task<Certification> GetById(int certificationId);
        Task<int> Create(CertificationCreateRequest request);
        Task<int> Update(CertificationUpdateRequest request);
        Task<int> Delete(int certificationId);
    }
}

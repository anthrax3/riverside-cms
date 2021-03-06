﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Riverside.Cms.Services.Storage.Domain
{
    public interface IStorageRepository
    {
        Task<IEnumerable<Blob>> SearchBlobsAsync(long tenantId, string path);
        Task<long> CreateBlobAsync(long tenantId, Blob blob);
        Task<Blob> ReadBlobAsync(long tenantId, long blobId);
        Task DeleteBlobAsync(long tenantId, long blobId);
    }
}

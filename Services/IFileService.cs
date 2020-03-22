using AISvisualizer.Models;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AISvisualizer.Services
{
    public interface IFileService
    {
        IAsyncEnumerable<LineContent> GetLineContents(IEnumerable<IFormFile> files);
        bool CheckHeader(string header);
    }
}

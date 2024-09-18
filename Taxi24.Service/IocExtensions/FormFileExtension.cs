using Microsoft.AspNetCore.Http;

namespace Taxi24.Service.IocExtensions;

public static class FormFileExtension
{
    public static async Task<string?> saveFile(this IFormFile? file, string? name, string WebRootPath)
    {
        if (file == null) return null;

        var fileName = Guid.NewGuid().ToString() + Path.GetExtension(name + file.FileName);
        var directory = Path.Combine(WebRootPath, "Files");
        if (!Directory.Exists(directory))
            Directory.CreateDirectory(directory);
        var filePath = Path.Combine(WebRootPath, "Files", fileName);

        using (var stream = new FileStream(filePath, FileMode.Create))
        {
            await file.CopyToAsync(stream);
            return fileName;
        }
    }

}

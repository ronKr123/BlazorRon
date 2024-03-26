using Microsoft.AspNetCore.Components.Forms;
using Microsoft.Extensions.FileProviders;
using System;
using System.IO;
using System.Threading.Tasks;

namespace BlazorAppMyLibrary
{
    public class FileService
    { 
            public async Task<(bool Success, string FileName, string ErrorMessage)> SaveImageAsync(IBrowserFile file, string folderPath)
            {
                try
                {
                    if (file != null && file.Size > 0)
                    {
                        string fileName = Path.GetFileName(file.Name);
                        string filePath = Path.Combine(folderPath, fileName);

                        // בדיקה אם קיים קובץ עם שם דומה
                        if (File.Exists(filePath))
                        {
                            return (false, null, "קיים במערכת קובץ עם שם דומה, אנא החלף שם קובץ");
                        }

                        using (FileStream fs = File.Create(filePath))
                        {
                            await file.OpenReadStream().CopyToAsync(fs);
                        }

                        return (true, fileName, null);
                    }

                    return (false, null, "שגיאה");
                }
                catch (Exception ex)
                {
                    return (false, null, $"שגיאה בשמירת הקובץ: {ex.Message}");
                }
            }
        }
}

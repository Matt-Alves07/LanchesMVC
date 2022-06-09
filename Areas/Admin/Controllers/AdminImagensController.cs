using LanchesMVC.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace LanchesMVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class AdminImagensController : Controller
    {
        private readonly ConfiguracaoImagens _config;
        private readonly IWebHostEnvironment _hostingEnvironment;

        public AdminImagensController(IOptions<ConfiguracaoImagens> config, IWebHostEnvironment hostingEnvironment)
        {
            _config = config.Value;
            _hostingEnvironment = hostingEnvironment;
        }

        public IActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// Receive a list of files to add new images for lanches
        /// </summary>
        /// <param name="files"></param>
        /// <returns></returns>
        public async Task<IActionResult> UploadFiles(List<IFormFile> files)
        {
            if (files == null || files.Count == 0)
            {
                ViewData["Erro"] = "Erro: Nenhum arquivo selecionado.";
                return View(ViewData);
            }

            if (files.Count > 10)
            {
                ViewData["Erro"] = "Erro: Quantidade máxima de arquivos excedida.";
                return View(ViewData);
            }

            long size = files.Sum(f => f.Length);
            var filePathsName = new List<string>();
            var filePath = Path.Combine(_hostingEnvironment.WebRootPath, _config.NomePastaImagensProdutos);

            foreach (var formFile in files)
            {
                if (formFile.FileName.Contains(".jpg") || formFile.FileName.Contains(".gif") || formFile.FileName.Contains(".png"))
                {
                    var fileNameWithPath = string.Concat(filePath, "/", formFile.FileName);
                    filePathsName.Add(fileNameWithPath);

                    using (var stream = new FileStream(fileNameWithPath, FileMode.Create))
                    {
                        await formFile.CopyToAsync(stream);
                    }

                }                
            }

            ViewData["Resultado"] = $"{files.Count()} arquivos foram enviados ao servidor, com tamanho total de: {size}";
            ViewBag.Arquivos = filePathsName;

            return View(ViewData);
        }

        /// <summary>
        /// Returns a list of images saved in produtos folder
        /// </summary>
        /// <returns></returns>
        public IActionResult GetImagens()
        {
            FileManagerModel model = new FileManagerModel();
            var userImagesPath = Path.Combine(_hostingEnvironment.WebRootPath, _config.NomePastaImagensProdutos);
            DirectoryInfo dir = new DirectoryInfo(userImagesPath);

            FileInfo[] files = dir.GetFiles();

            model.PathImagesProduto = _config.NomePastaImagensProdutos;

            if (files.Length == 0)
                ViewData["Error"] = $"Nenhum arquivo encontrado na past {userImagesPath}";

            model.Files = files;
            return View(model);
        }

        /// <summary>
        /// Removes an image from project folder produtos
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public IActionResult DeleteFile(string fileName)
        {
            string _imagemAApagar = Path.Combine(_hostingEnvironment.WebRootPath, _config.NomePastaImagensProdutos + "/", fileName);

            if (System.IO.File.Exists(_imagemAApagar))
            {
                System.IO.File.Delete(_imagemAApagar);
                ViewData["Excluído"] = $"Arquivo {fileName} removido com sucesso";
            }

            return View("index");
        }
    }
}

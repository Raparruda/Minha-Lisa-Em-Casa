using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MLEC.Models;

namespace MLEC.Controllers
{
    public class SecaosController : Controller
    {
        public IActionResult Index()
        {
            List<Secao> list = new List<Secao>
            {
                new Secao { Id = 1, Nome = "BEBIDA" },
                new Secao { Id = 2, Nome = "AÇOUGUE" },
                new Secao { Id = 3, Nome = "BISCOITO" },
                new Secao { Id = 4, Nome = "BOMBOM" },
                new Secao { Id = 5, Nome = "CANTINHO DO BEBÊ" },
                new Secao { Id = 6, Nome = "CEREAIS E FARINACEOS" },
                new Secao { Id = 7, Nome = "CONSERVAS" },
                new Secao { Id = 8, Nome = "EMBUTIDOS" },
                new Secao { Id = 9, Nome = "FRIOS E LATICÍNIOS" },
                new Secao { Id = 10, Nome = "HIGIÊNE PESSOAL" },
                new Secao { Id = 11, Nome = "HORTIFRUTI" },
                new Secao { Id = 12, Nome = "LIMPEZA" },
                new Secao { Id = 13, Nome = "MASSAS" },
                new Secao { Id = 14, Nome = "MATINAIS E PADARIA" },
                new Secao { Id = 15, Nome = "RAÇÕES, JARDINAGEM E CAMPING" },
                new Secao { Id = 16, Nome = "SALGADS" }
            };
            return View(list);
        }
    }
}
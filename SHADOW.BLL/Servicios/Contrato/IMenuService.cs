using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SHADOW.DTO;

namespace SHADOW.BLL.Servicios.Contrato
{
    public interface IMenuService
    {
        Task<MenuDTO> Lista(int idUsuario);
    }
}

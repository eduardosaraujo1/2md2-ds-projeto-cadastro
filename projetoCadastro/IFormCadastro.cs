using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projetoCadastro
{
    public interface IFormCadastro
    {
        IEntidade[] cadastros { get; set; } // Array será declarado como referencia para Storage.[TipoObjeto]
        Panel getPanelCampos { get; }

        void RenderizarDados();
        IEntidade PassarDadosParaIEntidade();
        void BloquearDigitacao();
        void PermitirDigitacao();
        
    }
}

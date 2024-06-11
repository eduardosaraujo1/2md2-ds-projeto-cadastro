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
        //int pointerCliente { get; set; }
        //int pointerPosicaoVaziaArray { get; set; }
        //LogicaCadastro.ModoForm modoForm { get; set; }
        TextBox inputCodigoGet { get; }
        Button btnAnteriorGet { get;  }
        Button btnProximoGet {get; }
        Button btnSalvarGet {get; }
        Button btnCancelarGet {get; }
        Button btnNovoGet {get; }
        Button btnPesquisarGet {get; }
        Button btnAlterarGet {get; }
        Button btnImprimirGet {get; }
        Button btnExcluirGet {get; }
        Button btnSairGet {get; }
        Panel panelCamposGet { get; }

        void RenderizarDados();
        IEntidade PassarDadosParaIEntidade();
        
    }
}

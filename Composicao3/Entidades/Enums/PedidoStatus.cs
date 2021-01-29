using System;
using System.Collections.Generic;
using System.Text;

namespace Composicao3.Entidades.Enums {
    enum PedidoStatus : int {

        Pagamento_Pendente = 0,
        Processando = 1,
        Enviado = 2,
        Entregue = 3
    }
}

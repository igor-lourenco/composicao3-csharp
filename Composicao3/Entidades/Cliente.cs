using System;
using System.Collections.Generic;
using System.Text;

namespace Composicao3.Entidades {
    class Cliente {

        public string Nome { get; set; }
        public string Email { get; set; }
        public DateTime Aniversario { get; set; }

        public Cliente(string nome, string email, DateTime aniversario) {
            Nome = nome;
            Email = email;
            Aniversario = aniversario;
        }

        public override string ToString() {
            return Nome
                + ", ("
                + Aniversario.ToString("dd/MM/yyyy")
                + ") - "
                + Email;
        }
    }
}

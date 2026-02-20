class Banco:
    def __init__(self, nome, codigo_bacen):
        self.nome = nome
        self.codigo_bacen = codigo_bacen

    def set_nome(self, nome):
        if nome.strip() != "":
            self.nome = nome

    def get_nome(self):
        return self.nome.upper()

    def set_codigo_bacen(self, codigo):
        if codigo.strip() != "":
            self.codigo_bacen = codigo

    def get_codigo_bacen(self):
        return self.codigo_bacen


class Transacao:
    def __init__(self, valor, data, conta_origem, conta_destino):
        self.valor = valor
        self.data = data
        self.conta_origem = conta_origem
        self.conta_destino = conta_destino

    def set_valor(self, valor):
        if valor > 0:
            self.valor = valor

    def get_valor(self):
        return self.valor


# Main
banco = Banco("Banco do Brasil", "001")
transacao = Transacao(150, "20/02/2026", "Conta A", "Conta B")

print("Banco:", banco.get_nome())
print("Código BACEN:", banco.get_codigo_bacen())
print("Valor da Transação:", transacao.get_valor())

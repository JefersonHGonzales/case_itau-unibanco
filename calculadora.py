class Calculadora:
    def __init__(self):
      # Inicializa uma lista para armazenar as operações realizadas.
        self.operacoes = []
      # Inicializa o resultado final com 0.0.
        self.resultado_final = 0.0

    def adicao(self, num1, num2):
      # Realiza a operação de adição.
        resultado = num1 + num2
       # Atualiza o resultado final e adiciona a operação à lista de operações.
        self.atualizar_resultado(num1, num2, resultado, "+")
        return resultado

    def subtracao(self, num1, num2):
      # Realiza a operação de subtração.
        resultado = num1 - num2
       # Atualiza o resultado final e adiciona a operação à lista de operações.
        self.atualizar_resultado(num1, num2, resultado, "-")
        return resultado

    def multiplicacao(self, num1, num2):
      # Realiza a operação de multiplicção.
        resultado = num1 * num2
      # Atualiza o resultado final e adiciona a operação à lista de operações.
        self.atualizar_resultado(num1, num2, resultado, "*")
        return resultado

    def divisao(self, num1, num2):
      # Verifica se o divisor é zero para evitar a divisão por zero.
        if num2 == 0:
            print("Erro: Divisão por zero!")
            return None
      # Realiza a operação de divisão.
        resultado = num1 / num2
      # Atualiza o resultado final e adiciona a operação à lista de operações.
        self.atualizar_resultado(num1, num2, resultado, "/")
        return resultado

    def atualizar_resultado(self, num1, num2, resultado, operador):
      # Formata e adiciona a operação à lista de operações.
        operacao = f"{len(self.operacoes) + 1}. {num1} {operador} {num2} = {resultado}"
        self.operacoes.append(operacao)
        self.resultado_final = resultado

    def mostrar_todas_operacoes(self):
      # Mostra todas as operações realizadas até o momento.
        print("Todas as Operações:")
        for operacao in self.operacoes:
            print(operacao)
        print()

    def mostrar_resultado_final(self):
      # Mostra o resultado final.
        print(f"Resultado Final: {self.resultado_final}\n")

    def executar_calculadora(self):
      # Input dos valores
        while True:
            print("Menu da Calculadora")
            print("1. Adição (+)")
            print("2. Subtração (-)")
            print("3. Multiplicação (*)")
            print("4. Divisão (/)")
            print("5. Mostrar Todas as Operações")
            print("6. Mostrar Resultado Final")
            print("7. Sair")

            escolha = input("Digite sua escolha (1-7): ")

            try:
                escolha = int(escolha)
            except ValueError:
                print("Entrada inválida. Por favor, insira uma opção válida.")
                continue

            if escolha in [1, 2, 3, 4]:
                try:
                    num1 = float(input("Digite o primeiro número: "))
                    num2 = float(input("Digite o segundo número: "))
                except ValueError:
                    print("Entrada inválida. Por favor, insira um número válido.")
                    continue

                if escolha == 1:
                    self.adicao(num1, num2)
                elif escolha == 2:
                    self.subtracao(num1, num2)
                elif escolha == 3:
                    self.multiplicacao(num1, num2)
                elif escolha == 4:
                    self.divisao(num1, num2)

            elif escolha == 5:
                self.mostrar_todas_operacoes()
            elif escolha == 6:
                self.mostrar_resultado_final()
            elif escolha == 7:
                print("Encerrando a calculadora.")
                self.mostrar_todas_operacoes()
                break
            else:
                print("Escolha inválida. Por favor, insira uma opção válida.")

# Cria uma instância da calculadora e a executa.
if __name__ == "__main__":
    calculadora = Calculadora()
    calculadora.executar_calculadora()
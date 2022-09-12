#Autor: Neemias Vieira, https://github.com/NeemiasVieira
#String de exemplo do exercício: Ana, 89,78, Maria, 45.8, 27, 56, Paula Pereira, 978, A, VIVA, 35, 125, 8999

#Cria uma linha para separar as informações e decorar o ambiente.
def linha():
    print("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=")

#Função que cria uma lista a partir de uma string separando os elementos por "," e depois separa os númericos das strings e exibe ao usuário.
def separaArray(array):

    arraySeparado = array.split(",")
    arraynum = []
    arraystring = []
    for x in range(0, len(arraySeparado)): #Percorre a lista
        try:
            if (float(arraySeparado[x]) / float(arraySeparado[x]) == 1): # Se o elemento for um número ele é adicionado a lista "arraynum".
                arraynum.append(float(arraySeparado[x]))
        except:  #Foi utilizado o try/except pois o comparador da erro ao tentar dividir uma string, e acabou sendo bem útil aqui :)

            arraystring.append(arraySeparado[x]) #Se não ele é considerado uma string e é adicionado a lista "arraystring".
    print(f'String original: "{array}"')
    print(f'Lista separada por virgulas: {arraySeparado}')
    print(f'Lista de números: {arraynum}')
    print(f'Lista de strings: {arraystring}') #A string e todas as listas são exibidas.

    linha()
    print("")
    print("")
    print("")
    input("Pressione a tecla Enter para continuar...") #Não permite que o console fique poluido antes que o usuário visualize o resultado.


#Função que opera o menu e retorna a escolha do usuário ao looping.
def menu():
    linha()
    print("                        MENU")
    linha()
    print("            1 - Transformar uma string")
    print("            2 - Fechar o programa")
    linha()
    try:
        opc = int(input("Digite a opção desejada: "))
    except:
        opc = 0

    if (opc == 1):
        string = str(input("Digite ou Cole a string desejada aqui: "))
        linha()
        separaArray(string)
    elif(opc == 2):
        linha()
        print("Programa finalizado com sucesso!")
        linha()
    else:
        linha()
        print("Opção invalida!")
        linha()
        input("Pressione a tecla Enter para continuar...")
    return opc

#Programa principal

arraynum = []
arraystring = [] #Criação das variáveis globais em forma de lista

controle = 1
while(controle == 1): #Looping do programa.
    if(menu() == 2):
        controle = 0



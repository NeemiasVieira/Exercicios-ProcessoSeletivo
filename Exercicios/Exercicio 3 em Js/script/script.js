//Gerador de crachás
//Autor: Neemias Vieira, Github: https://github.com/NeemiasVieira

// Variaveis Globais

var nomedocracha = document.querySelector("#lbl_name")
var formulario = document.querySelector("#formName")
var nomefuncionario = ""
var nomedeexibicao = ""

document.querySelector("#campoNome").focus() //Define o foco para o campo input

formulario.addEventListener('submit', (evt) => { //Evento que gera o crachá
    
    evt.preventDefault()   //Não permite que a página seja atualizada 
    nomefuncionario = formulario.querySelector("#campoNome").value  

    if (nomefuncionario != "") { //Valida a entrada se não for vazia
    
    nomefuncionario = nomefuncionario.split(" ") //Divide a string em um array com todos os nomes

    var contador = nomefuncionario.length-1 //Define um contador para encontrar o último nome do colaborador
    var lastname = (nomefuncionario[contador]+", ") //Encontra o nome e cria a primeira parte da string
    nomedeexibicao = lastname.toUpperCase() //Passa o último nome para o nome de exibição

    nomefuncionario = transformaParaMaiusculo(nomefuncionario, nomefuncionario.length) //Chama a função que transforma os nomes em letras iniciais maiusculas

    for(var i=0;i<(nomefuncionario.length-1);i++){ //Loop que valida os nomes e adiciona as iniciais de cada nome na string de exibição
        if(nomefuncionario[i]!= "DE" && nomefuncionario[i]!= "DA" &&
         nomefuncionario[i]!= "DAS" && nomefuncionario[i]!= "DO" && 
         nomefuncionario[i]!= "DOS" && nomefuncionario[i]!= "E"){
        
            nomedeexibicao = nomedeexibicao + (nomefuncionario[i].substring(0,1)+". ") 
        }   
    }
    
    nomedocracha.innerHTML = nomedeexibicao //Passa a variável nomedeexibicao já com as regras de negócio para o DOM
}
else{ 
    alert("Preencha o campo primeiro.") 
}
    
})

function transformaParaMaiusculo(array, limite){ 

    for (let i=0; i<limite; i++){
       array[i] = (array[i].toUpperCase())
       console.log("array[i]")
    }
    return array
 }

const limpar = () => { //Função que limpa os dados, foi utilizado o evento onclick inline, sem a criação de um eventlistener
    nomedeexibicao = "O nome será exibido aqui"
    nomedocracha.innerHTML = nomedeexibicao
    document.querySelector("#campoNome").value= ""
    document.querySelector("#campoNome").focus()

}

#!/bin/bash

# Função para criar projeto .NET
criar_projeto_dotnet() {
    local tipo_projeto=$1
    local nome_projeto=$2
    
    case $tipo_projeto in
        1)
            echo "Criando um projeto Minimal API..."
            dotnet new web -o $nome_projeto
            ;;
        2)
            echo "Criando um projeto Web API MVC..."
            dotnet new mvc -o $nome_projeto
            ;;
        3)
            echo "Criando um projeto Console..."
            dotnet new console -o $nome_projeto
            ;;
        *)
            echo "Opção inválida!"
            exit 1
            ;;
    esac
}

# Solicita o nome da pasta ao usuário
read -p "Digite o nome da pasta: " nome_pasta

# Cria a pasta
mkdir $nome_pasta
cd $nome_pasta

# Solicita ao usuário que escolha o tipo de projeto
echo "Escolha o tipo de projeto .NET que deseja criar:"
echo "1) Minimal API"
echo "2) Web API MVC"
echo "3) Console"
read -p "Digite o número da opção: " opcao

# Cria o projeto .NET com base na opção do usuário
criar_projeto_dotnet $opcao $nome_pasta

echo "Projeto criado com sucesso na pasta $nome_pasta!"
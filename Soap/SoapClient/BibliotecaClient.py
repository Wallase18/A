from zeep import Client

class Livros: 
    pass ##O pass fuciona como ser fosse um placeholder e 
         # os campos pode ser atribuidos conform for utilizado

def novoLivro():
    ret = Livros()
    ret.titulo = input('Digite o titulo do livro:')
    ret.autor = input('Digite o autor do livro:')
    ret.editora = input('Digite a editora do livro:')
    ret.descricao = input('Digite a descricao do livro:')
    return ret

def main():
     ## O zeep importa o cliente para consumir o serviço 
    client = Client('http://localhost:9876/biblioteca?wsdl')
    print('### Biblioteca ###')
    while True:
        print('\nMENU:')
        print('1) Inserir livro')
        print('2) Listar livros')
        print('0) Sair')
        op = input('> ')
        if op == '1':
            # Acessar os metodos do WebService
            livros = novoLivro()
            client.service.insereLivro(livros.titulo, livros.autor, livros.editora, livros.descricao)
        elif op == '2':
            ls = client.service.retornaLivros()
            for livros in ls:
                print('')
                print("Codigo:",livros.codigo)
                print("Titulo:",livros.titulo)
                print("Autor:",livros.autor)
                print("Editora:",livros.editora)
                print("Descricao:\n",livros.descricao)
        elif op == '0':
            break
        else:
            print('Opcao invalida!')
if __name__ == '__main__':
    main()

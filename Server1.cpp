// Para compila g++ Server1.cpp -o Server1.exe -l ws2_32

#include <iostream>
#include <winsock2.h>

using namespace std;

class Server
{
    public:
    WSADATA WSAData;
    SOCKET server, client;
    SOCKADDR_IN serverAddr, clientAddr;
    char buffer[1024];

    Server()
    {
        WSAStartup(MAKEWORD(2,0), &WSAData);// inicia a biblioteca de sockets do windows
        server = socket(AF_INET, SOCK_STREAM, 0);// Cria um novo socket
        // AF_INET -  Protocolo IPV4 // SOCK_STREAM - Comunicaçao de dois lados , usar protocolo TCP
        // AF_INET6 protocolo IPV6 // SOCK_DFRAM - Sem conexao, mensagens com tamanho maximo, usar protocolo UDP

        serverAddr.sin_addr.s_addr = INADDR_ANY;// Ip 
        // INADDR_ANY é usado para definir qualque indereço que seja expecificado pela rede 
        serverAddr.sin_family = AF_INET;// familia de protocolo
        serverAddr.sin_port = htons(5555);// porta // htons () converte para o formato correto

        bind(server, (SOCKADDR *)&serverAddr, sizeof(serverAddr));// Associa o socket a um endereço na rede
        // "sizeof"  tamanho em bytes
        listen(server, 0);// permite receber conxoes e o limite de conexoes

        cout << "Escultando conexão" << endl;
        int clientAddrSize = sizeof(clientAddr);
        if((client = accept(server, (SOCKADDR *)&clientAddr, &clientAddrSize)) != INVALID_SOCKET)
        // A funçao accept recebe o socket, depois o indereço e porta do cliente, um pontero que tem o tamanho da estrutura do sergundo argumento
        {
            cout << "Cliente conectado!" << endl;
        }
    }

    void Receber()
    {
        recv(client, buffer, sizeof(buffer), 0);// recebe os dados que o cliente enviar
        cout << "Cliente diz: " << buffer << endl;
        memset(buffer, 0, sizeof(buffer));
    }

    void Enviar()
    {
        cout << "Escreve mensagem : ";
        cin >> this -> buffer;
        send(client, buffer, sizeof(buffer), 0);
        memset(buffer, 0, sizeof(buffer));
        cout << "mensagem enviada!" << endl;
    }

    void Fechasocket()
    {
        closesocket(client);
        cout << "Socket fechado, cliente desconectado." << endl;
    }
};

int main()
{
    Server *Servidor = new Server();
    while (true)
    {
        Servidor -> Receber();
        Servidor -> Enviar();
    }
}
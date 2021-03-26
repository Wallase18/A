#include <iostream>
#include <winsock2.h>

using namespace std;

class Client
{
    public:
    WSADATA WSAData;
    SOCKET server;
    SOCKADDR_IN addr;
    char buffer[1024];

    Client()
    {
        cout << "Conectando ao servidor..." << endl << endl;
        WSAStartup(MAKEWORD(2, 0), &WSAData);
        server = socket(AF_INET, SOCK_STREAM, 0);
        addr.sin_addr.s_addr = inet_addr("192.168.56.1");// altere o indereço ip para o da sua maquina
        addr.sin_family = AF_INET;
        addr.sin_port = htons(5555);
        connect(server, (SOCKADDR *)&addr, sizeof(addr));
        cout << "Conectado ao servidor!" << endl;
    }

    void Enviar()
    {
        cout << "Escreva a mensagem: ";
        cin >> this -> buffer;
        send(server, buffer, sizeof(buffer), 0);
        memset(buffer, 0, sizeof(buffer));
        cout << "Mensagem enviada!" << endl;
    }

    void Receber()
    {
        recv(server, buffer, sizeof(buffer), 0);
        cout << "O servidor diz: " << buffer << endl;
        memset(buffer, 0, sizeof(buffer));
    }

    void Fecharsocket()
    {
        closesocket(server);
        WSACleanup();
        cout << "Socket fechado." << endl << endl;
    }
};

int main()
{
    Client *Cliente = new Client;
    while (true)
    {
        Cliente -> Enviar();
        Cliente -> Receber();
    }
}
package soapbiblioteca;
/**
 *
 * @author walla
 */
import java.util.List;
import javax.jws.WebService;


@WebService(endpointInterface = "soapbiblioteca.InterfaceBiblioteca")
public class bibliotecaServer implements InterfaceBiblioteca {
    
    private LivrosDAO livrosDAO = new LivrosDAO();// objeto de acesso aos dados
    
    @Override
    public List<Livros> retornaLivros() {// retornar os livros
        return livrosDAO.listaLivros();
    }

    @Override
    public void insereLivro(String titulo, String autor, String editora, String Descricao) {
        livrosDAO.insereLivros(titulo, autor, editora, Descricao);
    }
    
}

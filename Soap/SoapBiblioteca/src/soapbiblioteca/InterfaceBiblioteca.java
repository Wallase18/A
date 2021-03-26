package soapbiblioteca;
/**
 *
 * @author walla
 */
import java.util.List;
import javax.jws.WebService;
import javax.jws.WebMethod;


@WebService
public interface InterfaceBiblioteca {
    
    /* Métodos do webService*/
    @WebMethod
    public List<Livros> retornaLivros();
    
    @WebMethod
    public void insereLivro(String titulo, String autor, String editora, String Descricao);
}

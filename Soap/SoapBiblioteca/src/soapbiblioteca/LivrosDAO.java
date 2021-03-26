package soapbiblioteca;
/**
 *
 * @author walla
 */
import java.util.ArrayList;
import java.util.LinkedHashMap;
import java.util.Map;


public class LivrosDAO {
    /** Pseudo "banco de dados" utilizando hashmap **/
    private static Map<Long, Livros> Livros = new LinkedHashMap<>();
    private static Long counter;
    
    public LivrosDAO(){
        counter = 0L;// contador para gera o codigo do banco de dados
    }
    
    public ArrayList<Livros> listaLivros(){
        return new ArrayList<>(Livros.values());//arrayList com os valores
    }
    
   public void insereLivros(String titulo, String autor, String editora, String Descricao) {
        counter += 1L;
        Livros.put(counter, new Livros(counter, titulo, autor, editora, Descricao));
    } // metodo para inserçao dos livros atualizando o contador
}

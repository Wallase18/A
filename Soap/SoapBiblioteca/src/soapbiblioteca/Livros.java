package soapbiblioteca;
/**
 *
 * @author walla
 */

public class Livros {
    private Long codigo;
    private String titulo;
    private String autor;
    private String editora;
    private String Descricao;
    
    /** Construtor vazio é requisito da JAX-B (Java Architecture for XML Binding) **/
    public Livros(){
        
    }
    
    public Livros(Long codigo, String titulo, String autor, String editora, String Descricao){
        super();
        this.codigo = codigo;
        this.titulo = titulo;
        this.autor = autor;
        this.editora = editora;
        this.Descricao = Descricao;
    }
    public Long getCodigo(){
        return codigo;
    }
    public void setCodigo(Long codigo){
        this.codigo = codigo;
    }
    public String getTitulo(){
        return titulo;
    }
    public void setTitulo(String titulo){
        this.titulo = titulo;
    }
    public String getAutor(){
        return autor;
    }
    public void setAutor(String autor){
        this.autor = autor;
    }
    public String getEditora(){
        return editora;
    }
    public void setEditora(String editora){
        this.editora= editora;
    }
        public String getDescricao(){
        return Descricao;
    }
    public void setDescricao(String Descricao){
        this.Descricao = Descricao;
    }
    @Override
    public int hashCode(){
        final int prime = 31;
        int result = 1;
        result = prime * result + ((codigo == null) ? 0 : codigo.hashCode());
        return result;
    }
    
    @Override
    public boolean equals(Object obj){
        if(this == obj){
            return true;
        }
        if(obj == null){
            return false;
        }
        Livros other = (Livros) obj;
        if (codigo == null){
            if (other.codigo != null){
                return false;
            }
        } else if(!codigo.equals(other.codigo)){
            return false;
        }
        return true;
    }
}

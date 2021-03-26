package soapbiblioteca;
/**
 *
 * @author walla
 */

import javax.xml.ws.Endpoint;
import soapbiblioteca.bibliotecaServer;

public class BibliotecaPublisher {
    public static void main(String[] args){
        Endpoint.publish("http://localhost:9876/biblioteca", new bibliotecaServer());
    }
    
}

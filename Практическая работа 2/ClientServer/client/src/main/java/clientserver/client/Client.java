package clientserver.client;

import java.io.BufferedReader;
import java.io.BufferedWriter;
import java.io.IOException;
import java.io.InputStreamReader;
import java.io.OutputStreamWriter;
import java.net.Socket;
import java.net.UnknownHostException;

public class Client {

    public static final int PORT = 22812;

    private Socket socket;

    public Client() throws IOException, UnknownHostException {
        socket = new Socket("localhost", PORT); 
    }

    public void run() {
        try (
            var reader = new BufferedReader(new InputStreamReader(System.in));
            var in = new BufferedReader(new InputStreamReader(socket.getInputStream()));
            var out = new BufferedWriter(new OutputStreamWriter(socket.getOutputStream()));
        ) {
            System.out.println("Подключен к серверу...");
            while (true) {
                var responseStr = in.readLine();
                System.out.println(responseStr);
                var requestStr = reader.readLine();
                out.write(requestStr + "\n");
                out.flush();
            }
        } catch (IOException e) {
            System.out.println(e);
        }
    }

    public static void main(String[] args) {
        try {
            var client = new Client();
            client.run();
        } catch (UnknownHostException e) {
            e.printStackTrace();
        } catch (IOException e) {
            e.printStackTrace();
        }
    }
}

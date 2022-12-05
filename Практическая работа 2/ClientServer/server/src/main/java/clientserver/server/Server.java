package clientserver.server;

import java.io.BufferedReader;
import java.io.BufferedWriter;
import java.io.IOException;
import java.io.InputStreamReader;
import java.io.OutputStreamWriter;
import java.net.ServerSocket;
import java.util.ArrayList;
import java.util.List;

import clientserver.server.tasks.Dot;
import clientserver.server.tasks.Task10;
import clientserver.server.tasks.Task13;
import clientserver.server.tasks.Task16;
import clientserver.server.tasks.Task19;
import clientserver.server.tasks.Task7;

public class Server {

    public static final int PORT = 22812;
    private static ServerSocket server;

    public Server() throws IOException {
        server = new ServerSocket(PORT); 
    }

    private void print(BufferedWriter out, String message) throws IOException{
        out.write(message + "\n");
        out.flush();
    }

    private int readNum(BufferedReader in) throws IOException, NumberFormatException {
        var input = in.readLine();
        return Integer.parseInt(input);
    }

    public void run() {
        try (
            var socket = server.accept();
            var in = new BufferedReader(new InputStreamReader(socket.getInputStream()));
            var out = new BufferedWriter(new OutputStreamWriter(socket.getOutputStream()));
        ) {
            System.out.println("Подключение к серверу...");
            Task7 t7 = null;
            Task10 t10 = null;
            Task13 t13 = null;
            Task16 t16 = null;
            Task19 t19 = null;
            while (true) {
                try {
                    print(out, "Введите номер задания: [7, 10, 13, 16, 19]");
                    var numberOfTask = readNum(in);
                    switch (numberOfTask) {
                        case 7: {
                            print(out, "Введите номер подзадачи: [1 - ввести точки, 2 - вычислить расстояние]");
                            var numberOfSubTask = readNum(in);
                            switch (numberOfSubTask) {
                                case 1: {
                                    List<Dot> lst = new ArrayList<>();
                                    for (int i = 0; i < 10; i++) {
                                        print(out, "Введите X координату " + i + " точки");
                                        var x = readNum(in);
                                        print(out, "Введите Y координату " + i + " точки");
                                        var y = readNum(in);
                                        lst.add(new Dot(x, y));
                                    }

                                    t7 = new Task7(lst);
                                    print(out, "Площадь фигуры = " + t7.calcSquare());
                                    break;
                                }
                                case 2: {
                                    if (t7 == null) {
                                        print(out, "Фигуру сначала заполните!");
                                    } else {
                                        print(out, "Введите номер первой точки");
                                        var a = readNum(in);
                                        print(out, "Введите номер второй точки");
                                        var b = readNum(in);

                                        print(out, "Расстояние между точками = " + t7.distanceBetweenDots(a, b));
                                    }
                                    break;
                                }
                                default: {
                                    print(out, "Ну вот только непойми что не вводите!");
                                    break;
                                }
                            }
                            break;
                        }
                        case 10: {
                            print(out, "Введите номер подзадачи: [1 - узнать числа, 2 - проверить число]");
                            var numberOfSubTask = readNum(in);
                            switch (numberOfSubTask) {
                                case 1: {
                                    print(out, "Введите лимит");
                                    var limit = readNum(in);
                                    t10 = new Task10(limit);
                                    print(out, String.join(",", t10.getNumbers().stream().map((Integer n) -> n.toString()).toList()));
                                    break;
                                }
                                case 2: {
                                    print(out, "Введите число");
                                    var limit = readNum(in);
                                    t10 = new Task10(limit);
                                    print(out, t10.checkNumber(limit) ? "Удовлетворяет" : "Не удовлетворяет");
                                    break;
                                }
                                default: {
                                    print(out, "Ну вот только непойми что не вводите!");
                                    break;
                                }
                            }
                            break;
                        }
                        case 13: {
                            print(out, "Введите число");
                            var number = readNum(in);
                            print(out, "Введите степень");
                            var power = readNum(in);
                            t13 = new Task13();
                            print(out, "Результат = " + t13.pow(number, power)); 
                            break;
                        }
                        case 16: {
                            List<List<Integer>> pairs = new ArrayList<>();
                            for (int i = 0; i < 3; i++) {
                                List<Integer> tmp = new ArrayList<>();
                                print(out, "Введите 1 число " + i + " пары");
                                tmp.add(readNum(in));
                                print(out, "Введите 2 число " + i + " пары");
                                tmp.add(readNum(in));
                                pairs.add(tmp);
                            }
                            t16 = new Task16();
                            print(out, "Результат = " + String.join(", ", t16.pairsMax(pairs).stream().map((Integer i) -> i.toString()).toList())); 
                            break;
                        }
                        case 19: {
                            List<Integer> nums = new ArrayList<>();
                            for (int i = 0; i < 3; i++) {
                                print(out, "Введите число " + i);
                                nums.add(readNum(in));
                            }
                            t19 = new Task19();
                            print(out, "Результат = " + t19.listMin(nums)); 
                            break;
                        }
                        default: 
                            print(out, "Ну вот только непойми что не вводите!");
                    }
                    in.readLine();
                } catch (IOException e) {
                    print(out, "Все сломалось, ну и зачем было это делать?");
                } catch (NumberFormatException e) {
                    print(out, "И числа необходимо вводить НОРМАЛЬНЫЕ!");
                }
            }
        } catch (IOException e) {
            e.printStackTrace();
        }
    }

    public static void main(String[] args) {
        try {
            var server = new Server();
            server.run();
        } catch (IOException e) {
            e.printStackTrace();
        }
    }
}

package clientserver.server.tasks;

import java.util.List;

public class Task7 {

    private List<Dot> dots;

    public Task7(List<Dot> dots) {
        this.dots = dots;
    }

    // https://ru.wikipedia.org/wiki/%D0%A4%D0%BE%D1%80%D0%BC%D1%83%D0%BB%D0%B0_%D0%BF%D0%BB%D0%BE%D1%89%D0%B0%D0%B4%D0%B8_%D0%93%D0%B0%D1%83%D1%81%D1%81%D0%B0
    public double calcSquare() {
        int n = dots.size();
        double sum = 0;
        for (int i = 0; i < n - 1; i++) {
            sum += dots.get(i).x * dots.get(i + 1).y;
        }
        sum += dots.get(n - 1).x * dots.get(0).y;
        for (int i = 0; i < n - 1; i++) {
            sum += dots.get(i + 1).x * dots.get(i).y;
        }
        sum -= dots.get(0).x * dots.get(n - 1).y;
        return 1/2 * Math.abs(sum);
    }

    public double distanceBetweenDots(int i1, int i2) {
        Dot dot1 = dots.get(i1);
        Dot dot2 = dots.get(i2);
        return Math.sqrt(Math.pow(dot1.x - dot2.x, 2) + Math.pow(dot1.y - dot2.y, 2));
    }
}

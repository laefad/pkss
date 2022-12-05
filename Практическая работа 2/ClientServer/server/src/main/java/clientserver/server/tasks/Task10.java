package clientserver.server.tasks;

import java.util.List;
import java.util.stream.IntStream;

public class Task10 {

    private int N;

    public Task10(int N) {
        this.N = N;
    }

    public List<Integer> naturalList(int n) {
        return IntStream.range(1, n)
            .filter(x -> !String.valueOf(x).contains("0"))
            .filter(x -> String.valueOf(x)
                    .chars()
                    .map(i -> i - 48)
                    .distinct()
                    .filter(i -> x % i != 0)
                    .count() == 0
                )
            .boxed()
            .toList();
    }

    public boolean checkNumber(int i) {
        return naturalList(i + 1).stream().filter(I -> i == I).findFirst().isPresent();
    }

    public List<Integer> getNumbers() {
        return naturalList(N);
    }
}

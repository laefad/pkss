package clientserver.server.tasks;

import java.util.List;

public class Task16 {
    public List<Integer> pairsMax(List<List<Integer>> pairs) {
        return pairs.stream().map(
            (List<Integer> l) -> l.stream().max(Integer::compare).get()
        ).toList();
    }
}

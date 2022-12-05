package clientserver.server.tasks;

import java.util.List;

public class Task19 {
    public int listMin(List<Integer> pairs) {
        return pairs.stream().min(Integer::compare).get();
    }
}

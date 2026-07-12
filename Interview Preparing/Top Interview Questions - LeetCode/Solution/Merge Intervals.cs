public class Merge_Intervals
{
    public int[][] Merge(int[][] intervals)
    {
        int[] rngs = new int[20003];
        foreach (var r in intervals)
        {
            rngs[2 * r[0]]++;
            rngs[2 * r[1] + 1]--;
        }
        List<int[]> ret = [];
        int l = rngs[0] > 0 ? 0 : -1;
        for (int i = 1; i < rngs.Length; i++)
        {
            rngs[i] += rngs[i - 1];
            if (rngs[i] > 0 && l == -1)
                l = i / 2;

            if (l != -1 && rngs[i] == 0)
            {
                ret.Add([l, (i - 1) / 2]);
                l = -1;
            }
        }

        return ret.ToArray();
    }

    public int[][] Merge1(int[][] intervals)
    {
        Dictionary<int, int> lst = new();
        foreach (var r in intervals)
            if (lst.TryGetValue(r[0], out int l))
                lst[r[0]] = Math.Max(l, r[1]);
            else
                lst.Add(r[0], r[1]);
        
        List<int[]> ret = new();
        int reach = -1, cur = -1;
        for (int i = 0; i <= 1e4; i++)
        {
            if (lst.TryGetValue(i, out int l))
            {
                if (reach == -1) cur = i;
                reach = Math.Max(reach, l);
            }
            if (i == reach)
            {
                ret.Add([cur, reach]);
                cur = reach = -1;
            }
        }

        return ret.ToArray();
    }

    public int[][] Merge2(int[][] intervals)
    {
        Array.Sort(intervals, (l, r) => l[0].CompareTo(r[0]));
        List<int[]> ret = [intervals[0]];

        for (int i = 1; i < intervals.Length; i++)
            if (intervals[i][0] <= ret[^1][1])
                ret[^1][1] = Math.Max(ret[^1][1], intervals[i][1]);
            else
                ret.Add(intervals[i]);
        return ret.ToArray();
    }

    public int[][] Merge3(int[][] intervals)
    {
        Dictionary<int, int> lst = new();
        SortedSet<int> cands = new();
        foreach (var r in intervals)
        {
            if (lst.TryGetValue(r[0], out int l))
                lst[r[0]] = Math.Max(l, r[1]);
            else
                lst.Add(r[0], r[1]);
            cands.Add(r[0]);
            cands.Add(r[1]);
        }

        List<int[]> ret = new();
        int reach = -1, cur = -1;
        foreach (var i in cands)
        {
            if (lst.TryGetValue(i, out int l))
            {
                if (reach == -1) cur = i;
                reach = Math.Max(reach, l);
            }
            if (i == reach)
            {
                ret.Add([cur, reach]);
                cur = reach = -1;
            }
        }

        return ret.ToArray();
    }
}


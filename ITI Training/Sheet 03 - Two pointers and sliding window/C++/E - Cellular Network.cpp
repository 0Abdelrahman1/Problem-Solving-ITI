//#pragma GCC optimize ("O3", "no-stack-protector", "omit-frame-pointer", "tree-parallelize-loops=4", "profile-generate", "profile-use", "prefetch-loop-arrays", "ipa-cp", "ipa-sra", "ivopts", "loop-interchange")
#include <bits/stdc++.h>
using namespace std;

#ifdef LOCAL // in cmake add_definitions(-DLOCAL)
#include "Debug.cpp"
#define FileI(fileName)
#define FileO(fileName)
#define FastIO
#else
#define FastIO ios_base::sync_with_stdio(0); cin.tie(0); cerr.tie(0); cout.tie(0);
#define FileI(fileName) freopen(fileName, "r", stdin)
#define FileO(fileName) freopen(fileName, "w", stdout)
#define debug(...) void()
#define __print(...) void()
#define Time(i, x...) x
#endif
#define un unsigned
#define ld long double
#define LL long long
#define int LL
#define allc(x) begin(x), end(x)
#define rallc(x) rbegin(x), rend(x)
#define all(x,i,j) begin(x) + i, begin(x) + j
#define Ceil(x, y) (LL)((((x) ^ (y)) > 0) ? ((x) + (y) + array{-1, 1}[x < 0]) / (y) : (x) / (y))
#define endl(IF) cout << (IF ? "\n" : "")
#define Test int TC, _(0); cin >> TC; while(_++ < TC && endl(_ - 1))

void Solve()
{
    int n, m; cin >> n >> m;
    deque<int> a(n), b(m);
    for(auto& x : a) cin >> x;
    for(auto& x : b) cin >> x;
    b.push_front(-1e15);
    b.push_back(1e15);
    sort(allc(a));
    sort(allc(b));

    int i = 0, j = -1, ans = 0;
    while (i < n)
    {
        while (j + 1 < m + 2 && b[j + 1] <= a[i]) j++;
        ans = max(ans, min(a[i] - b[j], b[j + 1] - a[i]));
        i++;
    }
    cout << ans;
}

signed main()
{
    FastIO
    Solve();

    return 0;
}

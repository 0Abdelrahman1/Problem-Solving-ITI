// https://codeforces.com/group/iQQI5TD7io/contest/665354/problem/D

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
    vector<LL> a(m + 2);
    for (int i = 0, l, r; i < n; i++)
        cin >> l >> r, a[l]++, a[r + 1]--;
    partial_sum(allc(a), a.begin());
    LL ans = 0;
    for (int i = 1; i <= m; i++)
        if (!a[i])
            ans++;
    cout << ans << "\n";
    for (int i = 1; i <= m; i++)
        if (!a[i])
            cout << i << " ";
}

signed main()
{
    FastIO
    Solve();

    return 0;
}

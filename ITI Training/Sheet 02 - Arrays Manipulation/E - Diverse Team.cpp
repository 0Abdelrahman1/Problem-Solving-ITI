// https://codeforces.com/group/iQQI5TD7io/contest/665354/problem/E

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
    int n, k; cin >> n >> k;
    set<LL> s;
    vector<LL> ans;
    for (int i = 0, x; i < n && s.size() < k; i++)
        if (cin >> x; s.insert(x).second)
            ans.push_back(i + 1);

    if (s.size() != k)
        return cout << "NO", void();

    cout << "YES\n";
    for (auto i : ans)
        cout << i << " ";
}

signed main()
{
    FastIO
    Solve();

    return 0;
}

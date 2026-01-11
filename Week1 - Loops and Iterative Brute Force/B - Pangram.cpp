// https://codeforces.com/group/iQQI5TD7io/contest/663127/problem/B

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
    int n; cin >> n;
    string s; cin >> s;
    for (auto& x : s) x = tolower(x);
    sort(allc(s));
    s.erase(unique(allc(s)), s.end());
    if (s.size() == 26)
        cout << "YES";
    else
        cout << "NO";
}

signed main()
{
    FastIO
    Solve();

    return 0;
}

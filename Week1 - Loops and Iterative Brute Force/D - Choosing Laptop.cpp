// https://codeforces.com/group/iQQI5TD7io/contest/663127/problem/D

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
    vector<array<int, 5>> v(n), vv;
    for (int i = 0; auto& a : v)
        cin >> a[1] >> a[2] >> a[3] >> a[0], a[4] = ++i;

    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++)
            if (i != j)
                if (v[i][1] < v[j][1] && v[i][2] < v[j][2] && v[i][3] < v[j][3])
                    goto p;
        vv.push_back(v[i]);
        p:;
    }
    sort(allc(vv));
    cout << vv[0][4];
}

signed main()
{
    FastIO
    Solve();

    return 0;
}

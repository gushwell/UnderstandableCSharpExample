// ■リスト12-16：Selectメソッドを使ったコード（1）
var nums = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
var query = nums.Select(x => x * 2);  // 各要素を2倍する
foreach (var n in query)
{
    Console.WriteLine(n);
}

// ■リスト9-27：テキストファイルを作成する
var lines = new string[]
{
    "祇園精舍の鐘の声、諸行無常の響きあり。",
    "娑羅双樹の花の色、盛者必衰の理をあらはす。",
    "奢れる人も久しからず、ただ春の夜の夢のごとし。",
    "猛き者もつひにはほろびぬ、ひとへに風の前の塵に同じ。"
};
File.WriteAllLines("C:\\temp\\祇園精舎.txt", lines);

<Query Kind="Statements" />

Dictionary<string, string>? ReplaceQuotes(string text)
{
    //  记录被替换的引号内容的键与内容
    var rst = new Dictionary<string, string>();
    var count = 0;  //  引号计数
    var lastPosition = -1;  //  上一个开引号的位置, -1 表示上一个引号是闭引号
    var len = text.Length;  //  源文本串长度
    for (var i = 0; i < len; i++)
    {
        if (text[i].Equals('"'))
        {
            if (lastPosition == -1) lastPosition = i;
            else
            {
                var key = $"$$_Quotes_{++count}_$$";    //  按键数量替换
                var value = text[lastPosition..(i + 1)];    //  替换的文本
                var delta = key.Length - value.Length;  //  长度差值
                len += delta;   //  总长度设为替换后的总长度
                text = $"{text[0..lastPosition]}{key}{text[(i + 1)..]}";    //  替换
                rst.Add(key, value);  //  添加键与替换的文本
                i += delta; //  指针归位
                lastPosition = -1;  //  设为闭引号
            }
        }
    }
	rst.Add("SourceString", text);
    return rst;
}

var cmd = """
--send "Hello, World!" --to 127.0.0.1:6666 --callback "no value"
""";
ReplaceQuotes(cmd).Dump();

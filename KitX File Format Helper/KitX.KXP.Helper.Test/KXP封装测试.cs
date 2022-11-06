using KitX.Web.Rules;
using System.Text.Json;

namespace KitX.KXP.Helper.Test
{
    [TestClass]
    public class KXP封装测试
    {
        [TestMethod]
        public void 基准测试()
        {
            string baseDir = @"D:\tmp\";
            Encoder encoder = new(new()
                {
                    $"{baseDir}KitX.Contract.CSharp.dll",
                    $"{baseDir}TestPlugin.WPF.Core.deps.json",
                    $"{baseDir}TestPlugin.WPF.Core.dll"
                },
                JsonSerializer.Serialize(new LoaderStruct()
                {
                    LoaderName = "KitX.Loader.WPF.Core",
                    LoaderVersion = "v1.0.0",
                    LoaderFramework = "WPF.Core",
                    LoaderLanguage = "C#",
                    LoaderRunType = LoaderStruct.RunType.Desktop,
                    SupportOS = new()
                    {
                        OperatingSystems.Windows
                    }
                }),
                JsonSerializer.Serialize(new PluginStruct()
                {
                    AuthorLink = "AuthorLink",
                    AuthorName = "AuthorName",
                    ComplexDescription = new()
                    {
                        { "zh-cn", "ComplexDescription" }
                    },
                    DisplayName = new()
                    {
                        { "zh-cn", "显示名称" },
                        { "zh-cnt", "顯示名稱" },
                        { "en-us", "DisplayName" },
                    },
                    Functions = new List<Function>()
                    {
                        new Function()
                        {
                            DisplayNames = new Dictionary<string, string>()
                            {
                                { "zh-cn", "功能名称" },
                                { "en-us", "FunctionName" }
                            },
                            Parameters = new Dictionary<Dictionary<string, string>, string>()
                            {
                                {
                                    new Dictionary<string, string>()
                                    {
                                        { "zh-cn", "参数1" },
                                        { "en-us", "Parameter1" }
                                    },
                                    "string"
                                }
                            },
                            HasAppendParameters = false,
                            ReturnValueType = "void"
                        }
                    },
                    IconInBase64 = "IconInBase64",
                    IsMarketVersion = false,
                    LastUpdateDate = DateTime.Now,
                    Name = "Name",
                    PublishDate = DateTime.Now,
                    PublisherLink = "PublisherLink",
                    PublisherName = "PublisherName",
                    SimpleDescription = new()
                    {
                        { "zh-cn", "SimpleDescription" }
                    },
                    Tags = new(),
                    TotalDescriptionInMarkdown = new()
                    {
                        { "zh-cn", "TotalDescriptionInMarkdown" }
                    },
                    Version = "Version",
                    RootStartupFileName = "RootStartupFileName"
                })
            );
            encoder.Encode(@"D:\tmp\", @"D:\tmp\", @"test");
        }
    }
}

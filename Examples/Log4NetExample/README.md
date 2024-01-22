# log4net 使用方法

以下是使用log4net的步驟：

1. 在 Visual Studio 中，選擇 Tools > NuGet Package Manager > Manage NuGet Packages for Solution，並搜尋 log4net。選擇要安裝的專案，然後按 Install 按鈕。安裝完成後，Solution Explorer 中會出現新的文件 packages.config，可以查看安裝的 log4net 版本。

2. 創建 log4net.config 配置文件。在 Solution Explorer 中，對 solution 按右鍵，然後選擇 Add > New Item，選擇 Application Configuration File，將文件名改為 log4net.config。對 log4net.config 文件按右鍵，然後選擇 Properties，將 Copy to Output Directory 修改為 Copy if newer。

3. 配置 log4net.config 文件。打開 log4net.config 文件，並修改為以下內容：

```xml
<?xml version="1.0" encoding="utf-8" ?>
<configuration>
	<log4net>
		<!-- 控制台日誌配置 -->
		<appender name="Console" type="log4net.Appender.ConsoleAppender">
			<!-- 日誌輸出格式 -->
			<layout type="log4net.Layout.PatternLayout">
				<conversionPattern value="%5level [%thread] (%file:%line) - %message%newline" />
			</layout>
		</appender>

		<!-- 文件存儲日誌配置 -->
		<appender name="RollingFile" type="log4net.Appender.RollingFileAppender">
			<!-- 保存文件的名稱 -->
			<file value="D:\\log.log" />
			<appendToFile value="true" />
			<!-- 文件的編碼方式 -->
			<param name="Encoding" value="UTF-8"/>
			<!-- 每個文件的大小 -->
			<maximumFileSize value="100KB" />
			<!-- 保存文件數量 -->
			<maxSizeRollBackups value="2" />
			<!-- 日誌輸出格式 -->
			<layout type="log4net.Layout.PatternLayout">
				<conversionPattern value="%level %thread %logger - %message%newline" />
			</layout>
		</appender>

		<root>
			<level value="ALL" />
			<appender-ref ref="Console" />
			<appender-ref ref="RollingFile" />
		</root>
	</log4net>
</configuration>
```

4. 配置 AssemblyInfo.cs。打開 Project 的 Properties\AssemblyInfo.cs，並在最後將 log4net.config 設置給 log4net：

``` cs
// 指定log4net的配置文件
[assembly: log4net.Config.XmlConfigurator(ConfigFile = "log4net.config", Watch = true)]
```

# log4net有哪些日誌級別？

log4net提供了以下7個日誌級別，按嚴重性遞減排序：

1. FATAL: 指出每個嚴重的錯誤事件，可能會導致應用程序中止。
2. ERROR: 指出運行時錯誤事件，但不會嚴重到應用程序不能繼續運行。
3. WARN: 表示潛在的問題，它不會影響系統的運行。
4. INFO: 指出系統的運行情況。
5. DEBUG: 指出詳細的系統運行情況，主要用於開發和調試。
6. TRACE: 提供比DEBUG更詳細的信息，主要用於開發和調試。
7. ALL: 最低等級，用於打開所有日誌記錄。
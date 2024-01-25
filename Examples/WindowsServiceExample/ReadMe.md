# 安裝 MyService的方式

1. 以 系統管理員 運行 Developer Command Prompt for VS2019

2. 切換至本範例的bin\Debug路徑

``` sh
cd D:\Ray\MyProjects\LearnCSharp\Examples\WindowsServiceExample\bin\Debug
```

3. 安裝

``` sh
installutil WindowsServiceExample.exe
```

4. 在 `服務` 將 MyService啟動

5. 卸載安裝

``` sg
installutil /u WindowsServiceExample.exe
```

# 測試方式

在bin\Debug目錄底下會產生log			共3個資料夾
						|--debug
						|--error
						|--info
在 info 資料夾下會出現 info_2024-01-25.log 文件

本範例參考網路 [使用C#创建安装Windows服务程序(干货)](https://blog.csdn.net/2301_79251107/article/details/132339427)


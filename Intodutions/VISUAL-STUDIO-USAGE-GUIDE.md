# Через скачивание архива напрямую
Скачайте архив и разархивируйте его в любую папку. Подключите библиотеку через `<project>`->`Add`->`Reference`. Используйте следующий шаблон кода для написания программы через `ABCNET` на `C#`:

# Через пакетный менеджер `NuGet`
![Visual Studio - NuGet package installation](https://sun9-23.userapi.com/c858232/v858232025/15cb70/z-NsdL6lZTk.jpg)
Установите `NuGet-пакет` [`NETMouseProjectsOrganization.ABCNET`](https://www.nuget.org/packages/NETMouseProjectsOrganization.ABCNET/0.5.0.3) через `<project>`->`Manage NuGet Packages`->`Browse`.

### Рекомендуемый шаблон кода
Используйте следующий шаблон кода для написания программы через `ABCNET` на `C#`:
```Csharp
using ABCNET.Utils;
using ABCNET.Extensions;

namespace TestProgram
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // code here
        }
    }
}
```

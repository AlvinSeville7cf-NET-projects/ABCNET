# ABCNET
## Краткое описание
`ABCNET` - альтернатива модулю [`PABCSystem`](https://drive.google.com/open?id=1s2YX42HM8fKtah6blWmMkNZ9Z8Kfxn_BW4QSH6JY11o) для всего `NET`. Является чем-то средним между [`PABCSystem`](https://drive.google.com/open?id=1s2YX42HM8fKtah6blWmMkNZ9Z8Kfxn_BW4QSH6JY11o) и [`NETSquirrel`](https://github.com/NETMouse-projects/NETSquirrel). Ориентирована на русскоязычную аудиторию.

## Минимальные требования
`NET Framework 4.0`

# Организация проекта
- [Alvin Seville](https://github.com/Alvin-Seville) (руководитель проекта и основатель `NETMouse-projects`)
- [ProMix0](https://github.com/ProMix0) (главный разработчик)

# Цель проекта
Обеспечить пользователей [`PascalABC.NET 3.5.1.2277`](https://drive.google.com/open?id=1eHzHpHw7SYTCwefaxYPr4QbsB1bf6M41) (другие версии не поддерживаются нашим проектом) [`PABCSystem`](https://drive.google.com/open?id=1s2YX42HM8fKtah6blWmMkNZ9Z8Kfxn_BW4QSH6JY11o)-подобным функционалом за пределами данного языка. Но, в то же время, не предоставлять множество обёрток для работы с типами `NET`, а стимулировать обучающихся изучать данную платформу.

Выучите одну библиотеку один раз и используйте её на любом `NET`-языке!

# Принципы проекта
- Оптимизация важна
- Простота функционала
- Избегание использования специфических возможностей компиляторов

# Варианты использования
## PascalABC.NET
Не используйте данную `IDE` для крупных проектов.

### Через скачивание архива напрямую
Скачайте архив `ABCNET.rar` и разархивируйте его в папку с программой (не в директорию [`PascalABC.NET`](https://drive.google.com/open?id=1eHzHpHw7SYTCwefaxYPr4QbsB1bf6M41) из `Program Files (x86)`).

### Через пакетный менеджер `NuGet` в режиме проекта
![PascalABC.NET - NuGet package installation](https://sun9-29.userapi.com/c204828/v204828716/488d3/eFcKpAIwcP8.jpg)
Установите `NuGet-пакет` [`NETMouseProjectsOrganization.ABCNET`](https://www.nuget.org/packages/NETMouseProjectsOrganization.ABCNET/0.0.5) через `Подключённые сборки`->`Добавить сборку`->`NuGet`.

### Рекомендуемый шаблон кода
Используйте следующий шаблон кода для написания программы через `ABCNET` в [`PascalABC.NET`](https://drive.google.com/open?id=1eHzHpHw7SYTCwefaxYPr4QbsB1bf6M41):
```pascal
{$reference ABCNET.dll} // Уберите данную строку, если используйте ABCNET в режиме проекта и подключили её как NuGet-пакет.
uses ABCNET.Utils;
uses ABCNET.Extensions;
begin
  // code here
end.
```

## Visual Studio 2019
### Через скачивание архива напрямую
Скачайте архив и разархивируйте его в любую папку. Подключите библиотеку через `<project>`->`Add`->`Reference`. Используйте следующий шаблон кода для написания программы через `ABCNET` на `C#`:

### Через пакетный менеджер `NuGet`
![Visual Studio - NuGet package installation](https://sun9-23.userapi.com/c858232/v858232025/15cb70/z-NsdL6lZTk.jpg)
Установите `NuGet-пакет` [`NETMouseProjectsOrganization.ABCNET`](https://www.nuget.org/packages/NETMouseProjectsOrganization.ABCNET/0.0.5) через `<project>`->`Manage NuGet Packages`->`Browse`.

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

# Совместимость с похожими продуктами
## С PABCSystem
Полная совместимость с [`PABCSystem`](https://drive.google.com/open?id=1s2YX42HM8fKtah6blWmMkNZ9Z8Kfxn_BW4QSH6JY11o) не гарантируется. Функционал хоть и похожий, но отличается и по-разному распределён. Единственное место, в котором гарантируется полная совместимость (до `v0.5.0`, не включая её) - класс `ABCNET.Utils.PABCSystem`, который предоставляет часть функционала [`PABCSystem`](https://drive.google.com/open?id=1s2YX42HM8fKtah6blWmMkNZ9Z8Kfxn_BW4QSH6JY11o) в его изначальном виде. На данный момент доступны лишь короткие функции `Lst`, `LLst`, `HSet`, `SSet`, `Dict`, `KV`.

## С NETSquirrel
Полная совместимость с [`NETSquirrel`](https://github.com/NETMouse-projects/NETSquirrel) не гарантируется.

# Перенос кода на ABCNET
## С PABCSystem
Как перенести код с [`PABCSystem`](https://drive.google.com/open?id=1s2YX42HM8fKtah6blWmMkNZ9Z8Kfxn_BW4QSH6JY11o) на `ABCNET` смотрите [здесь](http://netmouseprojects.rusff.ru/viewtopic.php?id=10).

# Дополнительные разработки
- [Образцы кода](https://drive.google.com/open?id=1B_TWBw_gMT4meQXyrBhWiivk7KTrUhti) [Замените одноимённый файл данным в директории `C:\Program Files (x86)\PascalABC.NET`]

# Похожие продукты от NETMouse-projects
- [`NETSquirrel`](https://github.com/NETMouse-projects/NETSquirrel)
- [`PascalABCSquirrel`](https://github.com/NETMouse-projects/PascalABCSquirrel)

# Для разработчиков
## Жизненный цикл ABCNET
Любая версия должна содержать не более 20 `Issue`.
- Первые 5 `Issue` затрагивают `API` библиотеки (по их количеству ведётся версионирование).
- Вторые 5 `Issue` (необязательные) затрагивают исправления `API` библиотеки (`bug-small` и `bug-critical`).
- Третьи 5 `Issue` (необязательные) затрагивают примеры для `API` библиотеки.
- Четвёртые 5 `Issue` (необязательные) затрагивают внутренние изменения, которые не видны пользователям.

Формат версии: `x.y.z`, где:
- `x` - major-версия, принимает любое неотрицательное значение.
- `y` - minor-версия, принимает значение 0 и 5.
- `z` - количество закрытых Issue, касающихся `API` библиотеки.

Каждая major-версия закрывает в сумме ровно 50 `Issue` по `API`-библиотеки и состоит из двух minor-версий. Каждая сборка minor-версии закрывает в сумме ровно 5 `Issue` по `API`-библиотеки.

# Инструменты разработки
При разработке была использована [`Visual Studio 2019`](https://visualstudio.microsoft.com/vs/) и система контроля версий [`Git`](https://git-scm.com/download). Не используйте `GitHub Desktop` при разработке данного продукта.

Для автоматизации сборки версий применялся `Batch Script`.

Для выполнения простых и рутинных задач в репозитории на `GitHub` использованы [`GitHub Actions`](https://help.github.com/en/actions/automating-your-workflow-with-github-actions).

![GitHub Actions](https://sun9-53.userapi.com/c857536/v857536261/169dac/lGIxo4kVWoc.jpg)

----
Если Вы не знакомы с `GitHub`, но Вам есть что сообщить или предложить нам, пожалуйста, воспользуйтесь одной из следующих ссылок: [`Yandex forms`](https://forms.yandex.ru/u/5e1de81b0733df0bb13408e3/) | [`Google Groups`](https://groups.google.com/forum/#!forum/netmouse-projects) | [`Official Forum`](http://netmouseprojects.rusff.ru/viewforum.php?id=5)



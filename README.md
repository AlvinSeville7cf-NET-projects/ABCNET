<!--
  Используйте данный ReadMe.md как шаблон для русскоязычных проектов в NETMouse projects. Форматирование в ReadMe.md, сделанных на основе данного должно точно соответствовать текущему. Любые отступления от этого - не допускаются.

  Удалять комментарии из ReadMe.md запрещается - они могут быть полезны редакторам.

  Некоторые оговорки по поводу оформления:
  - По умолчанию используются ненумерованные списки, если не оговорено иное
    - По умолчанию пояснения для элементов списка запрещены, если не оговорено иное
    - Если в списке один элемент, то можно его писать без списка, если не оговорено иное
    - Пояснения для элементов списка даются в скобках, если не оговорено иное
  - Если имеется программный продукт X, то везде где встречается его названия должна быть ссыллка на его официальную страницу, либо иную другую для его преобретения. Такие ссылки должны быть везде и быть везде одинаковыми.
-->
# ABCNET
## Краткое описание
<!--
  Краткое описание продукта с возможными ссылками на похожие и указание аудитории, на которую он рассчитан.
-->
`ABCNET` - альтернатива модулю [`PABCSystem`](https://drive.google.com/open?id=1s2YX42HM8fKtah6blWmMkNZ9Z8Kfxn_BW4QSH6JY11o) для всего `NET`. Является чем-то средним между [`PABCSystem`](https://drive.google.com/open?id=1s2YX42HM8fKtah6blWmMkNZ9Z8Kfxn_BW4QSH6JY11o) и [`NETSquirrel`](https://github.com/NETMouse-projects/NETSquirrel). Ориентирована на русскоязычную аудиторию. Более подробно об `ABCNET` можно узнать в [презентации](https://github.com/NETMouse-projects/ABCNET/tree/master/NETMouse%20-%20.NET%20release/Presentations).

## Минимальные требования
<!--
  Требуемая версия framework'а и необходимые зависимости.
-->
`NET Framework 4.0`

# Организация проекта
<!--
  Участники команды, принявшие участие в работе над проектом. В скобках - роль в команде.
-->
- [Alvin Seville](https://github.com/Alvin-Seville) (руководитель проекта и основатель `NETMouse-projects`)
- [ProMix0](https://github.com/ProMix0) (главный разработчик)

# Цель проекта
<!--
  Краткое описание цели проекта. В конце - возможен лозунг.
-->
Обеспечить пользователей [`PascalABC.NET 3.5.1.2277`](https://drive.google.com/open?id=1eHzHpHw7SYTCwefaxYPr4QbsB1bf6M41) (другие версии не поддерживаются нашим проектом) [`PABCSystem`](https://drive.google.com/open?id=1s2YX42HM8fKtah6blWmMkNZ9Z8Kfxn_BW4QSH6JY11o)-подобным функционалом за пределами данного языка. Но, в то же время, не предоставлять множество обёрток для работы с типами `NET`, а стимулировать обучающихся изучать данную платформу.

Выучите одну библиотеку один раз и используйте её на любом `NET`-языке!

# Принципы проекта
<!--
  Принципы проекта.
-->
- Оптимизация важна
- Простота функционала
- Избегание использования специфических возможностей компиляторов

# Варианты использования
## PascalABC.NET
### Через скачивание архива напрямую
Скачайте архив `ABCNET.rar` и разархивируйте его в папку с программой (не в директорию [`PascalABC.NET`](https://drive.google.com/open?id=1eHzHpHw7SYTCwefaxYPr4QbsB1bf6M41) из `Program Files (x86)`).

### Через пакетный менеджер `NuGet` в режиме проекта
![PascalABC.NET - NuGet package installation](https://sun9-29.userapi.com/c204828/v204828716/488d3/eFcKpAIwcP8.jpg)
Установите `NuGet-пакет` [`NETMouseProjectsOrganization.ABCNET`](https://www.nuget.org/packages/NETMouseProjectsOrganization.ABCNET/0.5.0.3) через `Подключённые сборки`->`Добавить сборку`->`NuGet`.

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

# Порты
<!--
  Список проектов-портов данного.
-->
- [`ABCPy`](https://github.com/NETMouse-projects/ABCPy) (для `Python`)
- [`ABCJava`](https://github.com/NETMouse-projects/ABCJava) (для `Java`)
- [`ABCCPlusPlus`](https://github.com/NETMouse-projects/ABCCPlusPlus) (для `C++`)

# Совместимость с похожими продуктами
<!--
  Краткое описание совместимости с похожими продуктами, указанными в разделе "Похожие продукты от NETMouse-projects".
-->
## С PABCSystem
Полная совместимость с [`PABCSystem`](https://drive.google.com/open?id=1s2YX42HM8fKtah6blWmMkNZ9Z8Kfxn_BW4QSH6JY11o) не гарантируется. Функционал хоть и похожий, но отличается и по-разному распределён. Единственное место, в котором гарантируется полная совместимость (до `v0.5.0`, не включая её) - класс `ABCNET.Utils.PABCSystem`, который предоставляет часть функционала [`PABCSystem`](https://drive.google.com/open?id=1s2YX42HM8fKtah6blWmMkNZ9Z8Kfxn_BW4QSH6JY11o) в его изначальном виде. На данный момент доступны лишь короткие функции `Lst`, `LLst`, `HSet`, `SSet`, `Dict`, `KV`.

## С NETSquirrel
Полная совместимость с [`NETSquirrel`](https://github.com/NETMouse-projects/NETSquirrel) не гарантируется.

# Дополнительные разработки
- [Образцы кода](https://drive.google.com/open?id=1B_TWBw_gMT4meQXyrBhWiivk7KTrUhti) [Замените одноимённый файл данным в директории `C:\Program Files (x86)\PascalABC.NET`]

# Похожие продукты от NETMouse-projects
<!--
  Список похожих проктов NETMouse projects.
-->
- [`NETSquirrel`](https://github.com/NETMouse-projects/NETSquirrel)
- [`PascalABCSquirrel`](https://github.com/NETMouse-projects/PascalABCSquirrel)

# Для разработчиков
## Жизненный цикл ABCNET
<!--
  Описание правил разработки проекта. Сначала - разбиение на версии, потом формат версий.
-->
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
## Обязательные инструменты
<!--
  Описание обязательных инструментов разработки для проекта.
-->
- `IDE` - [`Visual Studio 2019`](https://visualstudio.microsoft.com/vs/), [`Repl.it`](https://repl.it/)
- Декомпилятор - [`dotPeek`](https://www.jetbrains.com/decompiler/)
- `VCS` - [`Git`](https://git-scm.com/download) с [`Git Bash`](https://git-scm.com/download)
- Язык автоматизации - [`Bash`](https://www.tldp.org/LDP/Bash-Beginners-Guide/html/)

## Рекомендуемые инструменты
<!--
  Описание рекомендуемых инструментов разработки для проекта.
-->
- `IDE` - [`myCompiler`](https://www.mycompiler.io/)

----
Если Вы не знакомы с `GitHub`, но Вам есть что сообщить или предложить нам, пожалуйста, воспользуйтесь [`Yandex forms`](https://forms.yandex.ru/u/5e1de81b0733df0bb13408e3/). 

[![Discord](https://user-images.githubusercontent.com/42812113/76321598-4c9aa680-62f3-11ea-9c4c-10b70b0a17da.png)](https://discord.gg/j8Xf6Me)

# Крестики-нолики на Godot с C#

Простая игра "Крестики-нолики" с различными режимами игры, разработанная на движке Godot с использованием языка C#.

## Возможности

- Игра против другого игрока (PvP)
- Игра против компьютера (PvE)
- Режим компьютер против компьютера (EvE)
- Подготовка к сетевой игре (в разработке)

## Требования

- Godot Engine 4.x
- .NET SDK 6.0 или выше
- Mono (для разработки на C# в Godot)

## Установка и запуск

1. Клонируйте репозиторий:
   ```
   git clone https://github.com/yourusername/tic-tac-toe.git
   cd tic-tac-toe
   ```

2. Откройте проект в Godot Engine:
   - Запустите Godot Engine
   - Нажмите "Импорт"
   - Найдите и выберите папку проекта
   - Нажмите "Открыть"

3. Запустите игру:
   - Нажмите кнопку "Запустить" (F5) в редакторе Godot

## Структура проекта

- `Scripts/` - C# скрипты
  - `Cell.cs` - Класс для ячейки игрового поля
  - `GameBoard.cs` - Класс для игрового поля
  - `GameManager.cs` - Класс для управления игрой
  - `AIPlayer.cs` - Класс для ИИ противника

## Как создать сцену игры

1. Создайте новую сцену с корневым узлом типа `Node`
2. Добавьте узел `Node2D` и назовите его "GameBoard"
3. Добавьте узел `GridContainer` внутрь GameBoard и назовите его "Grid"
   - Установите свойства Grid: Columns = 3, Size = (300, 300)
4. Добавьте 9 узлов `TextureButton` внутрь Grid и назовите их "Cell_0_0", "Cell_0_1", ..., "Cell_2_2"
   - Установите для каждой ячейки скрипт Cell.cs
5. Добавьте узел `Control` и назовите его "UI"
6. Добавьте внутрь UI:
   - `Label` с именем "StatusLabel" для отображения статуса игры
   - `Button` с именем "RestartButton" для перезапуска игры
   - `OptionButton` с именем "GameMode" для выбора режима игры
7. Добавьте узлы `AIPlayer` с именами "AIPlayer1" и "AIPlayer2"
8. Установите для корневого узла скрипт GameManager.cs
9. Установите для узла GameBoard скрипт GameBoard.cs

## Настройка внешнего вида

1. Создайте или найдите спрайты для X и O
2. Добавьте их в проект в папку "Assets"
3. Настройте текстуры для ячеек в методе `UpdateCellAppearance()` класса Cell

## Дальнейшее развитие

- Добавление сетевой игры
- Улучшение ИИ (разные уровни сложности)
- Добавление звуковых эффектов
- Улучшение визуального оформления

## Лицензия

MIT 
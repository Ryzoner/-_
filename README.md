# Пояснительная записка

## Название проекта: Web-приложение для взаимодествия с базой данных волонтеров и мероприятий СКИВ

### Инструкция по развертыванию проекта

1. Установка необходимых инструментов

Для начала работы с программой необходимы установленные:
* .NET Core SDK (https://dotnet.microsoft.com/download) 
* Git (https://git-scm.com/downloads). 

Для проверки, установлены ли они, можно ввести в командную строку команды:
```
dotnet --version
git --version
```

Пример того, что выведут команды: 
```
> dotnet --version
8.0.102
> git --version
git version 2.38.0.windows.1
```

2. Клонирование репозитория

Клонируем репозиторий проекта на ваш компьютер с помощью команды:
```
git clone https://github.com/Ryzoner/SKIV-Volunteers
```

3. Сборка проекта.

Переходим в каталог склонированного проекта:
```
cd SKIV-Volunteers
```
Выполняем сборку проекта с помощью команды:
```
dotnet build
```
4. Запуск проекта

После успешной сборки запускаем проект командой:
```
dotnet run
```
Открываем браузер и переходим по адресу https://localhost:5134, чтобы начать использовать приложения.

### Краткое описание проекта:
Данный проект представляет собой web-приложение, которое обеспечивает удобное управление базой данных о волонтерах СКИВ и мероприятиях, в которых участвует данный корпус. Приложение позволяет добавлять новых волонтеров и мероприятия, просматривать и редактировать информацию о них, а также осуществлять автоматический подсчет рейтинга волонтеров за их участие в мероприятиях.
СКИВ расшифровывается как Самарский Корпус Инклюзивных Волонтеров. Их основная деятельность заключаетсч в создании доступных мероприятий для людей с инвалидностью.

### Анализ проблемы:
Актуальность данного проекта обусловлена необходимостью эффективного управления данными о волонтерском корпусе и организации мероприятий. Ручное ведение таких данных часто вызывает проблемы с точностью, актуальностью и доступностью информации. Моё решение направлено на устранение этих проблем путем автоматизации процессов управления данными.

### Цели и задачи проекта:
Целью проекта является создание удобного и функционального web-приложения для управления данными о волонтерах и мероприятиях. Основные задачи включают в себя разработку интерфейса для взаимодействия с базой данных, реализацию функций добавления, редактирования и просмотра данных, а также разработку алгоритма для автоматического подсчета рейтинга волонтеров.

### Гипотеза исследования:
Гипотеза моего проекта заключается в том, что эффективное управление данными о волонтерах и мероприятиях через web-приложение позволит повысить прозрачность и эффективность работы СКИВ.

### Этапы работы:
- Анализ требований и проектирование базы данных.
- Разработка пользовательского интерфейса web-приложения.
- Реализация функций добавления, редактирования и просмотра данных.
- Разработка алгоритма для подсчета рейтинга волонтеров.
- Тестирование и отладка приложения.
- Релиз и внедрение.

### Описание практических разработок:
В результате моего проекта будет создано web-приложение, доступное по адресу URL, которое позволит управлять данными о волонтерах и мероприятиях СКИВ. Пользователь сможет легко добавлять новых волонтеров и мероприятия, редактировать информацию о них и просматривать рейтинг волонтеров за участие в мероприятиях.

### Выводы:
Разработка web-приложения для управления данными о волонтерах СКИВ и мероприятиях представляет собой важный шаг к повышению эффективности работы таких организаций. Наше приложение позволит сократить время и усилия, затрачиваемые на управление данными, и повысит прозрачность и доступность информации для всех участников СКИВ.

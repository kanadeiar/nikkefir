namespace nikkefir.Data;

public class ImagesData
{
    public static IEnumerable<Image> GetImages()
    {
        var i = 1;
        var images = new Image[]
        {
            #region 2022
            new Image
            {
                Id = i++,
                Date = new DateTime(2022, 03, 02),
                Name = "Мечта",
                Path = "images/2022/Мечта.png",
            },
            new Image
            {
                Id = i++,
                Date = new DateTime(2022, 03, 01),
                Name = "Идеал",
                Path = "images/2022/Идеал.png",
            },
            #endregion

            #region 2021
            new Image
            {
                Id = i++,
                Date = new DateTime(2021, 12, 30),
                Name = "На работу",
                Path = "images/2021/На работу.jpg",
            },
            new Image
            {
                Id = i++,
                Date = new DateTime(2021, 12, 29),
                Name = "С работы",
                Path = "images/2021/С работы.jpg",
            },
            new Image
            {
                Id = i++,
                Date = new DateTime(2021, 12, 28),
                Name = "Инвентаризация",
                Path = "images/2021/Инвентаризация.png",
            },
            new Image
            {
                Id = i++,
                Date = new DateTime(2021, 12, 27),
                Name = "Сводка",
                Path = "images/2021/Сводка.png",
            },
            new Image
            {
                Id = i++,
                Date = new DateTime(2021, 12, 26),
                Name = "Счастье",
                Path = "images/2021/Счастье.png",
            },
            new Image
            {
                Id = i++,
                Date = new DateTime(2021, 12, 25),
                Name = "Рай",
                Path = "images/2021/Рай.jpg",
            },
            new Image
            {
                Id = i++,
                Date = new DateTime(2021, 12, 25),
                Name = "Встреча",
                Path = "images/2021/Встреча.jpg",
            },
            new Image
            {
                Id = i++,
                Date = new DateTime(2021, 12, 25),
                Name = "61-я",
                Path = "images/2021/61.png",
            },
            new Image
            {
                Id = i++,
                Date = new DateTime(2021, 12, 25),
                Name = "Автоматизация",
                Path = "images/2021/Автоматизация.jpg",
            },
            new Image
            {
                Id = i++,
                Date = new DateTime(2021, 12, 25),
                Name = "Домовой",
                Path = "images/2021/Домовой.jpg",
            },
            new Image
            {
                Id = i++,
                Date = new DateTime(2021, 12, 20),
                Name = "Запой",
                Path = "images/2021/Запой.jpg",
            },
            new Image
            {
                Id = i++,
                Date = new DateTime(2021, 12, 19),
                Name = "Кефирный мир",
                Path = "images/2021/Кефирный мир.jpg",
            },
            new Image
            {
                Id = i++,
                Date = new DateTime(2021, 12, 18),
                Name = "Конфискация",
                Path = "images/2021/Конфискация.jpg",
            },
            new Image
            {
                Id = i++,
                Date = new DateTime(2021, 12, 17),
                Name = "Крышу",
                Path = "images/2021/Крышу.jpg",
            },
            new Image
            {
                Id = i++,
                Date = new DateTime(2021, 12, 16),
                Name = "Люди-паровозы",
                Path = "images/2021/Люди-паровозы.jpg",
            },
            new Image
            {
                Id = i++,
                Date = new DateTime(2021, 12, 15),
                Name = "Новая машина",
                Path = "images/2021/Новая машина.jpg",
            },
            new Image
            {
                Id = i++,
                Date = new DateTime(2021, 12, 14),
                Name = "Новогодний нефтевоз",
                Path = "images/2021/Новогодний нефтевоз.jpg",
            },
            new Image
            {
                Id = i++,
                Date = new DateTime(2021, 12, 13),
                Name = "Новогодняя открытка",
                Path = "images/2021/Новогодняя открытка.jpg",
            },
            new Image
            {
                Id = i++,
                Date = new DateTime(2021, 12, 12),
                Name = "Перевахтовка",
                Path = "images/2021/Перевахтовка.jpg",
            },
            new Image
            {
                Id = i++,
                Date = new DateTime(2021, 12, 11),
                Name = "Прыг",
                Path = "images/2021/Прыг.jpg",
            },
            new Image
            {
                Id = i++,
                Date = new DateTime(2021, 12, 10),
                Name = "Сварщик",
                Path = "images/2021/Сварщик.jpg",
            },
            new Image
            {
                Id = i++,
                Date = new DateTime(2021, 12, 9),
                Name = "Перелет в филиальную",
                Path = "images/2021/Перелет в филиальную.jpg",
            },
            new Image
            {
                Id = i++,
                Date = new DateTime(2021, 12, 6),
                Name = "Промысел",
                Path = "images/2021/Промысел.jpg",
            },
            new Image
            {
                Id = i++,
                Date = new DateTime(2021, 12, 5),
                Name = "Речка",
                Path = "images/2021/Речка.jpg",
            },
            new Image
            {
                Id = i++,
                Date = new DateTime(2021, 12, 4),
                Name = "С Новым Годом",
                Path = "images/2021/С Новым Годом.jpg",
            },
            new Image
            {
                Id = i++,
                Date = new DateTime(2021, 12, 3),
                Name = "Собрание",
                Path = "images/2021/Собрание.jpg",
            },
            new Image
            {
                Id = i++,
                Date = new DateTime(2021, 12, 2),
                Name = "Сокращение",
                Path = "images/2021/Сокращение.jpg",
            },
            new Image
            {
                Id = i++,
                Date = new DateTime(2021, 12, 1),
                Name = "Старый новый год",
                Path = "images/2021/Старый новый год.jpg",
            },
            new Image
            {
                Id = i++,
                Date = new DateTime(2021, 11, 30),
                Name = "Телеметрия",
                Path = "images/2021/Телеметрия.jpg",
            },
            #endregion

            #region 2020
            new Image
            {
                Id = i++,
                Date = new DateTime(2020, 07, 30),
                Name = "АТЦ",
                Path = "images/2020/АТЦ.jpg",
            },
            new Image
            {
                Id = i++,
                Date = new DateTime(2020, 07, 29),
                Name = "Банк",
                Path = "images/2020/Банк.jpg",
            },
            new Image
            {
                Id = i++,
                Date = new DateTime(2020, 07, 28),
                Name = "Борьба со змейкой",
                Path = "images/2020/Борьба со змейкой.jpg",
            },
            new Image
            {
                Id = i++,
                Date = new DateTime(2020, 07, 27),
                Name = "Бугор в гараже",
                Path = "images/2020/Бугор в гараже.jpg",
            },
            new Image
            {
                Id = i++,
                Date = new DateTime(2020, 06, 30),
                Name = "Аншлаг",
                Path = "images/2020/Аншлаг.jpg",
            },
            new Image
            {
                Id = i++,
                Date = new DateTime(2020, 06, 29),
                Name = "Аська",
                Path = "images/2020/Аська.jpg",
            },
            new Image
            {
                Id = i++,
                Date = new DateTime(2020, 06, 28),
                Name = "В поверку",
                Path = "images/2020/В поверку.jpg",
            },
            new Image
            {
                Id = i++,
                Date = new DateTime(2020, 06, 27),
                Name = "Гриль",
                Path = "images/2020/Гриль.jpg",
            },
            new Image
            {
                Id = i++,
                Date = new DateTime(2020, 06, 28),
                Name = "Дипломные работы",
                Path = "images/2020/Дипломные работы.jpg",
            },
            new Image
            {
                Id = i++,
                Date = new DateTime(2020, 06, 27),
                Name = "Дискотека",
                Path = "images/2020/Дискотека.jpg",
            },
            new Image
            {
                Id = i++,
                Date = new DateTime(2020, 06, 18),
                Name = "Добыча нефти",
                Path = "images/2020/Добыча нефти.jpg",
            },
            new Image
            {
                Id = i++,
                Date = new DateTime(2020, 06, 17),
                Name = "Добыча",
                Path = "images/2020/Добыча.jpg",
            },
            new Image
            {
                Id = i++,
                Date = new DateTime(2020, 06, 18),
                Name = "Долги",
                Path = "images/2020/Долги.jpg",
            },
            new Image
            {
                Id = i++,
                Date = new DateTime(2020, 06, 17),
                Name = "Замена шкафа",
                Path = "images/2020/Замена шкафа.jpg",
            },
            new Image
            {
                Id = i++,
                Date = new DateTime(2020, 06, 18),
                Name = "Запой",
                Path = "images/2020/Запой.jpg",
            },
            new Image
            {
                Id = i++,
                Date = new DateTime(2020, 06, 17),
                Name = "Змея",
                Path = "images/2020/Змея.jpg",
            },
            new Image
            {
                Id = i++,
                Date = new DateTime(2020, 06, 15),
                Name = "Избушка",
                Path = "images/2020/Избушка.jpg",
            },
            new Image
            {
                Id = i++,
                Date = new DateTime(2020, 06, 14),
                Name = "Клуб пивных пьяниц",
                Path = "images/2020/Клуб пивных пьяниц.jpg",
            },
            new Image
            {
                Id = i++,
                Date = new DateTime(2020, 06, 10),
                Name = "Комиссия",
                Path = "images/2020/Комиссия.jpg",
            },
            new Image
            {
                Id = i++,
                Date = new DateTime(2020, 06, 9),
                Name = "Конфискация окорочка",
                Path = "images/2020/Конфискация окорочка.jpg",
            },
            new Image
            {
                Id = i++,
                Date = new DateTime(2020, 06, 8),
                Name = "Кредит",
                Path = "images/2020/Кредит.jpg",
            },
            new Image
            {
                Id = i++,
                Date = new DateTime(2020, 06, 7),
                Name = "Лаборатория",
                Path = "images/2020/Лаборатория.jpg",
            },
            new Image
            {
                Id = i++,
                Date = new DateTime(2020, 06, 8),
                Name = "Лесная добыча",
                Path = "images/2020/Лесная добыча.jpg",
            },
            new Image
            {
                Id = i++,
                Date = new DateTime(2020, 06, 7),
                Name = "Медведь",
                Path = "images/2020/Медведь.jpg",
            },
            new Image
            {
                Id = i++,
                Date = new DateTime(2020, 06, 6),
                Name = "Медосмотр гусей",
                Path = "images/2020/Медосмотр гусей.jpg",
            },
            new Image
            {
                Id = i++,
                Date = new DateTime(2020, 06, 5),
                Name = "Мечта инструкция",
                Path = "images/2020/Мечта инструкция.jpg",
            },
            new Image
            {
                Id = i++,
                Date = new DateTime(2020, 06, 1),
                Name = "Мечта",
                Path = "images/2020/Мечта.jpg",
            },
            new Image
            {
                Id = i++,
                Date = new DateTime(2020, 05, 30),
                Name = "Мойка",
                Path = "images/2020/Мойка.jpg",
            },
            new Image
            {
                Id = i++,
                Date = new DateTime(2020, 05, 29),
                Name = "МФУ",
                Path = "images/2020/МФУ.jpg",
            },
            new Image
            {
                Id = i++,
                Date = new DateTime(2020, 05, 28),
                Name = "НГСВ1",
                Path = "images/2020/НГСВ1.jpg",
            },
            new Image
            {
                Id = i++,
                Date = new DateTime(2020, 05, 27),
                Name = "Не ждали",
                Path = "images/2020/Не ждали.jpg",
            },
            new Image
            {
                Id = i++,
                Date = new DateTime(2020, 05, 26),
                Name = "Обмен",
                Path = "images/2020/Обмен.jpg",
            },
            new Image
            {
                Id = i++,
                Date = new DateTime(2020, 05, 26),
                Name = "Паек",
                Path = "images/2020/Паек.jpg",
            },
            new Image
            {
                Id = i++,
                Date = new DateTime(2020, 05, 25),
                Name = "ПДК",
                Path = "images/2020/ПДК.jpg",
            },
            new Image
            {
                Id = i++,
                Date = new DateTime(2020, 05, 24),
                Name = "Первомай",
                Path = "images/2020/Первомай.jpg",
            },
            new Image
            {
                Id = i++,
                Date = new DateTime(2020, 05, 23),
                Name = "Перебрали",
                Path = "images/2020/Перебрали.jpg",
            },
            new Image
            {
                Id = i++,
                Date = new DateTime(2020, 05, 22),
                Name = "Переключения",
                Path = "images/2020/Переключения.jpg",
            },
            new Image
            {
                Id = i++,
                Date = new DateTime(2020, 05, 21),
                Name = "Пивас",
                Path = "images/2020/Пивас.jpg",
            },
            new Image
            {
                Id = i++,
                Date = new DateTime(2020, 05, 20),
                Name = "План и отчет",
                Path = "images/2020/План и отчет.jpg",
            },
            new Image
            {
                Id = i++,
                Date = new DateTime(2020, 05, 19),
                Name = "Пожар",
                Path = "images/2020/Пожар.jpg",
            },
            new Image
            {
                Id = i++,
                Date = new DateTime(2020, 05, 18),
                Name = "Порыв",
                Path = "images/2020/Порыв.jpg",
            },
            new Image
            {
                Id = i++,
                Date = new DateTime(2020, 05, 17),
                Name = "Праздник",
                Path = "images/2020/Праздник.jpg",
            },
            new Image
            {
                Id = i++,
                Date = new DateTime(2020, 05, 16),
                Name = "Производство сигарет",
                Path = "images/2020/Производство сигарет.jpg",
            },
            new Image
            {
                Id = i++,
                Date = new DateTime(2020, 05, 17),
                Name = "Сварка",
                Path = "images/2020/Сварка.jpg",
            },
            new Image
            {
                Id = i++,
                Date = new DateTime(2020, 05, 16),
                Name = "Свиной",
                Path = "images/2020/Свиной.jpg",
            },
            new Image
            {
                Id = i++,
                Date = new DateTime(2020, 05, 17),
                Name = "Селфи палка",
                Path = "images/2020/Селфи палка.jpg",
            },
            new Image
            {
                Id = i++,
                Date = new DateTime(2020, 05, 16),
                Name = "Селфи",
                Path = "images/2020/Селфи.jpg",
            },
            new Image
            {
                Id = i++,
                Date = new DateTime(2020, 05, 2),
                Name = "Система",
                Path = "images/2020/Система.jpg",
            },
            new Image
            {
                Id = i++,
                Date = new DateTime(2020, 05, 1),
                Name = "Смайлик",
                Path = "images/2020/Смайлик.jpg",
            },
            new Image
            {
                Id = i++,
                Date = new DateTime(2020, 05, 2),
                Name = "Снова весна",
                Path = "images/2020/Снова весна.jpg",
            },
            new Image
            {
                Id = i++,
                Date = new DateTime(2020, 05, 1),
                Name = "Срок",
                Path = "images/2020/Срок.jpg",
            },
            new Image
            {
                Id = i++,
                Date = new DateTime(2020, 04, 30),
                Name = "Ссора",
                Path = "images/2020/Ссора.jpg",
            },
            new Image
            {
                Id = i++,
                Date = new DateTime(2020, 04, 29),
                Name = "Ставки",
                Path = "images/2020/Ставки.jpg",
            },
            new Image
            {
                Id = i++,
                Date = new DateTime(2020, 04, 30),
                Name = "Старый новый год",
                Path = "images/2020/Старый новый год.jpg",
            },
            new Image
            {
                Id = i++,
                Date = new DateTime(2020, 04, 29),
                Name = "Студентка",
                Path = "images/2020/Студентка.jpg",
            },
            new Image
            {
                Id = i++,
                Date = new DateTime(2020, 04, 28),
                Name = "Субботниий перфоманс",
                Path = "images/2020/Субботниий перфоманс.jpg",
            },
            new Image
            {
                Id = i++,
                Date = new DateTime(2020, 04, 27),
                Name = "Субботник в офисе",
                Path = "images/2020/Субботник в офисе.jpg",
            },
            new Image
            {
                Id = i++,
                Date = new DateTime(2020, 04, 28),
                Name = "Таблички",
                Path = "images/2020/Таблички.jpg",
            },
            new Image
            {
                Id = i++,
                Date = new DateTime(2020, 04, 27),
                Name = "Танкист",
                Path = "images/2020/Танкист.jpg",
            },
            new Image
            {
                Id = i++,
                Date = new DateTime(2020, 04, 26),
                Name = "Тариф длинные разговоры",
                Path = "images/2020/Тариф длинные разговоры.jpg",
            },
            new Image
            {
                Id = i++,
                Date = new DateTime(2020, 04, 25),
                Name = "Телега",
                Path = "images/2020/Телега.jpg",
            },
            new Image
            {
                Id = i++,
                Date = new DateTime(2020, 04, 24),
                Name = "Теща",
                Path = "images/2020/Теща.jpg",
            },
            new Image
            {
                Id = i++,
                Date = new DateTime(2020, 04, 25),
                Name = "Трубка мира",
                Path = "images/2020/Трубка мира.jpg",
            },
            new Image
            {
                Id = i++,
                Date = new DateTime(2020, 04, 24),
                Name = "Тяжелая работа",
                Path = "images/2020/Тяжелая работа.jpg",
            },
            new Image
            {
                Id = i++,
                Date = new DateTime(2020, 04, 25),
                Name = "Фототаблички",
                Path = "images/2020/Фототаблички.jpg",
            },
            new Image
            {
                Id = i++,
                Date = new DateTime(2020, 04, 24),
                Name = "Хоккей",
                Path = "images/2020/Хоккей.jpg",
            },
            new Image
            {
                Id = i++,
                Date = new DateTime(2020, 04, 25),
                Name = "Ценности демократические",
                Path = "images/2020/Ценности демократические.jpg",
            },
            new Image
            {
                Id = i++,
                Date = new DateTime(2020, 04, 24),
                Name = "Чемодан",
                Path = "images/2020/Чемодан.jpg",
            },
            new Image
            {
                Id = i++,
                Date = new DateTime(2020, 04, 4),
                Name = "Экзамен",
                Path = "images/2020/Экзамен.jpg",
            },
            new Image
            {
                Id = i++,
                Date = new DateTime(2020, 04, 3),
                Name = "Электричество",
                Path = "images/2020/Электричество.jpg",
            },
            new Image
            {
                Id = i++,
                Date = new DateTime(2020, 04, 2),
                Name = "Электробуханка",
                Path = "images/2020/Электробуханка.jpg",
            },
            new Image
            {
                Id = i++,
                Date = new DateTime(2020, 04, 1),
                Name = "Электромобиль",
                Path = "images/2020/Электромобиль.jpg",
            },
            #endregion
        };
        return images;
    }
}


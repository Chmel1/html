using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.Helpers
{
    internal static class getApplicationName
    {
        public static string getName(int variantID)
        {
            switch (variantID)
            {
                case 1: return "ИС «Студенческая библиотека»";
                case 2: return "ИС «Страховая фирма»";
                case 3: return "ИС «Агентство недвижимости»";
                case 4: return "ИС «ГАИ»";
                case 5: return "ИС «Учебная часть»";
                case 6: return "ИС «Отдел кадров»";
                case 7: return "ИС фирмы покупки и продажи автомобилей";
                case 8: return "ИС «Гостиница»";
                case 9: return "ИС «Расчет квартплаты ТСЖ»";
                case 10: return "ИС «Железнодорожные кассы»";
                case 11: return "ИС «Авиапассажирские перевозки»";
                case 12: return "ИС «Музей»";
                case 13: return "ИС «Спортивные комплексы района»";
                case 14: return "ИС «Экзаменационная сессия»";
                case 15: return "ИС «Турагентство»";
                case 16: return "ИС «Аптека»";
                case 17: return "ИС «Сборка и реализация компьютеров»";
                case 18: return "ИС «Продуктовые магазины района»";
                case 19: return "ИС «Больница»";
                case 20: return "ИС «Кинотеатр»";
                case 21: return "ИС «Цветочный магазин»";
                case 22: return "ИС «Магазин запчастей»";
                case 23: return "ИС «Учет сельскохозяйственных работ»";
                case 24: return "ИС «Учет деятельности БПЛА»";
                case 25: return "ИС «Магазин семян»";
                case 26: return "ИС «Учет животных на ферме»";
                case 27: return "ИС «Учет строительных материалов»";
                case 28: return "ИС «Хлебобулочные изделия»";
                case 29: return "ИС «Удобрения»";
                case 30: return "ИС «Породы животных (одного вида)»";
                case 31: return "ИС «Приемная комиссия»";
                case 32: return "ИС «Санаторий: распределение номеров»";
                case 33: return "ИС «Пункт проката»";
                case 34: return "ИС «Таксопарк»";
                case 35: return "ИС «Курьерская служба»";
                case 36: return "ИС «Автошкола»";
                case 37: return "ИС «Учет учебной нагрузки преподавателей»";
            }

            return "";

        }
    }
}

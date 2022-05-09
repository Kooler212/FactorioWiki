﻿using System;
using System.Collections.Generic;
using System.Text;

namespace FactorioWiki
{
    internal class BasicMaterials
    {
        public readonly static FactorioItem Wood = new FactorioItem("Древесина", "Добывается при срубании деревьев.", "Древесина являются основным ресурсом, который может быть собран вручную. Автоматизированного сбора нет.Но можно механизировать: строительным дронам дать задание(в зоне действия дронстанции) удалить деревья, тогда они будут собирать древесину в сундуки хранения, сундуки запроса или инвентарь персонажа(если есть запрос).", 0, Factory.Empty, "Wood.png");

        public readonly static FactorioItem Coal = new FactorioItem("Уголь", "Добывается на месторождениях и при добыче глыб.", "Уголь - один из природных ресурсов. Является наиболее эффективным источником энергии в начале игры. При сгорании 1 единицы угля получается - 8 мДж энергии. Добычу угля можно автоматизировать.Уголь используется для питания Паровой шахты и Парового манипулятора, нагрева воды в Бойлере и переплавке сырья в Каменной плавильне или Стальной плавильне.Также уголь может служить топливом для Автомобиля и Дизельного локомотива.", 0, Factory.Boors, "Coal.png");

        public readonly static FactorioItem Stone = new FactorioItem("Камень", "Добывается на месторождениях и при добыче глыб.", "Камень - Природный ресурс. Добыча камня может быть автоматизирована. Камень используется для изготовления Каменной плавильни, Каменного блока, Прямого рельса и Углового рельса.", 0, Factory.Boors, "Stone.png");

        public readonly static FactorioItem Oil = new FactorioItem("Нефть", "Выкачивается нефтяной вышкой из нефтяных пятен.", "Сырая нефть - неисчерпаемый природный ресурс, так же как и воду - её нельзя добывать игровым персонажем напрямую. Транспортировка осуществляется с помощью труб и / или подземных труб, бочек и вагонов - цистерн. Резервуар позволяет хранить до 25000 единиц нефти.", 0, Factory.OilZavodL, "");

        public readonly static FactorioItem Water = new FactorioItem("Вода", "Выкачивается насосом из озера.", "Вода - Неограниченный природный ресурс. Воду, как и нефть нельзя добывать напрямую игровым персонажем. Вода используется для выработки электроэнергии паровым генератором, перед чем её необходимо предварительно разогреть до 100 градусов в бойлере.Транспортировка воды осуществляется с помощью труб и / или подземной трубой", 0, Factory.NasosL, "Water.png");

        public readonly static FactorioItem CopperOre = new FactorioItem("Медная руда", "Добывается на месторождениях.", "Медная руда -  Природный ресурс. Добыча медной руды может быть автоматизирована.Медная руда используется для изготовления медной плиты, для чего её необходимо переплавить в любой печи. Залежи медной руды можно найти на карте. Добывается с помощью кирки или шахты на соответствующих месторождениях.", 0, Factory.Boors, "Copperore.png");

        public readonly static FactorioItem Unranium = new FactorioItem("Уран", "Добывается на месторождениях.", "Урановая руда - один из ресурсов доступных на карте. В отличии от руды котору нужно переплавлять в печах, эта руда нуждается в переработке с помощью центрифуги. Переработка открывается после изучения технологии: Обработка урана. В процессе обработки в центрифуге получается уран - 235  и уран - 238, из которых можно создать топливо для ядерного реактора и различные виды боеприпасов.", 4, Factory.CentreFugaL, "");

        public readonly static FactorioItem Ironore = new FactorioItem("Железная руда", "Добывается на месторождениях.", "Железная руда - Природный ресурс. Добыча железной руды может быть автоматизирована. Железная руда используется для изготовления железобетона в чистом виде, и железных плит для чего её необходимо переплавить в любой плавильне. Залежи железной руды можно найти на карте. Добывается с помощью кирки или шахты на соответствующих месторождениях.", 0, Factory.Boors, "Ironore.png");

        public readonly static FactorioItem Fish = new FactorioItem("Рыба", "Добывается в озере.", "Рыба - нейтральное существо, предмет. В отличии от всех других предметов, рыба не участвует ни в одной цепочке производства, но с версией 1.0.0 добавлен в крафт паукотрона, так же может быть использовано Игровым персонажем для мгновенного восстановления части здоровья. Обитают рыбы исключительно в водоёмах.Количество рыбы в водоёмах зависит от загрязнения среды.", 0, Factory.Empty, "Fish.png");

        public readonly static FactorioItem Boards = new FactorioItem("Доски", "Создается из древесины", "У досок и древесины одно описание", 0, Factory.Empty, "");

        public readonly static FactorioItem IronList = new FactorioItem("Железная плита", "Создается в печах из железной руды", "Железная плита - основной материал для производства. Используется для производства большинства предметов в игре.", 3.5, "", (1, Ironore));

        public readonly static FactorioItem CopperList = new FactorioItem("Медная плита", "Создается в печах из медной руды", "Железная плита - основной материал для производства. Используется для производства большинства предметов в игре.", 3.5, "", (1, CopperOre));

        public readonly static FactorioItem StealBeam = new FactorioItem("Стальная балка", "Создается в печах из железного листа", "Стальная балка - продвинутый материал для производства. Используется для производства предметов середины игры и далее.Для изготовления необходимо провести исследование: Производство стали.", 17.5, "", (5, IronList));

        public readonly static FactorioItem IroneSterjen = new FactorioItem("Железный стержень", "Создается из железного листа", "Железный прут - промежуточный этап производства.", 0.5, "", (1, IronList));

        public readonly static FactorioItem IroneShesterny = new FactorioItem("Железная шестерня", "Создается из железного листа", "Железная шестерня - промежуточный этап производства. Используется в создании многих базовых предметов.", 0.5, "", (2, IronList));

        public readonly static FactorioItem CopperCabel = new FactorioItem("Медный кабель", "Создается из медного листа", "там пусто", 0.5, "", (1, CopperOre));

        public readonly static FactorioItem Mazut = new FactorioItem("Мазут", "Получается при очистке сырой нефти на нефтеперерабатывающем заводе", "Мазут - один из нефтепродуктов, который получается в результате очистки сырой Нефти на Нефтеочистительном заводе. Мазут можно использовать для производства Твёрдого топлива, обладающего более высокими энергетическими показателями, нежели у Древесины и Угля.", 0, "");

        public readonly static FactorioItem DzOil = new FactorioItem("Дизельное топливо", "Получается при очистке сырой нефти на нефтеперерабатывающем заводе", "Дизельное топливо - один из нефтепродуктов, который получается в результате очистки сырой Нефти на Нефтеочистительном заводе. Дизельное топливо можно использовать для производства Твёрдого топлива, обладающего более высокими энергетическими показателями, нежели у Древесины и Угля.", 0, "");

        public readonly static FactorioItem Putin = new FactorioItem("Нефтяной газ", "Получается при очистке сырой нефти на нефтеперерабатывающем заводе", "Попутный нефтяной газ - один из нефтепродуктов, который получается в результате очистки сырой Нефти на Нефтеочистительном заводе. Нефтяной газ можно использовать для производства Твёрдого топлива, обладающего более высокими энергетическими показателями, нежели у Древесины и Угля.", 0, "");

        public readonly static FactorioItem Smazka = new FactorioItem("Смазка", "Создается в химическом заводе из тяжёлой нефти", "Смазочная жидкость - материал, изготовляемый из мазута на химическом заводе. Используется при создании подземного и наземного экспресс конвейера, электродвигателя. Для изготовления необходимо провести исследование: Переработка нефти.", 1, "",(1, Mazut));

        public readonly static FactorioItem Par = new FactorioItem("Пар", "Получается из бойлеров и теплообменников", "Пар - это газ, который можно получить путём нагрева воды в бойлере или в теплообменниках для дальнейшей выработки электричества. Необходим для процесса сжижения угля на нефтеперерабатывающем заводе. Пар можно хранить в резервуарах. Есть разница между паром выработанным с помощью бойлера, где его максимальная температура равна 165°C, и в теплообменника, где пар может быть температурой 500°C. Это значит, что при том же количестве пара у нас будет больше энергии в сравнении с объёмом пара полученной с помощью бойлера и теплообменника. У пара отсутствуют потери тепла при хранении или перемещении его по трубам или резервуарам. Энергия, которую необходимо потратить для производства пара из воды (например сжигая топливо в бойлерах) равна той же энергии, которая содержится в паре, поскольку эффективность паровых двигателей и турбин равна 100%. Однако, есть особенность, которая основана на том, что КПД бойлера равен 50%, что означает - только половина энергии от сжигания топлива будет преобразована в другой вид энергии - пар.Количество энергии, содержащейся в паре, линейно пропорционально его температуре(-15 °C от температуры окружающей среды).В одной единице пара содержится энергия равная 200 джоулям /°C, поэтому для нагрева пара на 1°C необходимо совершить работу равную 200 джоулям.", 0, "");

        public readonly static FactorioItem Plastic = new FactorioItem("Пластмассовый брусок", "Создается в химическом заводе из попутного нефтяного газа и угля", "Пластмассовый брусок - продвинутый материал для производства улучшенных электросхем.Для изготовления необходимо провести исследование: Пластмассы.", 1, "", (1, Coal), (3, Putin));

        public readonly static FactorioItem Sera = new FactorioItem("Сера", "Создается в химическом заводе из попутного нефтяного газа и воды", "Сера - продвинутый материал для производства. Используется для производства серной кислоты и взрывчатки.Для изготовления необходимо провести исследование: Обработка серы.", 1, "", (3, Water), (3, Putin));

        public readonly static FactorioItem ToxicSera = new FactorioItem("Серная кислота", "Создается в химическом заводе из серы и воды", "Серная кислота - результат окисления серы. Производится исключительно на химическом заводе. Транспортируется по трубам. Резервуар позволяет хранить до 25000 единиц серной кислоты.Для изготовления необходимо провести исследование Обработка серы.", 1, "", (5, Sera), (1, IronList), (10, Water));

        public readonly static FactorioItem Boom = new FactorioItem("Взрывчатка", "Создается в химическом заводе из серы, угля и воды", "Взрывчатка используется для создания мин, ракет и крупнокалиберных снарядов. Для изготовления необходимо провести исследование: Взрывчатые вещества.", 5, "", (1, Sera), (1, Coal), (1, Water));

        public readonly static FactorioItem Batery = new FactorioItem("Батарейка", "Создается на химическом заводе из серной кислоты, медной и железной плит", "Аккумулятор - ключевой компонент, используемый в создании в создании каркаса дрона, лазерных турелей и исследовательского пакета 3.Для изготовления необходимо провести исследование: Аккумулятор.", 5, "", (1, IronList), (1, CopperList), (2, ToxicSera));

        public readonly static FactorioItem Cxema = new FactorioItem("Электронные схемы", "Создается из медных кабелей и железных листов", "Электросхема является базовым компонентом во многих рецептах. Оптимальной линией для сборки является: 3 сборочных автомата для производства медных кабелей и 2 - для электросхем.", 0.5, "", (1, IronList), (3, CopperList));

        public readonly static FactorioItem BetterCxema = new FactorioItem("Улучшенные схемы", "Создается из электронных схем и пластмассы", "Улучшенная электросхема является компонентом в высокотехнологичных предметах. Требуется в больших количествах, но перед начало производства рекомендуется наладить производство пластмассы.", 8, "", (2, Cxema), (2, Plastic), (4, CopperCabel));

        public readonly static FactorioItem Process= new FactorioItem("Процессор", "Создается из электронных схем, улучшенных электронных схем и серной кислоты на сборочном автомате", "Процессор является компонентом для предметов поздней игры, в основном для создания модулей, силовой брони и её оборудования.", 15, "", (20, Cxema), (2, BetterCxema), (0.5, ToxicSera));

        public readonly static FactorioItem StoneBlock = new FactorioItem("Каменный блок", "Ускоряет передвижение на 130%", "Каменный блок производится путём обжига камня в печи. Используется для создания продвинутых печей и оборонительных стен.Можно использовать для создания дорог из камня ЛКМ. Для того, чтобы убрать дорогу, нужно выбрать блок в инвентаре и нажать ПКМ по дороге.", 3.5, "", (2, Stone));

        public readonly static FactorioItem Beton = new FactorioItem("Бетон", "Ускоряет передвижение на 140%", "Бетон служит для ускоренного перемещения игрока. Скорость перемещения по нему составляет 140%. Бетонные плиты при наведении на них не активны, поэтому для удаления требуется использовать сам бетон.Так как для производства бетона требуется вода, его невозможно создавать ручной сборкой. Для этого потребуется Автоматический завод 2 или Автоматический завод 3, подключенный к трубе с водой.", 10, "", (1, Ironore), (5, StoneBlock), (100, Water));

        public readonly static FactorioItem Truba = new FactorioItem("Труба", "", "", 0.5, "", (1, IronList));

        public readonly static FactorioItem Accumulator = new FactorioItem("Аккумулятор", "", "Аккумулятор - ключевой компонент, используемый в создании в создании каркаса дрона, лазерных турелей и исследовательского пакета 3 .", 5, "", (1, IronList), (1, CopperList), (2, ToxicSera));

        public readonly static FactorioItem IromePrute = new FactorioItem("Железный прут", "", "Железный прут - промежуточный этап производства.", 0.5, "", (1, IronList));

        public readonly static FactorioItem SpeedModule = new FactorioItem("Модуль скорости", "", "Модуль скорости - модуль ускорения производства или добычи сооружений. Так же время увеличивает потребление электроэнергии. Для работы модуля скорости его необходимо поместить в свободный слот сооружения с поддержкой модулей. Одно и то же сооружение может использовать несколько одинаковых модулей скорости. Эффект суммируется.", 15, "", (5, BetterCxema), (5, Cxema));

        public readonly static FactorioItem Item = new FactorioItem("", "", "", "");

        public readonly static FactorioItem Item = new FactorioItem("", "", "", "");

        public readonly static FactorioItem Item = new FactorioItem("", "", "", "");

        public readonly static FactorioItem Item = new FactorioItem("", "", "", "");

        public readonly static FactorioItem Item = new FactorioItem("", "", "", "");

        public readonly static FactorioItem Item = new FactorioItem("", "", "", "");

        public readonly static FactorioItem Item = new FactorioItem("", "", "", "");

        public readonly static FactorioItem Item = new FactorioItem("", "", "", "");

        public readonly static FactorioItem Item = new FactorioItem("", "", "", "");

        public readonly static FactorioItem Item = new FactorioItem("", "", "", "");

        public readonly static FactorioItem Item = new FactorioItem("", "", "", "");

        public readonly static FactorioItem Item = new FactorioItem("", "", "", "");

        public readonly static FactorioItem Item = new FactorioItem("", "", "", "");

        public readonly static FactorioItem Item = new FactorioItem("", "", "", "");

        public readonly static FactorioItem Item = new FactorioItem("", "", "", "");

        public readonly static FactorioItem Item = new FactorioItem("", "", "", "");

        public readonly static FactorioItem Item = new FactorioItem("", "", "", "");

        public readonly static FactorioItem Item = new FactorioItem("", "", "", "");

        public readonly static FactorioItem Item = new FactorioItem("", "", "", "");

        public readonly static FactorioItem Item = new FactorioItem("", "", "", "");

        public readonly static FactorioItem Item = new FactorioItem("", "", "", "");

        public readonly static FactorioItem Item = new FactorioItem("", "", "", "");

        public readonly static FactorioItem Item = new FactorioItem("", "", "", "");

        public readonly static FactorioItem Item = new FactorioItem("", "", "", "");

        public readonly static FactorioItem Item = new FactorioItem("", "", "", "");

        public readonly static FactorioItem Item = new FactorioItem("", "", "", "");

        public readonly static FactorioItem Item = new FactorioItem("", "", "", "");

        public readonly static FactorioItem Item = new FactorioItem("", "", "", "");

        public readonly static FactorioItem Item = new FactorioItem("", "", "", "");


    }
}

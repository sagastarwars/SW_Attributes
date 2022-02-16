
namespace Attribute_libs
{
    public class Stamina_atr: Atribute_class
    {
        #region // конструктор класса
        public Stamina_atr()  // определяем конструктор класса, используя конструктор базового класса
        {
            Set_atr_score(0);                       // Устанавливаем текущее показатель атрибута 
            // Set_description("");                    // Устанавливаем описание атрибута
            //Set_atribute_code((int)SW_Character.enum_Atributes.Stamina);    // Устанавливаем код текущего атрибута
            


            Set_child_attribute_limit(2);           // Устанавливаем значение возрастного лимита атрибутов для Ребенок
            Set_teen_attribute_limit(4);            // Устанавливаем значение возрастного лимита атрибутов для Подросток
            Set_adult_attribute_limit(10);          // Устанавливаем значение возрастного лимита атрибутов для Взрослый
            Set_middle_attribute_limit(10);         // Устанавливаем значение возрастного лимита атрибутов для Средний Возраст
            Set_old_attribute_limit(10);            // Устанавливаем значение возрастного лимита атрибутов для Пожилой
            Set_eldery_attribute_limit(10);         // Устанавливаем значение возрастного лимита атрибутов для Почтенный
            Set_unknown_age_attribute_limit(0);     // Устанавливаем значение возрастного лимита атрибутов для Неизвестный возраст

            Set_private_range_attribute_limit(10);  // Устанавливаем значение рангового лимита атрибутов для Рядовой 
            Set_veteran_range_attribute_limit(10);  // Устанавливаем значение рангового лимита атрибутов для Ветеран 
            Set_hero_range_attribute_limit(10);     // Устанавливаем значение рангового лимита атрибутов для Герой 
            Set_epic_range_attribute_limit(10);     // Устанавливаем значение рангового лимита атрибутов для Эпик 
            Set_immortal_range_attribute_limit(10); // Устанавливаем значение рангового лимита атрибутов для Бессмертный
        }
        #endregion

        #region // определяем значения констант класса

        #endregion

        #region // Определяем особенности данного атрибута (если они есть)

        #endregion
    }
}

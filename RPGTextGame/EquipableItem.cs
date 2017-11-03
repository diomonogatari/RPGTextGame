namespace RPGTextGame
{
    public class EquipableItem : Item
    {
        public EquipableItem(string Description, string AfterUseDescription, TypesOfStats Stat) : base(Description, AfterUseDescription,  Stat)
        {
            isEquipable = true;
        }
    }
}
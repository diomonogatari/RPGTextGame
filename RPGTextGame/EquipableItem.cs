namespace RPGTextGame
{
    public class EquipableItem : Item
    {
        public enum TypeOfEquip { Belt, Boots, Cape, ChestPiece, Earrings, Helmet, Legs, LongSword, Necklace, Rings, Shield, Staff, Sword }
        public bool isEquiped;
        public TypeOfEquip equipType;
        public EquipableItem(string Description, string AfterUseDescription, TypesOfStats Stat, TypeOfEquip EquipType, short AmountOfValueIncreased) : base(Description, AfterUseDescription, Stat, AmountOfValueIncreased)
        {
            this.isEquipable = true;
            this.isEquiped = false;
            this.equipType = EquipType;
        }
    }
}
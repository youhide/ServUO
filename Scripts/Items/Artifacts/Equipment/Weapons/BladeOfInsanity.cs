using System;

namespace Server.Items
{
    public class BladeOfInsanity : Katana
	{
		public override bool IsArtifact { get { return true; } }
        [Constructable]
        public BladeOfInsanity()
        {
            Hue = 0x76D;
            WeaponAttributes.HitLeechStam = 100;
            Attributes.RegenStam = 2;
            Attributes.WeaponSpeed = 30;
            Attributes.WeaponDamage = 50;
        }

        public BladeOfInsanity(Serial serial)
            : base(serial)
        {
        }

        public override int LabelNumber
        {
            get
            {
                return 1061088;
            }
        }// Blade of Insanity
        public override int ArtifactRarity
        {
            get
            {
                return 11;
            }
        }
        public override int InitMinHits
        {
            get
            {
                return 255;
            }
        }
        public override int InitMaxHits
        {
            get
            {
                return 255;
            }
        }
        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);

            writer.Write((int)0);
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);

            int version = reader.ReadInt();

            if (this.Hue == 0x44F)
                this.Hue = 0x76D;
        }
    }
}
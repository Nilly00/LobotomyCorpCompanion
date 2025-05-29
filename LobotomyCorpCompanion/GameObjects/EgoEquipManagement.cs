using System;
using LobotomyCorpCompanion.GameObjects.EGOSuits;
using LobotomyCorpCompanion.GameObjects.EGOWeapons;

namespace LobotomyCorpCompanion.GameObjects
{
    internal static class GiftManagement
    {
        //gift stuff
        private static readonly List<EgoGift> GiftMasterList;
        static GiftManagement()
        {
            //building the master list like this ensures all instances are initialised
            GiftMasterList =
            [
                Alriune_Gift.Instance,
                Apocalypse_Gift.Instance,
                Apple_Gift.Instance,
                Army_Gift.Instance,
                Bald_Gift.Instance,
                Bear_Gift.Instance,
                Beauty_Gift.Instance,
                Bee_Gift.Instance,
                Big_Gift.Instance,
                Bloodbath_Gift.Instance,
                Butterflies_Gift.Instance,
                Censored_Gift.Instance,
                Cherry_Gift.Instance,
                Crumbling_Gift.Instance,
                Crumbling_B_Gift.Instance,
                Crumbling_O_Gift.Instance,
                Crumbling_R_Gift.Instance,
                Current_Gift.Instance,
                Cute_Gift.Instance,
                Despair_Gift.Instance,
                Dream_Gift.Instance,
                Fairy_Gift.Instance,
                Fetus_Gift.Instance,
                Firebird_Gift.Instance,
                Forsaken_Gift.Instance,
                Fragments_Gift.Instance,
                Freischütz_Gift.Instance,
                Galaxy_Gift.Instance,
                Greed_Gift.Instance,
                Hatred_Gift.Instance,
                Heaven_Gift.Instance,
                Helper_Gift.Instance,
                Judgement_Gift.Instance,
                Laetitia_Gift.Instance,
                Lantern_Gift.Instance,
                Love_Gift.Instance,
                Luna_Gift.Instance,
                MHZ_Gift.Instance,
                Monk_Gift.Instance,
                Nest_Gift.Instance,
                Nothing_Gift.Instance,
                OldLady_Gift.Instance,
                OneSin_Gift.Instance,
                Orchestra_Gift.Instance,
                Parasite_Gift.Instance,
                Plague_Gift.Instance,
                Porccubus_Gift.Instance,
                Prince_Gift.Instance,
                Punishing_Gift.Instance,
                Rabbit_Gift.Instance,
                Refraction_Gift.Instance,
                Ridinghood_Gift.Instance,
                Rudolta_Gift.Instance,
                Scarecrow_Gift.Instance,
                Schadenfreude_Gift.Instance,
                Scorched_Gift.Instance,
                Shoes_Gift.Instance,
                Shy_Gift.Instance,
                Singing_Gift.Instance,
                Smiling_Gift.Instance,
                Snow_Gift.Instance,
                Spider_Gift.Instance,
                Star_Gift.Instance,
                Swan_Gift.Instance,
                Wellcheers_Gift.Instance,
                White_Gift.Instance,
                Wolf_Gift.Instance,
                Woodsman_Gift.Instance,
                Yin_Gift.Instance,
            ];
        }
        public static List<EgoGift> GetList(Slot slot)
        {
            return slot switch
            {
                Slot.Brooch => GetBroochList(),
                Slot.Cheek => GetCheekList(),
                Slot.Eye => GetEyeList(),
                Slot.Face => GetFaceList(),
                Slot.Hand_1 => GetHand_1List(),
                Slot.Hand_2 => GetHand_2List(),
                Slot.Hat => GetHatList(),
                Slot.Helmet => GetHelmetList(),
                Slot.Left_back => GetLeft_backList(),
                Slot.Right_back => GetRight_backList(),
                Slot.Mouth_1 => GetMouth_1List(),
                Slot.Mouth_2 => GetMouth_2List(),
                Slot.Neckwear => GetNeckwearList(),
                Slot.Special => GetSpecialList(),
                _ => throw new Exception("EquipManagement.GetList(slot) unknown slot supplied")
            };
        }

        //gift list assemblers
        private static List<EgoGift> GetBroochList()
        {
            List<EgoGift> List = [];
            foreach (EgoGift gift in GiftMasterList)
            {
                if (gift.slot == Slot.Brooch) List.Add(gift);
            }
            return List;
        }
        private static List<EgoGift> GetCheekList()
        {
            List<EgoGift> List = [];
            foreach (EgoGift gift in GiftMasterList)
            {
                if (gift.slot == Slot.Cheek) List.Add(gift);
            }
            return List;
        }
        private static List<EgoGift> GetEyeList()
        {
            List<EgoGift> List = [];
            foreach (EgoGift gift in GiftMasterList)
            {
                if (gift.slot == Slot.Eye) List.Add(gift);
            }
            return List;
        }
        private static List<EgoGift> GetFaceList()
        {
            List<EgoGift> List = [];
            foreach (EgoGift gift in GiftMasterList)
            {
                if (gift.slot == Slot.Face) List.Add(gift);
            }
            return List;
        }
        private static List<EgoGift> GetHand_1List()
        {
            List<EgoGift> List = [];
            foreach (EgoGift gift in GiftMasterList)
            {
                if (gift.slot == Slot.Hand_1) List.Add(gift);
            }
            return List;
        }
        private static List<EgoGift> GetHand_2List()
        {
            List<EgoGift> List = [];
            foreach (EgoGift gift in GiftMasterList)
            {
                if (gift.slot == Slot.Hand_2) List.Add(gift);
            }
            return List;
        }
        private static List<EgoGift> GetHatList()
        {
            List<EgoGift> List = [];
            foreach (EgoGift gift in GiftMasterList)
            {
                if (gift.slot == Slot.Hat) List.Add(gift);
            }
            return List;
        }
        private static List<EgoGift> GetHelmetList()
        {
            List<EgoGift> List = [];
            foreach (EgoGift gift in GiftMasterList)
            {
                if (gift.slot == Slot.Helmet) List.Add(gift);
            }
            return List;
        }
        private static List<EgoGift> GetLeft_backList()
        {
            List<EgoGift> List = [];
            foreach (EgoGift gift in GiftMasterList)
            {
                if (gift.slot == Slot.Left_back) List.Add(gift);
            }
            return List;
        }
        private static List<EgoGift> GetRight_backList()
        {
            List<EgoGift> List = [];
            foreach (EgoGift gift in GiftMasterList)
            {
                if (gift.slot == Slot.Right_back) List.Add(gift);
            }
            return List;
        }
        private static List<EgoGift> GetMouth_1List()
        {
            List<EgoGift> List = [];
            foreach (EgoGift gift in GiftMasterList)
            {
                if (gift.slot == Slot.Mouth_1) List.Add(gift);
            }
            return List;
        }
        private static List<EgoGift> GetMouth_2List()
        {
            List<EgoGift> List = [];
            foreach (EgoGift gift in GiftMasterList)
            {
                if (gift.slot == Slot.Mouth_2) List.Add(gift);
            }
            return List;
        }
        private static List<EgoGift> GetNeckwearList()
        {
            List<EgoGift> List = [];
            foreach (EgoGift gift in GiftMasterList)
            {
                if (gift.slot == Slot.Neckwear) List.Add(gift);
            }
            return List;
        }
        private static List<EgoGift> GetSpecialList()
        {
            List<EgoGift> List = [];
            foreach (EgoGift gift in GiftMasterList)
            {
                if (gift.slot == Slot.Special) List.Add(gift);
            }
            return List;
        }

        //return a random gift for the specified slot
        public static EgoGift RandomGift(Slot slot)
        {
            Random random = new();

            List<EgoGift> list = GetList(slot);
            return list.ElementAt(random.Next(list.Count));
        }

        public static EgoGift[] RandomGiftSet()
        {
            EgoGift[] gifts =
                [
                RandomGift(Slot.Brooch),
                RandomGift(Slot.Cheek),
                RandomGift(Slot.Eye),
                RandomGift(Slot.Face),
                RandomGift(Slot.Hand_1),
                RandomGift(Slot.Hand_2),
                RandomGift(Slot.Hat),
                RandomGift(Slot.Helmet),
                RandomGift(Slot.Left_back),
                RandomGift(Slot.Right_back),
                RandomGift(Slot.Mouth_1),
                RandomGift(Slot.Mouth_2),
                RandomGift(Slot.Neckwear),
                RandomGift(Slot.Special),
            ];

            return gifts;
        }
    }

    internal static class SuitManagement
    {
        private static readonly List<EgoSuit> SuitMasterList;

        static SuitManagement()
        {
            //building the master list like this ensures all instances are initialised
            SuitMasterList = [
                Alriune_Suit.Instance,
                Apocalypse_Suit.Instance,
                Apple_Suit.Instance,
                Army_Suit.Instance,
                Bald_Suit.Instance,
                Bear_Suit.Instance,
                Beauty_Suit.Instance,
                Bee_Suit.Instance,
                Big_Suit.Instance,
                Bloodbath_Suit.Instance,
                Butterflies_Suit.Instance,
                Cherry_Suit.Instance,
                Crumbling_Suit.Instance,
                Current_Suit.Instance,
                Cute_Suit.Instance,
                Default_Suit.Instance,
                Despair_Suit.Instance,
                Dream_Suit.Instance,
                Fairy_Suit.Instance,
                Fetus_Suit.Instance,
                Firebird_Suit.Instance,
                Forsaken_Suit.Instance,
                Fragments_Suit.Instance,
                Freischütz_Suit.Instance,
                Galaxy_Suit.Instance,
                Greed_Suit.Instance,
                Hatred_Suit.Instance,
                Heaven_Suit.Instance,
                Helper_Suit.Instance,
                Judgement_Suit.Instance,
                Laetitia_Suit.Instance,
                Lantern_Suit.Instance,
                Love_Suit.Instance,
                Luna_Suit.Instance,
                MHZ_Suit.Instance,
                Monk_Suit.Instance,
                Nest_Suit.Instance,
                Nothing_Suit.Instance,
                OldLady_Suit.Instance,
                OneSin_Suit.Instance,
                Orchestra_Suit.Instance,
                Parasite_Suit.Instance,
                Porccubus_Suit.Instance,
                Prince_Suit.Instance,
                Punishing_Suit.Instance,
                Rabbit_Suit.Instance,
                Ridinghood_Suit.Instance,
                Rudolta_Suit.Instance,
                Scarecrow_Suit.Instance,
                Schadenfreude_Suit.Instance,
                Scorched_Suit.Instance,
                Shoes_Suit.Instance,
                Shy_Suit.Instance,
                Smiling_Suit.Instance,
                Snow_Suit.Instance,
                Spider_Suit.Instance,
                Star_Suit.Instance,
                Swan_Suit.Instance,
                WallLady_Suit.Instance,
                Wellcheers_Suit.Instance,
                White_Suit.Instance,
                Wolf_Suit.Instance,
                Woodsman_Suit.Instance,
                Yin_Suit.Instance,
            ];
        }

        public static EgoSuit GetRandomSuit()
        {
            Random random = new();
            return SuitMasterList.ElementAt(random.Next(SuitMasterList.Count));
        }
    }

    internal static class WeaponManagement
    {
        private static readonly List<EgoWeapon> WeaponMasterList;

        static WeaponManagement()
        {
            //building the master list like this ensures all instances are initialised
            WeaponMasterList = [
            Alriune_Weapon.Instance,
            Apocalypse_Weapon.Instance,
            Apple_Weapon.Instance,
            Army_Weapon.Instance,
            Bald_Weapon.Instance,
            Bear_Weapon.Instance,
            Beauty_Weapon.Instance,
            Bee_Weapon.Instance,
            Big_Weapon.Instance,
            Bloodbath_Weapon.Instance,
            Butterflies_Weapon.Instance,
            Censored_Weapon.Instance,
            Cherry_Weapon.Instance,
            Crumbling_Weapon.Instance,
            Current_Weapon.Instance,
            Cute_Weapon.Instance,
            Default_Weapon.Instance,
            Despair_Weapon.Instance,
            Dream_Weapon.Instance,
            Fairy_Weapon.Instance,
            Fetus_Weapon.Instance,
            Firebird_Weapon.Instance,
            Forsaken_Weapon.Instance,
            Fragments_Weapon.Instance,
            Freischütz_Weapon.Instance,
            Galaxy_Weapon.Instance,
            Greed_Weapon.Instance,
            Hatred_Weapon.Instance,
            Heaven_Weapon.Instance,
            Helper_Weapon.Instance,
            Judgement_Weapon.Instance,
            Laetitia_Weapon.Instance,
            Lantern_Weapon.Instance,
            Love_Weapon.Instance,
            Luna_Weapon.Instance,
            Monk_Weapon.Instance,
            Nest_Weapon.Instance,
            Nothing_Weapon.Instance,
            OldLady_Weapon.Instance,
            OneSin_Weapon.Instance,
            Orchestra_Weapon.Instance,
            Parasite_Weapon.Instance,
            Porccubus_Weapon.Instance,
            Prince_Weapon.Instance,
            Punishing_Weapon.Instance,
            Rabbit_Weapon.Instance,
            Refraction_Weapon.Instance,
            Ridinghood_Weapon.Instance,
            Rudolta_Weapon.Instance,
            Scarecrow_Weapon.Instance,
            Schadenfreude_Weapon.Instance,
            Scorched_Weapon.Instance,
            Shoes_Weapon.Instance,
            Shy_Weapon.Instance,
            Singing_Weapon.Instance,
            Smiling_Weapon.Instance,
            Snow_Weapon.Instance,
            Spider_Weapon.Instance,
            Star_Weapon.Instance,
            Swan_Weapon.Instance,
            WallLady_Weapon.Instance,
            Wellcheers_Weapon.Instance,
            White_Weapon.Instance,
            Wolf_Weapon.Instance,
            Woodsman_Weapon.Instance,
            Yin_Weapon.Instance,
            ];
        }

        public static EgoWeapon GetRandomWeapon()
        {
            Random random = new();
            return WeaponMasterList.ElementAt(random.Next(WeaponMasterList.Count));
        }
    }
}

using System;
using System.Collections.Generic;
using System.Collections.Frozen;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using LobotomyCorpCompanion.GameObjects.Abnormalities;


namespace LobotomyCorpCompanion.GameObjects
{
    internal abstract class Abnormality
    {
        internal string Name {get; init;}
        internal string? DerivedName { get; init; }
        internal RiskLevel RiskLevel { get; init; }

        internal EgoWeapon? Weapon { get; init; }
        internal EgoSuit? Suit { get; init; }
        internal EgoGift? Gift { get; init; }


        internal virtual void WeaponEffect(Employee employee)
        {
            //placeholder function to allow for calls
        }

        internal virtual void SuitEffect(Employee employee)
        {
            //placeholder function to allow for calls
        }

        internal virtual void GiftEffect(Employee employee)
        {
            //placeholder function to allow for calls
        }

        internal static readonly FrozenDictionary<string, Abnormality> Abnormalities = new Dictionary<string, Abnormality>
        {
            {"Apocalypse Bird" ,                    new Apocalypse()    },
            {"Snow White's Apple",                  new Apple()         },
            {"Army in Black",                       new Army()          },
            {"You're Bald...",                      new Bald()          },
            {"Happy Teddy Bear",                    new Bear()          },
            {"Beauty and the Beast",                new Beauty()        },
            {"Big Bird",                            new Big()           },
            {"Bloodbath",                           new Bloodbath()     },
            {"Funeral of the Dead Butteflies",      new Butterflies()   },
            {"Censored",                            new Censored()      },
            {"Grave of Cherry Blossoms",            new Cherry()        },
            {"Inspired Bravery",                    new Crumbling()     },
            {"Reckless Foolishness Blue",           new Crumbling_B()   },
            {"Reckless Foolishness Orange",         new Crumbling_O()   },
            {"Reckless Foolishness Red",            new Crumbling_R()   },
            {"Dreaming Current",                    new Current()       },
            {"Ppodae",                              new Cute()          },
            {"Default",                             new Default()       },
            {"The Knight of Despair",               new Despair()       },
            {"Void Dream",                          new Dream()         },
            {"Fairy Festival",                      new Fairy()         },
            {"Nameless Fetus",                      new Fetus()         },
            {"The Firebird",                        new Firebird()      },
            {"Forsaken Murderer",                   new Forsaken()      },
            {"Fragment of the Universe",            new Fragments()     },
            {"Der Freischütz",                      new Freischütz()    },
            {"Child of the Galaxy",                 new Galaxy()        },
            {"King of Greed",                       new Greed()         },
            {"Queen of Hatred",                     new Hatred()        },
            {"The Burrowing Heaven",                new Heaven()        },
            {"All Around Helper",                   new Helper()        },
            {"Judgement Bird",                      new Judgement()     },
            {"Laetitia",                            new Laetitia()      },
            {"Meat Lantern",                        new Lantern()       },
            {"Melting Love",                        new Love()          },
            {"Il Pianto della Luna",                new Luna()          },
            {"1.76 MHz",                            new MHZ()           },
            {"Heroic Monk",                         new Monk()          },
            {"The Naked Nest",                      new Nest()          },
            {"Old Lady",                            new OldLady()       },
            {"One Sin and Hundreds of Good Deeds",  new OneSin()        },
            {"The Silent Orchestra",                new Orchestra()     },
            {"Porccubus",                           new Porccubus()     },
            {"The Little Prince",                   new Prince()        },
            {"Punishing Bird",                      new Punishing()     },
            {"Snow Queen",                          new Queen()         },
            {"Litle Red Riding Hood",               new Red()           },
            {"Dimensional Refraction Variant",      new Refraction()    },
            {"Rudolta of the Sleigh",               new Rudolta()       },
            {"Scarecrow Searching for Wisdom",      new Scarecrow()     },
            {"Schadenfreude",                       new Schadenfreude() },
            {"The Scorched Girl",                   new Scorched()      },
            {"The Red Shoes",                       new Shoes()         },
            {"Today's Shy look",                    new Shy()           },
            {"Singing Machine",                     new Singing()       },
            {"Mountain of Smiling Bodies",          new Smiling()       },
            {"Spider Bud",                          new Spider()        },
            {"Blue Star",                           new Star()          },
            {"Dream of a Black Swan",               new Swan()          },
            {"Standard Training-Dummy Rabbit",      new Training()      },
            {"The Lady Facing the Wall",            new WallLady()      },
            {"Opened Can of WellCheers",            new WellCheers()    },
            {"White Night",                         new White()         },
            {"The Big and Will be Bad Wolf",        new Wolf()          },
            {"Warm-hearted Woodsman",               new Woodsman()      },
            {"Yin",                                 new Yin()           }
        }.ToFrozenDictionary();

    }
}

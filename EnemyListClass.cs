using System.Collections.Generic;

namespace GrandiaStatEditor
{
    public class EnemyListClass
    {
        public static List<int> EnemyList()
        {
            List<int> enemyListPosition = new List<int>
            {
            //Gaia Ape
            0x20898,
            //Gaia Horn
            0x31bdc,
            //Dragonoid
            0x40f04,
            //Gaia Drago
            0x50650,
            //Dragon Knight
            0x5e980,
            //Mountain Ape
            0x75c4c,
            //Yeti
            0x898f8,
            //Black Beret
            0x970d0,
            //Rock Man
            0xa8fdc,
            //Magma Man
            0xbb7e4,
            //Iron Giant
            0xcf8cc,
            //Cactus Man
            0xdae64,
            //Vanatos
            0xe5810,
            //Gaia Man
            0xf07d4,
            //Medusa Dancer
            0xff0d0,
            //Lilith
            0x1113dc,
            //Naga Queen
            0x1235b4,
            //Hyena Man
            0x134b50,
            //Wolfman
            0x145a24,
            //Jackal
            0x157780,
            //Red Devil
            0x168e8c,
            //Blue Devil
            0x176e58,
            //Nyalmot
            0x184da4,
            //Pink Mage
            0x192978,
            //Shaman
            0x19f978,
            //Layelah
            0x1ac978,
            //Pteranobone
            0x1b9f34,
            //Bird Skull
            0x1c61a0,
            //Skeleton
            0x1d29e8,
            //Zombie
            0x1dc44c,
            //Lich
            0x1e84f4,
            //Gaia Zombie
            0x1f3dc0,
            //Warp Man
            0x201f30,
            //Gaia Knight
            0x215d90,
            //Spacetime Armor
            0x22a0ac,
            //Ghostoid
            0x238780,
            //Vengeful Spirit
            0x244ce0,
            //Ghost
            0x2535a4,
            //Lost Soul
            0x25ec70,
            //Critter
            0x268b0c,
            //Will-O'-Wisp
            0x272d9c,
            //Hot Dog
            0x280384,
            //Fire Hound
            0x293b18,
            //Cerberus
            0x2a4340,
            //Snow Boar
            0x2b9914,
            //King Horn
            0x2cd914,
            //Milda
            0x2e3dd8,
            //Glug Bird
            0x2fed08,
            //Thud Bird
            0x30cff8,
            //Flap Bird
            0x31b888,
            //Sphytaros
            0x32c434,
            //Sphynx
            0x340880,
            //Guardian
            0x355420,
            //Land Slug
            0x369d08,
            //Huge Pupa
            0x37c708,
            //Gaia Slug
            0x3918a0,
            //Gaia Devil
            0x39ff58,
            //Toad Demon
            0x3aab18,
            //Satan
            0x3b5ef8,
            //Baby Bat
            0x3bb8d8,
            //Vampire Bat
            0x3c21a8,
            //Sonic Bat
            0x3c91cc,
            //Magic Head
            0x3d2e08,
            //Gaia Brain
            0x3e1314,
            //Brain Bat
            0x3eeb10,
            //Clay Bird
            0x4011bc,
            //Rock Bird
            0x414cb4,
            //Emerald Bird
            0x42b9bc,
            //Sweet Moth
            0x43cb2c,
            //Dizzy Moth
            0x44d710,
            //Giant Moth
            0x45df90,
            //Plop Mold
            0x46d9d0,
            //Mold Bird
            0x47b9d0,
            //Gaia Mold
            0x489bcc,
            //Marna Bug
            0x4953e8,
            //Beetlebug
            0x4a1548,
            //Metal Beetle
            0x4adaf8,
            //Zil Scorpion
            0x4bbbb8,
            //Scissorlock
            0x4c728c,
            //Gaia Demon
            0x4d2db0,
            //Crimsona
            0x4daaf8,
            //Lesser Crab
            0x4e3b60,
            //Gaia Alien
            0x4ecbb0,
            //Spyder
            0x4f8a9c,
            //Black Widow
            0x50629c,
            //Tarantula
            0x513a9c,
            //Ammonite
            0x52152c,
            //Mad Snail
            0x52fd2c,
            //Gaia Cyst
            0x53a8fc,
            //Sea Jelly
            0x5434e4,
            //Mud Jelly
            0x550b78,
            //Hermit Crab
            0x5622c8,
            //Scarab
            0x57530c,
            //Gaia Cancer
            0x58836c,
            //Sea Star
            0x59abec,
            //Starfish
            0x5ac7ac,
            //Gaia Star
            0x5bff3c,
            //Blue Kite
            0x5ce0b0,
            //Manta Ray
            0x5daab4,
            //Stingray
            0x5e7a7c,
            //Sand Diver
            0x5f4374,
            //Sand Man
            0x602b1c,
            //Gaia Scorpion
            0x61228c,
            //Giant Centipede
            0x61c01c,
            //Inchworm
            0x628de4,
            //Roadcrawler
            0x635e14,
            //Spitting Cobra
            0x64172c,
            //Pit Viper
            0x64d850,
            //Sand Worm
            0x657454,
            //Sand Snake
            0x668a30,
            //Gaia Snake
            0x673c54,
            //Chameleon
            0x681fb0,
            //Alligator
            0x6929e8,
            //Salamadile
            0x6a3430,
            //Gill Newt
            0x6b4464,
            //Oopa-Loopa
            0x6c5174,
            //Gaia Fly
            0x6d76fc,
            //Horned Toad
            0x6e3778,
            //Mad Frog
            0x6eeccc,
            //Toad King
            0x6f9ccc,
            //Hippocamp
            0x705f38,
            //Coelacanth
            0x713a50,
            //Gaia Cactus
            0x721644,
            //Green Slime
            0x72bee0,
            //Purple Slime
            0x734a5c,
            //Red Slime
            0x742794,
            //Grim Haze
            0x7516f4,
            //Gas Cloud
            0x75fcc0,
            //Mist Wraith
            0x76d728,
            //Odd Bird
            0x77d608,
            //Birdrake
            0x78e608,
            //Dodo
            0x79f608,
            //Slipple
            0x7ae3a8,
            //Gripple
            0x7bb330,
            //Stuttle
            0x7c84bc,
            //Ent
            0x7d83fc,
            //Mist Guard
            0x7e5528,
            //Killer Tree
            0x7f2a64,
            //Private
            0x7fe2b8,
            //Sergeant
            0x80a6f8,
            //Elite Officer
            0x817c00,
            //Klepp Soldier
            0x8289cc,
            //Elite Klepp
            0x8399c4,
            //Klepp Knight
            0x84b564,
            //Lizard Rider
            0x862220,
            //Mad Rider
            0x879800,
            //Klepp Rider
            0x890f38,
            //Squid King
            0x8c02c8,
            //Right Tentacle
            0x8e1064,
            //Left Tentacle
            0x8eb798,
            //Kraken
            0x917e90,
            //Right Tentacle
            0x93a01c,
            //Left Tentacle
            0x945830,
            //Ganymede
            0x958348,
            //Ganymede
            0x97b3c4,
            //Mad Turtle
            0x98db28,
            //Mad Turtle
            0x9b0ba4,
            //Gaia Bird
            0x9bb85c,
            //Gargoyle
            0x9d1b48,
            //Gargoyle
            0x9f4bc4,
            //Madragon
            0xa25b58,
            //Madragon
            0xa3e824,
            //Skip
            0xa450c0,
            //Phantom Dragon
            0xa7635c,
            //Phantom Dragon
            0xa8f044,
            //Massacre Machine
            0xabed94,
            //Eye
            0xacd7c0,
            //Massacre Machine
            0xafd594,
            //Eye
            0xb0bfc0,
            //Serpent
            0xb1e6c0,
            //Mean Head
            0xb38130,
            //Hot Head
            0xb3bb88,
            //Nice Head
            0xb3e9d8,
            //Bad Head
            0xb42954,
            //Hydra
            0xb546ac,
            //Peril Head
            0xb6df1c,
            //Hot Head
            0xb71294,
            //Nice Head
            0xb74140,
            //Awful Head
            0xb77e6c,
            //Trent
            0xb9f358,
            //Arm
            0xbb9254,
            //Flower
            0xbbd80c,
            //Gaia Trent
            0xbe5358,
            //Arm
            0xbff254,
            //Flower
            0xc0380c,
            //Lord's Ghost
            0xc2b738,
            //Lord's Ghost
            0xc48c50,
            //Wand
            0xc4d2b4,
            //Mage King
            0xc74f38,
            //Mage King
            0xc92448,
            //Wand
            0xc96ab4,
            //Ruin Guard
            0xcc7e68,
            //Ax
            0xce0f60,
            //Skip
            0xce1694,
            //Boomerang
            0xce3a38,
            //Great Susano-o
            0xd13518,
            //Ax
            0xd2c9c4,
            //Iron Ball
            0xd31244,
            //Chang
            0xd4a268,
            //Gadwin
            0xd75560,
            //Gadwin
            0xd9cd60,
            //Kung Fu Master
            0xdc7a8c,
            //Mullen
            0xdfb718,
            //Saki
            0xe234c4,
            //Saki
            0xe404c8,
            //Mio
            0xe58fa0,
            //Mio
            0xe71fa4,
            //Nana
            0xe8dde0,
            //Nana
            0xea95e4,
            //Grinwhale
            0xecf530,
            //Lure
            0xee6740,
            //Slug Fish
            0xf03d8c,
            //Lure
            0xf1af40,
            //Baal
            0xf546ec,
            //Baal
            0xf7a42c,
            //Gaia Tentacle
            0xfb5f4c,
            //Baal
            0xfcf5bc,
            //Gaia Tentacle
            0xff0d94,
            //Gaia Tentacle
            0xffe7ac,
            //Gaia Battler
            0x101d6a0,
            //Right Hand
            0x10360e0,
            //Left Hand
            0x1039e5c,
            //Gaia Battler
            0x10586a0,
            //Right Hand
            0x10710e0,
            //Left Hand
            0x1074e5c,
            //Gaia Battler
            0x10936a0,
            //Right Hand
            0x10ac0e0,
            //Left Hand
            0x10afe5c,
            //Gaia Battler
            0x10ce6a0,
            //Right Hand
            0x10e70e0,
            //Left Hand
            0x10eae5c,
            //Gaia Core
            0x1102fb8,
            //Mega Gaia
            0x1137a90,
            //Gaia Tentacle
            0x113bd08,
            //Evil Gaia
            0x1103014,
            //Giga Gaia
            //NONE
            //Gaia Armor
            0x116f574,
            //Eye
            0x117e010,
            //Gaia Slime
            0x11870ec,
            //Combatant
            0x11965a4,
            //Gaia Tree
            0x11a5e20,
            //Gaia Beetle
            0x11b3ad8,
            //Leviathan
            0x11e97c0,
            //Right Tentacle
            0x120b2d0,
            //Left Tentacle
            0x1215bac,
            //Orc
            0x121e978,
            //Orc King
            0x122e460,
            //Dom Orc
            0x1243d9c,
            };

            return enemyListPosition;
        }
    }
}

using Figgle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static string Picker(string[] words)
        {
            Random generator = new Random();
            var index = generator.Next(0, words.Length);
            return words[index];
        }
        static void Main(string[] args)
        {
            string[] Adjectives = {
                "artless",
                "beslubbering",
                "bootless",
                "churlish",
                "clouted",
                "craven",
                "currish",
                "dankish",
                "dissembling",
                "droning",
                "errant",
                "fawning",
                "fobbing",
                "froward",
                "frothy",
                "gleeking",
                "goatish",
                "gorbellied",
                "impertinent",
                "infectious",
                "jarring",
                "loggerheaded",
                "lumpish",
                "mammering",
                "mangled",
                "mewling",
                "paunchy",
                "pribbling",
                "puking",
                "puny",
                "qualling",
                "rank",
                "reeky",
                "roguish",
                "spleeny",
                "spongy",
                "surly",
                "tottering",
                "unmuzzled",
                "vain",
                "venomed",
                "villainous",
                "warped",
                "wayward",
                "weedy",
                "yeasty",
            };
            string[] CompoundAdjectives =
            {
                "base-court",
                "bat-fowling",
                "beef-witted",
                "beetle-headed",
                "boil-brained",
                "clapper-clawed",
                "clay-brained",
                "common-kissing",
                "crook-pated",
                "dismal-dreaming",
                "dizzy-eyed",
                "doghearted",
                "dread-bolted",
                "earth-vexing",
                "elf-skinned",
                "fat-kidneyed",
                "flap-mouthed",
                "fly-bitten",
                "folly-fallen",
                "fool-born",
                "full-gorged",
                "guts-griping",
                "half-faced",
                "hasty-witted",
                "hedge-born",
                "hell-hated",
                "idle-headed",
                "ill-nurtured",
                "knotty-pated",
                "milk-livered",
                "motley-minded",
                "onion-eyed",
                "plume-plucked",
                "pottle-deep",
                "pox-marked",
                "reeling-ripe",
                "rough-hewn",
                "rude-growing",
                "rump-fed",
                "shard-borne",
                "sheep-biting",
                "spur-galled",
            "swag-bellied",
            "tardy-gaited",
            "tickle-brained",
            "toad-spotted",
            "unchin-snouted",
            "weather-bitten",
            };
            string[] Nouns = {
              "apple-john",
            "baggage",
            "barnacle",
            "bladder",
            "boar-pig",
            "bugbear",
            "bum-bailey",
            "canker-blossom",
            "clack-dish",
            "clotpole",
            "coxcomb",
            "codpiece",
            "death-token",
            "dewberry",
            "flap-dragon",
            "flax-wench",
            "flirt-gill",
            "foot-licker",
            "fustilarian",
            "giglet",
            "gudgeon",
            "haggard",
            "harpy",
            "hedge-pig",
            "horn-beast",
            "hugger-mugger",
            "joithead",
            "lewdster",
            "lout",
            "maggot-pie",
            "malt-worm",
            "mammet",
            "measle",
            "minnow",
            "miscreant",
            "moldwarp",
            "mumble-news",
            "nut-hook",
            "pigeon-egg",
            "pignut",
            "puttock",
            "pumpion",
            "ratsbane",
            "scut",
            "skainsmate",
            "strumpet",
            "varlot",
            "vassal",
            "whey-face",
            "wagtail",
            };
            Console.WriteLine(
                FiggleFonts.Standard.Render("Happy April Fools Day!"));

            string adjective = Picker(Adjectives);
            string compoundAdjective = Picker(CompoundAdjectives);
            string noun = Picker(Nouns);

            Console.WriteLine("Thou {0} {1} {2}!!", adjective.ToUpper(), compoundAdjective.ToUpper(), noun.ToUpper());

            Console.ReadKey();
        }
    }
}

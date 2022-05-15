using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Dom5Logic.Model
{
    public partial class dom5Context : DbContext
    {
        public dom5Context()
        {
        }

        public dom5Context(DbContextOptions<dom5Context> options)
            : base(options)
        {
        }

        public virtual DbSet<BaseUDb> BaseUs { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlite("Data Source=dom5.db;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BaseUDb>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("BaseU");

                entity.Property(e => e.Aboleth).HasColumnName("aboleth");

                entity.Property(e => e.Aciddigest).HasColumnName("aciddigest");

                entity.Property(e => e.Acidshield).HasColumnName("acidshield");

                entity.Property(e => e.Addrandomage).HasColumnName("addrandomage");

                entity.Property(e => e.Adeptsacr).HasColumnName("adeptsacr");

                entity.Property(e => e.Adventurers).HasColumnName("adventurers");

                entity.Property(e => e.Ainorec).HasColumnName("ainorec");

                entity.Property(e => e.Airattuned).HasColumnName("airattuned");

                entity.Property(e => e.Aisinglerec).HasColumnName("aisinglerec");

                entity.Property(e => e.Alch).HasColumnName("alch");

                entity.Property(e => e.Alchemy).HasColumnName("alchemy");

                entity.Property(e => e.Allrange).HasColumnName("allrange");

                entity.Property(e => e.Allret).HasColumnName("allret");

                entity.Property(e => e.Almostundead).HasColumnName("almostundead");

                entity.Property(e => e.Ambidextrous).HasColumnName("ambidextrous");

                entity.Property(e => e.Amphibian).HasColumnName("amphibian");

                entity.Property(e => e.Animal).HasColumnName("animal");

                entity.Property(e => e.Animalawe).HasColumnName("animalawe");

                entity.Property(e => e.Ap).HasColumnName("ap");

                entity.Property(e => e.Appetite).HasColumnName("appetite");

                entity.Property(e => e.Aquatic).HasColumnName("aquatic");

                entity.Property(e => e.Armor1).HasColumnName("armor1");

                entity.Property(e => e.Armor2).HasColumnName("armor2");

                entity.Property(e => e.Armor3).HasColumnName("armor3");

                entity.Property(e => e.Armor4).HasColumnName("armor4");

                entity.Property(e => e.Assassin).HasColumnName("assassin");

                entity.Property(e => e.Astralattuned).HasColumnName("astralattuned");

                entity.Property(e => e.Astralfetters).HasColumnName("astralfetters");

                entity.Property(e => e.Astralrange).HasColumnName("astralrange");

                entity.Property(e => e.Att).HasColumnName("att");

                entity.Property(e => e.Autoblessed).HasColumnName("autoblessed");

                entity.Property(e => e.Autocompete).HasColumnName("autocompete");

                entity.Property(e => e.Autodishealer).HasColumnName("autodishealer");

                entity.Property(e => e.Autohealer).HasColumnName("autohealer");

                entity.Property(e => e.Autosum).HasColumnName("autosum");

                entity.Property(e => e.Awe).HasColumnName("awe");

                entity.Property(e => e.Banefireshield).HasColumnName("banefireshield");

                entity.Property(e => e.Basecost).HasColumnName("basecost");

                entity.Property(e => e.Batstartsum1).HasColumnName("batstartsum1");

                entity.Property(e => e.Batstartsum1d3).HasColumnName("batstartsum1d3");

                entity.Property(e => e.Batstartsum1d6).HasColumnName("batstartsum1d6");

                entity.Property(e => e.Batstartsum2).HasColumnName("batstartsum2");

                entity.Property(e => e.Batstartsum2d6).HasColumnName("batstartsum2d6");

                entity.Property(e => e.Batstartsum3).HasColumnName("batstartsum3");

                entity.Property(e => e.Batstartsum3d6).HasColumnName("batstartsum3d6");

                entity.Property(e => e.Batstartsum4).HasColumnName("batstartsum4");

                entity.Property(e => e.Batstartsum4d6).HasColumnName("batstartsum4d6");

                entity.Property(e => e.Batstartsum5).HasColumnName("batstartsum5");

                entity.Property(e => e.Batstartsum5d6).HasColumnName("batstartsum5d6");

                entity.Property(e => e.Batstartsum6d6).HasColumnName("batstartsum6d6");

                entity.Property(e => e.Battlesum5).HasColumnName("battlesum5");

                entity.Property(e => e.Beartattoo).HasColumnName("beartattoo");

                entity.Property(e => e.Beastmaster).HasColumnName("beastmaster");

                entity.Property(e => e.Beckon).HasColumnName("beckon");

                entity.Property(e => e.Berserk).HasColumnName("berserk");

                entity.Property(e => e.Blessbers).HasColumnName("blessbers");

                entity.Property(e => e.Blessfly).HasColumnName("blessfly");

                entity.Property(e => e.Blind).HasColumnName("blind");

                entity.Property(e => e.Bloodattuned).HasColumnName("bloodattuned");

                entity.Property(e => e.Bloodvengeance).HasColumnName("bloodvengeance");

                entity.Property(e => e.Bluntres).HasColumnName("bluntres");

                entity.Property(e => e.Boartattoo).HasColumnName("boartattoo");

                entity.Property(e => e.Body).HasColumnName("body");

                entity.Property(e => e.Bodyguard).HasColumnName("bodyguard");

                entity.Property(e => e.Bonusspells).HasColumnName("bonusspells");

                entity.Property(e => e.Bringeroffortune).HasColumnName("bringeroffortune");

                entity.Property(e => e.Buffer).HasColumnName("buffer");

                entity.Property(e => e.Bug).HasColumnName("bug");

                entity.Property(e => e.Bugreform).HasColumnName("bugreform");

                entity.Property(e => e.Carcasscollector).HasColumnName("carcasscollector");

                entity.Property(e => e.Castledef).HasColumnName("castledef");

                entity.Property(e => e.Cavesurvival).HasColumnName("cavesurvival");

                entity.Property(e => e.Changetargetgenderforseductionandseductionimmune).HasColumnName("changetargetgenderforseductionandseductionimmune");

                entity.Property(e => e.Chaospower).HasColumnName("chaospower");

                entity.Property(e => e.Chaosrec).HasColumnName("chaosrec");

                entity.Property(e => e.Cleanshape).HasColumnName("cleanshape");

                entity.Property(e => e.Clockworklord).HasColumnName("clockworklord");

                entity.Property(e => e.Cold).HasColumnName("cold");

                entity.Property(e => e.Coldblood).HasColumnName("coldblood");

                entity.Property(e => e.Coldpower).HasColumnName("coldpower");

                entity.Property(e => e.Coldrec).HasColumnName("coldrec");

                entity.Property(e => e.Coldres).HasColumnName("coldres");

                entity.Property(e => e.Coldsummon).HasColumnName("coldsummon");

                entity.Property(e => e.Combatcaster).HasColumnName("combatcaster");

                entity.Property(e => e.Commaster).HasColumnName("commaster");

                entity.Property(e => e.Comslave).HasColumnName("comslave");

                entity.Property(e => e.Corpseconstruct).HasColumnName("corpseconstruct");

                entity.Property(e => e.Corpseeater).HasColumnName("corpseeater");

                entity.Property(e => e.Corrupt).HasColumnName("corrupt");

                entity.Property(e => e.Crossbreeder).HasColumnName("crossbreeder");

                entity.Property(e => e.Crownonly).HasColumnName("crownonly");

                entity.Property(e => e.Curseattacker).HasColumnName("curseattacker");

                entity.Property(e => e.Curseluckshield).HasColumnName("curseluckshield");

                entity.Property(e => e.Damagerev).HasColumnName("damagerev");

                entity.Property(e => e.Darkpower).HasColumnName("darkpower");

                entity.Property(e => e.Darkvision).HasColumnName("darkvision");

                entity.Property(e => e.Deathattuned).HasColumnName("deathattuned");

                entity.Property(e => e.Deathcurse).HasColumnName("deathcurse");

                entity.Property(e => e.Deathdisease).HasColumnName("deathdisease");

                entity.Property(e => e.Deathfire).HasColumnName("deathfire");

                entity.Property(e => e.Deathparalyze).HasColumnName("deathparalyze");

                entity.Property(e => e.Deathpower).HasColumnName("deathpower");

                entity.Property(e => e.Deathrec).HasColumnName("deathrec");

                entity.Property(e => e.Def).HasColumnName("def");

                entity.Property(e => e.Defector).HasColumnName("defector");

                entity.Property(e => e.Defenceorganiser).HasColumnName("defenceorganiser");

                entity.Property(e => e.Defiler).HasColumnName("defiler");

                entity.Property(e => e.Demon).HasColumnName("demon");

                entity.Property(e => e.Digest).HasColumnName("digest");

                entity.Property(e => e.Disbelieve).HasColumnName("disbelieve");

                entity.Property(e => e.Diseasecloud).HasColumnName("diseasecloud");

                entity.Property(e => e.Diseaseres).HasColumnName("diseaseres");

                entity.Property(e => e.Divineins).HasColumnName("divineins");

                entity.Property(e => e.Domimmortal).HasColumnName("domimmortal");

                entity.Property(e => e.Domsummon).HasColumnName("domsummon");

                entity.Property(e => e.Domsummon20).HasColumnName("domsummon20");

                entity.Property(e => e.Douse).HasColumnName("douse");

                entity.Property(e => e.Dragonlord).HasColumnName("dragonlord");

                entity.Property(e => e.Drainimmune).HasColumnName("drainimmune");

                entity.Property(e => e.Drake).HasColumnName("drake");

                entity.Property(e => e.Dreanimator).HasColumnName("dreanimator");

                entity.Property(e => e.Dungeon).HasColumnName("dungeon");

                entity.Property(e => e.Earthattuned).HasColumnName("earthattuned");

                entity.Property(e => e.Elegist).HasColumnName("elegist");

                entity.Property(e => e.Elementrange).HasColumnName("elementrange");

                entity.Property(e => e.Enc).HasColumnName("enc");

                entity.Property(e => e.Enchrebate10).HasColumnName("enchrebate10");

                entity.Property(e => e.Enchrebate50).HasColumnName("enchrebate50");

                entity.Property(e => e.Enchrebate50p).HasColumnName("enchrebate50p");

                entity.Property(e => e.End).HasColumnName("end");

                entity.Property(e => e.Entangle).HasColumnName("entangle");

                entity.Property(e => e.Ethereal).HasColumnName("ethereal");

                entity.Property(e => e.Ethtrue).HasColumnName("ethtrue");

                entity.Property(e => e.Event).HasColumnName("event");

                entity.Property(e => e.Eyeloss).HasColumnName("eyeloss");

                entity.Property(e => e.Eyes).HasColumnName("eyes");

                entity.Property(e => e.Fallpower).HasColumnName("fallpower");

                entity.Property(e => e.Falsearmy).HasColumnName("falsearmy");

                entity.Property(e => e.Farthronekill).HasColumnName("farthronekill");

                entity.Property(e => e.Fear).HasColumnName("fear");

                entity.Property(e => e.Female).HasColumnName("female");

                entity.Property(e => e.Fireattuned).HasColumnName("fireattuned");

                entity.Property(e => e.Firepower).HasColumnName("firepower");

                entity.Property(e => e.Firerange).HasColumnName("firerange");

                entity.Property(e => e.Fireres).HasColumnName("fireres");

                entity.Property(e => e.Fireshield).HasColumnName("fireshield");

                entity.Property(e => e.Firstshape).HasColumnName("firstshape");

                entity.Property(e => e.Fixedname).HasColumnName("fixedname");

                entity.Property(e => e.Fixedresearch).HasColumnName("fixedresearch");

                entity.Property(e => e.Fixforgebonus).HasColumnName("fixforgebonus");

                entity.Property(e => e.Float).HasColumnName("float");

                entity.Property(e => e.Flying).HasColumnName("flying");

                entity.Property(e => e.Foot).HasColumnName("foot");

                entity.Property(e => e.Foreignmagicboost).HasColumnName("foreignmagicboost");

                entity.Property(e => e.Forestshape).HasColumnName("forestshape");

                entity.Property(e => e.Forestsurvival).HasColumnName("forestsurvival");

                entity.Property(e => e.Forgebonus).HasColumnName("forgebonus");

                entity.Property(e => e.Formationfighter).HasColumnName("formationfighter");

                entity.Property(e => e.Fortkill).HasColumnName("fortkill");

                entity.Property(e => e.Gem).HasColumnName("gem");

                entity.Property(e => e.Gemprod).HasColumnName("gemprod");

                entity.Property(e => e.Graphicsize).HasColumnName("graphicsize");

                entity.Property(e => e.Growhp).HasColumnName("growhp");

                entity.Property(e => e.Guardianspiritmodifier).HasColumnName("guardianspiritmodifier");

                entity.Property(e => e.Haltheretic).HasColumnName("haltheretic");

                entity.Property(e => e.Hand).HasColumnName("hand");

                entity.Property(e => e.Head).HasColumnName("head");

                entity.Property(e => e.Heal).HasColumnName("heal");

                entity.Property(e => e.Heat).HasColumnName("heat");

                entity.Property(e => e.Heathensummon).HasColumnName("heathensummon");

                entity.Property(e => e.Heatrec).HasColumnName("heatrec");

                entity.Property(e => e.Heretic).HasColumnName("heretic");

                entity.Property(e => e.Holy).HasColumnName("holy");

                entity.Property(e => e.Homeshape).HasColumnName("homeshape");

                entity.Property(e => e.Homesick).HasColumnName("homesick");

                entity.Property(e => e.Horror).HasColumnName("horror");

                entity.Property(e => e.Horrordeserter).HasColumnName("horrordeserter");

                entity.Property(e => e.Horrormark).HasColumnName("horrormark");

                entity.Property(e => e.Horrormarked).HasColumnName("horrormarked");

                entity.Property(e => e.Horsetattoo).HasColumnName("horsetattoo");

                entity.Property(e => e.Hp).HasColumnName("hp");

                entity.Property(e => e.Hpoverflow).HasColumnName("hpoverflow");

                entity.Property(e => e.Hpoverslow).HasColumnName("hpoverslow");

                entity.Property(e => e.Iceforging).HasColumnName("iceforging");

                entity.Property(e => e.Iceprot).HasColumnName("iceprot");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Illusion).HasColumnName("illusion");

                entity.Property(e => e.Illusionary).HasColumnName("illusionary");

                entity.Property(e => e.Immobile).HasColumnName("immobile");

                entity.Property(e => e.Immortal).HasColumnName("immortal");

                entity.Property(e => e.Immortalrespawn).HasColumnName("immortalrespawn");

                entity.Property(e => e.Inanimate).HasColumnName("inanimate");

                entity.Property(e => e.Incorporate).HasColumnName("incorporate");

                entity.Property(e => e.Incprovdef).HasColumnName("incprovdef");

                entity.Property(e => e.Incunrest).HasColumnName("incunrest");

                entity.Property(e => e.Indepmove).HasColumnName("indepmove");

                entity.Property(e => e.Indepspells).HasColumnName("indepspells");

                entity.Property(e => e.Indepstay).HasColumnName("indepstay");

                entity.Property(e => e.Infernoret).HasColumnName("infernoret");

                entity.Property(e => e.Inquisitor).HasColumnName("inquisitor");

                entity.Property(e => e.Insane).HasColumnName("insane");

                entity.Property(e => e.Insanify).HasColumnName("insanify");

                entity.Property(e => e.Inspirational).HasColumnName("inspirational");

                entity.Property(e => e.Inspiringres).HasColumnName("inspiringres");

                entity.Property(e => e.Invisible).HasColumnName("invisible");

                entity.Property(e => e.Invulnerable).HasColumnName("invulnerable");

                entity.Property(e => e.Ironvul).HasColumnName("ironvul");

                entity.Property(e => e.Isadaeva).HasColumnName("isadaeva");

                entity.Property(e => e.Isashah).HasColumnName("isashah");

                entity.Property(e => e.Isayazad).HasColumnName("isayazad");

                entity.Property(e => e.Ivylord).HasColumnName("ivylord");

                entity.Property(e => e.Kokytosret).HasColumnName("kokytosret");

                entity.Property(e => e.Labpromotion).HasColumnName("labpromotion");

                entity.Property(e => e.Lamialord).HasColumnName("lamialord");

                entity.Property(e => e.Lanceok).HasColumnName("lanceok");

                entity.Property(e => e.Landdamage).HasColumnName("landdamage");

                entity.Property(e => e.Landenc).HasColumnName("landenc");

                entity.Property(e => e.Landreinvigoration).HasColumnName("landreinvigoration");

                entity.Property(e => e.Landshape).HasColumnName("landshape");

                entity.Property(e => e.Latehero).HasColumnName("latehero");

                entity.Property(e => e.Leader).HasColumnName("leader");

                entity.Property(e => e.Leper).HasColumnName("leper");

                entity.Property(e => e.Link1).HasColumnName("link1");

                entity.Property(e => e.Link2).HasColumnName("link2");

                entity.Property(e => e.Link3).HasColumnName("link3");

                entity.Property(e => e.Link4).HasColumnName("link4");

                entity.Property(e => e.Link5).HasColumnName("link5");

                entity.Property(e => e.Link6).HasColumnName("link6");

                entity.Property(e => e.Localsun).HasColumnName("localsun");

                entity.Property(e => e.Magicbeing).HasColumnName("magicbeing");

                entity.Property(e => e.MagicboostA).HasColumnName("magicboostA");

                entity.Property(e => e.MagicboostAll).HasColumnName("magicboostALL");

                entity.Property(e => e.MagicboostD).HasColumnName("magicboostD");

                entity.Property(e => e.MagicboostE).HasColumnName("magicboostE");

                entity.Property(e => e.MagicboostF).HasColumnName("magicboostF");

                entity.Property(e => e.MagicboostN).HasColumnName("magicboostN");

                entity.Property(e => e.MagicboostS).HasColumnName("magicboostS");

                entity.Property(e => e.MagicboostW).HasColumnName("magicboostW");

                entity.Property(e => e.Magicleader).HasColumnName("magicleader");

                entity.Property(e => e.Magicpower).HasColumnName("magicpower");

                entity.Property(e => e.Magicstudy).HasColumnName("magicstudy");

                entity.Property(e => e.Makepearls).HasColumnName("makepearls");

                entity.Property(e => e.Mapmove).HasColumnName("mapmove");

                entity.Property(e => e.Mask1).HasColumnName("mask1");

                entity.Property(e => e.Mask2).HasColumnName("mask2");

                entity.Property(e => e.Mask3).HasColumnName("mask3");

                entity.Property(e => e.Mask4).HasColumnName("mask4");

                entity.Property(e => e.Mask5).HasColumnName("mask5");

                entity.Property(e => e.Mask6).HasColumnName("mask6");

                entity.Property(e => e.Mason).HasColumnName("mason");

                entity.Property(e => e.Mastersmith).HasColumnName("mastersmith");

                entity.Property(e => e.Maxage).HasColumnName("maxage");

                entity.Property(e => e.Mind).HasColumnName("mind");

                entity.Property(e => e.Mindcollar).HasColumnName("mindcollar");

                entity.Property(e => e.Mindslime).HasColumnName("mindslime");

                entity.Property(e => e.Mindvessel).HasColumnName("mindvessel");

                entity.Property(e => e.Minprison).HasColumnName("minprison");

                entity.Property(e => e.Minsizeleader).HasColumnName("minsizeleader");

                entity.Property(e => e.Misc).HasColumnName("misc");

                entity.Property(e => e.Mor).HasColumnName("mor");

                entity.Property(e => e.Moralebonus).HasColumnName("moralebonus");

                entity.Property(e => e.Mountainrec).HasColumnName("mountainrec");

                entity.Property(e => e.Mountainsurvival).HasColumnName("mountainsurvival");

                entity.Property(e => e.Mounted).HasColumnName("mounted");

                entity.Property(e => e.Mountedbeserk).HasColumnName("mountedbeserk");

                entity.Property(e => e.Mr).HasColumnName("mr");

                entity.Property(e => e.Mummification).HasColumnName("mummification");

                entity.Property(e => e.Mummify).HasColumnName("mummify");

                entity.Property(e => e.NAutosum).HasColumnName("n_autosum");

                entity.Property(e => e.NSummon).HasColumnName("n_summon");

                entity.Property(e => e.Name).HasColumnName("name");

                entity.Property(e => e.Nametype).HasColumnName("nametype");

                entity.Property(e => e.Natureattuned).HasColumnName("natureattuned");

                entity.Property(e => e.Naturerange).HasColumnName("naturerange");

                entity.Property(e => e.Nbr1).HasColumnName("nbr1");

                entity.Property(e => e.Nbr2).HasColumnName("nbr2");

                entity.Property(e => e.Nbr3).HasColumnName("nbr3");

                entity.Property(e => e.Nbr4).HasColumnName("nbr4");

                entity.Property(e => e.Nbr5).HasColumnName("nbr5");

                entity.Property(e => e.Nbr6).HasColumnName("nbr6");

                entity.Property(e => e.Neednoteat).HasColumnName("neednoteat");

                entity.Property(e => e.Noarmormapmovepenalty).HasColumnName("noarmormapmovepenalty");

                entity.Property(e => e.Nobadevents).HasColumnName("nobadevents");

                entity.Property(e => e.Noheal).HasColumnName("noheal");

                entity.Property(e => e.Nohof).HasColumnName("nohof");

                entity.Property(e => e.Nomovepen).HasColumnName("nomovepen");

                entity.Property(e => e.Norange).HasColumnName("norange");

                entity.Property(e => e.Noriverpass).HasColumnName("noriverpass");

                entity.Property(e => e.Nowish).HasColumnName("nowish");

                entity.Property(e => e.Older).HasColumnName("older");

                entity.Property(e => e.Onebattlespell).HasColumnName("onebattlespell");

                entity.Property(e => e.Onisummon).HasColumnName("onisummon");

                entity.Property(e => e.Pathboost).HasColumnName("pathboost");

                entity.Property(e => e.Pathboostland).HasColumnName("pathboostland");

                entity.Property(e => e.Pathboostuw).HasColumnName("pathboostuw");

                entity.Property(e => e.Pathcost).HasColumnName("pathcost");

                entity.Property(e => e.Patience).HasColumnName("patience");

                entity.Property(e => e.Patrolbonus).HasColumnName("patrolbonus");

                entity.Property(e => e.Percentpathreduction).HasColumnName("percentpathreduction");

                entity.Property(e => e.Petrify).HasColumnName("petrify");

                entity.Property(e => e.Pierceres).HasColumnName("pierceres");

                entity.Property(e => e.Pillagebonus).HasColumnName("pillagebonus");

                entity.Property(e => e.Plaguedoctor).HasColumnName("plaguedoctor");

                entity.Property(e => e.Plainshape).HasColumnName("plainshape");

                entity.Property(e => e.Plant).HasColumnName("plant");

                entity.Property(e => e.Poisonarmor).HasColumnName("poisonarmor");

                entity.Property(e => e.Poisoncloud).HasColumnName("poisoncloud");

                entity.Property(e => e.Poisonres).HasColumnName("poisonres");

                entity.Property(e => e.Poisonskin).HasColumnName("poisonskin");

                entity.Property(e => e.Polyimmune).HasColumnName("polyimmune");

                entity.Property(e => e.Pooramphibian).HasColumnName("pooramphibian");

                entity.Property(e => e.Popkill).HasColumnName("popkill");

                entity.Property(e => e.Preanimator).HasColumnName("preanimator");

                entity.Property(e => e.Prec).HasColumnName("prec");

                entity.Property(e => e.Prophetshape).HasColumnName("prophetshape");

                entity.Property(e => e.Prot).HasColumnName("prot");

                entity.Property(e => e.Raiseonkill).HasColumnName("raiseonkill");

                entity.Property(e => e.Raiseshape).HasColumnName("raiseshape");

                entity.Property(e => e.Rand1).HasColumnName("rand1");

                entity.Property(e => e.Rand2).HasColumnName("rand2");

                entity.Property(e => e.Rand3).HasColumnName("rand3");

                entity.Property(e => e.Rand4).HasColumnName("rand4");

                entity.Property(e => e.Rand5).HasColumnName("rand5");

                entity.Property(e => e.Rand6).HasColumnName("rand6");

                entity.Property(e => e.Randomspell).HasColumnName("randomspell");

                entity.Property(e => e.Raredomsummon).HasColumnName("raredomsummon");

                entity.Property(e => e.Rcost).HasColumnName("rcost");

                entity.Property(e => e.Realm1).HasColumnName("realm1");

                entity.Property(e => e.Realm2).HasColumnName("realm2");

                entity.Property(e => e.Realm3).HasColumnName("realm3");

                entity.Property(e => e.Reanimator).HasColumnName("reanimator");

                entity.Property(e => e.Reanimator2).HasColumnName("reanimator2");

                entity.Property(e => e.Reanimpriest).HasColumnName("reanimpriest");

                entity.Property(e => e.Reclimit).HasColumnName("reclimit");

                entity.Property(e => e.Reform).HasColumnName("reform");

                entity.Property(e => e.Reformtime).HasColumnName("reformtime");

                entity.Property(e => e.Regeneration).HasColumnName("regeneration");

                entity.Property(e => e.Reinc).HasColumnName("reinc");

                entity.Property(e => e.Reincarnation).HasColumnName("reincarnation");

                entity.Property(e => e.Reinvigoration).HasColumnName("reinvigoration");

                entity.Property(e => e.Reqlab).HasColumnName("reqlab");

                entity.Property(e => e.Reqtemple).HasColumnName("reqtemple");

                entity.Property(e => e.Researchbonus).HasColumnName("researchbonus");

                entity.Property(e => e.Researchwithoutmagic).HasColumnName("researchwithoutmagic");

                entity.Property(e => e.Resources).HasColumnName("resources");

                entity.Property(e => e.Ressize).HasColumnName("ressize");

                entity.Property(e => e.Rpcost).HasColumnName("rpcost");

                entity.Property(e => e.Rt).HasColumnName("rt");

                entity.Property(e => e.Sailingmaxunitsize).HasColumnName("sailingmaxunitsize");

                entity.Property(e => e.Sailingshipsize).HasColumnName("sailingshipsize");

                entity.Property(e => e.Sailsize).HasColumnName("sailsize");

                entity.Property(e => e.Saltvul).HasColumnName("saltvul");

                entity.Property(e => e.Scalewalls).HasColumnName("scalewalls");

                entity.Property(e => e.Secondshape).HasColumnName("secondshape");

                entity.Property(e => e.Secondtmpshape).HasColumnName("secondtmpshape");

                entity.Property(e => e.Seduce).HasColumnName("seduce");

                entity.Property(e => e.Sendlesserhorrormult).HasColumnName("sendlesserhorrormult");

                entity.Property(e => e.Shapechange).HasColumnName("shapechange");

                entity.Property(e => e.Shatteredsoul).HasColumnName("shatteredsoul");

                entity.Property(e => e.Shockres).HasColumnName("shockres");

                entity.Property(e => e.Shrinkhp).HasColumnName("shrinkhp");

                entity.Property(e => e.Siegebonus).HasColumnName("siegebonus");

                entity.Property(e => e.Singlebattle).HasColumnName("singlebattle");

                entity.Property(e => e.Size).HasColumnName("size");

                entity.Property(e => e.Skirmisher).HasColumnName("skirmisher");

                entity.Property(e => e.Slashres).HasColumnName("slashres");

                entity.Property(e => e.Slave).HasColumnName("slave");

                entity.Property(e => e.Slaver).HasColumnName("slaver");

                entity.Property(e => e.Slaverbonus).HasColumnName("slaverbonus");

                entity.Property(e => e.Sleepaura).HasColumnName("sleepaura");

                entity.Property(e => e.Slimer).HasColumnName("slimer");

                entity.Property(e => e.Slothresearch).HasColumnName("slothresearch");

                entity.Property(e => e.Snaketattoo).HasColumnName("snaketattoo");

                entity.Property(e => e.Snowmove).HasColumnName("snowmove");

                entity.Property(e => e.Sorceryrange).HasColumnName("sorceryrange");

                entity.Property(e => e.Special).HasColumnName("special");

                entity.Property(e => e.Speciallook).HasColumnName("speciallook");

                entity.Property(e => e.Spellsinger).HasColumnName("spellsinger");

                entity.Property(e => e.Spiritsight).HasColumnName("spiritsight");

                entity.Property(e => e.Spreadchaos).HasColumnName("spreadchaos");

                entity.Property(e => e.Spreaddeath).HasColumnName("spreaddeath");

                entity.Property(e => e.Spreaddom).HasColumnName("spreaddom");

                entity.Property(e => e.Spreadgrowth).HasColumnName("spreadgrowth");

                entity.Property(e => e.Spreadorder).HasColumnName("spreadorder");

                entity.Property(e => e.Springpower).HasColumnName("springpower");

                entity.Property(e => e.Spy).HasColumnName("spy");

                entity.Property(e => e.Standard).HasColumnName("standard");

                entity.Property(e => e.Startaff).HasColumnName("startaff");

                entity.Property(e => e.Startage).HasColumnName("startage");

                entity.Property(e => e.Startdom).HasColumnName("startdom");

                entity.Property(e => e.Startheroab).HasColumnName("startheroab");

                entity.Property(e => e.Startingaff).HasColumnName("startingaff");

                entity.Property(e => e.Startitem).HasColumnName("startitem");

                entity.Property(e => e.Stealthy).HasColumnName("stealthy");

                entity.Property(e => e.Stonebeing).HasColumnName("stonebeing");

                entity.Property(e => e.Stormimmune).HasColumnName("stormimmune");

                entity.Property(e => e.Stormpower).HasColumnName("stormpower");

                entity.Property(e => e.Str).HasColumnName("str");

                entity.Property(e => e.Stunimmunity).HasColumnName("stunimmunity");

                entity.Property(e => e.Stupid).HasColumnName("stupid");

                entity.Property(e => e.Stygianguide).HasColumnName("stygianguide");

                entity.Property(e => e.Succubus).HasColumnName("succubus");

                entity.Property(e => e.Summerpower).HasColumnName("summerpower");

                entity.Property(e => e.Summon).HasColumnName("summon");

                entity.Property(e => e.Summon1).HasColumnName("summon1");

                entity.Property(e => e.Summon5).HasColumnName("summon5");

                entity.Property(e => e.Sunawe).HasColumnName("sunawe");

                entity.Property(e => e.Supplybonus).HasColumnName("supplybonus");

                entity.Property(e => e.Swampsurvival).HasColumnName("swampsurvival");

                entity.Property(e => e.Swimming).HasColumnName("swimming");

                entity.Property(e => e.Taskmaster).HasColumnName("taskmaster");

                entity.Property(e => e.Taxcollector).HasColumnName("taxcollector");

                entity.Property(e => e.Teleport).HasColumnName("teleport");

                entity.Property(e => e.Templetrainer).HasColumnName("templetrainer");

                entity.Property(e => e.Theftofthesunawe).HasColumnName("theftofthesunawe");

                entity.Property(e => e.Thronekill).HasColumnName("thronekill");

                entity.Property(e => e.Tmpastralgems).HasColumnName("tmpastralgems");

                entity.Property(e => e.Tmpfiregems).HasColumnName("tmpfiregems");

                entity.Property(e => e.Trample).HasColumnName("trample");

                entity.Property(e => e.Trampswallow).HasColumnName("trampswallow");

                entity.Property(e => e.Transformation).HasColumnName("transformation");

                entity.Property(e => e.Triple3mon).HasColumnName("triple3mon");

                entity.Property(e => e.Triplegod).HasColumnName("triplegod");

                entity.Property(e => e.Triplegodmag).HasColumnName("triplegodmag");

                entity.Property(e => e.Turmoilsummon).HasColumnName("turmoilsummon");

                entity.Property(e => e.Twiceborn).HasColumnName("twiceborn");

                entity.Property(e => e.Uncurableaffliction).HasColumnName("uncurableaffliction");

                entity.Property(e => e.Undead).HasColumnName("undead");

                entity.Property(e => e.Undeadleader).HasColumnName("undeadleader");

                entity.Property(e => e.Undisciplined).HasColumnName("undisciplined");

                entity.Property(e => e.Undying).HasColumnName("undying");

                entity.Property(e => e.Unify).HasColumnName("unify");

                entity.Property(e => e.Unique).HasColumnName("unique");

                entity.Property(e => e.Unseen).HasColumnName("unseen");

                entity.Property(e => e.Unsurr).HasColumnName("unsurr");

                entity.Property(e => e.Unteleportable).HasColumnName("unteleportable");

                entity.Property(e => e.Uwbug).HasColumnName("uwbug");

                entity.Property(e => e.Uwdamage).HasColumnName("uwdamage");

                entity.Property(e => e.Uwfireshield).HasColumnName("uwfireshield");

                entity.Property(e => e.Uwheat).HasColumnName("uwheat");

                entity.Property(e => e.Uwregen).HasColumnName("uwregen");

                entity.Property(e => e.Voidsanity).HasColumnName("voidsanity");

                entity.Property(e => e.Voidsum).HasColumnName("voidsum");

                entity.Property(e => e.Wastesurvival).HasColumnName("wastesurvival");

                entity.Property(e => e.Waterattuned).HasColumnName("waterattuned");

                entity.Property(e => e.Waterbreathing).HasColumnName("waterbreathing");

                entity.Property(e => e.Watershape).HasColumnName("watershape");

                entity.Property(e => e.Winterpower).HasColumnName("winterpower");

                entity.Property(e => e.Wintersummon1d3).HasColumnName("wintersummon1d3");

                entity.Property(e => e.Wolf).HasColumnName("wolf");

                entity.Property(e => e.Wolftattoo).HasColumnName("wolftattoo");

                entity.Property(e => e.Woundfend).HasColumnName("woundfend");

                entity.Property(e => e.Wpn1).HasColumnName("wpn1");

                entity.Property(e => e.Wpn2).HasColumnName("wpn2");

                entity.Property(e => e.Wpn3).HasColumnName("wpn3");

                entity.Property(e => e.Wpn4).HasColumnName("wpn4");

                entity.Property(e => e.Wpn5).HasColumnName("wpn5");

                entity.Property(e => e.Wpn6).HasColumnName("wpn6");

                entity.Property(e => e.Wpn7).HasColumnName("wpn7");

                entity.Property(e => e.Xploss).HasColumnName("xploss");

                entity.Property(e => e.Xpshape).HasColumnName("xpshape");

                entity.Property(e => e.Yearturn).HasColumnName("yearturn");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

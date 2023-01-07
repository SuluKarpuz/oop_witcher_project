using Oop_Form_Homework.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop_Form_Homework
{
    public class Geralt : AbstractCharacter, IWitcher
    {
        public override string Name => "Geralt of Rivia";
        public override string Description => "A witcher and monster hunter for hire.";
        public override string SpeakVideoPath => "C:\\Users\\efedi\\source\\repos\\Oop_Form_Homework\\Oop_Form_Homework\\Resources\\geralt_speaking.mp4";
        public override string PicturePath => "C:\\Users\\efedi\\source\\repos\\Oop_Form_Homework\\Oop_Form_Homework\\Resources\\geralt.png";
        public string UseSignPath => "C:\\Users\\efedi\\source\\repos\\Oop_Form_Homework\\Oop_Form_Homework\\Resources\\geralt using sign.mp4";
        public string AttackVideoPath => "C:\\Users\\efedi\\source\\repos\\Oop_Form_Homework\\Oop_Form_Homework\\Resources\\geralt_attck.mp4";
    
    
    
    }

    public class Ciri : Geralt ,ITeleport
    {
        public override string Name => "Ciri";
        public override string Description => "A skilled warrior and member of the royal family of Cintra.";
        public override string SpeakVideoPath => "C:\\Users\\efedi\\source\\repos\\Oop_Form_Homework\\Oop_Form_Homework\\Resources\\ciri speaking.mp4";
        public override string PicturePath => "C:\\Users\\efedi\\source\\repos\\Oop_Form_Homework\\Oop_Form_Homework\\Resources\\ciri.png";
        

        public string teleport => "C:\\Users\\efedi\\source\\repos\\Oop_Form_Homework\\Oop_Form_Homework\\Resources\\ciri teleport.mp4";
    } 
    public class Yennefer : AbstractCharacter, IMage
    {
        public override string Name => "Yennefer of Vengerberg";
        public override string Description => "A powerful and enigmatic sorceress.";
        public override string SpeakVideoPath => "C:\\Users\\efedi\\source\\repos\\Oop_Form_Homework\\Oop_Form_Homework\\Resources\\yeneffer speaking.mp4";
        public override string PicturePath => "C:\\Users\\\\efedi\\\\source\\\\repos\\\\Oop_Form_Homework\\\\Oop_Form_Homework\\\\Resources\\\\yeneffer.png";
        public string UseMagic => "C:\\Users\\efedi\\source\\repos\\Oop_Form_Homework\\Oop_Form_Homework\\Resources\\yeneffer magic.mp4";
        public string MagicPower => "8";
    }
    public class Triss : AbstractCharacter, IMage
    {
        public override string Name => "Triss Merigold";
        public override string Description => "A skilled sorceress and member of the Brotherhood of Sorcerers.";
        public override string SpeakVideoPath => "C:\\Users\\efedi\\source\\repos\\Oop_Form_Homework\\Oop_Form_Homework\\Resources\\triss speaking.mp4";
        public override string PicturePath => "C:\\Users\\efedi\\source\\repos\\Oop_Form_Homework\\Oop_Form_Homework\\Resources\\triss.png";
        public string UseMagic => "C:\\Users\\efedi\\source\\repos\\Oop_Form_Homework\\Oop_Form_Homework\\Resources\\triss magic.mp4";
        public string MagicPower => "6";
    }
}

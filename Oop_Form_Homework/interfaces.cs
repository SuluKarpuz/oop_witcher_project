using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop_Form_Homework
{
    public abstract class AbstractCharacter
    {
        public abstract string Name { get; }
        public abstract string Description { get; }

        public abstract string SpeakVideoPath { get; }

        public abstract string PicturePath { get; }

    }


    public interface IWitcher
    {
        string UseSignPath { get; }
        string AttackVideoPath { get; }

    }

    public interface IMage
    {
        string UseMagic { get; }
        string MagicPower { get; }
    }

    public interface ITeleport
    {
        string teleport { get; }
    }
}

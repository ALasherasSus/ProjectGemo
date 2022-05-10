using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace GemoTale
{
    [DataContract]
    public class Cinematica
    {
        [DataMember] string cs_bg, cs_sound;
        public Cinematica(string cs_bg, string cs_sound)
        {
            this.cs_bg = cs_bg;
            this.cs_sound = cs_sound;
        }
        public string Cs_sound { get => cs_sound; set => cs_sound = value; }
        public string Cs_bg { get => cs_bg; set => cs_bg = value; }
    }
}

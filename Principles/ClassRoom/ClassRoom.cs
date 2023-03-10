using ClassRoom.Pupils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    public class ClassRoomMain
    {
        private static int countofPupil;
        public Pupil[] pupils = new Pupil[4];


        public ClassRoomMain(Pupil pupil1, Pupil pupil2, Pupil pupil3, Pupil pupil4)
        {

            pupils[countofPupil++] = pupil1;
            pupils[countofPupil++] = pupil2;
            pupils[countofPupil++] = pupil3;
            pupils[countofPupil++] = pupil4;


        }

        public int GetCountOfPupils()
        {
            return countofPupil;
        }
    }
}

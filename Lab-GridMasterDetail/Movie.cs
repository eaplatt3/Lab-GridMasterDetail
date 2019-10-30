using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_GridMasterDetail
{
    class Movie
    {
        string mName;
        string mRottenTomatosScore;
        string mReview;

        public string Name
        {
            get
            {
                return mName;
            }

            set
            {
                mName = value;
            }
        }

        public string RottenTomatosScore
        {
            get
            {
                return mRottenTomatosScore;
            }

            set
            {
                mRottenTomatosScore = value;
            }
        }

        public string Review
        {
            get
            {
                return mReview;
            }

            set
            {
                mReview = value;
            }
        }

        public Movie()
        {

        }


        public override string ToString()
        {
            return Name;
        }
    }
}

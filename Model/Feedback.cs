using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Feedback
    {
        public int FeedbackId { get; set; }
        public FeedbackType FeedbackType { get; set; }
        public DateTime FeedbackDateTime { get; set; }
        public Guest Guest { get; set; }
    }
    public enum FeedbackType
    {
        Comments,Complaints,Commendations
    }
}

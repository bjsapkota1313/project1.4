using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using Model;

namespace ServiceLayer
{
    public  class FeedbackService
    {
        FeedbackDAO feedbackDAO;
        public FeedbackService()
        {
            feedbackDAO = new FeedbackDAO();
        }
        public List<Feedback> GetAllFeedback()
        {
            return feedbackDAO.GetAllFeedback() ;
        }
        public void AddComment(string description)
        {
            feedbackDAO.EditFeedback($"INSERT INTO Feedback (Description) VALUES '{description}'");
        }
    }
}

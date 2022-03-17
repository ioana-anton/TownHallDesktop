using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TownHallD.Utils.Constants
{
    public class ErrorMessages
    {
        public const string NO_USERS_ERROR_MESSAGE = "Couldn't find any users.";
        public const string INSERT_DOCUMENT_ERROR_MESSAGE = "Couldn't insert document.";
        public const string DELETE_DOCUMENT_ERROR_MESSAGE = "Couldn't delete document.";

        public const string UPDATE_REQUEST_ERROR_MESSAGE = "Couldn't update request.";
        public const string DELETE_REQUEST_ERROR_MESSAGE = "Couldn't delete request.";
        public const string SELECT_REQUESTS_ERROR_MESSAGE = "Couldn't find requests.";
        public const string T3_REQUESTS_ERROR_MESSAGE = "Already made 3 requests this year.";


        public const string INSERT_HOUSE_ERROR_MESSAGE = "Couldn't insert house.";
        public const string DELETE_HOUSE_ERROR_MESSAGE = "Couldn't delete house.";
        public const string SELECT_HOUSES_ERROR_MESSAGE = "No houses found.";
    }
}

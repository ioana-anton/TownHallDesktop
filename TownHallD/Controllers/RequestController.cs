using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TownHallD.DTO;
using TownHallD.Services;

namespace TownHallD.Controllers
{
    public class RequestController
    {
        private readonly RequestService _requestService;

        public RequestController(RequestService requestService)
        {
            _requestService = requestService;
        }

        public async Task RemoveDocument(RequestDTO request)
        {
            try
            {
                await _requestService.DeleteRequest(request);
            }
            catch (ArgumentNullException ex)
            {
                throw new Exception(Utils.Constants.ErrorMessages.DELETE_REQUEST_ERROR_MESSAGE);
            }

        }

        public async Task<List<RequestDTO>> ShowRequests()
        {
            try
            {
                var res = await _requestService.ShowRequests();

                return res;
            }
            catch (Exception ex)
            {

                throw new Exception(Utils.Constants.ErrorMessages.SELECT_REQUESTS_ERROR_MESSAGE);
            }

        }
    }
}

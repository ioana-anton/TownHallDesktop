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

        public async Task RemoveRequest(RequestDTO request)
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

        public async Task<List<RequestDTO>> ShowSortedRequestsByDate()
        {
            try
            {
                var res = await _requestService.GetSortedRequestsByDate();

                return res;
            }
            catch (Exception ex)
            {
                throw new Exception(Utils.Constants.ErrorMessages.SELECT_REQUESTS_ERROR_MESSAGE);
            }

        }
        public async Task AddRequest(String idUser, String address, String docType)
        {
            try
            {

                await _requestService.InsertRequest(idUser, address, docType);
            }
            catch (ArgumentNullException ex)
            {

                throw new Exception(Utils.Constants.ErrorMessages.INSERT_HOUSE_ERROR_MESSAGE);
            }
        }

        public async Task UpdateRequest(RequestDTO request, String house, String document)
        {
            try
            {

                await _requestService.UpdateRequest(request, house, document);
            }
            catch (ArgumentNullException ex)
            {

                throw new Exception(Utils.Constants.ErrorMessages.UPDATE_REQUEST_ERROR_MESSAGE);
            }
        }

        public async Task UpdateRequestAdmin(RequestDTO request, String state)
        {
            try
            {

                await _requestService.UpdateRequestAdmin(request, state);
            }
            catch (ArgumentNullException ex)
            {

                throw new Exception(Utils.Constants.ErrorMessages.UPDATE_REQUEST_ERROR_MESSAGE);
            }
        }
    }
}

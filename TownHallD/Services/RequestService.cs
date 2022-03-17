using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TownHallD.DTO;
using TownHallD.Entities;
using TownHallD.Repositories;

namespace TownHallD.Services
{
    public class RequestService
    {
        private readonly RequestRepo _requestRepo;
        private readonly IMapper _mapper;

        public RequestService(RequestRepo requestRepo, IMapper mapper)
        {
            _requestRepo = requestRepo;
            _mapper = mapper;
        }

        public async Task DeleteRequest(RequestDTO request)
        {
            if (request == null) throw new ArgumentNullException();
            else
            {
                var req = _mapper.Map<Request>(request);

                await _requestRepo.DeleteRequest(req);
            }

        }

        public async Task<List<RequestDTO>> ShowRequests()
        {
            var reqs = await _requestRepo.GetAllRequests();
            if (reqs == null) throw new ArgumentNullException();
            else
            {

                return _mapper.Map<List<RequestDTO>>(reqs);
            }

        }

        public async Task<List<RequestDTO>> GetSortedRequestsByDate()
        {
            var reqs = await _requestRepo.GetSortedRequestsByDate();
            if (reqs == null) throw new ArgumentNullException();
            else
            {

                return _mapper.Map<List<RequestDTO>>(reqs);
            }

        }


        public async Task InsertRequest(String idUser, String address, String doctype)
        {
            if (idUser == String.Empty) throw new ArgumentNullException();
            else
            {
                var res = new Request();
                Console.WriteLine("Inserting request: " + res.Id);
                try
                {
                    await _requestRepo.InsertNewRequest(res, idUser, address, doctype);
                }
                catch (Exception ex)
                {
                    throw new ArgumentException(Utils.Constants.ErrorMessages.T3_REQUESTS_ERROR_MESSAGE);
                }
            }
        }

        public async Task UpdateRequest(RequestDTO request, String house, String document)
        {
            if ((request.Id == null) || (house == String.Empty) || (document == string.Empty)) throw new ArgumentNullException();
            else
            {

                var req = _mapper.Map<Request>(request);
                await _requestRepo.UpdateRequest(req, house, document);
            }
        }

        public async Task UpdateRequestAdmin(RequestDTO request, String state)
        {
            if ((request.Id == null) || (state == String.Empty)) throw new ArgumentNullException();
            else
            {

                var req = _mapper.Map<Request>(request);
                await _requestRepo.UpdateRequestAdmin(req, state);
            }
        }
    }
}

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
            if (reqs == null) return null;
            else return _mapper.Map<List<RequestDTO>>(reqs);

        }
    }
}

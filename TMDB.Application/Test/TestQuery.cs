using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Common.Application.DbContextInterfaces;

namespace TMDB.Application.Test
{
    public class TestQuery : IRequest<object>
    {
        private sealed class TestQueryHandler : IRequestHandler<TestQuery, object>
        {
            private readonly ITmdbDbContext _context;
            private readonly IMediator _mediator;
            private readonly ILogger _logger;
            //private readonly IMapper _mapper;
            public TestQueryHandler(ITmdbDbContext context, IMediator mediator, ILogger<TestQueryHandler> logger/*, IMapper mapper*/)
            {
                _context = context;
                _mediator = mediator;
                _logger = logger;
                //_mapper = mapper;
            }

            public async Task<object> Handle(TestQuery request, CancellationToken cancellationToken)
            {
                await _context.Movies.ToListAsync(cancellationToken);
                return new { };
            }
        }
    }
}

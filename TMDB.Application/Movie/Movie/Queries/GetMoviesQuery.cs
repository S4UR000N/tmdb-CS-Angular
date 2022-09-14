using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Common.Application.DbContextInterfaces;
using TMDB.Models.Movie;
using TMDB.Models.People;

namespace TMDB.Application.Movie.Movie.Queries
{
    public class GetMoviesQuery : IRequest<List<MovieModel>>
    {
        //[FromQuery(Name = "Id")]
        //public string Id { get; set; }

        //[FromQuery(Name = "Mode")]
        //public string Mode { get; set; }

        //[FromQuery(Name = "PageIndex")]
        //public int? PageIndex { get; set; }

        //[FromQuery(Name = "PageSize")]
        //public int? PageSize { get; set; }
        private sealed class GetMoviesQueryHandler : IRequestHandler<GetMoviesQuery, List<MovieModel>>
        {
            private readonly ITmdbDbContext _context;
            private readonly IMediator _mediator;
            private readonly ILogger _logger;
            //private readonly IMapper _mapper;
            public GetMoviesQueryHandler(ITmdbDbContext context, IMediator mediator, ILogger<GetMoviesQueryHandler> logger/*, IMapper mapper*/)
            {
                _context = context;
                _mediator = mediator;
                _logger = logger;
                //_mapper = mapper;
            }

            public async Task<List<MovieModel>> Handle(GetMoviesQuery request, CancellationToken cancellationToken)
            {
                try
                {
                    var count = _context.Movies.Count();
                    if (count > 0)
                    {
                        await _context.Movies.ToListAsync(cancellationToken);
                    }
                }
                catch
                {
                    var m = new MovieModel();
                    m.PosterPath = "http/Test Poster Path";
                    m.Adult = true;
                    m.Overview = "Test Overview";
                    m.ReleaseDate = "09/12/2022 16:52:55";
                    m.GenreIds.AddRange((new long[] { 1, 2 }).Select(x => x));
                    m.Genres = new List<GenreModel>()
                    {
                        new GenreModel() {
                            Id = 1,
                            Name = "Test Genre One"
                        },
                        new GenreModel() {
                            Id = 2,
                            Name = "Test Genre Two"
                        }
                    };
                    m.Id = 1;
                    m.OriginalTitle = "Test Title";
                    m.OriginalLanguage = "EN";
                    m.Title = "Test Title";
                    m.BackdropPath = "http/Test Backdrop Path";
                    m.Popularity = 5.00F;
                    m.VoteCount = 5;
                    m.Video = false;
                    m.VoteAverage = 5.00F;
                    m.Reviews = new List<ReviewModel>()
                    {
                        new ReviewModel()
                        {
                            Author = "NN",
                            Content = "Some Review Text",
                            CreatedAt = "09 / 12 / 2022 16:52:55",
                            Id = "1",
                            UpdatedAt = "",
                            Url = "url"
                        }
                    };
                    m.Actors = new List<ActorModel>()
                    {
                        new ActorModel()
                        {
                            Adult = false,
                            Gender = 2,
                            Id = 1,
                            KnownForDepartment = "Killer move",
                            Name = "Saitama",
                            OriginalName = "One Punch",
                            Popularity = 1,
                            ProfilePath = "http/Test Path",
                            CastId = 1,
                            Character = "Self",
                            CreditId = "1",
                            Order = 1
                        }
                    };
                    m.Directors = new List<DirectorModel>()
                    {
                        new DirectorModel()
                        {
                            Adult = false,
                            Gender = 2,
                            Id = 1,
                            KnownForDepartment = "Killer move",
                            Name = "Saitama",
                            OriginalName = "One Punch",
                            Popularity = 1,
                            ProfilePath = "http/Test Path",
                            CreditId = "1",
                            Department = "Slave",
                            Job = "Master"
                        }
                    };

                    _context.Movies.Add(m);
                    await _context.SaveChangesAsync(cancellationToken);
                }

                return new List<MovieModel>() { };
                //try
                //{
                //    // Get All
                //    if (request.Id is null && !request.PageIndex.HasValue && !request.PageSize.HasValue)
                //    {
                //        var query = await _context.EmailTemplate.ToListAsync();
                //        var listEmailTemplateDtos = query.Select(emailTemplate => new EmailTemplateDto()
                //        {
                //            Id = emailTemplate.Id,
                //            MessageTypeId = emailTemplate.MessageTypeId,
                //            LanguageCode = emailTemplate.LanguageCode,
                //            BrandId = emailTemplate.BrandId,
                //            BrandName = emailTemplate.BrandName,
                //            EmailTemplateHtml = emailTemplate.EmailTemplateHtml,
                //            MessageSubject = emailTemplate.MessageSubject,
                //            IsValid = emailTemplate.IsValid,
                //        }
                //        ).ToList();
                //        _logger.LogInformation($"SELECT * FROM EmailTemplate; {{200: OK}}");
                //        return listEmailTemplateDtos;
                //    }
                //    // Get one by Id Or Id + Method
                //    else if (request.Id is not null)
                //    {
                //        // Get One by Id
                //        if (string.IsNullOrEmpty(request.Mode))
                //        {
                //            // Query One By Id
                //            var query = await _context.EmailTemplate
                //                .Where(x => x.Id == request.Id)
                //                .Select(x => new EmailTemplateDto()
                //                {
                //                    Id = x.Id,
                //                    MessageTypeId = x.MessageTypeId,
                //                    LanguageCode = x.LanguageCode,
                //                    BrandId = x.BrandId,
                //                    BrandName = x.BrandName,
                //                    EmailTemplateHtml = x.EmailTemplateHtml,
                //                    MessageSubject = x.MessageSubject,
                //                    IsValid = x.IsValid
                //                })
                //                .FirstOrDefaultAsync(cancellationToken)
                //            ;
                //            // Return Error if failed
                //            if (query == null)
                //            {
                //                var errors = new List<string>();
                //                errors.Add("NOT_FOUND");
                //                _logger.LogInformation($"SELECT FROM EmailTemplate WHERE ID = ${request.Id}; {{404: NOT FOUND}}");
                //                return Result.Failure(errors);
                //            }
                //            // Return Response Data
                //            _logger.LogInformation($"SELECT FROM EmailTemplate WHERE ID = ${request.Id}; {{200: OK}}");
                //            return query;
                //        }
                //        // Id + Method
                //        else
                //        {
                //            // Id > Preview
                //            if (request.Mode.Equals("Preview", StringComparison.OrdinalIgnoreCase))
                //            {
                //                // Get Html Template with Subject
                //                var query = await _context.EmailTemplate
                //                    .Where(x => x.Id == request.Id)
                //                    .Select(x => new EmailTemplatePreviewDto()
                //                    {

                //                        MessageSubject = x.MessageSubject,
                //                        EmailTemplateHtml = x.EmailTemplateHtml
                //                    })
                //                    .SingleOrDefaultAsync(cancellationToken)
                //                ;
                //                // Return Error if failed
                //                if (query == null)
                //                {
                //                    var errors = new List<string>();
                //                    errors.Add("NOT_FOUND");
                //                    _logger.LogInformation($"SELECT FROM EmailTemplate WHERE ID = ${request.Id}; {{404: NOT FOUND}}");
                //                    return Result.Failure(errors);
                //                }
                //                // Return Response Data
                //                _logger.LogInformation($"SELECT FROM EmailTemplate WHERE ID = ${request.Id}; {{200: OK}}");
                //                return query;
                //            }
                //            // Id > Edit
                //            else if (request.Mode.Equals("Edit", StringComparison.OrdinalIgnoreCase))
                //            {
                //                // Get Html Template with Message Properties
                //                var query = await _context.EmailTemplate
                //                    .AsNoTracking()
                //                    .Where(x => x.Id.Equals(request.Id))
                //                    .Include(x => x.MessageProperties)
                //                    .SingleOrDefaultAsync(cancellationToken)
                //                ;
                //                // Return Error if failed
                //                if (query == null)
                //                {
                //                    var errors = new List<string>();
                //                    errors.Add("NOT_FOUND");
                //                    _logger.LogInformation($"SELECT FROM EmailTemplate JOIN MessageProperties WHERE ID = ${request.Id}; {{404: NOT FOUND}}");
                //                    return Result.Failure(errors);
                //                }
                //                // Return Response Data
                //                _logger.LogInformation($"SELECT FROM EmailTemplate JOIN MessageProperties WHERE ID = ${request.Id}; {{200: OK}}");
                //                return _mapper.Map<EmailTemplateEditDto>(query);
                //            }
                //            else
                //            {
                //                var errors = new List<string>();
                //                errors.Add("CALL_FOR_NON_EXISTENT_MODE");
                //                _logger.LogError("Database Exception: 400: BAD REQUEST: CALL_FOR_NON_EXISTENT_MODE!");
                //                return Result.Failure(errors);
                //            }
                //        }
                //    }
                //    // Get Paginated list of EmailTemplateDtos, Start: Skip(page * pageSize) -- End: Take(pageSize)
                //    else
                //    {
                //        // if PageIndex/PageSize isn't set. Set default values.
                //        int pageIndex = (request.PageIndex.HasValue && request.PageIndex >= 0) ? request.PageIndex.Value : Math.Abs(request.PageIndex.Value);
                //        int pageSize = (request.PageSize.HasValue && request.PageSize > 0 && request.PageSize <= 50) ? request.PageSize.Value : 10;

                //        // Query DB for Paginated Response and Map it to list of Data Transfer Objects.
                //        var count = await _context.EmailTemplate.AsQueryable().CountAsync(cancellationToken);
                //        var response = _context.EmailTemplate
                //            .AsQueryable()
                //            .Skip(pageIndex * pageSize)
                //            .Take(pageSize)
                //            .Select(emailTemplate => new EmailTemplateDisplayDto() //.ProjectTo<EmailTemplateDisplayDto>(_mapper.ConfigurationProvider)
                //            {
                //                Id = emailTemplate.Id,
                //                LanguageCode = emailTemplate.LanguageCode,
                //                MessageSubject = emailTemplate.MessageSubject,
                //                IsValid = emailTemplate.IsValid
                //            })
                //            .ToListAsync(cancellationToken)
                //        ;
                //        var wrappedResponse = new ResponseWrapperDto<EmailTemplateDisplayDto>()
                //        {
                //            PageIndex = pageIndex,
                //            PageSize = pageSize,
                //            TotalResultCount = count,
                //            ResultList = response.Result
                //        };

                //        // Log with Custom Logger
                //        _logger.LogInformation($"SELECT * FROM table OFFSET 1 LIMIT 50; {{200: OK}}");
                //        return wrappedResponse;
                //    }
                //}
                //catch (Exception e)
                //{
                //    var errors = new List<string>();
                //    errors.Add("500: INTERNAL SERVER ERROR");
                //    _logger.LogError("Database Exception: ", e);
                //    return Result.Failure(errors);
                //    }
            }
        }
    }
}

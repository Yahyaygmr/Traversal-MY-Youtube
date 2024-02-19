using MediatR;
using TraversalCore.CQRS.Results.DestinationResults;
using TraversalCore.CQRS.Results.GuideResults;

namespace TraversalCore.CQRS.Queries.GuideQueries
{
    public class GetAllGuideQuery : IRequest<List<GetAllGuideQueryResult>>
    {
    }
}

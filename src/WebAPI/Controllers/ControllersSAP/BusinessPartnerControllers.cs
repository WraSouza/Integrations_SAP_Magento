

using Application.Queries.QueriesSAP.GetBusinessPartner;
using Domain.DTOs.DTOSAP;
using MediatR;

namespace WebAPI.Controllers.ControllersSAP
{
    public static class BusinessPartnerControllers
    {
        public static RouteGroupBuilder BusinessPartnerEndpoint(this RouteGroupBuilder app)
        {
          //Não será necessário mais tarde. Irá rodar de tempos em tempos com o Coravel.
            app.MapGet("/businesspartner", async (IMediator mediator) =>
            {                   
                   var businessPartner = new GetBusinessPartnerQuery();

                    var newBusinessPartner = await mediator.Send(businessPartner);

                   return Results.Ok(newBusinessPartner);  

            }).Produces<BusinessPartnerDTO>(statusCode: StatusCodes.Status200OK)
              .Produces<BusinessPartnerDTO>(statusCode: StatusCodes.Status400BadRequest)
              .WithName("Get-BusinessPartner-SAP")
              .WithOpenApi();

              return app;
        }
    }
}
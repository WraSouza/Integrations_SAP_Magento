

using Application.Queries.QueriesMagento.GetOrdersMagento;
using MediatR;

namespace WebAPI.Controllers.ControllersMagento
{
    public static class OrdersControllers
    {
        public static RouteGroupBuilder OrdersEndpoint(this RouteGroupBuilder app)
        {
            app.MapGet("/orders", async (IMediator mediator) =>
            {
                var orders = new GetOrdersMagentoQuery();

                var allOrders = await mediator.Send(orders);

                return Results.Ok(allOrders);
            }

            );

            return app;
        }
    }
}
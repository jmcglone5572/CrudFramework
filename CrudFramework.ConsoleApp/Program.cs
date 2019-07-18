using CrudFramework.Contracts;
using CrudFramework.DecoratorClasses;

namespace CrudFramework.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var orderController = CreateOrderController();


            // sample calls. 
            // Note that parameters to each method would have to be valid in a working version.
            // The following is only to test the flow for the various decorators.
            orderController.Create(new Order());
            orderController.Delete(new Order());
            orderController.ReadOne(new System.Guid());
            orderController.ReadAll();
            orderController.Update(new Order());
            orderController.Delete(new Order());
        }
        /// <summary>
        /// Creates a CRUD instance that is fully decorated. Note that the various Order objects
        /// are not fully implemented in this example. In complete implementations, these concrete 
        /// instances would interact with a data store for the various CRUD operations.
        /// </summary>
        /// <returns></returns>
        static ICreateReadUpdateDelete<Order> CreateOrderController()
        {
            var reader = new OrderReader();
            var readCachingReader = new ReadCaching<Order>(reader);

            var saver = new OrderSaver();
            var auditInfoSaver = new AuditInfoSaver();
            var auditingSaver = new SaveAuditing<Order>(saver, auditInfoSaver);

            var deleter = new OrderDeleter();
            var deleteConfirmation = new DeleteConfirmation<Order>(deleter);
            var eventPublisher = new EventPublisher<Order>();
            var deleteEventPublishing = new DeleteEventPublishing<Order>(deleteConfirmation, eventPublisher);

            var orderController = new GenericController<Order>(readCachingReader, auditingSaver, deleteEventPublishing);
            var transactionalOrderController = new CrudTransactional<Order>(orderController);

            var logger = new Logger();
            var orderControllerWithLogging = new CrudLogging<Order>(transactionalOrderController, logger);
            
            return orderControllerWithLogging;
        }
    }

}

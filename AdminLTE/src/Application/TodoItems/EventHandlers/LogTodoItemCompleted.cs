using AdminLTE.Domain.Events;
using Microsoft.Extensions.Logging;

namespace AdminLTE.Application.TodoItems.EventHandlers;
public class LogTodoItemCompleted : INotificationHandler<TodoItemCompletedEvent>
{
    private readonly ILogger<LogTodoItemCompleted> _logger;

    public LogTodoItemCompleted(ILogger<LogTodoItemCompleted> logger)
    {
        _logger = logger;
    }

    public Task Handle(TodoItemCompletedEvent notification, CancellationToken cancellationToken)
    {
        _logger.LogInformation("AdminLTE Domain Event: {DomainEvent}", notification.GetType().Name);

        return Task.CompletedTask;
    }
}

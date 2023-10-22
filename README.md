# SystemIntegrationMP2-Application

This project provides a simple implementation of RabbitMQ producers for sending messages related to Camunda tasks and emails. The producers are designed to serialize the messages into JSON format and send them to specific RabbitMQ queues.

- [CamundaExternalTask](https://github.com/Dare-Share-Care/SystemIntegrationMP2-CamundaExternalTasks)
Sends messages to the camundaExternalTask queue.
- [CamundaTasks](https://github.com/Dare-Share-Care/SystemIntegrationMP2-CamundaTasks)
Sends messages to the camundaTask queue.
- [EmailService](https://github.com/Dare-Share-Care/SystemIntegrationMP2-EmailService)
Sends messages to the emailsQueue queue.

Each producer has a SendMessage<T> method that takes a message of type T, serializes it to JSON, and sends it to the respective RabbitMQ queue.

## Controllers
CamundaController: Provides endpoints to complete Camunda tasks and external tasks. Uses the above producers to send messages.
EmailController: Provides an endpoint to send emails. Uses the EmailProducer to send messages.

## API Endpoints
CamundaController:
- POST /task/complete: Completes a Camunda task.
- POST /external-task/complete: Completes a Camunda external task.

EmailController:
- POST /send: Sends an email.

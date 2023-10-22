# SystemIntegrationMP2-Application
## Authors

- **Frederik Bilgrav Andersen**: cph-fa116@cphbusiness.dk

- **Janus Stivang Rasmussen**: \_-_/

- **Julius Krüger Madsen**: cph-jm352@cphbusiness.dk

The goal of this project was to implement a Customer Complaint Handler using Camunda BPM and EIP. 
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
![Swagger](https://github.com/Dare-Share-Care/SystemIntegrationMP2-Application/blob/main/Docs/swagger.png)

## Camunda BPM Model
![BPM](https://github.com/Dare-Share-Care/SystemIntegrationMP2-Application/blob/main/Docs/CustomerComplains.png)

## EIP Implementation
We have used camunda to model our business process, and then The RabbitMQ queues (camundaExternalTask, camundaTask, and emailsQueue) act as Message Channels. These channels allow our systems to communicate with each other by sending and receiving messages.

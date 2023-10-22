# SystemIntegrationMP2-Application
## Authors

- **Frederik Bilgrav Andersen**: cph-fa116@cphbusiness.dk

- **Janus Stivang Rasmussen**: cph-jr270@cphbusiness.dk

- **Julius Krüger Madsen**: cph-jm352@cphbusiness.dk

## The Application
This application is a program meant for processing and handling customer complaints.

The application makes use of several microservices, these services can be found here:

- [CamundaExternalTask](https://github.com/Dare-Share-Care/SystemIntegrationMP2-CamundaExternalTasks).
- [CamundaTasks](https://github.com/Dare-Share-Care/SystemIntegrationMP2-CamundaTasks)
- [EmailService](https://github.com/Dare-Share-Care/SystemIntegrationMP2-EmailService)


## Controllers
CamundaController: Provides endpoints to complete Camunda tasks and external tasks. Uses the above producers to send messages.
EmailController: Provides an endpoint to send emails. Uses the EmailProducer to send messages.

## API Endpoints
![Swagger](https://github.com/Dare-Share-Care/SystemIntegrationMP2-Application/blob/main/Docs/swagger.png)

## Camunda BPM Model
![BPM](https://github.com/Dare-Share-Care/SystemIntegrationMP2-Application/blob/main/Docs/CustomerComplains.png)

## EIP Implementation
We have used camunda to model our business process, and then The RabbitMQ queues (camundaExternalTask, camundaTask, and emailsQueue) act as Message Channels. These channels allow our systems to communicate with each other by sending and receiving messages.
- Process Manager
  We have used camunda to model our business process. When deployed, tasks are then completed using CamundaAPI implemented as seperate services.

- Producer/Subscriber
  We use rabbit as our Message Broker. This allows us to integrate services using message queues by forwarding and accepting messages between the producer and subscriber applications

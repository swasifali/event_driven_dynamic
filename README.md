# Sample app using NServiceBus/EDA and loosely coupled messages

## Step to run
 - Clone the repository
 - Set the following projects as startup projects:
    - ClientUI
    - Sales
    - Billing
 - Run / Start debugging
 - Click the "Place Order" button on the launched browser window to send / publish messages
 
 # What it covers
 
 The code is based on the NServiceBus quickstart tutorial available for download [here](https://docs.particular.net/tutorials/quickstart/)

 Both NServiceBus and MassTransit require contracts to be shared between producers and consumers, including the full namespace.
 Some further discussion on this issue is available at:
 
  - https://stackoverflow.com/questions/52477283/masstransit-consume-equal-objects-defined-in-different-namespaces?rq=1
  - https://stackoverflow.com/questions/55147202/masstransit-patterns-and-practices-with-contract-classes
  - https://stackoverflow.com/questions/30739851/how-can-microservices-be-truly-independent-when-using-an-esb-i-e-masstransit
  - https://stackoverflow.com/questions/44368550/why-interfaces-for-message-contracts-are-strongly-recommended-in-masstransit
  - https://docs.particular.net/nservicebus/messaging/evolving-contracts
  - https://groups.google.com/forum/#!topic/particularsoftware/l1msW10KJfI

This code is modified to show the usage of a generic message as message contracts and avoid sharing libraries / common classes as contracts.

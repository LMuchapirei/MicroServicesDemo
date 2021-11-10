What is docker 

Docker is a containerization platform meaning that it enables you to package your applications into images and run them as containers on any platform that can run Docker

create a Dockerfile giving docker instructions on how to build the app and run it as a container in docker
specify stuff like ports etc

Dockerfile  -->  Docker Engine  --> Docker Image


docker ps gets us list of running containers

we get the id and we can use it to start or stop the container
docker start/stop container ID
we do the other command again
docker run -p 8080:80 -d linvle2/platformservice   will spin another container rather than restart the one we stopped

dont do docker push here rather try it with network access
push the container and start on the kubernetes stuff



Wait ! What if l mark http actions as Async?
```
[HttpPost]
public async Task<ActionResult<PlatformReadDto>> CreatePlatform(...args)
{
    ....
}
```
From a messaging perspective this method is still synchronous
The client still has to wait for a response
Async in this context (the C# language) means that the action will not wait for a long running operation
It will hand back its thread to the thread pool, where it can be reused
When the operation finishes it will re-acquire a thread and complete 
So Async here is about thread exhaustion- the requester still has to wait (the call is synchronous)


Asynchronous Messaging

No Request / Response Cycle
Requester does not wait
Event model eg publish -subscribe
Typically used between services
Event bus is often used (RabbitMQ)
Services dont need to know about each other , just the bus


continue @4:19:14
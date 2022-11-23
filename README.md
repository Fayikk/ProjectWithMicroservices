                               RUN THE PROJECT                           Author = FAYİK VEZNEDAROĞLU


![110304529-c5b70180-800c-11eb-832b-a2751b5bda76](https://user-images.githubusercontent.com/108293938/203602001-cdf6df99-6a02-4da0-8898-bc76fbe59829.png)

You will need the following tools:

Visual Studio 2019-2022 Comunity 
.Net Core 5 or later
Docker Desktop
Installing
Follow these steps to get your development environment set up: (Before Run Start the Docker Desktop)

Clone the repository
Once Docker for Windows is installed, go to the Settings > Advanced option, from the Docker icon in the system tray, to configure the minimum amount of memory and CPU like so:
Memory: 4 GB
CPU: 2

At the root directory which include docker-compose.yml files, run below command:

docker-compose -f docker-compose.yml -f docker-compose.override.yml up -d

Wait for docker compose all microservices. That’s it! (some microservices need extra time to work so please wait if not worked in first shut)

if you want take this project,just "docker-compose -f docker-compose.yml -f docker-compose.override.yml Kill" and "docker-compose -f docker-compose.yml -f 

docker-compose.override.yml restart" do it.It is enough for this work.

You can launch microservices as below urls:

You can launch microservices as below urls:

Catalog API -> http://host.docker.internal:8000/swagger/index.html

Basket API -> http://host.docker.internal:8001/swagger/index.html

Discount API -> http://host.docker.internal:8002/swagger/index.html

Ordering API -> http://host.docker.internal:8004/swagger/index.html

Shopping.Aggregator -> http://host.docker.internal:8005/swagger/index.html

API Gateway -> http://host.docker.internal:8010/Catalog

Rabbit Management Dashboard -> http://host.docker.internal:15672 -- guest/guest

Portainer -> http://host.docker.internal:9000 -- admin/admin1234

pgAdmin PostgreSQL -> http://host.docker.internal:5050 -- admin@aspnetrun.com/admin1234






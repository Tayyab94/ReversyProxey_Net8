# Reverse Proxy

This repository contains a C# .NET Core application configured as a reverse proxy using YARP. It routes traffic to multiple instances of Order and User APIs.

## Project Structure
* **[Project Directory]:** Contains the main project files.
* **appsettings.json:** Configuration file for the reverse proxy, including routes, clusters, and destinations.

## Prerequisites
* .NET Core SDK
* YARP package installed

## Getting Started
1. Clone the repository:
   ```bash
   git clone [https://github.com/your-username/your-repository.git](https://github.com/your-username/your-repository.git)

cd your-repository
dotnet restore


dotnet run


Configuration
The appsettings.json file contains the configuration for the reverse proxy. You can modify it to add or remove routes, clusters, and destinations.

Routes
orderRoute: Routes requests to the Order API.
userRoute: Routes requests to the User API.
Clusters
orders: Contains a list of Order API instances.
users: Contains a list of User API instances.

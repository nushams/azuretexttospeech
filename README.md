# Azure AI Text-to-Speech App

This application utilizes the Azure AI SDK for text-to-speech functionality. It is a basic .NET script that connects to an Azure subscription to synthesize speech from text.

## Table of Contents

- [Overview](#overview)
- [Features](#features)
- [Prerequisites](#prerequisites)
- [Setup](#setup)
- [Usage](#usage)
- [Configuration](#configuration)
- [Contributing](#contributing)

## Overview

The Azure AI Text-to-Speech App is a simple .NET application that converts text into spoken words using Azure Cognitive Services. The app connects to your Azure subscription and uses the provided resource ID and region to access the text-to-speech service.

## Features

- Converts text to speech using Azure Cognitive Services.
- Easy configuration with Azure subscription details.
- Outputs synthesized speech in real-time.

## Prerequisites

- .NET SDK installed on your machine.
- An active Azure subscription with Cognitive Services enabled.
- Azure AI SDK installed via NuGet.

## Setup

### Azure Subscription

1. **Create an Azure Cognitive Services Resource**:
   - Sign in to the [Azure portal](https://portal.azure.com/).
   - Create a new resource of type "Cognitive Services".
   - Note the **Resource ID** and **Region** of your Cognitive Services resource.

### Clone the Repository

1. Clone this repository to your local machine:
   ```sh
   git clone https://github.com/nushams/azuretexttospeech.git
   cd azuretexttospeech
   ```

### Install Dependencies

1. Install the necessary NuGet packages:
   ```sh
   dotnet add package Microsoft.CognitiveServices.Speech
   ```

## Usage

### Configure the Script

1. Open the `Program.cs` file and update the `SpeechConfig.FromSubscription` method with your Azure Cognitive Services **Subscription Key** and **Region**:
   ```csharp
   var config = SpeechConfig.FromSubscription("YourSubscriptionKey", "YourRegion");
   ```

### Run the Application

1. Run the .NET application:
   ```sh
   dotnet run
   ```

2. The application will output synthesized speech for the provided text:
   ```
   Hi, I am neural text to speech from Azure AI. I warmly welcome Google Dev Fest participants in December 2023!
   ```

## Configuration

### Azure Configuration

- **Subscription Key**: Obtain this from your Azure Cognitive Services resource.
- **Region**: The region where your Azure Cognitive Services resource is deployed (e.g., `eastus`, `westus`).

### Application Configuration

In the `Program.cs` file:
```csharp
var config = SpeechConfig.FromSubscription("YourSubscriptionKey", "YourRegion");
```

## Contributing

We welcome contributions! Please follow these steps:

1. Fork the repository.
2. Create a new branch (`git checkout -b feature/your-feature`).
3. Make your changes and commit them (`git commit -m 'Add some feature'`).
4. Push to the branch (`git push origin feature/your-feature`).
5. Open a Pull Request.

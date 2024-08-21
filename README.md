# .NET Practice Repository

![License](https://img.shields.io/badge/license-MIT-blue.svg)

## Description

This repository is a practice project for exploring and learning .NET technologies. The project includes a basic ToDo application that demonstrates core .NET features such as building a web API, working with data models, and handling HTTP requests.

## Features

- **Basic CRUD Operations**: Create, read, update, and delete tasks.
- **Custom ID Generation**: Demonstrates generating unique integer IDs for tasks.
- **.NET Fundamentals**: Practice with .NET project structure, dependency management, and build processes.

## Installation

### Prerequisites

- [.NET SDK](https://dotnet.microsoft.com/download) (version 6.0 or later)

### Getting Started

1. **Clone the repository:**

    ```sh
    git clone https://github.com/nikolaysm/dotnet-practice-repo.git
    ```

2. **Navigate to the project directory:**

    ```sh
    cd dotnet-practice-repo
    ```

3. **Restore dependencies:**

    ```sh
    dotnet restore
    ```

4. **Build the project:**

    ```sh
    dotnet build
    ```

5. **Run the application:**

    ```sh
    dotnet run
    ```

   - By default, the application will run on `http://localhost:5000`.

## Usage

This project is a practice tool, so the usage involves running and experimenting with the application. You can interact with the API using tools like [Postman](https://www.postman.com/) or [curl](https://curl.se/).

### Example API Endpoints

- **GET /tasks**: Retrieve the list of tasks.
- **POST /tasks**: Create a new task.
- **PUT /tasks/{id}**: Update an existing task.
- **DELETE /tasks/{id}**: Delete a task.

## Learning Objectives

- **Understanding .NET Project Structure**: Learn how to set up and manage a .NET project.
- **Working with Data Models**: Practice defining and using data models in .NET.
- **Handling HTTP Requests**: Get familiar with creating and processing HTTP requests.

## Contributing

As this is a practice project, contributions are not required, but you are welcome to fork the repository, experiment with the code, and submit pull requests if you make improvements or additional features.

1. Fork the repository.
2. Create a new branch (`git checkout -b feature-branch`).
3. Commit your changes (`git commit -am 'Add new feature'`).
4. Push the branch (`git push origin feature-branch`).
5. Create a Pull Request.

## License

This project is licensed under the MIT License. See the [LICENSE](LICENSE) file for details.

## Acknowledgements

- .NET for providing a powerful framework for building applications.
- Online tutorials and documentation that helped in learning .NET concepts.


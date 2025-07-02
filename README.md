# IndieGameZone_Backend

![.NET 8](https://img.shields.io/badge/.NET-8-512BD4?logo=dotnet)
![.NET Aspire](https://img.shields.io/badge/.NET_Aspire-✓-512BD4?logo=dotnet)
![Docker](https://img.shields.io/badge/Docker-✓-2496ED?logo=docker)
![EF Core](https://img.shields.io/badge/EF_Core-✓-512BD4)
![JWT](https://img.shields.io/badge/JWT-Auth-yellow)
![License](https://img.shields.io/badge/License-MIT-green)

A modern, scalable backend API for indie game distribution platforms (inspired by itch.io), built with **.NET 8** and **.NET Aspire**.

## 🚀 Features

- **Onion Architecture** with separated layers:
  - `Domain` (Domain models)
  - `Infrastructure` (Repositories, DbContext)
  - `Service` (Business logic)
  - `API` (REST endpoints)
- **Docker** container support
- Repository Pattern + Unit of Work
- JWT Authentication

## 📂 Solution Structure

IndieGameZone_Backend/ <br>
├── IndieGameZone.API/ # Web API (Entry Point) <br>
├── IndieGameZone.Domain/ # Domain Models/Entities <br>
├── IndieGameZone.Infrastructure/ # Data Access (EF Core) <br>
├── IndieGameZone.Service/ # Business Logic <br>

## 🛠️ Prerequisites

- [.NET 8 SDK](https://dotnet.microsoft.com/download)
- [Docker Desktop](https://www.docker.com/products/docker-desktop) (optional)
- IDE (VS 2022+, VS Code, or Rider)

## 🏃 Getting Started

1. **Clone the repo**:
   ```bash
   git clone https://github.com/your-username/IndieGameZone_Backend.git
   ```
2. **Run with .NET Aspire**:
   ```bash
   cd IndieGameZone_Backend
   dotnet run --project IndieGameZone.AppHost
   ```
   Access the Aspire dashboard at `http://localhost:18888`
4. **Docker(optional)**:
   ```bash
   docker build -t indiegamezone-api -f IndieGameZone.API/Dockerfile .
   docker run -p 8080:80 indiegamezone-api
   ```
   
## 📜 License

[MIT License](LICENSE) - See the license file for full details.

## 🤝 Contributing

We welcome contributions! Please follow these guidelines:

1. **Fork** the repository
2. Create a **feature branch** (`git checkout -b feature/your-feature`)
3. **Commit** your changes (`git commit -m 'Add some feature'`)
4. **Push** to the branch (`git push origin feature/your-feature`)
5. Open a **Pull Request**

**Coding Standards:**
- Follow Clean Architecture principles
- Keep commits atomic and well-described
- Document new endpoints and services

## 👥 Development Team

| Student ID   | Name                  | Role                                 | Responsibilities                      |
|--------------|-----------------------|--------------------------------------|---------------------------------------|
| SE173551     | Trần Minh Tâm         | Backend & Database Architect	      | API Development, Architecture         |
| SE184706     | Nguyễn Lê Tấn Nghiệp  | DevOps & Backend Dev	               | API Development, Architecture         |
| SE173305     | Lê Văn Hoàng Vũ       | Frontend Developer                   | Design UI/UX and build frontend page  |
| SE173222     | Ngô Gia Huy           | Frontend Developer                   | Design UI/UX and build frontend page  |

## 🔗 Related Links
- [📋 Project Board](https://github.com/orgs/IndieGameZone/projects?query=is%3Aopen)
- [🐛 Issue Tracker](https://github.com/IndieGameZone/IndieGameZone_Backend/issues)
- [📈 Insight](https://github.com/IndieGameZone/IndieGameZone_Backend/network/dependencies)
- [Backend Deploy Link](https://indiegamezonese101.azurewebsites.net/swagger) 
- [Frontend Deploy Link](https://indie-game-zone.vercel.app)

---

Built with ❤️ by **IndieGameZone Team**  
📧 Contact: [team@indiegamezone.dev](mailto:team@indiegamezone.dev)

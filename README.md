# Swiss Registre IDE@OFS API Client Library

| Maintenability | Tests | Coverage |
| :---: | :----: | :------: | 
| ![Static Badge](https://img.shields.io/badge/Maintenability-91%25-green) | ![Unit tests](https://img.shields.io/github/actions/workflow/status/anthonychaussin/AdminChWrapper/dotnet.yml) | ![Static Badge](https://img.shields.io/badge/Coverage-87.5%25-green)|

## Description

The **AdminChWrapper** is a .NET C# library designed to simplify the interaction with the Swiss Registre IDE@OFS API. This library provides an easy-to-use interface to access and manage commercial registry data.

## Features

- Easy integration with the Swiss Commercial Registry API.
- Comprehensive error handling.
- Asynchronous operations support.
- Well-documented methods and classes.
- Example usage and tests included.

## Getting Started
Here is a basic example to get you started with the Swiss Commercial Registry API Client Library:

```.net
using SwissCommercialRegistryApiClient;
using System.Threading.Tasks;

class Program
{
    static async Task Main(string[] args)
    {
        var companyInfo = new SearchApi().VatSearch<Company>("CHE-123.456.789");
        Console.WriteLine($"Company Name: {companyInfo.Name}");
        Console.WriteLine($"Address: {companyInfo.Address}");
    }
}
```
## Documentation
The full documentation can be found [here](https://www.bfs.admin.ch/bfs/fr/home/registres/registre-entreprises/numero-identification-entreprises/registre-ide/interfaces-ide.assetdetail.24605174.html).

## Contributing
Contributions are welcome! Please read the contributing guidelines for more details.

 - Fork the repository.
 - Create a feature branch (git checkout -b feature/AmazingFeature).
 - Commit your changes (git commit -m 'Add some AmazingFeature').
 - Push to the branch (git push origin feature/AmazingFeature).
 - Open a pull request.

## License
This project is licensed under the MIT License - see the LICENSE file for details.

## Acknowledgements
Thanks to the Confédération Suisse for providing the API.